using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentViewerWebApp.Models
{
    public class Assignment
    {
        public string AssignmentName { get; set; }
        public DateTime DueDate { get; set; }
        public int MaxScore { get; set; }
        public DateTime? CompletionDate { get; set; }
        public int ScoreEarned { get; set; }
    }
}