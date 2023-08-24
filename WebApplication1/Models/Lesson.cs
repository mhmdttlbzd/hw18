namespace WebApplication1.Models
{
    public class Lesson : BaseEntity
    {
        public string Tittle { get; set; }
        public string Course { get; set; } 
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public List<Student> Students { get; set; }

    }
}
