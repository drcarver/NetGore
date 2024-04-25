using Microsoft.Extensions.DependencyInjection;

namespace NetGore.Data;

public static class DataServices
{
    public static List<Type> FindSubClassesOf<GameTable>()
    {
        var baseType = typeof(GameTable);
        var assembly = baseType.Assembly;

        return assembly.GetTypes().Where(t => t.IsSubclassOf(baseType)).ToList();
    }

    public static IServiceCollection UseD20Data(this IServiceCollection collection)
    {
        collection
            .AddDbContext<NETGoreDbContext>();
            //.AddSingleton<IRaceService, RaceService>()
            //.AddSingleton<ICharacterService, CharacterService>()
            //.AddSingleton<IClassService, ClassService>()
            //.AddSingleton<IPlayerCharacter, PlayerCharacter>()
            //    .AddSingleton<IAccountService, AccountService>();

        ////collection
        //// Add all the game table types as transient
        //var list = Core.DataServices.GetGameTables();
        //foreach (var table in list)
        //{
        //    if (table.Name != nameof(RandomTable))
        //    {
        //        var t = collection.AddTransient(table);
        //    }
        //}

        //GameTables.AddRange(list.Cast<IGameTable>());
        return collection;
    }
}
