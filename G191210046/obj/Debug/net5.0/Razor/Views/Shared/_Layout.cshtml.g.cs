#pragma checksum "C:\Users\Yunus Emre\Desktop\G191210046\G191210046\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf472ea7178222e2b4557e70f043c9f279e3530b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Yunus Emre\Desktop\G191210046\G191210046\Views\_ViewImports.cshtml"
using G191210046;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yunus Emre\Desktop\G191210046\G191210046\Views\_ViewImports.cshtml"
using G191210046.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf472ea7178222e2b4557e70f043c9f279e3530b", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fad1abace4bc596beddf40ee9decc3483186a78", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf472ea7178222e2b4557e70f043c9f279e3530b4284", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "C:\Users\Yunus Emre\Desktop\G191210046\G191210046\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - G191210046</title>

    <link href=""https://fonts.googleapis.com/css2?family=Open+Sans:ital,wght@0,400;0,600;0,700;1,400&family=Poppins:wght@600&display=swap"" rel=""stylesheet"">
    <link href=""/lib/bootstrap/dist/css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""/lib/bootstrap/dist/css/fontawesome-all.min.css"" rel=""stylesheet"">
    <link href=""/lib/bootstrap/dist/css/swiper.css"" rel=""stylesheet"">
    <link href=""/lib/bootstrap/dist/css/styles.css"" rel=""stylesheet"">
    <link rel=""icon"" href=""/lib/bootstrap/dist/images/favicon.png"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf472ea7178222e2b4557e70f043c9f279e3530b6186", async() => {
                WriteLiteral(@"
    <!-- Navigation -->
    <nav id=""navbar"" class=""navbar navbar-expand-lg fixed-top navbar-dark"" aria-label=""Main navigation"">
        <div class=""container"">

            <!-- Image Logo -->
            <a class=""navbar-brand logo-image"" href=""index.html""><img src=""/lib/bootstrap/dist/images/logo.svg"" alt=""alternative""></a>

            <!-- Text Logo - Use this if you don't have a graphic logo -->
            <!-- <a class=""navbar-brand logo-text"" href=""index.html"">Elma</a> -->

            <button class=""navbar-toggler p-0 border-0"" type=""button"" id=""navbarSideCollapse"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>

            <div class=""navbar-collapse offcanvas-collapse"" id=""navbarsExampleDefault"">
                <ul class=""navbar-nav ms-auto navbar-nav-scroll"">
                    <li class=""nav-item"">
                        <a class=""nav-link active"" aria-current=""page"" href=""#header"">Home</a>
                  ");
                WriteLiteral(@"  </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#projects"">Projects</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#services"">Services</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#about"">About</a>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""dropdown01"" data-bs-toggle=""dropdown"" aria-expanded=""false"">Drop</a>
                        <ul class=""dropdown-menu"" aria-labelledby=""dropdown01"">
                            <li><a class=""dropdown-item"" href=""article.html"">Article Details</a></li>
                            <li><div class=""dropdown-divider""></div></li>
                            <li><a class=""dropdown-item"" href=""terms.html"">Terms Conditions</a></li>
                            <l");
                WriteLiteral(@"i><div class=""dropdown-divider""></div></li>
                            <li><a class=""dropdown-item"" href=""privacy.html"">Privacy Policy</a></li>
                        </ul>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#contact"">Contact</a>
                    </li>
                </ul>
                <span class=""nav-item social-icons"">
                    <span class=""fa-stack"">
                        <a href=""#your-link"">
                            <i class=""fas fa-circle fa-stack-2x""></i>
                            <i class=""fab fa-facebook-f fa-stack-1x""></i>
                        </a>
                    </span>
                    <span class=""fa-stack"">
                        <a href=""#your-link"">
                            <i class=""fas fa-circle fa-stack-2x""></i>
                            <i class=""fab fa-twitter fa-stack-1x""></i>
                        </a>
                    </span>
        ");
                WriteLiteral(@"        </span>
            </div> <!-- end of navbar-collapse -->
        </div> <!-- end of container -->
    </nav> <!-- end of navbar -->
    <!-- end of navigation -->
    <!-- Header -->
    <header id=""header"" class=""header"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6"">
                    <h1 class=""h1-large"">PLAN<br> DESIGN<br> DEVELOP</h1>
                </div> <!-- end of col -->
                <div class=""col-lg-6"">
                    <div class=""button-container"">
                        <a class=""btn-solid-lg page-scroll"" href=""#intro"">Discover</a>
                        <a class=""btn-outline-lg page-scroll"" href=""#contact"">Contact</a>
                    </div> <!-- end of button-container -->
                </div> <!-- end of col -->
            </div> <!-- end of row -->
        </div> <!-- end of container -->
    </header> <!-- end of header -->
    <!-- end of header -->

    <div class=""container"">
      ");
                WriteLiteral("  <main role=\"main\" class=\"pb-3\">\r\n            ");
#nullable restore
#line 96 "C:\Users\Yunus Emre\Desktop\G191210046\G191210046\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </main>\r\n    </div>\r\n\r\n    <footer class=\"border-top footer text-muted\">\r\n        <div class=\"container\">\r\n            &copy; 2021 - G191210046 - ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf472ea7178222e2b4557e70f043c9f279e3530b11272", async() => {
                    WriteLiteral("Privacy");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
    </footer>

    <!-- Scripts -->
    <script src=""/lib/bootstrap/dist/js/bootstrap.min.js""></script> <!-- Bootstrap framework -->
    <script src=""/lib/bootstrap/dist/js/swiper.min.js""></script> <!-- Swiper for image and text sliders -->
    <script src=""/lib/bootstrap/dist/js/purecounter.min.js""></script> <!-- Purecounter counter for statistics numbers -->
    <script src=""/lib/bootstrap/dist/js/scripts.js""></script> <!-- Custom scripts -->
    ");
#nullable restore
#line 111 "C:\Users\Yunus Emre\Desktop\G191210046\G191210046\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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