//
// Trade Goods
// Containing file adventuring\equipment\trade_goods.md
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

using GoDungeon.Equipment.Enum;
using GoDungeon.Equipment.Interfaces;
using GoDungeon.Equipment.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Equipment.Tables;

/// <summary>
/// Trade Goods
/// </summary>
public partial class TradeGoodsTable : NamedTable, ITradeGoodsTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public TradeGoodsTable()
	{
		Name = nameof(TradeGoodsTable);
		ProperName = "Trade Goods Table";
		Description = "Trade Goods";
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
				#region 1 cp
				new TradeGoodsTableEntryViewModel
				{
					Goods = "1 lb. of wheat",
				},
				#endregion

				#region 2 cp
				new TradeGoodsTableEntryViewModel
				{
					Goods = "1 lb. of flour or one chicken",
				},
				#endregion

				#region 5 cp
				new TradeGoodsTableEntryViewModel
				{
					Goods = "1 lb. of salt",
				},
				#endregion

				#region 1 sp
				new TradeGoodsTableEntryViewModel
				{
					Goods = "1 lb. of iron or 1 sq. yd. of canvas",
				},
				#endregion

				#region 5 sp
				new TradeGoodsTableEntryViewModel
				{
					Goods = "1 lb. of copper of 1 sq. yd. of cotton cloth",
				},
				#endregion

				#region 1 gp
				new TradeGoodsTableEntryViewModel
				{
					Goods = "1 lb. of ginger or one goat",
				},
				#endregion

				#region 2 gp
				new TradeGoodsTableEntryViewModel
				{
					Goods = "1 lb. of cinnamon or pepper, or one sheep",
				},
				#endregion

				#region 3 gp
				new TradeGoodsTableEntryViewModel
				{
					Goods = "1 lb. of cloves or one pig",
				},
				#endregion

				#region 5 gp
				new TradeGoodsTableEntryViewModel
				{
					Goods = "1 lb. of silver or 1 sq. yd. of linen",
				},
				#endregion

				#region 10 gp
				new TradeGoodsTableEntryViewModel
				{
					Goods = "1 sq. yd. of silk or one cow",
				},
				#endregion

				#region 15 gp
				new TradeGoodsTableEntryViewModel
				{
					Goods = "1 lb. of saffron or one ox",
				},
				#endregion

				#region 50 gp
				new TradeGoodsTableEntryViewModel
				{
					Goods = "1 lb. of gold",
				},
				#endregion

				#region 500 gp
				new TradeGoodsTableEntryViewModel
				{
					Goods = "1 lb. of platinum",
				},
				#endregion

			};
		}
	}
}
