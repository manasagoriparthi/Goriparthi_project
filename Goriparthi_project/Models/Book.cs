using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Goriparthi_project.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }

        public virtual ICollection<Issue> Issue_Details { get; set; }
    }
}