#pragma checksum "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterMessageNotification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "707fbd0e8c22563d6f2dd819c0c062189f07d24b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterMessageNotification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterMessageNotification/Default.cshtml")]
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
#line 1 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"707fbd0e8c22563d6f2dd819c0c062189f07d24b", @"/Views/Shared/Components/WriterMessageNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterMessageNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/_writer/assets/images/faces/face4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"messageDropdown\">\r\n    <h6 class=\"p-3 mb-0\">Mesajlar</h6>\r\n");
#nullable restore
#line 6 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"dropdown-divider\"></div>\r\n        <a class=\"dropdown-item preview-item\">\r\n            <div class=\"preview-thumbnail\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "707fbd0e8c22563d6f2dd819c0c062189f07d24b5113", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            WriteLiteral("\r\n            </div>\r\n            <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n                <h6 class=\"preview-subject ellipsis mb-1 font-weight-normal\">");
#nullable restore
#line 14 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                                                                        Write(item.SenderUser.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" sana mesaj gönderdi</h6>\r\n");
#nullable restore
#line 15 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                  
                    DateTime end = (DateTime)item.CreatedDate;
                    DateTime now = DateTime.Now;
                    TimeSpan diff = end.Subtract(now);
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                 if (diff.Days != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"text-gray mb-0\">");
#nullable restore
#line 22 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                                         Write(Convert.ToInt32(diff.ToString(@"dd")));

#line default
#line hidden
#nullable disable
            WriteLiteral(" gün önce</p>\r\n");
#nullable restore
#line 23 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                }
                else if (diff.Days == 0 && diff.Hours != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"text-gray mb-0\">");
#nullable restore
#line 26 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                                         Write(Convert.ToInt32(diff.ToString(@"hh")));

#line default
#line hidden
#nullable disable
            WriteLiteral(" saat önce</p>\r\n");
#nullable restore
#line 27 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                }
                else if (diff.Days == 0 && diff.Hours == 0 && diff.Minutes != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"text-gray mb-0\">");
#nullable restore
#line 30 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                                         Write(Convert.ToInt32(diff.ToString(@"mm")));

#line default
#line hidden
#nullable disable
            WriteLiteral(" dakika önce</p>\r\n");
#nullable restore
#line 31 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"text-gray mb-0\">");
#nullable restore
#line 34 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                                         Write(Convert.ToInt32(diff.ToString(@"ss")));

#line default
#line hidden
#nullable disable
            WriteLiteral(" saniye önce</p>\r\n");
#nullable restore
#line 35 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </a>\r\n");
#nullable restore
#line 38 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"dropdown-divider\"></div>\r\n    <h6 class=\"p-3 mb-0 text-center\">");
#nullable restore
#line 40 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                                Write(ViewBag.TotalMessageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" yeni mesaj</h6>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; }
    }
}
#pragma warning restore 1591
