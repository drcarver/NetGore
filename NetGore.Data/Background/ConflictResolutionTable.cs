using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Background;

/// <summary>
/// Once you determine the nature and CP for the 
/// event, the next step is to determine the 
/// resolution. In games that do not allow
/// evil characters, you cannot take a resolution 
/// that would adjust your character to an evil 
/// alignment.
/// </summary>
public partial class BackgroundTables
{
    //Table: Resolution
    //d7 Result CP
    //Regret and Penance(–3 cp) Not only do you regret your action, but you have publicly admitted to it and did your best to make amends for the wrongdoing.Most know of the conflict’s details and those who don’t can easily find them out if they know where to look or whom to ask.
    //Sincere Regret (–2 cp) Though you feel sincere regret for the event and its memory affects your behavior, it’s still a secret.Only your trusted companions know of the conflict, and they have promised a degree of discretion.
    //Secret Regret (–1 cp) You regret the conflict, but go to great lengths to keep it secret and try desperately to forget it ever happened.Only you and maybe a select few people know of your involvement in the conflict.
    //Mixed Feelings (0 cp) Sometimes you regret the conflict, but other times you feel as if you didn’t have a choice in the matter or that you made the right decision.Most of the time, you just avoid thinking about the conflict.Only you and maybe a select few people know of your involvement.
    //Denial (+1 cp) You feel little if any regret, and deny the event mostly so others won’t judge you.Few if any know of your part in the conflict, and your constant denials are meant to keep it that way.
    //No Guilt (+2 cp) Either guilt is for the weak, or you know you made the right decision.You might not openly brag about your part in the conflict, but you don’t deny it when confronted either.
    //You Enjoyed It (+3 cp) Those who cling to petty morals have no understanding of what true freedom and power is. The fact is, you enjoyed your part in the conflict and would do it all over again if the opportunity presented itself.Many people know of your misdeed, and they also realize your complete lack of remorse
    /// <summary>
    /// Conflict Resolution Table
    /// </summary>
    public static RandomTable ConflictResolutionTable { get; } = new()
    {
        Name = "The Conflict Resolution Table",
        DiceSides = 8,
        Table =
        [
            #region Regret and Penance
            //Regret and Penance(–3 cp) Not only do
            //you regret your action, but you have
            //publicly admitted to it and did your
            //best to make amends for the wrongdoing.
            //Most know of the conflict’s details
            //and those who don’t can easily find
            //them out if they know where to look
            //or whom to ask.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 01,
                Name = nameof(ConflictResolutionEnum.RegretandPenance),
                ProperName = "Regret and Penance",
                ConflictPoints = -3
            },
            #endregion

            #region Sincere Regret
            //Sincere Regret (–2 cp) Though you feel
            //sincere regret for the event and its
            //memory affects your behavior, it’s
            //still a secret.Only your trusted
            //companions know of the conflict, and
            //they have promised a degree of
            //discretion.
            new RandomTableEntry
            {
                LowerRange = 02,
                UpperRange = 02,
                Name = nameof(ConflictResolutionEnum.SincereRegret),
                ProperName = "Sincere Regret",
                ConflictPoints = -2
            },
            #endregion

            #region Secret Regret
            //Secret Regret (–1 cp) You regret the
            //conflict, but go to great lengths to
            //keep it secret and try desperately
            //to forget it ever happened.Only you
            //and maybe a select few people know
            //of your involvement in the conflict.
            new RandomTableEntry
            {
                LowerRange = 03,
                UpperRange = 03,
                Name = nameof(ConflictResolutionEnum.SecretRegret),
                ProperName = "Secret Regret",
                ConflictPoints = -1
            },
            #endregion

            #region Mixed Feelings
            //Mixed Feelings (0 cp) Sometimes you regret the conflict, but other times you feel as if you didn’t have a choice in the matter or that you made the right decision.Most of the time, you just avoid thinking about the conflict.Only you and maybe a select few people know of your involvement.
            new RandomTableEntry
            {
                LowerRange = 04,
                UpperRange = 05,
                Name = nameof(ConflictResolutionEnum.MixedFeelings),
                ProperName = "Mixed Feelings",
                ConflictPoints = 0
            },
            #endregion

            #region Denial
            //Denial (+1 cp) You feel little if any regret, and deny the event mostly so others won’t judge you.Few if any know of your part in the conflict, and your constant denials are meant to keep it that way.
            new RandomTableEntry
            {
                LowerRange = 06,
                UpperRange = 06,
                Name = nameof(ConflictResolutionEnum.Denial),
                ProperName = "Denial",
                ConflictPoints = 1
            },
            #endregion

            #region No Guilt
            //No Guilt (+2 cp) Either guilt is for the weak, or you know you made the right decision.You might not openly brag about your part in the conflict, but you don’t deny it when confronted either.
            new RandomTableEntry
            {
                LowerRange = 07,
                UpperRange = 07,
                Name = nameof(ConflictResolutionEnum.NoGuilt),
                ProperName = "No Guilt",
                ConflictPoints = 2
            },
            #endregion

            #region You Enjoyed It
            //You Enjoyed It (+3 cp) Those who cling to petty morals have no understanding of what true freedom and power is. The fact is, you enjoyed your part in the conflict and would do it all over again if the opportunity presented itself.Many people know of your misdeed, and they also realize your complete lack of remorse
            new RandomTableEntry
            {
                LowerRange = 08,
                UpperRange = 08,
                Name = nameof(ConflictResolutionEnum.YouEnjoyedIt),
                ProperName = "You Enjoyed It",
                ConflictPoints = 3
            },
            #endregion
        ],
    };
}
