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
    //Table: Punishment
    //d%	Punishment
    //01–10	Beating
    //11–20	Branding
    //21–30	Exile
    //31–40	Fine
    //41–50	Imprisonment
    //51–60	Stocks
    //61–70	Torture
    //71–80	Trial by combat
    //81–90	Trial by fire
    //91–100	Trial by water
    /// <summary>
    /// Punishment
    /// </summary>
    public static RandomTable PunishmentTable { get; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Beating"
            //01–10	Beating
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 10,
                Name = nameof(PunishmentEnum.Beating),
            },
            #endregion

            #region "Branding"
            //11–20	Branding
            new RandomTableEntry
            {
                LowerRange = 11,
                UpperRange = 20,
                Name = nameof(PunishmentEnum.Branding),
            },
            #endregion

            #region "Exile"
            //21–30	Exile
            new RandomTableEntry
            {
                LowerRange = 21,
                UpperRange = 30,
                Name = nameof(PunishmentEnum.Exile),
            },
            #endregion

            #region "Fine"
            //31–40	Fine
            new RandomTableEntry
            {
                LowerRange = 31,
                UpperRange = 40,
                Name = nameof(PunishmentEnum.Fine),
            },
            #endregion

            #region "Imprisonment"
            //41–50	Imprisonment
            new RandomTableEntry
            {
                LowerRange = 41,
                UpperRange = 50,
                Name = nameof(PunishmentEnum.Imprisonment),
            },
            #endregion

            #region "Stocks"
            //51–60	Stocks
            new RandomTableEntry
            {
                LowerRange = 51,
                UpperRange = 60,
                Name = nameof(PunishmentEnum.Stocks),
            },
            #endregion

            #region "Torture"
            //61–70	Torture
            new RandomTableEntry
            {
                LowerRange = 61,
                UpperRange = 70,
                Name = nameof(PunishmentEnum.Torture),
            },
            #endregion

            #region "Trial by combat"
            //71–80	Trial by combat
            new RandomTableEntry
            {
                LowerRange = 71,
                UpperRange = 80,
                Name = nameof(PunishmentEnum.Trialbycombat),
                ProperName = "Trial by combat",
            },
            #endregion

            #region "Trial by fire"
            //81–90	Trial by fire
            new RandomTableEntry
            {
                LowerRange = 81,
                UpperRange = 90,
                Name = nameof(PunishmentEnum.Trialbyfire),
                ProperName = "Trial by fire",
            },
            #endregion

            #region "Trial by water"
            //91–100 Trial by water
            new RandomTableEntry
            {
                LowerRange = 91,
                UpperRange = 100,
                Name = nameof(PunishmentEnum.Trialbywater),
                ProperName = "Trial by water",
            },
            #endregion
        ]
    };
}

