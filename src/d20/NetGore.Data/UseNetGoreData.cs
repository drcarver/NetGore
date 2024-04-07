using System.Diagnostics;

using Microsoft.Extensions.DependencyInjection;

using NetGore.Core.Data;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;
using NetGore.Data.Interfaces;
using NetGore.Data.Models;
using NetGore.Data.Services;

namespace NetGore.Data;

public static class DataServices
{
    public static List<Type> FindSubClassesOf<TBaseType>()
    {
        var baseType = typeof(TBaseType);
        var assembly = baseType.Assembly;

        return assembly.GetTypes().Where(t => t.IsSubclassOf(baseType)).ToList();
    }

    public static IServiceCollection UseNetGoreData(this IServiceCollection collection)
    {
        collection
            .AddDbContext<NETGoreDbContext>()
            .AddSingleton<IRaceService, RaceService>()
            .AddSingleton<ICharacterService, CharacterService>()
            .AddSingleton<IClassService, ClassService>()
            .AddSingleton<IPlayerCharacter, PlayerCharacter>()
            .AddSingleton<IAccountService, AccountService>();
        
         // Add all the game table types as transient
        foreach (var table in FindSubClassesOf<GameTable>())
        {
            var t = collection.AddTransient(table);
        }
        return collection;
    }
}
