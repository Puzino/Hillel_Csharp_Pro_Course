using Homework12.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homework12.Data.Configuration;

public class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).ValueGeneratedOnAdd();
        builder.Property(u => u.MovieName).HasColumnType("VARCHAR").IsRequired().HasMaxLength(100);
        builder.Property(u => u.Director).HasColumnType("VARCHAR").IsRequired().HasMaxLength(50);
        builder.Property(u => u.Style).HasColumnType("VARCHAR").IsRequired().HasMaxLength(50);
        builder.Property(u => u.Description).HasColumnType("VARCHAR").IsRequired().HasMaxLength(500);

        builder.HasMany(u => u.Sessions)
            .WithOne(ci => ci.Movie)
            .HasForeignKey(ci => ci.MovieId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}