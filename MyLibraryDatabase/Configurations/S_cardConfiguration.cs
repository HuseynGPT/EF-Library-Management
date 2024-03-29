﻿using LibraryDatabase.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MyLibraryDatabase.Configurations;

public class S_CardConfiguration : IEntityTypeConfiguration<S_Card>
{
    public void Configure(EntityTypeBuilder<S_Card> builder)
    {
        builder.HasOne(sc => sc.Student)
            .WithMany(s => s.S_Cards)
            .HasForeignKey(s => s.Id_Student);
    }
}