using Microsoft.Extensions.DependencyInjection;

namespace NetGore.CharacterClasses;

public static class DataServices
{
    public static IServiceCollection UseCharacterClasses(this IServiceCollection collection)
    {
        //collection
            //.AddSingleton<IAccountService, AccountService>()

            // Transient Random Tables
            //.AddTransient<IAdoptedOutsideYourRaceTable, AdoptedOutsideYourRaceTable>()
            ;

        return collection;
    }
}
