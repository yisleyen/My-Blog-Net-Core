#pragma checksum "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Shared\Components\Statistic\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5f8a968e653c3f3275825373c4469ba86a6eb2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_Statistic_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/Statistic/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f8a968e653c3f3275825373c4469ba86a6eb2e", @"/Areas/Admin/Views/Shared/Components/Statistic/Default.cshtml")]
    public class Areas_Admin_Views_Shared_Components_Statistic_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-3"">
        <div class=""widget style1"">
            <div class=""row"">
                <div class=""col-4 text-center"">
                    <i class=""fa fa-trophy fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span>Blog Sayısı</span>
                    <h2 class=""font-bold"">");
#nullable restore
#line 10 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Shared\Components\Statistic\Default.cshtml"
                                     Write(ViewBag.BlogCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-3\">\r\n        <div class=\"widget style1 navy-bg\">\r\n            <div class=\"row\">\r\n                <div class=\"col-4\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 642, "\"", 661, 1);
#nullable restore
#line 19 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Shared\Components\Statistic\Default.cshtml"
WriteAttributeValue("", 648, ViewBag.Icon, 648, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Hava Durumu\" />\r\n                </div>\r\n                <div class=\"col-8 text-right\">\r\n                    <span>İstanbul</span>\r\n                    <h2 class=\"font-bold\">");
#nullable restore
#line 23 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Shared\Components\Statistic\Default.cshtml"
                                     Write(ViewBag.Heat);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'C</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget style1 lazur-bg"">
            <div class=""row"">
                <div class=""col-4"">
                    <i class=""fa fa-envelope-o fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span>Mesaj Sayısı</span>
                    <h2 class=""font-bold"">");
#nullable restore
#line 36 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Shared\Components\Statistic\Default.cshtml"
                                     Write(ViewBag.ContactCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget style1 yellow-bg"">
            <div class=""row"">
                <div class=""col-4"">
                    <i class=""fa fa-comment fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span>Yorum Sayısı</span>
                    <h2 class=""font-bold"">");
#nullable restore
#line 49 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Shared\Components\Statistic\Default.cshtml"
                                     Write(ViewBag.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-2"">
        <div class=""widget style1 navy-bg"">
            <div class=""row vertical-align"">
                <div class=""col-3"">
                    <i class=""fa fa-user fa-3x""></i>
                </div>
                <div class=""col-9 text-right"">
                    <h2 class=""font-bold"">217</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-2"">
        <div class=""widget style1 navy-bg"">
            <div class=""row vertical-align"">
                <div class=""col-3"">
                    <i class=""fa fa-thumbs-up fa-3x""></i>
                </div>
                <div class=""col-9 text-right"">
                    <h2 class=""font-bold"">400</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-2"">
        <div class=""widget style1 navy-bg"">
            <div class=""row ");
            WriteLiteral(@"vertical-align"">
                <div class=""col-3"">
                    <i class=""fa fa-rss fa-3x""></i>
                </div>
                <div class=""col-9 text-right"">
                    <h2 class=""font-bold"">10</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-2"">
        <div class=""widget style1 lazur-bg"">
            <div class=""row vertical-align"">
                <div class=""col-3"">
                    <i class=""fa fa-phone fa-3x""></i>
                </div>
                <div class=""col-9 text-right"">
                    <h2 class=""font-bold"">120</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-2"">
        <div class=""widget style1 lazur-bg"">
            <div class=""row vertical-align"">
                <div class=""col-3"">
                    <i class=""fa fa-euro fa-3x""></i>
                </div>
                <div class=""col-9 text-right"">
                    <h2 class=");
            WriteLiteral(@"""font-bold"">462</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-2"">
        <div class=""widget style1 yellow-bg"">
            <div class=""row vertical-align"">
                <div class=""col-3"">
                    <i class=""fa fa-shield fa-3x""></i>
                </div>
                <div class=""col-9 text-right"">
                    <h2 class=""font-bold"">610</h2>
                </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
