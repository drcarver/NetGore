using System.Reflection;

using D20.Background.Interfaces;
using D20.Background.Tables.Halfling;
using D20.Background.Tables;
using D20.Character.Tables;
using D20.Core.Models;
using D20.Monsters.Interfaces;
using D20.Monsters.Models;
using D20.Monsters.Models.Humanoid;
using D20.Monsters.Race;

using Microsoft.VisualBasic;

namespace D20.Monsters;

public static class DataServices
{
    /// <summary>
    /// Get all the IGameable entries
    /// </summary>
    /// <returns></returns>
    private static List<Type> GetGameTables() => Assembly
        .GetExecutingAssembly()
        .GetExportedTypes()
        .Where(t => t.IsSubclassOf(typeof(GameTable)))
        .ToList();

    /// <summary>
    /// The list of game table entries
    /// </summary>
    public static List<Type> MonsterTables { get; set; } = [];

    public static IServiceCollection UseD20Monsters(this IServiceCollection collection)
    {
        //collection
        collection.AddTransient<IHumanoidRaceTable, HumanoidRaceTable>();
        collection.AddTransient<IHalfling, Halfling>();
        collection.AddTransient<IHalflingHomelandTable, HalflingHomelandTable>();
        collection.AddTransient<IHalflingParentsTable, HalflingParentsTable>();
        collection.AddTransient<IUnusualHomelandTable, UnusualHomelandTable>();
        collection.AddTransient<ICircumstanceofBirthTable, CircumstanceofBirthTable>();
        collection.AddTransient<IProfessionTable, ProfessionTable>();
        collection.AddTransient<INobilityTable, NobilityTable>();
        collection.AddTransient<IAdoptedOutsideYourRaceTable, AdoptedOutsideYourRaceTable>();
        collection.AddSingleton<IHumanoidRaceFactory, HumanoidRaceFactory>();
 
        //// Add all the humanoid races
        //foreach (RaceEnum race in Enum.GetValues(typeof(RaceEnum)).Cast<RaceEnum>())
        //{
        //    collection.AddKeyedTransient<IHumanoidRace, HumanoidRace>(race.ToString());
        //}

        return collection;
    }
}
