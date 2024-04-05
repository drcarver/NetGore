using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Data.Core;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data.Core;

[TestFixture]
public class LanguageTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        var languageTable = new LanguageTable();
        ClassicAssert.IsTrue(languageTable.Name == nameof(LanguageTable));
        ClassicAssert.IsTrue(languageTable.DiceSides == 20);

        // do we have an entry for each enum
        foreach (var item in Enum.GetValues(typeof(LanguageEnum)))
        {
            var entry = languageTable.GetEntryByName(item.ToString());
            ClassicAssert.IsNotNull(entry, $"Table entry Name = {nameof(item)} is not found");
        }

        for (int i = 1; i <= languageTable.DiceSides; i++)
        {
            var entry = languageTable.GetEntryByNumber(i);
            ClassicAssert.IsTrue(VerifyEntry(i, entry), $"Table entry {i} - Name = {entry?.Name} is incorrect");
        }
    }

    /// <summary>
    /// Verify a random table entry
    /// </summary>
    /// <param name="i">The index for the table</param>
    /// <param name="entry">The random entry</param>
    /// <returns>True if correct</returns>
    private static bool VerifyEntry(int i, IGameTableEntry entry)
    {
        if (entry == null)
        {
            return false;
        }

        switch (i)
        {
            //01	Common
            case int n when n >= 1 && n <= 1:
                return entry.Name == nameof(LanguageEnum.Common);

            //02	Dwarvish
            case int n when n >= 2 && n <= 2:
                return entry.Name == nameof(LanguageEnum.Dwarvish);

            //03	Elvish
            case int n when n >= 3 && n <= 3:
                return entry.Name == nameof(LanguageEnum.Elvish);

            //03	Elvish
            case int n when n >= 3 && n <= 3:
                return entry.Name == nameof(LanguageEnum.Elvish);

            //04	Giant
            case int n when n >= 4 && n <= 4:
                return entry.Name == nameof(LanguageEnum.Giant);

            //05	Gnomish
            case int n when n >= 5 && n <= 5:
                return entry.Name == nameof(LanguageEnum.Gnomish);

            //06	Goblin
            case int n when n >= 6 && n <= 6:
                return entry.Name == nameof(LanguageEnum.Goblin);

            //07	Halfling
            case int n when n >= 7 && n <= 7:
                return entry.Name == nameof(LanguageEnum.Halfling);

            //08	Orc
            case int n when n >= 8 && n <= 8:
                return entry.Name == nameof(LanguageEnum.Orc);

            //09	Abyssal
            case int n when n >= 9 && n <= 9:
                return entry.Name == nameof(LanguageEnum.Abyssal);

            //10	Celestial
            case int n when n >= 10 && n <= 10:
                return entry.Name == nameof(LanguageEnum.Celestial);

            //11	Draconic
            case int n when n >= 11 && n <= 11:
                return entry.Name == nameof(LanguageEnum.Draconic);

            //12	Deep
            case int n when n >= 12 && n <= 12:
                return entry.Name == nameof(LanguageEnum.Deep);

            //13	Infernal
            case int n when n >= 13 && n <= 13:
                return entry.Name == nameof(LanguageEnum.Infernal);

            //14	Primordial
            case int n when n >= 14 && n <= 14:
                return entry.Name == nameof(LanguageEnum.Primordial);

            //15	Sylvan
            case int n when n >= 15 && n <= 15:
                return entry.Name == nameof(LanguageEnum.Sylvan);

            //16	Undercommon
            case int n when n >= 16 && n <= 16:
                return entry.Name == nameof(LanguageEnum.Undercommon);

            //17	Aquan
            case int n when n >= 17 && n <= 17:
                return entry.Name == nameof(LanguageEnum.Aquan);

            //18	Gnoll
            case int n when n >= 18 && n <= 18:
                return entry.Name == nameof(LanguageEnum.Gnoll);

            //19	Auran
            case int n when n >= 19 && n <= 19:
                return entry.Name == nameof(LanguageEnum.Auran);

            //20	Terran
            case int n when n >= 20 && n <= 20:
                return entry.Name == nameof(LanguageEnum.Terran);
        }
        return false;
    }
}
