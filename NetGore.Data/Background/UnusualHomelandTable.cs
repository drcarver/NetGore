﻿using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Background;

/// <summary>
/// You grew up in a region not typically associated 
/// with the lands that your people call home. Roll 
/// on Table: Unusual Homeland to determine the 
/// homeland of your family. If the result is one 
/// that is typical for your race, this region is 
/// one where there are few other members of your 
/// race, outside of your family.
/// </summary>
public partial class BackgroundTables
{
    //Table: Unusual Homeland
    //d%	Result
    //01–10	Subterranean You gain access to the Surface Stranger regional trait.
    //11–25	Mountains You gain access to the Highlander regional trait.
    //26–40	Plains You gain access to the Savanna Child regional trait.
    //41–50	Town or Village You gain access to the Militia Veteran regional trait.
    //51–60	City or Metropolis You gain access to the Civilized social trait and the Vagabond Child regional trait.
    //61–70	Forest You gain access to the Log Roller regional trait.
    //71–80	River, Swamp, or Wetlands   You gain access to the River Rat regional trait.
    //81–85	Desert You gain access to the Desert Child regional trait.
    //86–90	Sea You gain access to the Sea-Souled regional trait.
    //91–95	Tundra You gain access to the Tundra Child regional trait.
    //96–100	Another Plane   Your GM chooses the plane.You gain access to the Scholar of the Great Beyond faith trait    
    /// <summary>
    /// The Unusual Homeland Table
    /// </summary>
    public static RandomTable UnusualHomelandTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region Subterranean
            //01–10	Subterranean You gain access to
            //the Surface Stranger regional trait.
            new BackgroundTableEntry
            {
                LowerRange = 01,
                UpperRange = 10,
                Name = "Subterranean",
                Description =
                    "You gain access to the Surface " +
                    "Stranger regional trait.",
                RacialTraits =
                { 
                    RacialTraitEnum.SurfaceStranger,
                },   
            },
            #endregion

            #region Mountains
            //11–25	Mountains You gain access to the
            //Highlander regional trait.
            new BackgroundTableEntry
            {
                LowerRange = 11,
                UpperRange = 25,
                Name = "Mountains",
                Description =
                    "You gain access to the Highlander " +
                    "regional trait.",
                RacialTraits =
                {
                    RacialTraitEnum.Highlander,
                },
            },
            #endregion

            #region Plains
            //26–40	Plains You gain access to the
            //Savanna Child regional trait.
            new BackgroundTableEntry
            {
                LowerRange = 26,
                UpperRange = 40,
                Name = "Plains",
                Description =
                    "You gain access to the Savanna " +
                    "Child regional trait.",
                RacialTraits =
                {
                    RacialTraitEnum.SavannaChild,
                },
            },
            #endregion

            #region "Town or Village"
            //41–50	Town or Village You gain access
            //to the Militia Veteran regional trait.
            new BackgroundTableEntry
            {
                LowerRange = 41,
                UpperRange = 50,
                Name = "Town or Village",
                Description =
                    "You gain access to the Militia " +
                    "Veteran regional trait",
                RacialTraits =
                {
                    RacialTraitEnum.MilitiaVeteran,
                },
            },
            #endregion

            #region "City or Metropolis"
            //51–60	City or Metropolis You gain access
            //to the Civilized social trait and the
            //Vagabond Child regional trait.
            new BackgroundTableEntry
            {
                LowerRange = 51,
                UpperRange = 60,
                Name = "City or Metropolis",
                Description =
                    "You gain access to the Civilized " +
                    "social trait and the Vagabond " +
                    "Child regional trait.",
                RacialTraits =
                {
                    RacialTraitEnum.MilitiaVeteran,
                },
            },
            #endregion

            #region Forest
            //61–70	Forest You gain access to the
            //Log Roller regional trait.
            new BackgroundTableEntry
            {
                LowerRange = 61,
                UpperRange = 70,
                Name = "Forest",
                Description =
                    "You gain access to the Log Roller " +
                    "regional trait.",
                RacialTraits =
                {
                    RacialTraitEnum.LogRoller,
                },
            },
            #endregion

            #region "River, Swamp, or Wetlands"
            //71–80	River, Swamp, or Wetlands You gain
            //access to the River Rat regional trait.
            new BackgroundTableEntry
            {
                LowerRange = 71,
                UpperRange = 80,
                Name = "River, Swamp, or Wetlands",
                Description =
                    "You gain access to the River Rat regional trait.",
                RacialTraits =
                {
                    RacialTraitEnum.RiverRat,
                },
            },
            #endregion

            #region Desert
            //81–85	Desert You gain access to the
            //Desert Child regional trait.
            new BackgroundTableEntry
            {
                LowerRange = 81,
                UpperRange = 85,
                Name = "Desert",
                Description =
                    "You gain access to the Desert Child regional trait.",
                RacialTraits =
                {
                    RacialTraitEnum.DesertChild,
                },
            },
            #endregion

            #region Sea-Souled
            //86–90	Sea You gain access to the
            //Sea-Souled regional trait.
            new BackgroundTableEntry
            {
                LowerRange = 86,
                UpperRange = 90,
                Name = "Sea",
                Description =
                    "You gain access to the Sea-Souled regional trait.",
                RacialTraits =
                {
                    RacialTraitEnum.SeaSouled,
                },
            },
            #endregion

            #region Tundra
            //91–95	Tundra You gain access to the
            //Tundra Child regional trait.
            new BackgroundTableEntry
            {
                LowerRange = 91,
                UpperRange = 95,
                Name = "Tundra",
                Description =
                    "You gain access to the Tundra Child regional trait.",
                RacialTraits =
                {
                    RacialTraitEnum.TundraChild,
                },
            },
            #endregion

            #region "Another Plane"
            //96–100 Another Plane You gain access
            //to the Scholar of the Great Beyond
            //faith trait    
            new BackgroundTableEntry
            {
                LowerRange = 96,
                UpperRange = 100,
                Name = "Another Plane",
                Description =
                    "You gain access to the Scholar of the Great Beyond faith trait",
                RacialTraits =
                {
                    RacialTraitEnum.ScholaroftheGreatBeyond,
                },
            },
            #endregion
        ],
    };
}
