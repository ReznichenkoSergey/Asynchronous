#pragma checksum "D:\EducationTests\02.Asynchronous\AsyncAwait.Task2.CodeReviewChallenge\Views\Home\Help.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb9bb6c2d51c5a1403c5bf87abe7ad04be354ceb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Help), @"mvc.1.0.view", @"/Views/Home/Help.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Help.cshtml", typeof(AspNetCore.Views_Home_Help))]
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
#line 1 "D:\EducationTests\02.Asynchronous\AsyncAwait.Task2.CodeReviewChallenge\Views\_ViewImports.cshtml"
using AsyncAwait.Task2.CodeReviewChallenge;

#line default
#line hidden
#line 2 "D:\EducationTests\02.Asynchronous\AsyncAwait.Task2.CodeReviewChallenge\Views\_ViewImports.cshtml"
using AsyncAwait.Task2.CodeReviewChallenge.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb9bb6c2d51c5a1403c5bf87abe7ad04be354ceb", @"/Views/Home/Help.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a9ea5e569bfa5b4df78a240c9833e2aa26c4d55", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Help : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\EducationTests\02.Asynchronous\AsyncAwait.Task2.CodeReviewChallenge\Views\Home\Help.cshtml"
  
    ViewData["Title"] = "Help";

#line default
#line hidden
            BeginContext(42, 34, true);
            WriteLiteral("\r\n<h1>Support info</h1>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(77, 19, false);
#line 8 "D:\EducationTests\02.Asynchronous\AsyncAwait.Task2.CodeReviewChallenge\Views\Home\Help.cshtml"
Write(ViewBag.RequestInfo);

#line default
#line hidden
            EndContext();
            BeginContext(96, 6, true);
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
