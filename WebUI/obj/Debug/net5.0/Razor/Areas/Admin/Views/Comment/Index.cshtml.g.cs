#pragma checksum "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3356ee72f9a419768708abc7e847661676c0acf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/Index.cshtml")]
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
#line 1 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Comment\Index.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3356ee72f9a419768708abc7e847661676c0acf", @"/Areas/Admin/Views/Comment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Comment\Index.cshtml"
  
    ViewData["Title"] = "Yorumlar";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <div class=\"ibox \">\r\n            <div class=\"ibox-title\">\r\n                <h5>");
#nullable restore
#line 12 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Comment\Index.cshtml"
               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                <div class=""ibox-tools"">
                    <a class=""collapse-link"">
                        <i class=""fa fa-chevron-up""></i>
                    </a>
                    <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                        <i class=""fa fa-wrench""></i>
                    </a>
                </div>
            </div>
            <div class=""ibox-content"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>Yazan</th>
                            <th>Ba??l??k</th>
                            <th>Durum</th>
                            <th>Puan</th>
                            <th>Tarih</th>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 36 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Comment\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 39 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Comment\Index.cshtml"
                               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 40 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Comment\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Comment\Index.cshtml"
                               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Comment\Index.cshtml"
                               Write(item.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Comment\Index.cshtml"
                               Write(item.CreatedDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1667, "\"", 1704, 2);
            WriteAttributeValue("", 1674, "/Admin/Comment/Delete/", 1674, 22, true);
#nullable restore
#line 44 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 1696, item.Id, 1696, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Silmek istedi??inize emin misiniz?\')\" class=\"btn btn-white btn-sm\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1849, "\"", 1856, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\">D??zenle</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 47 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Comment\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
