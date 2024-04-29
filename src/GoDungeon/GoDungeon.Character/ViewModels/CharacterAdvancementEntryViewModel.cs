using System;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Character.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Character.ViewModels
{
    public partial class CharacterAdvancementEntryViewModel : GameTableEntryViewModel, ICharacterAdvancementEntry
    {
        /// <summary>
        /// The sides to the dice for the table
        /// </summary>
        [ObservableProperty]
        private int level;

        /// <summary>
        /// The Proficiency	Bonus for this level
        /// </summary>
        [ObservableProperty]
        private int proficiencyBonus;

        /// <summary>
        /// The range of experience points for this level
        /// </summary>
        [ObservableProperty]
        private Range experiencePoints;
    }
}
