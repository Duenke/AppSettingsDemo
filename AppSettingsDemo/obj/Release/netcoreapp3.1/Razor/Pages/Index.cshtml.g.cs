#pragma checksum "C:\Users\jacob\Source\Repos\AppSettingsDemo\AppSettingsDemo\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "775872c0954f9b4ac75ad67c071831ca75444a38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AppSettingsDemo.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AppSettingsDemo.Pages
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
#line 1 "C:\Users\jacob\Source\Repos\AppSettingsDemo\AppSettingsDemo\Pages\_ViewImports.cshtml"
using AppSettingsDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jacob\Source\Repos\AppSettingsDemo\AppSettingsDemo\Pages\_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"775872c0954f9b4ac75ad67c071831ca75444a38", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0f5f662451d45ff8a9b9fa9bb837c7b08fb41a7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\jacob\Source\Repos\AppSettingsDemo\AppSettingsDemo\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>");
#nullable restore
#line 9 "C:\Users\jacob\Source\Repos\AppSettingsDemo\AppSettingsDemo\Pages\Index.cshtml"
  Write(Configuration.GetSection("GetSection")["GetSection-One"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 10 "C:\Users\jacob\Source\Repos\AppSettingsDemo\AppSettingsDemo\Pages\Index.cshtml"
  Write(Configuration.GetSection("GetSection")["GetSection-Two"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <br />\r\n    <p>");
#nullable restore
#line 12 "C:\Users\jacob\Source\Repos\AppSettingsDemo\AppSettingsDemo\Pages\Index.cshtml"
  Write(Configuration.GetValue("GetValue-One", "GetValue-One-Default"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 13 "C:\Users\jacob\Source\Repos\AppSettingsDemo\AppSettingsDemo\Pages\Index.cshtml"
  Write(Configuration.GetValue("GetValue-Two", "GetValue-Two-Default"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <br />\r\n    <p>");
#nullable restore
#line 15 "C:\Users\jacob\Source\Repos\AppSettingsDemo\AppSettingsDemo\Pages\Index.cshtml"
  Write(Configuration.GetSection("GetSection:GetSection-Nested")["GetSection-Nested-One"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <br />\r\n    <p>");
#nullable restore
#line 17 "C:\Users\jacob\Source\Repos\AppSettingsDemo\AppSettingsDemo\Pages\Index.cshtml"
  Write(Configuration.GetValue("GetValue-Nested:GetValue-Nested-One", "GetValue-Nested-One-Default"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <br />\r\n    <a href=\"https://github.com/Duenke/AppSettingsDemo.git\">GitHub repo for this demo!</a>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
