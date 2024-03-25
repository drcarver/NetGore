using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Background;

/// <summary>
/// Most of the time, your parents both come from 
/// the same social stratum. It’s uncommon, but 
/// not unheard of, for people to marry outside 
/// their caste. Roll on Table: Parent’s Profession 
/// to determine the principal profession of your 
/// parents.
/// </summary>
public partial class BackgroundTables
{
    //Table: Parents’ Profession
    //d%	Result
    //01–05	Slaves You gain access to the Life of Toil social trait.
    //06–25	Serfs/Peasants You gain access to the Poverty-Stricken social trait.
    //26–30	Entertainers You gain access to the Talented social trait.
    //31–34	Soldiers You gain access to the Tactician combat trait.
    //35–37	Sailors You gain access to the Worldly social trait.
    //38–40	Thieves You gain access to the Child of the Streets social trait.
    //41–55	Yeomen You gain access to the Savanna Child regional trait.
    //56–70	Tradespeople You gain access to the Artisan social trait and the Life of Toil social trait.
    //71–85	Artisans You gain access to the Artisan social trait.
    //86–95	Merchants You gain access to the Merchant social trait.
    //96–100	Clergy or Cultists You gain access to the Child of the Temple faith trait.}
    /// <summary>
    /// Parents’ Profession
    /// </summary>
    public static RandomTable ParentsProfessionTable { get; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Slaves"
            //01–05	Slaves You gain access to the Life of Toil social trait.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 05,
                Name = nameof(ProfessionEnum.Slaves),
                Description =
                    "You gain access to the Life of Toil social " +
                    "trait.",
                RacialTraits =
                {
                    RacialTraitEnum.LifeofToil,
                },
            },
            #endregion

            #region "Serfs/Peasants"
            //06–25	Serfs/Peasants You gain access to the Poverty-Stricken social trait.
            new RandomTableEntry
            {
                LowerRange = 06,
                UpperRange = 25,
                Name = nameof(ProfessionEnum.SerfsPeasants),
                ProperName = "Serfs/Peasants",
                Description =
                    "You gain access to the " +
                    "Poverty-Stricken social trait.",
                RacialTraits =
                {
                    RacialTraitEnum.PovertyStricken,
                },
            },
            #endregion

            #region "Entertainers"
            //26–30	Entertainers You gain access to the Talented social trait.
            new RandomTableEntry
            {
                LowerRange = 26,
                UpperRange = 30,
                Name = nameof(ProfessionEnum.Entertainers),
                Description =
                    "You gain access to the Talented social trait.",
                RacialTraits =
                {
                    RacialTraitEnum.Talented,
                },
            },
            #endregion

            #region "Soldiers"
            //31–34	Soldiers You gain access to the Tactician combat trait.
            new RandomTableEntry
            {
                LowerRange = 31,
                UpperRange = 34,
                Name = nameof(ProfessionEnum.Soldiers),
                Description =
                    "You gain access to the Tactician combat trait.",
                RacialTraits =
                {
                    RacialTraitEnum.Tactician,
                },
            },
            #endregion

            #region "Sailors"
            //35–37	Sailors You gain access to the Worldly social trait.
            new RandomTableEntry
            {
                LowerRange = 35,
                UpperRange = 37,
                Name = nameof(ProfessionEnum.Sailors),
                Description =
                    "You gain access to the Worldly social trait.",
                RacialTraits =
                {
                    RacialTraitEnum.Worldly,
                },
            },
            #endregion

            #region "Thieves"
            //38–40	Thieves You gain access to the Child of the Streets social trait.
            new RandomTableEntry
            {
                LowerRange = 38,
                UpperRange = 40,
                Name = nameof(ProfessionEnum.Thieves),
                Description =
                    "You gain access to the Child of " +
                    "the Streets social trait.",
                RacialTraits =
                {
                    RacialTraitEnum.ChildoftheStreets,
                },
            },
            #endregion

            #region "Yeomen"
            //41–55	Yeomen You gain access to the Savanna Child regional trait.
            new RandomTableEntry
            {
                LowerRange = 41,
                UpperRange = 55,
                Name = nameof(ProfessionEnum.Yeomen),
                Description =
                    "You gain access to the " +
                    "Savanna Child regional trait.",
                RacialTraits =
                {
                    RacialTraitEnum.SavannaChild,
                },
            },
            #endregion

            #region "Tradespeople"
            //56–70	Tradespeople You gain access to the Artisan social trait and the Life of Toil social trait.
            new RandomTableEntry
            {
                LowerRange = 56,
                UpperRange = 70,
                Name = nameof(ProfessionEnum.Tradespeople),
                Description =
                    "You gain access to the Artisan " +
                    "social trait and the Life of Toil " +
                    "social trait.",
                RacialTraits =
                {
                    RacialTraitEnum.Artisan,
                    RacialTraitEnum.LifeofToil,
                },
            },
            #endregion

            #region "Merchants"
            //86–95	Merchants You gain access to the Merchant social trait.
            new RandomTableEntry
            {
                LowerRange = 86,
                UpperRange = 96,
                Name = nameof(ProfessionEnum.Merchants),
                Description =
                    "You gain access to the Merchant social trait.",
                RacialTraits =
                {
                    RacialTraitEnum.Merchant,
                },
            },
            #endregion

            #region "Clergy or Cultists"
            //96–100 Clergy or Cultists You gain access to the Child of the Temple faith trait.
            new RandomTableEntry
            {
                LowerRange = 96,
                UpperRange = 100,
                Name = nameof(ProfessionEnum.ClergyorCultists),
                ProperName = "Clergy or Cultists",
                Description =
                    "You gain access to the Child of " +
                    "the Temple faith trait.",
                RacialTraits =
                {
                    RacialTraitEnum.ChildoftheTemple,
                },
            },
            #endregion
        ]
    };
}
