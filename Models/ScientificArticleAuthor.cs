namespace ScientificArticleManagerWPF.Models
{
    public class ScientificArticleAuthor
    {
        public ScientificArticleAuthor(string firstName, string lastName, string affiliation, string academicDegree)
        {
            FirstName = firstName;
            LastName = lastName;
            Affiliation = affiliation;
            AcademicDegree = academicDegree;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Affiliation { get; set; }
        public string AcademicDegree { get; set; }
    }
}