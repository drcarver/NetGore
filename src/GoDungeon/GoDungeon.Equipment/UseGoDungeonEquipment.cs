using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Equipment.Interfaces;
using GoDungeon.Equipment.Tables;

using Microsoft.Extensions.DependencyInjection;

namespace GoDungeon.Equipment
{
    public static class DataServices
    {
        /// <summary>
        /// Get all the IGameable entries
        /// </summary>
        /// <returns></returns>
        private static List<Type> EquipmentTables => Assembly
            .GetExecutingAssembly()
            .GetExportedTypes()
            .Where(t => t.IsSubclassOf(typeof(GameTable)))
            .ToList();

        /// <summary>
        /// The GoDungeon Core tables and services
        /// </summary>
        /// <param name="collection">The DI service collection</param>
        /// <returns>The services collection</returns>
        public static IServiceCollection UseGoDungeonEquipment(this IServiceCollection collection)
        {
            //collection
            // Add all the game table types as transient
            collection
                .AddTransient<IContainerCapacityTable, ContainerCapacityTable>()
                .AddTransient<IStandardExchangeRatesTable, StandardExchangeRatesTable>()
                .AddTransient<IEquipmentTable, EquipmentTable>();

            return collection;
        }
    }
}
