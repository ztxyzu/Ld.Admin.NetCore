#pragma checksum "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a513f4bce12e0f7a16d3ee35a39a1e2289f37f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InstitutionStore_Add), @"mvc.1.0.view", @"/Views/InstitutionStore/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/InstitutionStore/Add.cshtml", typeof(AspNetCore.Views_InstitutionStore_Add))]
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
#line 1 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml"
using LdCms.EF.DbModels;

#line default
#line hidden
#line 2 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml"
using LdCms.Common.Extension;

#line default
#line hidden
#line 3 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml"
using LdCms.Common.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a513f4bce12e0f7a16d3ee35a39a1e2289f37f3", @"/Views/InstitutionStore/Add.cshtml")]
    public class Views_InstitutionStore_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ld_Institution_Store>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/validate-methods.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/messages_zh.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(201, 45, true);
            WriteLiteral("\r\n<article class=\"page-container\">\r\n    <form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 246, "\"", 306, 1);
#line 11 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml"
WriteAttributeValue("", 255, Url.Action("Save",new { StoreId = Model.StoreID }), 255, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(307, 302, true);
            WriteLiteral(@" method=""post"" class=""form form-horizontal"" id=""form-add"">

        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>网点编号：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 609, "\"", 631, 1);
#line 16 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml"
WriteAttributeValue("", 617, Model.StoreID, 617, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(632, 46, true);
            WriteLiteral(" placeholder=\"\" id=\"fStoreId\" name=\"fStoreId\" ");
            EndContext();
            BeginContext(680, 53, false);
#line 16 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml"
                                                                                                                      Write(string.IsNullOrEmpty(Model.StoreID) ? "" : "disabled");

#line default
#line hidden
            EndContext();
            BeginContext(734, 281, true);
            WriteLiteral(@" />
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>网点名称：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1015, "\"", 1039, 1);
#line 22 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml"
WriteAttributeValue("", 1023, Model.StoreName, 1023, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1040, 331, true);
            WriteLiteral(@" placeholder="""" id=""fStoreName"" name=""fStoreName"" />
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>联系人姓名：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1371, "\"", 1394, 1);
#line 28 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml"
WriteAttributeValue("", 1379, Model.Contacts, 1379, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1395, 329, true);
            WriteLiteral(@" placeholder="""" id=""fContacts"" name=""fContacts"" />
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>联系人手机：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1724, "\"", 1744, 1);
#line 34 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml"
WriteAttributeValue("", 1732, Model.Phone, 1732, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1745, 322, true);
            WriteLiteral(@" placeholder="""" id=""fPhone"" name=""fPhone"" />
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>网点电话：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2067, "\"", 2085, 1);
#line 40 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml"
WriteAttributeValue("", 2075, Model.Tel, 2075, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2086, 318, true);
            WriteLiteral(@" placeholder="""" id=""fTel"" name=""fTel"" />
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>网点传真：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2404, "\"", 2422, 1);
#line 46 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml"
WriteAttributeValue("", 2412, Model.Fax, 2412, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2423, 320, true);
            WriteLiteral(@" placeholder="""" id=""fFax"" name=""fFax"" />
            </div>
        </div>

        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>电子邮箱：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2743, "\"", 2763, 1);
#line 53 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml"
WriteAttributeValue("", 2751, Model.Email, 2751, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2764, 1347, true);
            WriteLiteral(@" placeholder="""" id=""fEmail"" name=""fEmail"" />
            </div>
        </div>
        <div class=""row cl"" style=""display:none;"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>所属区域：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <span class=""select-box"" style=""width:32%;"">
                    <select class=""select"" size=""1"" id=""fProvinceId"" name=""fProvinceId"">
                        <option value="""">请选择省份</option>
                    </select>
                </span>
                <span class=""select-box"" style=""width:32%;"">
                    <select class=""select"" size=""1"" id=""fCityId"" name=""fCityId"">
                        <option value="""">请选择城市</option>
                    </select>
                </span>
                <span class=""select-box"" style=""width:32%;"">
                    <select class=""select"" size=""1"" id=""fAreaId"" name=""fAreaId"">
                        <option value="""">请选择区/县</option>
         ");
            WriteLiteral(@"           </select>
                </span>
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>网点地址：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4111, "\"", 4133, 1);
#line 79 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml"
WriteAttributeValue("", 4119, Model.Address, 4119, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4134, 324, true);
            WriteLiteral(@" placeholder="""" id=""fAddress"" name=""fAddress"" />
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>排序：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4458, "\"", 4477, 1);
#line 85 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml"
WriteAttributeValue("", 4466, Model.Sort, 4466, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4478, 365, true);
            WriteLiteral(@" placeholder="""" id=""fSort"" name=""fSort"" />
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2"">备注：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <textarea id=""fDescription"" name=""fDescription"" class=""textarea"" placeholder=""说点什么...100个字符以内"" dragonfly=""true"">");
            EndContext();
            BeginContext(4844, 27, false);
#line 91 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml"
                                                                                                                           Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(4871, 429, true);
            WriteLiteral(@"</textarea>
                <p class=""textarea-numberbar""><em class=""textarea-length"">0</em>/100</p>
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2"">审核：</label>
            <div class=""formControls col-xs-8 col-sm-9 skin-minimal"">
                <div class=""check-box"">
                    <input type=""checkbox"" id=""fState"" name=""fState"" value=""1"" ");
            EndContext();
            BeginContext(5302, 37, false);
#line 99 "G:\蓝点管理信息系统-开源版ASP.NET CORE\正式发布版本\LdCms_V1.0\LdCms.Web\Views\InstitutionStore\Add.cshtml"
                                                                           Write(Model.State.ToBool() ? "checked" : "");

#line default
#line hidden
            EndContext();
            BeginContext(5340, 400, true);
            WriteLiteral(@" />
                    <label for=""checkbox-1"">&nbsp;</label>
                </div>
            </div>
        </div>
        <div class=""row cl"">
            <div class=""col-xs-8 col-sm-9 col-xs-offset-4 col-sm-offset-2"">
                <input class=""btn btn-primary radius"" type=""submit"" value=""&nbsp;&nbsp;提交&nbsp;&nbsp;"">
            </div>
        </div>
    </form>
</article>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(5819, 34, true);
                WriteLiteral("\r\n    <!--请在下方写此页面业务相关的脚本-->\r\n    ");
                EndContext();
                BeginContext(5853, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53bfab00380e4167a84701e7e67bf12b", async() => {
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
                BeginContext(5955, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5961, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "449c486b386543c098a5c7ddcd34b9b7", async() => {
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
                BeginContext(6064, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6070, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42ed3bb4074f472e856e384e4435301d", async() => {
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
                BeginContext(6168, 2742, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        (function ($) {
            $.mainu = {
                init: function () {
                    $('.skin-minimal input').iCheck({
                        checkboxClass: 'icheckbox-blue',
                        radioClass: 'iradio-blue',
                        increaseArea: '20%'
                    });
                    $(""#fDescription"").Huitextarealength({
                        minlength: 4,
                        maxlength: 100
                    });

                },
                formSubmit: function () {
                    $(""#form-add"").validate({
                        rules: {
                            fStoreId: {
                                required: true
                            },
                            fStoreName: {
                                required: true
                            }
                        },
                        onkeyup: false,
                        focusCleanup: tru");
                WriteLiteral(@"e,
                        success: ""valid"",
                        submitHandler: function (form) {
                            var fState = $(""input[name='fState']"").is(':checked');
                            $(form).ajaxSubmit({
                                type: ""POST"",
                                cache: false,
                                data: { fState: fState},
                                dataType: ""json"",
                                error: function (XMLHttpRequest, textStatus, errorThrown) {
                                    if (XMLHttpRequest.status != 200) {
                                        layer.alert(""POST[FAIL]"", { icon: 5 });
                                    }
                                },
                                success: function (result) {
                                    var state = result.state;
                                    var message = result.message;
                                    if (state == ""success"") {
     ");
                WriteLiteral(@"                                   var index = parent.layer.getFrameIndex(window.name);
                                        parent.location.reload();
                                        parent.layer.close(index);
                                    } else {
                                        layer.alert(message, { icon: 5 });
                                    }
                                }
                            });
                        }
                    });
                }
            };
            $(function () {
                $.mainu.init();
                $.mainu.formSubmit();
            });
        })(jQuery);
    </script>
");
                EndContext();
            }
            );
            BeginContext(8913, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ld_Institution_Store> Html { get; private set; }
    }
}
#pragma warning restore 1591
