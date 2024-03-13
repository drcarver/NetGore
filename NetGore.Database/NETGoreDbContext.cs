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
    { }

    public DbSet<Example> Examples { get; set; }
    public DbSet<RandomTable> RandomTables { get; set; }
    public DbSet<RandomTableEntry> RandomTableEntries { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        //builder.Entity<Example>()
        //    .Property(e => e.Name)
        //    .HasColumnType("varchar(512)");

        //builder.Entity<RandomTableEntity>()
        //    .HasKey(e => e.Id);

        //builder.Entity<RandomTableEntity>()
        //    .Property(e => e.Name)
        //    .IsRequired()
        //    .HasComment("")
        //    .HasColumnType("varchar(80)");
    }
}