using GoDungeon.Monsters.Interfaces;
using GoDungeon.Monsters.Tables;
using GoDungeon.Monsters.ViewModels;
using GoDungeon.Monsters.ViewModels.Humanoid;

using Microsoft.Extensions.DependencyInjection;

namespace GoDungeon.Monsters;

public static class DataServices
{
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
            .AddSingleton<IMonsterLists, MonsterLists>()
        ;
        return collection;
    }
}
