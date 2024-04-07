using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Enum;
using NetGore.Data.Interfaces;
using NetGore.Data.Models;

namespace NetGore.Core.Data;

public class GenderTable : GameTable, IGenderTable
{
    //Table: Gender
    //d%	 Result
    //01–50	 Male
    //51–100 Female
    [SetsRequiredMembers]
    public GenderTable()
    {
        Name = nameof(GenderTable);
        ProperName = "Gender Table";
        DiceSides = 100;
        Table =
        [
            new GameTableEntry
            {
                Range = new Range(01,50),
                Name = nameof(GenderEnum.Male),
                Description = "The Male of the species",
            },
            new GameTableEntry
            {
                Range = new Range(51,100),
                Name = nameof(GenderEnum.Female),
                Description = "The Female of the species",
            },
        ];
    }

    /// <summary>
    /// Get the Gender of the creature
    /// </summary>
    /// <returns>The selected Gender</returns>
    public GenderEnum GetGender()
    {
        switch (GetRandomEntry().Name)
        {
            case nameof(GenderEnum.Male):
                return GenderEnum.Male;
            case nameof(GenderEnum.Female):
                return GenderEnum.Female;

        }
        return GenderEnum.Male;
    }
}