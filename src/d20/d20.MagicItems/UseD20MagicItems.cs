using D20.Core.Models;
using System.Reflection;

namespace D20.MagicItems;

public static class DataServices
{   
    /// <summary>
    /// Get all the IGameable entries
    /// </summary>
    /// <returns></returns>
    private static List<Type> GetGameTables() => Assembly
        .GetExecutingAssembly()
        .GetExportedTypes()
        .Where(t => t.IsSubclassOf(typeof(GameTable)))
        .ToList();

    /// <summary>
    /// The list of game table entries
    /// </summary>
    public static List<Type> MagicItemTables { get; set; } = [];

    public static IServiceCollection UseD20MagicItems(this IServiceCollection collection)
    {
        //collection
        // Add all the game table types as transient
        var list = GetGameTables();
        MagicItemTables.AddRange(list);
        foreach (var table in list)
        {
            var t = collection.AddTransient(table);
        }

        return collection;
    }
}
