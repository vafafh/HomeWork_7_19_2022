#pragma checksum "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Areas\Manage\Views\Setting\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "653a6514b970b4e1009375fe172c01b349c0d2d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Setting_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Setting/Index.cshtml")]
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
#line 2 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Areas\Manage\Views\_ViewImports.cshtml"
using P129Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Areas\Manage\Views\_ViewImports.cshtml"
using P129Allup.ViewModels.BasketViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Areas\Manage\Views\_ViewImports.cshtml"
using P129Allup.ViewModels.HeaderViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Areas\Manage\Views\_ViewImports.cshtml"
using P129Allup.ViewModels.HomeViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Areas\Manage\Views\_ViewImports.cshtml"
using P129Allup.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Areas\Manage\Views\_ViewImports.cshtml"
using P129Allup.Areas.Manage.ViewModels.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Areas\Manage\Views\_ViewImports.cshtml"
using P129Allup.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"653a6514b970b4e1009375fe172c01b349c0d2d2", @"/Areas/Manage/Views/Setting/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5efa520bb1f16008addc872683e8d9baa9707f7d", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Manage_Views_Setting_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IDictionary<string, string>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Areas\Manage\Views\Setting\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row justify-content-center"">
    <div class=""col-lg-2"">
        <h1>Brands</h1>
    </div>
</div>
<div class=""row justify-content-center"">
    <table class=""table table-bordered table-striped"" >
        <thead>
            <tr>
                <th>Name</th>
                <th>Value</th>
                <th>Setting</th>
            </tr>
        </thead>
        <tbody class=""settingContainer"">
            ");
#nullable restore
#line 21 "C:\Users\Vefa\Downloads\P129_ASP_18-07-2022_SignalR-main\P129_ASP_18-07-2022_SignalR-main\P129Allup\P129Allup\Areas\Manage\Views\Setting\Index.cshtml"
       Write(await Html.PartialAsync("_SettingIndexPartial", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        </tbody>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IDictionary<string, string>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
