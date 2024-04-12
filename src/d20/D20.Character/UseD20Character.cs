namespace D20.Character;

public static class DataServices
{
    public static IServiceCollection UseD20Character(this IServiceCollection collection)
    {
        //collection
        //.AddSingleton<IAccountService, AccountService>()

        // Transient Random Tables
        //.AddTransient<IAdoptedOutsideYourRaceTable, AdoptedOutsideYourRaceTable>()
        ;

        return collection;
    }
}
