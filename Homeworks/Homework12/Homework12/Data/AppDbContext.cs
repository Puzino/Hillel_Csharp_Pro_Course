using Homework12.Models;
using Microsoft.EntityFrameworkCore;

namespace Homework12.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; }

    public DbSet<Session> Sessions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppContext).Assembly);
        new DbInitializer(modelBuilder).Seed();
    }
}