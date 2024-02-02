using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using LibraryDatabase.Entities;

namespace MyLibraryDatabase.Configurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasMany(g => g.Students)
            .WithOne(s => s.Group)
            .HasForeignKey(s => s.Id_Group);
    }
}