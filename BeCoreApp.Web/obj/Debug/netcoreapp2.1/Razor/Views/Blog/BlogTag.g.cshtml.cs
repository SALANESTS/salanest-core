#pragma checksum "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4abcbfe01ad62d805ada0728ea38c5462577eafe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogTag), @"mvc.1.0.view", @"/Views/Blog/BlogTag.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/BlogTag.cshtml", typeof(AspNetCore.Views_Blog_BlogTag))]
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
#line 1 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\_ViewImports.cshtml"
using BeCoreApp.Extensions;

#line default
#line hidden
#line 3 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\_ViewImports.cshtml"
using BeCoreApp.Models;

#line default
#line hidden
#line 4 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\_ViewImports.cshtml"
using BeCoreApp.Application.ViewModels.Product;

#line default
#line hidden
#line 5 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\_ViewImports.cshtml"
using BeCoreApp.Application.ViewModels.Blog;

#line default
#line hidden
#line 6 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\_ViewImports.cshtml"
using BeCoreApp.Models.AccountViewModels;

#line default
#line hidden
#line 7 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\_ViewImports.cshtml"
using BeCoreApp.Models.ManageViewModels;

#line default
#line hidden
#line 8 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\_ViewImports.cshtml"
using BeCoreApp.Data.Entities;

