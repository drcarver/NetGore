using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using GoDungeon.Core.Tables;
using GoDungeon.RandomDungeon.Interfaces;
using GoDungeon.RandomDungeon.Tables;
using GoDungeon.RandomDungeon.ViewModels;

using Microsoft.Extensions.DependencyInjection;

namespace GoDungeon.RandomDungeon
{
    public static class DataServices
    {
        /// <summary>
        /// Get all the IGameable entries
        /// </summary>
        /// <returns></returns>
        public static List<Type> DungeonMapTables => Assembly
            .GetExecutingAssembly()
            .GetExportedTypes()
            .Where(t =>
                    t.IsSubclassOf(typeof(GameTable))
                && t.Name != nameof(RandomTable)
                && t.Name != nameof(NamedTable))
            .ToList();

        /// <summary>
        /// The GoDungeon Core tables and services
        /// </summary>
        /// <param name="collection">The DI service collection</param>
        /// <returns>The services collection</returns>
        public static IServiceCollection UseGoDungeonRandomDungeon(this IServiceCollection collection)
        {
            //collection
            // Add all the game table types as transient
            collection
                // View Models
                .AddTransient<IRandomDungeon, RandomDungeonViewModel>()
                .AddTransient<IRandomDungeonModel, RandomDungeonModel>()

                // The tables
                .AddSingleton<IBeyondADoorTable, BeyondADoorTable>()
                .AddSingleton<IChamberExitTable, ChamberExitTable>()
                .AddSingleton<IChamberTable, ChamberTable>()
                .AddSingleton<IDoorTypeTable, DoorTypeTable>()
                .AddSingleton<IDungeonHistoryTable, DungeonHistoryTable>()
                .AddSingleton<IDungeonPurposeTable, DungeonPurposeTable>()
                .AddSingleton<IExitLocationTable, ExitLocationTable>()
                .AddSingleton<IExitTypeTable, ExitTypeTable>()
                .AddSingleton<IFormOfGovernmentTable, FormOfGovernmentTable>()
                .AddSingleton<ILeaderTypeTable, LeaderTypeTable>()
                .AddSingleton<IMonumentsTable, MonumentsTable>()
                .AddSingleton<IPassageTable, PassageTable>()
                .AddSingleton<IPassageWidthTable, PassageWidthTable>()
                .AddSingleton<IPrecipitationTable, PrecipitationTable>()
                .AddSingleton<IRaceRelationsTable, RaceRelationsTable>()
                .AddSingleton<ISettlementsTable, SettlementTable>()
                .AddSingleton<IStairsTable, StairsTable>()
                .AddSingleton<IStartingAreaTable, StartingAreaTable>()
                .AddSingleton<ITemperatureTable, TemperatureTable>()
                .AddSingleton<IWeirdLocalesTable, WeirdLocalesTable>()
                .AddSingleton<IWindTable, WindTable>()
                .AddSingleton<IWorldShakingEventsTable, WorldShakingEventsTable>()
                ;

            return collection;
        }
    }
}
