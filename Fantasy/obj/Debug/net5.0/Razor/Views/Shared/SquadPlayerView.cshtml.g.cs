#pragma checksum "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Shared\SquadPlayerView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b636ddf25b6cf344afbc165e231a93c7c95d0754"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SquadPlayerView), @"mvc.1.0.view", @"/Views/Shared/SquadPlayerView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b636ddf25b6cf344afbc165e231a93c7c95d0754", @"/Views/Shared/SquadPlayerView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18380fd20002808b96b84ba5db19be3927775494", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SquadPlayerView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fantasy.Models.PlayerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/delete.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" width: 30px; height: 30px; margin: 0 auto; display: block;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<tr>\r\n\r\n    <td >");
#nullable restore
#line 5 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Shared\SquadPlayerView.cshtml"
     Write(Model.Num + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td hidden>");
#nullable restore
#line 6 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Shared\SquadPlayerView.cshtml"
          Write(Model.PlayerId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input hidden");
            BeginWriteAttribute("value", " value=\"", 125, "\"", 148, 1);
#nullable restore
#line 6 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Shared\SquadPlayerView.cshtml"
WriteAttributeValue("", 133, Model.PlayerId, 133, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 149, "\"", 190, 3);
            WriteAttributeValue("", 156, "Squad.Players[", 156, 14, true);
#nullable restore
#line 6 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Shared\SquadPlayerView.cshtml"
WriteAttributeValue("", 170, Model.Num, 170, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 180, "].PlayerId", 180, 10, true);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n    <td>");
#nullable restore
#line 7 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Shared\SquadPlayerView.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 8 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Shared\SquadPlayerView.cshtml"
   Write(Model.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 9 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Shared\SquadPlayerView.cshtml"
   Write(Model.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 10 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Shared\SquadPlayerView.cshtml"
   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 11 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Shared\SquadPlayerView.cshtml"
   Write(Model.Team.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    <td>\r\n        <button type =\"button\" class=\"delete\" style=\"border: none; background: none; margin: 0 auto; display: block;\"");
            BeginWriteAttribute("id", " id=\"", 477, "\"", 496, 1);
#nullable restore
#line 14 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Shared\SquadPlayerView.cshtml"
WriteAttributeValue("", 482, Model.Num+1, 482, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b636ddf25b6cf344afbc165e231a93c7c95d07547097", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </button>\r\n    </td>\r\n");
            WriteLiteral("</tr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fantasy.Models.PlayerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
