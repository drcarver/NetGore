using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Background;

/// <summary>
/// As a person of noble rank, you have access to 
/// a degree of wealth, privilege, or influence 
/// beyond that of the common people. If your 
/// character is of noble birth (and comes 
/// from a society where the nobility uses a 
/// traditional structure of rank), roll on 
/// Table: Nobility to learn your parents’ 
/// position among the ruling class.
/// </summary>
public partial class BackgroundTables
{
    //Table: Nobility
    //d%	Result
    //01–60	Gentry You are the child of a minor lord, lady, or noble with an income, hereditary land such as a manor, and titles.You likely grew up in a manor and your parents were paid tribute by peasants.Your parents serve a higher baron, count, or duke.
    //61–78	Knight You are the child of a knight, a noble with estates, titles, and lands who serves a lord. Your family has sworn an oath of fealty to a liege—such as a baron, count, or duke—and commits to military service in his or her name. As the child of a knight, you may serve as a squire to another knight while pursuing your own path to knighthood.
    //79–85	Baron You are the child of a baron or baroness, a noble responsible for a land encompassing several smaller manors that pay tribute.Your parents receive orders directly from the monarch, and you’re expected to attend the royal court.You are entitled to hereditary estates, titles, and land.
    //86–91	Count You are the noble child of a count or countess.Your family members receive hereditary titles, land, and estates, and are among the most wealthy nobles in your domain. Knights and minor lords pay tribute to your family, and your parents attend directly to the monarch. You’re expected to attend the royal court.
    //92–96	Duke You are the child of a duke or duchess, the most powerful noble in the realm apart from the royal family.Your parents attend directly to the monarch and have the highest place at court. Your lands, titles, and estates are significant, and many lords and knights serve under your parents’ command.
    //97–99	Minor Prince    You are the child of a prince or princess, and part of the royal family. You aren’t the next in succession, but your power and wealth are grand indeed.
    //100	Regent You are a prince or princess, the son or daughter of the monarch.You owe fealty directly to your parents, and to no one else. Few command the power and wealth you do, and your presence inspires great respect, if not total awe, among those who kneel before the crown
    /// <summary>
    /// Nobility
    /// </summary>
    public static RandomTable NobilityTable { get; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Gentry"
            //01–60	Gentry You are the child of a minor lord, lady, or noble with an income, hereditary land such as a manor, and titles.You likely grew up in a manor and your parents were paid tribute by peasants.Your parents serve a higher baron, count, or duke.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 60,
                Name = nameof(NobilityEnum.Gentry),
                Description =
                    "You are the child of a minor " +
                    "lord, lady, or noble with an " +
                    "income, hereditary land such " +
                    "as a manor, and titles. You " +
                    "likely grew up in a manor and " +
                    "your parents were paid tribute " +
                    "by peasants. Your parents serve " +
                    "a higher baron, count, or duke.",
            },
            #endregion

            #region "Knight"
            //61–78	Knight You are the child of a knight, a noble with estates, titles, and lands who serves a lord. Your family has sworn an oath of fealty to a liege—such as a baron, count, or duke—and commits to military service in his or her name. As the child of a knight, you may serve as a squire to another knight while pursuing your own path to knighthood.
            new RandomTableEntry
            {
                LowerRange = 61,
                UpperRange = 78,
                Name = nameof(NobilityEnum.Knight),
                Description =
                    "You are the child of a knight, " +
                    "a noble with estates, titles, " +
                    "and lands who serves a lord. " +
                    "Your family has sworn an oath " +
                    "of fealty to a liege—such as " +
                    "a baron, count, or duke—and " +
                    "commits to military service in " +
                    "his or her name. As the child of " +
                    "a knight, you may serve as a " +
                    "squire to another knight while " +
                    "pursuing your own path to " +
                    "knighthood.",
            },
            #endregion

            #region "Baron"
            //79–85	Baron You are the child of a baron or baroness, a noble responsible for a land encompassing several smaller manors that pay tribute.Your parents receive orders directly from the monarch, and you’re expected to attend the royal court.You are entitled to hereditary estates, titles, and land.
            new RandomTableEntry
            {
                LowerRange = 79,
                UpperRange = 85,
                Name = nameof(NobilityEnum.Baron),
                Description =
                    "You are the child of a baron or " +
                    "baroness, a noble responsible " +
                    "for a land encompassing several " +
                    "smaller manors that pay tribute. " +
                    "Your parents receive orders " +
                    "directly from the monarch, and " +
                    "you’re expected to attend the " +
                    "royal court. You are entitled " +
                    "to hereditary estates, titles, " +
                    "and land.",
            },
            #endregion

            #region "Count"
            //86–91	Count You are the noble child of a count or countess.Your family members receive hereditary titles, land, and estates, and are among the most wealthy nobles in your domain. Knights and minor lords pay tribute to your family, and your parents attend directly to the monarch. You’re expected to attend the royal court.
            new RandomTableEntry
            {
                LowerRange = 68,
                UpperRange = 91,
                Name = nameof(NobilityEnum.Count),
                Description =
                    "You are the noble child of a " +
                    "count or countess.Your family " +
                    "members receive hereditary " +
                    "titles, land, and estates, and " +
                    "are among the most wealthy " +
                    "nobles in your domain. Knights " +
                    "and minor lords pay tribute to " +
                    "your family, and your parents " +
                    "attend directly to the monarch. " +
                    "You’re expected to attend the " +
                    "royal court.",
            },
            #endregion

            #region "Duke"
            //92–96	Duke You are the child of a duke or duchess, the most powerful noble in the realm apart from the royal family.Your parents attend directly to the monarch and have the highest place at court. Your lands, titles, and estates are significant, and many lords and knights serve under your parents’ command.
            new RandomTableEntry
            {
                LowerRange = 92,
                UpperRange = 96,
                Name = nameof(NobilityEnum.Duke),
                Description =
                    "You are the child of a duke or " +
                    "duchess, the most powerful noble " +
                    "in the realm apart from the royal " +
                    "family. Your parents attend " +
                    "directly to the monarch and " +
                    "have the highest place at court. " +
                    "Your lands, titles, and estates " +
                    "are significant, and many lords " +
                    "and knights serve under your " +
                    "parents’ command.",
            },
            #endregion

            #region "Minor Prince"
            //97–99	Minor Prince You are the child of a prince or princess, and part of the royal family. You aren’t the next in succession, but your power and wealth are grand indeed.
            new RandomTableEntry
            {
                LowerRange = 97,
                UpperRange = 99,
                Name = nameof(NobilityEnum.MinorPrince),
                ProperName = "Minor Prince",
                Description =
                    "You are the child of a prince " +
                    "or princess, and part of the " +
                    "royal family. You aren’t the " +
                    "next in succession, but your " +
                    "power and wealth are grand indeed.",
            },
            #endregion

            #region "Regent"
            //100	Regent You are a prince or princess, the son or daughter of the monarch.You owe fealty directly to your parents, and to no one else. Few command the power and wealth you do, and your presence inspires great respect, if not total awe, among those who kneel before the crown
            new RandomTableEntry
            {
                LowerRange = 100,
                UpperRange = 100,
                Name = nameof(NobilityEnum.Regent),
                ProperName = "Minor Prince",
                Description =
                    "You are a prince or princess, " +
                    "the son or daughter of the " +
                    "monarch. You owe fealty directly " +
                    "to your parents, and to no one " +
                    "else. Few command the power and " +
                    "wealth you do, and your presence " +
                    "inspires great respect, if not " +
                    "total awe, among those who kneel " +
                    "before the crown.",
            },
            #endregion
        ]
    };
}

