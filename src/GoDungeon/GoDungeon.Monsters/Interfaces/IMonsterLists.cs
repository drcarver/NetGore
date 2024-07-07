using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using GoDungeon.Core.Enum;
using GoDungeon.Monsters.ViewModels;

namespace GoDungeon.Monsters.Interfaces;

public interface IMonsterLists
{
    /// <summary>
    /// Arctic Monsters
    /// </summary>
    public Dictionary<MonsterEnum, MonsterInfoViewModel> ArcticMonsters { get; }

    /// <summary>
    /// Urbane monsters
    /// </summary>
    public Dictionary<MonsterEnum, MonsterInfoViewModel> UrbaneMonsters { get; }

    /// <summary>
    /// The list of NPC's
    /// </summary>
    public ObservableCollection<MonsterInfoViewModel> NPCList { get; }

    /// <summary>
    /// Returns true if the monster is a Were beast
    /// </summary>
    /// <param name="monsterInfo">The monster info</param>
    /// <returns>True if the monster is a NPC</returns>
    bool IsWere(MonsterInfoViewModel monsterInfo);

    /// <summary>
    /// Returns true if the monster is a NPC
    /// </summary>
    /// <param name="monsterInfo">The monster info</param>
    /// <returns>True if the monster is a NPC</returns>
    bool IsNPC(MonsterInfoViewModel monsterInfo);
}