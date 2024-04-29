using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using GoDungeon.Core.Tables;
using GoDungeon.Spells.Interfaces;
using GoDungeon.Spells.Tables;
using GoDungeon.Spells.Tables.Bard;

using Microsoft.Extensions.DependencyInjection;

namespace GoDungeon.Spells
{
    public static class DataServices
    {
        /// <summary>
        /// Get all the IGameable entries
        /// </summary>
        /// <returns></returns>
        private static List<Type> SpellTables => Assembly
            .GetExecutingAssembly()
            .GetExportedTypes()
            .Where(t => t.IsSubclassOf(typeof(GameTable)))
            .ToList();

        public static IServiceCollection UseGoDungeonSpells(this IServiceCollection collection)
        {
            //collection
            // Add all the game table types as transient
            collection
                .AddTransient<IBardCantripSpellTable, BardCantripSpellTable>()
                .AddTransient<IBardFirstLevelSpellTable, BardFirstLevelSpellTable>()
                .AddTransient<ISpellsBeggingWithATable, SpellsBeggingWithATable>()
                ;

            return collection;
        }
    }
}
