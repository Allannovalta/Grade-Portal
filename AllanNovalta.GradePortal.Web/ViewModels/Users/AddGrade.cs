using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllanNovalta.GradePortal.Web.ViewModels.Users
{
    public class AddGrade
    {
        [Required]
        public string SubjectTitle { get; set; }
        [Required]
        public string SubjectCode { get; set; }
        [Required]
        public string AcademicYear { get; set; }
        [Required]
        public string Semester { get; set; }
        [Required]
        public decimal Grade { get; set; }
        [Required]
        public decimal GradePoint { get; set; }
        [Required]
        public string Comment { get; set; }
    }
}
