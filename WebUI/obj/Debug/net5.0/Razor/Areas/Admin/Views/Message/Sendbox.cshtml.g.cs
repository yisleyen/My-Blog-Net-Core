#pragma checksum "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Message\Sendbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec7f8dc58c28f8da889ce5a2d21b2c303edab040"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Message_Sendbox), @"mvc.1.0.view", @"/Areas/Admin/Views/Message/Sendbox.cshtml")]
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
#nullable restore
#line 1 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Message\Sendbox.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec7f8dc58c28f8da889ce5a2d21b2c303edab040", @"/Areas/Admin/Views/Message/Sendbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Message_Sendbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Message\Sendbox.cshtml"
  
    ViewData["Title"] = "Inbox";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"wrapper wrapper-content\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12 animated fadeInRight\">\r\n            <div class=\"mail-box-header\">\r\n                <h2>\r\n                    Gelen Kutusu (");
#nullable restore
#line 12 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Message\Sendbox.cshtml"
                             Write(ViewBag.MessageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                </h2>\r\n            </div>\r\n            <div class=\"mail-box\">\r\n                <table class=\"table table-hover table-mail\">\r\n                    <tbody>\r\n");
#nullable restore
#line 18 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Message\Sendbox.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"read\">\r\n                                <td class=\"mail-ontact\">");
#nullable restore
#line 21 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Message\Sendbox.cshtml"
                                                   Write(item.ReceiverUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"mail-subject\"><a href=\"mail_detail.html\">");
#nullable restore
#line 22 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Message\Sendbox.cshtml"
                                                                               Write(item.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td class=\"text-right mail-date\">");
#nullable restore
#line 23 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Message\Sendbox.cshtml"
                                                            Write(item.CreatedDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 25 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Message\Sendbox.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
