#pragma checksum "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Shared\Components\StatisticAdmin\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0780c8f1fda31564a870812242f61a7038e982da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_StatisticAdmin_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/StatisticAdmin/Default.cshtml")]
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
#line 1 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0780c8f1fda31564a870812242f61a7038e982da", @"/Areas/Admin/Views/Shared/Components/StatisticAdmin/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_StatisticAdmin_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-4\">\r\n        <div class=\"widget-head-color-box navy-bg p-lg text-center\">\r\n            <div class=\"m-b-md\">\r\n                <h2 class=\"font-bold no-margins\">\r\n                    ");
#nullable restore
#line 6 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Shared\Components\StatisticAdmin\Default.cshtml"
               Write(ViewBag.AdminName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h2>\r\n            </div>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 301, "\"", 326, 1);
#nullable restore
#line 9 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Shared\Components\StatisticAdmin\Default.cshtml"
WriteAttributeValue("", 307, ViewBag.AdminImage, 307, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""rounded-circle circle-border m-b-md"" alt=""profile"">
            <div>
                <span>100 Tweet</span> |
                <span>350 Takip Edilen</span> |
                <span>610 Takipçi</span>
            </div>
        </div>
        <div class=""widget-text-box"">
            <h4 class=""media-heading"">");
#nullable restore
#line 17 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Shared\Components\StatisticAdmin\Default.cshtml"
                                 Write(ViewBag.AdminName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <p>");
#nullable restore
#line 18 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Shared\Components\StatisticAdmin\Default.cshtml"
          Write(ViewBag.AdminDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
    </div>
    <div class=""col-lg-2"">
        <div class=""widget navy-bg p-lg text-center"">
            <div class=""m-b-md"">
                <i class=""fa fa-shield fa-4x""></i>
                <h1 class=""m-xs"">456</h1>
                <h3 class=""font-bold no-margins"">
                    Shield
                </h3>
                <small>power</small>
            </div>
        </div>
        <div class=""widget  p-lg text-center"">
            <div class=""m-b-md"">
                <i class=""fa fa-flash fa-4x""></i>
                <h1 class=""m-xs"">612</h1>
                <h3 class=""font-bold no-margins"">
                    Thunder
                </h3>
                <small>amount</small>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""widget lazur-bg p-xl"">

            <h2>
                Janet Smith
            </h2>
            <ul class=""list-unstyled m-t-md"">
                <li>
                    <span c");
            WriteLiteral(@"lass=""fa fa-envelope m-r-xs""></span>
                    <label>Email:</label>
                    mike@mail.com
                </li>
                <li>
                    <span class=""fa fa-home m-r-xs""></span>
                    <label>Address:</label>
                    Street 200, Avenue 10
                </li>
                <li>
                    <span class=""fa fa-phone m-r-xs""></span>
                    <label>Contact:</label>
                    (+121) 678 3462
                </li>
            </ul>

        </div>
        <div class=""widget red-bg p-lg text-center"">
            <div class=""m-b-md"">
                <i class=""fa fa-bell fa-4x""></i>
                <h1 class=""m-xs"">47</h1>
                <h3 class=""font-bold no-margins"">
                    Notification
                </h3>
                <small>We detect the error.</small>
            </div>
        </div>
    </div>
    <div class=""col-lg-2"">
        <div class=""widget yellow-bg p-lg text-c");
            WriteLiteral(@"enter"">
            <div class=""m-b-md"">
                <i class=""fa fa-thumbs-up fa-4x""></i>
                <h1 class=""m-xs"">520</h1>
                <h3 class=""font-bold no-margins"">
                    Likes
                </h3>
                <small>amount</small>
            </div>
        </div>
        <div class=""widget yellow-bg p-lg text-center"">
            <div class=""m-b-md"">
                <i class=""fa fa-warning fa-4x""></i>
                <h1 class=""m-xs"">Alarm</h1>
                <h3 class=""font-bold no-margins"">
                    Do
                </h3>
                <small>something</small>
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