#line default
#line hidden
#line 9 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4abcbfe01ad62d805ada0728ea38c5462577eafe", @"/Views/Blog/BlogTag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e9687c970b0a85b48325f199cadb19b9d1a74bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogTag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BeCoreApp.Models.BlogViewModels.CatalogViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
  
    ViewData["Title"] = Model.Data.CurrentPage == 1 ? Model.Tag.Name : Model.Tag.Name + " - Page " + Model.Data.CurrentPage;
    ViewData["MetaKeyword"] = Model.Data.CurrentPage == 1 ? Model.Tag.Name : Model.Tag.Name + " - Page " + Model.Data.CurrentPage;
    ViewData["MetaDescription"] = Model.Data.CurrentPage == 1 ? Model.Tag.Name : Model.Tag.Name + " - Page " + Model.Data.CurrentPage;

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(475, 184, true);
                WriteLiteral("\r\n    <script async defer crossorigin=\"anonymous\"\r\n            src=\"https://connect.facebook.net/vi_VN/sdk.js#xfbml=1&version=v6.0&appId=269628317070073&autoLogAppEvents=1\"></script>\r\n");
                EndContext();
            }
            );
            BeginContext(662, 375, true);
            WriteLiteral(@"<div class=""app-content"">
    <div class=""container"">
        <!-- Page-header opened -->
        <div class=""page-header"">
            <!--  row opened -->
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""#""><i class=""ti-home mr-1""></i> Trang Chủ</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">");
            EndContext();
            BeginContext(1038, 14, false);
#line 18 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                                                  Write(Model.Tag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1052, 499, true);
            WriteLiteral(@"</li>
            </ol>
            <!--  row closed -->
        </div>
        <!-- Page-header closed -->
        <div class=""row"">
            <div class=""col-xl-9 col-lg-12 col-md-12"">
                <!--Add lists-->
                <div class=""mb-lg-0"">
                    <div class="""">
                        <div class=""item2-gl "">
                            <div class=""item2-gl-nav bg-white d-flex ml-1 mr-1"">
                                <h6 class=""mb-0 mt-2"">Hiển thị ");
            EndContext();
            BeginContext(1552, 19, false);
#line 30 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                                          Write(Model.Data.RowCount);

#line default
#line hidden
            EndContext();
            BeginContext(1571, 1045, true);
            WriteLiteral(@" bài viết</h6>
                                <ul class=""nav item2-gl-menu ml-auto"">
                                    <li>
                                        <a href=""#tab-11"" class=""active show"" data-toggle=""tab"" title=""Grid"">
                                            <i class=""fa fa-th""></i>
                                        </a>
                                    </li>
                                    <li class="""">
                                        <a href=""#tab-12"" class="""" data-toggle=""tab"" title=""List style"">
                                            <i class=""fa fa-list""></i>
                                        </a>
                                    </li>

                                </ul>
                                <div class=""d-flex"">
                                    <label class=""mr-2 mt-1 mb-sm-1"">Sắp xếp:</label>
                                    <select name=""item"" class=""form-control mb-0 nice-select-md w-170"">
                   ");
            WriteLiteral("                     ");
            EndContext();
            BeginContext(2616, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c9a56e66460435ab0487c97592d445a", async() => {
                BeginContext(2634, 8, true);
                WriteLiteral("Mới nhất");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2651, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2693, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc1ec2c8222c441ab3fedfe51bf16b50", async() => {
                BeginContext(2711, 7, true);
                WriteLiteral("Cũ nhất");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2727, 1011, true);
            WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                            <script async src=""https://pagead2.googlesyndication.com/pagead/js/adsbygoogle.js""></script>
                            <!-- qc1 -->
                            <ins class=""adsbygoogle""
                                 style=""display:block""
                                 data-ad-client=""ca-pub-1035335846577046""
                                 data-ad-slot=""8117801273""
                                 data-ad-format=""auto""
                                 data-full-width-responsive=""true""></ins>
                            <script>
                                (adsbygoogle = window.adsbygoogle || []).push({});
                            </script>
                            <div class=""tab-content"">
                                <div class=""tab-pane active"" id=""tab-11"">
                                    <div class=""row"">
");
            EndContext();
#line 66 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                         foreach (var blog in Model.Data.Results)
                                        {
                                            var blogDetailUrl = $"/{blog.SeoAlias}-b.{blog.Id}.html";

#line default
#line hidden
            BeginContext(3967, 402, true);
            WriteLiteral(@"                                            <div class=""col-lg-6 col-md-12 col-xl-4"">
                                                <div class=""card overflow-hidden"">
                                                    <div class=""item-card9-img"">
                                                        <div class=""item-card9-imgs"">
                                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4369, "\"", 4390, 1);
#line 73 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
WriteAttributeValue("", 4376, blogDetailUrl, 4376, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4391, 71, true);
            WriteLiteral("></a>\r\n                                                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4462, "\"", 4479, 1);
#line 74 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
WriteAttributeValue("", 4468, blog.Image, 4468, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4480, 384, true);
            WriteLiteral(@" alt=""img"" class=""cover-image h-230"">
                                                        </div>
                                                    </div>
                                                    <div class=""card-body"">
                                                        <div class=""item-card9"">
                                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4864, "\"", 4885, 1);
#line 79 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
WriteAttributeValue("", 4871, blogDetailUrl, 4871, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4886, 67, true);
            WriteLiteral(" class=\" mt-2 leading-tight\"><h4 class=\"font-weight-semibold mt-1\">");
            EndContext();
            BeginContext(4954, 9, false);
#line 79 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                                                                                                                                  Write(blog.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4963, 265, true);
            WriteLiteral(@"</h4></a>
                                                            <div class=""item-card9-desc mb-1"">
                                                                <a href=""#"" class=""mr-1""><span class=""fs-13""><i class=""fa fa-calendar-o text-muted mr-1""></i> ");
            EndContext();
            BeginContext(5229, 40, false);
#line 81 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                                                                                                                                         Write(blog.DateModified.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(5269, 140, true);
            WriteLiteral("</span></a>\r\n                                                                <a href=\"#\"><span class=\"fs-13\"><i class=\"fa fa-bullseye\"></i> ");
            EndContext();
            BeginContext(5410, 21, false);
#line 82 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                                                                                                          Write(blog.BlogCategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(5431, 166, true);
            WriteLiteral("</span></a>\r\n                                                            </div>\r\n                                                            <p class=\"leading-tight\">");
            EndContext();
            BeginContext(5598, 16, false);
#line 84 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                                                                Write(blog.Description);

#line default
#line hidden
            EndContext();
            BeginContext(5614, 809, true);
            WriteLiteral(@"</p>
                                                        </div>
                                                    </div>
                                                    <div class=""card-footer"">
                                                        <div class=""item2-icons d-flex"">
                                                            <a href=""#"" class=""mr-3""><span class=""text-muted""><i class=""fa fa-comment-o text-muted""></i> 45 comments</span></a>
                                                            <a href=""#"" class=""mr-3""><span class=""ml-1 text-muted""><i class=""fa fa-thumbs-o-up text-muted""></i> 56 likes</span></a>
                                                            <a href=""#"" class=""mr-3""><span class=""ml-1 text-muted""><i class=""fa fa-eye text-muted""></i> ");
            EndContext();
            BeginContext(6424, 14, false);
#line 91 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                                                                                                                                   Write(blog.ViewCount);

#line default
#line hidden
            EndContext();
            BeginContext(6438, 253, true);
            WriteLiteral(" views</span></a>\r\n                                                        </div>\r\n                                                    </div>\r\n\r\n                                                </div>\r\n                                            </div>\r\n");
            EndContext();
#line 97 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                        }

#line default
#line hidden
            BeginContext(6734, 154, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"tab-pane\" id=\"tab-12\">\r\n");
            EndContext();
#line 102 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                     foreach (var blog in Model.Data.Results)
                                    {
                                        var blogDetailUrl = $"/{blog.SeoAlias}-b.{blog.Id}.html";

#line default
#line hidden
            BeginContext(7105, 364, true);
            WriteLiteral(@"                                        <div class=""card overflow-hidden"">
                                            <div class=""d-md-flex"">
                                                <div class=""item-card9-img"">
                                                    <div class=""item-card9-imgs"">
                                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7469, "\"", 7490, 1);
#line 109 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
WriteAttributeValue("", 7476, blogDetailUrl, 7476, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7491, 67, true);
            WriteLiteral("></a>\r\n                                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 7558, "\"", 7575, 1);
#line 110 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
WriteAttributeValue("", 7564, blog.Image, 7564, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7576, 467, true);
            WriteLiteral(@" alt=""img"" class=""cover-image w-400px h-200"">
                                                    </div>
                                                </div>
                                                <div class=""card mb-0 border-0"">
                                                    <div class=""card-body "">
                                                        <div class=""item-card9"">
                                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8043, "\"", 8064, 1);
#line 116 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
WriteAttributeValue("", 8050, blogDetailUrl, 8050, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8065, 48, true);
            WriteLiteral(" class=\"\"><h4 class=\"font-weight-semibold mt-1\">");
            EndContext();
            BeginContext(8114, 9, false);
#line 116 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                                                                                                               Write(blog.Name);

#line default
#line hidden
            EndContext();
            BeginContext(8123, 266, true);
            WriteLiteral(@" </h4></a>
                                                            <div class=""item-card9-desc mb-1"">
                                                                <a href=""#"" class=""mr-4""><span class=""fs-13""><i class=""fa fa-calendar-o text-muted mr-1""></i> ");
            EndContext();
            BeginContext(8390, 40, false);
#line 118 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                                                                                                                                         Write(blog.DateModified.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(8430, 109, true);
            WriteLiteral("</span></a>\r\n                                                                <a href=\"#\"><span class=\"fs-13\">");
            EndContext();
            BeginContext(8540, 21, false);
#line 119 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                                                                           Write(blog.BlogCategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(8561, 237, true);
            WriteLiteral("</span></a>\r\n                                                            </div>\r\n                                                            <p class=\"mb-0 leading-tight\">\r\n                                                                ");
            EndContext();
            BeginContext(8799, 16, false);
#line 122 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                                           Write(blog.Description);

#line default
#line hidden
            EndContext();
            BeginContext(8815, 1094, true);
            WriteLiteral(@"
                                                            </p>
                                                        </div>
                                                    </div>
                                                    <div class=""card-footer pt-4 pb-4"">
                                                        <div class=""item-card9-footer d-flex"">

                                                            <div class=""ml-auto"">
                                                                <div class=""item2-icons d-flex"">
                                                                    <a href=""#"" class=""mr-3""><span class=""text-muted""><i class=""fa fa-comment-o text-muted""></i> 45 comments</span></a>
                                                                    <a href=""#"" class=""mr-3""><span class=""ml-1 text-muted""><i class=""fa fa-thumbs-o-up text-muted""></i> 56 likes</span></a>
                                                                    <a href=""#"" class=""mr-");
            WriteLiteral("3\"><span class=\"ml-1 text-muted\"><i class=\"fa fa-eye text-muted\"></i> ");
            EndContext();
            BeginContext(9910, 14, false);
#line 133 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                                                                                                                                           Write(blog.ViewCount);

#line default
#line hidden
            EndContext();
            BeginContext(9924, 439, true);
            WriteLiteral(@" views</span></a>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
");
            EndContext();
#line 141 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                    }

#line default
#line hidden
            BeginContext(10402, 212, true);
            WriteLiteral("                                </div>\r\n\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"center-block text-center mb-5 mt-5\">\r\n                            ");
            EndContext();
            BeginContext(10615, 48, false);
#line 147 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                       Write(await Component.InvokeAsync("Pager", Model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(10663, 584, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <!--.Add lists-->
            </div>

            <!--Right Side Content-->
            <div class=""col-xl-3 col-lg-12 col-md-12"">
                <div class=""card"">
                    <div class=""card-header pl-3"">
                        <h3 class=""card-title"">Danh Mục</h3>
                    </div>
                    <div class=""card-body"">
                        <div class="""" id=""container"">
                            <div class=""filter-product-checkboxs"">
");
            EndContext();
#line 163 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                 foreach (var item in Model.SideBarBlogCategorys)
                                {

#line default
#line hidden
            BeginContext(11365, 136, true);
            WriteLiteral("                                    <label class=\"custom-control custom-checkbox mb-3 pl-0\">\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 11501, "\"", 11517, 1);
#line 166 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
WriteAttributeValue("", 11508, item.URL, 11508, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(11518, 65, true);
            WriteLiteral(" class=\"\">\r\n                                            <strong> ");
            EndContext();
            BeginContext(11584, 9, false);
#line 167 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                                Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(11593, 11, true);
            WriteLiteral("</strong>\r\n");
            EndContext();
            BeginContext(11724, 92, true);
            WriteLiteral("                                        </a>\r\n                                    </label>\r\n");
            EndContext();
#line 171 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                     foreach (var itemChild in item.BlogCategoryChild)
                                    {

#line default
#line hidden
            BeginContext(11943, 144, true);
            WriteLiteral("                                        <label class=\"custom-control custom-checkbox mb-2 pl-3\">\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 12087, "\"", 12108, 1);
#line 174 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
WriteAttributeValue("", 12094, itemChild.URL, 12094, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(12109, 10, true);
            WriteLiteral(" class=\"\">");
            EndContext();
            BeginContext(12120, 14, false);
#line 174 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                                                         Write(itemChild.Name);

#line default
#line hidden
            EndContext();
            BeginContext(12134, 48, true);
            WriteLiteral("<span class=\"label label-secondary float-right\">");
            EndContext();
            BeginContext(12183, 19, false);
#line 174 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                                                                                                                        Write(itemChild.CountBlog);

#line default
#line hidden
            EndContext();
            BeginContext(12202, 63, true);
            WriteLiteral("</span></a>\r\n                                        </label>\r\n");
            EndContext();
#line 176 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                    }

#line default
#line hidden
#line 176 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                     
                                }

#line default
#line hidden
            BeginContext(12339, 336, true);
            WriteLiteral(@"                            </div>
                        </div>
                    </div>

                    <div class=""card-header pl-3 border-top"">
                        <h3 class=""card-title"">Tags</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""tags"">
");
            EndContext();
#line 187 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                             for (int i = 0; i < Model.Tags.Count; i++)
                            {
                                string classValue = "";
                                if (i == 0) { classValue = "tag tag-blue"; }
                                else if (i == 1) { classValue = "tag tag-azure"; }
                                else if (i == 2) { classValue = "tag tag-indigo"; }
                                else if (i == 3) { classValue = "tag tag-purple"; }
                                else if (i == 4) { classValue = "tag tag-pink"; }
                                else if (i == 5) { classValue = "tag tag-red"; }
                                else if (i == 6) { classValue = "tag tag-orange"; }
                                else if (i == 7) { classValue = "tag tag-yellow"; }
                                else if (i == 8) { classValue = "tag tag-lime"; }
                                else if (i == 9) { classValue = "tag tag-green"; }
                                else if (i == 10) { classValue = "tag tag-teal"; }
                                else if (i == 11) { classValue = "tag tag-cyan"; }
                                else if (i == 12) { classValue = "tag tag-gray"; }
                                else { classValue = "tag tag-gray-dark"; }
                                var tagDetailUrl = $"/chu-de-bai-viet/{Model.Tags[i].Id}.html";

#line default
#line hidden
            BeginContext(14095, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 14129, "\"", 14148, 1);
#line 205 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
WriteAttributeValue("", 14137, classValue, 14137, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 14149, "\"", 14169, 1);
#line 205 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
WriteAttributeValue("", 14156, tagDetailUrl, 14156, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 14170, "\"", 14197, 1);
#line 205 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
WriteAttributeValue("", 14178, Model.Tags[i].Name, 14178, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(14198, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(14200, 18, false);
#line 205 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                                                                                                   Write(Model.Tags[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(14218, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 206 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Views\Blog\BlogTag.cshtml"
                            }

#line default
#line hidden
            BeginContext(14255, 2109, true);
            WriteLiteral(@"                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">FanPage</h3>
                    </div>
                    <div class=""card-body product-filter-desc"">
                        <div class=""product-filter-icons text-center"">
                            <div class=""fb-page"" data-href=""https://www.facebook.com/valuesshare.official""
                                  data-width="""" data-height=""350""
                                 data-small-header=""false""
                                 data-adapt-container-width=""true""
                                 data-hide-cover=""false""
                                 data-show-facepile=""true"">
                                <blockquote cite=""https://www.facebook.com/valuesshare.official"" class=""fb-xfbml-parse-ignore"">
                                    <a href=""https://www.facebook.com/valuesshar");
            WriteLiteral(@"e.official"">Autobank</a>
                                </blockquote>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Shares</h3>
                    </div>
                    <div class=""card-body product-filter-desc"">
                        <div class=""product-filter-icons text-center"">
                            <a href=""#"" class=""facebook-bg""><i class=""fa fa-facebook""></i></a>
                            <a href=""#"" class=""twitter-bg""><i class=""fa fa-twitter""></i></a>
                            <a href=""#"" class=""google-bg""><i class=""fa fa-google""></i></a>
                            <a href=""#"" class=""dribbble-bg""><i class=""fa fa-dribbble""></i></a>
                        </div>
                    </div>
                </div>
            </div>
            <!--Right Side Content-->
  ");
            WriteLiteral("      </div>\r\n        <!-- row closed -->\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BeCoreApp.Models.BlogViewModels.CatalogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
