using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllanNovalta.GradePortal.Web.Areas.Manage.ViewModels.GradeSheets
{
    public class EditGradeViewModel
    {
                [Required]
                public Guid? StudentId { get; set; }
                [Required]
        public Guid? UserId { get; set; }
        [Required]
                public string FullName { get; set; }
                [Required]
                public string SubjectCode { get; set; }
                [Required]
                public string SubjectTitle { get; set; }
                [Required]
                public string AcademicYear { get; set; }
                [Required]
                public string Semester { get; set; }
                [Required]
                public decimal GradePercent { get; set; }
                [Required]
                public decimal GradePoint { get; set; }
                [Required]
                public bool IsFailed { get; set; }
                [Required]
                public string Comment { get; set; }
    }
}
