#pragma checksum "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e5422f5c2d1de86aa59779c3f4b9bebe2e104a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Education_GetListTraining), @"mvc.1.0.view", @"/Views/Education/GetListTraining.cshtml")]
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
#line 1 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml"
using CvYarat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e5422f5c2d1de86aa59779c3f4b9bebe2e104a0", @"/Views/Education/GetListTraining.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d198c68932402d623a9b03359914f30b20324c68", @"/Views/_ViewImports.cshtml")]
    public class Views_Education_GetListTraining : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientTraining>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/site.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e5422f5c2d1de86aa59779c3f4b9bebe2e104a06379", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e5422f5c2d1de86aa59779c3f4b9bebe2e104a06759", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e5422f5c2d1de86aa59779c3f4b9bebe2e104a07937", async() => {
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
#line 9 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e5422f5c2d1de86aa59779c3f4b9bebe2e104a010674", async() => {
                WriteLiteral("\r\n    <div>\r\n        <h6><a href=\"/Education/CreateProfDevp/1\">Təlim və ixtisasartırma əlavə et</a></h6>\r\n");
#nullable restore
#line 14 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e5422f5c2d1de86aa59779c3f4b9bebe2e104a011308", async() => {
                    WriteLiteral("\r\n               \r\n                <div>\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e5422f5c2d1de86aa59779c3f4b9bebe2e104a011639", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml"
                   WriteLiteral("~/images/"+ @item.Certification);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                </div><br /><br />\r\n\r\n                <label>Təlimin adı</label><br /><br />\r\n                ");
#nullable restore
#line 23 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml"
           Write(Html.TextBoxFor(x => @item.Name, new { Valu = @item.Name, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n                <label>Təlimçinin ədı və soyadı</label><br /><br />\r\n                ");
#nullable restore
#line 26 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml"
           Write(Html.TextBoxFor(x => @item.NameSurname, new { Valu = @item.NameSurname, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n                <label>Təlimçinin əlaqə nömrəsi</label><br /><br />\r\n                ");
#nullable restore
#line 29 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml"
           Write(Html.TextBoxFor(x => @item.Tel, new { Valu = @item.Tel, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n\r\n                <label>Təlimçinin e-poçt ünvanı</label><br /><br />\r\n                ");
#nullable restore
#line 33 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml"
           Write(Html.TextBoxFor(x => @item.Mail, new { Valu = @item.Mail, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n\r\n                <label>Təlimi verən qurum</label><br /><br />\r\n                ");
#nullable restore
#line 37 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml"
           Write(Html.TextBoxFor(x => @item.Instition, new { Valu = @item.Instition, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n\r\n                <label>Təlimin keçirildiyi yer</label><br /><br />\r\n                ");
#nullable restore
#line 41 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml"
           Write(Html.TextBoxFor(x => @item.Address, new { Valu = @item.Address, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n                <label>Təlimin başladığı tarix</label><br /><br />\r\n                ");
#nullable restore
#line 44 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml"
           Write(Html.TextBoxFor(x => @item.ProfBeginDate, new { Valu = @item.ProfEndDate, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n                <label>Təlimin bitdiyi tarix</label><br /><br />\r\n                ");
#nullable restore
#line 47 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml"
           Write(Html.TextBoxFor(x => @item.ProfEndDate, new { Valu = @item.ProfEndDate, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n                <label>Təlimlə bağlı əlavə qeydlər</label><br /><br />\r\n                ");
#nullable restore
#line 50 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml"
           Write(Html.TextBoxFor(x => @item.Note, new { Valu = @item.Note, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("            <a");
                BeginWriteAttribute("href", " href=\"", 2479, "\"", 2518, 2);
                WriteAttributeValue("", 2486, "/Education/EditProfDevp/", 2486, 24, true);
#nullable restore
#line 54 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml"
WriteAttributeValue("", 2510, item.Id, 2510, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Dəyiş</a> <a");
                BeginWriteAttribute("href", " href=\"", 2532, "\"", 2573, 2);
                WriteAttributeValue("", 2539, "/Education/DeleteProfDevp/", 2539, 26, true);
#nullable restore
#line 54 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml"
WriteAttributeValue("", 2565, item.Id, 2565, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Sil</a><br />\r\n");
#nullable restore
#line 55 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\Education\GetListTraining.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClientTraining>> Html { get; private set; }
    }
}
#pragma warning restore 1591