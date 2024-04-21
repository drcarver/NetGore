using System.Reflection;

using D20.Character.Models;
using D20.Character.PC.Barbarian;
using D20.Character.PC.Bard;
using D20.Core.Interfaces;
using D20.Core.Models;

namespace D20.Character;

public static class DataServices
{
    /// <summary>
    /// Get all the IGameable entries
    /// </summary>
    /// <returns></returns>
    private static List<Type> GetGameTables() => Assembly
        .GetExecutingAssembly()
        .GetExportedTypes()
        .Where(t => t.IsSubclassOf(typeof(NamedTable)) && t.Name != nameof(DeitiesTable))
        .ToList();

    /// <summary>
    /// The list of game table entries
    /// </summary>
    public static List<Type> CharacterTables { get; set; } = [];

    /// <summary>
    /// The D20 Character tables and services
    /// </summary>
    /// <param name="collection">The DI service collection</param>
    /// <returns>The services collection</returns>
    public static IServiceCollection UseD20Character(this IServiceCollection collection)
    {
        //collection
        // Add all the game table types as transient
        var list = GetGameTables();
        CharacterTables.AddRange(list);
        foreach (var table in list)
        {
            if (table.Name != nameof(DeitiesTable))
            {
                var t = collection.AddTransient(table);
            }
        }

        // Now add the PC Classes
        collection.AddTransient<IBarbarian, Barbarian>();
        collection.AddTransient<IBard, Bard>();

        return collection;
    }
}
