using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;
using GoDungeon.Core.Enum;
using GoDungeon.Spells.Enum;

namespace GoDungeon.CodeGenerator.ViewModels;

public partial class SpellViewModel : CodeGenerationModel, ISpell
{
    /// <summary>
    /// The level of the spell
    /// </summary>
    [ObservableProperty]
    private int level;

    /// <summary>
    /// The magic school for the spell
    /// </summary>
    [ObservableProperty]
    private MagicSchoolEnum magicSchool;

    /// <summary>
    /// The list of character classes for the spell
    /// </summary>
    public List<ClassEnum> CharacterClassList { get; } = [];

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="parseModel">The parse model for a spell</param>
    public SpellViewModel(ParseModel parseModel)
        : base(parseModel)
    {
        foreach (var item in FileHeaders)
        {
            var fh = item.Substring(0, item.IndexOf(":"));
            switch (item.Substring(0, item.IndexOf(":")))
            {
                case "name":
                    break;
                case "level":
                    level = int.Parse(item.Replace("level:", string.Empty));
                    break;
                case "school":
                    Enum.TryParse<MagicSchoolEnum>(fh, true, out magicSchool);
                    break;
                case "classes":
                    fh = item.Replace("classes:", string.Empty);
                    int spellLineNumber = 3;

                    // Process the markdown file until we get all the classes for the spell
                    do
                    {
                        ClassEnum spellClass;
                        Enum.TryParse<ClassEnum>(fh, true, out spellClass);
                        CharacterClassList.Add(spellClass);
                        spellLineNumber++;
                        fh = ParseModel.Markdown[spellLineNumber].Trim();
                    } while (fh != string.Empty);
                    break;
            }
        }
    }
}
