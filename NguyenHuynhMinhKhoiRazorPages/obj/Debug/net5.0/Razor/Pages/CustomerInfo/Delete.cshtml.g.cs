#pragma checksum "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CustomerInfo\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aabf706fcfeddc61104ba164a9708e33778bdd81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NguyenHuynhMinhKhoiRazorPages.Pages.CustomerInfo.Pages_CustomerInfo_Delete), @"mvc.1.0.razor-page", @"/Pages/CustomerInfo/Delete.cshtml")]
namespace NguyenHuynhMinhKhoiRazorPages.Pages.CustomerInfo
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aabf706fcfeddc61104ba164a9708e33778bdd81", @"/Pages/CustomerInfo/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f643736c2bf15fc910a8ceafdb356ef67989f12", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CustomerInfo_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CustomerInfo\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CustomerInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CustomerInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CustomerInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CustomerInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CustomerInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.CustomerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CustomerInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.CustomerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CustomerInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.CustomerPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CustomerInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.CustomerPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CustomerInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.IdentityCard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CustomerInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.IdentityCard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CustomerInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.LicenceNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CustomerInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.LicenceNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CustomerInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.LicenceDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CustomerInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Customer.LicenceDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aabf706fcfeddc61104ba164a9708e33778bdd8110137", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aabf706fcfeddc61104ba164a9708e33778bdd8110404", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 61 "C:\Users\DELL\source\repos\NguyenHuynhMinhKhoi_SE150853_A02\NguyenHuynhMinhKhoiRazorPages\Pages\CustomerInfo\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Customer.CustomerId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aabf706fcfeddc61104ba164a9708e33778bdd8112251", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NguyenHuynhMinhKhoiRazorPages.Pages.CustomerInfo.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NguyenHuynhMinhKhoiRazorPages.Pages.CustomerInfo.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NguyenHuynhMinhKhoiRazorPages.Pages.CustomerInfo.DeleteModel>)PageContext?.ViewData;
        public NguyenHuynhMinhKhoiRazorPages.Pages.CustomerInfo.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
