#pragma checksum "C:\Users\mikay\OneDrive\Рабочий стол\P126\Asp\Front to Back\WebApplication\WebApplication\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07c2f570e8fba0a6d6a9f446f3fc43a4c9b5792c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c2f570e8fba0a6d6a9f446f3fc43a4c9b5792c", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("./home.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\mikay\OneDrive\Рабочий стол\P126\Asp\Front to Back\WebApplication\WebApplication\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <hr>
    <section id=""login-register"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-6"">
                    <div class=""login"">
                        <h2>LOGIN</h2>
                        <hr>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07c2f570e8fba0a6d6a9f446f3fc43a4c9b5792c3782", async() => {
                WriteLiteral("\r\n                            <label for=\"username\">Username or email address *</label><br>\r\n                            <input class=\"login-pass\" type=\"email\"");
                BeginWriteAttribute("name", " name=\"", 518, "\"", 525, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 526, "\"", 531, 0);
                EndWriteAttribute();
                WriteLiteral("><br>\r\n                            <label for=\"password\">Password *</label><br>\r\n                            <input class=\"login-pass\" type=\"password\"");
                BeginWriteAttribute("name", " name=\"", 682, "\"", 689, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 690, "\"", 695, 0);
                EndWriteAttribute();
                WriteLiteral("><br>\r\n                            <input type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 753, "\"", 760, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 761, "\"", 766, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <span>Remember me</span><br><br>\r\n                            <button href=\"./home.html\" type=\"submit\">Log in</button><br><br>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 956, "\"", 963, 0);
                EndWriteAttribute();
                WriteLiteral(">Lost your password?</a>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-6\">\r\n                    <div class=\"register\">\r\n                        <h2>REGISTER</h2>\r\n                        <hr>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07c2f570e8fba0a6d6a9f446f3fc43a4c9b5792c6912", async() => {
                WriteLiteral("\r\n                            <label for=\"username\">Email address *</label><br>\r\n                            <input class=\"login-pass\" type=\"email\"");
                BeginWriteAttribute("name", " name=\"", 1427, "\"", 1434, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1435, "\"", 1440, 0);
                EndWriteAttribute();
                WriteLiteral("><br>\r\n                            <label for=\"password\">Password *</label><br>\r\n                            <input class=\"login-pass\" type=\"password\"");
                BeginWriteAttribute("name", " name=\"", 1591, "\"", 1598, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1599, "\"", 1604, 0);
                EndWriteAttribute();
                WriteLiteral(@"><br>
                            <p>
                                Your personal data will be used to support your experience throughout this website,
                                to<br>manage access to your account, and for other purposes described in our <a");
                BeginWriteAttribute("href", " href=\"", 1873, "\"", 1880, 0);
                EndWriteAttribute();
                WriteLiteral(">privacy policy</a>.\r\n                            </p>\r\n                            <button href=\"./home.html\" type=\"submit\">Register</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>");
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
