using StudentViewerWebApp.Controllers.Services;
using StudentViewerWebApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

namespace StudentViewerWebApp.Services
{
    public class StudentService : IStudentService
    {
        public IEnumerable<Student> GetAllStudents()
        {
            var url = ServiceUrls.GetAllStudents;
            var result = Get<Student>(url);
            return result;
        }

        public IEnumerable<Assignment> GetStudentAssignments(int studentId)
        {
            var url = ServiceUrls.GetStudentAssignmentHistory + "?studentId=" + studentId;
            var result = Get<Assignment>(url);
            return result;
        }

        public IEnumerable<Enrollment> GetStudentEnrollments(int studentId)
        {
            var url = ServiceUrls.GetStudentEnrollmentHistory + "?studentId=" + studentId;
            var result = Get<Enrollment>(url);
            return result;
        }

        #region private methods

        private string studentViewerUsername = ConfigurationManager.AppSettings["StudentViewerUserName"];
        private string studentViewerPassword = ConfigurationManager.AppSettings["StudentViewerPassword"];
        private IEnumerable<T> Get<T>(string url) where T : class
        {
            var byteArray = Encoding.ASCII.GetBytes(string.Format("{0}:{1}", studentViewerUsername, studentViewerPassword));

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                httpClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["StudentViewerBaseApiUrl"]);
                var response = httpClient.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();

                IEnumerable<T> obj = response.Content.ReadAsAsync<IEnumerable<T>>().Result;
                return obj;
            }
        }

        #endregion

    }
}