using D20.Core.Models;

using System.Reflection;

namespace D20.Goods;

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
    public static List<Type> GoodsTables { get; set; } = [];

    /// <summary>
    /// The D20 Core tables and services
    /// </summary>
    /// <param name="collection">The DI service collection</param>
    /// <returns>The services collection</returns>
    public static IServiceCollection UseD20Goods(this IServiceCollection collection)
    {
        //collection
        // Add all the game table types as transient
        var list = GetGameTables();
        GoodsTables.AddRange(list);
        foreach (var table in list)
        {
            var t = collection.AddTransient(table);
        }

        return collection;
    }
}
