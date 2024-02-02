using LibraryDatabase.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MyLibraryDatabase.Configurations;

public class LibConfiguration : IEntityTypeConfiguration<Lib>
{
    public void Configure(EntityTypeBuilder<Lib> builder)
    {
        builder.HasMany(l => l.S_Cards)
            .WithOne(s => s.Lib)
            .HasForeignKey(s => s.Id_Lib);

        builder.HasMany(l => l.T_Cards)
            .WithOne(t => t.Lib)
            .HasForeignKey(t => t.Id_Lib);
    }
}