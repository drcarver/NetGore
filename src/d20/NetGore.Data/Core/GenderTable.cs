using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Enum;
using NetGore.Data.Interfaces;
using NetGore.Data.Models;

namespace NetGore.Core.Data;

/// <summary>
/// The gender table.  
/// </summary>
public class GenderTable : GameTable, IGenderTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public GenderTable()
    {
        Name = nameof(GenderTable);
        ProperName = "Gender Table";
        TableType = TableTypeEnum.CharacterTable;
        Table =
        [
            new GameTableEntry
            {
                Name = nameof(GenderEnum.Male),
                Description = "The Male of the species",
            },

            new GameTableEntry
            {
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