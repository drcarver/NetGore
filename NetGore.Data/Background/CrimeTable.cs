using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Background;

/// <summary>
/// If you have the Criminal social trait, roll on 
/// Table: Crime to determine the crime for which 
/// you were accused or convicted. After determining 
/// the crime, roll on Table: Punishment to learn 
/// the severity of the punishment you received—or 
/// have yet to receive—for having been judged guilty.
/// </summary>
public partial class BackgroundTables
{
    //Table: Crime
    //d%	Crime
    //01–10	Adultery
    //11–20	Arson
    //21–30	Burglary
    //31–40	Heresy
    //41–50	Minor offense(sumptuary law)
    //51–60	Murder
    //61–70	Rebellion/treason
    //71–80	Robbery
    //81–90	Smuggling
    //91–100	Unlawful use of magic
    /// <summary>
    /// Crime
    /// </summary>
    public static RandomTable CrimeTable { get; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Adultery"
            //01–10	Adultery
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 10,
                Name = nameof(CrimeEnum.Adultery),
            },
            #endregion

            #region "Arson"
            //11–20	Arson
            new RandomTableEntry
            {
                LowerRange = 11,
                UpperRange = 20,
                Name = nameof(CrimeEnum.Arson),
            },
            #endregion

            #region "Burglary"
            //21–30	Burglary
            new RandomTableEntry
            {
                LowerRange = 21,
                UpperRange = 30,
                Name = nameof(CrimeEnum.Burglary),
            },
            #endregion

            #region "Heresy"
            //31–40	Heresy
            new RandomTableEntry
            {
                LowerRange = 31,
                UpperRange = 40,
                Name = nameof(CrimeEnum.Heresy),
            },
            #endregion

            #region "Minor offense(sumptuary law)"
            //41–50	Minor offense(sumptuary law)
            new RandomTableEntry
            {
                LowerRange = 41,
                UpperRange = 50,
                Name = nameof(CrimeEnum.Minoroffense),
                ProperName = "Minor offense (sumptuary law)"
            },
            #endregion

            #region "Murder"
            //51–60	Murder
            new RandomTableEntry
            {
                LowerRange = 51,
                UpperRange = 60,
                Name = nameof(CrimeEnum.Murder),
            },
            #endregion

            #region "Rebellion/treason"
            //61–70	Rebellion/treason
            new RandomTableEntry
            {
                LowerRange = 61,
                UpperRange = 70,
                Name = nameof(CrimeEnum.RebellionorTreason),
                ProperName = "Rebellion or Treason",
            },
            #endregion

            #region "Robbery"
            //71–80	Robbery
            new RandomTableEntry
            {
                LowerRange = 71,
                UpperRange = 80,
                Name = nameof(CrimeEnum.Robbery),
            },
            #endregion

            #region "Smuggling"
            //81–90	Smuggling
            new RandomTableEntry
            {
                LowerRange = 81,
                UpperRange = 90,
                Name = nameof(CrimeEnum.Smuggling),
            },
            #endregion

            #region "Unlawful use of magic"
            //91–100	Unlawful use of magic
            new RandomTableEntry
            {
                LowerRange = 91,
                UpperRange = 100,
                Name = nameof(CrimeEnum.Unlawfuluseofmagic),
                ProperName = "Unlawful use of magic",
            },
            #endregion
        ]
    };
}
