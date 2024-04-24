using CommunityToolkit.Mvvm.ComponentModel;

using D20.Character.Interfaces;

namespace NetGore.UI.Admin.ViewModel;

public partial class CharacterAdvancementEntryViewModel : ObservableObject
{
    /// <summary>
    /// The experience point range required for the level
    /// </summary>
    [ObservableProperty]
    Range experiencePoints;

    /// <summary>
    /// The character level
    /// </summary>
    [ObservableProperty]
    int level;

    /// <summary>
    /// The Proficiency Bonus for this level
    /// </summary>
    [ObservableProperty]
    int proficiencyBonus;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="model">The model to be loaded</param>
    public CharacterAdvancementEntryViewModel(ICharacterAdvancementEntry model)
    {
        ExperiencePoints = model.ExperiencePoints;
        ProficiencyBonus = model.ProficiencyBonus;
        Level = model.Level;
    }
}