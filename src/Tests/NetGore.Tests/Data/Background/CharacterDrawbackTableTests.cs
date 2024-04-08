using NetGore.Core.Enum;
using NetGore.Data.Background;
using NetGore.Data.Interfaces;
using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data.Background;

[TestFixture]
public class CharacterDrawbackTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        var characterDrawbackTable = new CharacterDrawbackTable();
        ClassicAssert.IsTrue(characterDrawbackTable.Name == nameof(CharacterDrawbackTable));
        ClassicAssert.IsTrue(characterDrawbackTable.DiceSides == 100);

        for (int i = 1; i <= characterDrawbackTable.DiceSides; i++)
        {
            var entry = (IBackgroundTableEntry)characterDrawbackTable.GetRangeEntryByNumber(i);
            ClassicAssert.IsTrue(VerifyEntry(i, entry), $"Table entry {i} - Name = {entry?.Name} is incorrect");
        }
    }

    /// <summary>
    /// Verify a random table entry
    /// </summary>
    /// <param name="i">The index for the table</param>
    /// <param name="entry">The IBackgroundTableEntry entry</param>
    /// <returns>True if correct</returns>
    private static bool VerifyEntry(int i, IBackgroundTableEntry entry)
    {
        if (entry == null)
        {
            return false;
        }

        switch (i)
        {
            //01–05	Attachment(Object) Attached drawback.
            case int n when n >= 1 && n <= 5:
                return entry.Name == nameof(CharacterDrawbackEnum.AttachmenttoanObject)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Attached);

            //06–10	Attachment(Person).
            case int n when n >= 6 && n <= 10:
                return entry.Name == nameof(CharacterDrawbackEnum.AttachmenttoaPerson)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Attached);

            //11–15	Family
            case int n when n >= 11 && n <= 15:
                return entry.Name == nameof(CharacterDrawbackEnum.Family)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.FamilyTies);

            //16–20	Justice
            case int n when n >= 16 && n <= 20:
                return entry.Name == nameof(CharacterDrawbackEnum.Justice)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Headstrong);

            //21–25	Love
            case int n when n >= 21 && n <= 25:
                return entry.Name == nameof(CharacterDrawbackEnum.Love)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Lovesick);

            //26–30	Loyalty
            case int n when n >= 26 && n <= 30:
                return entry.Name == nameof(CharacterDrawbackEnum.Loyalty)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Pride);

            //31–35	Material Wealth
            case int n when n >= 31 && n <= 35:
                return entry.Name == nameof(CharacterDrawbackEnum.MaterialWealth)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Avarice);

            //36–40	Pleasure
            case int n when n >= 36 && n <= 40:
                return entry.Name == nameof(CharacterDrawbackEnum.Pleasure)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Hedonistic);

            //41–45	Power
            case int n when n >= 41 && n <= 45:
                return entry.Name == nameof(CharacterDrawbackEnum.Power)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.PowerHungry);

            //46–50	Pride
            case int n when n >= 46 && n <= 50:
                return entry.Name == nameof(CharacterDrawbackEnum.Pride)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Pride);

            //51–55	Race
            case int n when n >= 51 && n <= 55:
                return entry.Name == nameof(CharacterDrawbackEnum.Race)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Xenophobic);

            //56–60	Religion
            case int n when n >= 56 && n <= 60:
                return entry.Name == nameof(CharacterDrawbackEnum.Religion)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Zealous);

            //61–65	Reputation or Fame
            case int n when n >= 61 && n <= 65:
                return entry.Name == nameof(CharacterDrawbackEnum.ReputationorFame)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Vain);

            //66–70	Safety or Security
            case int n when n >= 66 && n <= 70:
                return entry.Name == nameof(CharacterDrawbackEnum.SafetyorSecurity)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Paranoid);

            //71–75	Self-Doubt
            case int n when n >= 71 && n <= 75:
                return entry.Name == nameof(CharacterDrawbackEnum.SelfDoubt)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Doubt);

            //76–80	Social Acceptance
            case int n when n >= 76 && n <= 80:
                return entry.Name == nameof(CharacterDrawbackEnum.SocialAcceptance)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Dependent);

            //81–85	The Future
            case int n when n >= 81 && n <= 85:
                return entry.Name == nameof(CharacterDrawbackEnum.TheFuture)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Meticulous);

            //86–90	The Past
            case int n when n >= 86 && n <= 90:
                return entry.Name == nameof(CharacterDrawbackEnum.ThePast)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Sentimental);

            //91–95	Worldview
            case int n when n >= 91 && n <= 95:
                return entry.Name == nameof(CharacterDrawbackEnum.Worldview)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Provincial);

            //96–100 Youth
            case int n when n >= 96 && n <= 100:
                return entry.Name == nameof(CharacterDrawbackEnum.Youth)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Vain);
        }
        return false;
    }
}
