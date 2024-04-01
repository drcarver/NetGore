using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Core.Data;

public class Gender
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
                Name = nameof(GenderEnum.Male),
                Description = "The Male of the species",
            },
            new RandomTableEntry
            {
                LowerRange = 51,
                UpperRange = 100,
                Name = nameof(GenderEnum.Female),
                Description = "The Female of the species",
            },
        ],
    };

    /// <summary>
    /// Get the Gender of the creature
    /// </summary>
    /// <returns>The selected Gender</returns>
    public static GenderEnum GetGender()
    {
        switch (GenderTable.GetRandomEntry().Name)
        {
            case nameof(GenderEnum.Male):
                return GenderEnum.Male;
            case nameof(GenderEnum.Female):
                return GenderEnum.Female;

        }
        return GenderEnum.Male;
    }
}