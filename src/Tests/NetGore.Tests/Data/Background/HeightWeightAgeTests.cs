using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Core;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data.Background;

[TestFixture]
public class HeightWeightAgeTests
{
    [Test]
    public void CalculateHeightAndWeightTest()
    {
        int feet = 4, inches = 9, weight = 120;
        string weightDice = "4d6";
        string heightDice = "2d4";

        var totalInches = BackgroundTables.CalculateHeightInInches(feet, inches);
        Assert.That(57, Is.EqualTo(totalInches));

        feet = 0;
        inches = 0;
        BackgroundTables.ConvertInchesToFeetAndInches(totalInches, ref feet, ref inches);
        Assert.That(4, Is.EqualTo(feet));
        Assert.That(9, Is.EqualTo(inches));

        BackgroundTables.HeightAndWeight(ref feet, ref inches, ref weight, heightDice, weightDice);
        ClassicAssert.IsTrue(weight >= 124 && weight <= 144);

        totalInches = BackgroundTables.CalculateHeightInInches(feet, inches);
        ClassicAssert.IsTrue(totalInches >= 59 && totalInches <= 65);
    }

    [Test]
    public void CalculateAgeTest()
    {
        int StartingAge = 40;

        // barbarians 3d6
        int age = 0;
        age = BackgroundTables.CalculateCharacterAge(ClassEnum.Barbarian, StartingAge, "3d6", "5d6", "7d6");
        ClassicAssert.IsTrue(age >= StartingAge + 3
            && age <= StartingAge + 3 * 6,
            $"{nameof(ClassEnum.Barbarian)} Age={age} is outside of range");

        // rogues 3d6
        age = BackgroundTables.CalculateCharacterAge(ClassEnum.Rogue, StartingAge, "3d6", "5d6", "7d6");
        ClassicAssert.IsTrue(age >= StartingAge + 3
            && age <= StartingAge + 3 * 6,
            $"{nameof(ClassEnum.Rogue)} Age={age} is outside of range");

        // sorcerers 3d6
        age = BackgroundTables.CalculateCharacterAge(ClassEnum.Sorcerer, StartingAge, "3d6", "5d6", "7d6");
        ClassicAssert.IsTrue(age >= StartingAge + 3
            && age <= StartingAge + 3 * 6,
            $"{nameof(ClassEnum.Sorcerer)} Age={age} is outside of range");

        // warlocks. 3d6
        age = BackgroundTables.CalculateCharacterAge(ClassEnum.Warlock, StartingAge, "3d6", "5d6", "7d6");
        ClassicAssert.IsTrue(age >= StartingAge + 3
            && age <= StartingAge + 3 * 6,
            $"{nameof(ClassEnum.Warlock)} Age={age} is outside of range");

        // bards 5d6
        age = BackgroundTables.CalculateCharacterAge(ClassEnum.Bard, StartingAge, "3d6", "5d6", "7d6");
        ClassicAssert.IsTrue(age >= StartingAge + 5
            && age <= StartingAge + 5 * 6,
            $"{nameof(ClassEnum.Bard)} Age={age} is outside of range");

        // fighters 5d6
        age = BackgroundTables.CalculateCharacterAge(ClassEnum.Fighter, StartingAge, "3d6", "5d6", "7d6");
        ClassicAssert.IsTrue(age >= StartingAge + 5
            && age <= StartingAge + 5 * 6,
            $"{nameof(ClassEnum.Fighter)} Age={age} is outside of range");

        // paladins 5d6
        age = BackgroundTables.CalculateCharacterAge(ClassEnum.Paladin, StartingAge, "3d6", "5d6", "7d6");
        ClassicAssert.IsTrue(age >= StartingAge + 5
            && age <= StartingAge + 5 * 6,
            $"{nameof(ClassEnum.Paladin)} Age={age} is outside of range");

        // ranger 5d6
        age = BackgroundTables.CalculateCharacterAge(ClassEnum.Ranger, StartingAge, "3d6", "5d6", "7d6");
        ClassicAssert.IsTrue(age >= StartingAge + 5
            && age <= StartingAge + 5 * 6,
            $"{nameof(ClassEnum.Ranger)} Age={age} is outside of range");

        // clerics 7d6
        age = BackgroundTables.CalculateCharacterAge(ClassEnum.Cleric, StartingAge, "3d6", "5d6", "7d6");
        ClassicAssert.IsTrue(age >= StartingAge + 7
            && age <= StartingAge + 7 * 6,
            $"{nameof(ClassEnum.Cleric)} Age={age} is outside of range");

        // druids 7d6
        age = BackgroundTables.CalculateCharacterAge(ClassEnum.Druid, StartingAge, "3d6", "5d6", "7d6");
        ClassicAssert.IsTrue(age >= StartingAge + 7
            && age <= StartingAge + 7 * 6,
            $"{nameof(ClassEnum.Druid)} Age={age} is outside of range");

        // monks 7d6
        age = BackgroundTables.CalculateCharacterAge(ClassEnum.Monk, StartingAge, "3d6", "5d6", "7d6");
        ClassicAssert.IsTrue(age >= StartingAge + 7
            && age <= StartingAge + 7 * 6,
            $"{nameof(ClassEnum.Monk)} Age={age} is outside of range");

        // wizards 7d6.
        age = BackgroundTables.CalculateCharacterAge(ClassEnum.Wizard, StartingAge, "3d6", "5d6", "7d6");
        ClassicAssert.IsTrue(age >= StartingAge + 7
            && age <= StartingAge + 7 * 6,
            $"{nameof(ClassEnum.Wizard)} Age={age} is outside of range");
    }
}
