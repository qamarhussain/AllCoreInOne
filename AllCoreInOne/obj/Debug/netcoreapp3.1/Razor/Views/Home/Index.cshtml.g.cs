#pragma checksum "E:\AllCoreInOne\AllCoreInOne\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "855d969c0783e9b767f6c8134754888eee3a2c21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\AllCoreInOne\AllCoreInOne\Views\_ViewImports.cshtml"
using AllCoreInOne;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\AllCoreInOne\AllCoreInOne\Views\_ViewImports.cshtml"
using AllCoreInOne.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"855d969c0783e9b767f6c8134754888eee3a2c21", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36f7b7f654d65ff19be8d8dc1562c520454496d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\AllCoreInOne\AllCoreInOne\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h2>Welcome</h2>
    <p>This app covers following stuff in Asp.Net Core.:</p>
</div>

<div class=""container"">
    <ul class=""list-group list-group-flush"">
        <li class=""list-group-item"">ASP.NET Core MVC Web App</li>
        <li class=""list-group-item"">ASP.NET Core Identity (SQL Server)</li>
        <li class=""list-group-item"">Entity Framework Core (SQL Server)</li>
        <li class=""list-group-item"">Authentication using Identity</li>
        <li class=""list-group-item"">Role based authorization using Identity</li>
        <li class=""list-group-item"">Policy based authorization</li>
        <li class=""list-group-item"">Serilog for logging (logging into Console, Text File, Json File and Seq)</li>
        <li class=""list-group-item"">Custom Middleware</li>
        <li class=""list-group-item"">AutoMapper</li>
        <li class=""list-group-item"">XUnit for Unit testing</li>
        <li class=""list-group-item"">SendGrid (Email)</li>
    </ul>
</div>
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