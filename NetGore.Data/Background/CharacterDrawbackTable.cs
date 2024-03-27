#region Copyright Notice and source url
//
// This content contains copyright material. The material
// format has been change to support the needs of the
// Application.  In particular the table entries and
// values have the following copyright notice.
//
// The content is from the url:
// https://www.d20pfsrd.com/basics-ability-scores/more-character-options/character-backgrounds/background-generator
//
// Pathfinder Roleplaying Game: Ultimate Campaign.
// ©2013, Paizo Publishing, LLC;
// Authors: Jesse Benner, Benjamin Bruck, Jason Bulmahn,
// Ryan Costello, Adam Daigle, Matt Goetz, Tim Hitchcock,
// James Jacobs, Ryan Macklin, Colin McComb,
// Jason Nelson, Richard Pett, Stephen Radney-MacFarland,
// Patrick Renie, Sean K Reynolds, F. Wesley Schneider,
// James L.Sutter, Russ Taylor, and Stephen Townshend.
//
#endregion

using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Background;

/// <summary>
/// Character drawbacks are emotional weak points—chinks
/// your armor. a drawback gives you a small mechanical 
/// penalty and a roleplaying hook. Drawbacks also 
/// serve as loopholes in the alignment system. 
/// When roleplaying your drawback, you might act 
/// well outside the bounds of your alignment within 
/// certain situations. Each of the following grants 
/// a drawback you may choose to take. If you take 
/// a drawback option, you may take three traits 
/// you have access to instead of two. Roll on the 
/// following table to determine your character’s 
/// drawback.
/// </summary>
public partial class BackgroundTables
{
    //Table: Character Drawback
    //d%	Result
    //01–05	Attachment(Object) You are attached to a precious possession with immense sentimental value and significance.Without it, you are no longer yourself and are prone to suffer from depression, moodiness, or aggressive behavior.You gain access to the Attached drawback.
    //06–10	Attachment(Person) You are attached to a particular person—a friend, family member, or loved one—who means more than anything or anyone in the world.Your thoughts always return to this person.You gain access to the Attached drawback.
    //11–15	Family Your family means everything to you, and there is nothing you wouldn’t do for them.Maybe your ties extend to your entire clan or bloodline, or perhaps there is one specific member of your family you hold closer than any other. You gain access to the Family Ties drawback.
    //16–20	Justice Unfairness and injustice are intolerable. Whenever you witness them, you feel compelled to act or speak out. When you’re personally wronged, you require appeasement—or revenge if you don’t receive it.You gain access to the Headstrong drawback.
    //21–25	Love Your love for someone motivates you.When this person is in danger, you’re prone to feel weak, powerless, or angry. You gain access to the Lovesick drawback.
    //26–30	Loyalty You value loyalty over all things.You treasure the friends, associates, and lovers you have earned throughout the years, and when someone breaks your trust or betrays you in some way, you become utterly unhinged. You gain access to the Pride drawback.
    //31–35	Material Wealth You have a weakness for material things—money, fine jewelry, exquisite foods, expensive or rare items, and so on.When such riches are within your reach, you’re driven to possess them, and you claim them either as an honest collector or a cunning thief.You gain access to the Avarice drawback.
    //36–40	Pleasure You crave luxury, entertainment, and pleasure. You might indulge in every passing fancy or hold strong against a temptation that constantly eats at you. You gain access to the Hedonistic drawback.
    //41–45	Power You long for the ability to influence the world around you, whether that’s as small as a village or as large as a plane of reality. You gain access to the Power-Hungry drawback.
    //46–50	Pride You present an image to the world that can’t be tarnished.When someone questions your motives, criticizes your actions, or insults your honor or pride, you question his friendship or count him among your enemies until he makes amends. You gain access to the Pride drawback.
    //51–55	Race You are truly comfortable only around others of your race, and you have a hard time putting faith or trust in those of races different from your own.You gain access to the Xenophobic drawback.
    //56–60	Religion Your beliefs are of paramount importance in your life, whether you belong to a temple, follow a cult, or practice a religious philosophy independently. When others question or attack the beliefs, principles, relics, or structures of your faith, you respond with fury. You gain access to the Zealous drawback.
    //61–65	Reputation or Fame You’ve worked hard to establish your identity and reputation, and someone who slanders or insults you must answer for it.You strive to promote your identity to the point where everyone knows your reputation. You gain access to the Vain drawback.
    //66–70	Safety or Security You are cautious and guarded—wary of others who might harm you, steal from you, or betray your trust. As such, you sleep lightly, always suspecting someone or something to sneak in upon you in the dark. Even when in relationships with people who trust you, there’s always the fear that they harbor hidden agendas or will change and turn against you. You gain access to the Paranoid drawback.
    //71–75	Self-Doubt No matter what you do, it’s never good enough. You cannot help but see in your victories many little defeats and failures.If you were stronger, smarter, faster, or more powerful, maybe you could be better.However, stuck in the body and mind you have, you feel you’re destined to fail. You gain access to the Doubt drawback.
    //76–80	Social Acceptance   You want others to accept you, to believe you’re special and worthy of merit. You are self-conscious about your social flaws and breaches of etiquette.Rejection is among your greatest fears. You might go to extraordinary lengths to be accepted by or seek favor from your peers. You gain access to the Dependent drawback.
    //81–85	The Future  Your concerns lie not with the present, but with preparation for the future. You may be an avid and organized planner, or perhaps you see the signs of a coming dark age or troubled time. You behave cautiously, conservatively, and methodically as you plan for events that might one day occur. You gain access to the Meticulous drawback.
    //86–90	The Past    You long for the world to return to a past age. You’ve adopted the manners and style of this age, and are fascinated by its customs, relics, and artifacts, and by the historical figures of that time. Perhaps you live so much in this past age that your connection to the present is tenuous.Or your pretentiousness annoys others.You gain access to the Sentimental drawback.
    //91–95	Worldview In your eyes, your moral philosophy—your alignment—is the only correct and true way of the world. Perhaps you gently pity, argue with, or brawl with those misguided souls who don’t see the world your way or by your light of reason. You gain access to the Provincial drawback.
    //96–100	Youth You reflect upon your youth as a golden time, one ever present in your mind and that refuses to fade into the background. Every day, you feel yourself growing older and closer to your inevitable end.You seek ways to make yourself look and feel young in attempt to rekindle that fire of your adolescence, but despite your attempts, you realize that your time still draws ever nearer.You gain access to the Vain drawback.
    /// <summary>
    /// Character Drawback
    /// </summary>
    public static RandomTable CharacterDrawbackTable { get; } = new()
    {
        Name = "Character Drawback Table",
        DiceSides = 100,
        Table =
        [
            #region Attachment to an Object
            //01–05	Attachment(Object) You are attached to a precious possession with immense sentimental value and significance.Without it, you are no longer yourself and are prone to suffer from depression, moodiness, or aggressive behavior.You gain access to the Attached drawback.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 05,
                Name = nameof(CharacterDrawbackEnum.AttachmenttoanObject),
                ProperName = "Attachment to an Object",
                Description =
                    "You are attached to a precious " +
                    "possession with immense sentimental " +
                    "value and significance. Without it, " +
                    "you are no longer yourself and " +
                    "are prone to suffer from depression, " +
                    "moodiness, or aggressive behavior. ",
                Traits =
                {
                    //TraitEnum.Attached,
                },
            },
            #endregion

            #region Attachment to a Person
            //06–10	Attachment(Person) You are attached to a particular person—a friend, family member, or loved one—who means more than anything or anyone in the world.Your thoughts always return to this person.You gain access to the Attached drawback.
            new RandomTableEntry
            {
                LowerRange = 06,
                UpperRange = 10,
                Name = nameof(CharacterDrawbackEnum.AttachmenttoaPerson),
                ProperName = "Attachment to a Person",
                Description =
                    "You are attached to a particular " +
                    "person—a friend, family member, " +
                    "or loved one—who means more than " +
                    "anything or anyone in the world. " +
                    "Your thoughts always return to " +
                    "this person.",
                Traits =
                {
                },
            },
            #endregion

            #region Family
            //11–15	Family Your family means everything to you, and there is nothing you wouldn’t do for them.Maybe your ties extend to your entire clan or bloodline, or perhaps there is one specific member of your family you hold closer than any other. You gain access to the Family Ties drawback.
            new RandomTableEntry
            {
                LowerRange = 11,
                UpperRange = 15,
                Name = nameof(CharacterDrawbackEnum.Family),
                ProperName = "Family",
                Description =
                    "Your family means everything to " +
                    "you, and there is nothing you " +
                    "wouldn’t do for them. Maybe your " +
                    "ties extend to your entire clan " +
                    "or bloodline, or perhaps there is " +
                    "one specific member of your family " +
                    "you hold closer than any other. ", 
                Traits =
                {
                },
            },
            #endregion

            //16–20	Justice Unfairness and injustice are intolerable. Whenever you witness them, you feel compelled to act or speak out. When you’re personally wronged, you require appeasement—or revenge if you don’t receive it.You gain access to the Headstrong drawback.
            //21–25	Love Your love for someone motivates you.When this person is in danger, you’re prone to feel weak, powerless, or angry. You gain access to the Lovesick drawback.
            //26–30	Loyalty You value loyalty over all things.You treasure the friends, associates, and lovers you have earned throughout the years, and when someone breaks your trust or betrays you in some way, you become utterly unhinged. You gain access to the Pride drawback.
            //31–35	Material Wealth You have a weakness for material things—money, fine jewelry, exquisite foods, expensive or rare items, and so on.When such riches are within your reach, you’re driven to possess them, and you claim them either as an honest collector or a cunning thief.You gain access to the Avarice drawback.
            //36–40	Pleasure You crave luxury, entertainment, and pleasure. You might indulge in every passing fancy or hold strong against a temptation that constantly eats at you. You gain access to the Hedonistic drawback.
            //41–45	Power You long for the ability to influence the world around you, whether that’s as small as a village or as large as a plane of reality. You gain access to the Power-Hungry drawback.
            //46–50	Pride You present an image to the world that can’t be tarnished.When someone questions your motives, criticizes your actions, or insults your honor or pride, you question his friendship or count him among your enemies until he makes amends. You gain access to the Pride drawback.
            //51–55	Race You are truly comfortable only around others of your race, and you have a hard time putting faith or trust in those of races different from your own.You gain access to the Xenophobic drawback.
            //56–60	Religion Your beliefs are of paramount importance in your life, whether you belong to a temple, follow a cult, or practice a religious philosophy independently. When others question or attack the beliefs, principles, relics, or structures of your faith, you respond with fury. You gain access to the Zealous drawback.
            //61–65	Reputation or Fame You’ve worked hard to establish your identity and reputation, and someone who slanders or insults you must answer for it.You strive to promote your identity to the point where everyone knows your reputation. You gain access to the Vain drawback.
            //66–70	Safety or Security You are cautious and guarded—wary of others who might harm you, steal from you, or betray your trust. As such, you sleep lightly, always suspecting someone or something to sneak in upon you in the dark. Even when in relationships with people who trust you, there’s always the fear that they harbor hidden agendas or will change and turn against you. You gain access to the Paranoid drawback.
            //71–75	Self-Doubt No matter what you do, it’s never good enough. You cannot help but see in your victories many little defeats and failures.If you were stronger, smarter, faster, or more powerful, maybe you could be better.However, stuck in the body and mind you have, you feel you’re destined to fail. You gain access to the Doubt drawback.
            //76–80	Social Acceptance   You want others to accept you, to believe you’re special and worthy of merit. You are self-conscious about your social flaws and breaches of etiquette.Rejection is among your greatest fears. You might go to extraordinary lengths to be accepted by or seek favor from your peers. You gain access to the Dependent drawback.
            //81–85	The Future  Your concerns lie not with the present, but with preparation for the future. You may be an avid and organized planner, or perhaps you see the signs of a coming dark age or troubled time. You behave cautiously, conservatively, and methodically as you plan for events that might one day occur. You gain access to the Meticulous drawback.
            //86–90	The Past    You long for the world to return to a past age. You’ve adopted the manners and style of this age, and are fascinated by its customs, relics, and artifacts, and by the historical figures of that time. Perhaps you live so much in this past age that your connection to the present is tenuous.Or your pretentiousness annoys others.You gain access to the Sentimental drawback.
            //91–95	Worldview In your eyes, your moral philosophy—your alignment—is the only correct and true way of the world. Perhaps you gently pity, argue with, or brawl with those misguided souls who don’t see the world your way or by your light of reason. You gain access to the Provincial drawback.
            //96–100	Youth You reflect upon your youth as a golden time, one ever present in your mind and that refuses to fade into the background. Every day, you feel yourself growing older and closer to your inevitable end.You seek ways to make yourself look and feel young in attempt to rekindle that fire of your adolescence, but despite your attempts, you realize that your time still draws ever nearer.You gain access to the Vain drawback.
        ]
    };
}
