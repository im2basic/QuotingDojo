#pragma checksum "C:\Users\basic\Desktop\codingDojo\c#\Asp\QuotingDojo\Views\Home\Quotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbacbc3505f3f3734c7055e1f88b3d90822ec143"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Quotes), @"mvc.1.0.view", @"/Views/Home/Quotes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Quotes.cshtml", typeof(AspNetCore.Views_Home_Quotes))]
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
#line 1 "C:\Users\basic\Desktop\codingDojo\c#\Asp\QuotingDojo\Views\_ViewImports.cshtml"
using QuotingDojo;

#line default
#line hidden
#line 2 "C:\Users\basic\Desktop\codingDojo\c#\Asp\QuotingDojo\Views\_ViewImports.cshtml"
using QuotingDojo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbacbc3505f3f3734c7055e1f88b3d90822ec143", @"/Views/Home/Quotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1590bf4c09dff90063a94a6cfc81488d471e1d42", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Quotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 45, true);
            WriteLiteral("<h1>Here are the awesome quotes!</h1>\r\n<ul>\r\n");
            EndContext();
#line 3 "C:\Users\basic\Desktop\codingDojo\c#\Asp\QuotingDojo\Views\Home\Quotes.cshtml"
 foreach(var user in ViewBag.Users)
{
    

#line default
#line hidden
            BeginContext(91, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(100, 12, false);
#line 6 "C:\Users\basic\Desktop\codingDojo\c#\Asp\QuotingDojo\Views\Home\Quotes.cshtml"
   Write(user["Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(112, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(114, 13, false);
#line 6 "C:\Users\basic\Desktop\codingDojo\c#\Asp\QuotingDojo\Views\Home\Quotes.cshtml"
                 Write(user["Quote"]);

#line default
#line hidden
            EndContext();
            BeginContext(127, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 7 "C:\Users\basic\Desktop\codingDojo\c#\Asp\QuotingDojo\Views\Home\Quotes.cshtml"
}

#line default
#line hidden
            BeginContext(137, 5, true);
            WriteLiteral("</ul>");
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
