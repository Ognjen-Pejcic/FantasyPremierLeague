#pragma checksum "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Player\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16ab6299a0eaab8a5a24edb6e55fe02d97b9883a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Player_Details), @"mvc.1.0.view", @"/Views/Player/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16ab6299a0eaab8a5a24edb6e55fe02d97b9883a", @"/Views/Player/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18380fd20002808b96b84ba5db19be3927775494", @"/Views/_ViewImports.cshtml")]
    public class Views_Player_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Player>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"h1\">Player</h1>\r\n\r\n<h3 class=\"h3\">Name: ");
#nullable restore
#line 5 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Player\Details.cshtml"
                Write(Model.PlayerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3 class=\"h3\">Name: ");
#nullable restore
#line 6 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Player\Details.cshtml"
                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3 class=\"h3\">Name: ");
#nullable restore
#line 7 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Player\Details.cshtml"
                Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3 class=\"h3\">Name: ");
#nullable restore
#line 8 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Player\Details.cshtml"
                Write(Model.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Player> Html { get; private set; }
    }
}
#pragma warning restore 1591