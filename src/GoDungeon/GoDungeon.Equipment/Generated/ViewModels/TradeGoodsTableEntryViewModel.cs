//
// Trade Goods view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Trade Goods
/// </summary>
public partial class TradeGoodsTableEntryViewModel : StandardTableEntryViewModel, ITradeGoodsTableEntry
{
	/// <summary>
	/// Cost
	/// </summary>
	[ObservableProperty]
	private CostViewModel cost;

	/// <summary>
	/// Goods
	/// </summary>
	[ObservableProperty]
	private string goods;

}
