#pragma checksum "C:\Users\ACER\source\repos\login3\login3\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1abf1643aeb1555aa44eb0e9c7c85932d18d2ab2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
#line 1 "C:\Users\ACER\source\repos\login3\login3\Views\_ViewImports.cshtml"
using login3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\source\repos\login3\login3\Views\_ViewImports.cshtml"
using login3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1abf1643aeb1555aa44eb0e9c7c85932d18d2ab2", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde9cdb235609c7a6d6372f232514f3b8a647281", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Verify"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ACER\source\repos\login3\login3\Views\Account\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <section class=""main"">
        <div class=""layer"">

            <div class=""bottom-grid"">
                <div class=""logo"">
                    <h1> <a href=""index.html""><span class=""fa fa-key""></span> Key</a></h1>
                </div>
                <div class=""links"">
                    <ul class=""links-unordered-list"">
                        <li class=""active"">
                            <a href=""#""");
            BeginWriteAttribute("class", " class=\"", 520, "\"", 528, 0);
            EndWriteAttribute();
            WriteLiteral(">Login</a>\r\n                        </li>\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 599, "\"", 607, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <a href=\"#\"");
            BeginWriteAttribute("class", " class=\"", 650, "\"", 658, 0);
            EndWriteAttribute();
            WriteLiteral(">About Us</a>\r\n                        </li>\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 732, "\"", 740, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <a href=\"#\"");
            BeginWriteAttribute("class", " class=\"", 783, "\"", 791, 0);
            EndWriteAttribute();
            WriteLiteral(">Register</a>\r\n                        </li>\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 865, "\"", 873, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <a href=\"#\"");
            BeginWriteAttribute("class", " class=\"", 916, "\"", 924, 0);
            EndWriteAttribute();
            WriteLiteral(@">Contact</a>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""content-w3ls"">
                <div class=""text-center icon"">
                    <span class=""fa fa-html5""></span>
                </div>
                <div class=""content-bottom"">


                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1abf1643aeb1555aa44eb0e9c7c85932d18d2ab26244", async() => {
                WriteLiteral(@"
                        <div class=""field-group"">
                            <span class=""fa fa-user"" aria-hidden=""true""></span>
                            <div class=""wthree-field"">
                                <input name=""Name"" id=""text1"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 1577, "\"", 1585, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Username"" required>
                            </div>
                        </div>
                        <div class=""field-group"">
                            <span class=""fa fa-lock"" aria-hidden=""true""></span>
                            <div class=""wthree-field"">
                                <input name=""Password"" id=""myInput"" type=""Password"" placeholder=""Password"">
                            </div>
                        </div>
                        <div class=""wthree-field"">
                            <button type=""submit"" class=""btn"">Get Started</button>
                        </div>
                        <ul class=""list-login"">
                            <li class=""switch-agileits"">
                                <label class=""switch"">
                                    <input type=""checkbox"">
                                    <span class=""slider round""></span>
                                    keep Logged in
                                </label>");
                WriteLiteral(@"
                            </li>
                            <li>
                                <a href=""#"" class=""text-right"">forgot password?</a>
                            </li>
                            <li class=""clearfix""></li>
                        </ul>
                        <ul class=""list-login-bottom"">
                            <li");
                BeginWriteAttribute("class", " class=\"", 2975, "\"", 2983, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <a href=\"#\"");
                BeginWriteAttribute("class", " class=\"", 3030, "\"", 3038, 0);
                EndWriteAttribute();
                WriteLiteral(">Create Account</a>\r\n                            </li>\r\n                            <li");
                BeginWriteAttribute("class", " class=\"", 3126, "\"", 3134, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <a href=\"#\" class=\"text-right\">Need Help?</a>\r\n                            </li>\r\n                            <li class=\"clearfix\"></li>\r\n                        </ul>\r\n                    ");
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
            WriteLiteral("\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"bottom-grid1\">\r\n                <div class=\"links\">\r\n                    <ul class=\"links-unordered-list\">\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 3577, "\"", 3585, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <a href=\"#\"");
            BeginWriteAttribute("class", " class=\"", 3628, "\"", 3636, 0);
            EndWriteAttribute();
            WriteLiteral(">About Us</a>\r\n                        </li>\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 3710, "\"", 3718, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <a href=\"#\"");
            BeginWriteAttribute("class", " class=\"", 3761, "\"", 3769, 0);
            EndWriteAttribute();
            WriteLiteral(">Privacy Policy</a>\r\n                        </li>\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 3849, "\"", 3857, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <a href=\"#\"");
            BeginWriteAttribute("class", " class=\"", 3900, "\"", 3908, 0);
            EndWriteAttribute();
            WriteLiteral(@">Terms of Use</a>
                        </li>
                    </ul>
                </div>
                <div class=""copyright"">
                    <p>
                        Â© 2019 Key. All rights reserved | Design by
                        <a href=""http://w3layouts.com"">W3layouts</a>
                    </p>
                </div>
            </div>
        </div>
    </section>


");
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