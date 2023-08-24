namespace WebApplication1.Models
{
    public class Address : BaseEntity
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
