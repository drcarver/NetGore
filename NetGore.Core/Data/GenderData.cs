using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Core.Data;

public class GenderData
{
    //Table: Gender
    //d%	 Result
    //01–50	 Male
    //51–100 Female
    private static RandomTable GenderTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 50,
                Name = "Male",
                Description = "The Male of the species",
            },
            new RandomTableEntry
            {
                LowerRange = 51,
                UpperRange = 100,
                Name = "Female",
                Description = "The Female of the species",
            },
        ],
    };

    /// <summary>
    /// Get the Gender of the creature
    /// </summary>
    /// <returns>The selected Gender</returns>
    public static Gender GetGender()
    {
        var tableentry = GenderTable.GetRandomEntry();
        return new Gender
        {
            Name = tableentry?.Name,
            GenderEnum = tableentry?.Name == "Male" ?
                GenderEnum.Male :
                GenderEnum.Female,
        };
    }
}