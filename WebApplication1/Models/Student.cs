namespace WebApplication1.Models
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public List<Lesson> Lessons { get; set; }

        public int? AddressId { get; set; }
        public Address? Address { get; set; }

        public int? StateId { get; set; }
        public State? State { get; set; }
    }
}
