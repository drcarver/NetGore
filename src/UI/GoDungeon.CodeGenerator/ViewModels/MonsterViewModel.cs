using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.CodeGenerator.CodeGen;
using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.CodeGenerator.ViewModels;

public partial class MonsterViewModel : StandardTableEntryViewModel, IMonster
{
    /// <summary>
    /// The type of monster
    /// </summary>
    [ObservableProperty]
    private RaceTypeEnum raceType;

    /// <summary>
    /// The sub type of monster
    /// </summary>
    [ObservableProperty]
    private RaceSubTypeEnum raceSubType;

    /// <summary>
    /// The challenge rating of the monster
    /// </summary>
    [ObservableProperty]
    private double challengeRating;

    /// <summary>
    /// The parse model for this magic item
    /// </summary>
    public ParseModel ParseModel { get; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="parseModel">The parse model for the monster</param>
    public MonsterViewModel(ParseModel parseModel)
    {
        ParseModel = parseModel;
        ProperName = parseModel.FileHeaders[0].Replace("name: ", string.Empty);
        Name = Utilities.CleanupForCSharp(ProperName);
        foreach (var item in parseModel.FileHeaders)
        {
            var fh = item.Substring(0, item.IndexOf(":"));
            switch (item.Substring(0, item.IndexOf(":")))
            {
                case "cr":
                    challengeRating = Convert.ToDouble(item.Replace("cr:", string.Empty));
                    break;
                case "type":
                    string rType = item.Replace("type:", string.Empty);
                    string rSubType = string.Empty;
                    if (rType.IndexOf("(") != -1)
                    {
                        rSubType = item.Substring(item.IndexOf("(")+1);
                        rSubType = rSubType.Replace(")", string.Empty).Replace(" race", string.Empty);
                        rType = rType.Substring(1, rType.IndexOf("(")-1).Trim();
                    }
                    Enum.TryParse<RaceTypeEnum>(rType, true, out raceType);
                    if (rSubType != string.Empty)
                    {
                        if (rSubType.IndexOf(",") != -1)
                        {
                        }
                        Enum.TryParse<RaceSubTypeEnum>(rSubType, true, out raceSubType);
                    }
                    break;
            }
        }
    }
}
