#pragma checksum "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Admin\UpdateLink.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb58c768622f8a5b8285a1fa042e3f17e5bde75b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateLink), @"mvc.1.0.view", @"/Views/Admin/UpdateLink.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb58c768622f8a5b8285a1fa042e3f17e5bde75b", @"/Views/Admin/UpdateLink.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4afe9bf6814b78ced41bc00ebeb077d35db308e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateLink : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Link>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/update-link.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"form-group\">\r\n    <label><span class=\"text-danger\">(*)</span>Nh??m link:</label>\r\n    <select id=\"modal-link-group-id\" class=\"form-control\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb58c768622f8a5b8285a1fa042e3f17e5bde75b4254", async() => {
                WriteLiteral("Ch???n nh??m link");
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Admin\UpdateLink.cshtml"
          
            var linkGroups = ViewBag.LinkGroups as List<LinkGroup>;
            if (linkGroups != null && linkGroups.Count > 0)
            {
                foreach (var item in linkGroups)
                {
                    if (Model.LinkGroupId == item.Id)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb58c768622f8a5b8285a1fa042e3f17e5bde75b5940", async() => {
#nullable restore
#line 14 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Admin\UpdateLink.cshtml"
                                                     Write(item.LinkGroupName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Admin\UpdateLink.cshtml"
                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 15 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Admin\UpdateLink.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb58c768622f8a5b8285a1fa042e3f17e5bde75b8352", async() => {
#nullable restore
#line 18 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Admin\UpdateLink.cshtml"
                                            Write(item.LinkGroupName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Admin\UpdateLink.cshtml"
                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 19 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Admin\UpdateLink.cshtml"
                    }
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </select>\r\n</div>\r\n<div class=\"form-group\">\r\n    <label><span class=\"text-danger\">(*)</span>Link:</label>\r\n    <input id=\"modal-url\" class=\"form-control\" type=\"text\" placeholder=\"Nh???p link\"");
            BeginWriteAttribute("value", " value=\"", 1020, "\"", 1038, 1);
#nullable restore
#line 27 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Admin\UpdateLink.cshtml"
WriteAttributeValue("", 1028, Model.Url, 1028, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n<div class=\"form-group\">\r\n    <label><span class=\"text-danger\">(*)</span>S???p x???p:</label>\r\n    <input id=\"modal-link-order\" class=\"form-control\" type=\"number\" placeholder=\"Nh???p v??? tr?? c???a link\"");
            BeginWriteAttribute("value", " value=\"", 1245, "\"", 1269, 1);
#nullable restore
#line 31 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Admin\UpdateLink.cshtml"
WriteAttributeValue("", 1253, Model.LinkOrder, 1253, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n<div class=\"text-center\">\r\n    <input id=\"link-id\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1347, "\"", 1364, 1);
#nullable restore
#line 34 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Admin\UpdateLink.cshtml"
WriteAttributeValue("", 1355, Model.Id, 1355, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input id=\"modal-btn-update-link\" type=\"button\" class=\"btn btn-primary\" value=\"S???a link\" />\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb58c768622f8a5b8285a1fa042e3f17e5bde75b12160", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Link> Html { get; private set; }
    }
}
#pragma warning restore 1591
