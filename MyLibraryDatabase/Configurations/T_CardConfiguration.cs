using LibraryDatabase.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MyLibraryDatabase.Configurations;
public class T_CardConfiguration : IEntityTypeConfiguration<T_Card>
{
    public void Configure(EntityTypeBuilder<T_Card> builder)
    {
        builder.HasOne(tc => tc.Teacher)
            .WithMany(t => t.T_Cards)
            .HasForeignKey(t => t.Id_Teacher);
    }


}