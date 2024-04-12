using System.Diagnostics.CodeAnalysis;

using D20.Core.Base;
using D20.Core.Enum;

namespace D20.Core.Models;

public class ArmorClass : DataObject
{
    /// <summary>
    /// Tha base armor class for the creature
    /// </summary>
    public int BaseArmorClass { get; set; } = 10;

    /// <summary>
    /// An armor bonus applies to armor class and 
    /// is granted by armor or by a spell or 
    /// magical effect that mimics armor. Armor 
    /// bonuses stack with all other bonuses to 
    /// armor class (even with natural armor bonuses) 
    /// except other armor bonuses. An armor bonus 
    /// doesn’t apply against touch attacks, except 
    /// for armor bonuses granted by force effects 
    /// (such as the mage armor spell) which apply 
    /// against incorporeal touch attacks, such as 
    /// that of a shadow.
    /// </summary>
    public int ArmorBonus { get; set; } = 0;

    /// <summary>
    /// Modifiers based on the characters class (wisdom
    /// for monks for example).
    /// </summary>
    public int ClassBonus { get; set; } = 0;

    /// <summary>
    /// A deflection bonus affects armor class and 
    /// is granted by a spell or magic effect that 
    /// makes attacks veer off harmlessly. Deflection 
    /// bonuses stack with all other bonuses to AC 
    /// except other deflection bonuses. A deflection 
    /// bonus applies against touch attacks.
    /// </summary>
    public int DeflectionBonus { get; set; } = 0;

    /// <summary>
    /// Modifiers based on the characters dexterity
    /// </summary>
    public int DexterityBonus { get; set; } = 0;

    /// <summary>
    /// A dodge bonus improves armor class (and 
    /// sometimes Reflex saves) resulting from 
    /// physical skill at avoiding blows and 
    /// other ill effects. Dodge bonuses are 
    /// never 1 usually not granted by spells 
    /// or magic items. Any situation or effect 
    /// (except wearing armor) that negates a 
    /// character’s Dexterity bonus also negates
    /// any dodge bonuses the character may have. 
    /// Dodge bonuses stack with all other bonuses to AC, even other dodge bonuses. Dodge bonuses apply against touch attacks.
    /// </summary>
    public int DodgeBonus { get; set; } = 0;

    /// <summary>
    /// An enhancement bonus represents an increase 
    /// in the sturdiness and/or effectiveness of 
    /// armor or natural armor, or the effectiveness 
    /// of a weapon, or a general bonus to an ability 
    /// score. Multiple enhancement bonuses on the 
    /// same object (in the case of armor and weapons), 
    /// creature (in the case of natural armor), or 
    /// ability score do not stack. Only the highest 
    /// enhancement bonus applies. Since enhancement 
    /// bonuses to armor or natural armor effectively 
    /// increase the armor or natural armor’s bonus to 
    /// AC, they don’t apply against touch attacks.
    /// </summary>
    public int EnhancementBonus { get; set; } = 0;

    /// <summary>
    /// An insight bonus improves performance of a 
    /// given activity by granting the character an 
    /// almost precognitive knowledge of what might 
    /// occur. Multiple insight bonuses on the same 
    /// character or object do not stack. Only the 
    /// highest insight bonus applies.
    /// </summary>
    public int InsightBonus { get; set; } = 0;

    /// <summary>
    /// A luck bonus represents good (or bad) fortune. 
    /// Multiple luck bonuses on the same character 
    /// or object do not stack. Only the highest luck 
    /// bonus applies.
    /// </summary>
    public int LuckBonus { get; set; } = 0;

    /// <summary>
    /// A natural armor bonus improves armor class 
    /// resulting from a creature’s naturally tough 
    /// hide. Natural armor bonuses stack with all 
    /// other bonuses to armor class (even with 
    /// armor bonuses) except other natural armor 
    /// bonuses. Some magical effects (such as the 
    /// barkskin spell) grant an enhancement bonus 
    /// to the creature’s existing natural armor 
    /// bonus, which has the effect of increasing 
    /// the natural armor’s overall bonus to armor 
    /// class. A natural armor bonus doesn’t apply 
    /// against touch attacks.
    /// </summary>
    public int NaturalArmorBonus { get; set; } = 0;

