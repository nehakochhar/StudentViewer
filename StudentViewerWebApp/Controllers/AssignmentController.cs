using StudentViewerWebApp.Services;
using System.Web.Mvc;

namespace StudentViewerWebApp.Controllers
{
    public class AssignmentController : Controller
    {
        private IStudentService studentService;
        public AssignmentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }
        // GET: Assignment
        public ActionResult Index(int studentId)
        {
            return View(studentId);
        }

        public JsonResult GetStudentAssignments(int studentId)
        {
            var assignments = studentService.GetStudentAssignments(studentId);
            return Json(assignments, JsonRequestBehavior.AllowGet);
        }
    }
}