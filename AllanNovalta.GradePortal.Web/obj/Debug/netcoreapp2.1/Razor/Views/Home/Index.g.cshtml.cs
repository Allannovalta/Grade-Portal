#pragma checksum "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ef0e33b46c95f0f172f547615bb4153cbf381ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Views\_ViewImports.cshtml"
using AllanNovalta.GradePortal.Web;

#line default
#line hidden
#line 2 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Views\_ViewImports.cshtml"
using AllanNovalta.GradePortal.Web.Models;

#line default
#line hidden
#line 1 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Views\Home\Index.cshtml"
using AllanNovalta.GradePortal.Web.Infrastructure.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ef0e33b46c95f0f172f547615bb4153cbf381ed", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3645ee9abb6c0b5d42457454d9516c8433106ac5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllanNovalta.GradePortal.Web.ViewModels.Users.IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(135, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "View Grade";

#line default
#line hidden
            BeginContext(183, 317, true);
            WriteLiteral(@"
<div class=""container"">
    <h2>Users</h2>
    <p>Here is a paged list of all the users</p>
    <table class=""table"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Email Address</th>
                <th>Gender</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 20 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Views\Home\Index.cshtml"
              
                foreach (User user in Model.Users.Items)
                {

#line default
#line hidden
            BeginContext(593, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(648, 13, false);
#line 24 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Views\Home\Index.cshtml"
                       Write(user.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(661, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(697, 17, false);
#line 25 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Views\Home\Index.cshtml"
                       Write(user.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(714, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(750, 11, false);
#line 26 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Views\Home\Index.cshtml"
                       Write(user.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(761, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 28 "C:\Users\ALLAN_Novalta\Documents\CSM_Website\New AllanNovalta.CSMGradePortal.Web\AllanNovalta.GradePortal.Web\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(829, 39, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllanNovalta.GradePortal.Web.ViewModels.Users.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
