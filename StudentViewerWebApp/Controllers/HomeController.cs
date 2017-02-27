using StudentViewerWebApp.Services;
using System.Web.Mvc;

namespace StudentViewerWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IStudentService studentService;
        public HomeController(IStudentService studentService)
        {
            this.studentService = studentService;
        }
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Student Viewer.";

            return View();
        }
        public JsonResult GetAllStudents()
        {
            var students = studentService.GetAllStudents();
            return Json(students, JsonRequestBehavior.AllowGet);
        }
    }
}