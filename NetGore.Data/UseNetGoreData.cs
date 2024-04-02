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

            // Transient Random Tables
            .AddTransient<IAdoptedOutsideYourRaceTable, AdoptedOutsideYourRaceTable>()
            .AddTransient<IAlignmentTable, AlignmentTable>()
            .AddTransient<ICharacterAdvancement, CharacterAdvancementTable>()
            .AddTransient<ICircumstanceofBirthTable, CircumstanceofBirthTable>()
            .AddTransient<ICrimeTable, CrimeTable>()
            .AddTransient<ILanguageTable, LanguageTable>()
            .AddTransient<INobilityTable, NobilityTable>()
            .AddTransient<IProfessionTable, ProfessionTable>()
            .AddTransient<IRaceTable, RaceTable>()
            ;

        return collection;
    }
}
