#pragma checksum "C:\Users\Alexandr\Desktop\VsePikchi\VsePikchi\Views\Home\RandomGenerator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd01dc0ab322a58fdb151ebef6af88bc03fc0ee2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RandomGenerator), @"mvc.1.0.view", @"/Views/Home/RandomGenerator.cshtml")]
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
#line 1 "C:\Users\Alexandr\Desktop\VsePikchi\VsePikchi\Views\_ViewImports.cshtml"
using VsePikchi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alexandr\Desktop\VsePikchi\VsePikchi\Views\_ViewImports.cshtml"
using VsePikchi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd01dc0ab322a58fdb151ebef6af88bc03fc0ee2", @"/Views/Home/RandomGenerator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a2eaf64ca46d74b3db8676ea001324dc151dee2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RandomGenerator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VsePikchi.Models.Picture>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/copy-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Alexandr\Desktop\VsePikchi\VsePikchi\Views\Home\RandomGenerator.cshtml"
  
    ViewData["Title"] = "RandomGenerator";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"img-block\">\r\n    <div class=\"actions-bar\">\r\n        <div class=\"actions-bar__item\">\r\n");
#nullable restore
#line 10 "C:\Users\Alexandr\Desktop\VsePikchi\VsePikchi\Views\Home\RandomGenerator.cshtml"
             using (Html.BeginForm("RandomPicture", "Picture"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button class=\"generate-image-button\">Сгенерировать новую</button>\r\n");
#nullable restore
#line 13 "C:\Users\Alexandr\Desktop\VsePikchi\VsePikchi\Views\Home\RandomGenerator.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"actions-bar__item\">\r\n            <div class=\"url-block\">\r\n                <button class=\"copy-button\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fd01dc0ab322a58fdb151ebef6af88bc03fc0ee24885", async() => {
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
            WriteLiteral("\r\n                </button>\r\n                <span class=\"url-span\"\r\n                      style=\"width: 200px; color: #000000; text-align: center; font-family: \'Segoe UI\', \'Open Sans\', \'Helvetica Neue\', sans-serif\">");
#nullable restore
#line 21 "C:\Users\Alexandr\Desktop\VsePikchi\VsePikchi\Views\Home\RandomGenerator.cshtml"
                                                                                                                                              Write(Model.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"large-img\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 906, "\"", 922, 1);
#nullable restore
#line 26 "C:\Users\Alexandr\Desktop\VsePikchi\VsePikchi\Views\Home\RandomGenerator.cshtml"
WriteAttributeValue("", 912, Model.Url, 912, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                 alt=\"", 923, "\"", 947, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VsePikchi.Models.Picture> Html { get; private set; }
    }
}
#pragma warning restore 1591