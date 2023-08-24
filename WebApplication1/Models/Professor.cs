namespace WebApplication1.Models
{
    public class Professor : BaseEntity 
    {
        public string Name { get; set; }
        public string Family { get; set; }

        public List<Lesson> Lessons { get; set; } 
    }
}
