using LibraryDatabase.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace MyLibraryDatabase.Configurations;

public class FacultyConfiguration : IEntityTypeConfiguration<Faculty>
{
    public void Configure(EntityTypeBuilder<Faculty> builder)
    {
        builder.HasMany(f => f.Groups)
            .WithOne(g => g.Faculty)
            .HasForeignKey(g => g.Id_Faculty);
    }
}
