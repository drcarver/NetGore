using GoDungeon.CodeGenerator.Models;
using GoDungeon.Core.Enum;

namespace GoDungeon.CodeGenerator.Tables;

public partial class MonsterLists
{
	public static List<MonsterInfo> ArcticMonsters =
	[
		new MonsterInfo { Name = nameof(MonsterEnum.Acolyte), Terrain = TerrainEnum.Urban },
		new MonsterInfo { Name = nameof(MonsterEnum.Commoner), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.Owl), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.Bandit), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.BloodHawk), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.Kobold), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.TribalWarrior), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.GiantOwl), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.IceMephit), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.Orc), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.Scout), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.BrownBear), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.BanditCaptain), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.Berserker), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.Druid), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.Griffon), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.Ogre), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.PolarBear), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.SaberToothedTiger), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.Manticore), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.Veteran), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.WinterWolf), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.Troll), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.Werebear), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.Mammoth), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.YoungWhiteDragon), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.FrostGiant), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.Remorhaz), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.Roc), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.AdultWhiteDragon), Terrain = TerrainEnum.Arctic },
		new MonsterInfo { Name = nameof(MonsterEnum.AncientWhiteDragon), Terrain = TerrainEnum.Arctic }
	];
}