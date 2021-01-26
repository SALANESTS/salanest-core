using System;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.HdWallet;
using Nethereum.Web3.Accounts;
using Nethereum.Util;
using Nethereum.Hex.HexConvertors.Extensions;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;

namespace MinerEthereum
{
    class Program
    {
        static Dictionary<string, decimal> etherAccounts = new Dictionary<string, decimal>();
        static void Main(string[] args)
        {
            etherAccounts = new Dictionary<string, decimal>();

            List<Account> etherAccountGenerals = new List<Account>();

            Console.Write("Vui long nhap so may dao: ");

            bool isNumber = int.TryParse(Console.ReadLine(), out int numberAccount);

            if (isNumber)
            {
                Console.WriteLine("\nHe thong dang tao ra {0} may dao. Xin vui long doi...", numberAccount);

                for (int i = 0; i < numberAccount; i++)
                {
                    var ethAcc = CreateEthereumAccount();
                    etherAccountGenerals.Add(ethAcc);

                    Console.WriteLine("\n- May: {0} \n==> Khoa Bi Mat: {1}  \n==> Khoa Cong Khai: {2}", i, ethAcc.PrivateKey, ethAcc.Address);
                }

                Console.WriteLine("\n======================================================================>");
                Console.WriteLine("\n======================================================================>");
                Console.WriteLine($"\nBat dau qua trinh {etherAccountGenerals.Count()} dao ethereum. Xin vui long doi...");

                for (int i = 0; i < etherAccountGenerals.Count(); i++)
                {
                    var ethAcc = etherAccountGenerals[i];
                    Console.WriteLine("\n- May: {0} \n==> Khoa Bi Mat: {1}  \n==> Khoa Cong Khai: {2}", i, ethAcc.PrivateKey, ethAcc.Address);

                    string prkeySub = ethAcc.PrivateKey.Substring(2);

                    for (int j = 0; j < 50; j++)
                    {
                        string prKeyLogin = ShortStringRandom(prkeySub);
                        GetBalance(j, prKeyLogin).Wait(10000);
                    }
                }

                Console.WriteLine("\n======================================================================>");
                Console.WriteLine("\n======================================================================>");
                Console.WriteLine($"\nSo May Dao Duoc Ethereum la: {etherAccounts.Count()}");
                foreach (var itemAccount in etherAccounts)
                {
                    Console.WriteLine("\n==> Khoa Bi Mat: {0}  \n==> So Ether: {1}", itemAccount.Key, itemAccount.Value);
                }

                Console.WriteLine("\nQua Trinh Dao Ethereum Ket Thuc. Thank You =))");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nVui long nhap so lon hon 0 !!!!");
                Console.ReadKey();
            }
        }

        static async Task GetBalance(int index, string prKey)
        {
            try
            {
                Console.WriteLine($"{index} - Khoa Bi Mat: {prKey}");
                var account = new Account(prKey);

                var web3 = new Web3(account, "https://mainnet.infura.io/v3/223d692d4fd14f38ad5f223437a5ca9b");

                var balance = await web3.Eth.GetBalance.SendRequestAsync(account.Address);

                var balanceEther = Web3.Convert.FromWei(balance.Value);

                Console.WriteLine("Khoa Bi Mat: {0} - So Ether: {1} Ether", prKey, balanceEther);

                if (balanceEther > 0)
                {
                    etherAccounts.Add(prKey, balanceEther);
                }
            }
            catch (Exception ex)
            {
            }
        }

        static string ShortStringRandom(string valueRandom)
        {
            Random r = new Random();

            string random = new string(valueRandom.ToCharArray().OrderBy(s => (r.Next(2) % 2) == 0).ToArray());

            return random;
        }

        static Account CreateEthereumAccount()
        {
            var ecKey = Nethereum.Signer.EthECKey.GenerateKey();
            var privateKey = ecKey.GetPrivateKeyAsBytes().ToHex();
            var account = new Account(privateKey);
            return account;
        }
    }
}
