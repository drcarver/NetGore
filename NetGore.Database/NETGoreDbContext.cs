using System.Reflection.Emit;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using NetGore.Core.Models;
using NetGore.Database.EntityConfigurations;
using NetGore.Models;

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
}