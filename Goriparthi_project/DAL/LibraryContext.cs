using Goriparthi_project.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Goriparthi_project.DAL
{
    public class LibraryContext : DbContext
    {

        public LibraryContext() : base("LibraryContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}