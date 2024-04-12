#region Copyright Notice and source url
//
// This content contains copyright material. The material
// format has been change to support the needs of the
// Application.  In particular the table entries and
// values have the following copyright notice.
//
// The content is from the url:
// https://www.d20pfsrd.com/basics-ability-scores/more-character-options/character-backgrounds/background-generator
//
// Pathfinder Roleplaying Game: Ultimate Campaign.
// ©2013, Paizo Publishing, LLC;
// Authors: Jesse Benner, Benjamin Bruck, Jason Bulmahn,
// Ryan Costello, Adam Daigle, Matt Goetz, Tim Hitchcock,
// James Jacobs, Ryan Macklin, Colin McComb,
// Jason Nelson, Richard Pett, Stephen Radney-MacFarland,
// Patrick Renie, Sean K Reynolds, F. Wesley Schneider,
// James L.Sutter, Russ Taylor, and Stephen Townshend.
//
#endregion

using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Core;

namespace D20.Character.Services;

public class VitalStatisticsService : IVitalStatisticsService
{
    /// <summary>
    /// Convert feet and inches to inches
    /// </summary>
    /// <param name="feet">The height in feet</param>
    /// <param name="inches">The additional inches</param>
    /// <returns>The height in inches only</returns>
    public int CalculateHeightInInches(int feet, int inches)
    {
        return feet * 12 + inches;
    }

    /// <summary>
    /// Convert inches to feet and inches
    /// </summary>
    /// <param name="inches">The height in inches</param>
    /// <returns>The string with the height in feet and inches.</returns>
    public void ConvertInchesToFeetAndInches(int totalInches, ref int feet, ref int inches)
    {
        feet = totalInches / 12;
        var feet2 = feet * 12;
        inches = totalInches - feet2;
    }

    /// <summary>
    /// Compute the height and weight for a creature;
    /// </summary>
    /// <param name="feet">Starting height in feet</param>
    /// <param name="inches">Starting height in inches</param>
    /// <param name="startingweight">Starting weight in lbs.</param>
    /// <param name="additionalHeightDice">Additional height</param>
    /// <param name="additionalWeightDie">Additional weight</param>
    public void HeightAndWeight(
        ref int feet,
        ref int inches,
        ref int Weight,
        string additionalHeightDice,
        string additionalWeightDice,
        int weightMultiplier = 1)
    {
        var totalInches = CalculateHeightInInches(feet, inches)
            + new Dice(additionalHeightDice).Total;
        ConvertInchesToFeetAndInches(totalInches, ref feet, ref inches);

        Weight += new Dice(additionalWeightDice).Total *
            weightMultiplier;
    }

    /// <summary>
    /// Calculate the age of a creature
    /// </summary>
    /// <param name="characterClass">The character class</param>
    /// <param name="StartingAge">The starting age</param>
    /// <param name="IntuitiveAgeDice">Dice for intuitive classes</param>
    /// <param name="SelfTaughtAgeDice">Dice for self-taught</param>
    /// <param name="TrainedAgeDice">Dice for trained</param>
    /// <returns></returns>
    public int CalculateCharacterAge(
        ClassEnum characterClass,
        int StartingAge,
        string IntuitiveAgeDice,
        string SelfTaughtAgeDice,
        string TrainedAgeDice)
    {
        // barbarians, rogues, sorcerers and warlocks.
        if (characterClass == ClassEnum.Barbarian ||
            characterClass == ClassEnum.Rogue ||
            characterClass == ClassEnum.Sorcerer ||
            characterClass == ClassEnum.Warlock)
        {
            var age = StartingAge + new Dice(IntuitiveAgeDice).Total;
            return age;
        }

        // bards, fighters, paladins and rangers.
        if (characterClass == ClassEnum.Bard ||
            characterClass == ClassEnum.Fighter ||
            characterClass == ClassEnum.Paladin ||
            characterClass == ClassEnum.Ranger)
        {
            return StartingAge + new Dice(SelfTaughtAgeDice).Total;
        }

        // clerics, druids, monks, and wizards.
        if (characterClass == ClassEnum.Cleric ||
            characterClass == ClassEnum.Druid ||
            characterClass == ClassEnum.Monk ||
            characterClass == ClassEnum.Wizard)
        {
            return StartingAge + new Dice(TrainedAgeDice).Total;
        }

        return StartingAge;
    }
}
