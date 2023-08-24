using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Context.Configur
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(p => p.City).HasColumnType("nvarchar(25)");
            builder.Property(p => p.Street).HasColumnType("nvarchar(25)");
            builder.HasOne(p => p.Student).WithOne(p => p.Address).HasForeignKey<Address>(p => p.StudentId);
        }
    }
}
