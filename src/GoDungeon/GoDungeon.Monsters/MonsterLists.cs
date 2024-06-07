using System.Collections.Generic;
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Monsters.Interfaces;
using GoDungeon.Monsters.ViewModels;

namespace GoDungeon.Monsters;

public partial class MonsterLists : IMonsterLists
{
    /// <summary>
    /// Arctic Monsters
    /// </summary>
    public Dictionary<MonsterEnum, MonsterInfoViewModel> ArcticMonsters { get; } = new Dictionary<MonsterEnum, MonsterInfoViewModel>
    {
        { MonsterEnum.Acolyte, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Acolyte), Terrain = TerrainEnum.Urban } },
        { MonsterEnum.Commoner, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Commoner), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.Owl, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Owl), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.Bandit, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Bandit), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.BloodHawk, new MonsterInfoViewModel { Name = nameof(MonsterEnum.BloodHawk), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.Kobold, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Kobold), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.TribalWarrior, new MonsterInfoViewModel { Name = nameof(MonsterEnum.TribalWarrior), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.GiantOwl, new MonsterInfoViewModel { Name = nameof(MonsterEnum.GiantOwl), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.IceMephit, new MonsterInfoViewModel { Name = nameof(MonsterEnum.IceMephit), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.Orc, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Orc), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.Scout, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Scout), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.BrownBear, new MonsterInfoViewModel { Name = nameof(MonsterEnum.BrownBear), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.BanditCaptain, new MonsterInfoViewModel { Name = nameof(MonsterEnum.BanditCaptain), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.Bandit, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Bandit), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.Berserker, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Berserker), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.Druid, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Druid), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.Griffon, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Griffon), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.Ogre, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Ogre), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.PolarBear, new MonsterInfoViewModel { Name = nameof(MonsterEnum.PolarBear), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.SaberToothedTiger, new MonsterInfoViewModel { Name = nameof(MonsterEnum.SaberToothedTiger), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.Manticore, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Manticore), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.Veteran, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Veteran), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.WinterWolf, new MonsterInfoViewModel { Name = nameof(MonsterEnum.WinterWolf), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.Troll, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Troll), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.Werebear, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Werebear), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.Mammoth, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Mammoth), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.YoungWhiteDragon, new MonsterInfoViewModel { Name = nameof(MonsterEnum.YoungWhiteDragon), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.FrostGiant, new MonsterInfoViewModel { Name = nameof(MonsterEnum.FrostGiant), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.Remorhaz, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Remorhaz), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.Roc, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Roc), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.AdultWhiteDragon, new MonsterInfoViewModel { Name = nameof(MonsterEnum.AdultWhiteDragon), Terrain = TerrainEnum.Arctic } },
        { MonsterEnum.AncientWhiteDragon, new MonsterInfoViewModel { Name = nameof(MonsterEnum.AncientWhiteDragon), Terrain = TerrainEnum.Arctic } }
    };

    /// <summary>
    /// Urbane monsters
    /// </summary>
    public Dictionary<MonsterEnum, MonsterInfoViewModel> UrbaneMonsters { get; } = new Dictionary<MonsterEnum, MonsterInfoViewModel>
    {
        { MonsterEnum.Acolyte, new MonsterInfoViewModel { Name = nameof(MonsterEnum.Acolyte), Terrain = TerrainEnum.Urban } },
    };

    /// <summary>
    /// The list of NPC's
    /// </summary>
    public ObservableCollection<MonsterInfoViewModel> NPCList { get; } = new ObservableCollection<MonsterInfoViewModel>()
    {
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Acolyte) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Archmage) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Assassin) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Bandit) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.BanditCaptain) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Berserker) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Commoner) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Cultist) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.CultFanatic) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Druid) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Gladiator) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Guard) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Knight) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Mage) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Noble) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Priest) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Scout) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Spy) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Thug) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.TribalWarrior) },
        new MonsterInfoViewModel { Name = nameof(MonsterEnum.Veteran) },
    };
}
