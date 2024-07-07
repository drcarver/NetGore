//
// Standard Exchange Rates
// Containing file adventuring\equipment\coins.md
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

using GoDungeon.Equipment.Interfaces;
using GoDungeon.Equipment.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Equipment.Tables;

/// <summary>
/// Standard Exchange Rates
/// </summary>
public partial class StandardExchangeRatesTable : NamedTable, IStandardExchangeRatesTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public StandardExchangeRatesTable()
	{
		Name = nameof(StandardExchangeRatesTable);
		ProperName = "Standard Exchange Rates Table";
		Description = "Standard Exchange Rates";
	}

	/// <summary>
	/// Initialize the table.  This is a separate method so
	/// we can create a game table for it's meta properties
	/// with out creating the actual table values.  A bit of
	/// optimization to conserve memory on big tables
	/// </summary>
	public override void InitializeTable()
	{
		if (Table == null || Table.Count == 0)
		{
			Table = new ObservableCollection<IGameTableEntry>()
			{
				#region Copper (cp)
				new StandardExchangeRatesTableEntryViewModel
				{
					Coin = "Copper (cp)",
					CP = 1,
					SP = "1/10",
					EP = "1/50",
					GP = "1/100",
					PP = "1/1,000",
				},
				#endregion

				#region Silver (sp)
				new StandardExchangeRatesTableEntryViewModel
				{
					Coin = "Silver (sp)",
					CP = 10,
					SP = "1",
					EP = "1/5",
					GP = "1/10",
					PP = "1/100",
				},
				#endregion

				#region Electrum (ep)
				new StandardExchangeRatesTableEntryViewModel
				{
					Coin = "Electrum (ep)",
					CP = 50,
					SP = "5",
					EP = "1",
					GP = "1/2",
					PP = "1/20",
				},
				#endregion

				#region Gold (gp)
				new StandardExchangeRatesTableEntryViewModel
				{
					Coin = "Gold (gp)",
					CP = 100,
					SP = "10",
					EP = "2",
					GP = "1",
					PP = "1/10",
				},
				#endregion

				#region Platinum (pp)
				new StandardExchangeRatesTableEntryViewModel
				{
					Coin = "Platinum (pp)",
					CP = 1000,
					SP = "100",
					EP = "20",
					GP = "10",
					PP = "1",
				},
				#endregion

			};
		}
	}
}
