using Microsoft.AspNetCore.Mvc;
using Student_Info.Data;
using Student_Info.Models;

namespace Student_Info.Controllers
{
    public class StudentInfoController : Controller
    {
        private readonly StudentEntities db;

        public StudentInfoController(StudentEntities _db)
        {
            db = _db;
        }
        public IActionResult Get()
        {
            var result = db.Students.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            var ClassDetails = db.ClassInfos.ToList();
            return View(ClassDetails);
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            db.Students.Add(new Student()
            {
                Id = Guid.NewGuid(),
                Name = student.Name,
                DOB = student.DOB,
                Gender = student.Gender,
                ClassId = student.ClassId,
                CreateDate = DateTime.Now,
                ModificationDate = DateTime.Now.AddDays(1),
            });
            if (db.SaveChanges() > 0)
            {
                return RedirectToAction("Get");
            }
            TempData["msg"] = "Value not added";
            return View();
        }
        [HttpGet]
        public IActionResult Details(Guid id)
        {
            var info = db.Students.SingleOrDefault(x => x.Id == id);
            return View(info);
        }
        public IActionResult Delete(Guid id)
        {
            var student = db.Students.SingleOrDefault(x => x.Id == id);

            if (student != null)
            {
                db.Students.Remove(student); 
                if (db.SaveChanges() > 0)
                {
                    return RedirectToAction("Get");
                }
            }
            TempData["msg"] = "Value not deleted";
            return View();
        }
    }
}
