#pragma checksum "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "362ee9da751b57f0acb5c43cfa9b9c2fd71b6ef4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 2 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Views\_ViewImports.cshtml"
using P129Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Views\_ViewImports.cshtml"
using P129Allup.ViewModels.BasketViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Views\_ViewImports.cshtml"
using P129Allup.ViewModels.HeaderViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Views\_ViewImports.cshtml"
using P129Allup.ViewModels.HomeViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Views\_ViewImports.cshtml"
using P129Allup.ViewModels.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Views\_ViewImports.cshtml"
using P129Allup.ViewModels.OrderViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"362ee9da751b57f0acb5c43cfa9b9c2fd71b6ef4", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877fd0647f5d3de0472e00b00c19ae9be8674dce", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--====== Breadcrumb Part Start ======-->

<div class=""breadcrumb-area"">
    <div class=""container-fluid custom-container"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                <li class=""breadcrumb-item active"">Checkout</li>
            </ol>
        </nav>
    </div> <!-- container -->
</div>

<!--====== Breadcrumb Part Ends ======-->
<!--====== Checkout Part Start ======-->

<section class=""checkout-area pt-10"">
    <div class=""container-fluid custom-container"">
        <div class=""row"">
            <div class=""col-xl-8 col-lg-7"">
                <div class=""checkout-form"">
                    ");
#nullable restore
#line 27 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Views\Order\Index.cshtml"
               Write(await Html.PartialAsync("_OrderFormPartial",Model.Order));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-xl-4 col-lg-5"">
                <div class=""checkout-total-wrapper mt-30"">
                    <h4 class=""allup-title"">Cart Total</h4>
                    <div class=""checkout-total mt-30"">
                        <h4 class=""title"">Product  <span>Total</span></h4>
                        <ul>
");
#nullable restore
#line 36 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Views\Order\Index.cshtml"
                             foreach (var item in Model.Baskets)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\n                                    <p class=\"total-value\">");
#nullable restore
#line 39 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Views\Order\Index.cshtml"
                                                      Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" X ");
#nullable restore
#line 39 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Views\Order\Index.cshtml"
                                                                           Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                    <p class=\"total-amount\">€");
#nullable restore
#line 40 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Views\Order\Index.cshtml"
                                                         Write(((item.Product.DiscoutnPrice > 0 ? item.Product.DiscoutnPrice * item.Count : item.Product.Price * item.Count)+(item.Product.ExTax*item.Count)).ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                </li>\n");
#nullable restore
#line 42 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Views\Order\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\n                        <div class=\"checkout-total-sub\">\n                            <p class=\"total-value\">Sub Total</p>\n                            <p class=\"total-amount\">€");
#nullable restore
#line 46 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Views\Order\Index.cshtml"
                                                 Write((Model.Baskets.Sum(b=>b.Product.DiscoutnPrice > 0 ? b.Product.DiscoutnPrice*b.Count : b.Product.Price * b.Count)+Model.Baskets.Sum(b=>b.Product.ExTax * b.Count)).ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        </div>\n                        <h4 class=\"title mt-15\">Product  <span>€");
#nullable restore
#line 48 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Views\Order\Index.cshtml"
                                                            Write((Model.Baskets.Sum(b=>b.Product.DiscoutnPrice > 0 ? b.Product.DiscoutnPrice*b.Count : b.Product.Price * b.Count)+Model.Baskets.Sum(b=>b.Product.ExTax * b.Count)).ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h4>
                    </div>
                </div>
                <div class=""checkout-btn"">
                    <button type=""submit"" form=""orderform"" class=""main-btn main-btn-2"" href=""#"">Place Order</button>
                </div>
            </div>
        </div>
    </div>
</section>

<!--====== Checkout Part Ends ======-->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
