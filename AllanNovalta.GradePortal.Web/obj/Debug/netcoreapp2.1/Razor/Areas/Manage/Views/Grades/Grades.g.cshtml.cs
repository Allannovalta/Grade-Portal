#pragma checksum "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32063ea4a39d2e3c11dc16725fc30c8a729b14e0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32063ea4a39d2e3c11dc16725fc30c8a729b14e0", @"/Areas/Manage/Views/Grades/Grades.cshtml")]
    public class Areas_Manage_Views_Grades_Grades : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllanNovalta.GradePortal.Web.Areas.Manage.ViewModels.GradeSheets.IndexViewModel>
    {
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
            BeginContext(393, 402, true);
            WriteLiteral(@"<table class=""table"">
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
            BeginContext(886, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(933, 14, false);
#line 30 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
                   Write(grade.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(947, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(979, 17, false);
#line 31 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
                   Write(grade.SubjectCode);

#line default
#line hidden
            EndContext();
            BeginContext(996, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1028, 18, false);
#line 32 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
                   Write(grade.SubjectTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1046, 31, true);
            WriteLiteral("</td>\r\n                    <th>");
            EndContext();
            BeginContext(1078, 18, false);
#line 33 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
                   Write(grade.AcademicYear);

#line default
#line hidden
            EndContext();
            BeginContext(1096, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1128, 14, false);
#line 34 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
                   Write(grade.Semester);

#line default
#line hidden
            EndContext();
            BeginContext(1142, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1174, 18, false);
#line 35 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
                   Write(grade.GradePercent);

#line default
#line hidden
            EndContext();
            BeginContext(1192, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1224, 16, false);
#line 36 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
                   Write(grade.GradePoint);

#line default
#line hidden
            EndContext();
            BeginContext(1240, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
            BeginContext(1295, 24, true);
            WriteLiteral("                    <th>");
            EndContext();
            BeginContext(1320, 13, false);
#line 38 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
                   Write(grade.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(1333, 32, true);
            WriteLiteral("</th>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 41 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Areas\Manage\Views\Grades\Grades.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1391, 22, true);
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
