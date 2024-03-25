using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class NobilityTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.NobilityTable.Name == "NobilityTable");
        ClassicAssert.IsTrue(BackgroundTables.NobilityTable.DiceSides == 100);

        for (int i = 1; i <= BackgroundTables.NobilityTable.DiceSides; i++)
        {
            var entry = BackgroundTables.NobilityTable.GetEntryByNumber(i);
            ClassicAssert.IsTrue(VerifyEntry(i, entry), $"Table entry {i} - Name = {entry?.Name} is incorrect");
        }
    }

    /// <summary>
    /// Verify a random table entry
    /// </summary>
    /// <param name="i">The index for the table</param>
    /// <param name="entry">The random entry</param>
    /// <returns>True if correct</returns>
    private static bool VerifyEntry(int i, RandomTableEntry? entry)
    {
        if (entry == null)
        {
            return false;
        }

        switch (i)
        {
            //01–60	Gentry You are the child of a minor lord, lady, or noble with an income, hereditary land such as a manor, and titles.You likely grew up in a manor and your parents were paid tribute by peasants.Your parents serve a higher baron, count, or duke.
            case int n when (n>= 1 && n <= 60):
                return entry.Name == nameof(NobilityEnum.Gentry);
            //61–78	Knight You are the child of a knight, a noble with estates, titles, and lands who serves a lord. Your family has sworn an oath of fealty to a liege—such as a baron, count, or duke—and commits to military service in his or her name. As the child of a knight, you may serve as a squire to another knight while pursuing your own path to knighthood.
            case int n when (n >= 61 && n <= 78):
                return entry.Name == nameof(NobilityEnum.Knight);
            //79–85	Baron You are the child of a baron or baroness, a noble responsible for a land encompassing several smaller manors that pay tribute.Your parents receive orders directly from the monarch, and you’re expected to attend the royal court.You are entitled to hereditary estates, titles, and land.
            case int n when (n >= 79 && n <= 85):
                return entry.Name == nameof(NobilityEnum.Baron);
            //86–91	Count You are the noble child of a count or countess.Your family members receive hereditary titles, land, and estates, and are among the most wealthy nobles in your domain. Knights and minor lords pay tribute to your family, and your parents attend directly to the monarch. You’re expected to attend the royal court.
            case int n when (n >= 86 && n <= 91):
                return entry.Name == nameof(NobilityEnum.Count);
            //92–96	Duke You are the child of a duke or duchess, the most powerful noble in the realm apart from the royal family.Your parents attend directly to the monarch and have the highest place at court. Your lands, titles, and estates are significant, and many lords and knights serve under your parents’ command.
            case int n when (n >= 92 && n <= 96):
                return entry.Name == nameof(NobilityEnum.Duke);
            //97–99	Minor Prince    You are the child of a prince or princess, and part of the royal family. You aren’t the next in succession, but your power and wealth are grand indeed.
            case int n when (n >= 97 && n <= 99):
                return entry.Name == nameof(NobilityEnum.MinorPrince);
            //100	Regent You are a prince or princess, the son or daughter of the monarch.You owe fealty directly to your parents, and to no one else. Few command the power and wealth you do, and your presence inspires great respect, if not total awe, among those who kneel before the crown.
            case int n when (n >= 100 && n <= 100):
                return entry.Name == nameof(NobilityEnum.Regent);
        }
        return false;
    }
}
