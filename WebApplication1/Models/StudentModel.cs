namespace WebApplication1.Models
{
    public class StudentModel:BaseEntity
    {
        public string FullName { get; set; }
        public string Addresse { get; set; }
        public List<string> Professors { get; set; }
        public List<string> Lessons { get; set; }

    }
}
