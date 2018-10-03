using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllanNovalta.GradePortal.Web.Areas.Manage.Models;
using AllanNovalta.GradePortal.Web.Areas.Manage.ViewModels.GradeSheets;
using AllanNovalta.GradePortal.Web.Infrastructure.Data.Helpers;
//using AllanNovalta.GradePortal.Web.Areas.Manage.Models.SudentGrade;
using AllanNovalta.GradePortal.Web.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AllanNovalta.GradePortal.Web.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class GradesController : Controller
    {
        private readonly DefaultDbContext _context;

        public GradesController(DefaultDbContext context)
        {
            _context = context;
        }

        [HttpGet, Route("manage/grades/index")]
        [HttpGet, Route("manage/grades")]
        public IActionResult Index(int pageSize = 5, int pageIndex = 1, string subjectCode = "", string academicYear = "", string semester ="")
        {
            Page<StudentGrade> result = new Page<StudentGrade>();
            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Grade> GradeQuery = (IQueryable<Grade>)this._context.Grades;
            if (!string.IsNullOrEmpty(subjectCode) && !string.IsNullOrEmpty(academicYear) && !string.IsNullOrEmpty(semester))
            {
                GradeQuery = GradeQuery.Where(u => u.SubjectCode.ToLower() == subjectCode.ToLower()
                                                && u.AcademicYear.ToLower() == academicYear.ToLower()
                                                && u.Semester.ToLower() == semester.ToLower());


                long queryCount = GradeQuery.Count();
                int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
                long mod = (queryCount % pageSize);
                if (mod > 0)
                {
                    pageCount = pageCount + 1;
                }
                int skip = (int)(pageSize * (pageIndex - 1));
                List<Grade> grades = GradeQuery.ToList();
                List<StudentGrade> gradesheet = new List<StudentGrade>();

                foreach(Grade grade in grades)
                {
                    var student = this._context.Users.FirstOrDefault(u => u.Id == grade.StudentId);

                    gradesheet.Add(new StudentGrade() {
                        AcademicYear = grade.AcademicYear,
                        StudentId = grade.StudentId,
                        FirstName = student.FirstName,
                        LastName = student.LastName,
                    });
                }


                result.Items = gradesheet.Skip(skip).Take((int)pageSize).ToList();
                result.PageCount = pageCount;
                result.PageSize = pageSize;
                result.QueryCount = queryCount;
                result.CurrentPage = pageIndex;

            }

            return View(new IndexViewModel()
            {
                Grades = result
            });


        }

        [HttpGet, Route("manage/grades/Create")]
        public IActionResult Create()
        {
            return View();
        }

        //[HttpGet, Route("manage/grades/create")]
        //public IActionResult _Create()
        //{
        //    return View();
        //}

        [HttpPost, Route("manage/grades/create")]
        public IActionResult Create(EditGradeViewModel model)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("index");
            var grade = this._context.Grades.FirstOrDefault(u => u.FullName.ToLower() == model.FullName.ToLower());
            if (grade == null)
            {
                grade = new Grade()
                {
                    StudentId = model.StudentId,
                    UserId = model.UserId,
                    SubjectTitle = model.SubjectTitle,
                    SubjectCode = model.SubjectCode,
                    AcademicYear = model.AcademicYear,
                    Semester = model.Semester,
                    GradePercent = model.GradePercent,
                    GradePoint = model.GradePoint,
                    IsFailed = model.IsFailed,
                    Comment = model.Comment
                };
                this._context.Grades.Add(grade);
                this._context.SaveChanges();
            }
            return RedirectToAction("grades");
        }
    }
}