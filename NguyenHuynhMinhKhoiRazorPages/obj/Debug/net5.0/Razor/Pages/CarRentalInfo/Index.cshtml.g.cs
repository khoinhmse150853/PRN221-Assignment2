#pragma checksum "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CarRentalInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "557a95766b820934461e0e3a72de9fe799185b6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NguyenHuynhMinhKhoiRazorPages.Pages.CarRentalInfo.Pages_CarRentalInfo_Index), @"mvc.1.0.razor-page", @"/Pages/CarRentalInfo/Index.cshtml")]
namespace NguyenHuynhMinhKhoiRazorPages.Pages.CarRentalInfo
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
#line 1 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\_ViewImports.cshtml"
using NguyenHuynhMinhKhoiRazorPages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"557a95766b820934461e0e3a72de9fe799185b6f", @"/Pages/CarRentalInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f643736c2bf15fc910a8ceafdb356ef67989f12", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CarRentalInfo_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CarRentalInfo\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "557a95766b820934461e0e3a72de9fe799185b6f3741", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CarRentalInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CarRental[0].RentPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CarRentalInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CarRental[0].Car));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CarRentalInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CarRental[0].Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CarRentalInfo\Index.cshtml"
 foreach (var item in Model.CarRental) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CarRentalInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RentPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CarRentalInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Car.CarId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CarRentalInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CarRentalInfo\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 43 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CarRentalInfo\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 44 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CarRentalInfo\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CarRentalInfo\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NguyenHuynhMinhKhoiRazorPages.Pages.CarRentalInfo.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NguyenHuynhMinhKhoiRazorPages.Pages.CarRentalInfo.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NguyenHuynhMinhKhoiRazorPages.Pages.CarRentalInfo.IndexModel>)PageContext?.ViewData;
        public NguyenHuynhMinhKhoiRazorPages.Pages.CarRentalInfo.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
