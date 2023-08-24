namespace WebApplication1.Models
{
    public class State : BaseEntity
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
