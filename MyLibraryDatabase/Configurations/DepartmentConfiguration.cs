using LibraryDatabase.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace MyLibraryDatabase.Configurations;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.HasMany(d => d.Teachers)
            .WithOne(t => t.Department)
            .HasForeignKey(t => t.Id_Dep);
    }
}
