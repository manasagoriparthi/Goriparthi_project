namespace Goriparthi_project.Models
{
    public enum Grade
    {
        Maintained,Not_Maintained
    }

    public class Issue
    {
        public int IssueID { get; set; }
        public int BookID { get; set; }
        public int StudentID { get; set; }
        

        public virtual Book Book { get; set; }
        public virtual Student Student { get; set; }
        public Grade Grade { get; internal set; }
    }
}