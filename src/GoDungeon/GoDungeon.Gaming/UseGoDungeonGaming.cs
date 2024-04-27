using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using GoDungeon.Core.Tables;
using GoDungeon.Gaming.Interfaces;
using GoDungeon.Gaming.Tables;

using Microsoft.Extensions.DependencyInjection;

namespace GoDungeon.Gaming
{
    public static class DataServices
    {
        /// <summary>
        /// Get all the IGameable entries
        /// </summary>
        /// <returns></returns>
        private static List<Type> GamingTables => Assembly
            .GetExecutingAssembly()
            .GetExportedTypes()
            .Where(t => t.IsSubclassOf(typeof(GameTable)))
            .ToList();

        /// <summary>
        /// Add services to collection
        /// </summary>
        /// <param name="collection">The service collection</param>
        /// <returns>The updated service collection</returns>
        public static IServiceCollection UseGoDungeonGaming(this IServiceCollection collection)
        {
            //collection
            // Add all the game table types as transient
            collection
                .AddTransient<IChallengeRatingEquivalenceTable, ChallengeRatingEquivalenceTable>()
                .AddTransient<ICharacterWealthByLevelTable, CharacterWealthByLevelTable>()
                .AddTransient<IEncounterDesignTable, EncounterDesignTable>()
                .AddTransient<IExperiencePointAwardsTable, ExperiencePointAwardsTable>()
                .AddTransient<ITreasureTable, TreasureTable>()
                .AddTransient<ITreasureValuesPerEncounterTable, TreasureValuesPerEncounterTable>()
                ;

            return collection;
        }
    }
}
