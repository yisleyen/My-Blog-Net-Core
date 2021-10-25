#pragma checksum "C:\Yusuf\project\MyBlog\WebUI\Views\Blog\WriterBlogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbecebce183f528404ef123dd5bdb9644b412608"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_WriterBlogList), @"mvc.1.0.view", @"/Views/Blog/WriterBlogList.cshtml")]
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
#line 1 "C:\Yusuf\project\MyBlog\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Yusuf\project\MyBlog\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Yusuf\project\MyBlog\WebUI\Views\Blog\WriterBlogList.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbecebce183f528404ef123dd5bdb9644b412608", @"/Views/Blog/WriterBlogList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_WriterBlogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Yusuf\project\MyBlog\WebUI\Views\Blog\WriterBlogList.cshtml"
  
    ViewData["Title"] = "WriterBlogList";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""page-header"">
    <h3 class=""page-title"">Yazılar</h3>
</div>
<div class=""row"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Başlık</th>
                            <th>Kayıt Tarihi</th>
                            <th>Kategori</th>
                            <th>Durumu</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 28 "C:\Yusuf\project\MyBlog\WebUI\Views\Blog\WriterBlogList.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 31 "C:\Yusuf\project\MyBlog\WebUI\Views\Blog\WriterBlogList.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 32 "C:\Yusuf\project\MyBlog\WebUI\Views\Blog\WriterBlogList.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 33 "C:\Yusuf\project\MyBlog\WebUI\Views\Blog\WriterBlogList.cshtml"
                               Write(item.CreatedDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 34 "C:\Yusuf\project\MyBlog\WebUI\Views\Blog\WriterBlogList.cshtml"
                               Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 36 "C:\Yusuf\project\MyBlog\WebUI\Views\Blog\WriterBlogList.cshtml"
                                     if (item.Status)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"badge badge-success\">Aktif</span>\r\n");
#nullable restore
#line 39 "C:\Yusuf\project\MyBlog\WebUI\Views\Blog\WriterBlogList.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"badge badge-secondary\">Pasif</span>\r\n");
#nullable restore
#line 43 "C:\Yusuf\project\MyBlog\WebUI\Views\Blog\WriterBlogList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1744, "\"", 1751, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-fw\">Sil</a> <a");
            BeginWriteAttribute("href", " href=\"", 1793, "\"", 1800, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-fw\">Düzenle</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 47 "C:\Yusuf\project\MyBlog\WebUI\Views\Blog\WriterBlogList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 2029, "\"", 2036, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-fw\">Yeni Yazı</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
