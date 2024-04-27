using System.Diagnostics.CodeAnalysis;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Models;

using GoDungeon.Core.ViewModels;
using GoDungeon.Monsters.Interfaces;

namespace GoDungeon.Monsters.Models
{
    public class RaceTableEntryViewModel : RandomTableEntryViewModel, IRaceTableEntry
    {
        /// <summary>
        /// The humanoid race to create
        /// </summary>
        public RaceEnum Race { get; set; }
    }
}
