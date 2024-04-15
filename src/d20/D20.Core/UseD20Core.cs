using System.Reflection;

using D20.Core.Interfaces;
using D20.Core.Models;

namespace D20.Core;

public static class DataServices
{
    /// <summary>
    /// Get all the IGameable entries
    /// </summary>
    /// <returns></returns>
    private static List<Type> GetGameTables() => Assembly
        .GetExecutingAssembly()
        .GetExportedTypes()
        .Where(t => t.IsSubclassOf(typeof(GameTable)) && t.Name != nameof(RandomTable))
        .ToList();

    /// <summary>
    /// The list of game table entries
    /// </summary>
    public static List<Type> CoreTables { get; set; } = [];

    /// <summary>
    /// The D20 Core tables and services
    /// </summary>
    /// <param name="collection">The DI service collection</param>
    /// <returns>The services collection</returns>
    public static IServiceCollection UseD20Core(this IServiceCollection collection)
    {
        //collection
        // Add all the game table types as transient
        var list = GetGameTables();
        CoreTables.AddRange(list);
        foreach (var table in list)
        {
            if (table.Name != nameof(RandomTable)
                || table.Name != nameof(GameTable))
            {
                var t = collection.AddTransient(table);
            }
        }

        return collection;
    }
}
