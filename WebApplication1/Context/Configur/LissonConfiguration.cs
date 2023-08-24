using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Context.Configur
{
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.Property(p => p.Tittle).HasColumnType("nvarchar(25)");
            builder.Property(p => p.Course).HasColumnType("nvarchar(25)");

        }
    }
}
