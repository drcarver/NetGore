using System.Diagnostics.CodeAnalysis;

using D20.Character.Models;
using D20.Core.Base;

namespace D20.Gaming.Models;

/// <summary>
/// A party of player characters
/// </summary>
public class Party : BaseObject
{
    /// <summary>
    /// THe player characters
    /// </summary>
    [SetsRequiredMembers]
    public Party()
    {
    }

    /// <summary>
    /// The party
    /// </summary>
    public List<PlayerCharacter> CharacterParty { get; set; } = [];

    /// <summary>
    /// Determine the average level of your player characters—this 
    /// is their Average Party Level (APL for short). You should 
    /// round this value to the nearest whole number (this is one 
    /// of the few exceptions to the round down rule). Note that 
    /// these encounter creation guidelines assume a group of four 
    /// or five PCs. If your group contains six or more players, 
    /// add one to their average level. If your group contains 
    /// three or fewer players, subtract one from their average 
    /// level. For example, if your group consists of six players, 
    /// two of which are 4th level and four of which are 5th level, 
    /// their APL is 6th (28 total levels, divided by six players, 
    /// rounding up, and adding one to the final result).
    /// </summary>
    /// <returns>The average player level</returns>
    public int AveragePartyLevel() 
    {
        int apl = 0;

        foreach (var character in CharacterParty)
        {
            apl += character.Level;
        }

        apl = (int) Math.Round((double) (apl / CharacterParty.Count));
        if (CharacterParty.Count >= 6) 
        {
            apl += 1;
        }
        else if (CharacterParty.Count <= 3) 
        {
            apl -= 1;
        }
        return apl; 
    }
}
