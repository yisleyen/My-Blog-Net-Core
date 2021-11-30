#pragma checksum "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fe3bd5cfcd9e72d13f07ad4e901544022721203"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Category\Index.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fe3bd5cfcd9e72d13f07ad4e901544022721203", @"/Areas/Admin/Views/Category/Index.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Kategoriler";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <div class=\"ibox \">\r\n            <div class=\"ibox-title\">\r\n                <h5>");
#nullable restore
#line 14 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Category\Index.cshtml"
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
                            <th>#</th>
                            <th>Adı</th>
                            <th>Kayıt Tarihi</th>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 36 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Category\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 39 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Category\Index.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 40 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Category\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Category\Index.cshtml"
                               Write(item.CreatedDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1523, "\"", 1561, 2);
            WriteAttributeValue("", 1530, "/Admin/Category/Delete/", 1530, 23, true);
#nullable restore
#line 42 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 1553, item.Id, 1553, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Silmek istediğinize emin misiniz?\')\" class=\"btn btn-white btn-sm\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1706, "\"", 1713, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Düzenle</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 45 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Category\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<a href=\"/Admin/Category/Add\" class=\"btn btn-primary btn-sm\">Yeni Kategori Ekle</a>\r\n<br /><br />\r\n");
#nullable restore
#line 55 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Areas\Admin\Views\Category\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
