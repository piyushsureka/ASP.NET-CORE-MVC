#pragma checksum "C:\Users\PIYUSH14.TRN\Desktop\MVC CORE\QuickKart\QuickKartCoreMVCApp\Views\Customer\CustomerHome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3dfc9f6e1ff8152788326a8ba0080d5e330c7ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CustomerHome), @"mvc.1.0.view", @"/Views/Customer/CustomerHome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/CustomerHome.cshtml", typeof(AspNetCore.Views_Customer_CustomerHome))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3dfc9f6e1ff8152788326a8ba0080d5e330c7ce", @"/Views/Customer/CustomerHome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47325ae46f33b306ee7a267fd8e45a3caf75d53b", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_CustomerHome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\PIYUSH14.TRN\Desktop\MVC CORE\QuickKart\QuickKartCoreMVCApp\Views\Customer\CustomerHome.cshtml"
  
    ViewData["Title"] = "CustomerHome";
    Layout = "~/Views/Shared/_LayoutCustomer.cshtml";

#line default
#line hidden
            BeginContext(181, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(210, 72, true);
            WriteLiteral("<div class=\"col-md-3\" style=\"margin-left:900px\">\r\n    \r\n    <h4>Welcome ");
            EndContext();
            BeginContext(283, 57, false);
#line 11 "C:\Users\PIYUSH14.TRN\Desktop\MVC CORE\QuickKart\QuickKartCoreMVCApp\Views\Customer\CustomerHome.cshtml"
           Write(httpContextaccessor.HttpContext.Request.Query["username"]);

#line default
#line hidden
            EndContext();
            BeginContext(340, 113, true);
            WriteLiteral("</h4>\r\n</div>\r\n\r\n<h3 class=\"text-center\">Customer Home Page</h3>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
            EndContext();
#line 17 "C:\Users\PIYUSH14.TRN\Desktop\MVC CORE\QuickKart\QuickKartCoreMVCApp\Views\Customer\CustomerHome.cshtml"
          
            Html.RenderPartial("_RecentPurchases");
        

#line default
#line hidden
            BeginContext(529, 38, true);
            WriteLiteral("    </div>\r\n    \r\n\r\n    \r\n</div>\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor httpContextaccessor { get; private set; }
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
