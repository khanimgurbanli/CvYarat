#pragma checksum "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListEdu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b13745f9b1b65a0e95a62a4214f7d8b7104e388e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Education_GetListEdu), @"mvc.1.0.view", @"/Views/Education/GetListEdu.cshtml")]
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
#line 1 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\_ViewImports.cshtml"
using CvYarat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListEdu.cshtml"
using CvYarat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b13745f9b1b65a0e95a62a4214f7d8b7104e388e", @"/Views/Education/GetListEdu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d198c68932402d623a9b03359914f30b20324c68", @"/Views/_ViewImports.cshtml")]
    public class Views_Education_GetListEdu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Education>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/site.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b13745f9b1b65a0e95a62a4214f7d8b7104e388e5523", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b13745f9b1b65a0e95a62a4214f7d8b7104e388e5903", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b13745f9b1b65a0e95a62a4214f7d8b7104e388e7081", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 9 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListEdu.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b13745f9b1b65a0e95a62a4214f7d8b7104e388e9813", async() => {
                WriteLiteral("\r\n    <div>\r\n        <h5><a href=\"/Education/CreateEdu\">Təhsil əlavə et</a></h5>\r\n        <h6><a href=\"/Education/CreateProfDevp\">Təlim və ixtisasartırma</a></h6>\r\n");
#nullable restore
#line 15 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListEdu.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b13745f9b1b65a0e95a62a4214f7d8b7104e388e10505", async() => {
                    WriteLiteral("\r\n\r\n\r\n                <label>Təhsil səviyyəsi </label><br /><br />\r\n                ");
#nullable restore
#line 22 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListEdu.cshtml"
           Write(Html.DropDownListFor(x => @item.EducationLevelId, (List<SelectListItem>)ViewData["EduLevel"], "Seçin", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n        \r\n\r\n                <label>İxtisas</label><br /><br />\r\n                ");
#nullable restore
#line 26 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListEdu.cshtml"
           Write(Html.TextBoxFor(x => @item.Specialty, new { Valu = @item.Specialty, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n            \r\n\r\n                <label>Təhsil müəssisəsi</label><br /><br />\r\n                ");
#nullable restore
#line 30 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListEdu.cshtml"
           Write(Html.DropDownListFor(x => @item.EduInstitutionId, (List<SelectListItem>)ViewData["Institution"], new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n     \r\n\r\n\r\n                <label>Başlama tarixi</label><br /><br />\r\n                ");
#nullable restore
#line 35 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListEdu.cshtml"
           Write(Html.TextBoxFor(x => @item.BeginDate, new { Valu = @item.BeginDate, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n\r\n                <label>Bitmə tarixi</label><br /><br />\r\n                ");
#nullable restore
#line 39 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListEdu.cshtml"
           Write(Html.TextBoxFor(x => @item.EndDate, new { Valu = @item.EndDate, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n                <label>Giriş balı</label><br /><br />\r\n                ");
#nullable restore
#line 42 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListEdu.cshtml"
           Write(Html.TextBoxFor(x => @item.Point, new { Valu = @item.Point, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("            <a");
                BeginWriteAttribute("href", " href=\"", 1841, "\"", 1875, 2);
                WriteAttributeValue("", 1848, "/Education/EditEdu/", 1848, 19, true);
#nullable restore
#line 45 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListEdu.cshtml"
WriteAttributeValue("", 1867, item.Id, 1867, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Dəyiş</a> <a");
                BeginWriteAttribute("href", " href=\"", 1889, "\"", 1925, 2);
                WriteAttributeValue("", 1896, "/Education/DeleteEdu/", 1896, 21, true);
#nullable restore
#line 45 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListEdu.cshtml"
WriteAttributeValue("", 1917, item.Id, 1917, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Sil</a>\r\n");
#nullable restore
#line 46 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListEdu.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Education>> Html { get; private set; }
    }
}
#pragma warning restore 1591
