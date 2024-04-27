using System.Reflection;

using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Character.PC.Barbarian;
using D20.Character.PC.Bard;
using D20.Character.PC.Cleric;
using D20.Character.PC.Druid;
using D20.Character.Tables;
using D20.Core.Models;

using GoDungeon.Character.Interfaces;

namespace D20.Character;

public static class DataServices
{
    /// <summary>
    /// Get all the IGameable entries
    /// </summary>
    /// <returns></returns>
    public static List<Type> CharacterTables => Assembly
        .GetExecutingAssembly()
        .GetExportedTypes()
        .Where(t => 
                t.IsSubclassOf(typeof(GameTable)) 
            &&  t.Name != nameof(DeitiesTable))
        .ToList();

    /// <summary>
    /// The D20 Character tables and services
    /// </summary>
    /// <param name="collection">The DI service collection</param>
    /// <returns>The services collection</returns>
    public static IServiceCollection UseD20Character(this IServiceCollection collection)
    {
        //collection
        // Add all the game table types as transient
        collection.AddTransient<ICelticDeitiesTable, CelticDeitiesTable>();
        collection.AddTransient<ICharacterAdvancementTable, CharacterAdvancementTable>();
        collection.AddTransient<IClassFeatureTable, ClassFeatureTable>();

        // Now add the Barbarian Class
        collection.AddTransient<IBarbarian, Barbarian>();
        collection.AddTransient<IBarbarianBackgroundTable, BarbarianBackgroundTable>();
        collection.AddTransient<IBarbarianLevelTable, BarbarianLevelTable>();

        // Now add the Bard Class
        collection.AddTransient<IBard, Bard>();
        collection.AddTransient<IBardBackgroundTable, BardBackgroundTable>();
        collection.AddTransient<IBardLevelTable, BardLevelTable>();

        // Now add the Cleric Class
        collection.AddTransient<ICleric, Cleric>();
        collection.AddTransient<IClericBackgroundTable, ClericBackgroundTable>();
        collection.AddTransient<IClericLevelTable, ClericLevelTable>();

        // Now add the Druid Class
        collection.AddTransient<IDruid, Druid>();
        collection.AddTransient<IDruidBackgroundTable, DruidBackgroundTable>();
        collection.AddTransient<IDruidLevelTable, DruidLevelTable>();

        return collection;
    }
}
