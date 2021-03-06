#pragma checksum "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\Intention.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e41fb0cac325e67f3a2cf61fb4985d3b7f5272c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Intention), @"mvc.1.0.view", @"/Views/Admin/Intention.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Intention.cshtml", typeof(AspNetCore.Views_Admin_Intention))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e41fb0cac325e67f3a2cf61fb4985d3b7f5272c", @"/Views/Admin/Intention.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dd4cdda90c1aa4f501d634a6985bd5db8aeaf73", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Intention : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\Intention.cshtml"
  
    Layout = "adminHomeLayout";
    var intentions = Model;

#line default
#line hidden
            BeginContext(69, 246, true);
            WriteLiteral("\r\n<div class=\"box ui-draggable ui-droppable\">\r\n    <div class=\"box-header\">\r\n        <div class=\"box-name\">\r\n            <i class=\"fa fa-table\"></i>\r\n            <span>应聘信息</span>\r\n        </div>\r\n        <div class=\"no-move\"></div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1062, 432, true);
            WriteLiteral(@"    <div class=""box-content no-padding"">
        <table class=""table table-striped table-bordered table-hover table-heading no-border-bottom"">
            <thead>
                <tr>
                    <th>应聘者账号</th>
                    <th>招聘信息账号</th>
                    <th>信息状态</th>
                    <th>投递时间</th>
                    <th>处理时间</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 42 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\Intention.cshtml"
                 for (int i = 0; i < intentions.Count; i++)
                {

#line default
#line hidden
            BeginContext(1574, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1629, 17, false);
#line 45 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\Intention.cshtml"
                       Write(intentions[i].AId);

#line default
#line hidden
            EndContext();
            BeginContext(1646, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1682, 17, false);
#line 46 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\Intention.cshtml"
                       Write(intentions[i].RId);

#line default
#line hidden
            EndContext();
            BeginContext(1699, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1735, 21, false);
#line 47 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\Intention.cshtml"
                       Write(intentions[i].IStatus);

#line default
#line hidden
            EndContext();
            BeginContext(1756, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1792, 25, false);
#line 48 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\Intention.cshtml"
                       Write(intentions[i].ICreateTime);

#line default
#line hidden
            EndContext();
            BeginContext(1817, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1853, 23, false);
#line 49 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\Intention.cshtml"
                       Write(intentions[i].IDealTime);

#line default
#line hidden
            EndContext();
            BeginContext(1876, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 51 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\Intention.cshtml"
                }

#line default
#line hidden
            BeginContext(1929, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("MyScripts", async() => {
                BeginContext(2016, 163, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        function Deleteitem(AId)\r\n        {\r\n            if (confirm(\"确定要删除吗？\"))\r\n            {\r\n                var url = \'");
                EndContext();
                BeginContext(2180, 38, false);
#line 64 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\Intention.cshtml"
                      Write(Url.Action("DeleteApplicant", "Admin"));

#line default
#line hidden
                EndContext();
                BeginContext(2218, 163, true);
                WriteLiteral("\' + \'?AId=\' + encodeURI(AId);\r\n                location.href = url;\r\n            }\r\n        }\r\n        function showitem(AId)\r\n        {\r\n\r\n            var url = \'");
                EndContext();
                BeginContext(2382, 36, false);
#line 71 "D:\高鹤\生产实习\ptj1\PTJ-NEW\PartTimeJob\Views\Admin\Intention.cshtml"
                  Write(Url.Action("IntentionList", "Admin"));

#line default
#line hidden
                EndContext();
                BeginContext(2418, 91, true);
                WriteLiteral("\' + \'?AId=\' + encodeURI(AId);\r\n            location.href = url;\r\n        }\r\n    </script>\r\n");
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
