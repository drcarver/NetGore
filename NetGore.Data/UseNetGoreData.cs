using Microsoft.Extensions.DependencyInjection;

using NetGore.Core.Interfaces;
using NetGore.Core.Models;
using NetGore.Data.Background;
using NetGore.Data.Interfaces;
using NetGore.Data.Services;

namespace NetGore.Data;

public static class DataServices
{
    public static IServiceCollection UseNetGoreData(this IServiceCollection collection)
    {
        collection
            .AddDbContext<NETGoreDbContext>()
            .AddSingleton<IRaceService, RaceService>()
            .AddSingleton<ICharacterService, CharacterService>()
            .AddSingleton<IClassService, ClassService>()
            .AddSingleton<IPlayerCharacter, PlayerCharacter>()
            .AddSingleton<IAccountService, AccountService>()

            // Random Tables
            .AddSingleton<ICharacterAdvancement, CharacterAdvancementTable>()
            .AddSingleton<ICircumstanceofBirthTable, CircumstanceofBirthTable>()
            .AddSingleton<ICrimeTable, CrimeTable>()
            .AddSingleton<ILanguageTable, LanguageTable>()
            .AddSingleton<INobilityTable, NobilityTable>()
            .AddSingleton<IProfessionTable, ProfessionTable>()
            .AddSingleton<IRaceTable, RaceTable>()
            ;

        return collection;
    }
}
