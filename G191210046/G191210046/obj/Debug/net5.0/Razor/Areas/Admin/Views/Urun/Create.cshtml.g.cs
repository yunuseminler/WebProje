#pragma checksum "C:\Users\Yunus Emre\Desktop\G191210046\G191210046\Areas\Admin\Views\Urun\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aef57afd316daef5aae5c13039ac86262a91af7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Urun_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Urun/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aef57afd316daef5aae5c13039ac86262a91af7", @"/Areas/Admin/Views/Urun/Create.cshtml")]
    public class Areas_Admin_Views_Urun_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<G191210046.Models.Urun>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Yunus Emre\Desktop\G191210046\G191210046\Areas\Admin\Views\Urun\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Urun</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Ad"" class=""control-label""></label>
                <input asp-for=""Ad"" class=""form-control"" />
                <span asp-validation-for=""Ad"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Fiyat"" class=""control-label""></label>
                <input asp-for=""Fiyat"" class=""form-control"" />
                <span asp-validation-for=""Fiyat"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Aciklama"" class=""control-label""></label>
                <input asp-for=""Aciklama"" class=""form-control"" />
                <span asp-validation-for=""Aciklama"" class=""text-danger""></span>
            </div>
    ");
            WriteLiteral("        <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\Yunus Emre\Desktop\G191210046\G191210046\Areas\Admin\Views\Urun\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<G191210046.Models.Urun> Html { get; private set; }
    }
}
#pragma warning restore 1591