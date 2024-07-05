using GoDungeon.CodeGenerator.Models;
using GoDungeon.CodeGenerator.ViewModels;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface IParseMarkdown
{
    /// <summary>
    /// The parse models for all the markdown models
    /// </summary>
    public List<SpellViewModel> SpellModels { get; }

    /// <summary>
    /// The parse models for all the rules models
    /// </summary>
    public List<RulesViewModel> RulesModels { get; }

    /// <summary>
    /// The parse models for all the magic item models
    /// </summary>
    public List<MagicItemViewModel> MagicItemsModels { get; }

    /// <summary>
    /// The parse models for all the monsters
    /// </summary>
    public List<MonsterViewModel> MonsterModels { get; }

    /// <summary>
    /// Get the tables in the markdown file
    /// </summary>
    void ParseMarkDownTable(ParseModel markDown);

    /// <summary>
    /// The root directory to generate the .html and class files in
    /// </summary>
    string? RootDirectory { get; set; }
}
