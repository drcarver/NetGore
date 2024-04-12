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
    /// The description of the entry
    /// </summary>
    [ObservableProperty]
    string? description;

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
    /// The title of the table
    /// </summary>
    [ObservableProperty]
    string properName;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="model">The model to be loaded</param>
    public CharacterAdvancementEntryViewModel(ICharacterAdvancementEntry model)
    {
        ExperiencePoints = model.ExperiencePoints;
        Description = model.Description;
        ProficiencyBonus = model.ProficiencyBonus;
        Level = model.Level;
        ProperName = model.ProperName ?? model.Name;
    }
}