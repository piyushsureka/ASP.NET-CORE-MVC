#pragma checksum "C:\Users\PIYUSH14.TRN\Desktop\MVC CORE\QuickKart\QuickKartCoreMVCApp\Views\Shared\_RecentPurchases.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cf425f509e2222dc4323434cfced596b43936f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__RecentPurchases), @"mvc.1.0.view", @"/Views/Shared/_RecentPurchases.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_RecentPurchases.cshtml", typeof(AspNetCore.Views_Shared__RecentPurchases))]
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
#line 1 "C:\Users\PIYUSH14.TRN\Desktop\MVC CORE\QuickKart\QuickKartCoreMVCApp\Views\_ViewImports.cshtml"
using QuickKartCoreMVCApp;

#line default
#line hidden
#line 2 "C:\Users\PIYUSH14.TRN\Desktop\MVC CORE\QuickKart\QuickKartCoreMVCApp\Views\_ViewImports.cshtml"
using QuickKartCoreMVCApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cf425f509e2222dc4323434cfced596b43936f7", @"/Views/Shared/_RecentPurchases.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47325ae46f33b306ee7a267fd8e45a3caf75d53b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__RecentPurchases : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 52, true);
            WriteLiteral("\r\n<strong>Recent purchases:</strong>\r\n<br />\r\n<ul>\r\n");
            EndContext();
#line 5 "C:\Users\PIYUSH14.TRN\Desktop\MVC CORE\QuickKart\QuickKartCoreMVCApp\Views\Shared\_RecentPurchases.cshtml"
      
        if (ViewBag.TopProducts.Count != 0)
        {
            foreach (var product in ViewBag.TopProducts)
            {

#line default
#line hidden
            BeginContext(189, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(210, 7, false);
#line 10 "C:\Users\PIYUSH14.TRN\Desktop\MVC CORE\QuickKart\QuickKartCoreMVCApp\Views\Shared\_RecentPurchases.cshtml"
               Write(product);

#line default
#line hidden
            EndContext();
            BeginContext(217, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 11 "C:\Users\PIYUSH14.TRN\Desktop\MVC CORE\QuickKart\QuickKartCoreMVCApp\Views\Shared\_RecentPurchases.cshtml"
            }
        }
        else
        {

#line default
#line hidden
            BeginContext(275, 44, true);
            WriteLiteral("            <li>No products purchased</li>\r\n");
            EndContext();
#line 16 "C:\Users\PIYUSH14.TRN\Desktop\MVC CORE\QuickKart\QuickKartCoreMVCApp\Views\Shared\_RecentPurchases.cshtml"
        }
    

#line default
#line hidden
            BeginContext(337, 9, true);
            WriteLiteral("</ul>\r\n\r\n");
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
