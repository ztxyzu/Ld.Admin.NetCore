#pragma checksum "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "842f4f9e9dae3ce245dfba1150e703eb50687cb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LogTable_Details), @"mvc.1.0.view", @"/Views/LogTable/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LogTable/Details.cshtml", typeof(AspNetCore.Views_LogTable_Details))]
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
#line 1 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
using LdCms.EF.DbModels;

#line default
#line hidden
#line 2 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
using LdCms.Common.Extension;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"842f4f9e9dae3ce245dfba1150e703eb50687cb8", @"/Views/LogTable/Details.cshtml")]
    public class Views_LogTable_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ld_Log_TableDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/My97DatePicker/4.8/WdatePicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/datatables/1.10.0/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/laypage/1.2/laypage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(188, 91, true);
            WriteLiteral("\r\n\r\n<div class=\"page-container\">\r\n    <div class=\"mt-10\">\r\n        <div class=\"mb-10\">数据表： ");
            EndContext();
            BeginContext(280, 17, false);
#line 12 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
                           Write(ViewBag.TableName);

#line default
#line hidden
            EndContext();
            BeginContext(297, 544, true);
            WriteLiteral(@" 字段明细</div>
        <table class=""table table-border table-bordered table-hover table-bg table-sort"">
            <thead>
                <tr class=""text-c"">
                    <th width=""240"">表名</th>
                    <th width=""220"">字段名称</th>
                    <th width=""260"">字段注释</th>
                    <th width=""80"">数据类型</th>
                    <th width=""60"">主键</th>
                    <th width="""">备注</th>
                    <th width=""120"">操作</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 26 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
                 if (Model != null)
                {
                    foreach (var m in Model)
                    {

#line default
#line hidden
            BeginContext(966, 77, true);
            WriteLiteral("                        <tr class=\"text-c\">\r\n                            <td>");
            EndContext();
            BeginContext(1044, 17, false);
#line 31 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
                           Write(ViewBag.TableName);

#line default
#line hidden
            EndContext();
            BeginContext(1061, 54, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-l\">");
            EndContext();
            BeginContext(1116, 12, false);
#line 32 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
                                          Write(m.ColumnName);

#line default
#line hidden
            EndContext();
            BeginContext(1128, 54, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-l\">");
            EndContext();
            BeginContext(1183, 12, false);
#line 33 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
                                          Write(m.ColumnText);

#line default
#line hidden
            EndContext();
            BeginContext(1195, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1235, 16, false);
#line 34 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
                           Write(m.ColumnDataType);

#line default
#line hidden
            EndContext();
            BeginContext(1251, 57, true);
            WriteLiteral("</td>\r\n                            <td class=\"td-status\">");
            EndContext();
            BeginContext(1310, 151, false);
#line 35 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
                                              Write(m.IsPrimaryKey.ToBool() ? Html.Raw("<span class='label label-success radius'>是</span>") : Html.Raw("<span class='label label-defaunt radius'>否</span>"));

#line default
#line hidden
            EndContext();
            BeginContext(1462, 54, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-l\">");
            EndContext();
            BeginContext(1517, 8, false);
#line 36 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
                                          Write(m.Remark);

#line default
#line hidden
            EndContext();
            BeginContext(1525, 59, true);
            WriteLiteral("</td>\r\n                            <td class=\"td-manage\">\r\n");
            EndContext();
#line 38 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
                                 if (m.IsPrimaryKey.ToBool())
                                {

#line default
#line hidden
            BeginContext(1682, 109, true);
            WriteLiteral("                                <a title=\"删除主建\" href=\"javascript:;\" class=\"ml-5\" style=\"text-decoration:none\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 1791, "\"", 1827, 3);
            WriteAttributeValue("", 1801, "$.mainu.stop(this,\'", 1801, 19, true);
#line 40 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
WriteAttributeValue("", 1820, m.ID, 1820, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 1825, "\')", 1825, 2, true);
            EndWriteAttribute();
            BeginContext(1828, 11, true);
            WriteLiteral(">删除主建</a>\r\n");
            EndContext();
#line 41 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1947, 109, true);
            WriteLiteral("                                <a title=\"设为主建\" href=\"javascript:;\" class=\"ml-5\" style=\"text-decoration:none\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 2056, "\"", 2093, 3);
            WriteAttributeValue("", 2066, "$.mainu.start(this,\'", 2066, 20, true);
#line 44 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
WriteAttributeValue("", 2086, m.ID, 2086, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 2091, "\')", 2091, 2, true);
            EndWriteAttribute();
            BeginContext(2094, 11, true);
            WriteLiteral(">设为主建</a>\r\n");
            EndContext();
#line 45 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
                                }

#line default
#line hidden
            BeginContext(2140, 67, true);
            WriteLiteral("                                <a title=\"编辑注释\" href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2207, "\"", 2283, 3);
            WriteAttributeValue("", 2217, "$.mainu.edit(\'编辑\',\'", 2217, 19, true);
#line 46 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
WriteAttributeValue("", 2236, Url.Action("EditDetails", new { id = m.ID }), 2236, 45, false);

#line default
#line hidden
            WriteAttributeValue("", 2281, "\')", 2281, 2, true);
            EndWriteAttribute();
            BeginContext(2284, 117, true);
            WriteLiteral(" class=\"ml-5\" style=\"text-decoration:none\">编辑</a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 49 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2443, 120, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div class=\"pt-30\" style=\"width:100%; height:60px;\"></div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2642, 34, true);
                WriteLiteral("\r\n    <!--请在下方写此页面业务相关的脚本-->\r\n    ");
                EndContext();
                BeginContext(2676, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d850b840926a4e1b9ebe97af96b8a21d", async() => {
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
                EndContext();
                BeginContext(2768, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2774, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40cbe78d029b4c24aee9c0f2120aa4c9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2875, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2881, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5afa8961a6da4c629df402d195e183ca", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2962, 542, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
            (function ($) {
                $.mainu = {
                    init: function () {

                    },
                    edit: function (title, url, w, h) {
                        layer_show(title, url, w, h);
                    },
                    stop: function (obj, id) {
                        layer.confirm('确认要删除主建吗？', function (index) {
                            $.ajax({
                                type: 'POST',
                                url: '");
                EndContext();
                BeginContext(3505, 30, false);
#line 79 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
                                 Write(Url.Action("UpdatePrimaryKey"));

#line default
#line hidden
                EndContext();
                BeginContext(3535, 1574, true);
                WriteLiteral(@"',
                                data: { id: id, fState: false },
                                dataType: 'json',
                                success: function (result) {
                                    var state = result.state;
                                    var message = result.message;
                                    if (state == ""success"") {
                                        $(obj).parents(""tr"").find("".td-manage"").prepend('<a title=""设为主建"" href=""javascript:;"" class=""ml-5"" style=""text-decoration:none"" onClick=""$.mainu.start(this,\'' + id + '\')"">设为主建</a>');
                                        $(obj).parents(""tr"").find("".td-status"").html('<span class=""label label-defaunt radius"">否</span>');
                                        $(obj).remove();
                                        layer.msg('删除主建！', { icon: 5, time: 3000 });
                                    } else {
                                        layer.msg(message, { icon: 5, time: 3000 });
       ");
                WriteLiteral(@"                             }
                                },
                                error: function (data) {
                                    console.log(data.msg);
                                }
                            });
                        });
                    },
                    start: function (obj, id) {
                        layer.confirm('确认要设为主建吗？', function (index) {
                            $.ajax({
                                type: 'POST',
                                url: '");
                EndContext();
                BeginContext(5110, 30, false);
#line 104 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\LogTable\Details.cshtml"
                                 Write(Url.Action("UpdatePrimaryKey"));

#line default
#line hidden
                EndContext();
                BeginContext(5140, 1479, true);
                WriteLiteral(@"',
                                data: { id: id, fState: true },
                                dataType: 'json',
                                success: function (result) {
                                    var state = result.state;
                                    var message = result.message;
                                    if (state == ""success"") {
                                        $(obj).parents(""tr"").find("".td-manage"").prepend('<a title=""删除主建"" href=""javascript:;"" class=""ml-5"" style=""text-decoration:none"" onClick=""$.mainu.stop(this,\'' + id + '\')"">删除主建</a>');
                                        $(obj).parents(""tr"").find("".td-status"").html('<span class=""label label-success radius"">是</span>');
                                        $(obj).remove();
                                        layer.msg('设为主建！', { icon: 6, time: 3000 });
                                    } else {
                                        layer.msg(message, { icon: 5, time: 3000 });
         ");
                WriteLiteral(@"                           }
                                },
                                error: function (data) {
                                    console.log(data.msg);
                                }
                            });
                        });
                    }
                };
                $(function () {
                    $.mainu.init();
                });
            })(jQuery);
    </script>
");
                EndContext();
            }
            );
            BeginContext(6622, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ld_Log_TableDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
