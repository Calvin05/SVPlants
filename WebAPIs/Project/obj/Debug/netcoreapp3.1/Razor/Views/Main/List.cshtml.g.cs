#pragma checksum "C:\Users\Calvin\Desktop\T7\Project\Views\Main\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05eb525eb1a19d03ee57c063b947a81f62bd5b3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_List), @"mvc.1.0.view", @"/Views/Main/List.cshtml")]
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
#line 1 "C:\Users\Calvin\Desktop\T7\Project\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Calvin\Desktop\T7\Project\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05eb525eb1a19d03ee57c063b947a81f62bd5b3b", @"/Views/Main/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Calvin\Desktop\T7\Project\Views\Main\List.cshtml"
  
    Layout = Layout;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Calvin\Desktop\T7\Project\Views\Main\List.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-header\">");
#nullable restore
#line 14 "C:\Users\Calvin\Desktop\T7\Project\Views\Main\List.cshtml"
                                Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\Calvin\Desktop\T7\Project\Views\Main\List.cshtml"
                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h6>Looking for Doctor with these requirements: </h6>\r\n                <p class=\"card-text\">\r\n                    Gender: ");
#nullable restore
#line 19 "C:\Users\Calvin\Desktop\T7\Project\Views\Main\List.cshtml"
                       Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p class=\"card-text\">\r\n                    Location: ");
#nullable restore
#line 22 "C:\Users\Calvin\Desktop\T7\Project\Views\Main\List.cshtml"
                         Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p class=\"card-text\">\r\n                    Expertise: ");
#nullable restore
#line 25 "C:\Users\Calvin\Desktop\T7\Project\Views\Main\List.cshtml"
                          Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p class=\"card-text\">\r\n                    Location: ");
#nullable restore
#line 28 "C:\Users\Calvin\Desktop\T7\Project\Views\Main\List.cshtml"
                         Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p class=\"card-text\">\r\n                    Other Requirements: ");
#nullable restore
#line 31 "C:\Users\Calvin\Desktop\T7\Project\Views\Main\List.cshtml"
                                   Write(item.Other);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <a href=\"#\" class=\"btn btn-primary\">More Info</a>\r\n            </div>\r\n            <div class=\"card-footer\">");
#nullable restore
#line 35 "C:\Users\Calvin\Desktop\T7\Project\Views\Main\List.cshtml"
                                Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n");
#nullable restore
#line 37 "C:\Users\Calvin\Desktop\T7\Project\Views\Main\List.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Project.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
