using System;
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Gaming.Interfaces;
using GoDungeon.Gaming.ViewModels;

namespace GoDungeon.Gaming.Tables
{
    /// <summary>
    /// This table lists the amount of treasure each encounter 
    /// should award based on the average level of the PCs and 
    /// the speed of the campaign’s XP progression (slow, 
    /// medium, or fast). Easy encounters should award treasure 
    /// one level lower than the PCs’ average level. Challenging, 
    /// hard, and epic encounters should award treasure one, 
    /// two, or three levels higher than the PCs’ average level, 
    /// respectively. If you are running a low-fantasy game, cut 
    /// these values in half.  If you are running a high-fantasy 
    /// game, double these values.
    /// </summary>
    public class TreasureValuesPerEncounterTable : GameTable, ITreasureValuesPerEncounterTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public TreasureValuesPerEncounterTable()
        {
            Name = nameof(TreasureValuesPerEncounterTable);
            ProperName = "Treasure Values Per Encounter Table";
            TableType = TableTypeEnum.GamingTable;
            Description =
                "This table lists the amount of treasure each " +
                "encounter should award based on the average " +
                "level of the PCs and the speed of the campaign’s " +
                "XP progression (slow, medium, or fast). Easy " +
                "encounters should award treasure one level " +
                "lower than the PCs’ average level. Challenging, " +
                "hard, and epic encounters should award treasure " +
                "one, two, or three levels higher than the PCs’ " +
                "average level, respectively. If you are running " +
                "a low-fantasy game, cut these values in half. " +
                "If you are running a high-fantasy game, double " +
                "these values.";
        }

