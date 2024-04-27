using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using GoDungeon.Background.Interfaces;
using GoDungeon.Background.Tables;
using GoDungeon.Background.Tables.Halfling;
using GoDungeon.Core.Tables;
using GoDungeon.Monsters.Interfaces;
using GoDungeon.Monsters.Tables;
using GoDungeon.Monsters.ViewModels;
using GoDungeon.Monsters.ViewModels.Humanoid;

using Microsoft.Extensions.DependencyInjection;

namespace GoDungeon.Monsters
{
    public static class DataServices
    {
        /// <summary>
        /// Get all the IGameable entries
        /// </summary>
        /// <returns></returns>
        private static List<Type> MonsterTables => Assembly
            .GetExecutingAssembly()
            .GetExportedTypes()
            .Where(t => t.IsSubclassOf(typeof(GameTable)))
            .ToList();

        public static IServiceCollection UseGoDungeonMonsters(this IServiceCollection collection)
        {
            //collection
            collection.AddTransient<IHumanoidRaceTable, HumanoidRaceTable>();
            collection.AddTransient<IHalfling, HalflingViewModel>();
            collection.AddTransient<IHalflingHomelandTable, HalflingHomelandTable>();
            collection.AddTransient<IHalflingParentsTable, HalflingParentsTable>();
            collection.AddTransient<IUnusualHomelandTable, UnusualHomelandTable>();
            collection.AddTransient<ICircumstanceofBirthTable, CircumstanceofBirthTable>();
            collection.AddTransient<IProfessionTable, ProfessionTable>();
            collection.AddTransient<INobilityTable, NobilityTable>();
            collection.AddTransient<IAdoptedOutsideYourRaceTable, AdoptedOutsideYourRaceTable>();
            collection.AddSingleton<IHumanoidRaceFactory, HumanoidRaceFactory>();

            //// Add all the humanoid races
            //foreach (RaceEnum race in Enum.GetValues(typeof(RaceEnum)).Cast<RaceEnum>())
            //{
            //    collection.AddKeyedTransient<IHumanoidRace, HumanoidRace>(race.ToString());
            //}

            return collection;
        }
    }
}
