using CommunityToolkit.Mvvm.ComponentModel;

using NetGore.Data.Interfaces;

namespace NetGore.UI.Admin.ViewModel;

public partial class CharacterAdvancementEntryViewModel : ObservableObject
{
    /// <summary>
    /// The range of the entries on the dice (0-9) for example
    /// </summary>
    [ObservableProperty]
    Range range;

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
        Range = model.Range;
        Description = model.Description;
        ProficiencyBonus = model.ProficiencyBonus;
        Level = model.Level;
        ProperName = model.ProperName ?? model.Name;
    }
}