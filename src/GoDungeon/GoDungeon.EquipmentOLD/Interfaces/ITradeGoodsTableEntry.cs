//
// Trade Goods view model interface
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.Interfaces;

/// <summary>
/// ITrade Goods
/// </summary>
public interface ITradeGoodsTableEntry : IStandardTableEntry
{
	/// <summary>
	/// Cost
	/// </summary>
	public string Cost { get; set; }

	/// <summary>
	/// Goods
	/// </summary>
	public string Goods { get; set; }

}
