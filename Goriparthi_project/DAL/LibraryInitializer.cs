using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Goriparthi_project.Models;

namespace Goriparthi_project.DAL
{
    public class LibraryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LibraryContext>
    {
    
       protected override void Seed(LibraryContext context)
        {
            var students = new List<Student>
            {
            new Student{ StudentID=1,FirstMidName = "Vidhya", LastName = "Dokku", IssueDate=DateTime.Parse("2005-09-01")},
            new Student{ StudentID=2,FirstMidName = "manasa", LastName = "goriparthi", IssueDate=DateTime.Parse("2005-09-01")},

            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var book = new List<Book>
            {
            new Book{BookID = 1001, BookName = "Anna Karenina", Author=" Leo Tolstoy"},
            new Book{BookID = 1002, BookName = "Bible", Author=" Jessus"},
            
            };
            book.ForEach(s => context.Books.Add(s));
            context.SaveChanges();
            var Issue = new List<Issue>
            {
            new Issue{StudentID=1,BookID=1001,Grade=Grade.Maintained},
            new Issue{StudentID=2,BookID=1002,Grade=Grade.Maintained},
          
           
            };
            Issue.ForEach(s => context.Issues.Add(s));
            context.SaveChanges();
        }
    }
}