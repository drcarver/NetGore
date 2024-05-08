using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using GoDungeon.Character.Interfaces;
using GoDungeon.Character.PC.Barbarian;
using GoDungeon.Character.PC.Bard;
using GoDungeon.Character.PC.Cleric;
using GoDungeon.Character.PC.Druid;
using GoDungeon.Character.Tables;
using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

using Microsoft.Extensions.DependencyInjection;

namespace GoDungeon.Character
{
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
        /// The GoDungeon Character tables and services
        /// </summary>
        /// <param name="collection">The DI service collection</param>
        /// <returns>The services collection</returns>
        public static IServiceCollection UseGoDungeonCharacter(this IServiceCollection collection)
        {
            //collection
            // Add all the game table types as transient
            collection.AddTransient<ICelticDeitiesTable, CelticDeitiesTable>();
            collection.AddTransient<ICharacterAdvancementTable, CharacterAdvancementTable>();
            collection.AddTransient<IClassFeatureTable, ClassFeatureTable>();
            collection.AddTransient<ICharacter, CharacterViewModel>();

            // Now add the Barbarian Class
            collection.AddTransient<IBarbarian, BarbarianViewModel>();
            collection.AddTransient<IBarbarianBackgroundTable, BarbarianBackgroundTable>();
            collection.AddTransient<IBarbarianLevelTable, BarbarianLevelTable>();

            // Now add the Bard Class
            collection.AddTransient<IBard, BardViewModel>();
            collection.AddTransient<IBardBackgroundTable, BardBackgroundTable>();
            collection.AddTransient<IBardLevelTable, BardLevelTable>();

            // Now add the Cleric Class
            collection.AddTransient<ICleric, ClericViewModel>();
            collection.AddTransient<IClericBackgroundTable, ClericBackgroundTable>();
            collection.AddTransient<IClericLevelTable, ClericLevelTable>();

            // Now add the Druid Class
            collection.AddTransient<IDruid, DruidViewModel>();
            collection.AddTransient<IDruidBackgroundTable, DruidBackgroundTable>();
            collection.AddTransient<IDruidLevelTable, DruidLevelTable>();

            return collection;
        }
    }
}
