#pragma checksum "C:\Nandini\PromotionEngine\PromotionEngine\PromotionEngine\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "906b818044ba8da9fdb5a7531d3cf9e618bb8f78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Nandini\PromotionEngine\PromotionEngine\PromotionEngine\Views\_ViewImports.cshtml"
using PromotionEngine;

#line default
#line hidden
#line 2 "C:\Nandini\PromotionEngine\PromotionEngine\PromotionEngine\Views\_ViewImports.cshtml"
using PromotionEngine.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"906b818044ba8da9fdb5a7531d3cf9e618bb8f78", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6e5c9cfbd0b54dafc31e095af5eb8acf9d8701c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Nandini\PromotionEngine\PromotionEngine\PromotionEngine\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 104, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <h2>Scenarion A</h2><br />\r\n        <h2>Total: ");
            EndContext();
            BeginContext(150, 21, false);
#line 8 "C:\Nandini\PromotionEngine\PromotionEngine\PromotionEngine\Views\Home\Index.cshtml"
              Write(ViewData["ScenarioA"]);

#line default
#line hidden
            EndContext();
            BeginContext(171, 102, true);
            WriteLiteral("</h2>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <h2>Scenarion B</h2><br />\r\n        <h2>Total: ");
            EndContext();
            BeginContext(274, 21, false);
#line 12 "C:\Nandini\PromotionEngine\PromotionEngine\PromotionEngine\Views\Home\Index.cshtml"
              Write(ViewData["ScenarioB"]);

#line default
#line hidden
            EndContext();
            BeginContext(295, 102, true);
            WriteLiteral("</h2>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <h2>Scenarion C</h2><br />\r\n        <h2>Total: ");
            EndContext();
            BeginContext(398, 21, false);
#line 16 "C:\Nandini\PromotionEngine\PromotionEngine\PromotionEngine\Views\Home\Index.cshtml"
              Write(ViewData["ScenarioC"]);

#line default
#line hidden
            EndContext();
            BeginContext(419, 27, true);
            WriteLiteral("</h2>\r\n    </div>\r\n</div>\r\n");
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
