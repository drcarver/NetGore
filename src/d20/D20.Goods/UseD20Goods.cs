namespace D20.Character;

public static class DataServices
{
    /// <summary>
    /// The D20 Core tables and services
    /// </summary>
    /// <param name="collection">The DI service collection</param>
    /// <returns>The services collection</returns>
    public static IServiceCollection UseD20Goods(this IServiceCollection collection)
    {
        //collection
        // Add all the game table types as transient
        var list = Core.DataServices.GetGameTables();
        foreach (var table in list)
        {
            var t = collection.AddTransient(table);
        }

        return collection;
    }
}
