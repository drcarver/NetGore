using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;

using Microsoft.Extensions.DependencyInjection;

namespace GoDungeon.Core
{
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
        /// The GoDungeon Core tables and services
        /// </summary>
        /// <param name="collection">The DI service collection</param>
        /// <returns>The services collection</returns>
        public static IServiceCollection UseGoDungeonCore(this IServiceCollection collection)
        {
            //collection
            // Add all the game table types as transient
            //collection.AddTransient<IAbilityBase, AbilityBaseViewModel>();
            collection.AddTransient<IAbilityBonusSpellEntry, AbilityBonusSpellEntryViewModel>();
            collection.AddTransient<IAcrobaticsModifiersTableEntry, AcrobaticsModifierViewModel>();
            collection.AddTransient<IAlignmentEntry, AlignmentTableEntryViewModel>();
            collection.AddTransient<IBaseObject, BaseObjectViewModel>();
            collection.AddTransient<ICreature, CreatureViewModel>();
            collection.AddTransient<IDataObject, DataObjectViewModel>();
            collection.AddTransient<IGameTableEntry, GameTableEntryViewModel>();
            collection.AddTransient<IGameTable, GameTable>();
            collection.AddTransient<INamedTableEntry, NamedTableEntryViewModel>();
            collection.AddTransient<IRandomTableEntry, RandomTableEntryViewModel>();
            collection.AddTransient<IRandomTable, RandomTable>();
            //collection.AddTransient<ISavingThrow, SavingThrowViewModel>();
            collection.AddTransient<ISkillTableEntry, SkillTableEntryViewModel>();
            collection.AddTransient<IStandardTableEntry, StandardTableEntryViewModel>();

            // The tables
            collection.AddTransient<IAcrobaticsModifiersTable, AcrobaticsModifierTable>();
            collection.AddTransient<IAlignmentTable, AlignmentTable>();
            collection.AddTransient<IGenderTable, GenderTable>();
            collection.AddTransient<ILanguageTable, LanguageTable>();
            collection.AddTransient<IRandomAlignmentTable, RandomAlignmentTable>();
            collection.AddTransient<ISpellAbilityModifierTable, SpellAbilityModifierTable>();

            return collection;
        }
    }
}
