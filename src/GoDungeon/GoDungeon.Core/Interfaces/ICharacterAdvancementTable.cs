using System.Linq;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Character.Interfaces
{
    public interface ICharacterAdvancementTable : INamedTable
    {
        /// <summary>
        /// Get a entry from the table by it's experience points
        /// </summary>
        /// <returns>The selected CharacterAdvancementEntryViewModel.</returns>
        public ICharacterAdvancementEntry GetEntryByExperiencePoints(int number);
    }
}