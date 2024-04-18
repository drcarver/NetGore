using D20.Core.Models;

using System.Reflection;

namespace D20.Gaming;

public static class DataServices
{
    /// <summary>
    /// Get all the IGameable entries
    /// </summary>
    /// <returns></returns>
    private static List<Type> GetGameTables() => Assembly
        .GetExecutingAssembly()
        .GetExportedTypes()
        .Where(t => t.IsSubclassOf(typeof(NamedTable)))
        .ToList();

    /// <summary>
    /// The list of game table entries
    /// </summary>
    public static List<Type> GamingTables { get; set; } = [];

    /// <summary>
    /// Add services to collection
    /// </summary>
    /// <param name="collection">The service collection</param>
    /// <returns>The updated service collection</returns>
    public static IServiceCollection UseD20Gaming(this IServiceCollection collection)
    {
        //collection
        // Add all the game table types as transient
        var list = GetGameTables();
        GamingTables.AddRange(list);
        foreach (var table in list)
        {
            var t = collection.AddTransient(table);
        }

        return collection;
    }
}
