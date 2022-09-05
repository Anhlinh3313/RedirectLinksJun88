#pragma checksum "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a81117dff7b7a45c686a48f3b3144ec4cdae8e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_LinkGroup), @"mvc.1.0.view", @"/Views/Admin/LinkGroup.cshtml")]
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
#line 1 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\_ViewImports.cshtml"
using RedirectLinks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\_ViewImports.cshtml"
using RedirectLinks.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\_ViewImports.cshtml"
using RedirectLinks.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a81117dff7b7a45c686a48f3b3144ec4cdae8e3", @"/Views/Admin/LinkGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4afe9bf6814b78ced41bc00ebeb077d35db308e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_LinkGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/link-group.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
  
    Layout = "_AdminLayout";
    ViewData["Title"] = "Quản lý nhóm link";
    List<int> pageSizes = new List<int>();
    pageSizes.Add(10);
    pageSizes.Add(20);
    pageSizes.Add(30);
    pageSizes.Add(40);
    pageSizes.Add(50);
    pageSizes.Add(100);
    pageSizes.Add(200);
    pageSizes.Add(1000);

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral(" \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a81117dff7b7a45c686a48f3b3144ec4cdae8e34366", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<div class=""container"">
    <h1 class=""text-center mt-4 mb-4"">Quản lý nhóm link</h1>
    <div class=""border-bottom pb-1 mb-2"">
        <div class=""w-50 float-left"">
            <div class=""form-inline"">
                <input id=""link-group-name-for-search"" class=""form-control"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 708, "\"", 738, 1);
