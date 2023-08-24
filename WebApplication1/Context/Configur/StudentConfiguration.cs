using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Context.Configur
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasOne(p => p.Address).WithOne(p => p.Student).HasForeignKey<Student>(p => p.AddressId).OnDelete(DeleteBehavior.Cascade);
            builder.Property(p => p.Name).HasColumnType("nvarchar(25)");
            builder.Property(p => p.Family).HasColumnType("nvarchar(25)");
        }
    }
}
