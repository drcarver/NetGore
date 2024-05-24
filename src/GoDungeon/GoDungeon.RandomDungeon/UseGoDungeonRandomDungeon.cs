using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.RandomDungeon.Interfaces;
using GoDungeon.RandomDungeon.Models;
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

                //LOCATION - BASED ADVENTURES
                //Adventures set in crumbling dungeons and remote
                //wilderness locations are the cornerstone of countless
                //campaigns. Many of the greatest D&D adventures of all
                //time are location-based.
                //Creating a location-based adventure can be broken
                //down into a number of steps. Each step provides tables
                //from which you can select the basic elements of your
                //adventure. Alternatively, roll on the tables and see how
                //the random results inspire you. You can mix up the
                //order of the steps. 
                .AddSingleton<IDungeonGoalsTable, DungeonGoalsTable>()
                .AddSingleton<IAdventureVillainsTable, AdventureVillainsTable>()
                .AddSingleton<IWildernessGoalsTable, WildernessGoalsTable>()
                .AddSingleton<IMonumentsTable, MonumentsTable>()
                .AddSingleton<IPrecipitationTable, PrecipitationTable>()
                .AddSingleton<ITemperatureTable, TemperatureTable>()
                .AddSingleton<IWindTable, WindTable>()
                .AddSingleton<IOtherGoalsTable, OtherGoalsTable>()

                // Dungeon Map
                .AddSingleton<IStartingAreaTable, StartingAreaTable>()
                .AddSingleton<IDoorTypeTable, DoorTypeTable>()
                .AddSingleton<IBeyondADoorTable, BeyondADoorTable>()
                .AddSingleton<IChamberTable, ChamberTable>()
                .AddSingleton<IChamberExitTable, ChamberExitTable>()
                .AddSingleton<IExitLocationTable, ExitLocationTable>()
                .AddSingleton<IExitTypeTable, ExitTypeTable>()
                .AddSingleton<IPassageTable, PassageTable>()
                .AddSingleton<IPassageWidthTable, PassageWidthTable>()
                .AddSingleton<IStairsTable, StairsTable>()

                // Misc Table
                .AddSingleton<IFormOfGovernmentTable, FormOfGovernmentTable>()
                .AddSingleton<IWeirdLocalesTable, WeirdLocalesTable>()
                .AddSingleton<IWorldShakingEventsTable, WorldShakingEventsTable>()
                .AddSingleton<ILeaderTypeTable, LeaderTypeTable>()

                // Settlement tables
                .AddSingleton<ISettlementsTable, SettlementTable>()
                .AddSingleton<IRaceRelationsTable, RaceRelationsTable>()
                .AddSingleton<IRulerStatusTable, RulerStatusTable>()

                // Dungeon Creator's Table
                .AddSingleton<IDungeonCreatorTable, DungeonCreatorTable>()
                .AddSingleton<IDungeonHistoryTable, DungeonHistoryTable>()
                .AddSingleton<IDungeonLocationTable, DungeonLocationTable>()
                .AddSingleton<IDungeonPurposeTable, DungeonPurposeTable>()
                .AddSingleton<ICultsTable, CultsTable>()
                .AddSingleton<INPCAlignmentTable, NPCAlignmentTable>()
                .AddSingleton<INPCAppearanceTable, NPCAppearanceTable>()
                .AddSingleton<INPCClassTable, NPCClassTable>()
                .AddSingleton<INPCHighAbilitiesTable, NPCHighAbilitiesTable>()
                .AddSingleton<INPCLowAbilitiesTable, NPCLowAbilitiesTable>()
                .AddSingleton<IExoticLocationTable, ExoticLocationTable>()
                ;

            return collection;
        }
    }
}

