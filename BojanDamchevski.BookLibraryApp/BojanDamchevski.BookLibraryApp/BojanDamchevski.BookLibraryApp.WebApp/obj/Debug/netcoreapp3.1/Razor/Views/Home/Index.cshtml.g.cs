#pragma checksum "C:\Users\Com\Desktop\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp.WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ab9a34ac8cd1e8066105749877eef790c7c6516"
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
#line 1 "C:\Users\Com\Desktop\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp.WebApp\Views\_ViewImports.cshtml"
using BojanDamchevski.BookLibraryApp.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Com\Desktop\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp.WebApp\Views\_ViewImports.cshtml"
using BojanDamchevski.BookLibraryApp.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Com\Desktop\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp.WebApp\Views\_ViewImports.cshtml"
using BojanDamchevski.BookLibraryApp.ViewModels.MemberViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Com\Desktop\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp.WebApp\Views\_ViewImports.cshtml"
using BojanDamchevski.BookLibraryApp.ViewModels.BookViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Com\Desktop\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp.WebApp\Views\_ViewImports.cshtml"
using BojanDamchevski.BookLibraryApp.ViewModels.AuthorViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Com\Desktop\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp.WebApp\Views\_ViewImports.cshtml"
using BojanDamchevski.BookLibraryApp.Domain.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ab9a34ac8cd1e8066105749877eef790c7c6516", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c58cc1a5c51ed920101980a2cf7c95980b110925", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Com\Desktop\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp.WebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
    <p>Get your book reservations here and now.</p>
    <h3>Made by Bojan Damchevski</h3>
    <h5>We have ");
#nullable restore
#line 10 "C:\Users\Com\Desktop\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp.WebApp\Views\Home\Index.cshtml"
           Write(ViewBag.NumberOfBooks);

#line default
#line hidden
#nullable disable
            WriteLiteral(" books</h5>\r\n    <small>from</small>\r\n    <h5>");
#nullable restore
#line 12 "C:\Users\Com\Desktop\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp.WebApp\Views\Home\Index.cshtml"
   Write(ViewBag.NumberOfAuthors);

#line default
#line hidden
#nullable disable
            WriteLiteral(" authors</h5>\r\n    <small>and</small>\r\n    <h5>we have ");
#nullable restore
#line 14 "C:\Users\Com\Desktop\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp.WebApp\Views\Home\Index.cshtml"
           Write(ViewBag.NumberOfMembers);

#line default
#line hidden
#nullable disable
            WriteLiteral(" members</h5>\r\n    <small>till now !</small>\r\n</div>\r\n");
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
