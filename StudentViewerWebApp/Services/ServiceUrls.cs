using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentViewerWebApp.Controllers.Services
{
    public static class ServiceUrls
    {
        public const string GetAllStudents = "/api/Student/All";
        public const string GetStudentEnrollmentHistory = "/api/Student/EnrollmentHistory";
        public const string GetStudentAssignmentHistory = "/api/Student/AssignmentHistory";
    }
}