using Microsoft.EntityFrameworkCore;

using NetGore.Core.Models;

namespace NetGore.Database;

/// <summary>
/// Entity framework context
/// </summary>
public class NETGoreDbContext : DbContext
{
    public NETGoreDbContext(DbContextOptions<NETGoreDbContext> options)
        : base(options)
    {
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //     => optionsBuilder
    //        .UseSqlite($@"Server={DatabaseConstants.DatabasePath}");

    public DbSet<Example> Examples { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<RandomTable> RandomTables { get; set; }
    public DbSet<RandomTableEntry> RandomTableEntries { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(typeof(AccountBan).Assembly);
    }

    public override int SaveChanges()
    {
        var changedEntriesCopy = ChangeTracker.Entries()
                    .Where( e => e.State == EntityState.Added ||
                            e.State == EntityState.Modified ||
                            e.State == EntityState.Deleted)
                    .ToList();
        var saveTime = DateTime.UtcNow;

        foreach (var entityEntry in changedEntriesCopy)
        {
            if (entityEntry.Metadata.FindProperty("CreatedAt") != null 
                && entityEntry.Property("CreatedAt").CurrentValue == null)
            {
                entityEntry.Property("CreatedAt").CurrentValue = saveTime;
            }

            if (entityEntry.Metadata.FindProperty("UpdatedAt") != null)
            {
                entityEntry.Property("UpdatedAt").CurrentValue = saveTime;
            }

            if (entityEntry.Metadata.FindProperty("IsDeleted") != null
                && entityEntry.State == EntityState.Deleted)
            {
                entityEntry.Property("IsDeleted").CurrentValue = true;
            }
        }
        return base.SaveChanges();
    }
}