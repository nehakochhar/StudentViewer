using StudentViewerWebApp.Services;
using System.Web.Mvc;

namespace StudentViewerWebApp.Controllers
{
    public class EnrollmentController : Controller
    {
        private IStudentService studentService;
        public EnrollmentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }
        public ActionResult Index(int studentId)
        {
            return View(studentId);
        }

        public JsonResult GetStudentEnrollments(int studentId)
        {
            var enrollments = studentService.GetStudentEnrollments(studentId);
            return Json(enrollments, JsonRequestBehavior.AllowGet);
        }
    }
}