using AllanNovalta.GradePortal.Web.Infrastructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllanNovalta.GradePortal.Web.ViewModels.Users
{
    public class UpdateProfileViewModel
    {
        [Required]
        public Guid? UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public Gender Gender { get; set; }
    }
}
