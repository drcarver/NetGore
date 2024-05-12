using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;

namespace GoDungeon.Core.Interfaces
{
    public interface ICharacterRace : IHumanoidRace
    {
        /// <summary>
        /// The level of the character
        /// </summary>
        public int Level { get; }

        /// <summary>
        /// The character's homeland
        /// </summary>
        public IBackgroundTableEntry? Homeland { get; }

        /// <summary>
        /// The traits for this character
        /// </summary>
        public ObservableCollection<TraitEnum> Traits { get; }

        /// <summary>
        /// The character's parents
        /// </summary>
        public IBackgroundTableEntry? Parents { get; }

        /// <summary>
        /// The character's circumstance of birth
        /// </summary>
        public IBackgroundTableEntry? CircumstanceOfBirth { get; }

        /// <summary>
        /// The character's parents profession
        /// </summary>
        public IBackgroundTableEntry? ParentProfession { get; }

        /// <summary>
        /// Adopted parents if needed
        /// </summary>
        public IBackgroundTableEntry? AdoptedParents { get; }
    }
}