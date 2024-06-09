using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Models
{
    public partial class ArmorClassViewModel : DataObjectViewModel, IArmorClass
    {
        /// <summary>
        /// The base armor class for the creature
        /// </summary>
        [ObservableProperty]
        private int baseArmorClass = 10;

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
        [ObservableProperty]
        private int armorBonus = 0;

        /// <summary>
        /// Modifiers based on the characters class (wisdom
        /// for monks for example).
        /// </summary>
        [ObservableProperty]
        private int classBonus = 0;

        /// <summary>
        /// A deflection bonus affects armor class and 
        /// is granted by a spell or magic effect that 
        /// makes attacks veer off harmlessly. Deflection 
        /// bonuses stack with all other bonuses to AC 
        /// except other deflection bonuses. A deflection 
        /// bonus applies against touch attacks.
        /// </summary>
        [ObservableProperty]
        private int deflectionBonus = 0;

        /// <summary>
        /// Modifiers based on the characters dexterity
        /// </summary>
        [ObservableProperty]
        private int dexterityBonus = 0;

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
        /// <para>
        /// Dodge bonuses stack with all other bonuses to AC,
        /// even other dodge bonuses. Dodge bonuses apply 
        /// against touch attacks.
        /// </para>
        /// </summary>
        [ObservableProperty]
        private int dodgeBonus = 0;

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
        [ObservableProperty]
        private int enhancementBonus = 0;

        /// <summary>
        /// An insight bonus improves performance of a 
        /// given activity by granting the character an 
        /// almost precognitive knowledge of what might 
        /// occur. Multiple insight bonuses on the same 
        /// character or object do not stack. Only the 
        /// highest insight bonus applies.
        /// </summary>
        [ObservableProperty]
        private int insightBonus = 0;

        /// <summary>
        /// A luck bonus represents good (or bad) fortune. 
        /// Multiple luck bonuses on the same character 
        /// or object do not stack. Only the highest luck 
        /// bonus applies.
        /// </summary>
        [ObservableProperty]
        private int luckBonus = 0;

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
        [ObservableProperty]
        private int armorAndShield = (int) ArmorAndShieldEnum.Natural;

        /// <summary>
        /// A profane bonus (or penalty) stems from the 
        /// power of evil. Multiple profane bonuses 
        /// on the same character or object do not 
        /// stack. Only the highest profane bonus 
        /// applies.
        /// </summary>
        [ObservableProperty]
        private int profaneBonus = 0;

        /// <summary>
        /// A racial bonus comes from the culture a 
        /// particular creature was brought up in or 
        /// because of innate characteristics of that 
        /// type of creature. If a creature’s race 
        /// changes (for instance, if it dies and 
        /// is reincarnated), it loses all racial 
        /// bonuses it had in its previous form.
        /// </summary>
        [ObservableProperty]
        private int racialBonus = 0;

        /// <summary>
        /// A sacred bonus (or penalty) stems from the 
        /// power of good. Multiple sacred bonuses on 
        /// the same character or object do not stack. 
        /// Only the highest sacred bonus applies.
        /// </summary>
        [ObservableProperty]
        private int sacredBonus = 0;

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
        [ObservableProperty]
        private int shieldBonus = 0;

        /// <summary>
        /// A size bonus or penalty is derived from 
        /// a creature’s size category. Size modifiers 
        /// of different kinds apply to armor class, 
        /// attack rolls, Stealth checks, combat maneuver 
        /// checks, and various other checks.
        /// </summary>
        [ObservableProperty]
        private int sizeBonus = 0;

        /// <summary>
        /// Spell bonus
        /// </summary>
        [ObservableProperty]
        private int spellBonus = 0;

        /// <summary>
        /// Armor bonus from a magic Item
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<int> magicItemBonus = new ObservableCollection<int>();

        /// <summary>
        /// Raging as an example 
        /// </summary>
        [ObservableProperty]
        private int temporaryBonus = 0;

        /// <summary>
        /// The armor class with all bonuses
        /// </summary>
        /// <param name="attackType">The type of attack</param>
        /// <returns>The computed armor class</returns>
        public int AC(AttackTypeEnum attackType)
        {
            int itemBonus = 0;
            foreach (var item in MagicItemBonus)
            {
                itemBonus += item;
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
                + itemBonus;

            if (attackType != AttackTypeEnum.Touch)
            {
                ACBonus += ArmorBonus
                    + ClassBonus
                    + EnhancementBonus
                    //+ NaturalArmorBonus
                    + ShieldBonus;
            }

            return ACBonus;
        }

        /// <summary>
        /// The constructor
        /// </summary>
        public ArmorClassViewModel() 
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

        /// <summary>
        /// Set the armor class
        /// </summary>
        /// <param name="armorClass">The armor class</param>
        public ArmorClassViewModel(int armorClass)
            : base()
        {
            this.BaseArmorClass = armorClass;
        }
    }
}
