#pragma checksum "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\ViewBody\ViewApplicant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edb6ef23ebb8444a662ce0b36631b89cf3ffb5e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ViewBody_ViewApplicant), @"mvc.1.0.view", @"/Views/ViewBody/ViewApplicant.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ViewBody/ViewApplicant.cshtml", typeof(AspNetCore.Views_ViewBody_ViewApplicant))]
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
#line 1 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\_ViewImports.cshtml"
using PartTimeJob;

#line default
#line hidden
#line 2 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\_ViewImports.cshtml"
using PartTimeJob.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edb6ef23ebb8444a662ce0b36631b89cf3ffb5e3", @"/Views/ViewBody/ViewApplicant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dd4cdda90c1aa4f501d634a6985bd5db8aeaf73", @"/Views/_ViewImports.cshtml")]
    public class Views_ViewBody_ViewApplicant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/news/img04.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Article Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ViewBody", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewApplicantSend", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\ViewBody\ViewApplicant.cshtml"
  
    Layout = "Homelayouta";

#line default
#line hidden
            BeginContext(36, 263, true);
            WriteLiteral(@"

<section class=""padding bg-grey"" id=""blog"">
    <div class=""container"">
        <h2 class=""section-title"">搜索结果出来了</h2>
        <p class=""section-lead text-muted"">看看有没有适合你的</p>
        <div class=""section-body"">
            <div class=""row col-spacing"">
");
            EndContext();
#line 12 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\ViewBody\ViewApplicant.cshtml"
                 foreach (var res in ViewBag.Result)
                {

#line default
#line hidden
            BeginContext(372, 136, true);
            WriteLiteral("                    <div class=\"col-12 col-md-6 col-lg-4\">\r\n                        <article class=\"card\">\r\n                            ");
            EndContext();
            BeginContext(508, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "03d549ded01442519e65404a4959ffd1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(581, 144, true);
            WriteLiteral("\r\n                            <div class=\"card-body\">\r\n                                <div class=\"card-subtitle mb-2 text-muted\">由 <a href=\"#\">");
            EndContext();
            BeginContext(726, 11, false);
#line 18 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\ViewBody\ViewApplicant.cshtml"
                                                                                    Write(res.RPeople);

#line default
#line hidden
            EndContext();
            BeginContext(737, 7, true);
            WriteLiteral("</a> 于 ");
            EndContext();
            BeginContext(745, 14, false);
#line 18 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\ViewBody\ViewApplicant.cshtml"
                                                                                                       Write(res.RCreatTime);

#line default
#line hidden
            EndContext();
            BeginContext(759, 114, true);
            WriteLiteral(" 发布</div>\r\n                                <h4 class=\"card-title\"><a href=\"#\" data-toggle=\"read\" data-id=\"1\">工作类型：");
            EndContext();
            BeginContext(874, 9, false);
#line 19 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\ViewBody\ViewApplicant.cshtml"
                                                                                                  Write(res.RType);

#line default
#line hidden
            EndContext();
            BeginContext(883, 9, true);
            WriteLiteral("    工资:  ");
            EndContext();
            BeginContext(893, 11, false);
#line 19 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\ViewBody\ViewApplicant.cshtml"
                                                                                                                     Write(res.RSalary);

#line default
#line hidden
            EndContext();
            BeginContext(904, 9, true);
            WriteLiteral("    工作地址：");
            EndContext();
            BeginContext(914, 12, false);
#line 19 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\ViewBody\ViewApplicant.cshtml"
                                                                                                                                          Write(res.RAddress);

#line default
#line hidden
            EndContext();
            BeginContext(926, 69, true);
            WriteLiteral("</a></h4>\r\n                                <p class=\"card-text\">工作描述：");
            EndContext();
            BeginContext(996, 13, false);
#line 20 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\ViewBody\ViewApplicant.cshtml"
                                                     Write(res.RDescribe);

#line default
#line hidden
            EndContext();
            BeginContext(1009, 65, true);
            WriteLiteral("</p>\r\n                                <p1 class=\"card-text\">工作描述：");
            EndContext();
            BeginContext(1075, 12, false);
#line 21 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\ViewBody\ViewApplicant.cshtml"
                                                      Write(res.RRequire);

#line default
#line hidden
            EndContext();
            BeginContext(1087, 107, true);
            WriteLiteral("</p1>\r\n                                <p></p>\r\n                                <p2 class=\"card-text\">有效日期：");
            EndContext();
            BeginContext(1195, 14, false);
#line 23 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\ViewBody\ViewApplicant.cshtml"
                                                      Write(res.RStartDate);

#line default
#line hidden
            EndContext();
            BeginContext(1209, 4, true);
            WriteLiteral(" -- ");
            EndContext();
            BeginContext(1214, 12, false);
#line 23 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\ViewBody\ViewApplicant.cshtml"
                                                                         Write(res.REndDate);

#line default
#line hidden
            EndContext();
            BeginContext(1226, 101, true);
            WriteLiteral("</p2>\r\n                                <div class=\"text-right\">\r\n                                    ");
            EndContext();
            BeginContext(1327, 317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50dd5702b19740438e64ac515b4d1901", async() => {
                BeginContext(1405, 73, true);
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"RId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1478, "\"", 1494, 1);
#line 26 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\ViewBody\ViewApplicant.cshtml"
WriteAttributeValue("", 1486, res.RId, 1486, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1495, 142, true);
                WriteLiteral(">\r\n\r\n                                        <button class=\"btn btn-primary\"   type=\"submit\">投递</button>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1644, 144, true);
            WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n                        </article>\r\n                    </div>\r\n");
            EndContext();
#line 35 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\ViewBody\ViewApplicant.cshtml"
                }

#line default
#line hidden
            BeginContext(1807, 68, true);
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n</section>\r\n");
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