#pragma checksum "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Player\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e9b85ee47c521037272168f38fc3e37d4499b66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Player_Index), @"mvc.1.0.view", @"/Views/Player/Index.cshtml")]
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
#line 1 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\_ViewImports.cshtml"
using Fantasy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\_ViewImports.cshtml"
using Fantasy.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\_ViewImports.cshtml"
using Model.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e9b85ee47c521037272168f38fc3e37d4499b66", @"/Views/Player/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18380fd20002808b96b84ba5db19be3927775494", @"/Views/_ViewImports.cshtml")]
    public class Views_Player_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Player>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Player\Index.cshtml"
  
    ViewData["Title"] = "Player";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Jeeej</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Player ID</th>\r\n            <th>Name</th>\r\n            <th>Surname</th>\r\n            <th>Position</th>\r\n        </tr>\r\n\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Player\Index.cshtml"
         foreach (Player p in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td><a>");
#nullable restore
#line 23 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Player\Index.cshtml"
              Write(Html.ActionLink("Details", "Details", "Player", new { id = p.PlayerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n");
            WriteLiteral("            <td>");
#nullable restore
#line 25 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Player\Index.cshtml"
           Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Player\Index.cshtml"
           Write(p.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Player\Index.cshtml"
           Write(p.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Player\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Player>> Html { get; private set; }
    }
}
#pragma warning restore 1591
