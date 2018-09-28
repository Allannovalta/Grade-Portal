using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllanNovalta.GradePortal.Web.Areas.Manage.Models
{
    public class StudentGrade
    {
        public Guid? StudentId { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        public string SubjectTitle { get; set; }

        public string SubjectCode { get; set; }

        public string AcademicYear { get; set; }

        public string Semester { get; set; }

        public decimal GradePercent { get; set; }

        public decimal GradePoint { get; set; }

        public bool IsFailed { get; set; }

        public string Comment { get; set; }
    }
}
