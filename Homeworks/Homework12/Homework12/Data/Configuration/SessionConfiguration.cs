using Homework12.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homework12.Data.Configuration;

public class SessionConfiguration : IEntityTypeConfiguration<Session>
{
    public void Configure(EntityTypeBuilder<Session> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Id).ValueGeneratedOnAdd();
        builder.Property(s => s.Room).HasColumnType("INT").IsRequired();
        builder.Property(s => s.Price).HasColumnType("decimal(6,2)").IsRequired();
        builder.Property(s => s.DateTime).IsRequired();
        
        builder.HasOne(s => s.Movie)
            .WithMany(m => m.Sessions)
            .HasForeignKey(s => s.MovieId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();
    }
}