using System.Diagnostics.CodeAnalysis;
using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Core.Models;

namespace D20.Core.Tables;

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

    /// <summary>
    /// Initialize the game table.  This is a seperate method so we can create a game table for it;s meta properties
    /// with out creating the table.  A bit of optimiation to conserve memeory
    /// </summary>
    public override void InitializeTable()
    {
        Table =
        [
            new StandardTableEntry
            {
                Name = nameof(GenderEnum.Male),
                Description = "The Male of the species",
            },

            new StandardTableEntry
            {
                Name = nameof(GenderEnum.Female),
                Description = "The Female of the species",
            },
        ];
    }
}