using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Character.Enum;
using GoDungeon.Character.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Character.ViewModels
{
    public partial class ClassFeatureLevelEntryViewModel : GameTableEntryViewModel, IClassFeatureLevelEntry
    {
        /// <summary>
        /// The class feature level
        /// </summary>
        [ObservableProperty]
        private int level;

        /// <summary>
        /// The base proficiency for this level
        /// </summary>
        [ObservableProperty]
        private int baseProficiency;

        /// <summary>
        /// The class features
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<ClassFeatureEnum>? classFeatures;
    }
}
