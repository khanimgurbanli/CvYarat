#pragma checksum "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f6723e7bcf10c5de4f40fbda36c4525f9a47708"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PrivateInfo_Edit), @"mvc.1.0.view", @"/Views/PrivateInfo/Edit.cshtml")]
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
#line 2 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\_ViewImports.cshtml"
using CvYarat.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
using CvYarat.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
using CvYarat.Data.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f6723e7bcf10c5de4f40fbda36c4525f9a47708", @"/Views/PrivateInfo/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d198c68932402d623a9b03359914f30b20324c68", @"/Views/_ViewImports.cshtml")]
    public class Views_PrivateInfo_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EditProfileImage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/site.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PrivateInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f6723e7bcf10c5de4f40fbda36c4525f9a477087667", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8f6723e7bcf10c5de4f40fbda36c4525f9a477088047", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8f6723e7bcf10c5de4f40fbda36c4525f9a477089225", async() => {
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
#line 12 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f6723e7bcf10c5de4f40fbda36c4525f9a4770811954", async() => {
                WriteLiteral("\r\n    <h3>Şəxsi məlumatlar</h3><br /><br />\r\n    <div>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f6723e7bcf10c5de4f40fbda36c4525f9a4770812279", async() => {
                    WriteLiteral("\r\n            <div>\r\n                ");
#nullable restore
#line 19 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.HiddenFor(x => x.Id, new { Value = Model.Id, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n                <div>\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8f6723e7bcf10c5de4f40fbda36c4525f9a4770812938", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
                   WriteLiteral("~/images/"+ Model.Photo);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 22 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
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
                    WriteLiteral(@"
                </div><br /><br />


                <div class=""form-group"">
                    <label>Foto yükləyin</label><br />
                    <input type=""file"" name=""ImageFile"" class=""form-control"" />
                </div><br /><br />

                <label>Ad</label><br /><br />
                ");
#nullable restore
#line 32 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.TextBoxFor(x => x.Name, new { Value = Model.Name, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n                ");
#nullable restore
#line 33 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.ValidationMessageFor(x => x.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n                <label>Soyad</label><br /><br />\r\n                ");
#nullable restore
#line 36 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.TextBoxFor(x => x.Surname, new { Value = Model.Surname, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n                ");
#nullable restore
#line 37 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.ValidationMessageFor(x => x.Surname, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n                <label>Ata adı</label><br /><br />\r\n                ");
#nullable restore
#line 40 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.TextBoxFor(x => x.FatherName, new { Value = Model.FatherName, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n                ");
#nullable restore
#line 41 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.ValidationMessageFor(x => x.FatherName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n                <label>Cinsiyyət</label><br /><br />\r\n                ");
#nullable restore
#line 44 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.DropDownListFor(x => x.Gender, new SelectList(Enum.GetValues(typeof(SelectGender))), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n                ");
#nullable restore
#line 45 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.ValidationMessageFor(x => x.Gender, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n                <label>Doğum tarixi</label><br /><br />\r\n                ");
#nullable restore
#line 48 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.TextBoxFor(x => x.Birthdate, new { Value = Model.Birthdate, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n                ");
#nullable restore
#line 49 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.ValidationMessageFor(x => x.Birthdate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n\r\n                <label>Ailə vəziyyəti</label><br /><br />\r\n                ");
#nullable restore
#line 53 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.DropDownListFor(x => x.MaritalStatus, new SelectList(Enum.GetValues(typeof(MrtlStatus))), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n                ");
#nullable restore
#line 54 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.ValidationMessageFor(x => x.MaritalStatus, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n\r\n                <label>Vətəndaşlıq</label><br />\r\n                ");
#nullable restore
#line 58 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.TextBoxFor(x => x.Citizenship, new { Value = Model.Citizenship, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n                <label>Elektron poçt ünvanı</label><br />\r\n                ");
#nullable restore
#line 61 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.TextBoxFor(x => x.Mail, new { Value = Model.Mail, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n                ");
#nullable restore
#line 62 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.ValidationMessageFor(x => x.Mail, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n\r\n                <label>Sürücülük vəsiqəsi</label><br />\r\n                ");
#nullable restore
#line 66 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.DropDownListFor(x => x.DrivingLicense, new SelectList(Enum.GetValues(typeof(DrvgLicense))), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n                ");
#nullable restore
#line 67 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.ValidationMessageFor(x => x.DrivingLicense, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n\r\n                <label>Hərbi xidmət</label><br />\r\n                ");
#nullable restore
#line 71 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.DropDownListFor(x => x.MilitaryService, new SelectList(Enum.GetValues(typeof(MltryService))), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n                ");
#nullable restore
#line 72 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.ValidationMessageFor(x => x.MilitaryService, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n\r\n                <label>Yaşayış ünvanı</label><br />\r\n                ");
#nullable restore
#line 76 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.TextBoxFor(x => x.LivingAddress, new { Value = Model.LivingAddress, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n                ");
#nullable restore
#line 77 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.ValidationMessageFor(x => x.LivingAddress, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n\r\n                <label>Qeydiyyatda olduğunuz</label><br />\r\n                ");
#nullable restore
#line 81 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.TextBoxFor(x => x.RegistrationAddress, new { Value = Model.RegistrationAddress, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n                <label>Mobil Nömrə</label><br />\r\n                ");
#nullable restore
#line 84 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.TextBoxFor(x => x.MobPhone, new { Value = Model.MobPhone, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n                ");
#nullable restore
#line 85 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.ValidationMessageFor(x => x.MobPhone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n\r\n                <label>Linkedin hesab linki</label><br />\r\n                ");
#nullable restore
#line 89 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.TextBoxFor(x => x.Linkedin, new { Value = Model.Linkedin, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n                <label>Github hesab linki</label><br />\r\n                ");
#nullable restore
#line 92 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.TextBoxFor(x => x.Github, new { Value = Model.Github, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n                <label>Yaşadığınız şəhər</label><br /><br />\r\n                ");
#nullable restore
#line 95 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.DropDownListFor(x => x.CityId, (List<SelectListItem>)@ViewData["City"], new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n                ");
#nullable restore
#line 96 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.ValidationMessageFor(x => x.CityId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n\r\n                <label>Əlavə qeyd</label><br />\r\n                ");
#nullable restore
#line 99 "C:\Users\ACER\Desktop\SonCvYarat\CvYarat\CvYarat\Views\PrivateInfo\Edit.cshtml"
           Write(Html.TextBoxFor(x => x.Action, new { Value = Model.Action, @class = "form-control" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<br />\r\n                <input type=\"submit\" class=\"btn btn-success\" value=\"Yadda saxla\">\r\n\r\n            </div>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditProfileImage> Html { get; private set; }
    }
}
#pragma warning restore 1591