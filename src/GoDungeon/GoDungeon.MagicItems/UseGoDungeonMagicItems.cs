using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using GoDungeon.Core.Tables;

using Microsoft.Extensions.DependencyInjection;

namespace GoDungeon.MagicItems
{
    public static class DataServices
    {
        /// <summary>
        /// Get all the IGameable entries
        /// </summary>
        /// <returns></returns>
        private static List<Type> MagicItemTables => Assembly
            .GetExecutingAssembly()
            .GetExportedTypes()
            .Where(t => t.IsSubclassOf(typeof(GameTable)))
            .ToList();

        public static IServiceCollection UseGoDungeonMagicItems(this IServiceCollection collection)
        {
            //collection
            // Add all the game table types as transient

            return collection;
        }
    }
}
