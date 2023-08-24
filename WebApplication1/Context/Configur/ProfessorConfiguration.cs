using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Context.Configur
{
    public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.Property(p => p.Name).HasColumnType("nvarchar(25)");
            builder.Property(p => p.Family).HasColumnType("nvarchar(25)");
        }
    }
}
