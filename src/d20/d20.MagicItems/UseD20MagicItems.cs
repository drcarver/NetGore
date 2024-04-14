namespace d20.MagicItems;

public static class DataServices
{
    public static IServiceCollection UseD20MagicItems(this IServiceCollection collection)
    {
        //collection
        // Add all the game table types as transient
        var list = D20.Core.DataServices.GetGameTables();
        foreach (var table in list)
        {
            var t = collection.AddTransient(table);
        }

        return collection;
    }
}
