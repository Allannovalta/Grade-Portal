#pragma checksum "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9217c05f7067c2e802dcaafbd9ff8d4573c27356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Grades_Create), @"mvc.1.0.view", @"/Areas/Manage/Views/Grades/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Grades/Create.cshtml", typeof(AspNetCore.Areas_Manage_Views_Grades_Create))]
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
#line 1 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Create.cshtml"
using AllanNovalta.GradePortal.Web.Areas.Manage.ViewModels.GradeSheets;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9217c05f7067c2e802dcaafbd9ff8d4573c27356", @"/Areas/Manage/Views/Grades/Create.cshtml")]
    public class Areas_Manage_Views_Grades_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Areas/Manage/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(178, 19, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n");
            EndContext();
            BeginContext(197, 1507, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b579703430b467d9f07dbcb84d38306", async() => {
                BeginContext(240, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(247, 23, false);
#line 10 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(270, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(277, 24, false);
#line 11 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Create.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(301, 1396, true);
                WriteLiteral(@"
    <div class=""form-group"">
        <label for=""Name"">Student Name</label>
        <input type=""name"" class=""form-control"" id=""name"" asp-for=""Name"" aria-describedby=""NameHelp"" placeholder=""Enter Student Name"">
        <small id=""NameHelp"" class=""form-text text-muted"">Name is required.</small>
    </div>
    <div class=""form-group"">
        <label for=""SubjectCode"">SubjectCode</label>
        <input type=""subjectCode"" class=""form-control"" id=""subjectCode"" asp-for=""subjectCode"" aria-describedby=""SubjectCodeHelp"" placeholder=""Subject Code"">
        <small id=""SubjectCodeHelp"" class=""form-text text-muted"">Subject Code is required.</small>
    </div>
    <div class=""form-group"">
        <label for=""SubjectTitle"">SubjectTitle</label>
        <input type=""subjectTitle"" class=""form-control"" id=""subjectTitle"" asp-for=""subjectTitle"" aria-describedby=""SubjectTitleHelp"" placeholder=""Subject Title"">
        <small id=""SubjectTitleHelp"" class=""form-text text-muted"">Subject Title is required.</small>
    </");
                WriteLiteral(@"div>
    <div class=""form-group"">
        <label for=""academicYear"">AcademicYear</label>
        <input type=""academicYear"" class=""form-control"" id=""subjectTitle"" asp-for=""academicYear"" aria-describedby=""AcademicYearHelp"" placeholder=""Academic Year"">
        <small id=""AcademicYearHelp"" class=""form-text text-muted""> Academic Year is required.</small>
    </div>

");
                EndContext();
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
            BeginContext(1704, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
