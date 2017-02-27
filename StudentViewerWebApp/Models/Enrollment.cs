using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentViewerWebApp.Models
{
    public class Enrollment
    {
        public DateTime EntryDate { get; set; }
        public DateTime ExitDate { get; set; }
        public string ExitReason { get; set; }
    }
}