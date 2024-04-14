using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Character.Tables;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data.Background;

[TestFixture]
public class ConflictTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        var table = new ConflictTable();
        ClassicAssert.IsTrue(table.Name == nameof(ConflictTable));

        foreach (var entry in table.Table)
        {
            ClassicAssert.IsTrue(VerifyEntry((IConflictTableEntry) entry), $"Table entry Name = {entry?.Name} is incorrect");
        }
    }

    /// <summary>
    /// Verify a random table entry
    /// </summary>
    /// <param name="i">The index for the table</param>
    /// <param name="entry">The random entry</param>
    /// <returns>True if correct</returns>
    private static bool VerifyEntry(IConflictTableEntry entry)
    {
        if (entry == null)
        {
            return false;
        }

        switch (entry.Name)
        {
            //1	Minor Failure
            case nameof(ConflictEnum.MinorFailure):
                    return entry.ConflictPoints == 1;

            //2	Petty Crime
            case nameof(ConflictEnum.PettyCrime):
                    return entry.ConflictPoints == 1;

            //3	Told a Lie
            case nameof(ConflictEnum.ToldaLie):
                    return entry.ConflictPoints == 1;

            //4	Broke a Promise
            case nameof(ConflictEnum.BrokeaPromise):
                    return entry.ConflictPoints == 1;

            //5	Humiliation
            case nameof(ConflictEnum.Humiliation):
                    return entry.ConflictPoints == 2;

            //6	Negligence
            case nameof(ConflictEnum.Negligence):
                    return entry.ConflictPoints == 2;

            //7	Minor Theft
            case nameof(ConflictEnum.MinorTheft):
                    return entry.ConflictPoints == 2;

            //8	Seducer
            case nameof(ConflictEnum.Seducer):
                    return entry.ConflictPoints == 3;

            //9	Cheater
            case nameof(ConflictEnum.Cheater):
                    return entry.ConflictPoints == 3;

            //10 Betrayal
            case nameof(ConflictEnum.Betrayal):
                    return entry.ConflictPoints == 4;

            //11	Malign Associates
            case nameof(ConflictEnum.MalignAssociates):
                    return entry.ConflictPoints == 4;

            //12 Destroyed a Reputation
            case nameof(ConflictEnum.DestroyedaReputation):
                    return entry.ConflictPoints == 5;

            //13 Major Theft
            case nameof(ConflictEnum.MajorTheft):
                    return entry.ConflictPoints == 5;

            //14 Corrupted an Innocent
            case nameof(ConflictEnum.CorruptedanInnocent):
                    return entry.ConflictPoints == 6;

            //15 Blackmailed
            case nameof(ConflictEnum.Blackmailed):
                    return entry.ConflictPoints == 6;

            //16 Destruction
            case nameof(ConflictEnum.Destruction):
                    return entry.ConflictPoints == 6;

            //17 Armed Robbery
            case nameof(ConflictEnum.ArmedRobbery):
                    return entry.ConflictPoints == 6;

            //18 Violent Crime
            case nameof(ConflictEnum.ViolentCrime):
                    return entry.ConflictPoints == 7;

            //19 Murder
            case nameof(ConflictEnum.Murder):
                    return entry.ConflictPoints == 8;

            //20 Mass Murder
            case nameof(ConflictEnum.MassMurder):
                    return entry.ConflictPoints == 12;
        }
        return false;
    }
}