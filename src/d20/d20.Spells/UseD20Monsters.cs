namespace d20.Spells;

public static class DataServices
{
    public static IServiceCollection UseD20Spells(this IServiceCollection collection)
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
