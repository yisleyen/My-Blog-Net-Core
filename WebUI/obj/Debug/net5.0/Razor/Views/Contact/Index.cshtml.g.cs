#pragma checksum "C:\Yusuf\project\MyBlog\WebUI\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c061df9a3f97b568d57ae4b3f751deac62b6b4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c061df9a3f97b568d57ae4b3f751deac62b6b4a", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Yusuf\project\MyBlog\WebUI\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""main-content-w3layouts-agileits"">

    <h3 class=""tittle"">Bize ulaşın</h3>
    <div class=""contact-map inner-sec"">

        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d100949.24429313939!2d-122.44206553967531!3d37.75102885910819!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x80859a6d00690021%3A0x4a501367f076adff!2sSan+Francisco%2C+CA%2C+USA!5e0!3m2!1sen!2sin!4v1472190196783""
                class=""map"" style=""border:0""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 568, "\"", 586, 0);
            EndWriteAttribute();
            WriteLiteral(@"></iframe>
    </div>
    <div class=""ad-inf-sec bg-light"">
        <div class=""container"">
            <div class=""address row"">

                <div class=""col-lg-4 address-grid"">
                    <div class=""row address-info"">
                        <div class=""col-md-4 address-left text-center"">
                            <i class=""far fa-map""></i>
                        </div>
                        <div class=""col-md-8 address-right text-left"">
                            <h6>Adres</h6>
                            <p>
                                İstabul / Türkiye
                            </p>
                        </div>
                    </div>

                </div>
                <div class=""col-lg-4 address-grid"">
                    <div class=""row address-info"">
                        <div class=""col-md-4 address-left text-center"">
                            <i class=""far fa-envelope""></i>
                        </div>
                        <div c");
            WriteLiteral(@"lass=""col-md-8 address-right text-left"">
                            <h6>E-Posta Adresi</h6>
                            <p>
                                E-Posta :
                                <a href=""mailto:blog@webui.com"">blog@webui.com</a>

                            </p>
                        </div>

                    </div>
                </div>
                <div class=""col-lg-4 address-grid"">
                    <div class=""row address-info"">
                        <div class=""col-md-4 address-left text-center"">
                            <i class=""fas fa-mobile-alt""></i>
                        </div>
                        <div class=""col-md-8 address-right text-left"">
                            <h6>Telefon</h6>
                            <p>+90 555 555 5555</p>

                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""container"">
        <div class=""contact_grid_right");
            WriteLiteral("\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c061df9a3f97b568d57ae4b3f751deac62b6b4a6857", async() => {
                WriteLiteral(@"
                <div class=""row contact_left_grid"">
                    <div class=""col-md-6 con-left"">
                        <div class=""form-group"">
                            <label for=""validationCustom01 my-2"">Adınız</label>
                            <input class=""form-control"" type=""text"" name=""UserName""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3004, "\"", 3018, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 3019, "\"", 3030, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleFormControlInput1"">E-Posta Adresi</label>
                            <input class=""form-control"" type=""email"" name=""EMail""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3287, "\"", 3301, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 3302, "\"", 3313, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"validationCustom03 my-2\">Konu</label>\r\n                            <input class=\"form-control\" type=\"text\" name=\"Subject\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3560, "\"", 3574, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 3575, "\"", 3586, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""col-md-6 con-right"">
                        <div class=""form-group"">
                            <label for=""textarea"">Mesaj</label>
                            <textarea id=""textarea"" name=""Message""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3885, "\"", 3899, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n                        </div>\r\n                        <input class=\"form-control\" type=\"submit\" value=\"Gönder\">\r\n\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>");
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
