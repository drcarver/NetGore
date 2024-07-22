using System.Diagnostics.CodeAnalysis;

using GoDungeon.CodeGenerator.Enum;
using GoDungeon.CodeGenerator.Interfaces;

namespace GoDungeon.CodeGenerator.Models;

public class IndexModel
{
    /// <summary>
    /// The file header count of the view model for this index
    /// </summary>
    public int FileHeaderCount { get; set; }

    /// <summary>
    /// The Index 
    /// </summary>
    public IndexEnum Index { get; set; }

    /// <summary>
    /// The path to the Index
    /// </summary>
    public string Path { get; set; }

    /// <summary>
    /// The path to the detail file
    /// </summary>
    public string DetailPath { get; set; }

    /// <summary>
    /// The title of the index
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// The dictionary of models for this index
    /// </summary>
    public Dictionary<IndexEnum, List<ICodeGen>> IndexDictionary { get; set; } = [];

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="index">The index to be created</param>
    public IndexModel(IndexEnum index)
    {
        switch (index)
        {
            case IndexEnum.ByMagicItemName:
                FileHeaderCount = 2;
                Title = "Magic items by name";
                Path = $"/MagicItems{index.ToString()}.md";
                DetailPath = $"magicitems/";
                break;
            case IndexEnum.ByMagicItemType:
                FileHeaderCount = 2;
                Title = "Magic items by type";
                Path = $"/MagicItems{index.ToString()}.md";
                DetailPath = $"magicitems/";
                break;
            case IndexEnum.ByMonsterName:
                FileHeaderCount = 3;
                Title = "Monsters by name";
                Path = $"/Monsters{index.ToString()}.md";
                DetailPath = $"monsters/";
                break;
            case IndexEnum.ByChallengeRating:
                FileHeaderCount = 3;
                Title = "Monsters by challenge rating";
                Path = $"/Monsters{index.ToString()}.md";
                DetailPath = $"monsters/";
                break;
            case IndexEnum.ByRaceType:
                FileHeaderCount = 3;
                Title = "Monsters by race";
                Path = $"/Monsters{index.ToString()}.md";
                DetailPath = $"monsters/";
                break;
            case IndexEnum.BySpellName:
                FileHeaderCount = 4;
                Title = "Spells by name";
                Path = $"/Spells{index.ToString()}.md";
                DetailPath = $"spells/";
                break;
            case IndexEnum.BySpellLevel:
                FileHeaderCount = 4;
                Title = "Spells by level";
                Path = $"/spells{index.ToString()}.md";
                DetailPath = $"spells/";
                break;
            case IndexEnum.BySpellSchool:
                FileHeaderCount = 4;
                Title = "Spells by school";
                Path = $"/spells{index.ToString()}.md";
                DetailPath = $"spells/";
                break;
            default:
                FileHeaderCount = 0;
                Title = "Index File";
                Path = string.Empty;
                DetailPath = string.Empty;
                break;
        }
    }
}
