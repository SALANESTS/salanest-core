#pragma checksum "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\District\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "842debdf66ae12867b4eba2d7352b99041848514"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_District_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/District/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/District/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_District_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"842debdf66ae12867b4eba2d7352b99041848514", @"/Areas/Admin/Views/District/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68994ac50316bb5bc7adb5dd726610ea311dbfdf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_District_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/admin-app/controllers/district/index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/admin-app/controllers/district/index.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\District\Index.cshtml"
  
    ViewData["Title"] = "Pages";

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(58, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(64, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "115eec8e7b4d4a26bf82aad3b53af25d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 5 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\District\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(155, 119, true);
                WriteLiteral("\r\n    <script>\r\n        var districtObj = new DistrictController();\r\n        districtObj.initialize();\r\n    </script>\r\n");
                EndContext();
            }
            );
            DefineSection("Styles", async() => {
                BeginContext(293, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(299, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b04cb982d89649a79d54ce73c3550bb6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 12 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\District\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(400, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(405, 27, true);
            WriteLiteral("<!-- BEGIN: Subheader -->\r\n");
            EndContext();
            BeginContext(433, 40, false);
#line 15 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\District\Index.cshtml"
Write(await Component.InvokeAsync("SubHeader"));

#line default
#line hidden
            EndContext();
            BeginContext(473, 1538, true);
            WriteLiteral(@"
<!-- END: Subheader -->
<div class=""m-content"">
    <div class=""m-portlet m-portlet--mobile"">
        <div class=""m-portlet__head"">
            <div class=""m-portlet__head-caption"">
                <div class=""m-portlet__head-title"">
                    <h3 class=""m-portlet__head-text"">
                        Quận/Huyện
                    </h3>
                </div>
            </div>
        </div>
        <div class=""m-portlet__body"">
            <!--begin: Search Form -->
            <div class=""m-form m-form--label-align-right m--margin-top-20 m--margin-bottom-30"">
                <div class=""row align-items-center"">
                    <div class=""col-xl-8 order-2 order-xl-1"">
                        <div class=""form-group m-form__group row align-items-center"">
                            <div class=""col-md-4"">
                                <div class=""m-input-icon m-input-icon--left"">
                                    <input type=""text"" id=""txt-search-keyword"" class=""form-co");
            WriteLiteral(@"ntrol m-input m-input--air"" placeholder=""Search..."">
                                    <span class=""m-input-icon__icon m-input-icon__icon--left"">
                                        <span><i class=""la la-search""></i></span>
                                    </span>
                                </div>
                            </div>
                            <div class=""col-md-4"">
                                <div class=""m-select2 m-select2--air"">
                                    ");
            EndContext();
            BeginContext(2012, 107, false);
#line 44 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\District\Index.cshtml"
                               Write(Html.DropDownList("ProvinceId", null, "", new { @class = "form-control m-select2",id= "SearchProvinceId" }));

#line default
#line hidden
            EndContext();
            BeginContext(2119, 1569, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""col-xl-4 order-1 order-xl-2 m--align-right"">
                        <a href=""#"" id=""btn-create"" class=""btn btn-success m-btn m-btn--custom m-btn--icon m-btn--air m-btn--pill"">
                            <span>
                                <i class=""flaticon-plus""></i><span>Create</span>
                            </span>
                        </a>
                        <div class=""m-separator m-separator--dashed d-xl-none""></div>
                    </div>
                </div>
            </div>
            <!--end: Search Form -->
            <!--begin::Section-->
            <div class=""m-section"">
                <div class=""m-section__content"">
                    <div class=""table-responsive"">
                        <table class=""table m-table m-table--head-separator-primary"">
                            <t");
            WriteLiteral(@"head>
                                <tr>
                                    <th>No</th>
                                    <th>Tiêu Đề</th>
                                    <th>Tỉnh</th>
                                    <th>Trạng Thái</th>
                                    <th width=""250"">Chức Năng</th>
                                </tr>
                            </thead>
                            <tbody id=""tbl-content""></tbody>
                        </table>
                    </div>
                    ");
            EndContext();
            BeginContext(3689, 37, false);
#line 78 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\District\Index.cshtml"
               Write(await Component.InvokeAsync("Paging"));

#line default
#line hidden
            EndContext();
            BeginContext(3726, 726, true);
            WriteLiteral(@"
                </div>
            </div>
            <!--end::Section-->
        </div>
    </div>
</div>
<script id=""table-template"" type=""x-tmpl-mustache"">
    <tr>
        <td>{{Id}}</td>
        <td>{{Name}}</td>
        <td>{{ProvinceName}}</td>
        <td>{{{Status}}}</td>
        <td width=""250"">
            <a href=""#"" data-id=""{{Id}}"" class=""btn-edit m-portlet__nav-link btn m-btn m-btn--hover-accent m-btn--icon m-btn--icon-only m-btn--pill""><i class=""la la-edit""></i></a>
            <a href=""#"" data-id=""{{Id}}"" class=""btn-delete m-portlet__nav-link btn m-btn m-btn--hover-danger m-btn--icon m-btn--icon-only m-btn--pill""><i class=""la la-trash""></i></a>
        </td>
    </tr>
</script>

");
            EndContext();
            BeginContext(4453, 29, false);
#line 98 "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\District\Index.cshtml"
Write(Html.Partial("_AddEditModal"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
