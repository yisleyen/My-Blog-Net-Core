#pragma checksum "C:\Yusuf\project\MyBlog\WebUI\Views\Shared\Components\LatestBlogPosts\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b09ef56deb77875309af7050eddbe9bdd6e22a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LatestBlogPosts_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LatestBlogPosts/Default.cshtml")]
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
#line 1 "C:\Yusuf\project\MyBlog\WebUI\Views\Shared\Components\LatestBlogPosts\Default.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b09ef56deb77875309af7050eddbe9bdd6e22a4", @"/Views/Shared/Components/LatestBlogPosts/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LatestBlogPosts_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n    <h3>Son Yazılar</h3>\r\n");
#nullable restore
#line 6 "C:\Yusuf\project\MyBlog\WebUI\Views\Shared\Components\LatestBlogPosts\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 248, "\"", 281, 2);
            WriteAttributeValue("", 255, "/Blog/BlogDetails/", 255, 18, true);
#nullable restore
#line 10 "C:\Yusuf\project\MyBlog\WebUI\Views\Shared\Components\LatestBlogPosts\Default.cshtml"
WriteAttributeValue("", 273, item.Id, 273, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 309, "\"", 326, 1);
#nullable restore
#line 11 "C:\Yusuf\project\MyBlog\WebUI\Views\Shared\Components\LatestBlogPosts\Default.cshtml"
WriteAttributeValue("", 315, item.Image, 315, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 358, "\"", 364, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 508, "\"", 541, 2);
            WriteAttributeValue("", 515, "/Blog/BlogDetails/", 515, 18, true);
#nullable restore
#line 17 "C:\Yusuf\project\MyBlog\WebUI\Views\Shared\Components\LatestBlogPosts\Default.cshtml"
WriteAttributeValue("", 533, item.Id, 533, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Yusuf\project\MyBlog\WebUI\Views\Shared\Components\LatestBlogPosts\Default.cshtml"
                                                    Write(item.Content.Substring(0, item.Content.Substring(0, 55).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 21 "C:\Yusuf\project\MyBlog\WebUI\Views\Shared\Components\LatestBlogPosts\Default.cshtml"
                                                Write(item.CreatedDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 26 "C:\Yusuf\project\MyBlog\WebUI\Views\Shared\Components\LatestBlogPosts\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
