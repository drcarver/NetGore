namespace D20.Monsters;

public static class DataServices
{
    public static IServiceCollection UseD20Monsters(this IServiceCollection collection)
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
