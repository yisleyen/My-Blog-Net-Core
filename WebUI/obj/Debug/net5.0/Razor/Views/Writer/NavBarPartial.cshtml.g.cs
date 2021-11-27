#pragma checksum "C:\Yusuf\project\My-Blog-Net-Core\WebUI\Views\Writer\NavBarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d79de344071ab61095a17ef939487a4f58174930"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_NavBarPartial), @"mvc.1.0.view", @"/Views/Writer/NavBarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d79de344071ab61095a17ef939487a4f58174930", @"/Views/Writer/NavBarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_NavBarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/_writer/assets/images/faces/face1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<nav class=\"sidebar sidebar-offcanvas\" id=\"sidebar\">\r\n    <ul class=\"nav\">\r\n        <li class=\"nav-item nav-profile\">\r\n            <a href=\"#\" class=\"nav-link\">\r\n                <div class=\"nav-profile-image\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d79de344071ab61095a17ef939487a4f581749304058", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <span class=""login-status online""></span>
                </div>
                <div class=""nav-profile-text d-flex flex-column"">
                    <span class=""font-weight-bold mb-2"">Yusuf İşleyen</span>
                    <span class=""text-secondary text-small"">Yazılım Uzmanı</span>
                </div>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Dashboard/Index"">
                <span class=""menu-title"">Dashboard</span>
                <i class=""mdi mdi-home menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/EditProfile"">
                <span class=""menu-title"">Hesap Bilgileri</span>
                <i class=""mdi mdi-contacts menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Blog/WriterBlogList"">
                <span class=""menu-title"">Yazılarım</span>
           ");
            WriteLiteral(@"     <i class=""mdi mdi-newspaper menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Blog/Add"">
                <span class=""menu-title"">Yeni Yazı</span>
                <i class=""mdi mdi-adobe menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Message/List"">
                <span class=""menu-title"">Mesajlar</span>
                <i class=""mdi mdi-message menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Notification/List"">
                <span class=""menu-title"">Bildirimler</span>
                <i class=""mdi mdi-call-missed menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/EditProfile"">
                <span class=""menu-title"">Ayarlar</span>
                <i class=""mdi mdi-settings menu-icon""></i>
            </a>");
            WriteLiteral(@"
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Blog/Index"">
                <span class=""menu-title"">Siteye Git</span>
                <i class=""mdi mdi-car menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/LogOut"">
                <span class=""menu-title"">Çıkış</span>
                <i class=""mdi mdi-logout menu-icon""></i>
            </a>
        </li>
    </ul>
</nav>");
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
