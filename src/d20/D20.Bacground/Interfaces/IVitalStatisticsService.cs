using D20.Core.Enum;

namespace D20.Background.Interfaces;

public interface IVitalStatisticsService
{
    /// <summary>
    /// Convert feet and inches to inches
    /// </summary>
    /// <param name="feet">The height in feet</param>
    /// <param name="inches">The additional inches</param>
    /// <returns>The height in inches only</returns>
    int CalculateCharacterAge(ClassEnum characterClass, int StartingAge, string IntuitiveAgeDice, string SelfTaughtAgeDice, string TrainedAgeDice);

    /// <summary>
    /// Convert inches to feet and inches
    /// </summary>
    /// <param name="inches">The height in inches</param>
    /// <returns>The string with the height in feet and inches.</returns>
    int CalculateHeightInInches(int feet, int inches);

    /// <summary>
    /// Compute the height and weight for a creature;
    /// </summary>
    /// <param name="feet">Starting height in feet</param>
    /// <param name="inches">Starting height in inches</param>
    /// <param name="startingweight">Starting weight in lbs.</param>
    /// <param name="additionalHeightDice">Additional height</param>
    /// <param name="additionalWeightDie">Additional weight</param>
    void ConvertInchesToFeetAndInches(int totalInches, ref int feet, ref int inches);

    /// <summary>
    /// Calculate the age of a creature
    /// </summary>
    /// <param name="characterClass">The character class</param>
    /// <param name="StartingAge">The starting age</param>
    /// <param name="IntuitiveAgeDice">Dice for intuitive classes</param>
    /// <param name="SelfTaughtAgeDice">Dice for self-taught</param>
    /// <param name="TrainedAgeDice">Dice for trained</param>
    void HeightAndWeight(ref int feet, ref int inches, ref int Weight, string additionalHeightDice, string additionalWeightDice, int weightMultiplier = 1);
}