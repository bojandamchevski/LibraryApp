#pragma checksum "C:\Users\Com\Desktop\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp.WebApp\Views\Author\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e380d8134b6343b93a852564d88c00bbeb654c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Index), @"mvc.1.0.view", @"/Views/Author/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e380d8134b6343b93a852564d88c00bbeb654c1", @"/Views/Author/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c58cc1a5c51ed920101980a2cf7c95980b110925", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AuthorDDViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h3>Authors:</h3>\r\n<br />\r\n<br />\r\n<br />\r\n<div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\Com\Desktop\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp.WebApp\Views\Author\Index.cshtml"
     foreach (AuthorDDViewModel author in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card border-success mb-3\" style=\"max-width: 18rem; margin-left: 10px;\">\r\n            <div class=\"card-body text-success\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\Com\Desktop\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp.WebApp\Views\Author\Index.cshtml"
                                  Write(author.AuthorFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <button type=\"button\" class=\"btn btn-success\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e380d8134b6343b93a852564d88c00bbeb654c16086", async() => {
                WriteLiteral("View author details");
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
#nullable restore
#line 13 "C:\Users\Com\Desktop\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp.WebApp\Views\Author\Index.cshtml"
                                                                                        WriteLiteral(author.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</button>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 16 "C:\Users\Com\Desktop\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp\BojanDamchevski.BookLibraryApp.WebApp\Views\Author\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<button type=\"button\" class=\"btn btn-warning\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e380d8134b6343b93a852564d88c00bbeb654c18741", async() => {
                WriteLiteral("Create a new author");
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
            WriteLiteral("</button>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AuthorDDViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591