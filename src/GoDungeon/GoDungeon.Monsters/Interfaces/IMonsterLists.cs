using System.Collections.Generic;
using System.Collections.ObjectModel;

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
}