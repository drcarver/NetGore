using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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
            collection
                .AddTransient<IHumanoidRaceTable, HumanoidRaceTable>()
                .AddTransient<IDragonborn, DragonbornViewModel>()
                .AddTransient<IDwarf, DwarfViewModel>()
                .AddTransient<IElf, ElfViewModel>()
                .AddTransient<IGnome, GnomeViewModel>()
                .AddTransient<IHalfElf, HalfElfViewModel>()
                .AddTransient<IHalfling, HalflingViewModel>()
                .AddTransient<IHalfOrc, HalfOrcViewModel>()
                .AddTransient<IHuman, HumanViewModel>()
                .AddTransient<ITiefling, TieflingViewModel>()
                .AddSingleton<IHumanoidRaceFactory, HumanoidRaceFactory>()
            ;
            return collection;
        }
    }
}
