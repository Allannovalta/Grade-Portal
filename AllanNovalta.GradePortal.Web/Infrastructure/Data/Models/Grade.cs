using AllanNovalta.GradePortal.Web.Infrastructure.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllanNovalta.GradePortal.Web.Infrastructure.Data.Models
{
    public class Grade: BaseModel
    {
        public Guid? StudentId { get; set; }

        public Guid? UserId { get; set; }

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
