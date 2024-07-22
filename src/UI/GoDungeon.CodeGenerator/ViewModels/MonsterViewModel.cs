using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;
using GoDungeon.Core.Enum;

namespace GoDungeon.CodeGenerator.ViewModels;

public partial class MonsterViewModel : CodeGenerationModel, IMonster
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
    private decimal challengeRating;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="parseModel">The parse model for the monster</param>
    public MonsterViewModel(ParseModel parseModel)
        : base(parseModel)
    {
        foreach (var item in FileHeaders)
        {
            var fh = item.Substring(0, item.IndexOf(":"));
            switch (item.Substring(0, item.IndexOf(":")))
            {
                case "cr":
                    challengeRating = Convert.ToDecimal(item.Replace("cr:", string.Empty));
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
                    System.Enum.TryParse<RaceTypeEnum>(rType, true, out raceType);
                    if (rSubType != string.Empty)
                    {
                        if (rSubType.IndexOf(",") != -1)
                        {
                        }
                        System.Enum.TryParse<RaceSubTypeEnum>(rSubType, true, out raceSubType);
                    }
                    break;
            }
        }
    }
}
