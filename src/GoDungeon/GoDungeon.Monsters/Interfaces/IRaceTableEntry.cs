using GoDungeon.Core.Enum;

namespace GoDungeon.Monsters.Interfaces
{
    public interface IRaceTableEntry
    {
        /// <summary>
        /// The humanoid race to create
        /// </summary>
        public RaceEnum Race { get; set; }
    }
}