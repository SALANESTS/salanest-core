#pragma checksum "C:\TongHop\Others\Salanests\BeCoreApp.Web\Areas\Admin\Views\Project\_ImageManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f77563938187a3675b1ee2f956aaeaa325367b89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Project__ImageManagement), @"mvc.1.0.view", @"/Areas/Admin/Views/Project/_ImageManagement.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Project/_ImageManagement.cshtml", typeof(AspNetCore.Areas_Admin_Views_Project__ImageManagement))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f77563938187a3675b1ee2f956aaeaa325367b89", @"/Areas/Admin/Views/Project/_ImageManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68994ac50316bb5bc7adb5dd726610ea311dbfdf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Project__ImageManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmMaintainance"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 723, true);
            WriteLiteral(@"<div id=""modal-image-manage"" class=""modal fade"" data-backdrop=""static"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">
                    Quản lý hình ảnh dự án
                </h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">
                        &times;
                    </span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(723, 635, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cc68f69f1a34050ac52107df684fa3b", async() => {
                BeginContext(786, 565, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <input type=""hidden"" id=""hidId"" value="""" />
                        <div id=""image-list"" class=""col-md-12""></div>
                    </div>
                    <div class=""form-group"">
                        <label for=""txtName"" class=""form-control-label"">Chọn ảnh</label>
                        <div class=""input-group"">
                            <input type=""file"" id=""fileImage""/>
                        </div><!-- /input-group -->
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1358, 325, true);
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" id=""btnCancel"" class=""btn btn-secondary"" data-dismiss=""modal"">Hủy</button>
                <button type=""button"" id=""btnSaveImages"" class=""btn btn-success"">Lưu</button>
            </div>
        </div>
    </div>
</div>");
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
