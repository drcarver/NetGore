using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class RaceTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.RaceTable.Name == "Race Table");
        ClassicAssert.IsTrue(BackgroundTables.RaceTable.DiceSides == 100);

        for (int i = 1; i <= BackgroundTables.RaceTable.DiceSides; i++)
        {
            var entry = BackgroundTables.RaceTable.GetEntryByNumber(i);
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
            //01	Aasimar
            case int n when (n>= 1 && n <= 1):
                return entry.Name == nameof(RaceEnum.Aasimar)
                    && entry.Traits.Count == 0;

            //02	Catfolk
            case int n when (n >= 2 && n <= 2):
                return entry.Name == nameof(RaceEnum.Catfolk)
                    && entry.Traits.Count == 0;

            //03–04	Changeling
            case int n when (n >= 3 && n <= 4):
                return entry.Name == nameof(RaceEnum.Changeling)
                    && entry.Traits.Count == 0;

            //05	Dhampir
            case int n when (n >= 5 && n <= 5):
                return entry.Name == nameof(RaceEnum.Dhampir)
                    && entry.Traits.Count == 0;

            //06	Duergar
            case int n when (n >= 6 && n <= 6):
                return entry.Name == nameof(RaceEnum.Duergar)
                    && entry.Traits.Count == 0;

            //07–16	Dwarf
            case int n when (n >= 7 && n <= 16):
                return entry.Name == nameof(RaceEnum.Dwarf)
                    && entry.Traits.Count == 0;

            //17–26	Elf
            case int n when (n >= 17 && n <= 26):
                return entry.Name == nameof(RaceEnum.Elf)
                    && entry.Traits.Count == 0;

            //27	Fetchling
            case int n when (n >= 27 && n <= 27):
                return entry.Name == nameof(RaceEnum.Fetchling)
                    && entry.Traits.Count == 0;

            //28	Gillman
            case int n when (n >= 28 && n <= 28):
                return entry.Name == nameof(RaceEnum.Gillman)
                    && entry.Traits.Count == 0;

            //29–38	Gnome
            case int n when (n >= 29 && n <= 38):
                return entry.Name == nameof(RaceEnum.Gnome)
                    && entry.Traits.Count == 0;

            //39	Goblin
            case int n when (n >= 39 && n <= 39):
                return entry.Name == nameof(RaceEnum.Goblin)
                    && entry.Traits.Count == 0;

            //40	Grippli
            case int n when (n >= 40 && n <= 40):
                return entry.Name == nameof(RaceEnum.Grippli)
                    && entry.Traits.Count == 0;

            //41–50	Half-Elf
            case int n when (n >= 41 && n <= 50):
                return entry.Name == nameof(RaceEnum.HalfElf)
                    && entry.Traits.Count == 0;

            //51–60	Half-orc
            case int n when (n >= 51 && n <= 60):
                return entry.Name == nameof(RaceEnum.HalfOrc)
                    && entry.Traits.Count == 0;

            //61–70	Halfling
            case int n when (n >= 61 && n <= 70):
                return entry.Name == nameof(RaceEnum.Halfling)
                    && entry.Traits.Count == 0;

            //71	Hobgoblin
            case int n when (n >= 71 && n <= 71):
                return entry.Name == nameof(RaceEnum.Hobgoblin)
                    && entry.Traits.Count == 0;

            //72–81	Human
            case int n when (n >= 72 && n <= 81):
                return entry.Name == nameof(RaceEnum.Human)
                    && entry.Traits.Count == 0;

            //82	Ifrit
            case int n when (n >= 82 && n <= 82):
                return entry.Name == nameof(RaceEnum.Ifrit)
                    && entry.Traits.Count == 0;

            //83	Kitsune
            case int n when (n >= 83 && n <= 83):
                return entry.Name == nameof(RaceEnum.Kitsune)
                    && entry.Traits.Count == 0;

            //84	Kobold
            case int n when (n >= 84 && n <= 84):
                return entry.Name == nameof(RaceEnum.Kobold)
                    && entry.Traits.Count == 0;

            //85	Merfolk
            case int n when (n >= 85 && n <= 85):
                return entry.Name == nameof(RaceEnum.Merfolk)
                    && entry.Traits.Count == 0;

            //86	Nagaji
            case int n when (n >= 86 && n <= 86):
                return entry.Name == nameof(RaceEnum.Nagaji)
                    && entry.Traits.Count == 0;

            //87	Orc
            case int n when (n >= 87 && n <= 87):
                return entry.Name == nameof(RaceEnum.Orc)
                    && entry.Traits.Count == 0;

            //88	Oread
            case int n when (n >= 88 && n <= 88):
                return entry.Name == nameof(RaceEnum.Oread)
                    && entry.Traits.Count == 0;

            //89	Ratfolk
            case int n when (n >= 89 && n <= 89):
                return entry.Name == nameof(RaceEnum.Ratfolk)
                    && entry.Traits.Count == 0;

            //90	Samsaran
            case int n when (n >= 90 && n <= 90):
                return entry.Name == nameof(RaceEnum.Samsaran)
                    && entry.Traits.Count == 0;

            //91	Strix
            case int n when (n >= 91 && n <= 91):
                return entry.Name == nameof(RaceEnum.Strix)
                    && entry.Traits.Count == 0;

            //92	Suli
            case int n when (n >= 92 && n <= 92):
                return entry.Name == nameof(RaceEnum.Suli)
                    && entry.Traits.Count == 0;

            //93	Svirfneblin
            case int n when (n >= 93 && n <= 93):
                return entry.Name == nameof(RaceEnum.Svirfneblin)
                    && entry.Traits.Count == 0;

            //94	Sylph
            case int n when (n >= 94 && n <= 94):
                return entry.Name == nameof(RaceEnum.Sylph)
                    && entry.Traits.Count == 0;

            //95	Tengu
            case int n when (n >= 95 && n <= 95):
                return entry.Name == nameof(RaceEnum.Tengu)
                    && entry.Traits.Count == 0;

            //96	Tiefling
            case int n when (n >= 96 && n <= 96):
                return entry.Name == nameof(RaceEnum.Tiefling)
                    && entry.Traits.Count == 0;

            //97	Undine
            case int n when (n >= 97 && n <= 97):
                return entry.Name == nameof(RaceEnum.Undine)
                    && entry.Traits.Count == 0;

            //98	Vanara
            case int n when (n >= 98 && n <= 98):
                return entry.Name == nameof(RaceEnum.Vanara)
                    && entry.Traits.Count == 0;

            //99	Vishkanya
            case int n when (n >= 99 && n <= 99):
                return entry.Name == nameof(RaceEnum.Vishkanya)
                    && entry.Traits.Count == 0;

            //100	Wayang
            case int n when (n >= 100 && n <= 100):
                return entry.Name == nameof(RaceEnum.Wayang)
                    && entry.Traits.Count == 0;
        }
        return false;
    }
}
