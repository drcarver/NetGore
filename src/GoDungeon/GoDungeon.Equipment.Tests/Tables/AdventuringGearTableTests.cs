using System;

using GoDungeon.Equipment.Enum;
using GoDungeon.Equipment.Interfaces;
using GoDungeon.Equipment.Tables;

namespace GoDungeon.Tests.Equipment.Tables;

[TestClass]
public partial class EquipmentTableTests
{
    [TestMethod]
    public void AdventuringGearTableTests()
    {
        IAdventuringGearTable testTable = new AdventuringGearTable();
        testTable.InitializeTable();
        Assert.IsTrue(testTable.Name == nameof(AdventuringGearTable));
        Assert.IsTrue(testTable.ProperName == "Adventuring Gear Table");
        Assert.IsTrue(testTable.Description == "Adventuring Gear");
        Assert.IsTrue(testTable.Table.Count() == 83);
        foreach (var item in System.Enum.GetValues(typeof(AdventuringGearEnum)))
        {
            IAdventuringGearTableEntry entry = (IAdventuringGearTableEntry) testTable.GetEntryByName(item.ToString());
            Assert.IsNotNull(entry, $"Adventuring gear table has no entry for {item}");
            var verify = VerifyTableEntry(item.ToString(), entry);
            Assert.IsTrue(verify == string.Empty, verify);
        }
    }

    /// <summary>
    /// Verify a entry in the IAdventuringGearTable
    /// </summary>
    /// <param name="enumString">The name of the entry as a string</param>
    /// <param name="entry">The entry</param>
    /// <returns>Empty when no test fails, otherwise a failure string.</returns>
    private string VerifyTableEntry(string enumString, IAdventuringGearTableEntry entry)
    {
        AdventuringGearEnum enumValue;
        if (!System.Enum.TryParse(enumString, out enumValue))
        {
            return $"Unable to convert {enumString} to a AdventuringGearEnum";
        }
        switch (enumValue)
        {
            #region Abacus
            case AdventuringGearEnum.Abacus:
                if (entry.Name != AdventuringGearEnum.Abacus.ToString())
                {
                    return $"Entry has wrong name, Name={entry.Name}";
                }
                if (entry.ProperName != "Abacus")
                {
                    return $"Entry has wrong ProperName, ProperName={entry.ProperName}";
                }
                if (entry.Cost != "2 gp")
                {
                    return $"Entry has wrong Cost, Cost={entry.Cost}";
                }
                if (entry.Weight != "2 lb.")
                {
                    return $"Entry has wrong Weight, Weight={entry.Weight}";
                }
                return string.Empty;
            #endregion

            default:
                return $"No Case for entry named {entry.Name}";
        }
    }
}