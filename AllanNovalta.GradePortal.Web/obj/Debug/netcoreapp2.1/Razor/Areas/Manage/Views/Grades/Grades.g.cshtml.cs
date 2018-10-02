#pragma checksum "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6c5d8c2d18173ac781b405f15d9620eba95b320"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Grades_Grades), @"mvc.1.0.view", @"/Areas/Manage/Views/Grades/Grades.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Grades/Grades.cshtml", typeof(AspNetCore.Areas_Manage_Views_Grades_Grades))]
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
#line 1 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
using AllanNovalta.GradePortal.Web.Areas.Manage.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6c5d8c2d18173ac781b405f15d9620eba95b320", @"/Areas/Manage/Views/Grades/Grades.cshtml")]
    public class Areas_Manage_Views_Grades_Grades : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllanNovalta.GradePortal.Web.Areas.Manage.ViewModels.GradeSheets.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Create User"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
  
    ViewData["Title"] = "Grades";

#line default
#line hidden
            BeginContext(188, 66, true);
            WriteLiteral("\r\n<h2>Grades</h2>\r\n<p>Here is a paged list of all the grades</p>\r\n");
            EndContext();
            BeginContext(254, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a287572a909747dbb74d01a2df2d773d", async() => {
                BeginContext(298, 83, true);
                WriteLiteral("<button type=\"button\" class=\"btn\">Add Grades   <i class=\"fas fa-plus\"></i></button>");
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
            BeginContext(385, 404, true);
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th>Name</th>
            <th>Subject Title</th>
            <th>Subject Code</th>
            <th>Academic Year</th>
            <th>Semester</th>
            <th>Grade</th>
            <th>Grade Point</th>
            <th>Remark</th>
            <th>Comments</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 26 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
          
            foreach (StudentGrade grade in Model.Grades.Items)
            {

#line default
#line hidden
            BeginContext(880, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(927, 14, false);
#line 30 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
                   Write(grade.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(941, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(973, 17, false);
#line 31 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
                   Write(grade.SubjectCode);

#line default
#line hidden
            EndContext();
            BeginContext(990, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1022, 18, false);
#line 32 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
                   Write(grade.SubjectTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1040, 31, true);
            WriteLiteral("</td>\r\n                    <th>");
            EndContext();
            BeginContext(1072, 18, false);
#line 33 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
                   Write(grade.AcademicYear);

#line default
#line hidden
            EndContext();
            BeginContext(1090, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1122, 14, false);
#line 34 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
                   Write(grade.Semester);

#line default
#line hidden
            EndContext();
            BeginContext(1136, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1168, 18, false);
#line 35 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
                   Write(grade.GradePercent);

#line default
#line hidden
            EndContext();
            BeginContext(1186, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1218, 16, false);
#line 36 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
                   Write(grade.GradePoint);

#line default
#line hidden
            EndContext();
            BeginContext(1234, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
            BeginContext(1289, 24, true);
            WriteLiteral("                    <th>");
            EndContext();
            BeginContext(1314, 13, false);
#line 38 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
                   Write(grade.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(1327, 32, true);
            WriteLiteral("</th>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 41 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1385, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllanNovalta.GradePortal.Web.Areas.Manage.ViewModels.GradeSheets.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
