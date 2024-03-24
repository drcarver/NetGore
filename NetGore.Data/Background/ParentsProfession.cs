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
    /// <summary>
    /// Parents’ Profession
    /// </summary>
    public static RandomTable ParentsProfession { get; } = new()
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
                Name = "Slaves",
                Description =
                    "You gain access to the Life of Toil social " +
                    "trait.",
                RacialTraits =
                {
                    RacialTraitEnum.LifeofToil,
                },
            },
            #endregion
        ]
    };
}
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
