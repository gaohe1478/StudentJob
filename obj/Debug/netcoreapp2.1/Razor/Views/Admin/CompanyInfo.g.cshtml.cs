#pragma checksum "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daa2306e88c649689b9d864eb42d521b1248385d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CompanyInfo), @"mvc.1.0.view", @"/Views/Admin/CompanyInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/CompanyInfo.cshtml", typeof(AspNetCore.Views_Admin_CompanyInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daa2306e88c649689b9d864eb42d521b1248385d", @"/Views/Admin/CompanyInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dd4cdda90c1aa4f501d634a6985bd5db8aeaf73", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CompanyInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FindCompany", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
  
    Layout = "adminHomeLayout";
    var companys = Model;

#line default
#line hidden
            BeginContext(67, 282, true);
            WriteLiteral(@"<div class=""box ui-draggable ui-droppable"">
    <div class=""box-header"">
        <div class=""box-name"">
            <i class=""fa fa-table""></i>
            <span>公司信息</span>
        </div>
        <div class=""no-move""></div>
    </div>
    <div>
        <div>
            ");
            EndContext();
            BeginContext(349, 816, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "024120e0d00c4daa85425a4b757f54cd", async() => {
                BeginContext(403, 417, true);
                WriteLiteral(@"
                <div class=""form-group"">
                    <label class=""control-label"">公司账号</label>
                    <input name=""CId"" type=""text"">
                    <label class=""control-label"">公司名称</label>
                    <input name=""CName"" type=""text"">
                    <label class=""control-label"">账号状态</label>
                    <select class="""" name=""CStatus"">
                        ");
                EndContext();
                BeginContext(820, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d48d17bd8f1400389edf592f650b31e", async() => {
                    BeginContext(838, 3, true);
                    WriteLiteral("未封禁");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(850, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(876, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63fff10f55644a7da3231a8f076c6ddb", async() => {
                    BeginContext(894, 3, true);
                    WriteLiteral("已封禁");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(906, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(932, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "765f102d068e46068e2f9128b8efac05", async() => {
                    BeginContext(959, 6, true);
                    WriteLiteral("--默认--");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
                BeginContext(974, 152, true);
                WriteLiteral("\r\n                    </select>\r\n                    <button class=\"btn btn-primary\" type=\"submit\">搜索</button>\r\n                </div>\r\n                ");
                EndContext();
                BeginContext(1127, 17, false);
#line 29 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
           Write(ViewData["error"]);

#line default
#line hidden
                EndContext();
                BeginContext(1144, 14, true);
                WriteLiteral("\r\n            ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1165, 420, true);
            WriteLiteral(@"
        </div>
    </div>
    <div class=""box-content no-padding"">
        <table class=""table table-striped table-bordered table-hover table-heading no-border-bottom"">
            <thead>
                <tr>
                    <th>公司账号</th>
                    <th>名称</th>
                    <th>账号状态</th>
                    <th>操作</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 44 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
                 for (int i = 0; i < companys.Count; i++)
                {

#line default
#line hidden
            BeginContext(1663, 57, true);
            WriteLiteral("                <tr>\r\n                    <td><a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1720, "\"", 1758, 3);
            WriteAttributeValue("", 1730, "showinfo(\'", 1730, 10, true);
#line 47 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
WriteAttributeValue("", 1740, companys[i].CId, 1740, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 1756, "\')", 1756, 2, true);
            EndWriteAttribute();
            BeginContext(1759, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1761, 15, false);
#line 47 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
                                                                      Write(companys[i].CId);

#line default
#line hidden
            EndContext();
            BeginContext(1776, 11, true);
            WriteLiteral("</a></td>\r\n");
            EndContext();
#line 48 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
                     if (@ViewBag.Info[i] == null)
                    {

#line default
#line hidden
            BeginContext(1862, 35, true);
            WriteLiteral("                        <td></td>\r\n");
            EndContext();
#line 51 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1969, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(1998, 21, false);
#line 54 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
                       Write(ViewBag.Info[i].CName);

#line default
#line hidden
            EndContext();
            BeginContext(2019, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 55 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
                    }

#line default
#line hidden
            BeginContext(2049, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 56 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
                     if (companys[i].CStatus == 0)
                    {

#line default
#line hidden
            BeginContext(2124, 38, true);
            WriteLiteral("                        <td>未封禁</td>\r\n");
            EndContext();
#line 59 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2234, 38, true);
            WriteLiteral("                        <td>已封禁</td>\r\n");
            EndContext();
#line 63 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
                    }

#line default
#line hidden
            BeginContext(2295, 26, true);
            WriteLiteral("                    <td>\r\n");
            EndContext();
#line 65 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
                         if (companys[i].CStatus == 0)
                        {

#line default
#line hidden
            BeginContext(2404, 59, true);
            WriteLiteral("                            <button class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2463, "\"", 2501, 3);
            WriteAttributeValue("", 2473, "showitem(\'", 2473, 10, true);
#line 67 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
WriteAttributeValue("", 2483, companys[i].CId, 2483, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 2499, "\')", 2499, 2, true);
            EndWriteAttribute();
            BeginContext(2502, 28, true);
            WriteLiteral(" type=\"button\">封禁</button>\r\n");
            EndContext();
#line 68 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2614, 56, true);
            WriteLiteral("                            <button class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2670, "\"", 2708, 3);
            WriteAttributeValue("", 2680, "showitem(\'", 2680, 10, true);
#line 71 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
WriteAttributeValue("", 2690, companys[i].CId, 2690, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 2706, "\')", 2706, 2, true);
            EndWriteAttribute();
            BeginContext(2709, 28, true);
            WriteLiteral(" type=\"button\">解封</button>\r\n");
            EndContext();
#line 72 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
                        }

#line default
#line hidden
            BeginContext(2764, 54, true);
            WriteLiteral("                        <button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2818, "\"", 2858, 3);
            WriteAttributeValue("", 2828, "Deleteitem(\'", 2828, 12, true);
#line 73 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
WriteAttributeValue("", 2840, companys[i].CId, 2840, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 2856, "\')", 2856, 2, true);
            EndWriteAttribute();
            BeginContext(2859, 83, true);
            WriteLiteral(" type=\"button\">删除</button>\r\n                        <button class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2942, "\"", 2984, 3);
            WriteAttributeValue("", 2952, "crecruititem(\'", 2952, 14, true);
#line 74 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
WriteAttributeValue("", 2966, companys[i].CId, 2966, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 2982, "\')", 2982, 2, true);
            EndWriteAttribute();
            BeginContext(2985, 80, true);
            WriteLiteral(" type=\"button\">招聘信息</button>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 77 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
                }

#line default
#line hidden
            BeginContext(3084, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("MyScripts", async() => {
                BeginContext(3171, 163, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        function Deleteitem(CId)\r\n        {\r\n            if (confirm(\"确定要删除吗？\"))\r\n            {\r\n                var url = \'");
                EndContext();
                BeginContext(3335, 36, false);
#line 90 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
                      Write(Url.Action("DeleteCompany", "Admin"));

#line default
#line hidden
                EndContext();
                BeginContext(3371, 161, true);
                WriteLiteral("\' + \'?CId=\' + encodeURI(CId);\r\n                location.href = url;\r\n            }\r\n        }\r\n        function showitem(CId)\r\n        {\r\n            var url = \'");
                EndContext();
                BeginContext(3533, 36, false);
#line 96 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
                  Write(Url.Action("UpdateCStatus", "Admin"));

#line default
#line hidden
                EndContext();
                BeginContext(3569, 144, true);
                WriteLiteral("\' + \'?CId=\' + encodeURI(CId);\r\n            location.href = url;\r\n        }\r\n        function showinfo(CId)\r\n        {\r\n\r\n            var url = \'");
                EndContext();
                BeginContext(3714, 37, false);
#line 102 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
                  Write(Url.Action("CompanyInfoView","Admin"));

#line default
#line hidden
                EndContext();
                BeginContext(3751, 146, true);
                WriteLiteral("\' + \'?CId=\' + encodeURI(CId);\r\n            location.href = url;\r\n        }\r\n        function crecruititem(CId)\r\n        {\r\n            var url = \'");
                EndContext();
                BeginContext(3898, 35, false);
#line 107 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\CompanyInfo.cshtml"
                  Write(Url.Action("CRecruitList", "Admin"));

#line default
#line hidden
                EndContext();
                BeginContext(3933, 91, true);
                WriteLiteral("\' + \'?CId=\' + encodeURI(CId);\r\n            location.href = url;\r\n        }\r\n    </script>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
