#pragma checksum "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "591d8a624ba52a9d10f380cc60fdf1586cc61630"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Home), @"mvc.1.0.view", @"/Views/Movie/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Home.cshtml", typeof(AspNetCore.Views_Movie_Home))]
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
#line 1 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#line 2 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"591d8a624ba52a9d10f380cc60fdf1586cc61630", @"/Views/Movie/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab3.Models.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Upload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:block; width: 19%; margin:auto; margin-bottom:3em"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Left Align"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
  
    Layout = Layout;

#line default
#line hidden
            BeginContext(70, 65, true);
            WriteLiteral("\r\n<h1 class=\"Header\" style=\"background-color: #203e4a;\">Welcome, ");
            EndContext();
            BeginContext(136, 16, false);
#line 7 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
                                                          Write(TempData["user"]);

#line default
#line hidden
            EndContext();
            BeginContext(152, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
            BeginContext(159, 226, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "022975c00646454b87da5294d3231949", async() => {
                BeginContext(303, 78, true);
                WriteLiteral("Upload Movie <span class=\"glyphicon glyphicon-film\" aria-hidden=\"true\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(385, 194, true);
            WriteLiteral("\r\n<br />\r\n<h2 style=\"color:black; width:20%; margin:auto; text-align:center; font-size:2em\">Avaiable Movie </h2>\r\n<hr style=\"margin-bottom:0;\"/>\r\n<div style=\"background: #e2e1e0;\">\r\n    <br />\r\n");
            EndContext();
#line 14 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(620, 174, true);
            WriteLiteral("        <div class=\"TabContent\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\" style=\"margin-left:1em;\">\r\n                    <h2 style=\"color:black\">");
            EndContext();
            BeginContext(795, 9, false);
#line 19 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(804, 91, true);
            WriteLiteral("</h2>\r\n                    <p>Uploaded By: <span style=\"font-size:1.2em; font-weight:bold\">");
            EndContext();
            BeginContext(896, 9, false);
#line 20 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
                                                                               Write(item.User);

#line default
#line hidden
            EndContext();
            BeginContext(905, 13, true);
            WriteLiteral("</span></p>\r\n");
            EndContext();
#line 21 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
                     if (item.Rate != null)
                    {
                        int ave = 0; 
                        foreach(var rate in item.Rate)
                        {
                            ave += rate; 
                        }
                            ave = ave / item.Rate.Count;

#line default
#line hidden
            BeginContext(1236, 77, true);
            WriteLiteral("                    <p>Rate: <span style=\"font-size:1.2em; font-weight:bold\">");
            EndContext();
            BeginContext(1314, 3, false);
#line 29 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
                                                                        Write(ave);

#line default
#line hidden
            EndContext();
            BeginContext(1317, 92, true);
            WriteLiteral("</span><i class=\"fa fa-star-o\" aria-hidden=\"true\" style=\"background-color:yellow\"></i></p>\r\n");
            EndContext();
#line 30 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
                    }

#line default
#line hidden
            BeginContext(1432, 78, true);
            WriteLiteral("                    <p>Genre: <span style=\"font-size:1.2em; font-weight:bold\">");
            EndContext();
            BeginContext(1511, 10, false);
#line 31 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
                                                                         Write(item.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(1521, 97, true);
            WriteLiteral("</span></p>\r\n                    <p>Upload Date: <span style=\"font-size:1.2em; font-weight:bold\">");
            EndContext();
            BeginContext(1619, 15, false);
#line 32 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
                                                                               Write(item.DateUpload);

#line default
#line hidden
            EndContext();
            BeginContext(1634, 94, true);
            WriteLiteral("</span></p>\r\n                    <h3 style=\"font-size:1.2em; font-weight:bold\">Comment:</h3>\r\n");
            EndContext();
#line 34 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
                     if (item.Comment != null)
                    {
                        

#line default
#line hidden
#line 36 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
                         foreach (var comment in item.Comment)
                        {

#line default
#line hidden
            BeginContext(1890, 58, true);
            WriteLiteral("                            <h6 style=\"margin-left: 1em;\">");
            EndContext();
            BeginContext(1949, 7, false);
#line 38 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
                                                     Write(comment);

#line default
#line hidden
            EndContext();
            BeginContext(1956, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
#line 39 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"

                        }

#line default
#line hidden
#line 40 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(2015, 148, true);
            WriteLiteral("                    <hr style=\"margin:0; padding:0;\" />\r\n                    <br />\r\n                    <div class=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2163, 1404, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16de237fef03439d9ca1adb455dc6f87", async() => {
                BeginContext(2193, 212, true);
                WriteLiteral("\r\n                            <div class=\"col-sm-10\">\r\n                                <select name=\"rate\" class=\"form-control\" style=\"margin-left: 1em; margin-bottom:10px;\">\r\n                                    ");
                EndContext();
                BeginContext(2405, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fb254ac78df4aa2b82404cd21720222", async() => {
                    BeginContext(2422, 15, true);
                    WriteLiteral("Rate this Movie");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2446, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2484, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5763c6b84f49499a95a92aab0bbb7389", async() => {
                    BeginContext(2502, 1, true);
                    WriteLiteral("5");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2512, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2550, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4997edbdf28f45cbaef406bdf276bfa4", async() => {
                    BeginContext(2568, 1, true);
                    WriteLiteral("4");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2578, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2616, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae385e25246248499b46bd7660fb4f1a", async() => {
                    BeginContext(2634, 1, true);
                    WriteLiteral("3");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2644, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2682, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2d717fb9ef34b62a07162111269d994", async() => {
                    BeginContext(2700, 1, true);
                    WriteLiteral("2");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2710, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2748, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f95d792a633429286ef1328c886cb26", async() => {
                    BeginContext(2766, 1, true);
                    WriteLiteral("1");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2776, 388, true);
                WriteLiteral(@"
                                </select>
                            </div>
                          
                            <div class=""col-sm-10"">
                                <textarea class=""form-control"" name=""comment"" required placeholder=""Add your comment"" style=""margin-left: 1em;""></textarea>
                                <input name=""id"" class=""form-control""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3164, "\"", 3180, 1);
#line 59 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
WriteAttributeValue("", 3172, item.Id, 3172, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3181, 90, true);
                WriteLiteral(" type=\"hidden\" />\r\n                                <input name=\"user\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3271, "\"", 3296, 1);
#line 60 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
WriteAttributeValue("", 3279, TempData["user"], 3279, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3297, 263, true);
                WriteLiteral(@" type=""hidden"" />
                            </div>
                            <div class=""col-sm-2"">
                                <input type=""submit"" value=""Submit"" class=""btn btn-success"" />
                            </div>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3567, 292, true);
            WriteLiteral(@"

                    </div>
                    <br />
                </div>
                <div class=""col-md-offset-6"" style="" margin-top:1em; margin-right:1em;"">
                    <video controls=""controls"" style=""overflow: hidden; width:100%;"">
                        <source");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3859, "\"", 3949, 1);
#line 72 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
WriteAttributeValue("", 3865, Url.Content(item.Source.GetPreSignedURL(DateTime.Now.Add(TimeSpan.FromMinutes(5)))), 3865, 84, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3950, 132, true);
            WriteLiteral(" />\r\n                    </video>\r\n                   \r\n                </div>\r\n            </div>\r\n        </div>\r\n        <br />\r\n");
            EndContext();
#line 79 "C:\Users\SONY\Desktop\Lab3\WebApplication3\Views\Movie\Home.cshtml"
    }

#line default
#line hidden
            BeginContext(4089, 18, true);
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab3.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
