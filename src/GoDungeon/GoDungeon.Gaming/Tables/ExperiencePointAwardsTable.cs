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
    /// Determine the total XP award for the encounter by looking it 
    /// up by its CR on Table: Experience Point Awards.This gives 
    /// you an “XP budget” for the encounter. Every creature, trap, 
    /// and hazard is worth an amount of XP determined by its CR. 
    /// To build your encounter, simply add creatures, traps, 
    /// and hazards whose combined XP does not exceed the total 
    /// XP budget for your encounter. It’s easiest to add the 
    /// highest CR challenges to the encounter first, filling 
    /// out the remaining total with lesser challenges.
    /// </summary>
    public class ExperiencePointAwardsTable : NamedTable, IExperiencePointAwardsTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ExperiencePointAwardsTable()
        {
            Name = nameof(ExperiencePointAwardsTable);
            ProperName = "Experience Point Awards Table";
            TableType = TableTypeEnum.GamingTable;
            Description =
                "Determine the total XP award for the encounter by " +
                "looking it up by its CR. This gives you an “XP budget” " +
                "for the encounter. Every creature, trap, and hazard " +
                "is worth an amount of XP determined by its CR, " +
                "as noted on Table: Experience Point Awards. To build " +
                "your encounter, simply add creatures, traps, and " +
                "hazards whose combined XP does not exceed the " +
                "total XP budget for your encounter. It’s easiest " +
                "to add the highest CR challenges to the encounter " +
                "first, filling out the remaining total with lesser " +
                "challenges.";
        }

        //Table: Experience Point Awards
        //CR  Total XP    Individual XP
        //      Total    1-3 4-5	6+
        //1/8	50	    15	 15	    10
        //1/6	65	20	15	10
        //1/4	100	35	25	15
        //1/3	135	45	35	25
        //1/2	200	65	50	35
        //1	400	135	100	65
        //2	600	200	150	100
        //3	800	265	200	135
        //4	1,200	400	300	200
        //5	1,600	535	400	265
        //6	2,400	800	600	400
        //7	3,200	1,070	800	535
        //8	4,800	1,600	1,200	800
        //9	6,400	2,130	1,600	1,070
        //10	9,600	3,200	2,400	1,600
        //11	12,800	4,270	3,200	2,130
        //12	19,200	6,400	4,800	3,200
        //13	25,600	8,530	6,400	4,270
        //14	38,400	12,800	9,600	6,400
        //15	51,200	17,100	12,800	8,530
        //16	76,800	25,600	19,200	12,800
        //17	102,400	34,100	25,600	17,100
        //18	153,600	51,200	38,400	25,600
        //19	204,800	68,300	51,200	34,100
        //20	307,200	102,000	76,800	51,200
        //21	409,600	137,000	102,400	68,300
        //22	614,400	205,000	153,600	102,400
        //23	819,200	273,000	204,800	137,000
        //24	1,228,800	410,000	307,200	204,800
        //25	1,638,400	546,000	409,600	273,000
        //26	2,457,600	820,000	614,400	409,600
        //27	3,276,800	1,092,000	819,200	546,000
        //28	4,915,200	1,640,000	1,228,800	819,200
        //29	6,553,600	2,184,000	1,638,400	1,092,000
        //30	9,830,400	3,280,000	2,457,600	1,638,400
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
                    #region 1/8
                    //1/8	50	    15	 15	    10
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = Convert.ToDecimal(1 / 8),
                        TotalXP = 50,
                        Individual1to3XP = 15,
                        Individual4to5XP = 15,
                        Individual6PlusXP = 10
                    },
                    #endregion

                    #region 1/6
                    //1/6	65	20	15	10
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = Convert.ToDecimal(1 / 6),
                        TotalXP = 65,
                        Individual1to3XP = 20,
                        Individual4to5XP = 15,
                        Individual6PlusXP = 10
                    },
                    #endregion

                    #region 1/4
                    //1/4	100	35	25	15
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = Convert.ToDecimal(1 / 4),
                        TotalXP = 100,
                        Individual1to3XP = 35,
                        Individual4to5XP = 25,
                        Individual6PlusXP = 15
                    },
                    #endregion

                    #region 1/3
                    //1/3	135	45	35	25
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = Convert.ToDecimal(1 / 3),
                        TotalXP = 135,
                        Individual1to3XP = 45,
                        Individual4to5XP = 35,
                        Individual6PlusXP = 25
                    },
                    #endregion

                    #region 1/2
                    //1/2	200	65	50	35
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = Convert.ToDecimal(1 / 2),
                        TotalXP = 200,
                        Individual1to3XP = 65,
                        Individual4to5XP = 50,
                        Individual6PlusXP = 35
                    },
                    #endregion

                    #region 1
                    //1	400	135	100	65
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 1,
                        TotalXP = 400,
                        Individual1to3XP = 135,
                        Individual4to5XP = 100,
                        Individual6PlusXP = 65
                    },
                    #endregion

                    #region 2
                    //2	600	200	150	100
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 2,
                        TotalXP = 600,
                        Individual1to3XP = 200,
                        Individual4to5XP = 150,
                        Individual6PlusXP = 100
                    },
                    #endregion

                    #region 3
                    //3	800	265	200	135
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 3,
                        TotalXP = 800,
                        Individual1to3XP = 265,
                        Individual4to5XP = 200,
                        Individual6PlusXP = 135
                    },
                    #endregion

                    #region 4
                    //4	1,200	400	300	200
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 4,
                        TotalXP = 1200,
                        Individual1to3XP = 400,
                        Individual4to5XP = 300,
                        Individual6PlusXP = 200
                    },
                    #endregion

                    #region 5
                    //5	1,600	535	400	265
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 5,
                        TotalXP = 1600,
                        Individual1to3XP = 535,
                        Individual4to5XP = 400,
                        Individual6PlusXP = 265
                    },
                    #endregion

                    #region 6
                    //6	2,400	800	600	400
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 6,
                        TotalXP = 2400,
                        Individual1to3XP = 800,
                        Individual4to5XP = 600,
                        Individual6PlusXP = 400
                    },
                    #endregion

                    #region 7
                    //7	3,200	1,070	800	535
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 7,
                        TotalXP = 3200,
                        Individual1to3XP = 1070,
                        Individual4to5XP = 800,
                        Individual6PlusXP = 535
                    },
                    #endregion

                    #region 8
                    //8	4,800	1,600	1,200	800
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 8,
                        TotalXP = 4800,
                        Individual1to3XP = 1600,
                        Individual4to5XP = 1200,
                        Individual6PlusXP = 800
                    },
                    #endregion

                    #region 9
                    //9	6,400	2,130	1,600	1,070
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 9,
                        TotalXP = 6400,
                        Individual1to3XP = 2130,
                        Individual4to5XP = 1600,
                        Individual6PlusXP = 1070
                    },
                    #endregion

                    #region 10
                    //10	9,600	3,200	2,400	1,600
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 10,
                        TotalXP = 9600,
                        Individual1to3XP = 3200,
                        Individual4to5XP = 2400,
                        Individual6PlusXP = 1600
                    },
                    #endregion

                    #region 11
                    //11	12,800	4,270	3,200	2,130
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 11,
                        TotalXP = 12800,
                        Individual1to3XP = 4270,
                        Individual4to5XP = 3200,
                        Individual6PlusXP = 2130
                    },
                    #endregion

                    #region 12
                    //12	19,200	6,400	4,800	3,200
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 12,
                        TotalXP = 19200,
                        Individual1to3XP = 6400,
                        Individual4to5XP = 4800,
                        Individual6PlusXP = 3200
                    },
                    #endregion

                    #region 13
                    //13	25,600	8,530	6,400	4,270
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 13,
                        TotalXP = 25600,
                        Individual1to3XP = 8530,
                        Individual4to5XP = 6400,
                        Individual6PlusXP = 4270
                    },
                    #endregion

                    #region 14
                    //14	38,400	12,800	9,600	6,400
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 14,
                        TotalXP = 38400,
                        Individual1to3XP = 12800,
                        Individual4to5XP = 9600,
                        Individual6PlusXP = 6400
                    },
                    #endregion

                    #region 15
                    //15	51,200	17,100	12,800	8,530
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 15,
                        TotalXP = 51200,
                        Individual1to3XP = 17100,
                        Individual4to5XP = 12800,
                        Individual6PlusXP = 8530
                    },
                    #endregion

                    #region 16
                    //16	76,800	25,600	19,200	12,800
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 16,
                        TotalXP = 76800,
                        Individual1to3XP = 25600,
                        Individual4to5XP = 19200,
                        Individual6PlusXP = 12800
                    },
                    #endregion

                    #region 17
                    //17	102,400	34,100	25,600	17,100
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 17,
                        TotalXP = 102400,
                        Individual1to3XP = 34100,
                        Individual4to5XP = 25600,
                        Individual6PlusXP = 17100
                    },
                    #endregion

                    #region 18
                    //18	153,600	51,200	38,400	25,600
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 18,
                        TotalXP = 153600,
                        Individual1to3XP = 51200,
                        Individual4to5XP = 38400,
                        Individual6PlusXP = 25600
                    },
                    #endregion

                    #region 19
                    //19	204,800	68,300	51,200	34,100
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 19,
                        TotalXP = 204800,
                        Individual1to3XP = 68300,
                        Individual4to5XP = 51200,
                        Individual6PlusXP = 34100
                    },
                    #endregion

                    #region 20
                    //20	307,200	102,000	76,800	51,200
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 20,
                        TotalXP = 307200,
                        Individual1to3XP = 102000,
                        Individual4to5XP = 76800,
                        Individual6PlusXP = 51200
                    },
                    #endregion

                    #region 21
                    //21	409,600	137,000	102,400	68,300
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 21,
                        TotalXP = 409600,
                        Individual1to3XP = 137000,
                        Individual4to5XP = 102400,
                        Individual6PlusXP = 68300
                    },
                    #endregion

                    #region 22
                    //22	614,400	205,000	153,600	102,400
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 22,
                        TotalXP = 614400,
                        Individual1to3XP = 205000,
                        Individual4to5XP = 153600,
                        Individual6PlusXP = 102400
                    },
                    #endregion

                    #region 23
                    //23	819,200	273,000	204,800	137,000
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 23,
                        TotalXP = 819200,
                        Individual1to3XP = 273000,
                        Individual4to5XP = 204800,
                        Individual6PlusXP = 137000
                    },
                    #endregion

                    #region 24
                    //24	1,228,800	410,000	307,200	204,800
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 24,
                        TotalXP = 1228800,
                        Individual1to3XP = 410000,
                        Individual4to5XP = 307200,
                        Individual6PlusXP = 204800
                    },
                    #endregion

                    #region 25
                    //25	1,638,400	546,000	409,600	273,000
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 25,
                        TotalXP = 1638400,
                        Individual1to3XP = 546000,
                        Individual4to5XP = 409600,
                        Individual6PlusXP = 273000
                    },
                    #endregion

                    #region 26
                    //26	2,457,600	820,000	614,400	409,600
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 26,
                        TotalXP = 2457600,
                        Individual1to3XP = 820000,
                        Individual4to5XP = 614400,
                        Individual6PlusXP = 409600
                    },
                    #endregion

                    #region 27
                    //27	3,276,800	1,092,000	819,200	546,000
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 27,
                        TotalXP = 3276800,
                        Individual1to3XP = 1092000,
                        Individual4to5XP = 819200,
                        Individual6PlusXP = 546000
                    },
                    #endregion

                    #region 28
                    //28	4,915,200	1,640,000	1,228,800	819,200
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 28,
                        TotalXP = 4915200,
                        Individual1to3XP = 1640000,
                        Individual4to5XP = 1228800,
                        Individual6PlusXP = 819200
                    },
                    #endregion

                    #region 29
                    //29	6,553,600	2,184,000	1,638,400	1,092,000
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 29,
                        TotalXP = 6553600,
                        Individual1to3XP = 2184000,
                        Individual4to5XP = 1638400,
                        Individual6PlusXP = 1092000
                    },
                    #endregion

                    #region 30
                    //30	9,830,400	3,280,000	2,457,600	1,638,400
                    new ExperiencePointAwardEntryViewModel
                    {
                        ChallengeRating = 30,
                        TotalXP = 9830400,
                        Individual1to3XP = 3280000,
                        Individual4to5XP = 2457600,
                        Individual6PlusXP = 138400
                    },
                    #endregion
                };
            }
        }
    }
}
