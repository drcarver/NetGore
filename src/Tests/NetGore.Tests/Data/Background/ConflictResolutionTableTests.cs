using NetGore.Core.Enum;
using NetGore.Data.Background;
using NetGore.Data.Interfaces;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data.Background;

[TestFixture]
public class ConflictResolutionTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        var conflictResolutionTable = new ConflictResolutionTable();
        ClassicAssert.IsTrue(conflictResolutionTable.Name == nameof(ConflictResolutionTable));

        foreach (var entry in conflictResolutionTable.Table)
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
            //Regret and Penance(–3 cp) Not only do you regret your action, but you have publicly admitted to it and did your best to make amends for the wrongdoing.Most know of the conflict’s details and those who don’t can easily find them out if they know where to look or whom to ask.
            case nameof(ConflictResolutionEnum.RegretandPenance):
                    return entry.ConflictPoints == -3;

            //Sincere Regret (–2 cp) Though you feel sincere regret for the event and its memory affects your behavior, it’s still a secret.Only your trusted companions know of the conflict, and they have promised a degree of discretion.
            case nameof(ConflictResolutionEnum.SincereRegret):
                    return entry.ConflictPoints == -2;

            //Secret Regret (–1 cp) You regret the conflict, but go to great lengths to keep it secret and try desperately to forget it ever happened.Only you and maybe a select few people know of your involvement in the conflict.
            case nameof(ConflictResolutionEnum.SecretRegret):
                    return entry.ConflictPoints == -1;

            //Mixed Feelings (0 cp) Sometimes you regret the conflict, but other times you feel as if you didn’t have a choice in the matter or that you made the right decision.Most of the time, you just avoid thinking about the conflict.Only you and maybe a select few people know of your involvement.
            case nameof(ConflictResolutionEnum.MixedFeelings):
                    return entry.ConflictPoints == 0;

            //Denial (+1 cp) You feel little if any regret, and deny the event mostly so others won’t judge you.Few if any know of your part in the conflict, and your constant denials are meant to keep it that way.
            case nameof(ConflictResolutionEnum.Denial):
                    return entry.ConflictPoints == 1;

            //No Guilt (+2 cp) Either guilt is for the weak, or you know you made the right decision.You might not openly brag about your part in the conflict, but you don’t deny it when confronted either.
            case nameof(ConflictResolutionEnum.NoGuilt):
                    return entry.ConflictPoints == 2;

            //You Enjoyed It (+3 cp) Those who cling to petty morals have no understanding of what true freedom and power is. The fact is, you enjoyed your part in the conflict and would do it all over again if the opportunity presented itself.Many people know of your misdeed, and they also realize your complete lack of remorse
            case nameof(ConflictResolutionEnum.YouEnjoyedIt):
                    return entry.ConflictPoints == 3;
        }
        return false;
    }
}