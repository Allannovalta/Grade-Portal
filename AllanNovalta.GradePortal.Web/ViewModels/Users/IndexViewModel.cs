using AllanNovalta.GradePortal.Web.Infrastructure.Data.Helpers;
using AllanNovalta.GradePortal.Web.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllanNovalta.GradePortal.Web.ViewModels.Users
{
    public class IndexViewModel
    {
        public Page<User> Users { get; set; }
    }
}