        //Table: Treasure Values per Encounter
        //CR Treasure per Encounter
        //Slow Medium  Fast
        //1/8	20 gp	35 gp	50 gp
        //1/6	30 gp	45 gp	65 gp
        //1/4	40 gp	65 gp	100 gp
        //1/3	55 gp	85 gp	135 gp
        //1/2	85 gp	130 gp	200 gp
        //1	170 gp	260 gp	400 gp
        //2	350 gp	550 gp	800 gp
        //3	550 gp	800 gp	1,200 gp
        //4	750 gp	1,150 gp	1,700 gp
        //5	1,000 gp	1,550 gp	2,300 gp
        //6	1,350 gp	2,000 gp	3,000 gp
        //7	1,750 gp	2,600 gp	3,900 gp
        //8	2,200 gp	3,350 gp	5,000 gp
        //9	2,850 gp	4,250 gp	6,400 gp
        //10	3,650 gp	5,450 gp	8,200 gp
        //11	4,650 gp	7,000 gp	10,500 gp
        //12	6,000 gp	9,000 gp	13,500 gp
        //13	7,750 gp	11,600 gp	17,500 gp
        //14	10,000 gp	15,000 gp	22,000 gp
        //15	13,000 gp	19,500 gp	29,000 gp
        //16	16,500 gp	25,000 gp	38,000 gp
        //17	22,000 gp	32,000 gp	48,000 gp
        //18	28,000 gp	41,000 gp	62,000 gp
        //19	35,000 gp	53,000 gp	79,000 gp
        //20	44,000 gp	67,000 gp	100,000 gp
        //21	55,000 gp	84,000 gp	125,000 gp
        //22	69,000 gp	104,000 gp	155,000 gp
        //23	85,000 gp	127,000 gp	190,000 gp
        //24	102,000 gp	155,000 gp	230,000 gp
        //25	125,000 gp	185,000 gp	275,000 gp
        //26	150,000 gp	220,000 gp	330,000 gp
        //27	175,000 gp	260,000 gp	390,000 gp
        //28	205,000 gp	305,000 gp	460,000 gp
        //29	240,000 gp	360,000 gp	540,000 gp
        //30	280,000 gp	420,000 gp	630,000 gp
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
                    #region ChallengeRating = 1/8
                    //1/8	20 gp	35 gp	50 gp
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = Convert.ToDecimal(1 / 8),
                        Slow = 20,
                        Medium = 35,
                        Fast = 50,
                    },
                    #endregion

                    #region ChallengeRating = 1/6
                    //1/6	30 gp	45 gp	65 gp
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = Convert.ToDecimal(1 / 6),
                        Slow = 30,
                        Medium = 45,
                        Fast = 65,
                    },
                    #endregion

                    #region ChallengeRating = 1/4
                    //1/4	40 gp	65 gp	100 gp
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = Convert.ToDecimal(1 / 4),
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region ChallengeRating = 1/3
                    //1/3	55 gp	85 gp	135 gp
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = Convert.ToDecimal(1 / 3),
                        Slow = 55,
                        Medium = 85,
                        Fast = 135,
                    },
                    #endregion

                    #region ChallengeRating = 1/2
                    //1/2	85 gp	130 gp	200 gp
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = Convert.ToDecimal(1 / 2),
                        Slow = 85,
                        Medium = 130,
                        Fast = 200,
                    },
                    #endregion

                    #region ChallengeRating = 1
                    //1	170 gp	260 gp	400 gp
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 1,
                        Slow = 170,
                        Medium = 260,
                        Fast = 400,
                    },
                    #endregion

                    #region ChallengeRating = 2
                    //2	350 gp	550 gp	800 gp
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 2,
                        Slow = 350,
                        Medium = 550,
                        Fast = 800,
                    },
                    #endregion

                    #region ChallengeRating = 3
                    //3	550 gp	800 gp	1,200 gp
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 3,
                        Slow = 550,
                        Medium = 800,
                        Fast = 1200,
                    },
                    #endregion
            
                    #region ChallengeRating = 4
                    //4	750 gp	1,150 gp	1,700 gp
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 4,
                        Slow = 750,
                        Medium = 1150,
                        Fast = 1700,
                    },
                    #endregion

                    #region ChallengeRating = 5
                    //5	1,000 gp	1,550 gp	2,300 gp
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 5,
                        Slow = 1000,
                        Medium = 1550,
                        Fast = 2300,
                    },
                    #endregion

                    #region ChallengeRating = 6
                    //6	1,350 gp	2,000 gp	3,000 gp
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 6,
                        Slow = 1350,
                        Medium = 2000,
                        Fast = 3000,
                    },
                    #endregion

                    #region ChallengeRating = 7
                    //7	1,750 gp	2,600 gp	3,900 gp
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 7,
                        Slow = 1750,
                        Medium = 2600,
                        Fast = 3900,
                    },
                    #endregion

                    #region ChallengeRating = 8
                    //8	2,200 gp	3,350 gp	5,000 gp
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 8,
                        Slow = 2200,
                        Medium = 3350,
                        Fast = 5000,
                    },
                    #endregion

                    #region 9
                    //9	6,400	2,130	1,600	1,070
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 9,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 10
                    //10	9,600	3,200	2,400	1,600
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 10,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 11
                    //11	12,800	4,270	3,200	2,130
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 11,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 12
                    //12	19,200	6,400	4,800	3,200
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 12,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 13
                    //13	25,600	8,530	6,400	4,270
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 13,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 14
                    //14	38,400	12,800	9,600	6,400
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 14,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 15
                    //15	51,200	17,100	12,800	8,530
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 15,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 16
                    //16	76,800	25,600	19,200	12,800
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 16,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 17
                    //17	102,400	34,100	25,600	17,100
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 17,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 18
                    //18	153,600	51,200	38,400	25,600
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 18,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 19
                    //19	204,800	68,300	51,200	34,100
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 19,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 20
                    //20	307,200	102,000	76,800	51,200
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 20,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 21
                    //21	409,600	137,000	102,400	68,300
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 21,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 22
                    //22	614,400	205,000	153,600	102,400
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 22,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 23
                    //23	819,200	273,000	204,800	137,000
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 23,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 24
                    //24	1,228,800	410,000	307,200	204,800
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 24,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 25
                    //25	1,638,400	546,000	409,600	273,000
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 25,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 26
                    //26	2,457,600	820,000	614,400	409,600
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 26,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 27
                    //27	3,276,800	1,092,000	819,200	546,000
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 27,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 28
                    //28	4,915,200	1,640,000	1,228,800	819,200
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 28,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 29
                    //29	6,553,600	2,184,000	1,638,400	1,092,000
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 29,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion

                    #region 30
                    //30	9,830,400	3,280,000	2,457,600	1,638,400
                    new TreasureValuesPerEncounterEntryViewModel
                    {
                        ChallengeRating = 30,
                        Slow = 40,
                        Medium = 65,
                        Fast = 100,
                    },
                    #endregion
                };
            }
        }
    }
}
