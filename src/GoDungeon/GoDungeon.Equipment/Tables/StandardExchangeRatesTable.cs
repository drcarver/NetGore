using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Equipment.Interfaces;
using GoDungeon.Equipment.ViewModels;

namespace GoDungeon.Equipment.Tables
{
    public class StandardExchangeRatesTable : NamedTable, IStandardExchangeRatesTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public StandardExchangeRatesTable()
        {
            Name = nameof(StandardExchangeRatesTable);
            ProperName = "Standard Exchange Rates Table";
            TableType = TableTypeEnum.EquipmentTable;
            Description =
                "Common coins come in several different " +
                "denominations based on the relative worth of the " +
                "metal from which they are made.The three most " +
                "common coins are the gold piece (gp), the silver " +
                "piece (sp), and the copper piece (cp).";
        }

        /// <summary>
        /// Initialize the game table.  This is a separate method so 
        /// we can create a game table for it's meta properties
        /// with out creating the actual able values.  A bit of 
        /// optimization to conserve memory on big tables
        /// </summary>
        public override void InitializeTable()
        {
            if (Table == null || Table.Count == 0)
            {
                Table = new ObservableCollection<IGameTableEntry>
                {
                    #region Copper
                    //Copper(cp) 1 1/10 1/50 1/100 1/1,000
                    new StandardExchangeRatesEntryViewModel
                    {
                        Coin = new CopperPieceViewModel(),
                        CopperRate = 1,
                        SilverRate = 1 / 10,
                        ElectrumRate = 1 / 50,
                        GoldRate = 1 / 100,
                        PlatinumRate = 1 / 1000,
                    },
                    #endregion

                    #region Silver
                    //Silver(sp) 10 1 1/5 1/10 1/100
                    new StandardExchangeRatesEntryViewModel
                    {
                        Coin = new SilverPieceViewModel(),
                        CopperRate = 10,
                        SilverRate = 1,
                        ElectrumRate = 1 / 5,
                        GoldRate = 1 / 10,
                        PlatinumRate = 1 / 100,
                    },
                    #endregion

                    #region Electrum
                    //Electrum(ep) 50 5 1 1/2 1/20
                    new StandardExchangeRatesEntryViewModel
                    {
                        Coin = new ElectrumPieceViewModel(),
                        CopperRate = 50,
                        SilverRate = 5,
                        ElectrumRate = 1,
                        GoldRate = 1 / 2,
                        PlatinumRate = 1 / 20,
                    },
                    #endregion

                    #region Gold
                    //Gold(gp) 100 10 2 1 1/10
                    new StandardExchangeRatesEntryViewModel
                    {
                        Coin = new GoldPieceViewModel(),
                        CopperRate = 100,
                        SilverRate = 10,
                        ElectrumRate = 2,
                        GoldRate = 1,
                        PlatinumRate = 1 / 10,
                    },
                    #endregion

                    #region Platinum
                    //Platinum(pp) 1,000 100 20 10 1
                    new StandardExchangeRatesEntryViewModel
                    {
                        Coin = new PlatinumPieceVewModel(),
                        CopperRate = 1000,
                        SilverRate = 100,
                        ElectrumRate = 20,
                        GoldRate = 10,
                        PlatinumRate = 1,
                    },
                    #endregion
                };
            }
        }
    }
}