    /// <summary>
    /// A profane bonus (or penalty) stems from the 
    /// power of evil. Multiple profane bonuses 
    /// on the same character or object do not 
    /// stack. Only the highest profane bonus 
    /// applies.
    /// </summary>
    public int ProfaneBonus { get; set; } = 0;

    /// <summary>
    /// A racial bonus comes from the culture a 
    /// particular creature was brought up in or 
    /// because of innate characteristics of that 
    /// type of creature. If a creature’s race 
    /// changes (for instance, if it dies and 
    /// is reincarnated), it loses all racial 
    /// bonuses it had in its previous form.
    /// </summary>
    public int RacialBonus { get; set; } = 0;

    /// <summary>
    /// A sacred bonus (or penalty) stems from the 
    /// power of good. Multiple sacred bonuses on 
    /// the same character or object do not stack. 
    /// Only the highest sacred bonus applies.
    /// </summary>
    public int SacredBonus { get; set; } = 0;

    /// <summary>
    /// A shield bonus improves armor class and is 
    /// granted by a shield or by a spell or magic 
    /// effect that mimics a shield. Shield bonuses 
    /// stack with all other bonuses to AC except 
    /// other shield bonuses. A magic shield 
    /// typically grants an enhancement bonus 
    /// to the shield’s shield bonus, which has 
    /// the effect of increasing the shield’s 
    /// overall bonus to AC. A shield bonus granted
    /// by a spell or magic item typically takes 
    /// the form of an invisible, tangible field 
    /// of force that protects the recipient. A 
    /// shield bonus doesn’t apply against touch 
    /// attacks.
    /// </summary>
    public int ShieldBonus { get; set; } = 0;

    /// <summary>
    /// A size bonus or penalty is derived from 
    /// a creature’s size category. Size modifiers 
    /// of different kinds apply to armor class, 
    /// attack rolls, Stealth checks, combat maneuver 
    /// checks, and various other checks.
    /// </summary>
    public int SizeBonus { get; set; } = 0;

    /// <summary>
    /// Spell bonus from using a shield
    /// </summary>
    public int SpellBonus { get; set; } = 0;

    /// <summary>
    /// Spell bonus from using a shield
    /// </summary>
    public List<int> MagicItemBonus { get; set; } = new List<int>();

    /// <summary>
    /// Raging as an example 
    /// </summary>
    public int TemporaryBonus {  get; set; } = 0;

    /// <summary>
    /// The armor class with all bonuses
    /// </summary>
    /// <param name="attackType">The type of attack</param>
    /// <returns>The computed armor class</returns>
    public int AC(AttackTypeEnum attackType)
    {
        int itembonus = 0;
        foreach (var item in MagicItemBonus)
        {
            itembonus += item;
        }
        int ACBonus = BaseArmorClass
            + ClassBonus
            + DeflectionBonus
            + DexterityBonus
            + DodgeBonus
            + InsightBonus
            + LuckBonus
            + ProfaneBonus
            + RacialBonus
            + SacredBonus
            + SizeBonus
            + SpellBonus
            + TemporaryBonus
            + itembonus;

        if (attackType != AttackTypeEnum.Touch)
        {
            ACBonus += ArmorBonus
                + ClassBonus
                + EnhancementBonus
                + NaturalArmorBonus
                + ShieldBonus;
        }

        return ACBonus;
    }

    /// <summary>
    /// The constructor
    /// </summary>
    [SetsRequiredMembers]
    public ArmorClass() 
    {
        Name = "Armor Class";
        Description = "All creatures in the game " +
            "have an Armor Class. This score represents " +
            "how difficult a character is to hit with " +
            "weapons and some spells, and works much " +
            "like a Difficulty Class for attacks. As " +
            "with other scores, higher is better. This " +
            "is the target number enemies need to hit " +
            "you. Your basic AC is 10 + Dex modifier " +
            "armor bonus + shield bonus + spells or " +
            "magic items that grant an AC bonus. An " +
            "average unarmored person has an AC of " +
            "10. Armor and various abilities can " +
            "increase this number.";
    }
}
