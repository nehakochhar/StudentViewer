using StudentViewerWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentViewerWebApp.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Assignment> GetStudentAssignments(int studentId);
        IEnumerable<Enrollment> GetStudentEnrollments(int studentId);
    }
}