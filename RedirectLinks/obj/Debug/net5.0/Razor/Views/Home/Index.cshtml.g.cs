#pragma checksum "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89932c7a652cdce434ff64f42248d7ef072747e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89932c7a652cdce434ff64f42248d7ef072747e9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4afe9bf6814b78ced41bc00ebeb077d35db308e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LinkViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/home.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "JUN88";
    ViewData["Description"] = "Địa chỉ truy cập mới nhất";
    ViewData["Keywords"] = "789";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("css", async() => {
                WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://unpkg.com/swiper@8/swiper-bundle.min.css\" />\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "89932c7a652cdce434ff64f42248d7ef072747e94841", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n<script src=\"https://unpkg.com/swiper@8/swiper-bundle.min.js\"></script>\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89932c7a652cdce434ff64f42248d7ef072747e96213", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

<script>
        var mySwiper = new Swiper ('.swiper-container', {
        direction: 'vertical',
        effect: 'slide',
        slidesPerView: 3,
        loop: true,
        centeredSlides: true,
        autoplay: {
            delay: 3000,
            reverseDirection: false,
            disableOnInteraction: false,
        },
    })
</script>
");
            }
            );
            WriteLiteral(@"<div id=""links-container"">
    <img id=""logo"" src=""/images/logo-jun88.png"" alt=""Alternate Text"" />

    <div class=""col-lg-12 p-lg-0 m-lg-auto box-noti"">
        <div class=""notification"">
            <div class=""icon-noti"">
                <img src=""/images/ringing.png"" />
            </div>
            <marquee>Siêu khuyến mãi khủng chào mừng sự kiện <span style=""color: #02a9dc""> Jun88.com </span> trở thành đối tác hợp tác chính thức FIFA Word Cup QATAR 2022</marquee>
        </div>
        <div class=""col-lg-12 col-xl-7 pl-lg-0 float-lg-left "" id=""screen-img"">
");
            WriteLiteral(@"            <div class=""box-promos"">
                <div class=""swiper-container"">
                    <div class=""swiper-wrapper"">
                        <div class=""swiper-slide"">
                            <a href=""https://www.jun82.com/promotions/39153765-76eb-4bef-8b0c-6a7bebb936cd"" target=""_blank"">
                                <img src=""/images/quakhung.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1806, "\"", 1812, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""swiper-slide"">
                            <a href=""https://www.jun82.com/promotions/849556f3-780b-408a-8163-181ec1a4954e"" target=""_blank"">
                                <img src=""/images/quavip.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2121, "\"", 2127, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""swiper-slide"">
                            <a href=""https://www.jun82.com/promotions/10329565-5c62-48f0-a4c2-8b2479bd5c18"" target=""_blank"">
                                <img src=""/images/sieu-hoan-tra-50.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2446, "\"", 2452, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""swiper-slide"">
                            <a href=""https://www.jun82.com/promotions/edd8ccb9-cb69-4107-a67e-19d97ce0a02c"" target=""_blank"">
                                <img src=""/images/sieulixi.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2763, "\"", 2769, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""swiper-slide"">
                            <a href=""https://www.jun82.com/promotions/66054bae-ddf4-406b-86fe-2eab5c98fabe"" target=""_blank"">
                                <img src=""/images/thuongkhithang.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3086, "\"", 3092, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                        <div class=""swiper-slide"">
                            <a href=""https://www.jun82.com/promotions/e2b8c610-1661-41ea-8dbf-2c6ee36e5ef3"" target=""_blank"">
                                <img src=""/images/sieu-tien-thuong-vip.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3415, "\"", 3421, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("        </div>\r\n        <div class=\"col-lg-12 col-xl-5 pr-lg-0 float-lg-left p-0\">\r\n            <div id=\"domains-list\">\r\n");
#nullable restore
#line 84 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Home\Index.cshtml"
                  
                    if (Model != null && Model.Count > 0)
                    {
                        for (int i = 0; i < Model.Count; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"link\"");
            BeginWriteAttribute("link", " link=\"", 4012, "\"", 4032, 1);
#nullable restore
#line 89 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Home\Index.cshtml"
WriteAttributeValue("", 4019, Model[i].Url, 4019, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""col-8 p-0 float-left"">
                                    <div class=""link-number"">
                                        <div class=""yellow-circle"">
                                            <div class=""black-circle"">
                                                <p>
");
#nullable restore
#line 95 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Home\Index.cshtml"
                                                      
                                                        var order = i + 1;
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
#nullable restore
#line 98 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Home\Index.cshtml"
                                               Write(order);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""float-left ml-2 link-info"">
                                        <h5 class=""d-inline text-white"">
");
#nullable restore
#line 105 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Home\Index.cshtml"
                                              
                                                var speed = order * 100;
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
#nullable restore
#line 108 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Home\Index.cshtml"
                                       Write(speed);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </h5>\r\n                                        <span class=\"text-white\">ms</span>\r\n                                        <h5 class=\"d-inline text-white ml-3\">Link truy cập ");
#nullable restore
#line 111 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Home\Index.cshtml"
                                                                                      Write(order);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"col-4 p-0 float-left text-right pr-2\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5611, "\"", 5631, 1);
#nullable restore
#line 115 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Home\Index.cshtml"
WriteAttributeValue("", 5618, Model[i].Url, 5618, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""btn-1"" class=""btn button"">
                                        <span>Truy cập</span>
                                    </a>
                                </div>
                                <div class=""clear-both""></div>
                            </div>
");
#nullable restore
#line 121 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"clear-both\"></div>\r\n");
#nullable restore
#line 123 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Home\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
        <div class=""clear-both""></div>
    </div>
    <div id=""menu-container"">
        <div id=""menu"">
            <div id=""menu-bg"">
                <img src=""/images/icons/menu-bg.png"" alt=""Alternate Text"" />
            </div>
            <div class=""btn-bg"" id=""android"">
                <a href=""https://jun47.com/"" target=""_blank"" class=""icon"" icon-name=""android"">
                    <img src=""/images/icons/android-icon.png"" alt=""android-icon"" />
                </a>
                <p>
                    <a href=""https://jun47.com/"" target=""_blank"">ANDROID</a>
                </p>
            </div>
            <div class=""btn-bg"" id=""agent"">
                <a href=""https://jun.bet/"" target=""_blank"" class=""icon"" icon-name=""agent"">
                    <img class=""icon"" src=""/images/icons/agent-icon.png"" alt=""agent-icon"" />
                </a>
                <p>
                    <a href=""https://jun.bet/"" target=""_blank"">ĐẠI LÝ</a>
          ");
            WriteLiteral(@"      </p>
            </div>
            <div class=""btn-bg"" id=""customer-service"">
                <a href=""https://jun88.gofiber.dev/tawkto"" target=""_blank"" class=""icon"" icon-name=""customerService"">
                    <img class=""icon"" src=""/images/icons/customer-service-icon.png"" alt=""customer-service-icon"" />
                </a>
                <p>
                    <a href=""https://jun88.gofiber.dev/tawkto"" target=""_blank"">CSKH</a>
                </p>
            </div>
            <div class=""btn-bg"" id=""gift"">
                <a href=""https://www.jun85.com/promotions"" target=""_blank"" class=""icon"" icon-name=""gift"">
                    <img class=""icon"" src=""/images/icons/gift-icon.png"" alt=""gift-icon"" />
                </a>
                <p>
                    <a href=""https://www.jun85.com/promotions"" target=""_blank"">KHUYẾN MÃI</a>
                </p>
            </div>
            <div class=""btn-bg"" id=""ios"">
                <a href=""https://jun47.com/"" target=""_blank"" c");
            WriteLiteral(@"lass=""icon"" icon-name=""ios"">
                    <img class=""icon"" src=""/images/icons/ios-icon.png"" alt=""ios-icon"" />
                </a>
                <p>
                    <a href=""https://jun47.com/"" target=""_blank"">IOS</a>
                </p>
            </div>
            <div id=""btn-home"">
                <div id=""btn-home-items"">
                    <div id=""home-icon"">
                        <a href=""https://www.jun82.com/"" target=""_blank"">
                            <img src=""/images/icons/home-icon.png"" alt=""android-icon"" />
                        </a>
                    </div>
                    <div id=""home-text"">
                        <a href=""https://www.jun82.com/"" target=""_blank"">TRANG CHỦ</a>
                    </div>
                    <div class=""clear-both""></div>
                </div>
            </div>
        </div>
    </div>
</div>
<input id=""background-image-url"" type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 9039, "\"", 9066, 1);
#nullable restore
#line 190 "D:\NhaCai\bet789\RedirectLinksJun88\RedirectLinks\Views\Home\Index.cshtml"
WriteAttributeValue("", 9047, ViewBag.Background, 9047, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LinkViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
