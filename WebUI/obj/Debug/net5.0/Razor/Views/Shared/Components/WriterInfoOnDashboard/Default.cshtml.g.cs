#pragma checksum "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterInfoOnDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b6f7fb79191e0dcf56e79d137d550187d2bda26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterInfoOnDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterInfoOnDashboard/Default.cshtml")]
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
#line 1 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterInfoOnDashboard\Default.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b6f7fb79191e0dcf56e79d137d550187d2bda26", @"/Views/Shared/Components/WriterInfoOnDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterInfoOnDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Writer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Yazar Hakkında</h4>
                <div class=""d-flex mt-5 align-items-top"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 317, "\"", 335, 1);
#nullable restore
#line 9 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterInfoOnDashboard\Default.cshtml"
WriteAttributeValue("", 323, Model.Image, 323, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-sm rounded-circle mr-3\" alt=\"image\">\r\n                    <div class=\"mb-0 flex-grow\">\r\n                        <h5 class=\"mr-2 mb-2\">");
#nullable restore
#line 11 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterInfoOnDashboard\Default.cshtml"
                                         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"mb-0 font-weight-light\">");
#nullable restore
#line 12 "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Shared\Components\WriterInfoOnDashboard\Default.cshtml"
                                                     Write(Model.About);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                    <div class=""ml-auto"">
                        <i class=""mdi mdi-heart-outline text-muted""></i>
                    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Writer> Html { get; private set; }
    }
}
#pragma warning restore 1591
