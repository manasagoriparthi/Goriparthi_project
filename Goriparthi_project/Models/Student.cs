using System;
using System.Collections.Generic;

namespace Goriparthi_project.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime IssueDate { get; set; }

        public virtual ICollection<Issue> Enrollments { get; set; }
        public int StudentID { get; internal set; }
    }
}