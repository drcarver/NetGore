using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Data.Background;
using NetGore.Data.Models;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class RaceTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        var raceTable = new RaceTable();
        ClassicAssert.IsTrue(raceTable.Name == nameof(RaceTable));
        ClassicAssert.IsTrue(raceTable.DiceSides == 100);

        for (int i = 1; i <= raceTable.DiceSides; i++)
        {
            var entry = raceTable.GetEntryByNumber(i);
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
            //01	Aasimar
            case int n when (n>= 1 && n <= 1):
                return entry.Name == nameof(RaceEnum.Aasimar);

            //02	Catfolk
            case int n when (n >= 2 && n <= 2):
                return entry.Name == nameof(RaceEnum.Catfolk);

            //03–04	Changeling
            case int n when (n >= 3 && n <= 4):
                return entry.Name == nameof(RaceEnum.Changeling);

            //05	Dhampir
            case int n when (n >= 5 && n <= 5):
                return entry.Name == nameof(RaceEnum.Dhampir);

            //06	Duergar
            case int n when (n >= 6 && n <= 6):
                return entry.Name == nameof(RaceEnum.Duergar);

            //07–16	Dwarf
            case int n when (n >= 7 && n <= 16):
                return entry.Name == nameof(RaceEnum.Dwarf);

            //17–26	Elf
            case int n when (n >= 17 && n <= 26):
                return entry.Name == nameof(RaceEnum.Elf);

            //27	Fetchling
            case int n when (n >= 27 && n <= 27):
                return entry.Name == nameof(RaceEnum.Fetchling);

            //28	Gillman
            case int n when (n >= 28 && n <= 28):
                return entry.Name == nameof(RaceEnum.Gillman);

            //29–38	Gnome
            case int n when (n >= 29 && n <= 38):
                return entry.Name == nameof(RaceEnum.Gnome);

            //39	Goblin
            case int n when (n >= 39 && n <= 39):
                return entry.Name == nameof(RaceEnum.Goblin);

            //40	Grippli
            case int n when (n >= 40 && n <= 40):
                return entry.Name == nameof(RaceEnum.Grippli);

            //41–50	Half-Elf
            case int n when (n >= 41 && n <= 50):
                return entry.Name == nameof(RaceEnum.HalfElf);

            //51–60	Half-orc
            case int n when (n >= 51 && n <= 60):
                return entry.Name == nameof(RaceEnum.HalfOrc);

            //61–70	Halfling
            case int n when (n >= 61 && n <= 70):
                return entry.Name == nameof(RaceEnum.Halfling);

            //71	Hobgoblin
            case int n when (n >= 71 && n <= 71):
                return entry.Name == nameof(RaceEnum.Hobgoblin);

            //72–81	Human
            case int n when (n >= 72 && n <= 81):
                return entry.Name == nameof(RaceEnum.Human);

            //82	Ifrit
            case int n when (n >= 82 && n <= 82):
                return entry.Name == nameof(RaceEnum.Ifrit);

            //83	Kitsune
            case int n when (n >= 83 && n <= 83):
                return entry.Name == nameof(RaceEnum.Kitsune);

            //84	Kobold
            case int n when (n >= 84 && n <= 84):
                return entry.Name == nameof(RaceEnum.Kobold);

            //85	Merfolk
            case int n when (n >= 85 && n <= 85):
                return entry.Name == nameof(RaceEnum.Merfolk);

            //86	Nagaji
            case int n when (n >= 86 && n <= 86):
                return entry.Name == nameof(RaceEnum.Nagaji);

            //87	Orc
            case int n when (n >= 87 && n <= 87):
                return entry.Name == nameof(RaceEnum.Orc);

            //88	Oread
            case int n when (n >= 88 && n <= 88):
                return entry.Name == nameof(RaceEnum.Oread);

            //89	Ratfolk
            case int n when (n >= 89 && n <= 89):
                return entry.Name == nameof(RaceEnum.Ratfolk);

            //90	Samsaran
            case int n when (n >= 90 && n <= 90):
                return entry.Name == nameof(RaceEnum.Samsaran);

            //91	Strix
            case int n when (n >= 91 && n <= 91):
                return entry.Name == nameof(RaceEnum.Strix);

            //92	Suli
            case int n when (n >= 92 && n <= 92):
                return entry.Name == nameof(RaceEnum.Suli);

            //93	Svirfneblin
            case int n when (n >= 93 && n <= 93):
                return entry.Name == nameof(RaceEnum.Svirfneblin);

            //94	Sylph
            case int n when (n >= 94 && n <= 94):
                return entry.Name == nameof(RaceEnum.Sylph);

            //95	Tengu
            case int n when (n >= 95 && n <= 95):
                return entry.Name == nameof(RaceEnum.Tengu);

            //96	Tiefling
            case int n when (n >= 96 && n <= 96):
                return entry.Name == nameof(RaceEnum.Tiefling);

            //97	Undine
            case int n when (n >= 97 && n <= 97):
                return entry.Name == nameof(RaceEnum.Undine);

            //98	Vanara
            case int n when (n >= 98 && n <= 98):
                return entry.Name == nameof(RaceEnum.Vanara);

            //99	Vishkanya
            case int n when (n >= 99 && n <= 99):
                return entry.Name == nameof(RaceEnum.Vishkanya);

            //100	Wayang
            case int n when (n >= 100 && n <= 100):
                return entry.Name == nameof(RaceEnum.Wayang);
        }
        return false;
    }
}
