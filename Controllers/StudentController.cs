using Microsoft.AspNetCore.Mvc;

using crudoperations.Services;
using crudoperations.Models;

namespace crudoperations.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult AddStudent()
        {
            return View(StudentService.GetAll());
        }
        [HttpPost]
        public IActionResult AddStudent(StudentModel model)
        {
            StudentService.Add(model);
            return View(StudentService.GetAll());
        }
        public IActionResult DeleteRecord(int id)
        {
            StudentService.Delete(id);
            return RedirectToAction(nameof(AddStudent));
        }
        public IActionResult Update(int id)
        {
            return View(StudentService.GetbyId(id));
        }
        [HttpPost]
        public IActionResult UpdateRecord(StudentModel tempmodel)
        {
            StudentService.Update(tempmodel);
            return RedirectToAction(nameof(AddStudent));
        }
    }
}
