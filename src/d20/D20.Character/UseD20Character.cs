using D20.Character.Models;

namespace D20.Character;

public static class DataServices
{

    /// <summary>
    /// The D20 Character tables and services
    /// </summary>
    /// <param name="collection">The DI service collection</param>
    /// <returns>The services collection</returns>
    public static IServiceCollection UseD20Character(this IServiceCollection collection)
    {
        //collection
        // Add all the game table types as transient
        var list = Core.DataServices.GetGameTables();
        foreach (var table in list)
        {
            if (table.Name != nameof(DeitiesTable))
            {
                var t = collection.AddTransient(table);
            }
        }

        return collection;
    }
}