#nullable restore
#line 23 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
WriteAttributeValue("", 716, ViewBag.LinkGroupName, 716, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Nhập tên nhóm link"" />
                <input id=""btn-search"" type=""button"" class=""btn btn-primary ml-2"" value=""Tìm kiếm"" />
            </div>
        </div>
        <div class=""w-50 float-left"">
            <div class=""text-right"">
                <span>Thêm nhóm link mới: </span>
                <input type=""button"" class=""btn btn-primary"" value=""Thêm mới"" data-toggle=""modal"" data-target=""#insert-link-group-modal"" />
            </div>
        </div>
        <div class=""clear-both""></div>
    </div>
    <table class=""table table-striped table-bordered"">
        <thead>
            <tr>
                <th>#</th>
                <th>Tên nhóm link</th>
                <th>Thời gian tạo</th>
                <th>Thời gian sửa</th>
                <th class=""text-center"">Thao tác</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 46 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
              
                var linkGroups = Model.Data as List<LinkGroup>;
                if (linkGroups != null && linkGroups.Count > 0)
                {
                    foreach (var item in linkGroups)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 53 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 54 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                           Write(item.LinkGroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 55 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                           Write(item.CreatedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 56 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                           Write(item.UpdatedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">\r\n                                <div class=\"d-inline-block btn-group-m\">\r\n                                    <button class=\"btn btn-danger btn-sm btn-delete-link-group\"");
            BeginWriteAttribute("link-group-id", " link-group-id=\"", 2333, "\"", 2357, 1);
#nullable restore
#line 59 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
WriteAttributeValue("", 2349, item.Id, 2349, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""12"" height=""12"" fill=""currentColor"" class=""bi bi-trash3"" viewBox=""0 0 16 16"">
                                            <path d=""M6.5 1h3a.5.5 0 0 1 .5.5v1H6v-1a.5.5 0 0 1 .5-.5ZM11 2.5v-1A1.5 1.5 0 0 0 9.5 0h-3A1.5 1.5 0 0 0 5 1.5v1H2.506a.58.58 0 0 0-.01 0H1.5a.5.5 0 0 0 0 1h.538l.853 10.66A2 2 0 0 0 4.885 16h6.23a2 2 0 0 0 1.994-1.84l.853-10.66h.538a.5.5 0 0 0 0-1h-.995a.59.59 0 0 0-.01 0H11Zm1.958 1-.846 10.58a1 1 0 0 1-.997.92h-6.23a1 1 0 0 1-.997-.92L3.042 3.5h9.916Zm-7.487 1a.5.5 0 0 1 .528.47l.5 8.5a.5.5 0 0 1-.998.06L5 5.03a.5.5 0 0 1 .47-.53Zm5.058 0a.5.5 0 0 1 .47.53l-.5 8.5a.5.5 0 1 1-.998-.06l.5-8.5a.5.5 0 0 1 .528-.47ZM8 4.5a.5.5 0 0 1 .5.5v8.5a.5.5 0 0 1-1 0V5a.5.5 0 0 1 .5-.5Z"" />
                                        </svg>
                                    </button>
                                    <button class=""btn btn-success btn-sm btn-update-link-group""");
            BeginWriteAttribute("link-group-id", " link-group-id=\"", 3349, "\"", 3373, 1);
#nullable restore
#line 64 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
WriteAttributeValue("", 3365, item.Id, 3365, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""12"" height=""12"" fill=""currentColor"" class=""bi bi-pencil-square"" viewBox=""0 0 16 16"">
                                            <path d=""M15.502 1.94a.5.5 0 0 1 0 .706L14.459 3.69l-2-2L13.502.646a.5.5 0 0 1 .707 0l1.293 1.293zm-1.75 2.456-2-2L4.939 9.21a.5.5 0 0 0-.121.196l-.805 2.414a.25.25 0 0 0 .316.316l2.414-.805a.5.5 0 0 0 .196-.12l6.813-6.814z"" />
                                            <path fill-rule=""evenodd"" d=""M1 13.5A1.5 1.5 0 0 0 2.5 15h11a1.5 1.5 0 0 0 1.5-1.5v-6a.5.5 0 0 0-1 0v6a.5.5 0 0 1-.5.5h-11a.5.5 0 0 1-.5-.5v-11a.5.5 0 0 1 .5-.5H9a.5.5 0 0 0 0-1H2.5A1.5 1.5 0 0 0 1 2.5v11z"" />
                                        </svg>
                                    </button>
                                </div>
                            </td>
                        </tr>
");
#nullable restore
#line 73 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <!--Hiddens-->\r\n    <input id=\"hidden-link-group-name\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 4442, "\"", 4472, 1);
#nullable restore
#line 80 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
WriteAttributeValue("", 4450, ViewBag.LinkGroupName, 4450, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n    <!--Paging-->\r\n    <div class=\"mt-4 text-center\">\r\n        <div id=\"pagination-container d-inline-block\">\r\n            <ul class=\"list-unstyled d-inline-block\">\r\n");
#nullable restore
#line 86 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                  
                    var pageIndex = (int)ViewBag.PageIndex;
                    var totalPage = Model.TotalPage;
                    if (totalPage < 10)
                    {
                        for (int i = 1; i <= totalPage; i++)
                        {
                            var href = "/admin/linkgroup?linkGroupName=" + ViewBag.LinkGroupName + "&pageIndex=" + i + "&pageSize=" + ViewBag.PageSize;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"d-inline-block\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 5178, "\"", 5190, 1);
#nullable restore
#line 95 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
WriteAttributeValue("", 5185, href, 5185, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"bg-secondary border border-secondary pt-1 pb-1 pr-2 pl-2\">\r\n");
#nullable restore
#line 97 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                          
                                            if (pageIndex == i)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p class=\"m-0 text-warning font-weight-bold\">");
#nullable restore
#line 100 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                                                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 101 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p class=\"m-0 text-white\">");
#nullable restore
#line 104 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                                     Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 105 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 110 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                        }
                    }
                    else
                    {
                        var firstHref = "/admin/linkgroup?linkGroupName=" + ViewBag.LinkGroupName + "&pageIndex=" + "&pageSize=" + ViewBag.PageSize;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"d-inline-block\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 6324, "\"", 6341, 1);
#nullable restore
#line 116 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
WriteAttributeValue("", 6331, firstHref, 6331, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"bg-secondary border border-secondary pt-1 pb-1 pr-2 pl-2\">\r\n");
#nullable restore
#line 118 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                      
                                        if (pageIndex == 1)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p class=\"m-0 text-warning font-weight-bold\">1</p>\r\n");
#nullable restore
#line 122 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p class=\"m-0 text-white\">1</p>\r\n");
#nullable restore
#line 126 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 131 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                        if (pageIndex <= 6)
                        {
                            for (var i = 2; i <= 9; i++)
                            {
                                var href = "/admin/linkgroup?linkGroupName=" + ViewBag.LinkGroupName + "&pageIndex=" + i + "&pageSize=" + ViewBag.PageSize;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"d-inline-block\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 7502, "\"", 7514, 1);
#nullable restore
#line 137 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
WriteAttributeValue("", 7509, href, 7509, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"bg-secondary border border-secondary pt-1 pb-1 pr-2 pl-2\">\r\n");
#nullable restore
#line 139 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                              
                                                if (pageIndex == i)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <p class=\"m-0 text-warning font-weight-bold\">");
#nullable restore
#line 142 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 143 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <p class=\"m-0 text-white\">");
#nullable restore
#line 146 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 147 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 152 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <li class=""d-inline-block"">
                                <a href=""#"">
                                    <div class=""bg-secondary border border-secondary pt-1 pb-1 pr-2 pl-2"">
                                        <p class=""m-0 text-white"">...</p>
                                    </div>
                                </a>
                            </li>
");
#nullable restore
#line 163 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                            if (pageIndex <= totalPage - 5)
                            {
                                for (int i = pageIndex - 5; i <= pageIndex + 5; i++)
                                {
                                    var href = "/admin/linkgroup?linkGroupName=" + ViewBag.LinkGroupName + "&pageIndex=" + i + "&pageSize=" + ViewBag.PageSize;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"d-inline-block\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 9371, "\"", 9383, 1);
#nullable restore
#line 169 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
WriteAttributeValue("", 9378, href, 9378, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"bg-secondary border border-secondary pt-1 pb-1 pr-2 pl-2\">\r\n");
#nullable restore
#line 171 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                  
                                                    if (pageIndex == i)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p class=\"m-0 text-warning font-weight-bold\">");
#nullable restore
#line 174 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                                                                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 175 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p class=\"m-0 text-white\">");
#nullable restore
#line 178 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 179 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n                                        </a>\r\n                                    </li>\r\n");
#nullable restore
#line 184 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li class=""d-inline-block"">
                                    <a href=""#"">
                                        <div class=""bg-secondary border border-secondary pt-1 pb-1 pr-2 pl-2"">
                                            <p class=""m-0 text-white"">...</p>
                                        </div>
                                    </a>
                                </li>
");
#nullable restore
#line 192 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                            }
                            else
                            {
                                var lastPage = pageIndex + (totalPage - pageIndex);
                                for (int i = pageIndex - 5; i < lastPage; i++)
                                {
                                    var href = "/admin/linkgroup?linkGroupName=" + ViewBag.LinkGroupName + "&pageIndex=" + i + "&pageSize=" + ViewBag.PageSize;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"d-inline-block\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 11327, "\"", 11339, 1);
#nullable restore
#line 200 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
WriteAttributeValue("", 11334, href, 11334, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"bg-secondary border border-secondary pt-1 pb-1 pr-2 pl-2\">\r\n");
#nullable restore
#line 202 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                  
                                                    if (pageIndex == i)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p class=\"m-0 text-warning font-weight-bold\">");
#nullable restore
#line 205 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                                                                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 206 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p class=\"m-0 text-white\">");
#nullable restore
#line 209 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 210 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n                                        </a>\r\n                                    </li>\r\n");
#nullable restore
#line 215 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                }
                            }
                        }
                        var lastHref = "/admin/linkgroup?linkGroupName=" + ViewBag.LinkGroupName + "&pageIndex=" + totalPage + "&pageSize=" + ViewBag.PageSize;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"d-inline-block\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 12590, "\"", 12606, 1);
#nullable restore
#line 220 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
WriteAttributeValue("", 12597, lastHref, 12597, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"bg-secondary border border-secondary pt-1 pb-1 pr-2 pl-2\">\r\n");
#nullable restore
#line 222 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                      
                                        if (pageIndex == totalPage)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p class=\"m-0 text-warning font-weight-bold\">");
#nullable restore
#line 225 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                                                    Write(totalPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 226 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p class=\"m-0 text-white\">");
#nullable restore
#line 229 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                                 Write(totalPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 230 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 235 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n            <div class=\"d-inline-block ml-2\">\r\n                <div class=\"form-inline\">\r\n                    <label>Hiển thị:</label>\r\n                    <select id=\"page-size-select\" class=\"form-control ml-2\">\r\n");
#nullable restore
#line 243 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                          
                            foreach (var pageSize in pageSizes)
                            {
                                if (ViewBag.PageSize == pageSize)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a81117dff7b7a45c686a48f3b3144ec4cdae8e332586", async() => {
#nullable restore
#line 248 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                                  Write(pageSize);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 248 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                       WriteLiteral(pageSize);

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
#line 249 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a81117dff7b7a45c686a48f3b3144ec4cdae8e335081", async() => {
#nullable restore
#line 252 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                                         Write(pageSize);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 252 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                       WriteLiteral(pageSize);

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
#line 253 "D:\Jun88\RedirectLinks\RedirectLinksJun88\RedirectLinks\Views\Admin\LinkGroup.cshtml"
                                }
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""insert-link-group-modal"" tabindex=""-1"" role=""dialog"" data-backdrop=""static"" aria-labelledby=""insert-link-group"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Thêm mới nhóm link</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""insert-link-group-modal-body"">
                <div class=""form-group"">
                    <label>Tên nhóm link: (Không dấu cách nhau bằng dấu ""-"")</label>
                    <input id=""link-group-name"" type=""text"" class=""form-control"" placeholder=""Ví dụ: soi-keo-vip"" />
                </div>
                ");
            WriteLiteral(@"<div class=""text-center"">
                    <input id=""btn-insert-link-group"" type=""button"" class=""btn btn-primary"" value=""Thêm mới"" />
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""update-link-group-modal"" tabindex=""-1"" role=""dialog"" data-backdrop=""static"" aria-labelledby=""update-link-group"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Thêm mới nhóm link</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""update-link-group-modal-body"">
                
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
