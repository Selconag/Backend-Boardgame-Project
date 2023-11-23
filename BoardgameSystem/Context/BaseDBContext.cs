using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Reflection;
using BoardgameSystem.Models;

namespace BoardgameSystem.Context;

public class BaseDbContext : DbContext
{
    public BaseDbContext(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GamesDB;Trusted_Connection=True;MultipleActiveResultSets=true");
    }

    public DbSet<Game> Games { get; set; }
    public DbSet<Developer> Developers { get; set; }

    public DbSet<Artist> Artists { get; set; }

    public DbSet<Publisher> Publishers { get; set; }


}
