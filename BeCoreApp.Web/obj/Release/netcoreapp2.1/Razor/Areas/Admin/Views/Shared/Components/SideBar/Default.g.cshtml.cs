#pragma checksum "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ded3fabd6cf73b39f525ae6260d70c8962bbee4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_SideBar_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_Components_SideBar_Default))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp;

#line default
#line hidden
#line 3 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Models;

#line default
#line hidden
#line 4 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Models.ManageViewModels;

#line default
#line hidden
#line 6 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Application.ViewModels.System;

#line default
#line hidden
#line 7 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Application.ViewModels.BlockChain;

#line default
#line hidden
#line 8 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Application.ViewModels.Valuesshare;

#line default
#line hidden
#line 9 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Data.Entities;

#line default
#line hidden
#line 3 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded3fabd6cf73b39f525ae6260d70c8962bbee4a", @"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68994ac50316bb5bc7adb5dd726610ea311dbfdf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_SideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
  
    var url = Context.Request.GetEncodedUrl();

#line default
#line hidden
#line 7 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
            BeginContext(162, 14, false);
#line 9 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
Write(Html.Raw(item));

#line default
#line hidden
            EndContext();
#line 9 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                   
}

#line default
#line hidden
            BeginContext(181, 316, true);
            WriteLiteral(@"
<style>
    .liCustomerName {
        background: linear-gradient(45deg, #ff3d00, #FFC107);
        box-shadow: 0px 0px 8px 2px #FF9800;
    }

    .spanCustomerName {
        color: white !important;
        font-weight: bold !important;
        text-transform: uppercase !important;
    }
</style>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
