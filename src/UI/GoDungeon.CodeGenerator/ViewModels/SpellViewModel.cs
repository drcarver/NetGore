using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.CodeGenerator.CodeGen;
using GoDungeon.CodeGenerator.Models;
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;
using GoDungeon.Spells.Enum;

namespace GoDungeon.CodeGenerator.ViewModels;

public partial class SpellViewModel : StandardTableEntryViewModel
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
    private List<ClassEnum> characterClassList = [];
 
    /// <summary>
    /// The parse model for this magic item
    /// </summary>
    public ParseModel ParseModel { get; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="parseModel">The parse model for a spell</param>
    public SpellViewModel(ParseModel parseModel)
    {
        ParseModel = parseModel;
        ProperName = parseModel.FileHeaders[0].Replace("name: ", string.Empty);
        Name = Utilities.CleanupForCSharp(ProperName);
        foreach (var item in parseModel.FileHeaders)
        {
            var fh = item.Substring(0, item.IndexOf(":"));
            switch (item.Substring(0, item.IndexOf(":")))
            {
                case "level":
                    level = int.Parse(item.Replace("level:", string.Empty).Trim());
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
                        characterClassList.Add(spellClass);
                        spellLineNumber++;
                        fh = ParseModel.Markdown[spellLineNumber].Trim();
                    } while (fh != string.Empty);
                    break;
            }
        }
    }
}
