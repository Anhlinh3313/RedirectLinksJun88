#pragma checksum "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Admin\UpdateLinkGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f0e46cc519b811ad1dab39fea892c16104a183f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateLinkGroup), @"mvc.1.0.view", @"/Views/Admin/UpdateLinkGroup.cshtml")]
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
#nullable restore
#line 1 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\_ViewImports.cshtml"
using RedirectLinks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\_ViewImports.cshtml"
using RedirectLinks.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\_ViewImports.cshtml"
using RedirectLinks.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f0e46cc519b811ad1dab39fea892c16104a183f", @"/Views/Admin/UpdateLinkGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4afe9bf6814b78ced41bc00ebeb077d35db308e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateLinkGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LinkGroup>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/update-link-group.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"form-group\">\r\n    <label>Tên nhóm link:</label>\r\n    <input id=\"modal-link-group-name\" class=\"form-control\" type=\"text\" placeholder=\"Nhập tên nhóm link\"");
            BeginWriteAttribute("value", " value=\"", 182, "\"", 210, 1);
#nullable restore
#line 4 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Admin\UpdateLinkGroup.cshtml"
WriteAttributeValue("", 190, Model.LinkGroupName, 190, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n<div class=\"text-center\">\r\n    <input id=\"link-group-id\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 294, "\"", 311, 1);
#nullable restore
#line 7 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Admin\UpdateLinkGroup.cshtml"
WriteAttributeValue("", 302, Model.Id, 302, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input id=\"modal-btn-update-link-group\" class=\"btn btn-primary\" type=\"button\" value=\"Sửa nhóm link\" />\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f0e46cc519b811ad1dab39fea892c16104a183f4839", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LinkGroup> Html { get; private set; }
    }
}
#pragma warning restore 1591