//
// Ammunition Table tests
//
using System;

using GoDungeon.Equipment.Enum;
using GoDungeon.Equipment.Interfaces;
using GoDungeon.Equipment.Tables;

namespace GoDungeon.Tests.Equipment.Tables;

public partial class EquipmentTableTests
{
	[TestMethod]
	public void EquipmentAmmunitionTableTests()
	{
		IAmmunitionTable testTable = new AmmunitionTable();
		testTable.InitializeTable();
		Assert.IsTrue(testTable.Name == nameof(AmmunitionTable));
		Assert.IsTrue(testTable.ProperName == "Ammunition Table");
		Assert.IsTrue(testTable.Description == "Ammunition");
		Assert.IsTrue(testTable.Table.Count() == 4);
		foreach (var item in System.Enum.GetValues(typeof(AmmunitionEnum)))
		{
			IAmmunitionTableEntry entry = (IAmmunitionTableEntry) testTable.GetEntryByName(item.ToString());
			Assert.IsNotNull(entry, $"The Ammunition table has no entry for {item.ToString()}");
			var verify = VerifyAmmunitionTableEntry(item.ToString(), entry);
			Assert.IsTrue(verify == string.Empty, verify);
		}
	}

	/// <summary>
	/// Verify a entry in the IAmmunitionTable
	/// </summary>
	/// <param name="enumString">The name of the entry as a string</param>
	/// <param name="entry">The IAmmunitionTableEntry entry</param>
	/// <returns>Empty when no test fails, otherwise a failure string.</returns>
	private string VerifyAmmunitionTableEntry(string enumString, IAmmunitionTableEntry entry)
	{
		AmmunitionEnum enumValue;
		if (!System.Enum.TryParse(enumString, out enumValue))
		{
			return $"Unable to convert {enumString} to a AmmunitionTableEnum";
		}
		return string.Empty;
	}
}
