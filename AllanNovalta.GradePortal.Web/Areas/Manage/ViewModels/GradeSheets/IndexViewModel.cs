using AllanNovalta.GradePortal.Web.Areas.Manage.Models;
using AllanNovalta.GradePortal.Web.Infrastructure.Data.Helpers;
using AllanNovalta.GradePortal.Web.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllanNovalta.GradePortal.Web.Areas.Manage.ViewModels.GradeSheets
{
    public class IndexViewModel
    {
        public Page<StudentGrade> Grades { get; set; }
    }
}
