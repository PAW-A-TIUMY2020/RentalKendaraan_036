#pragma checksum "D:\Project\RentalKendaraan_036\RentalKendaraan_036\Views\Peminjamen\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "462718ae034aba312dc22dc21dca3c500f938f8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Peminjamen_Details), @"mvc.1.0.view", @"/Views/Peminjamen/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Peminjamen/Details.cshtml", typeof(AspNetCore.Views_Peminjamen_Details))]
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
#line 1 "D:\Project\RentalKendaraan_036\RentalKendaraan_036\Views\_ViewImports.cshtml"
using RentalKendaraan_036;

#line default
#line hidden
#line 2 "D:\Project\RentalKendaraan_036\RentalKendaraan_036\Views\_ViewImports.cshtml"
using RentalKendaraan_036.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"462718ae034aba312dc22dc21dca3c500f938f8a", @"/Views/Peminjamen/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4118286fd30770089b00b746f90153a19d5aa54d", @"/Views/_ViewImports.cshtml")]
    public class Views_Peminjamen_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RentalKendaraan_036.Models.Peminjaman>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project\RentalKendaraan_036\RentalKendaraan_036\Views\Peminjamen\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(91, 124, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Peminjaman</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(216, 53, false);
#line 14 "D:\Project\RentalKendaraan_036\RentalKendaraan_036\Views\Peminjamen\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TanggalPeminjaman));

#line default
#line hidden
            EndContext();
            BeginContext(269, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(313, 49, false);
#line 17 "D:\Project\RentalKendaraan_036\RentalKendaraan_036\Views\Peminjamen\Details.cshtml"
       Write(Html.DisplayFor(model => model.TanggalPeminjaman));

#line default
#line hidden
            EndContext();
            BeginContext(362, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(406, 41, false);
#line 20 "D:\Project\RentalKendaraan_036\RentalKendaraan_036\Views\Peminjamen\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Biaya));

#line default
#line hidden
            EndContext();
            BeginContext(447, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(491, 37, false);
#line 23 "D:\Project\RentalKendaraan_036\RentalKendaraan_036\Views\Peminjamen\Details.cshtml"
       Write(Html.DisplayFor(model => model.Biaya));

#line default
#line hidden
            EndContext();
            BeginContext(528, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(572, 56, false);
#line 26 "D:\Project\RentalKendaraan_036\RentalKendaraan_036\Views\Peminjamen\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdCustomerNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(628, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(672, 65, false);
#line 29 "D:\Project\RentalKendaraan_036\RentalKendaraan_036\Views\Peminjamen\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdCustomerNavigation.NamaCustomer));

#line default
#line hidden
            EndContext();
            BeginContext(737, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(781, 55, false);
#line 32 "D:\Project\RentalKendaraan_036\RentalKendaraan_036\Views\Peminjamen\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdJaminanNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(836, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(880, 63, false);
#line 35 "D:\Project\RentalKendaraan_036\RentalKendaraan_036\Views\Peminjamen\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdJaminanNavigation.NamaJaminan));

#line default
#line hidden
            EndContext();
            BeginContext(943, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(987, 57, false);
#line 38 "D:\Project\RentalKendaraan_036\RentalKendaraan_036\Views\Peminjamen\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdKendaraanNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1088, 67, false);
#line 41 "D:\Project\RentalKendaraan_036\RentalKendaraan_036\Views\Peminjamen\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdKendaraanNavigation.NamaKendaraan));

#line default
#line hidden
            EndContext();
            BeginContext(1155, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1202, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4915cd8ce3b4360980f1a521e1018f7", async() => {
                BeginContext(1258, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "D:\Project\RentalKendaraan_036\RentalKendaraan_036\Views\Peminjamen\Details.cshtml"
                           WriteLiteral(Model.IdPeminjaman);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1266, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1274, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "525f1ed7859942869baf32a38cc4cedd", async() => {
                BeginContext(1296, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1312, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RentalKendaraan_036.Models.Peminjaman> Html { get; private set; }
    }
}
#pragma warning restore 1591
