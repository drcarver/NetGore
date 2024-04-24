using System.Reflection;

using D20.Core.Interfaces;
using D20.Core.Models;
using D20.Core.Tables;

namespace D20.Core;

public static class DataServices
{
    /// <summary>
    /// Get all the IGameable entries
    /// </summary>
    /// <returns></returns>
    public static List<Type> CoreTables => Assembly
        .GetExecutingAssembly()
        .GetExportedTypes()
        .Where(t => 
                t.IsSubclassOf(typeof(GameTable)) 
            &&  t.Name != nameof(RandomTable)
            &&  t.Name != nameof(NamedTable))
        .ToList();

    /// <summary>
    /// The D20 Core tables and services
    /// </summary>
    /// <param name="collection">The DI service collection</param>
    /// <returns>The services collection</returns>
    public static IServiceCollection UseD20Core(this IServiceCollection collection)
    {
        //collection
        // Add all the game table types as transient
        collection.AddTransient<IAbilityModifierTable, AbilityModifierTable>();
        collection.AddTransient<ISkillTable, SkillTable>();
        collection.AddTransient<IGenderTable, GenderTable>();
        collection.AddTransient<ILanguageTable, LanguageTable>();
        collection.AddTransient<IRandomAlignmentTable, RandomAlignmentTable>();
        collection.AddTransient<ISpellAbilityModifierTable, SpellAbilityModifierTable>();

        return collection;
    }
}
