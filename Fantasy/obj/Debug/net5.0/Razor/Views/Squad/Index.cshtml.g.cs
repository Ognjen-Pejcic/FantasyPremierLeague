#pragma checksum "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "048b0b0ec0a7e8396fe9585f637761456b5053d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Squad_Index), @"mvc.1.0.view", @"/Views/Squad/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"048b0b0ec0a7e8396fe9585f637761456b5053d1", @"/Views/Squad/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18380fd20002808b96b84ba5db19be3927775494", @"/Views/_ViewImports.cshtml")]
    public class Views_Squad_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SquadViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/mySquadStyling.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
  
    ViewData["Title"] = "Squads";
    int i = 0;

#line default
#line hidden
#nullable disable
            DefineSection("Style", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "048b0b0ec0a7e8396fe9585f637761456b5053d14377", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<h1>");
#nullable restore
#line 10 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
Write(Model.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n<div>\r\n    Gameweek:\r\n    <select id=\"gw\">\r\n\r\n");
#nullable restore
#line 17 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
         for (int j = Model.MaxGameWeek; j > 0; j--)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "048b0b0ec0a7e8396fe9585f637761456b5053d16145", async() => {
#nullable restore
#line 19 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                      Write(j);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
           WriteLiteral(j);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </select>\r\n    <button onclick=\"ChangeGameweek()\">Change gameweek</button>\r\n</div>\r\n<p>Current gameweek is: <span id=\"currGW\">");
#nullable restore
#line 24 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                                     Write(Model.Gameweek);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n<p>Points: <span id=\"currGW\">");
#nullable restore
#line 25 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                        Write(Model.GWPoints);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n<div class=\"grass\">\r\n    <div class=\"lineup\">\r\n        <div class=\"gk\">\r\n            <div class=\"row\">\r\n                <div class=\"player\"");
            BeginWriteAttribute("id", " id=\"", 713, "\"", 744, 1);
#nullable restore
#line 30 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
WriteAttributeValue("", 718, Model.Goalkeeper.PlayerId, 718, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img src=\"/images/kit.png\"");
            BeginWriteAttribute("alt", " alt=\"", 794, "\"", 800, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <p>");
#nullable restore
#line 32 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                  Write(Model.Goalkeeper.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                                         Write(Model.Goalkeeper.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 33 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                  Write(Model.stats[i++].Points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"def\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 39 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                 foreach (var item in Model.DefenderLine)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"player\"");
            BeginWriteAttribute("id", " id=\"", 1165, "\"", 1184, 1);
#nullable restore
#line 41 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
WriteAttributeValue("", 1170, item.PlayerId, 1170, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img src=\"/images/kit.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1234, "\"", 1240, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <p>");
#nullable restore
#line 43 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 43 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                             Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 44 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                  Write(Model.stats[i++].Points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 46 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"mid\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 51 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                 foreach (var item in Model.MidfielderLine)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"player\"");
            BeginWriteAttribute("id", " id=\"", 1602, "\"", 1621, 1);
#nullable restore
#line 53 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
WriteAttributeValue("", 1607, item.PlayerId, 1607, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img src=\"/images/kit.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1671, "\"", 1677, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <p>");
#nullable restore
#line 55 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 55 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                             Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 56 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                  Write(Model.stats[i++].Points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 58 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"fwd\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 63 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                 foreach (var item in Model.AttackLine)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"player\"");
            BeginWriteAttribute("id", " id=\"", 2035, "\"", 2054, 1);
#nullable restore
#line 65 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
WriteAttributeValue("", 2040, item.PlayerId, 2040, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img src=\"/images/kit.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2104, "\"", 2110, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <p>");
#nullable restore
#line 67 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 67 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                             Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 68 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                  Write(Model.stats[i++].Points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 70 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"bench\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 76 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
             foreach (var item in Model.Bench)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"player\"");
            BeginWriteAttribute("id", " id=\"", 2457, "\"", 2476, 1);
#nullable restore
#line 78 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
WriteAttributeValue("", 2462, item.PlayerId, 2462, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img src=\"/images/kit.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2522, "\"", 2528, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <p>");
#nullable restore
#line 80 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 80 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                         Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n           \r\n            </div>\r\n");
#nullable restore
#line 83 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<div class=\"c-vc\">\r\n    <div class=\"c\">\r\n        <p>Captain is:</p>\r\n        <select id=\"captain\" onchange=\"checkPlayer()\">\r\n");
#nullable restore
#line 91 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
             for (int j = 0; j < Model.StartLine.Count; j++)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                 if (Model.Squad.Captain == @Model.StartLine[j].PlayerId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "048b0b0ec0a7e8396fe9585f637761456b5053d118364", async() => {
#nullable restore
#line 96 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                                                                       Write(Model.StartLine[j].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 96 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                                                                                                Write(Model.StartLine[j].Surname);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            WriteLiteral("c-");
#nullable restore
#line 96 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                                  WriteLiteral(Model.StartLine[j].PlayerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 97 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "048b0b0ec0a7e8396fe9585f637761456b5053d121129", async() => {
#nullable restore
#line 100 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                                                              Write(Model.StartLine[j].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 100 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                                                                                       Write(Model.StartLine[j].Surname);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("c-");
#nullable restore
#line 100 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                         WriteLiteral(Model.StartLine[j].PlayerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 101 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </select>\r\n    </div>\r\n    <div class=\"vc\">\r\n        <p>Vice captain is:</p>\r\n        <select id=\"vice\" onchange=\"checkPlayer()\">\r\n");
#nullable restore
#line 109 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
             for (int j = Model.StartLine.Count - 1; j >= 0; j--)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                 if (Model.Squad.ViceCaptain == @Model.StartLine[j].PlayerId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "048b0b0ec0a7e8396fe9585f637761456b5053d124392", async() => {
#nullable restore
#line 113 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                                                                        Write(Model.StartLine[j].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 113 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                                                                                                 Write(Model.StartLine[j].Surname);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            WriteLiteral("vc-");
#nullable restore
#line 113 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                                   WriteLiteral(Model.StartLine[j].PlayerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 114 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "048b0b0ec0a7e8396fe9585f637761456b5053d127165", async() => {
#nullable restore
#line 117 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                                                                Write(Model.StartLine[j].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 117 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                                                                                         Write(Model.StartLine[j].Surname);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("vc-");
#nullable restore
#line 117 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                           WriteLiteral(Model.StartLine[j].PlayerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 118 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </select>\r\n    </div>\r\n</div>\r\n<div id=\"below\">\r\n    <p style=\"font-size: 20px;\">Rotate player</p>\r\n    <div class=\"change\">\r\n        <div>\r\n            <p>Start linup</p>\r\n            <select id=\"in\">\r\n");
#nullable restore
#line 130 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                 for (int j = 0; j < Model.StartLine.Count; j++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "048b0b0ec0a7e8396fe9585f637761456b5053d130249", async() => {
#nullable restore
#line 132 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                                                        Write(Model.StartLine[j].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 132 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                                                                                 Write(Model.StartLine[j].Surname);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 132 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                   WriteLiteral(Model.StartLine[j].PlayerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 133 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n        </div>\r\n        <div>\r\n            <p>Reserves</p>\r\n            <select id=\"out\">\r\n");
#nullable restore
#line 139 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                 for (int j = Model.Bench.Count - 4; j < Model.Bench.Count; j++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "048b0b0ec0a7e8396fe9585f637761456b5053d132993", async() => {
#nullable restore
#line 141 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                                                    Write(Model.Bench[j].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 141 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                                                                         Write(Model.Bench[j].Surname);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 141 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                   WriteLiteral(Model.Bench[j].PlayerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 142 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n        </div>\r\n        <button id=\"rotate\" onclick=\"Rotate()\">Rotate</button>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        function Rotate() {\r\n             $.ajax({\r\n                url: \'");
#nullable restore
#line 153 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                 Write(Url.ActionLink("CheckIfPlayersCouldRotate", "Squad"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                method:'get',
                data: {
                    activePlayerId: $('#in').val(),
                    benchedPlayerId: $('#out').val()
                },
                success: function () {
                    location.reload();
                }
            });

        }
        function checkPlayer() {
            if ($(""#captain :selected"").text() == $(""#vice :selected"").text()) {
                alert(""Vice captain and captain must be different players!"");
                location.reload();
            }
        }
        function ChangeGameweek() {
             $.ajax({
                url: '");
#nullable restore
#line 173 "C:\Users\pejci\source\repos\Fantasy\Fantasy\Views\Squad\Index.cshtml"
                 Write(Url.ActionLink("ChangeGameWeek", "Squad"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                method:'get',
                data: {
                    gw: $('#gw').val(),
                },
                 success: function () {
                    console.log(""?"")
                    location.reload();
                }
            });
        }
        if ($(""#gw :selected"").text() != $(""#currGW"").text())
            $(""#below"").css('display', 'none');
        else
            $(""#below"").css('display', 'block');
            //$(""#rotate"").prop('disabled', true);
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SquadViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
