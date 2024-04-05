using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Core.Data;

public class Traits
{
	public static List<Trait> TraitList { get; set; } = new List<Trait>()
	{
		#region Basic

		#region Absolute Loyalty
		new Trait
		{
			Name = nameof(TraitEnum.AbsoluteLoyalty),
			ProperName = "Absolute Loyalty",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/absolute-loyalty"),
			Description = "You gain the one-time ability to immediately cast atonement upon yourself as a spell-like ability upon performing an act or being subjected to an effect that spell affects. This ability can only be used while you are acting in the service of your liege (an individual of higher social standing chosen when you take this feat).)",
		},
		#endregion

		#region Accelerated Drinker
		new Trait
		{
			Name = nameof(TraitEnum.AcceleratedDrinker),
			ProperName = "Accelerated Drinker",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/accelerated-drinker"),
			Description = "You may drink a potion as a move action instead of a standard as long as you start your turn with the potion in your hand.)",
		},
		#endregion

		#region Acrobat
		new Trait
		{
			Name = nameof(TraitEnum.Acrobat),
			ProperName = "Acrobat",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/acrobat"),
			Description = "You gain a +1 bonus on Acrobatics checks, and you take only a –2 penalty instead of the normal – 5 penalty when using the Climb skill to attempt an accelerated climb.)",
		},
		#endregion

		#region Adopted
		new Trait
		{
			Name = nameof(TraitEnum.Adopted),
			ProperName = "Adopted",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/adopted"),
			Description = "You may select a race trait from your adoptive parents’ race.)",
		},
		#endregion

		#region Affable
		new Trait
		{
			Name = nameof(TraitEnum.Affable),
			ProperName = "Affable",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/affable-social"),
			Description = "You gain a +2 trait bonus on Diplomacy checks to gather information, and can do so in half the normal time. In addition, Diplomacy and Knowledge (local) are always class skills for you.)",
		},
		#endregion

		#region Air-Touched
		new Trait
		{
			Name = nameof(TraitEnum.AirTouched),
			ProperName = "Air-Touched",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/air-touched"),
			Description = "You gain DR 1/— against creatures and attacks with the air type.)",
		},
		#endregion

		#region Alchemical Adept
		new Trait
		{
			Name = nameof(TraitEnum.AlchemicalAdept),
			ProperName = "Alchemical Adept",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/alchemical-adept"),
			Description = "You gain a +2 trait bonus on all Craft (alchemy) checks made to craft alchemical items. Furthermore, when you fail a Craft (alchemy) check by 5 or more but don't roll a natural 1, you don't ruin any raw materials or have to pay that cost again.)",
		},
		#endregion

		#region Alchemical Intuition
		new Trait
		{
			Name = nameof(TraitEnum.AlchemicalIntuition),
			ProperName = "Alchemical Intuition",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/alchemical-intuition"),
			Description = "Once per day as a free action, you may gain a trait bonus equal to your Charisma modifier (minimum 0) on a Craft (alchemy) check you make. You can apply this bonus after you roll the check, possibly turning a failure into a success.)",
		},
		#endregion

		#region Alert
		new Trait
		{
			Name = nameof(TraitEnum.Alert),
			ProperName = "Alert",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			Description = "Once per day as a free action, you can take 10 on your initiative check.)",
		},
		#endregion

		#region Ambitious
		new Trait
		{
			Name = nameof(TraitEnum.Ambitious),
			ProperName = "Ambitious",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/ambitious"),
			Description = "You gain a +4 trait bonus on Diplomacy checks made to influence creatures with at least 5 Hit Dice more than you possess.)",
		},
		#endregion

		#region Ambush Training
		new Trait
		{
			Name = nameof(TraitEnum.AmbushTraining),
			ProperName = "Ambush Training",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/ambush-training"),
			Description = "You gain a +1 trait bonus on initiative checks and a +1 trait bonus on weapon damage rolls during any surprise round in which you act.)",
		},
		#endregion

		#region Amiable Blunder
		new Trait
		{
			Name = nameof(TraitEnum.AmiableBlunder),
			ProperName = "Amiable Blunder",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/amiable-blunder-social"),
			Description = "Once per day when you fail a Diplomacy check by 5 or more and would cause an NPC's attitude toward you to worsen, you can immediately attempt another Diplomacy check against the same DC as a free action. If you succeed at this second Diplomacy check, the character's attitude doesn't change, as though you had failed the original check by 4 or less.)",
		},
		#endregion

		#region Anatomist
		new Trait
		{
			Name = nameof(TraitEnum.Anatomist),
			ProperName = "Anatomist",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/anatomist"),
			Description = "You gain a +1 trait bonus on all rolls made to confirm critical hits.)",
		},
		#endregion

		#region Arcane Revitalization
		new Trait
		{
			Name = nameof(TraitEnum.ArcaneRevitalization),
			ProperName = "Arcane Revitalization",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/arcane-revitalization"),
			Description = "Once per day, when you confirm a critical hit with a weapon attack, you regain 1 arcane pool point. You can't exceed your maximum number of arcane pool points.)",
		},
		#endregion

		#region Arcane Temper
		new Trait
		{
			Name = nameof(TraitEnum.ArcaneTemper),
			ProperName = "Arcane Temper",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/arcane-temper"),
			Description = "You gain a +1 trait bonus on concentration and initiative checks.)",
		},
		#endregion

		#region Armor Expert
		new Trait
		{
			Name = nameof(TraitEnum.ArmorExpert),
			ProperName = "Armor Expert",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/armor-expert"),
			Description = "Armor check penalties for armor you wear are reduced by 1, to a minimum of 0.)",
		},
		#endregion

		#region Artisan
		new Trait
		{
			Name = nameof(TraitEnum.Artisan),
			ProperName = "Artisan",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/artisan"),
			Description = "You gain a +2 trait bonus on a single Craft skill (your choice).)",
		},
		#endregion

		#region Ascendant Recollection
		new Trait
		{
			Name = nameof(TraitEnum.AscendantRecollection),
			ProperName = "Ascendant Recollection",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/ascendant-recollection"),
			Description = "Your sorcerer level is considered to be 1 level higher when determining the effects of your 1st-level bloodline power.)",
		},
		#endregion

		#region Authoritarian
		new Trait
		{
			Name = nameof(TraitEnum.Authoritarian),
			ProperName = "Authoritarian",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/authoritarian"),
			Description = "As long as you are acting in the service of a liege or leader you recognize as legitimate, you gain a +2 trait bonus on saving throws against fear and compulsion effects.)",
		},
		#endregion

		#region Avid Reader
		new Trait
		{
			Name = nameof(TraitEnum.AvidReader),
			ProperName = "Avid Reader",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/avid-reader"),
			Description = "Choose one Knowledge skill. You can always choose to take 10 on checks with the chosen Knowledge skill, even when distracted or threatened.)",
		},
		#endregion

		#region Axe to Grind
		new Trait
		{
			Name = nameof(TraitEnum.AxetoGrind),
			ProperName = "Axe to Grind",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/axe-to-grind"),
			Description = "You gain a +1 trait bonus on damage against foes who are threatened by only you.)",
		},
		#endregion

		#region Balancer's Banishing
		new Trait
		{
			Name = nameof(TraitEnum.BalancersBanishing),
			ProperName = "Balancers Banishing",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/balancer-s-banishing-magic"),
			Description = "As long as you remain neutral, whenever you cast a spell that would send an outsider with the chaotic, evil, good, or lawful subtype back to its home plane, the spell's saving throw DC increases by 1.)",
		},
		#endregion

		#region Bastard
		new Trait
		{
			Name = nameof(TraitEnum.Bastard),
			ProperName = "Bastard",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/bastard"),
			Description = "You gain a +1 trait bonus on Sense Motive checks, and Sense Motive is always a class skill for you.)",
		},
		#endregion

		#region Battlefield Disciple
		new Trait
		{
			Name = nameof(TraitEnum.BattlefieldDisciple),
			ProperName = "Battlefield Disciple",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/battlefield-disciple"),
			Description = "You gain a +2 trait bonus on Heal checks made to stabilize a dying creature. In addition, when you successfully use the aid another action in combat to grant an ally a bonus on her next attack roll, the bonus you grant increases by 1.)",
		},
		#endregion

		#region Beacon of Faith
		new Trait
		{
			Name = nameof(TraitEnum.BeaconofFaith),
			ProperName = "Beacon of Faith",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/beacon-of-faith"),
			Description = "Once per day as a free action, you may treat your caster level as if it were 2 levels higher when using one of the granted powers of your domain or inquisition, or when casting one of your domain spells.)",
		},
		#endregion

		#region Beast Bond
		new Trait
		{
			Name = nameof(TraitEnum.BeastBond),
			ProperName = "Beast Bond",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/beast-bond"),
			Description = "You gain a +1 bonus on Handle Animal checks and Ride checks. One of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Beast of the Society
		new Trait
		{
			Name = nameof(TraitEnum.BeastoftheSociety),
			ProperName = "Beast of the Society",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			CharacterClass = ClassEnum.Druid,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/beast-of-the-society-druid-pathfinder-society"),
			Description = "Whenever you use your wild shape class ability to turn yourself into a Small or Medium-sized animal, the effect lasts for 2 hours per druid level instead of 1 hour per druid level.)",
		},
		#endregion

		#region Berserker of the Society
		new Trait
		{
			Name = nameof(TraitEnum.BerserkeroftheSociety),
			ProperName = "Berserker of the Society",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			CharacterClass = ClassEnum.Barbarian,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/berserker-of-the-society-barbarian-pathfinder-society"),
			Description = "You may use your rage ability for 3 additional rounds per day.)",
		},
		#endregion

		#region Birthmark
		new Trait
		{
			Name = nameof(TraitEnum.Birthmark),
			ProperName = "Birthmark",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/birthmark"),
			Description = "Your birthmark can serve as a divine focus for casting spells and you gain a +2 trait bonus on all saving throws against charm and compulsion effects.)",
		},
		#endregion

		#region Black Powder Bravado
		new Trait
		{
			Name = nameof(TraitEnum.BlackPowderBravado),
			ProperName = "Black Powder Bravado",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/black-powder-bravado"),
			Description = "Once per day, when you perform a deed that requires an attack roll and you miss with that roll, you can reroll it. You must take the second result even if it is worse.)",
		},
		#endregion

		#region Black Powder Fortune
		new Trait
		{
			Name = nameof(TraitEnum.BlackPowderFortune),
			ProperName = "Black Powder Fortune",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/black-powder-fortune"),
			Description = "As long as you are wielding a firearm, you gain a +2 trait bonus on all saving throws against curse, fear, and emotion effects.)",
		},
		#endregion

		#region Black Powder Interjection
		new Trait
		{
			Name = nameof(TraitEnum.BlackPowderInterjection),
			ProperName = "Black Powder Interjection",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/black-powder-interjection"),
			Description = "Once per day, when you interrupt the casting of a spell with a firearm attack, you may regain 1 grit point.)",
		},
		#endregion

		#region Bladed Magic
		new Trait
		{
			Name = nameof(TraitEnum.BladedMagic),
			ProperName = "Bladed Magic",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/bladed-magic"),
			Description = "You gain a +1 trait bonus on Craft checks made to craft magic or masterwork weapons. In addition, when you use your arcane pool class ability to grant a weapon an enhancement bonus, that bonus lasts for 2 minutes instead of 1.)",
		},
		#endregion

		#region Blade of the Society
		new Trait
		{
			Name = nameof(TraitEnum.BladeoftheSociety),
			ProperName = "Blade of the Society",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			CharacterClass = ClassEnum.Rogue,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/blade-of-the-society-rogue-pathfinder-society"),
			Description = "You gain a +1 trait bonus to damage rolls from sneak attacks.)",
		},
		#endregion

		#region Blessed
		new Trait
		{
			Name = nameof(TraitEnum.Blessed),
			ProperName = "Blessed",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/blessed"),
			Description = "Once per day as a swift action, you gain a +1 trait bonus on all saving throws for 1 round.)",
		},
		#endregion

		#region Blessed Touch
		new Trait
		{
			Name = nameof(TraitEnum.BlessedTouch),
			ProperName = "Blessed Touch",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/blessed-touch-faith"),
			Description = "You heal 1 additional point of damage when using lay on hands, channeling energy, or casting a cure spell.)",
		},
		#endregion

		#region Bloodthirsty
		new Trait
		{
			Name = nameof(TraitEnum.Bloodthirsty),
			ProperName = "Bloodthirsty",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/bloodthirsty"),
			Description = "Whenever you make an attack that reduces a foe to 0 hit points or fewer or you confirm a critical hit, your attack deals 1 additional point of damage. The additional damage is a trait bonus, and is multiplied by your weapon's critical hit multiplier.)",
		},
		#endregion

		#region Bloody-Minded
		new Trait
		{
			Name = nameof(TraitEnum.BloodyMinded),
			ProperName = "Bloody-Minded",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/bloody-minded-combat"),
			Description = "You gain a +1 trait bonus on initiative and Intimidate checks.)",
		},
		#endregion

		#region Born under the Stranger
		new Trait
		{
			Name = nameof(TraitEnum.BornundertheStranger),
			ProperName = "Born under the Stranger",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			Description = "When feinting against aberrations, you do not take a –4 penalty for feinting against a non-humanoid creature, and you take only a –4 penalty if you feint against an aberration of animal Intelligence instead of –8). You still cannot feint against mindless creatures.)",
		},
		#endregion

		#region Bruising Intellect
		new Trait
		{
			Name = nameof(TraitEnum.BruisingIntellect),
			ProperName = "Bruising Intellect",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/bruising-intellect"),
			Description = "Intimidate is always a class skill for you, and you may use your Intelligence modifier when making Intimidate checks instead of your Charisma modifier.)",
		},
		#endregion

		#region Bullied
		new Trait
		{
			Name = nameof(TraitEnum.Bullied),
			ProperName = "Bullied",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/bullied"),
			Description = "You gain a +1 trait bonus on attacks of opportunity attack rolls made with unarmed strikes.)",
		},
		#endregion

		#region Bully
		new Trait
		{
			Name = nameof(TraitEnum.Bully),
			ProperName = "Bully",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/bully"),
			Description = "You gain a +1 trait bonus on Intimidate checks, and Intimidate is always a class skill for you.)",
		},
		#endregion

		#region Calculated Bribe
		new Trait
		{
			Name = nameof(TraitEnum.CalculatedBribe),
			ProperName = "Calculated Bribe",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/calculated-bribe"),
			Description = "Once per day while negotiating with another intelligent creature, you can spend a number of gold pieces equal to your level × 10 in order to reroll a Diplomacy check you just made, before the results are revealed. You must take the result of the reroll, even if it's worse than the original roll. In addition, you begin play with a set of extravagant noble's clothes worth 100 gp.)",
		},
		#endregion

		#region Called
		new Trait
		{
			Name = nameof(TraitEnum.Called),
			ProperName = "Called",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/called"),
			Description = "Once per day upon rolling a natural 1 on an attack roll, you may reroll the die and take the second result instead.)",
		},
		#endregion

		#region Canter
		new Trait
		{
			Name = nameof(TraitEnum.Canter),
			ProperName = "Canter",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/canter"),
			Description = "Anyone who attempts to use Bluff to deliver a secret message to you gains a +5 bonus on his Bluff check. When you attempt to intercept a secret message using Sense Motive, you gain a +5 trait bonus on the attempt.)",
		},
		#endregion

		#region Careful Combatant
		new Trait
		{
			Name = nameof(TraitEnum.CarefulCombatant),
			ProperName = "Careful Combatant",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/careful-combatant-combat"),
			Description = "When using the withdraw action, both the first and second squares of your movement are not considered threatened by any opponents you can see, rather than just the first square.)",
		},
		#endregion

		#region Caretaker
		new Trait
		{
			Name = nameof(TraitEnum.Caretaker),
			ProperName = "Caretaker",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/caretaker"),
			Description = "You gain a +1 trait bonus on Heal checks, and Heal is always a class skill for you.)",
		},
		#endregion

		#region Charlatan
		new Trait
		{
			Name = nameof(TraitEnum.Charlatan),
			ProperName = "Charlatan",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/charlatan-gnome-magic"),
			Description = "As a swift action, you may expend one prepared spell or spell slot to gain a bonus on the next Bluff check you make, provided the check takes place before the beginning of your next turn. The bonus on this check is equal to the level of the spell consumed. You may use this ability 3 times per day.)",
		},
		#endregion

		#region Charming
		new Trait
		{
			Name = nameof(TraitEnum.Charming),
			ProperName = "Charming",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/charming"),
			Description = "You gain a +1 trait bonus when you use Bluff or Diplomacy on a character that is (or could be) sexually attracted to you, and a +1 trait bonus to the save DC of any language-dependent spell you cast on such characters or creatures.)",
		},
		#endregion

		#region Child of the Moon
		new Trait
		{
			Name = nameof(TraitEnum.ChildoftheMoon),
			ProperName = "Child of the Moon",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/child-of-the-moon-magic"),
			Description = "Choose either Climb, Stealth, or Swim. You gain a +1 trait bonus on checks made with the chosen skill. On dates during and after the first quarter of a lunar phase but before end of the last quarter (the half of the lunar cycle where the moon is fuller), this bonus increases to +2. During the full moon, this bonus increases to +4.)",
		},
		#endregion

		#region Child of the Streets
		new Trait
		{
			Name = nameof(TraitEnum.ChildoftheStreets),
			ProperName = "Child of the Streets",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/child-of-the-streets"),
			Description = "You gain a +1 trait bonus on Sleight of Hand checks, and Sleight of Hand is always a class skill for you.)",
		},
		#endregion

		#region Child of the Temple
		new Trait
		{
			Name = nameof(TraitEnum.ChildoftheTemple),
			ProperName = "Child of the Temple",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/child-of-the-temple"),
			Description = "You gain a +1 trait bonus on Knowledge (nobility and royalty) and Knowledge (religion) checks, and one of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Chosen One
		new Trait
		{
			Name = nameof(TraitEnum.ChosenOne),
			ProperName = "Chosen One",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/chosen-one-faith"),
			Description = "You may cast light once per day as a spell-like ability (caster level 1st), and you begin play with a masterwork longsword. In addition, whenever light is cast upon this sword, the radius of light and its duration is doubled.)",
		},
		#endregion

		#region Civilized
		new Trait
		{
			Name = nameof(TraitEnum.Civilized),
			ProperName = "Civilized",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/civilized"),
			Description = "You gain a +1 trait bonus on Knowledge (nobility) checks and Knowledge (local) checks. Knowledge (local) is always a class skill for you.)",
		},
		#endregion

		#region Classically Schooled
		new Trait
		{
			Name = nameof(TraitEnum.ClassicallySchooled),
			ProperName = "Classically Schooled",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/classically-schooled"),
			Description = "You gain a +1 trait bonus on Spellcraft checks, and Spellcraft is always a class skill for you.)",
		},
		#endregion

		#region Clever Wordplay
		new Trait
		{
			Name = nameof(TraitEnum.CleverWordplay),
			ProperName = "Clever Wordplay",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/clever-wordplay"),
			Description = "Choose one Charisma-based skill. You attempt checks with that skill using your Intelligence modifier instead of your Charisma modifier.)",
		},
		#endregion

		#region Coherent Rage
		new Trait
		{
			Name = nameof(TraitEnum.CoherentRage),
			ProperName = "Coherent Rage",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/coherent-rage-ulfen-guard"),
			Description = "Select one of the following skills: Bluff, Escape Artist, Handle Animal, or Stealth. You may use this skill normally while raging.)",
		},
		#endregion

		#region Cold and Calculating
		new Trait
		{
			Name = nameof(TraitEnum.ColdandCalculating),
			ProperName = "Cold and Calculating",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/cold-and-calculating"),
			Description = "You gain a +1 trait bonus on all Bluff checks against favored enemies that share one of your subtypes. You also gain a +1 trait bonus on attack rolls made against such favored enemies during the surprise round.)",
		},
		#endregion

		#region Collector
		new Trait
		{
			Name = nameof(TraitEnum.Collector),
			ProperName = "Collector",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/collector-gnome-social"),
			Description = "Select one of the following skills: Craft (any one), Disable Device, Escape Artist, Perform (any one), Spellcraft. Whenever you have your collection within 5 feet of you, you gain a +2 trait bonus on all checks made with the selected skill. Once this skill has been selected, it cannot be changed, nor can you gain it for any other collection you begin amassing.)",
		},
		#endregion

		#region Competitive
		new Trait
		{
			Name = nameof(TraitEnum.Competitive),
			ProperName = "Competitive",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/competitive"),
			Description = "Whenever another creature within 30 feet attempts a skill check and you attempt a check with the same skill before the start of that creature's next turn, you gain a +1 trait bonus on your check (this includes attempting an opposed skill check against the creature).)",
		},
		#endregion

		#region Contagious Mettle
		new Trait
		{
			Name = nameof(TraitEnum.ContagiousMettle),
			ProperName = "Contagious Mettle",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/contagious-mettle"),
			Description = "If you follow this code, you gain a +1 trait bonus on Will saving throws against fear. In addition, any allies adjacent to you receive a +1 morale bonus on Will saving throws against fear.)",
		},
		#endregion

		#region Convincing Liar
		new Trait
		{
			Name = nameof(TraitEnum.ConvincingLiar),
			ProperName = "Convincing Liar",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/convincing-liar"),
			Description = "You gain a +1 trait bonus on Bluff or Intimidate checks and one of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Cooperative Combatant
		new Trait
		{
			Name = nameof(TraitEnum.CooperativeCombatant),
			ProperName = "Cooperative Combatant",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +2 trait bonus on attack rolls to perform the aid another action.)",
		},
		#endregion

		#region Courageous
		new Trait
		{
			Name = nameof(TraitEnum.Courageous),
			ProperName = "Courageous",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/courageous"),
			Description = "You gain a +2 trait bonus on saving throws against fear effects.)",
		},
		#endregion

		#region Criminal
		new Trait
		{
			Name = nameof(TraitEnum.Criminal),
			ProperName = "Criminal",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/criminal"),
			Description = "Select one of the following skills: Disable Device, Intimidate, or Sleight of Hand. You gain a +1 trait bonus on that skill, and it is always a class skill for you.)",
		},
		#endregion

		#region Cross-Disciplined
		new Trait
		{
			Name = nameof(TraitEnum.CrossDisciplined),
			ProperName = "Cross-Disciplined",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/cross-disciplined"),
			Description = "Once per day, you may cast a spell you have prepared that appears on both the magus and wizard spell lists as if your caster level were 1 level higher.)",
		},
		#endregion

		#region Cross-Knowledge
		new Trait
		{
			Name = nameof(TraitEnum.CrossKnowledge),
			ProperName = "Cross-Knowledge",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/cross-knowledge"),
			Description = "Once per day, you may treat an extract you drink as if your caster level were 1 level higher as long as that extract appears on the wizard spell list and the alchemist list of formulae.)",
		},
		#endregion

		#region Crowd Dodger
		new Trait
		{
			Name = nameof(TraitEnum.CrowdDodger),
			ProperName = "Crowd Dodger",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/crowd-dodger"),
			Description = "You gain a +2 trait bonus on Acrobatics checks to move through another creature's space and to avoid attacks of opportunity for leaving a threatened square.)",
		},
		#endregion

		#region Cynical Ear
		new Trait
		{
			Name = nameof(TraitEnum.CynicalEar),
			ProperName = "Cynical Ear",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/cynical-ear-social"),
			Description = "Add 2 when determining your Hit Dice for Intimidate checks, and increase the DC or all Diplomacy checks against you by 2.)",
		},
		#endregion

		#region Dangerously Curious
		new Trait
		{
			Name = nameof(TraitEnum.DangerouslyCurious),
			ProperName = "Dangerously Curious",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/dangerously-curious"),
			Description = "You gain a +1 bonus on Use Magic Device checks, and Use Magic Device is always a class skill for you.)",
		},
		#endregion

		#region Dedicated Defender
		new Trait
		{
			Name = nameof(TraitEnum.DedicatedDefender),
			ProperName = "Dedicated Defender",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/dedicated-defender"),
			Description = "You gain a +1 trait bonus on attack rolls and on checks made to overcome spell resistance while you are adjacent to a dying or disabled ally, animal companion, eidolon, familiar, or mount.)",
		},
		#endregion

		#region Deep Guardian
		new Trait
		{
			Name = nameof(TraitEnum.DeepGuardian),
			ProperName = "Deep Guardian",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/deep-guardian-dwarf-magic-trait"),
			Description = "Any creature you conjure with a summon spell that has the earth subtype or a burrow speed gains a +1 morale bonus on attack rolls and a +1 enhancement bonus to Armor Class for the duration of the spell that summoned it.)",
		},
		#endregion

		#region Defender of the Society
		new Trait
		{
			Name = nameof(TraitEnum.DefenderoftheSociety),
			ProperName = "Defender of the Society",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			CharacterClass = ClassEnum.Fighter,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/defender-of-the-society-fighter-pathfinder-society"),
			Description = "You gain a +1 trait bonus to Armor Class when wearing medium or heavy armor.)",
		},
		#endregion

		#region Deft Dodger
		new Trait
		{
			Name = nameof(TraitEnum.DeftDodger),
			ProperName = "Deft Dodger",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/deft-dodger"),
			Description = "You gain a +1 trait bonus on Reflex saving throws.)",
		},
		#endregion

		#region Demon Slayer
		new Trait
		{
			Name = nameof(TraitEnum.DemonSlayer),
			ProperName = "Demon Slayer",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/demon-slayer-mendev-crusaders"),
			Description = "You can attempt a Knowledge (planes) check to find a demon’s weak spot. (DC 10 + the demon’s CR). If you succeed, you gain a +3 trait bonus on rolls to confirm critical hits against that demon until the end of the battle. This effect only works on demons.)",
		},
		#endregion

		#region Demon Smiter
		new Trait
		{
			Name = nameof(TraitEnum.DemonSmiter),
			ProperName = "Demon Smiter",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/demon-smiter-combat"),
			Description = "Once per day when fighting demons, you gain a +4 trait bonus on a single attack roll.)",
		},
		#endregion

		#region Desperate Resolve
		new Trait
		{
			Name = nameof(TraitEnum.DesperateResolve),
			ProperName = "Desperate Resolve",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/desperate-resolve"),
			Description = "You gain a +1 trait bonus on concentration checks. This trait bonus increases to + 4 when you are grappled, pinned, in violent weather, or entangled.)",
		},
		#endregion

		#region Desperate Speed
		new Trait
		{
			Name = nameof(TraitEnum.DesperateSpeed),
			ProperName = "Desperate Speed",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/desperate-speed"),
			Description = "Your eidolon receives a +5-foot enhancement bonus to one type of speed it has that you do not, such as a climb or swim speed. If your eidolon doesn't already possess such a mode of movement, you may apply this trait bonus later if it gains an evolution that grants it such a mode. Once this bonus is applied to a mode of movement, it can't be switched to another mode.)",
		},
		#endregion

		#region Destined Diplomat
		new Trait
		{
			Name = nameof(TraitEnum.DestinedDiplomat),
			ProperName = "Destined Diplomat",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/destined-diplomat"),
			Description = "You gain a +2 trait bonus on Diplomacy checks toward outsiders, and Diplomacy is always a class skill for you.)",
		},
		#endregion

		#region Detect Disobedience
		new Trait
		{
			Name = nameof(TraitEnum.DetectDisobedience),
			ProperName = "Detect Disobedience",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/detect-disobedience-social"),
			Description = "You gain a +2 trait bonus on Sense Motive checks to detect when an underling is trying to hide something from you, and can attempt such checks instead of Perception checks to notice and react to a subordinate's surprise attack against you.)",
		},
		#endregion

		#region Devoted Healer
		new Trait
		{
			Name = nameof(TraitEnum.DevotedHealer),
			ProperName = "Devoted Healer",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/devoted-healer"),
			Description = "Whenever you take 20 on a Heal check to treat deadly wounds, you restore an additional 1d4 hit points to those you aid.)",
		},
		#endregion

		#region Devotee of the Green
		new Trait
		{
			Name = nameof(TraitEnum.DevoteeoftheGreen),
			ProperName = "Devotee of the Green",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/devotee-of-the-green"),
			Description = "You gain a +1 trait bonus on Knowledge (geography) and Knowledge (nature) checks, and one of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Diabolical Dabbler
		new Trait
		{
			Name = nameof(TraitEnum.DiabolicalDabbler),
			ProperName = "Diabolical Dabbler",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/diabolical-dabbler"),
			Description = "Fiendish animals you conjure with summon spells gain +1 hp per hit die for the duration of the spell that summoned it.)",
		},
		#endregion

		#region Dirty Fighter
		new Trait
		{
			Name = nameof(TraitEnum.DirtyFighter),
			ProperName = "Dirty Fighter",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/dirty-fighter"),
			Description = "You gain a +1 trait bonus to damage rolls against opponents you are flanking.)",
		},
		#endregion

		#region Disdainful Defender
		new Trait
		{
			Name = nameof(TraitEnum.DisdainfulDefender),
			ProperName = "Disdainful Defender",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/disdainful-defender"),
			Description = "You gain a +2 trait bonus on all Will saves you attempt against divine spells. This bonus does not apply against divine spells cast by a caster who worships the same deity you do.)",
		},
		#endregion

		#region Disillusioned
		new Trait
		{
			Name = nameof(TraitEnum.Disillusioned),
			ProperName = "Disillusioned",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/disillusioned"),
			Description = "You gain a +2 trait bonus on Will saving throws against emotion and fear effects.)",
		},
		#endregion

		#region Dismantle Order
		new Trait
		{
			Name = nameof(TraitEnum.DismantleOrder),
			ProperName = "Dismantle Order",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/dismantle-order"),
			Description = "Once per day, you can use detect law as a spell-like ability (caster level 1st). If you have levels in a class that can cast detect law, your caster level for this spell-like ability is equal to that class level.)",
		},
		#endregion

		#region Dispelled Battler
		new Trait
		{
			Name = nameof(TraitEnum.DispelledBattler),
			ProperName = "Dispelled Battler",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/dispelled-battler"),
			Description = "You gain a +1 trait bonus on weapon attack and damage rolls while within an area of antimagic such as that created by an antimagic field. You also gain this bonus for 1 round after you are subject to an area or targeted dispel magic spell, regardless of the effect's success or failure in dispelling your spells and magical effects.)",
		},
		#endregion

		#region Distance Aptitude
		new Trait
		{
			Name = nameof(TraitEnum.DistanceAptitude),
			ProperName = "Distance Aptitude",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/distance-aptitude"),
			Description = "Treat your caster level as 1 higher for the purposes of determining the range of spells and spell-like abilities.)",
		},
		#endregion

		#region Domineering
		new Trait
		{
			Name = nameof(TraitEnum.Domineering),
			ProperName = "Domineering",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/domineering"),
			Description = "Choose one 1st-level enchantment spell you are capable of casting. The DC of that spell increases by 1.)",
		},
		#endregion

		#region Doublespeak
		new Trait
		{
			Name = nameof(TraitEnum.Doublespeak),
			ProperName = "Doublespeak",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/doublespeak-social"),
			Description = "You gain a +2 trait bonus on Bluff checks to pass along secret messages.)",
		},
		#endregion

		#region Dueling Cloak Adept
		new Trait
		{
			Name = nameof(TraitEnum.DuelingCloakAdept),
			ProperName = "Dueling Cloak Adept",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/dueling-cloak-adept"),
			Description = "While wearing a cloak and using a dueling sword, you gain a +2 trait bonus on Bluff checks made to feint. Additionally, every time you successfully feint while wearing a cloak, you gain a +1 dodge bonus to your Armor Class until your next turn.)",
		},
		#endregion

		#region Earthbound
		new Trait
		{
			Name = nameof(TraitEnum.Earthbound),
			ProperName = "Earthbound",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/earthbound"),
			Description = "Your druid spells use a handful of earth or sand as a divine focus in addition to the normal components. While you are touching the ground, you add a +2 trait bonus to saving throw DCs and on caster level checks to overcome spell resistance for all spells you cast against creatures with the air subtype.)",
		},
		#endregion

		#region Earth-Touched
		new Trait
		{
			Name = nameof(TraitEnum.EarthTouched),
			ProperName = "Earth-Touched",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/earth-touched"),
			Description = "You gain DR 1/— against attacks from creatures with the earth subtype.)",
		},
		#endregion

		#region Ease of Faith
		new Trait
		{
			Name = nameof(TraitEnum.EaseofFaith),
			ProperName = "Ease of Faith",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/ease-of-faith"),
			Description = "You gain a +1 bonus on Diplomacy checks, and Diplomacy is always a class skill for you.)",
		},
		#endregion

		#region Easy Way or the Hard Way
		new Trait
		{
			Name = nameof(TraitEnum.EasyWayortheHardWay),
			ProperName = "Easy Way or the Hard Way",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/easy-way-or-the-hard-way"),
			Description = "Whenever you attack one of your favored enemies with a weapon that deals lethal damage and choose to deal nonlethal damage, you take only a –2 penalty on the attack roll instead of the normal –4 .)",
		},
		#endregion

		#region Eldritch Delver
		new Trait
		{
			Name = nameof(TraitEnum.EldritchDelver),
			ProperName = "Eldritch Delver",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/eldritch-delver"),
			Description = "You gain a +1 trait bonus on all Knowledge (dungeoneering) and Knowledge (history) checks, and you may treat your caster level as 1 level higher for all conjuration spells of the teleportation subschool.)",
		},
		#endregion

		#region Eldritch Smith
		new Trait
		{
			Name = nameof(TraitEnum.EldritchSmith),
			ProperName = "Eldritch Smith",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/eldritch-smith"),
			Description = "Whenever you use the Craft skill or a crafting feat to make stone or metal items, or items which include stone or metal in their design, you reduce the cost of making the item by 5%.)",
		},
		#endregion

		#region Elemental Endowment
		new Trait
		{
			Name = nameof(TraitEnum.ElementalEndowment),
			ProperName = "Elemental Endowment",
			Category = TraitCategoryEnum.Regional,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/elemental-endowment-regional"),
			Description = "As an immediate action, once per day when you cast a spell with the air, earth, fire, or water descriptor, you can gain a number of temporary hit points equal to the spell's level. This effect lasts for 1 minute.)",
		},
		#endregion

		#region Enduring Mutagen
		new Trait
		{
			Name = nameof(TraitEnum.EnduringMutagen),
			ProperName = "Enduring Mutagen",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/enduring-mutagen"),
			Description = "The bonuses and penalties granted by your mutagens last for 1 additional minute per alchemist level.)",
		},
		#endregion

		#region Enemy of Slavers
		new Trait
		{
			Name = nameof(TraitEnum.EnemyofSlavers),
			ProperName = "Enemy of Slavers",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/enemy-of-slavers"),
			Description = "You gain a +2 trait bonus on Diplomacy and Intimidate checks made to sway the minds of slavers and anyone who otherwise keeps innocent people against their will.)",
		},
		#endregion

		#region Etymologist
		new Trait
		{
			Name = nameof(TraitEnum.Etymologist),
			ProperName = "Etymologist",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/etymologist-gnome-social"),
			Description = "You gain a +1 trait bonus on Linguistics checks, know one additional bonus language, and treat Linguistics as a class skill.)",
		},
		#endregion

		#region Evasive Sting
		new Trait
		{
			Name = nameof(TraitEnum.EvasiveSting),
			ProperName = "Evasive Sting",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/evasive-sting"),
			Description = "You gain a +1 dodge bonus to AC against enemies that are both your favored enemy and at least two size categories larger than you.)",
		},
		#endregion

		#region Exalted of the Society
		new Trait
		{
			Name = nameof(TraitEnum.ExaltedoftheSociety),
			ProperName = "Exalted of the Society",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			CharacterClass = ClassEnum.Cleric,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/exalted-of-the-society-cleric-pathfinder-society"),
			Description = "You may channel energy 1 additional time per day.)",
		},
		#endregion

		#region Excitable
		new Trait
		{
			Name = nameof(TraitEnum.Excitable),
			ProperName = "Excitable",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/excitable"),
			Description = "You gain a +2 trait bonus on all Initiative checks.)",
		},
		#endregion

		#region Explorer
		new Trait
		{
			Name = nameof(TraitEnum.Explorer),
			ProperName = "Explorer",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/explorer-gnome-social"),
			Description = "When you gain a level, select a terrain type from the following list: cold, desert, forest, jungle, mountains (including hills), plains, planes (other than the Material Plane), swamp, underground (including caves and dungeons), urban, water. You gain a +2 bonus on all Survival checks made in your desired terrain type. At the beginning of each level, you must select a new desired terrain type to replace the old one (you cannot take the same desired terrain type two levels in a row).)",
		},
		#endregion

		#region Faithful Feedback
		new Trait
		{
			Name = nameof(TraitEnum.FaithfulFeedback),
			ProperName = "Faithful Feedback",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/faithful-feedback-any-religion"),
			Description = "Whenever you cast a spell belonging to the healing subschool on someone of your religion, increase the hit points healed by +1.)",
		},
		#endregion

		#region Faith's Hunter
		new Trait
		{
			Name = nameof(TraitEnum.FaithsHunter),
			ProperName = "Faiths Hunter",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/faith-s-hunter"),
			Description = "When you confirm a critical hit against a favored enemy, you may extend the duration of any divine spell affecting you by 1 round. The benefits from multiple critical hits stack. Divine spells with an instantaneous duration can't be extended in this manner.)",
		},
		#endregion

		#region Fast-Talker
		new Trait
		{
			Name = nameof(TraitEnum.FastTalker),
			ProperName = "Fast-Talker",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/fast-talker"),
			Description = "You gain a +1 trait bonus on Bluff checks, and Bluff is always a class skill for you.)",
		},
		#endregion

		#region Fate's Favored
		new Trait
		{
			Name = nameof(TraitEnum.FatesFavored),
			ProperName = "Fates Favored",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/fate-s-favored"),
			Description = "Whenever you gain a luck bonus, that bonus increases by 1.)",
		},
		#endregion

		#region Fearless Defiance
		new Trait
		{
			Name = nameof(TraitEnum.FearlessDefiance),
			ProperName = "Fearless Defiance",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/fearless-defiance"),
			Description = "You gain a +1 trait bonus on all saving throws against fear effects. In addition, if you successfully save against such an effect, you receive a +1 trait bonus on attack rolls against your favored enemies for 1 round.)",
		},
		#endregion

		#region Fencer
		new Trait
		{
			Name = nameof(TraitEnum.Fencer),
			ProperName = "Fencer",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/fencer"),
			Description = "You gain a +1 trait bonus on attacks of opportunity made with daggers, swords, and similar bladed weapons.)",
		},
		#endregion

		#region Fey Protection
		new Trait
		{
			Name = nameof(TraitEnum.FeyProtection),
			ProperName = "Fey Protection",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/fey-protection"),
			Description = "You gain a +1 trait bonus to AC against attacks of opportunities made by fey and a +1 trait bonus on saving throws against the effects of fey creatures.)",
		},
		#endregion

		#region Firebug
		new Trait
		{
			Name = nameof(TraitEnum.Firebug),
			ProperName = "Firebug",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/firebug"),
			Description = "You gain a +1 trait bonus on attack rolls made with thrown splash weapons and alchemist bombs.)",
		},
		#endregion

		#region First Memories
		new Trait
		{
			Name = nameof(TraitEnum.FirstMemories),
			ProperName = "First Memories",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/first-memories-gnome-faith"),
			Description = "You do not gain the normal spell-like abilities for the gnome magic racial trait. Instead, if you have a Wisdom of 11 of higher, you gain the following spell-like abilities: 1/day—detect poison, know direction, stabilize, and speak with animals. The caster level for these effects is equal to your character level. The DC for these spells is equal to 10 + the spell’s level + your Wisdom modifier.)",
		},
		#endregion

		#region Flame-Touched
		new Trait
		{
			Name = nameof(TraitEnum.FlameTouched),
			ProperName = "Flame-Touched",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/flame-touched"),
			Description = "You gain DR 1/— against creatures and attacks with the fire type.)",
		},
		#endregion

		#region Focused Burn
		new Trait
		{
			Name = nameof(TraitEnum.FocusedBurn),
			ProperName = "Focused Burn",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/focused-burn"),
			Description = "Any bombs you have that deal fire damage deal 1 additional point of fire damage on a direct hit per 2d6 of fire damage normally dealt (minimum 1 point). This additional damage does not apply to the bomb's splash damage.)",
		},
		#endregion

		#region Focused Disciple
		new Trait
		{
			Name = nameof(TraitEnum.FocusedDisciple),
			ProperName = "Focused Disciple",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/focused-disciple"),
			Description = "You gain a +2 trait bonus on saving throws against charm and compulsion effects.)",
		},
		#endregion

		#region Focused Mind
		new Trait
		{
			Name = nameof(TraitEnum.FocusedMind),
			ProperName = "Focused Mind",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/focused-mind"),
			Description = "You gain a +2 trait bonus on concentration checks.)",
		},
		#endregion

		#region Fortunate
		new Trait
		{
			Name = nameof(TraitEnum.Fortunate),
			ProperName = "Fortunate",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/fortunate"),
			Description = "Once per day when you use a spell or magic item with a randomized effect (such as confusion, mirror image, prismatic spray, or a bag of tricks), before you roll to determine the result, you may choose to roll twice and pick either result.)",
		},
		#endregion

		#region Free Spirit
		new Trait
		{
			Name = nameof(TraitEnum.FreeSpirit),
			ProperName = "Free Spirit",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/free-spirit"),
			Description = "You gain a +1 trait bonus on saving throws against language-dependent and effects with the sonic descriptor. In addition, the DC to Intimidate you increases by 2.)",
		},
		#endregion

		#region Friend in Every Town
		new Trait
		{
			Name = nameof(TraitEnum.FriendinEveryTown),
			ProperName = "Friend in Every Town",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/friend-in-every-town"),
			Description = "You gain a +1 trait bonus on all Knowledge (local) checks and Diplomacy checks. One of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Friends in High Places
		new Trait
		{
			Name = nameof(TraitEnum.FriendsinHighPlaces),
			ProperName = "Friends in High Places",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/friends-in-high-places"),
			Description = "Whenever you are in an area in which you have used the Diplomacy skill to gather information, you gain a +1 trait bonus on Diplomacy and Intimidate checks. This bonus increases to +2 when dealing with government officials.)",
		},
		#endregion

		#region Friends in Low Places
		new Trait
		{
			Name = nameof(TraitEnum.FriendsinLowPlaces),
			ProperName = "Friends in Low Places",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/friends-in-low-places-social"),
			Description = "Diplomacy checks to gather information in lower quarters, such as vice dens and poorer districts, takes you 1d2 hours (instead of 1d4 hours). In addition, the attitudes of any destitute or impoverished NPCs you interact with begin one step closer to helpful.)",
		},
		#endregion

		#region Ghost Sight
		new Trait
		{
			Name = nameof(TraitEnum.GhostSight),
			ProperName = "Ghost Sight",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/ghost-sight"),
			Description = "You receive a +2 trait bonus to Perception checks when trying to locate undead, and can attempt to locate ethereal undead (though they are still considered merely invisible, +20 to Stealth).)",
		},
		#endregion

		#region Gifted Adept
		new Trait
		{
			Name = nameof(TraitEnum.GiftedAdept),
			ProperName = "Gifted Adept",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/gifted-adept"),
			Description = "Pick a spell when you choose this trait—from this point on, whenever you cast that spell, its effects manifest at +1 caster level.)",
		},
		#endregion

		#region Gnomish Alchemist
		new Trait
		{
			Name = nameof(TraitEnum.GnomishAlchemist),
			ProperName = "Gnomish Alchemist",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/businessman-gnome-social"),
			Description = "You gain a +2 trait bonus on all Craft (alchemy) checks.)",
		},
		#endregion

		#region Greater Adept of the Society
		new Trait
		{
			Name = nameof(TraitEnum.GreaterAdeptoftheSociety),
			ProperName = "Greater Adept of the Society",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			CharacterClass = ClassEnum.Wizard,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/greater-adept-of-the-society-wizard-pathfinder-society"),
			Description = "You gain one additional 0-level spell slot.)",
		},
		#endregion

		#region Greater Link
		new Trait
		{
			Name = nameof(TraitEnum.GreaterLink),
			ProperName = "Greater Link",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/greater-link"),
			Description = "Your eidolon's current and maximum hit point totals are not reduced by 50% until you are separated by 110 feet or more. Your eidolon's current and maximum hit point totals are not reduced by 75% until you are separated by 1,100 feet or more. All other aspects of your life link class feature are unaffected.)",
		},
		#endregion

		#region Greater Purpose
		new Trait
		{
			Name = nameof(TraitEnum.GreaterPurpose),
			ProperName = "Greater Purpose",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/greater-purpose"),
			Description = "You gain a +1 trait bonus on all saving throws to resist death effects and a +1 trait bonus on Constitution checks made to stabilize while dying.)",
		},
		#endregion

		#region Gregarious
		new Trait
		{
			Name = nameof(TraitEnum.Gregarious),
			ProperName = "Gregarious",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/gregarious"),
			Description = "Once per day, when you attempt a Diplomacy check to improve a creature's attitude toward you, you may choose to reroll the check after the first roll is made but before the results are revealed. You must take the second result, even if it is worse.)",
		},
		#endregion

		#region Grief-Filled
		new Trait
		{
			Name = nameof(TraitEnum.GriefFilled),
			ProperName = "Grief-Filled",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/grief-filled"),
			Description = "You gain a +2 trait bonus on all saving throws against emotion spells and effects.)",
		},
		#endregion

		#region Grim Optimism
		new Trait
		{
			Name = nameof(TraitEnum.GrimOptimism),
			ProperName = "Grim Optimism",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/grim-optimi"),
			Description = "As a standard action, you can joke about a troublesome situation to lighten the load of dealing with it for yourself and others. You and all allies within 30 feet who can hear you gain a +2 morale bonus on saving throws against fear and pain effects for 1d4 rounds. A character cannot benefit from this effect more than once in 24 hours.)",
		},
		#endregion

		#region Hardly a Fool
		new Trait
		{
			Name = nameof(TraitEnum.HardlyaFool),
			ProperName = "Hardly a Fool",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/hardly-a-fool-social"),
			Description = "You gain a +1 trait bonus on Sense Motive checks and a +1 trait bonus on saving throws against illusion effects.)",
		},
		#endregion

		#region Hard to Kill
		new Trait
		{
			Name = nameof(TraitEnum.HardtoKill),
			ProperName = "Hard to Kill",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/hard-to-kill-combat"),
			Description = "When you are attempting a Constitution check to stabilize when dying, the penalty on the check is only half your negative hit point total instead of your full negative hit point total.)",
		},
		#endregion

		#region Harvester
		new Trait
		{
			Name = nameof(TraitEnum.Harvester),
			ProperName = "Harvester",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/harvester"),
			Description = "You gain a +1 trait bonus on Profession (tanner) or Profession (trapper) checks, and you may make these checks as if you were trained in the skill even if you have no ranks. Additionally, you do not risk poisoning yourself whenever you handle or apply poison taken from a venomous creature.)",
		},
		#endregion

		#region Havoc of the Society
		new Trait
		{
			Name = nameof(TraitEnum.HavocoftheSociety),
			ProperName = "Havoc of the Society",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			CharacterClass = ClassEnum.Sorcerer,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/havoc-of-the-society-sorcerer-pathfinder-society"),
			Description = "Whenever you cast a spell that deals damage, you gain a +1 trait bonus to the total damage dealt. This damage is considered force damage regardless of the type of damage dealt by the spell.)",
		},
		#endregion

		#region Hedge Magician
		new Trait
		{
			Name = nameof(TraitEnum.HedgeMagician),
			ProperName = "Hedge Magician",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/hedge-magician"),
			Description = "Whenever you craft a magic item, you reduce the cost of gp required to make the item by 5%.)",
		},
		#endregion

		#region Hell Knight Ancestry
		new Trait
		{
			Name = nameof(TraitEnum.HellKnightAncestry),
			ProperName = "Hell Knight Ancestry",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/hellknight-ancestry"),
			Description = "You gain a +2 trait bonus on Diplomacy checks to influence Hellknights and a +2 trait bonus on Intimidate checks to influence enemies of the Hellknights.)",
		},
		#endregion

		#region Helpful
		new Trait
		{
			Name = nameof(TraitEnum.Helpful),
			ProperName = "Helpful",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/helpful-combat"),
			Description = "When using the aid another action, you grant your ally a +3 bonus instead of a +2 bonus.)",
		},
		#endregion

		#region Hidden Hand
		new Trait
		{
			Name = nameof(TraitEnum.HiddenHand),
			ProperName = "Hidden Hand",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/hidden-hand"),
			Description = "You gain a +1 trait bonus on Sleight of Hand checks made to conceal light weapons and a +1 trait bonus on attack rolls when making an attack with a light weapon during a surprise round.)",
		},
		#endregion

		#region Hill Fighter
		new Trait
		{
			Name = nameof(TraitEnum.HillFighter),
			ProperName = "Hill Fighter",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/hill-fighter"),
			Description = "You may run or charge downhill on a steep slope (moving up to your base speed) without making an Acrobatics check to avoid stumbling but if you travel farther than this distance, the normal rules for steep slopes apply.)",
		},
		#endregion

		#region History of Heresy
		new Trait
		{
			Name = nameof(TraitEnum.HistoryofHeresy),
			ProperName = "History of Heresy",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/history-of-heresy"),
			Description = "As long as you do not possess any levels in a class that grants divine spellcasting power, you gain a +1 trait bonus on all saving throws made against divine spells.)",
		},
		#endregion

		#region Holdout
		new Trait
		{
			Name = nameof(TraitEnum.Holdout),
			ProperName = "Holdout",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/holdout"),
			Description = "You gain a +1 trait bonus to your CMD against disarm and steal combat maneuvers.)",
		},
		#endregion

		#region Honest
		new Trait
		{
			Name = nameof(TraitEnum.Honest),
			ProperName = "Honest",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/honest"),
			Description = "You gain a +1 trait bonus on Diplomacy checks. This bonus increases to +2 when the Diplomacy check is made to influence those who are already friendly or helpful toward you.)",
		},
		#endregion

		#region Honored Fist of the Society
		new Trait
		{
			Name = nameof(TraitEnum.HonoredFistoftheSociety),
			ProperName = "Honored Fist of the Society",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			CharacterClass = ClassEnum.Monk,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/honored-fist-of-the-society-monk-pathfinder-society"),
			Description = "You increase your ki pool by 1 point.)",
		},
		#endregion

		#region Horrifying Mind
		new Trait
		{
			Name = nameof(TraitEnum.HorrifyingMind),
			ProperName = "Horrifying Mind",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/horrifying-mind-magic"),
			Description = "When a non-evil humanoid attempts to read your mind via a magical effect, the reader must attempt a Will save opposed by your Wisdom or Charisma check (your choice). If the reader fails this save, she is shaken for 1 round. If she fails by 10 or more, she is instead frightened for 1 round, then shaken for 1 round.)",
		},
		#endregion

		#region Hunter's Blood
		new Trait
		{
			Name = nameof(TraitEnum.HuntersBlood),
			ProperName = "Hunters Blood",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/hunter-s-blood"),
			Description = "You gain a +1 trait bonus on Diplomacy checks to gather information, to Knowledge (religion) checks, and to Survival checks to track undead. Choose one as these as a class skill. Undead gain a +1 bonus on any rolls made to determine if they know anything about you.)",
		},
		#endregion

		#region Hunter's Knack
		new Trait
		{
			Name = nameof(TraitEnum.HuntersKnack),
			ProperName = "Hunters Knack",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/hunter-s-knack"),
			Description = "You gain a +1 trait bonus on attack rolls against your favored enemies when you make such attacks as part of a readied action.)",
		},
		#endregion

		#region Imposing Scion
		new Trait
		{
			Name = nameof(TraitEnum.ImposingScion),
			ProperName = "Imposing Scion",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/imposing-scion"),
			Description = "You gain a +1 trait bonus on Intimidate checks. If your bloodline is keyed to a specific creature type, your trait bonus increases to +2 when interacting with creatures of that type.)",
		},
		#endregion

		#region Improvised Defense
		new Trait
		{
			Name = nameof(TraitEnum.ImprovisedDefense),
			ProperName = "Improvised Defense",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/improvised-defense-combat"),
			Description = "Whenever you wield an improvised weapon, you gain a +1 shield bonus to AC. If you use the improvised weapon to attack, you lose this shield bonus until the beginning of your next turn.)",
		},
		#endregion

		#region Indelible Ire
		new Trait
		{
			Name = nameof(TraitEnum.IndelibleIre),
			ProperName = "Indelible Ire",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/indelible-ire"),
			Description = "Each time a critical hit is confirmed against you, you gain a +1 trait bonus on attack rolls for 1 round.)",
		},
		#endregion

		#region Indomitable Faith
		new Trait
		{
			Name = nameof(TraitEnum.IndomitableFaith),
			ProperName = "Indomitable Faith",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/indomitable-faith"),
			Description = "You gain a +1 trait bonus on Will saving throws.)",
		},
		#endregion

		#region Inexorable Authority
		new Trait
		{
			Name = nameof(TraitEnum.InexorableAuthority),
			ProperName = "Inexorable Authority",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/inexorable-authority-social"),
			Description = "You gain a +2 trait bonus on Intimidate checks when enforcing or pronouncing a lawful judgment that you're legitimately deputed to enforce or pronounce.)",
		},
		#endregion

		#region Influence
		new Trait
		{
			Name = nameof(TraitEnum.Influence),
			ProperName = "Influence",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/influence"),
			Description = "Choose one of the following skills: Diplomacy, Intimidate, or Sense Motive. You gain a +1 trait bonus on that skill, and it is always a class skill for you.)",
		},
		#endregion

		#region Insistent Benefactor
		new Trait
		{
			Name = nameof(TraitEnum.InsistentBenefactor),
			ProperName = "Insistent Benefactor",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/insistent-benefactor"),
			Description = "Whenever you cast a harmless spell, you gain a +2 trait bonus on caster level checks to overcome spell resistance, and the saving throw DC of the spell (if any) is increased by 2.)",
		},
		#endregion

		#region Inspired
		new Trait
		{
			Name = nameof(TraitEnum.Inspired),
			ProperName = "Inspired",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/inspired"),
			Description = "Once per day as a free action, roll twice and take the better result on a skill check or ability check.)",
		},
		#endregion

		#region Inspiring
		new Trait
		{
			Name = nameof(TraitEnum.Inspiring),
			ProperName = "Inspiring",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/inspiring"),
			Description = "As a standard action, you can speak words of encouragement to grant a +1 morale bonus to an ally within 30 feet who can see and hear you. The ally can use this bonus on any d20 roll of her choice before the start of your next turn. You cannot use this trait to grant a bonus to yourself or to an ally who has already benefited from this trait within the last 24 hours.)",
		},
		#endregion

		#region Inspiring Rush
		new Trait
		{
			Name = nameof(TraitEnum.InspiringRush),
			ProperName = "Inspiring Rush",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/inspiring-rush"),
			Description = "Once per day when you make a charge attack, you gain a +1 trait bonus on both your attack and damage rolls, as do any allies who make a charge attack before the beginning of your next turn.)",
		},
		#endregion

		#region Inured to Death
		new Trait
		{
			Name = nameof(TraitEnum.InuredtoDeath),
			ProperName = "Inured to Death",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/inured-to-death"),
			Description = "You gain a +2 trait bonus on saving throws against death effects.)",
		},
		#endregion

		#region Irrepressible
		new Trait
		{
			Name = nameof(TraitEnum.Irrepressible),
			ProperName = "Irrepressible",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/irrepressible"),
			Description = "You can use your Charisma modifier in place of your Wisdom modifier when attempting Will saving throws against charm and compulsion effects.)",
		},
		#endregion

		#region Jungle Fighter
		new Trait
		{
			Name = nameof(TraitEnum.JungleFighter),
			ProperName = "Jungle Fighter",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/jungle-fighter"),
			Description = "Your speed may not be reduced to less than 10 feet by difficult terrain in jungles (meaning you may take a 5-foot step in difficult terrain and not provoke an attack of opportunity).)",
		},
		#endregion

		#region Just Like New
		new Trait
		{
			Name = nameof(TraitEnum.JustLikeNew),
			ProperName = "Just Like New",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/just-like-new"),
			Description = "Your first attempt to remove the broken condition from your starting firearm and to upgrade it to a masterwork weapon costs 150 gp instead of 300 gp. In addition, when wielding a firearm that has the broken condition or is treated as if it had the broken condition, you take a –1 penalty on attack rolls made with it instead of the normal –2.)",
		},
		#endregion

		#region Keen Appraiser
		new Trait
		{
			Name = nameof(TraitEnum.KeenAppraiser),
			ProperName = "Keen Appraiser",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/keen-appraiser"),
			Description = "You gain a +1 trait bonus on Appraise checks. In addition, you need only exceed the DC of an Appraise check by 2 in order to determine whether the item in question has magic properties (although success still does not grant knowledge of the magic item's abilities).)",
		},
		#endregion

		#region Killer
		new Trait
		{
			Name = nameof(TraitEnum.Killer),
			ProperName = "Killer",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/killer"),
			Description = "You gain a trait bonus to damage rolls equal to your weapon’s critical hit modifier when you score a successful critical hit with a weapon; this additional damage is added to the final total.)",
		},
		#endregion

		#region Kin Bond
		new Trait
		{
			Name = nameof(TraitEnum.KinBond),
			ProperName = "Kin Bond",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/kin-bond"),
			Description = "Choose a sibling with whom to share this bond. Once per day when you fail a saving throw while your sibling is within 30 feet, you may reroll that saving throw using your sibling's saving throw modifier. If you and the sibling are twins or otherwise part of a multiple birth, you gain a +2 trait bonus on the rerolled saving throw. Your sibling must be willing to grant you the reroll. If you fail the saving throw, you and your sibling are dazed for 1 round.)",
		},
		#endregion

		#region Kin Guardian
		new Trait
		{
			Name = nameof(TraitEnum.KinGuardian),
			ProperName = "Kin Guardian",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/kin-guardian"),
			Description = "When you use the aid another action to give a member of your family a bonus to AC, increase the bonus by 2. This increase is a trait bonus (and therefore doesn't stack with increases granted by other family members using this trait). This trait has no effect when using the aid another action to increase a family member's next attack roll.)",
		},
		#endregion

		#region Knowing the Enemy
		new Trait
		{
			Name = nameof(TraitEnum.KnowingtheEnemy),
			ProperName = "Knowing the Enemy",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/knowing-the-enemy"),
			Description = "You gain a +1 trait bonus on checks with the Knowledge skill corresponding to your first favored enemy choice, and that Knowledge skill is always a class skill for you.)",
		},
		#endregion

		#region Knowledgeable Caster
		new Trait
		{
			Name = nameof(TraitEnum.KnowledgeableCaster),
			ProperName = "Knowledgeable Caster",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/knowledgeable-caster"),
			Description = "Once per day when you cast a divination spell, you can cast that spell as if your caster level were 1 level higher in the appropriate class. You also gain a +1 trait bonus on any Knowledge checks associated with your sorcerer bloodline, if any.)",
		},
		#endregion

		#region Larger Than Life
		new Trait
		{
			Name = nameof(TraitEnum.LargerThanLife),
			ProperName = "Larger Than Life",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/larger-than-life"),
			Description = "When you use the Intimidate skill on a creature while wielding a firearm, you are considered one size category larger than your actual size.)",
		},
		#endregion

		#region Law Enforcer
		new Trait
		{
			Name = nameof(TraitEnum.LawEnforcer),
			ProperName = "Law Enforcer",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/law-enforcer"),
			Description = "You receive a +2 bonus on Sense Motive checks to gain a hunch from social situations, and begin play with a pair of masterwork manacles.)",
		},
		#endregion

		#region Life of Toil
		new Trait
		{
			Name = nameof(TraitEnum.LifeofToil),
			ProperName = "Life of Toil",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/life-of-toil"),
			Description = "You gain a +1 trait bonus on Fortitude saves.)",
		},
		#endregion

		#region Linked Surge
		new Trait
		{
			Name = nameof(TraitEnum.LinkedSurge),
			ProperName = "Linked Surge",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/linked-surge"),
			Description = "Once per day, you may make a Strength- or Constitution-based ability check or skill check using you eidolon's ability score in place of your own. Your eidolon must be summoned and with 30 feet for you to use this trait.)",
		},
		#endregion

		#region Lost Nobility
		new Trait
		{
			Name = nameof(TraitEnum.LostNobility),
			ProperName = "Lost Nobility",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/lost-nobility"),
			Description = "You gain a +1 trait bonus on attack and damage rolls against government officials of your homeland.)",
		},
		#endregion

		#region Loyalty across Lifetimes
		new Trait
		{
			Name = nameof(TraitEnum.LoyaltyacrossLifetimes),
			ProperName = "Loyalty across Lifetimes",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/loyalty-across-lifetimes"),
			Description = "Your eidolon treats its Constitution score as if it were 2 points higher for the purposes of determining when its negative hit point total sends it back to its home plane. In addition, your eidolon gains a +1 trait bonus on Will saving throws against enchantment spells and effects.)",
		},
		#endregion

		#region Lucid Dreamer
		new Trait
		{
			Name = nameof(TraitEnum.LucidDreamer),
			ProperName = "Lucid Dreamer",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/lucid-dreamer-varisian-wanderers-wonderseekers"),
			Description = "You receive a +1 trait bonus on Knowledge (planes) checks and a +2 trait bonus on Will saving throws against effects on your dreaming mind or subconscious, such as a night hag’s dream haunting ability, the nightmare spell, and illusions of the phantasm subschool.)",
		},
		#endregion

		#region Lunar Birth 
		new Trait
		{
			Name = nameof(TraitEnum.LunarBirth),
			ProperName = "Lunar Birth",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on saving throws against the spells and spell-like abilities cast by humans.)",
		},
		#endregion

		#region Maestro of the Society
		new Trait
		{
			Name = nameof(TraitEnum.MaestrooftheSociety),
			ProperName = "Maestro of the Society",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			CharacterClass = ClassEnum.Bard,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/maestro-of-society"),
			Description = "You may use bardic performance 3 additional rounds per day.)",
		},
		#endregion

		#region Magical Flair
		new Trait
		{
			Name = nameof(TraitEnum.MagicalFlair),
			ProperName = "Magical Flair",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/magical-flair"),
			Description = "Choose a school of magic. The Spellcraft DC to identify spells you cast from that school of magic increases by 2. Creatures that fail a Spellcraft check to identify your spell by 2 or less incorrectly identify the spell as another randomly selected spell of the same school and level.)",
		},
		#endregion

		#region Magical Knack
		new Trait
		{
			Name = nameof(TraitEnum.MagicalKnack),
			ProperName = "Magical Knack",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/magical-knack"),
			Description = "Pick a class when you gain this trait—your caster level in that class gains a +2 trait bonus as long as this bonus doesn’t increase your caster level higher than your current Hit Dice.)",
		},
		#endregion

		#region Magical Lineage
		new Trait
		{
			Name = nameof(TraitEnum.MagicalLineage),
			ProperName = "Magical Lineage",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/magical-lineage"),
			Description = "Pick one spell when you choose this trait. When you apply metamagic feats to this spell, treat its actual level as 1 lower for determining the spell’s final adjusted level.)",
		},
		#endregion

		#region Magical Talent
		new Trait
		{
			Name = nameof(TraitEnum.MagicalTalent),
			ProperName = "Magical Talent",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/magical-talent"),
			Description = "Choose a 0-level spell. You may cast that spell once per day as a spell-like ability. This spell-like ability is cast at your highest caster level gained; if you have no caster level, it functions at CL 1st. The spell-like ability’s save DC is Charisma-based.)",
		},
		#endregion

		#region Magic Crafter
		new Trait
		{
			Name = nameof(TraitEnum.MagicCrafter),
			ProperName = "Magic Crafter",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/magic-crafter"),
			Description = "You gain a +1 trait bonus on Appraise checks and a +1 bonus on any Craft checks attempted while making magic items.)",
		},
		#endregion

		#region Malleable Magic
		new Trait
		{
			Name = nameof(TraitEnum.MalleableMagic),
			ProperName = "Malleable Magic",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/malleable-magic"),
			Description = "Once per day as a swift action, you can lose a single 1st-, 2nd- or 3rd-level magus spell to regain 1 arcane pool point. You can't exceed the maximum number of arcane pool points in your arcane pool by using this trait.)",
		},
		#endregion

		#region Marked by Unknown Forces
		new Trait
		{
			Name = nameof(TraitEnum.MarkedbyUnknownForces),
			ProperName = "Marked by Unknown Forces",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/marked-by-unknown-forces-social"),
			Description = "You may cast light three times per day as a spell-like ability, but this ability only targets the palm of your hand, and it manifests as a glowing sigil the appearance of which is determined by you and your GM. Those who recognize this symbol have a starting attitude toward you of one step closer to friendly (if they are followers of or scholars studying the sign) or one step closer to hostile (if they are opposed to the sign or its followers).)",
		},
		#endregion

		#region Martial Manuscript
		new Trait
		{
			Name = nameof(TraitEnum.MartialManuscript),
			ProperName = "Martial Manuscript",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/martial-manuscript"),
			Description = "You gain a +2 trait bonus on rolls to confirm critical hits when you're using an unarmed strike or monk weapon.)",
		},
		#endregion

		#region Martial Performer
		new Trait
		{
			Name = nameof(TraitEnum.MartialPerformer),
			ProperName = "Martial Performer",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/martial-performer"),
			Description = "When you gain a monk bonus feat, you may instead take a performance feat for which you meet the prerequisites.)",
		},
		#endregion

		#region Mathematical Prodigy
		new Trait
		{
			Name = nameof(TraitEnum.MathematicalProdigy),
			ProperName = "Mathematical Prodigy",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/mathematical-prodigy"),
			Description = "You gain a +1 bonus on Knowledge (arcana) and Knowledge (engineering) checks, and one of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Mediator
		new Trait
		{
			Name = nameof(TraitEnum.Mediator),
			ProperName = "Mediator",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/mediator-social"),
			Description = "You receive a +1 trait bonus on Diplomacy checks. In addition, you receive a +1 trait bonus to the DC of any charm or compulsion effect that does not provide ongoing control and results in peaceful acts, such as calm emotions, sleep, or a suggestion to lay down arms.)",
		},
		#endregion

		#region Memorable
		new Trait
		{
			Name = nameof(TraitEnum.Memorable),
			ProperName = "Memorable",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/memorable"),
			Description = "When you modify a creature's attitude with Diplomacy or Intimidate, the attitude change lasts 1-1/2 times longer than it otherwise would. Your spells or effects with the fear or mind-affecting descriptors that impose a penalty or bonus with a duration of at least 2 rounds, lasts 1 additional round.)",
		},
		#endregion

		#region Mentored
		new Trait
		{
			Name = nameof(TraitEnum.Mentored),
			ProperName = "Mentored",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/mentored"),
			Description = "Choose a single Craft, Perform, or Profession skill. You gain a +1 trait bonus on checks with that skill. You also gain a +1 trait bonus when you aid another's skill check with any skill.)",
		},
		#endregion

		#region Mercenary
		new Trait
		{
			Name = nameof(TraitEnum.Mercenary),
			ProperName = "Mercenary",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/mercenary"),
			Description = "You gain a +2 trait bonus on Diplomacy, Intimidate, and Sense Motive checks made while negotiating payment for a quest or a service that you provide.)",
		},
		#endregion

		#region Merchant
		new Trait
		{
			Name = nameof(TraitEnum.Merchant),
			ProperName = "Merchant",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/merchant"),
			Description = "You gain a +1 trait bonus on any Appraise and Sense Motive checks you attempt while bargaining for the price of goods. Appraise is always a class skill for you.)",
		},
		#endregion

		#region Meticulous Concoction
		new Trait
		{
			Name = nameof(TraitEnum.MeticulousConcoction),
			ProperName = "Meticulous Concoction",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/meticulous-concoction"),
			Description = "Once per day, you can either add a +2 trait bonus to the save DC for one bomb you throw or extend the duration of one extract you imbibe by 2 rounds. Extracts with an instantaneous duration are not affected by this trait.)",
		},
		#endregion

		#region Muscle of the Society
		new Trait
		{
			Name = nameof(TraitEnum.MuscleoftheSociety),
			ProperName = "Muscle of the Society",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/muscle-of-the-society"),
			Description = "You gain a +2 trait bonus on Strength checks made to break doors and lift portcullises, and you treat your Strength score as 2 higher for the purpose of determining your carrying capacity.)",
		},
		#endregion

		#region Mutant Eye
		new Trait
		{
			Name = nameof(TraitEnum.MutantEye),
			ProperName = "Mutant Eye",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/mutant-eye"),
			Description = "You have a third eye on your forehead. As long as it is uncovered and open, you can get a clearer sense of the emotions of those you see, granting you a +2 trait bonus on Sense Motive checks that increases to +4 on checks to notice whether a character is under a mind-affecting effect. However, the eye is unsettling, and you take a –1 penalty on Bluff and Diplomacy checks against humanoids who can see it.)",
		},
		#endregion

		#region Mystery Initiate
		new Trait
		{
			Name = nameof(TraitEnum.MysteryInitiate),
			ProperName = "Mystery Initiate",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/mystery-initiate"),
			Description = "Once per day, you may reroll any Knowledge skill check. You must decide to use this ability after the first roll is made but before the results are revealed. You must take the second result, even if it is worse.)",
		},
		#endregion

		#region Natural-Born Leader
		new Trait
		{
			Name = nameof(TraitEnum.NaturalBornLeader),
			ProperName = "Natural-Born Leader",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/natural-born-leader"),
			Description = "All cohorts, followers, or summoned creatures under your leadership gain a +1 morale bonus on Will saves to avoid mind-affecting effects. If you ever take the Leadership feat, you gain a +1 trait bonus to your Leadership score.)",
		},
		#endregion

		#region Naturally Gifted
		new Trait
		{
			Name = nameof(TraitEnum.NaturallyGifted),
			ProperName = "Naturally Gifted",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/naturally-gifted-gnome-magic"),
			Description = "You gain an additional use of one of your gnome magic spell-like abilities each day. This does not always have to be the same spell-like ability—one day you might use dancing lights twice, only to use the additional casting for speak with animals the next day.)",
		},
		#endregion

		#region Nature's Mimic
		new Trait
		{
			Name = nameof(TraitEnum.NaturesMimic),
			ProperName = "Natures Mimic",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/nature-s-mimic"),
			Description = "You gain a +1 trait bonus on all Knowledge (nature) checks, and Knowledge (nature) is always a class skill for you. You can make Knowledge (nature) checks pertaining to animals that correspond to your style feats untrained.)",
		},
		#endregion

		#region Necrotic Aura
		new Trait
		{
			Name = nameof(TraitEnum.NecroticAura),
			ProperName = "Necrotic Aura",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/necrotic-aura-whispering-way"),
			Description = "You gain a +1 trait bonus on saving throws against spells from the necromancy school or any effect that deals negative energy damage.)",
		},
		#endregion

		#region Never Stop Shooting
		new Trait
		{
			Name = nameof(TraitEnum.NeverStopShooting),
			ProperName = "Never Stop Shooting",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/never-stop-shooting"),
			Description = "If your hit point total drops to 0 or lower but you are not dead, you may act as if disabled rather than dying (as if you possessed the Diehard feat). However, you can use your actions only to draw a firearm, reload a firearm, or attack with a firearm. If you have the Diehard feat, this trait also allows you to substitute your Wisdom score for your Constitution score for the purpose of determining the negative hit point total at which you die.)",
		},
		#endregion

		#region Noble Savage
		new Trait
		{
			Name = nameof(TraitEnum.NobleSavage),
			ProperName = "Noble Savage",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/noble-savage"),
			Description = "You gain a +2 trait bonus on Diplomacy and Perform checks when dealing with people of high social standing.)",
		},
		#endregion

		#region No Escape
		new Trait
		{
			Name = nameof(TraitEnum.NoEscape),
			ProperName = "No Escape",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/no-escape-combat"),
			Description = "You gain a +1 trait bonus on combat maneuver checks to lawfully and nonlethally restrain a creature you've witnessed commit a crime.)",
		},
		#endregion

		#region Nonchalant Thuggery
		new Trait
		{
			Name = nameof(TraitEnum.NonchalantThuggery),
			ProperName = "Nonchalant Thuggery",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/nonchalant-thuggery"),
			Description = "You gain a +4 trait bonus on Bluff checks to keep others from noticing your aggressive actions.)",
		},
		#endregion

		#region Oathbound
		new Trait
		{
			Name = nameof(TraitEnum.Oathbound),
			ProperName = "Oathbound",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/oathbound"),
			Description = "Once per day, you may reroll a saving throw against a charm or compulsion effect. You must take the second result even if it is worse.)",
		},
		#endregion

		#region Omen
		new Trait
		{
			Name = nameof(TraitEnum.Omen),
			ProperName = "Omen",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/omen"),
			Description = "You gain a +1 trait bonus on Intimidate checks, and Intimidate is always a class skill for you. Once per day, you may attempt to demoralize an opponent as a swift action.)",
		},
		#endregion

		#region Ordinary
		new Trait
		{
			Name = nameof(TraitEnum.Ordinary),
			ProperName = "Ordinary",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/ordinary"),
			Description = "You gain a + 4 trait bonus on Stealth checks whenever you attempt to hide in a crowd.)",
		},
		#endregion

		#region Orphaned
		new Trait
		{
			Name = nameof(TraitEnum.Orphaned),
			ProperName = "Orphaned",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/orphaned"),
			Description = "You gain a +1 trait bonus on Survival checks, and Survival is always a class skill for you.)",
		},
		#endregion

		#region Outcast's Intuition
		new Trait
		{
			Name = nameof(TraitEnum.OutcastsIntuition),
			ProperName = "Outcasts Intuition",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/outcast-s-intuition"),
			Description = "You gain a +1 trait bonus on Sense Motive checks, and Sense Motive is always a class skill for you. In addition, your caster level is treated as 1 level higher for the purposes of any attempts to dispel your magic.)",
		},
		#endregion

		#region Overwhelming Beauty
		new Trait
		{
			Name = nameof(TraitEnum.OverwhelmingBeauty),
			ProperName = "Overwhelming Beauty",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/overwhelming-beauty-magic"),
			Description = "The DC of your mind-affecting effects increases by 1 against creatures that have at least one of the same subtypes as you.)",
		},
		#endregion

		#region Partial Protege
		new Trait
		{
			Name = nameof(TraitEnum.PartialProtege),
			ProperName = "Partial Protege",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/partial-protege"),
			Description = "You gain a +1 trait bonus on Bluff checks and on Use Magic Device checks made to emulate a class feature.)",
		},
		#endregion

		#region Passionate Inertia
		new Trait
		{
			Name = nameof(TraitEnum.PassionateInertia),
			ProperName = "Passionate Inertia",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/passionate-inertia-social"),
			Description = "You gain a +2 trait bonus on Will saves to resist having your mind changed about something, but you take a –1 penalty on Will saves to resist temptation and compulsions you might reasonably be already inclined toward.)",
		},
		#endregion

		#region Pathfinder's Focus
		new Trait
		{
			Name = nameof(TraitEnum.PathfindersFocus),
			ProperName = "Pathfinders Focus",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/pathfinder-s-focus"),
			Description = "You can select a magnetic compass for your arcane bond class feature; this compass is non-magical, but you can later spend 250 gp to upgrade it into a wayfinder. Choosing this trait allows you to upgrade this wayfinder to a variant or unique wayfinder per the normal rules for improving magic items. A bonded wayfinder must be held in your hand to grant the benefits of being a bonded object.)",
		},
		#endregion

		#region Patient Calm
		new Trait
		{
			Name = nameof(TraitEnum.PatientCalm),
			ProperName = "Patient Calm",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/patient-calm"),
			Description = "Choose one Craft or Profession skill. Whenever you take 10 with that skill, determine the result as if you had rolled a 12 instead of a 10.)",
		},
		#endregion

		#region Perfectionist's Brew
		new Trait
		{
			Name = nameof(TraitEnum.PerfectionistsBrew),
			ProperName = "Perfectionists Brew",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/perfectionist-s-brew"),
			Description = "You gain a +2 trait bonus on all Craft (alchemy) checks and on Spellcraft checks made to brew potions.)",
		},
		#endregion

		#region Perpetual Companion
		new Trait
		{
			Name = nameof(TraitEnum.PerpetualCompanion),
			ProperName = "Perpetual Companion",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/perpetual-companion"),
			Description = "You gain a +2 trait bonus on all saving throws against fear effects whenever your eidolon is within 30 feet.)",
		},
		#endregion

		#region Pillager
		new Trait
		{
			Name = nameof(TraitEnum.Pillager),
			ProperName = "Pillager",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/pillager"),
			Description = "You gain a +1 trait bonus on combat maneuver checks to perform disarm and steal combat maneuvers.)",
		},
		#endregion

		#region Planar Savant
		new Trait
		{
			Name = nameof(TraitEnum.PlanarSavant),
			ProperName = "Planar Savant",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/planar-savant"),
			Description = "You may use your Charisma modifier when making Knowledge (planes) checks instead of your Intelligence modifier.)",
		},
		#endregion

		#region Possessed
		new Trait
		{
			Name = nameof(TraitEnum.Possessed),
			ProperName = "Possessed",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/possessed"),
			Description = "Once per day, you can attempt a Knowledge check of your choice even if you are not trained in that skill and it is not usually possible to use that skill untrained. If you can normally use that skill untrained, you gain a +2 trait bonus on the check.)",
		},
		#endregion

		#region Poverty-Stricken
		new Trait
		{
			Name = nameof(TraitEnum.PovertyStricken),
			ProperName = "Poverty-Stricken",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/poverty-stricken"),
			Description = "You gain a +1 bonus to Survival checks, and Survival is always a class skill for you.)",
		},
		#endregion

		#region Pragmatic Activator
		new Trait
		{
			Name = nameof(TraitEnum.PragmaticActivator),
			ProperName = "Pragmatic Activator",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/pragmatic-activator"),
			Description = "You may use your Intelligence modifier when making Use Magic Device checks instead of your Charisma modifier.)",
		},
		#endregion

		#region Precise Treatment
		new Trait
		{
			Name = nameof(TraitEnum.PreciseTreatment),
			ProperName = "Precise Treatment",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/precise-treatment"),
			Description = "You gain a +1 trait bonus on all Heal checks, and you may use your Intelligence modifier when making Heal checks instead of your Wisdom modifier.)",
		},
		#endregion

		#region Prince/Princess
		new Trait
		{
			Name = nameof(TraitEnum.PrincePrincess),
			ProperName = "Prince/Princess",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/princess-female"),
			Description = "You gain a +1 trait bonus to Diplomacy and Intimidate checks, and one of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Principled
		new Trait
		{
			Name = nameof(TraitEnum.Principled),
			ProperName = "Principled",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/principled"),
			Description = "You take a –2 penalty on Bluff checks and gain a +2 trait bonus on saving throws against charm, compulsion, and emotion effects.)",
		},
		#endregion

		#region Prophesied
		new Trait
		{
			Name = nameof(TraitEnum.Prophesied),
			ProperName = "Prophesied",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/prophesied"),
			Description = "You gain a +1 trait bonus on Diplomacy checks and Intimidate checks when interacting with anyone familiar with you or your reputation.)",
		},
		#endregion

		#region Punish Insurrection
		new Trait
		{
			Name = nameof(TraitEnum.PunishInsurrection),
			ProperName = "Punish Insurrection",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/punish-insurrection-combat"),
			Description = "Against members of the same organization or hierarchy who formally answer to you, you gain a +1 trait bonus on attack and damage rolls. You also gain this bonus against members who have openly defied the authority or rules of that body, provided the infraction is serious enough that their standing is now less than yours.)",
		},
		#endregion

		#region Reactionary
		new Trait
		{
			Name = nameof(TraitEnum.Reactionary),
			ProperName = "Reactionary",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/reactionary"),
			Description = "You gain a +2 trait bonus to Initiative checks.)",
		},
		#endregion

		#region Reckless
		new Trait
		{
			Name = nameof(TraitEnum.Reckless),
			ProperName = "Reckless",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/reckless"),
			Description = "You gain a +1 bonus on Acrobatics checks, and Acrobatics is always a class skill for you.)",
		},
		#endregion

		#region Reckless Contempt
		new Trait
		{
			Name = nameof(TraitEnum.RecklessContempt),
			ProperName = "Reckless Contempt",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/reckless-contempt"),
			Description = "Whenever you provoke an attack of opportunity by firing a firearm, you gain a +1 trait bonus on the attack roll that provoked the attack of opportunity.)",
		},
		#endregion

		#region Redeemer
		new Trait
		{
			Name = nameof(TraitEnum.Redeemer),
			ProperName = "Redeemer",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/redeemer-faith"),
			Description = "When acting as a sponsor for an evil creature seeking redemption, your patience and kindness grant the creature a +3 bonus on its save rather than a +1 bonus.)",
		},
		#endregion

		#region Reincarnated
		new Trait
		{
			Name = nameof(TraitEnum.Reincarnated),
			ProperName = "Reincarnated",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/reincarnated"),
			Description = "You gain a +2 trait bonus on saving throws against fear and death effects.)",
		},
		#endregion

		#region Relic-Proof
		new Trait
		{
			Name = nameof(TraitEnum.RelicProof),
			ProperName = "Relic-Proof",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/relic-proof"),
			Description = "You gain a +1 trait bonus on saving throws against effects produced by spell completion and spell trigger items.)",
		},
		#endregion

		#region Reluctant Apprentice
		new Trait
		{
			Name = nameof(TraitEnum.ReluctantApprentice),
			ProperName = "Reluctant Apprentice",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/reluctant-apprentice"),
			Description = "You gain a +1 trait bonus on Knowledge (arcana) checks, and are considered trained in that skill even if you have no ranks in it.)",
		},
		#endregion

		#region Resilient
		new Trait
		{
			Name = nameof(TraitEnum.Resilient),
			ProperName = "Resilient",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/resilient"),
			Description = "You gain a +1 trait bonus on Fortitude saves.)",
		},
		#endregion

		#region Resilient Caster
		new Trait
		{
			Name = nameof(TraitEnum.ResilientCaster),
			ProperName = "Resilient Caster",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/resilient-caster"),
			Description = "Your caster level is treated as 1 level higher whenever someone attempts to dispel one of your spells.)",
		},
		#endregion

		#region Resolve of the Rejected
		new Trait
		{
			Name = nameof(TraitEnum.ResolveoftheRejected),
			ProperName = "Resolve of the Rejected",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/resolve-of-the-rejected"),
			Description = "You gain a +1 trait bonus on all saving throws against charm and compulsion effects. Also, once per day when you succeed at a saving throw against such an effect, you regain 1 grit point.)",
		},
		#endregion

		#region Rest for the Wicked
		new Trait
		{
			Name = nameof(TraitEnum.RestfortheWicked),
			ProperName = "Rest for the Wicked",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/rest-for-the-wicked-social"),
			Description = "You heal temporary ability damage at a rate of 3 points per day of complete bed rest. A normal night of rest (8 hours) still heals you at a rate of only 1 point of temporary ability damage per night of rest.)",
		},
		#endregion

		#region Rich Parents
		new Trait
		{
			Name = nameof(TraitEnum.RichParents),
			ProperName = "Rich Parents",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/rich-parents"),
			Description = "Your starting wealth increases to 900 gp.)",
		},
		#endregion

		#region River Fighter
		new Trait
		{
			Name = nameof(TraitEnum.RiverFighter),
			ProperName = "River Fighter",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/river-fighter"),
			Description = "You may swim downstream or cross-current as a charge if you make your Swim DC by 5 or more.)",
		},
		#endregion

		#region Sacred Conduit
		new Trait
		{
			Name = nameof(TraitEnum.SacredConduit),
			ProperName = "Sacred Conduit",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/sacred-conduit"),
			Description = "Whenever you channel energy, you gain a +1 trait bonus to the save DC of your channeled energy.)",
		},
		#endregion

		#region Sacred Touch
		new Trait
		{
			Name = nameof(TraitEnum.SacredTouch),
			ProperName = "Sacred Touch",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/sacred-touch"),
			Description = "As a standard action, you may automatically stabilize a dying creature merely by touching it.)",
		},
		#endregion

		#region Savage
		new Trait
		{
			Name = nameof(TraitEnum.Savage),
			ProperName = "Savage",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/savage"),
			Description = "You gain a +1 trait bonus on Knowledge (nature) checks and a +1 trait bonus on Survival checks to get along in the wild. Knowledge (nature) is always a class skill for you.)",
		},
		#endregion

		#region Savanna Hunter
		new Trait
		{
			Name = nameof(TraitEnum.SavannaHunter),
			ProperName = "Savanna Hunter",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/savanna-hunter"),
			Description = "You gain a +1 trait bonus on attacks of opportunity attack rolls made with a shortspear, as well as a +1 racial bonus on Constitution checks to continue running and avoid nonlethal damage from a forced march.)",
		},
		#endregion

		#region Savant
		new Trait
		{
			Name = nameof(TraitEnum.Savant),
			ProperName = "Savant",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/savant"),
			Description = "Chose a performance type. You gain a +2 trait bonus on all Perform checks made using that performance type. Perform is always a class skill for you.)",
		},
		#endregion

		#region Scarred by Space Pirates
		new Trait
		{
			Name = nameof(TraitEnum.ScarredbySpacePirates),
			ProperName = "Scarred by Space Pirates",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on attack rolls against humanoids.)",
		},
		#endregion

		#region Scarred Descendant
		new Trait
		{
			Name = nameof(TraitEnum.ScarredDescendant),
			ProperName = "Scarred Descendant",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/scarred-descendant"),
			Description = "You gain a +1 trait bonus on rolls to confirm critical hits against favored enemies of your own subtype and on Survival checks made to track such creatures.)",
		},
		#endregion

		#region Scholar of the Great Beyond
		new Trait
		{
			Name = nameof(TraitEnum.ScholaroftheGreatBeyond),
			ProperName = "Scholar of the Great Beyond",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/scholar-of-the-great-beyond"),
			Description = "You gain a +1 trait bonus on Knowledge (history) and Knowledge (planes) checks, and one of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Schooled Inquisitor
		new Trait
		{
			Name = nameof(TraitEnum.SchooledInquisitor),
			ProperName = "Schooled Inquisitor",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/schooled-inquisitor"),
			Description = "You gain a +2 trait bonus on all Knowledge (planes) and Knowledge (religion) checks made to identify the abilities and weaknesses of creatures.)",
		},
		#endregion

		#region Scorned by Magic
		new Trait
		{
			Name = nameof(TraitEnum.ScornedbyMagic),
			ProperName = "Scorned by Magic",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/scorned-by-magic"),
			Description = "Reduce the caster level of spells and spell-like abilities cast upon you by 1 for the purpose of attempting dispel checks and overcoming your spell resistance (if any).)",
		},
		#endregion

		#region Secret-Keeper
		new Trait
		{
			Name = nameof(TraitEnum.SecretKeeper),
			ProperName = "Secret-Keeper",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/secret-keeper"),
			Description = "You gain a +1 trait bonus on Bluff checks and a +1 trait bonus on saving throws against divinations, domination effects, and effects that would compel you to speak the truth.)",
		},
		#endregion

		#region Seeker
		new Trait
		{
			Name = nameof(TraitEnum.Seeker),
			ProperName = "Seeker",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/seeker"),
			Description = "You gain a +1 trait bonus on Perception checks, and Perception is always a class skill for you.)",
		},
		#endregion

		#region Self-Taught Scholar
		new Trait
		{
			Name = nameof(TraitEnum.SelfTaughtScholar),
			ProperName = "Self-Taught Scholar",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/self-taught-scholar"),
			Description = "You gain a +1 trait bonus on Linguistics checks to decipher unfamiliar languages, and Linguistics is always a class skill for you. In addition, you gain a +1 trait bonus on Spellcraft checks made to decipher the writing on a scroll.)",
		},
		#endregion

		#region Shrouded Casting
		new Trait
		{
			Name = nameof(TraitEnum.ShroudedCasting),
			ProperName = "Shrouded Casting",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/shrouded-casting"),
			Description = "Choose one school of magic when you pick this trait. You can cast spells from that school as if you had the Eschew Materials feat.)",
		},
		#endregion

		#region Signature Moves
		new Trait
		{
			Name = nameof(TraitEnum.SignatureMoves),
			ProperName = "Signature Moves",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/signature-moves-social"),
			Description = "Your starting equipment includes a single masterwork item worth less than 900 gp, and you gain a +1 trait bonus on Bluff and Intimidate checks while wielding this item in one or both hands.)",
		},
		#endregion

		#region Simple Disciple
		new Trait
		{
			Name = nameof(TraitEnum.SimpleDisciple),
			ProperName = "Simple Disciple",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/simple-disciple"),
			Description = "You gain a +1 trait bonus on checks with a Profession or Craft skill of your choice.)",
		},
		#endregion

		#region Skeptic
		new Trait
		{
			Name = nameof(TraitEnum.Skeptic),
			ProperName = "Skeptic",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/skeptic"),
			Description = "You gain a +2 trait bonus on all saving throws against illusions.)",
		},
		#endregion

		#region Slippery
		new Trait
		{
			Name = nameof(TraitEnum.Slippery),
			ProperName = "Slippery",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/slippery-bellflower-network"),
			Description = "You gain a +1 trait bonus on Stealth checks and Stealth is always a class skill for you.)",
		},
		#endregion

		#region Snowbound
		new Trait
		{
			Name = nameof(TraitEnum.Snowbound),
			ProperName = "Snowbound",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/snowbound"),
			Description = "You gain a +1 trait bonus on saving throws against cold effects and a +2 trait bonus on Fortitude saving throws against the effects of cold weather.)",
		},
		#endregion

		#region Soaring Sprinter
		new Trait
		{
			Name = nameof(TraitEnum.SoaringSprinter),
			ProperName = "Soaring Sprinter",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/soaring-sprinter"),
			Description = "You gain a +2 trait bonus on Acrobatics checks to keep your balance or jump, and Acrobatics becomes a class skill for you.)",
		},
		#endregion

		#region Spark of Creation
		new Trait
		{
			Name = nameof(TraitEnum.SparkofCreation),
			ProperName = "Spark of Creation",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/spark-of-creation-magic"),
			Description = "You gain a +1 trait bonus on Craft checks, and the cost of creating magic items is reduced by 5%.)",
		},
		#endregion

		#region Spell Intuition
		new Trait
		{
			Name = nameof(TraitEnum.SpellIntuition),
			ProperName = "Spell Intuition",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/spell-intuition"),
			Description = "You gain a +1 trait bonus on Spellcraft checks, and Spellcraft becomes a class skill for you.)",
		},
		#endregion

		#region Spirit Sense
		new Trait
		{
			Name = nameof(TraitEnum.SpiritSense),
			ProperName = "Spirit Sense",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/spirit-sense"),
			Description = "You gain a +2 trait bonus on Perception checks to avoid being surprised and to detect invisible or incorporeal creatures.)",
		},
		#endregion

		#region Sprint
		new Trait
		{
			Name = nameof(TraitEnum.Sprint),
			ProperName = "Sprint",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/sprint-gnome"),
			Description = "If you do nothing but move in a turn (that is, if you run or use both of your actions in a round to move your speed) and you are in no armor or light armor, you may move an extra 5 feet.)",
		},
		#endregion

		#region Stalwart of the Society
		new Trait
		{
			Name = nameof(TraitEnum.StalwartoftheSociety),
			ProperName = "Stalwart of the Society",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			CharacterClass = ClassEnum.Paladin,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/stalwart-of-the-society-paladin-pathfinder-society"),
			Description = "Your aura of courage class ability grants an additional +1 trait bonus on saving throws against fear effects.)",
		},
		#endregion

		#region Startling Report
		new Trait
		{
			Name = nameof(TraitEnum.StartlingReport),
			ProperName = "Startling Report",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/startling-report"),
			Description = "When you shoot a firearm, you gain a +2 trait bonus on Intimidate checks for 1 round against those who heard the shot.)",
		},
		#endregion

		#region Steel Skin
		new Trait
		{
			Name = nameof(TraitEnum.SteelSkin),
			ProperName = "Steel Skin",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/steel-skin"),
			Description = "You gain the ability to don or remove heavy armor in half the normal time. Additionally, you begin play with a great helm bearing the iconography of your family (this helm grants no special defensive benefits). While wearing this helm with a suit of heavy armor, you gain a +2 trait bonus on Intimidate checks.)",
		},
		#endregion

		#region Storm-Touched
		new Trait
		{
			Name = nameof(TraitEnum.StormTouched),
			ProperName = "Storm-Touched",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/storm-touched"),
			Description = "You gain DR 1/— against creatures and attacks with the electricity type.)",
		},
		#endregion

		#region Strength Foretold
		new Trait
		{
			Name = nameof(TraitEnum.StrengthForetold),
			ProperName = "Strength Foretold",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/strength-foretold"),
			Description = "Once per day as a free action, you gain a +1 trait bonus to the DC of the saving throw of one of your bonus bloodline spells.)",
		},
		#endregion

		#region Strength of the Land
		new Trait
		{
			Name = nameof(TraitEnum.StrengthoftheLand),
			ProperName = "Strength of the Land",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/strength-of-the-land"),
			Description = "You gain a +1 trait bonus on caster level checks while touching the ground or unworked stone. This includes dispel checks and checks to overcome spell resistance.)",
		},
		#endregion

		#region Strong Arm, Supple Wrist
		new Trait
		{
			Name = nameof(TraitEnum.StrongArmSuppleWrist),
			ProperName = "Strong Arm, Supple Wrist",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/strong-arm-supple-wrist"),
			Description = "Whenever you move at least 10 feet before making an attack with a thrown weapon, you add 10 feet to the range increment of the weapon thrown. You can only gain this benefit once per round.)",
		},
		#endregion

		#region Student of Philosophy
		new Trait
		{
			Name = nameof(TraitEnum.StudentofPhilosophy),
			ProperName = "Student of Philosophy",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/student-of-philosophy"),
			Description = "You can use your Intelligence modifier in place of your Charisma modifier on Diplomacy checks to persuade others and on Bluff checks to convince others that a lie is true. (This trait does not affect Diplomacy checks to gather information or Bluff checks to feint in combat).)",
		},
		#endregion

		#region Style Sage
		new Trait
		{
			Name = nameof(TraitEnum.StyleSage),
			ProperName = "Style Sage",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/style-sage"),
			Description = "You gain a +1 trait bonus on checks with your choice of either Knowledge (local) or Knowledge (history), and the one you choose is always a class skill for you. In addition, you gain a +1 trait bonus on Diplomacy checks made to gather information about any person with levels in monk.)",
		},
		#endregion

		#region Subjective Truth
		new Trait
		{
			Name = nameof(TraitEnum.SubjectiveTruth),
			ProperName = "Subjective Truth",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/subjective-truth-social"),
			Description = "You gain a +2 trait bonus on Bluff checks to lie, provided the person you're lying to has never known you to lie to him. Failing this check counts as being caught in a lie by the target, negating any future use of this bonus against that person.)",
		},
		#endregion

		#region Sun-Blessed 
		new Trait
		{
			Name = nameof(TraitEnum.SunBlessed),
			ProperName = "Sun-Blessed",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			Description = "Whenever you're affected by a healing effect that would heal more hit points than your maximum hit point total, you gain the excess healing as temporary hit points. You can gain up to a number of temporary hit points per day equal to your character level in this way. These temporary hit points last for 1 minute.)",
		},
		#endregion

		#region Supportive
		new Trait
		{
			Name = nameof(TraitEnum.Supportive),
			ProperName = "Supportive",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/supportive"),
			Description = "You gain a +1 trait bonus on skill checks to use the aid another action.)",
		},
		#endregion

		#region Surprise Weapon
		new Trait
		{
			Name = nameof(TraitEnum.SurpriseWeapon),
			ProperName = "Surprise Weapon",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/surprise-weapon"),
			Description = "You gain a +2 trait bonus on attack rolls with improvised weapons.)",
		},
		#endregion

		#region Suspicious
		new Trait
		{
			Name = nameof(TraitEnum.Suspicious),
			ProperName = "Suspicious",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/suspicious"),
			Description = "You gain a +1 trait bonus on Sense Motive checks, and Sense Motive is always a class skill for you.)",
		},
		#endregion

		#region Sworn Enemy
		new Trait
		{
			Name = nameof(TraitEnum.SwornEnemy),
			ProperName = "Sworn Enemy",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/sworn-enemy"),
			Description = "Choose a creature type from ranger's list of favored enemies. You gain a +1 trait bonus on attacks of opportunity against the chosen creature type.)",
		},
		#endregion

		#region Tactician
		new Trait
		{
			Name = nameof(TraitEnum.Tactician),
			ProperName = "Tactician",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/tactician"),
			Description = "You gain a +1 trait bonus on initiative checks. In addition, once per day when you make an attack of opportunity, you gain a +2 trait bonus on the attack roll.)",
		},
		#endregion

		#region Talented
		new Trait
		{
			Name = nameof(TraitEnum.Talented),
			ProperName = "Talented",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/talented"),
			Description = "You gain a +1 trait bonus on checks with a single Perform skill (your choice), and all Perform skills are always class skills for you.)",
		},
		#endregion

		#region Tenacious Shifting
		new Trait
		{
			Name = nameof(TraitEnum.TenaciousShifting),
			ProperName = "Tenacious Shifting",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/tenacious-shifting"),
			Description = "Any transmutation spell you cast upon yourself has its duration increased by 2 rounds. Transmutation spells with an instantaneous duration are not affected by this trait.)",
		},
		#endregion

		#region Theoretical Magician
		new Trait
		{
			Name = nameof(TraitEnum.TheoreticalMagician),
			ProperName = "Theoretical Magician",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/theoretical-magician"),
			Description = "You gain a +2 trait bonus on Spellcraft checks, or a +3 bonus if you aren't a spellcaster.)",
		},
		#endregion

		#region Threatening Defender
		new Trait
		{
			Name = nameof(TraitEnum.ThreateningDefender),
			ProperName = "Threatening Defender",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/threatening-defender"),
			Description = "When you use Combat Expertise, reduce the number you subtract from your melee attack rolls by 1.)",
		},
		#endregion

		#region Tireless Avenger
		new Trait
		{
			Name = nameof(TraitEnum.TirelessAvenger),
			ProperName = "Tireless Avenger",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/tireless-avenger"),
			Description = "When you're in pursuit of one of your favored enemies, the DC for the Constitution check to avoid taking lethal damage during a forced march is 10 + 1 per extra hour, instead of 10 + 2 per extra hour.)",
		},
		#endregion

		#region Tireless Logic
		new Trait
		{
			Name = nameof(TraitEnum.TirelessLogic),
			ProperName = "Tireless Logic",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/tireless-logic"),
			Description = "Once per day when you make an Intelligence-based skill check or ability check, you can roll twice and take the better result.)",
		},
		#endregion

		#region Tracker of the Society
		new Trait
		{
			Name = nameof(TraitEnum.TrackeroftheSociety),
			ProperName = "Tracker of the Society",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			CharacterClass = ClassEnum.Ranger,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/tracker-of-the-society-ranger-pathfinder-society"),
			Description = "You gain a +1 trait bonus on Initiative checks and a +2 trait bonus on Survival skill checks made while traveling through any of your favored terrains. This is in addition to any bonuses you receive from your Favored Terrain class ability.)",
		},
		#endregion

		#region Transmuter
		new Trait
		{
			Name = nameof(TraitEnum.Transmuter),
			ProperName = "Transmuter",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/transmuter-magic"),
			Description = "Whenever you cast a spell from the transmutation school, its effects manifest at +1 caster level. Additionally, select one of the following transmutation spells: bear's endurance, bull's strength, cat's grace, eagle's splendor, fox's cunning, or owl's wisdom. Once per day when you cast that spell, its duration is doubled. A spell affected by this trait cannot be modified further by the Extend Spell metamagic feat or similar abilities.)",
		},
		#endregion

		#region Trickster
		new Trait
		{
			Name = nameof(TraitEnum.Trickster),
			ProperName = "Trickster",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/trickster-gnome-magic"),
			Description = "You gain a +1 trait bonus to your caster level when determining the duration, range, and area of all spells from the illusion school.)",
		},
		#endregion

		#region Tropical Upbringing
		new Trait
		{
			Name = nameof(TraitEnum.TropicalUpbringing),
			ProperName = "Tropical Upbringing",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/tropical-upbringing"),
			Description = "You gain a +1 trait bonus on saving throws against fire effects and a +2 trait bonus on Fortitude saving throws against the effects of hot weather.)",
		},
		#endregion

		#region Trustworthy
		new Trait
		{
			Name = nameof(TraitEnum.Trustworthy),
			ProperName = "Trustworthy",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/trustworthy"),
			Description = "You gain a +1 trait bonus on Bluff checks made to fool someone. You also gain a +1 trait bonus on Diplomacy checks, and Diplomacy is always a class skill for you.)",
		},
		#endregion

		#region Truth's Agent
		new Trait
		{
			Name = nameof(TraitEnum.TruthsAgent),
			ProperName = "Truths Agent",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/truth-s-agent"),
			Description = "You gain a +1 trait bonus on all Diplomacy checks made to gather information and all Knowledge (local) checks. Knowledge (local) is always a class skill for you.)",
		},
		#endregion

		#region Twinned Presence
		new Trait
		{
			Name = nameof(TraitEnum.TwinnedPresence),
			ProperName = "Twinned Presence",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/twinned-presence"),
			Description = "You gain a +1 trait bonus on Intimidate checks, and Intimidate is always a class skill for you. In addition, if your eidolon is summoned and within 30 feet, and its size exceeds your own, use its size modifier on any Intimidate checks you make.)",
		},
		#endregion

		#region Two-World Magic
		new Trait
		{
			Name = nameof(TraitEnum.TwoWorldMagic),
			ProperName = "Two-World Magic",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/two-world-magic"),
			Description = "Select one 0-level spell from a class spell list other than your own. This spell is a 0-level spell on your class spell list (or a 1st-level spell if your class doesn't have 0-level spells). For example, if you are a druid, you could select mage hand and thereafter prepare it as a 0-level druid spell; if you are a sorcerer, you could select know direction as a 0-level sorcerer spell known.)",
		},
		#endregion

		#region Unabashed Gall
		new Trait
		{
			Name = nameof(TraitEnum.UnabashedGall),
			ProperName = "Unabashed Gall",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/unabashed-gall-social"),
			Description = "Whenever you commit an unexpected and outrageously unlawful act (such as knowingly destroying or stealing something) that would elicit a hostile response from another creature, you may attempt a Bluff check opposed by the opponent's Sense Motive check. If you're successful, you and any allies who were willfully expecting your unlawful deed may act in a surprise round. For each ally willfully expecting your unlawful deed, you take a cumulative –2 penalty on your Bluff check. If your Bluff check fails, there is no surprise round. Regardless of whether your Bluff check succeeds, you and any allies willfully taking advantage of your unlawful deed treat your initiative checks for the duration of combat as though you had each rolled a 1.)",
		},
		#endregion

		#region Unblemished Barrel
		new Trait
		{
			Name = nameof(TraitEnum.UnblemishedBarrel),
			ProperName = "Unblemished Barrel",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/unblemished-barrel"),
			Description = "You gain a +1 trait bonus on Craft (alchemy) and Craft (weapons) checks, and it takes you only 30 minutes to remove the broken condition from a firearm.)",
		},
		#endregion

		#region Unintentional Linguist
		new Trait
		{
			Name = nameof(TraitEnum.UnintentionalLinguist),
			ProperName = "Unintentional Linguist",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/unintentional-linguist"),
			Description = "You gain a +1 trait bonus on Linguistics checks, and you begin play knowing one of the following languages (in addition to those granted by your race and Intelligence modifier): Abyssal, Aquan, Celestial, Ignan, Infernal, Protean, or Terran.)",
		},
		#endregion

		#region Unnatural Revenge
		new Trait
		{
			Name = nameof(TraitEnum.UnnaturalRevenge),
			ProperName = "Unnatural Revenge",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/unnatural-revenge"),
			Description = "You gain a +2 trait bonus on all Intimidate checks against creatures of the animal, fey, or plant type, and Intimidate is always a class skill for you.)",
		},
		#endregion

		#region Unpredictable
		new Trait
		{
			Name = nameof(TraitEnum.Unpredictable),
			ProperName = "Unpredictable",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/unpredictable"),
			Description = "You gain a +1 trait bonus on Bluff checks, and Bluff is always a class skill for you.)",
		},
		#endregion

		#region Unpredictable Reactions
		new Trait
		{
			Name = nameof(TraitEnum.UnpredictableReactions),
			ProperName = "Unpredictable Reactions",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/unpredictable-reactions-combat"),
			Description = "You gain a +1 trait bonus on attack rolls made during the surprise round of combat.)",
		},
		#endregion

		#region Unscathed
		new Trait
		{
			Name = nameof(TraitEnum.Unscathed),
			ProperName = "Unscathed",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/unscathed"),
			Description = "Each type of energy resistance you have (if any) increases by 2 points.)",
		},
		#endregion

		#region Unseen but Not Undone
		new Trait
		{
			Name = nameof(TraitEnum.UnseenbutNotUndone),
			ProperName = "Unseen but Not Undone",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/unseen-but-not-undone"),
			Description = "Once per day, you can cast a bloodline spell as if you had the Still Spell feat. Using this trait does not modify the spell's level.)",
		},
		#endregion

		#region Unstable Mutagen
		new Trait
		{
			Name = nameof(TraitEnum.UnstableMutagen),
			ProperName = "Unstable Mutagen",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/unstable-mutagen"),
			Description = "Once per day, you can create an unstable mutagen. It is like a normal mutagen in most ways, but also gains a single benefit or hindrance due to its instability. Roll 1d6 to determine the result of the instability.  1  The unstable mutagen lasts for 5 minutes per alchemist level. 2  The unstable mutagen lasts for 20 minutes per alchemist level. 3  The unstable mutagen does not grant a natural armor bonus. 4  The natural armor bonus granted by the mutagen increases by 2. 5  The penalty that the mutagen applies to the corresponding mental ability score increases by 2. 6  The unstable mutagen does not apply a penalty to the corresponding mental ability score.)",
		},
		#endregion

		#region Veiled Disciple
		new Trait
		{
			Name = nameof(TraitEnum.VeiledDisciple),
			ProperName = "Veiled Disciple",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/veiled-disciple"),
			Description = "You gain a +1 trait bonus on Bluff checks made to pass secret messages and a +1 trait bonus on saving throws against charm and compulsion effects.)",
		},
		#endregion

		#region Vengeful
		new Trait
		{
			Name = nameof(TraitEnum.Vengeful),
			ProperName = "Vengeful",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/vengeful"),
			Description = "Whenever you strike the last creature that damaged you in the past 24 hours, you gain a +1 trait bonus on damage rolls against that creature.)",
		},
		#endregion

		#region Vigilant Battler
		new Trait
		{
			Name = nameof(TraitEnum.VigilantBattler),
			ProperName = "Vigilant Battler",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/vigilant-battler"),
			Description = "You gain a +1 trait bonus on all Sense Motive checks. This trait bonus increases to +2 when used to counter a feint in combat.)",
		},
		#endregion

		#region Volatile Conduit
		new Trait
		{
			Name = nameof(TraitEnum.VolatileConduit),
			ProperName = "Volatile Conduit",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/volatile-conduit"),
			Description = "Once per day as a free action, when you cast a spell that deals acid, cold, electricity, or fire damage, you can enhance that spell with volatile energy. When you do, it deals 1d4 points of extra damage of the same energy type.)",
		},
		#endregion

		#region Wanderer's Shroud
		new Trait
		{
			Name = nameof(TraitEnum.WanderersShroud),
			ProperName = "Wanderers Shroud",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/wanderer-s-shroud"),
			Description = "Efforts to use the Diplomacy skill to gather information about you take a –1 penalty, and you gain a +1 trait bonus on all saving throws against scrying and mind-reading effects that allow saving throws.)",
		},
		#endregion

		#region Wanderlust
		new Trait
		{
			Name = nameof(TraitEnum.Wanderlust),
			ProperName = "Wanderlust",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/wanderlust"),
			Description = "Treat your base land speed as 10 feet higher when determining your overland speed.)",
		},
		#endregion

		#region Water-Touched
		new Trait
		{
			Name = nameof(TraitEnum.WaterTouched),
			ProperName = "Water-Touched",
			Category = TraitCategoryEnum.Magic,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/water-touched"),
			Description = "You gain DR 1/— against creatures and attacks with the water type.)",
		},
		#endregion

		#region Weapon of Peace
		new Trait
		{
			Name = nameof(TraitEnum.WeaponofPeace),
			ProperName = "Weapon of Peace",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/weapon-of-peace-combat"),
			Description = "When using a melee weapon that deals lethal damage to instead deal nonlethal damage, you take only a –2 attack penalty instead of –4.)",
		},
		#endregion

		#region Weathered Emissary
		new Trait
		{
			Name = nameof(TraitEnum.WeatheredEmissary),
			ProperName = "Weathered Emissary",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/weathered-emissary"),
			Description = "You gain a +1 trait bonus on Linguistics and Survival checks, and Linguistics is always a class skill for you.)",
		},
		#endregion

		#region Wicked Leader
		new Trait
		{
			Name = nameof(TraitEnum.WickedLeader),
			ProperName = "Wicked Leader",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/wicked-leader-social"),
			Description = "You gain a +1 trait bonus on Charisma checks against evil creatures. If you select the Leadership feat or the Vile Leadership feat at any point when you meet the prerequisites for that feat, you can recruit a cohort who is up to 1 level lower than you (instead of the normal requirement that your cohort must be 2 or more levels lower than you are) as long as your cohort is evil.)",
		},
		#endregion

		#region Without a Past
		new Trait
		{
			Name = nameof(TraitEnum.WithoutaPast),
			ProperName = "Without a Past",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/without-a-past"),
			Description = "You gain a +1 trait bonus to Bluff and Linguistics when forging documents, and you may choose one of the two as always a class skill for you.)",
		},
		#endregion

		#region Witty Repartee
		new Trait
		{
			Name = nameof(TraitEnum.WittyRepartee),
			ProperName = "Witty Repartee",
			Category = TraitCategoryEnum.Combat,
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.AcademyMembership,
			URL = new Uri("http://www.d20pfsrd.com/traits/combat-traits/witty-repartee-kitharodian-academy"),
			Description = "You gain a +1 trait bonus on Bluff checks and Bluff is always a class skill for you.)",
		},
		#endregion

		#region Worldly
		new Trait
		{
			Name = nameof(TraitEnum.Worldly),
			ProperName = "Worldly",
			Category = TraitCategoryEnum.Social,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/social-traits/worldly"),
			Description = "Once per day when attempting a skill check for a skill you're untrained in, you can roll twice and take the better result.)",
		},
		#endregion

		#region Zealot
		new Trait
		{
			Name = nameof(TraitEnum.Zealot),
			ProperName = "Zealot",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/zealot"),
			Description = "You gain a +1 trait bonus on Knowledge (religion) checks, and that skill is always a class skill for you. As long as you remain completely faithful to the tenets of your faith (as determined by the GM), you never suffer from the negative racial effect normally associated with your race.)",
		},
		#endregion

		#region Zealous Striker
		new Trait
		{
			Name = nameof(TraitEnum.ZealousStriker),
			ProperName = "Zealous Striker",
			Category = TraitCategoryEnum.Faith,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/zealous-striker"),
			Description = "While you have the destruction judgment active, you gain a +1 trait bonus on damage rolls when attacking a foe who can cast divine spells and worships a different deity than you.)",
		},
		#endregion


		#endregion

		#region Campaign

		#region Alabaster Outcast
		new Trait
		{
			Name = nameof(TraitEnum.AlabasterOutcast),
			ProperName = "Alabaster Outcast",
			Category = TraitCategoryEnum.ShatteredStar,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/shattered-star/alabaster-outcast"),
			Description = "You gain a +1 trait bonus on Diplomacy and Intimidate checks made within the city. Additionally, you start play with a noble's outfit, a signet ring, and a single additional non-magical item worth no more than 200 gp.)",
		},
		#endregion

		#region Ancient Explorer
		new Trait
		{
			Name = nameof(TraitEnum.AncientExplorer),
			ProperName = "Ancient Explorer",
			Category = TraitCategoryEnum.SkullShackles,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/skull-shackles/ancient-explorer"),
			Description = "You gain a +1 trait bonus on Knowledge (history) and Knowledge (local) checks, and one of these skills is always a class skill for you. In addition, you gain Cyclops or Polyglot as a bonus language.)",
		},
		#endregion

		#region Barroom Talespinner
		new Trait
		{
			Name = nameof(TraitEnum.BarroomTalespinner),
			ProperName = "Barroom Talespinner",
			Category = TraitCategoryEnum.SkullShackles,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/skull-shackles/barroom-talespinner"),
			Description = "You gain a +1 trait bonus on Diplomacy checks and one category of Perform checks, and one of these skills is always a class skill for you. In addition, once per week you can make a DC 15 Knowledge (local) or Intelligence check to see if you know a popular legendary pirate tale, the telling of which grants you a +1 trait bonus on checks made to influence NPCs in the area.)",
		},
		#endregion

		#region Bastard
		new Trait
		{
			Name = nameof(TraitEnum.Bastard),
			ProperName = "Bastard",
			Category = TraitCategoryEnum.Kingmaker,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/kingmaker/bastard"),
			Description = "You take a –1 penalty on all Charisma-based skill checks made when dealing with members of nobility but gain a +1 trait bonus on Will saves as a result of your stubbornness and individuality. (The penalty aspect of this trait is removed if you ever manage to establish yourself as a true noble.))",
		},
		#endregion

		#region Best Friend
		new Trait
		{
			Name = nameof(TraitEnum.BestFriend),
			ProperName = "Best Friend",
			Category = TraitCategoryEnum.JadeRegent,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/jade-regent-traits/best-friend"),
			Description = "Choose An NPC. You and the chosen NPC are best friends. You gain a +1 trait bonus on all attack rolls against foes that threaten your friend as well as one of the following (depending on the NPC chosen, consult your GM for specifics): A +2 trait bonus on Diplomacy checks or a +2 trait bonus on Bluff checks. Whichever skill you gain a trait bonus on, that skill is always considered a class skill for you.)",
		},
		#endregion

		#region Black Sheep
		new Trait
		{
			Name = nameof(TraitEnum.BlackSheep),
			ProperName = "Black Sheep",
			Category = TraitCategoryEnum.RiseoftheRunelords,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/rise-of-the-runelords/black-sheep"),
			Description = "You gain a +1 trait bonus on Knowledge (local) checks, and Knowledge (local) is always a class skill for you. In addition, you can choose any one notorious citizen from below as an ally; depending on the person you pick, you’ll get different benefits. Apothecarist: You start the game with 400 gp worth of poison, and the apothecarist will continue to sell you poison as long as you don’t spread the word. Bitter Nobleman: Choose one of the following skills: Bluff, Sleight of Hand, or Stealth. You gain a +1 trait bonus on that skill, and it is always a class skill for you.)",
		},
		#endregion

		#region Blood of Pharaohs
		new Trait
		{
			Name = nameof(TraitEnum.BloodofPharaohs),
			ProperName = "Blood of Pharaohs",
			Category = TraitCategoryEnum.MummysMask,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/mummy-s-mask/blood-of-pharaohs"),
			Description = "You gain a +1 trait bonus on Will saves. You also gain a +1 trait bonus on Knowledge (nobility) checks and that skill is always a class skill for you. In addition, you may choose an ancient language as one of your bonus languages.)",
		},
		#endregion

		#region Boarded [A]
		new Trait
		{
			Name = nameof(TraitEnum.BoardedA),
			ProperName = "Boarded [A]",
			Category = TraitCategoryEnum.SerpentsSkull,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/serpent-s-skull/boarded-in-cheliax"),
			Description = "You begin with a detailed map of a very large jungle (this grants +2 competence bonus on all Knowledge [geography] checks made regarding this region) and 200 gp worth of mundane equipment to aid your exploration of the jungle.)",
		},
		#endregion

		#region Boarded [B]
		new Trait
		{
			Name = nameof(TraitEnum.BoardedB),
			ProperName = "Boarded [B]",
			Category = TraitCategoryEnum.SerpentsSkull,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/serpent-s-skull/boarded-in-the-mwangi-expanse"),
			Description = "You gain Polyglot as a bonus language and receive a +1 trait bonus on all Knowledge (nature) checks regarding the jungle.)",
		},
		#endregion

		#region Boarded [C]
		new Trait
		{
			Name = nameof(TraitEnum.BoardedC),
			ProperName = "Boarded [C]",
			Category = TraitCategoryEnum.SerpentsSkull,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/serpent-s-skull/boarded-in-the-shackles"),
			Description = "Choose Fort, Reflex, or Will. You gain a +1 trait bonus on all saving throws of that type.)",
		},
		#endregion

		#region Boarded [D]
		new Trait
		{
			Name = nameof(TraitEnum.BoardedD),
			ProperName = "Boarded [D]",
			Category = TraitCategoryEnum.SerpentsSkull,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/serpent-s-skull/boarded-in-varisia"),
			Description = "You gain either a +2 trait bonus on all Bluff checks made against inhabitants of the jungle, or treat your spells with the mind-affecting descriptor as being +1 caster level higher when cast against creatures and natives of the jungle.)",
		},
		#endregion

		#region Boarded [E]
		new Trait
		{
			Name = nameof(TraitEnum.BoardedE),
			ProperName = "Boarded [E]",
			Category = TraitCategoryEnum.SerpentsSkull,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/serpent-s-skull/boarded-in-mediogalti"),
			Description = "Your familiarity with subtle slayings and toxins grants you a +2 trait bonus on all saving throws against poison. In addition, you can pick one type of poison listed below to be immune to, having undergone a long and painful process of building up an immunity to its effects: blue whinnis, giant wasp poison, medium spider venom, small centipede poison, or spider vine poison.)",
		},
		#endregion

		#region Brigand
		new Trait
		{
			Name = nameof(TraitEnum.Brigand),
			ProperName = "Brigand",
			Category = TraitCategoryEnum.Kingmaker,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/kingmaker/brigand"),
			Description = "You begin with an extra 100 gp in equipment. You also gain a +1 trait bonus on Bluff, Diplomacy, Intimidate, and Sense Motive checks when dealing with brigands, thieves, bandits, and their ilk.)",
		},
		#endregion

		#region Buccaneer's Blood
		new Trait
		{
			Name = nameof(TraitEnum.BuccaneersBlood),
			ProperName = "Buccaneers Blood",
			Category = TraitCategoryEnum.SkullShackles,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/skull-shackles/buccaneer-s-blood"),
			Description = "You gain a +1 trait bonus on Intimidate and Profession (sailor) checks. In addition, you gain a one-time +1 trait bonus to your Disrepute and Infamy scores.)",
		},
		#endregion

		#region Caravan Guard
		new Trait
		{
			Name = nameof(TraitEnum.CaravanGuard),
			ProperName = "Caravan Guard",
			Category = TraitCategoryEnum.JadeRegent,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/jade-regent-traits/caravan-guard"),
			Description = "You gain a +1 trait bonus on Survival checks, and Survival becomes a class skill for you.)",
		},
		#endregion

		#region Chance Savior
		new Trait
		{
			Name = nameof(TraitEnum.ChanceSavior),
			ProperName = "Chance Savior",
			Category = TraitCategoryEnum.CarrionCrown,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/carrion-crown/chance-savior"),
			Description = "You gain a +2 trait bonus on Initiative checks.)",
		},
		#endregion

		#region Childhood Crush
		new Trait
		{
			Name = nameof(TraitEnum.ChildhoodCrush),
			ProperName = "Childhood Crush",
			Category = TraitCategoryEnum.JadeRegent,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/jade-regent-traits/childhood-crush"),
			Description = "You gain a +1 trait bonus on all attack rolls against foes that threaten your crush. Once per day, you may attempt to earn a kind word or a smile from the NPC whom you have a crush on by making a DC 15 Charisma check. If you’re successful, the elation and joy at the attention gives you a +1 trait bonus on all saving throws for the remainder of the day. If you’re ever lucky enough to win the NPC’s love, this +1 trait bonus on saving throws applies at all times, as long as your relationship remains active.)",
		},
		#endregion

		#region Child of Infamy
		new Trait
		{
			Name = nameof(TraitEnum.ChildofInfamy),
			ProperName = "Child of Infamy",
			Category = TraitCategoryEnum.CouncilofThieves,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/council-of-thieves/child-of-infamy"),
			Description = "You gain a +1 trait bonus on Perform (act) skill checks, and the skill is always considered a class skill for you. Furthermore, you begin play with an additional 300 gp.)",
		},
		#endregion

		#region Colonial
		new Trait
		{
			Name = nameof(TraitEnum.Colonial),
			ProperName = "Colonial",
			Category = TraitCategoryEnum.SerpentsSkull,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/serpent-s-skull/colonial"),
			Description = "You gain a +1 trait bonus on Knowledge (local) checks relating to settlements and politics and a +1 trait bonus on saving throws against disease.)",
		},
		#endregion

		#region Conspiracy Hunter
		new Trait
		{
			Name = nameof(TraitEnum.ConspiracyHunter),
			ProperName = "Conspiracy Hunter",
			Category = TraitCategoryEnum.CouncilofThieves,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/council-of-thieves/conspiracy-hunter"),
			Description = "Choose one of the following skills: Bluff, Diplomacy, Knowledge (local), Perception, Sense Motive, or Stealth. You gain a +1 trait bonus on this skill and it is always considered a class skill for you.)",
		},
		#endregion

		#region Devotee of the Old Gods
		new Trait
		{
			Name = nameof(TraitEnum.DevoteeoftheOldGods),
			ProperName = "Devotee of the Old Gods",
			Category = TraitCategoryEnum.MummysMask,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/mummy-s-mask/devotee-of-the-old-gods"),
			Description = "You gain a +1 trait bonus on Knowledge (history) and Knowledge (religion) checks, and one of those skills is always a class skill for you. In addition, your faith in the old gods grants you a +1 trait bonus on saving throws against divine magic.)",
		},
		#endregion

		#region Diabolist Raised
		new Trait
		{
			Name = nameof(TraitEnum.DiabolistRaised),
			ProperName = "Diabolist Raised",
			Category = TraitCategoryEnum.CouncilofThieves,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/council-of-thieves/diabolist-raised"),
			Description = "You gain a +1 bonus on Bluff, Diplomacy, Intimidate, and Sense Motive checks made against local nobility, and a +1 bonus on all saving throws made against mind-affecting attacks from devils.)",
		},
		#endregion

		#region Dockside Brawler
		new Trait
		{
			Name = nameof(TraitEnum.DocksideBrawler),
			ProperName = "Dockside Brawler",
			Category = TraitCategoryEnum.SkullShackles,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/skull-shackles/dockside-brawler"),
			Description = "You begin with brass knuckles in addition to your starting wealth. You gain a +1 trait bonus on damage rolls with brass knuckles and improvised weapons.)",
		},
		#endregion

		#region Drug Addict
		new Trait
		{
			Name = nameof(TraitEnum.DrugAddict),
			ProperName = "Drug Addict",
			Category = TraitCategoryEnum.CurseoftheCrimsonThrone,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/curse-of-the-crimson-throne/drug-addict"),
			Description = "Choose 'friend' or 'self'. If you choose 'friend', you gain a +2 bonus on Knowledge (local) checks or Diplomacy checks to gather information (choose one when selecting this trait). If you choose 'self' you were the addict. You gain a +1 bonus on Fortitude saving throws.)",
		},
		#endregion

		#region Earning Your Freedom
		new Trait
		{
			Name = nameof(TraitEnum.EarningYourFreedom),
			ProperName = "Earning Your Freedom",
			Category = TraitCategoryEnum.LegacyofFire,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("https://sites.google.com/site/pathfinderogc/traits/campaign-traits/legacy-of-fire/earning-your-freedom"),
			Description = "Choose Fortitude, Reflex, or Will; you gain a +1 trait bonus on all saving throws of that type.)",
		},
		#endregion

		#region Exchange Agent
		new Trait
		{
			Name = nameof(TraitEnum.ExchangeAgent),
			ProperName = "Exchange Agent",
			Category = TraitCategoryEnum.ShatteredStar,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/shattered-star/exchange-agent"),
			Description = "You gain one language as a bonus language. Additionally, choose one of the following skills: Handle Animal, Knowledge (geography), Linguistics, or Survival. You gain a +1 trait bonus on checks made with this skill and it is always a class skill for you.)",
		},
		#endregion

		#region Eye for Plunder
		new Trait
		{
			Name = nameof(TraitEnum.EyeforPlunder),
			ProperName = "Eye for Plunder",
			Category = TraitCategoryEnum.SkullShackles,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/skull-shackles/eye-for-plunder"),
			Description = "You gain a +1 trait bonus on Appraise and Perception checks to find concealed or secret objects (including doors and traps). In addition, you begin the campaign with a selection mundane trade goods worth 50 gp that you were able to scrounge together during your first day on the ship.)",
		},
		#endregion

		#region Favored Child
		new Trait
		{
			Name = nameof(TraitEnum.FavoredChild),
			ProperName = "Favored Child",
			Category = TraitCategoryEnum.RiseoftheRunelords,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/rise-of-the-runelords/favored-son-daughter"),
			Description = "You gain a +1 trait bonus on Knowledge (local) checks, and Knowledge (local) is always a class skill for you. In addition, you can choose any one law-abiding citizen from below as an ally; depending on the person you pick, you’ll get different benefits. Local noble and Innkeeper: You gain an additional 10% over the amount of gp you normally would get from selling off treasure. Town Sheriff: You can call in a favor from him once per game session. A favor can either get you out of a legal jam, hook you up with a town guard for help, or give you a one-time +10 bonus on a Bluff, Diplomacy, or Intimidate check made against any local person.)",
		},
		#endregion

		#region Finding Your Kin
		new Trait
		{
			Name = nameof(TraitEnum.FindingYourKin),
			ProperName = "Finding Your Kin",
			Category = TraitCategoryEnum.LegacyofFire,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/legacy-of-fire/finding-haleen"),
			Description = "The class you chose at 1st level is always a favored class to you. Every time you take a level in the class, you gain +1 hit point and 1 additional skill point over and above what you would normally gain.)",
		},
		#endregion

		#region Firebrand
		new Trait
		{
			Name = nameof(TraitEnum.Firebrand),
			ProperName = "Firebrand",
			Category = TraitCategoryEnum.CouncilofThieves,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/council-of-thieves/westcrown-firebrand"),
			Description = "You gain a +1 trait bonus on Initiative checks, and if you act in a surprise round, you gain a +1 trait bonus on all attack rolls.)",
		},
		#endregion

		#region Fools for Friends
		new Trait
		{
			Name = nameof(TraitEnum.FoolsforFriends),
			ProperName = "Fools for Friends",
			Category = TraitCategoryEnum.SecondDarkness,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/second-darkness/fools-for-friends"),
			Description = "Whenever you perform the Aid Another action, or whenever an ally aids you in this manner, a successful check grants an additional +1 trait bonus to the check for which aid was being rendered. Additionally, as long as one of your friends is within 30 feet, you gain a +1 trait bonus on all saving throws against charm and compulsion effects.)",
		},
		#endregion

		#region Foreign Opportunist
		new Trait
		{
			Name = nameof(TraitEnum.ForeignOpportunist),
			ProperName = "Foreign Opportunist",
			Category = TraitCategoryEnum.MummysMask,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/mummy-s-mask/foreign-opportunist"),
			Description = "You gain a +2 trait bonus on Appraise checks, and Appraise is always a class skill for you. In addition, your contacts in the antiquities markets allow you to sell relics for 60% of their listed price, rather than the normal 50% value. What is considered an ancient relic is left to the GM's discretion.)",
		},
		#endregion

		#region Former Assassin
		new Trait
		{
			Name = nameof(TraitEnum.FormerAssassin),
			ProperName = "Former Assassin",
			Category = TraitCategoryEnum.ShatteredStar,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/shattered-star/ex-sczarni"),
			Description = "You gain a +2 trait bonus on Bluff checks to pass hidden messages. Also, anytime you deliver a coup de grace, you deal an additional 1d6 points of damage.)",
		},
		#endregion

		#region Foster Child
		new Trait
		{
			Name = nameof(TraitEnum.FosterChild),
			ProperName = "Foster Child",
			Category = TraitCategoryEnum.JadeRegent,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/jade-regent-traits/foster-child"),
			Description = "You have an adoptive mother. Choose any Knowledge skill—you gain a +2 bonus on skill checks with that Knowledge skill, and it becomes a class skill for you. In addition, you gain a +1 trait bonus on all attack rolls against foes that threaten your adoptive mother.)",
		},
		#endregion

		#region Framed
		new Trait
		{
			Name = nameof(TraitEnum.Framed),
			ProperName = "Framed",
			Category = TraitCategoryEnum.CurseoftheCrimsonThrone,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("https://sites.google.com/site/pathfinderogc/traits/campaign-traits/curse-of-the-crimson-throne/framed"),
			Description = "You gain a +2 bonus on Spellcraft checks.)",
		},
		#endregion

		#region Friend of the Family
		new Trait
		{
			Name = nameof(TraitEnum.FriendoftheFamily),
			ProperName = "Friend of the Family",
			Category = TraitCategoryEnum.JadeRegent,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/jade-regent-traits/friend-of-the-family"),
			Description = "You have a close family friend. As long as your family friend remains alive, you gain a +1 trait bonus on Perception checks, and Perception becomes a class skill for you. In addition, you gain a +1 trait bonus on all attack rolls against foes that threaten your family friend.)",
		},
		#endregion

		#region Get the Cargo Through
		new Trait
		{
			Name = nameof(TraitEnum.GettheCargoThrough),
			ProperName = "Get the Cargo Through",
			Category = TraitCategoryEnum.SerpentsSkull,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/serpent-s-skull/get-the-cargo-through"),
			Description = "Your character’s history as a merchant or mercenary has earned her a respectable living, and you begin the campaign with an additional 300 gp in starting wealth.)",
		},
		#endregion

		#region Gnoll Killer
		new Trait
		{
			Name = nameof(TraitEnum.GnollKiller),
			ProperName = "Gnoll Killer",
			Category = TraitCategoryEnum.LegacyofFire,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/legacy-of-fire/gnoll-killer"),
			Description = "You gain a +1 trait bonus on attack rolls and weapon damage rolls made against gnolls. If you are a barbarian and you’re fighting gnolls, your rage lasts 1 round longer than normal. If you’re a ranger and you select humanoid (gnoll) as a favored enemy, your trait bonus on attack rolls and weapon damage rolls against gnolls increases to +2. If you’re a spellcaster, you gain a +1 trait bonus to spell save DCs for damaging spells against gnolls.)",
		},
		#endregion

		#region Hero Worship
		new Trait
		{
			Name = nameof(TraitEnum.HeroWorship),
			ProperName = "Hero Worship",
			Category = TraitCategoryEnum.JadeRegent,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/jade-regent-traits/hero-worship"),
			Description = "You admire an NPC as a hero to respect and attempt to model your life after. You gain one of the following benefits depending on the NPC chosen (consult your GM for details). A +2 bonus on concentration checks. A +1 bonus to your AC against attacks of opportunity.)",
		},
		#endregion

		#region Infernal Bastard
		new Trait
		{
			Name = nameof(TraitEnum.InfernalBastard),
			ProperName = "Infernal Bastard",
			Category = TraitCategoryEnum.CouncilofThieves,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/council-of-thieves/infernal-bastard"),
			Description = "You are a tiefling but you lack a tiefling’s standard resistances to cold, electricity, and fire—instead, you merely have a +2 bonus on all saving throws made against these effects. Likewise, you do not have the ability to use darkness as a spell-like ability once per day—instead, you may choose any one 0-level spell that you can instead use at will as a spell-like ability.)",
		},
		#endregion

		#region Inquisitive Archaeologist
		new Trait
		{
			Name = nameof(TraitEnum.InquisitiveArchaeologist),
			ProperName = "Inquisitive Archaeologist",
			Category = TraitCategoryEnum.MummysMask,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/mummy-s-mask/inquisitive-archaeologist"),
			Description = "You gain a +2 trait bonus on Knowledge (engineering) checks, and that skill is always a class skill for you. In addition, you gain a +2 trait bonus on Perception checks to find concealed or secret doors in ancient structures.)",
		},
		#endregion

		#region Inspired by Greatness
		new Trait
		{
			Name = nameof(TraitEnum.InspiredbyGreatness),
			ProperName = "Inspired by Greatness",
			Category = TraitCategoryEnum.CarrionCrown,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/carrion-crown/inspired-by-greatness"),
			Description = "Choose one spell you can cast. From now on, you always cast this spell at +1 caster level.)",
		},
		#endregion

		#region Into Enemy Territory
		new Trait
		{
			Name = nameof(TraitEnum.IntoEnemyTerritory),
			ProperName = "Into Enemy Territory",
			Category = TraitCategoryEnum.SecondDarkness,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/second-darkness/into-enemy-territory"),
			Description = "Pick one of the three categories of saving throw. You gain a +1 trait bonus on all saving throws of that type.)",
		},
		#endregion

		#region Issian
		new Trait
		{
			Name = nameof(TraitEnum.Issian),
			ProperName = "Issian",
			Category = TraitCategoryEnum.Kingmaker,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/kingmaker/issian"),
			Description = "You gain a +1 trait bonus on all Will saves made to resist mind-affecting effects.)",
		},
		#endregion

		#region Jungle Scholar
		new Trait
		{
			Name = nameof(TraitEnum.JungleScholar),
			ProperName = "Jungle Scholar",
			Category = TraitCategoryEnum.SerpentsSkull,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/serpent-s-skull/mwangi-scholar"),
			Description = "You gain Polyglot as a bonus language and receive a +1 trait bonus on all Knowledge (history) checks regarding the jungle.)",
		},
		#endregion

		#region Looking for Work
		new Trait
		{
			Name = nameof(TraitEnum.LookingforWork),
			ProperName = "Looking for Work",
			Category = TraitCategoryEnum.SecondDarkness,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/second-darkness/looking-for-work"),
			Description = "Pick one of the following skills: Bluff, Craft (any), Diplomacy, Intimidate, Perform (any), Profession (gambler), or Perception. You gain a +1 trait bonus in that skill, and that skill is always considered a class skill for you.)",
		},
		#endregion

		#region Love Lost
		new Trait
		{
			Name = nameof(TraitEnum.LoveLost),
			ProperName = "Love Lost",
			Category = TraitCategoryEnum.CurseoftheCrimsonThrone,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/curse-of-the-crimson-throne/love-lost"),
			Description = "Choose 'parent' or 'lover'. If you choose 'parent' you gain a +2 bonus on one of the following skills: Craft, Perform, or Profession. If you choose 'lover' you gain a +2 bonus on Intimidate checks.)",
		},
		#endregion

		#region Making Good on Promises
		new Trait
		{
			Name = nameof(TraitEnum.MakingGoodonPromises),
			ProperName = "Making Good on Promises",
			Category = TraitCategoryEnum.CarrionCrown,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/carrion-crown/making-good-on-promises"),
			Description = "You gain a +2 trait bonus on saving throws against fear effects.)",
		},
		#endregion

		#region Missing Child
		new Trait
		{
			Name = nameof(TraitEnum.MissingChild),
			ProperName = "Missing Child",
			Category = TraitCategoryEnum.CurseoftheCrimsonThrone,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/curse-of-the-crimson-throne/missing-child"),
			Description = "Choose 'sibling' or 'child'. If you choose 'sibling' Diplomacy and Sense Motive are always class skills for you. If you choose 'child' you gain a +1 trait bonus on Will saves.)",
		},
		#endregion

		#region Missionary
		new Trait
		{
			Name = nameof(TraitEnum.Missionary),
			ProperName = "Missionary",
			Category = TraitCategoryEnum.LegacyofFire,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/legacy-of-fire/missionary"),
			Description = "Pick one of the following skills: Bluff, Diplomacy, Intimidate, Knowledge (religion), Perform (any), or Sense Motive. You gain a +1 trait bonus on checks using that skill, and it is always considered a class skill for you.)",
		},
		#endregion

		#region Monument Scholar
		new Trait
		{
			Name = nameof(TraitEnum.MonumentScholar),
			ProperName = "Monument Scholar",
			Category = TraitCategoryEnum.ShatteredStar,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/shattered-star/monument-scholar"),
			Description = "You gain a +1 trait bonus on Knowledge (history) checks made in your home city. This bonus increases to +2 if the check relates to that city. Additionally, you gain a +2 trait bonus on any skill check made to receive a boon from one of the cities magically imbued monuments.)",
		},
		#endregion

		#region Mummy-Cursed
		new Trait
		{
			Name = nameof(TraitEnum.MummyCursed),
			ProperName = "Mummy-Cursed",
			Category = TraitCategoryEnum.MummysMask,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/mummy-s-mask/mummy-cursed"),
			Description = "You gain a +2 trait bonus on saving throws against curses and curse effects (including mummy rot and spells with the curse descriptor) and a +2 trait bonus on saving throws against a mummy's aura of despair.)",
		},
		#endregion

		#region Native
		new Trait
		{
			Name = nameof(TraitEnum.Native),
			ProperName = "Native",
			Category = TraitCategoryEnum.SkullShackles,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/skull-shackles/ilizmagorti-native"),
			Description = "You gain a +1 trait bonus on Sense Motive checks, and Sense Motive is always a class skill for you. In addition, your familiarity with the pirate's life allows you to make untrained Knowledge (local) checks regarding pirates or the region.)",
		},
		#endregion

		#region Natural Born Sailor
		new Trait
		{
			Name = nameof(TraitEnum.NaturalBornSailor),
			ProperName = "Natural Born Sailor",
			Category = TraitCategoryEnum.SkullShackles,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/skull-shackles/besmara-s-blessing"),
			Description = "You gain a +1 trait bonus on Perception and Profession (sailor) checks. In addition, once per week you can reroll a Profession (sailor) check and take the higher result (you must announce that you are using this ability before the results of the check are known).)",
		},
		#endregion

		#region Necropolis Native
		new Trait
		{
			Name = nameof(TraitEnum.NecropolisNative),
			ProperName = "Necropolis Native",
			Category = TraitCategoryEnum.MummysMask,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/mummy-s-mask/necropolis-native"),
			Description = "You gain a +2 trait bonus on saving throws against fear effects. In addition, your knowledge of the city grants you a +1 trait bonus on Knowledge (local) checks, and that skill is always a class skill for you.)",
		},
		#endregion

		#region Noble Born
		new Trait
		{
			Name = nameof(TraitEnum.NobleBorn),
			ProperName = "Noble Born",
			Category = TraitCategoryEnum.Kingmaker,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/kingmaker/noble-born"),
			Description = "Choose one of the following:      You ignore the movement penalty for the first 5 feet of rocky difficult terrain you move through per round. This applies only to terrain made difficult by rocks or ruins. In addition, you gain a +2 trait bonus on Appraise checks to assess the value of natural stones or metals. Your family motto is “Strong as the Mountains.”     You gain one of the following languages as a bonus language: Dwarven, Elven, Hallit, Gnome, Giant, Halfling, Skald, or Sylvan. Your family motto is “Success through Grace.”     You gain a +1 trait bonus on Swim checks, and Swim is always treated as a class skill for you. Your family motto is “The Waters, Our Fields.”     You gain a +2 trait bonus on all Diplomacy checks made to deal with fey creatures and a +1 trait bonus on Will saves made against their spells and supernatural abilities. Your family motto is “Endurance Overcomes All.”     You gain a +1 trait bonus on your CMD. In addition, choose Acrobatics, Diplomacy, or Stealth—you gain a +1 trait bonus on this skill. Your family motto is “High Above.”     You deal +2 damage when attacking a flat-footed opponent while wielding a light or one-handed weapon. Your family motto is “Ours is the Right.”)",
		},
		#endregion

		#region Nontraditional Native
		new Trait
		{
			Name = nameof(TraitEnum.NontraditionalNative),
			ProperName = "Nontraditional Native",
			Category = TraitCategoryEnum.ShatteredStar,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/shattered-star/nontraditional-native"),
			Description = "You gain either a +1 trait bonus on Knowledge (geography) checks made relating to a specific city and a +1 trait bonus on damage rolls made during the surprise round when you're wielding a bladed scarf or starknife, or you gain a +1 trait bonus on Survival checks made while in a specific city and gain a +1 trait bonus on rolls to confirm critical hits made using an earth breaker or a klar.)",
		},
		#endregion

		#region On the Payroll
		new Trait
		{
			Name = nameof(TraitEnum.OnthePayroll),
			ProperName = "On the Payroll",
			Category = TraitCategoryEnum.CarrionCrown,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/carrion-crown/on-the-payroll"),
			Description = "You begin play with an additional 150 gp in starting wealth.)",
		},
		#endregion

		#region Optimistic Gambler
		new Trait
		{
			Name = nameof(TraitEnum.OptimisticGambler),
			ProperName = "Optimistic Gambler",
			Category = TraitCategoryEnum.SecondDarkness,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/second-darkness/optimistic-gambler"),
			Description = "Effects that grant you morale bonuses persist 1d4 rounds longer than they normally would as a result.)",
		},
		#endregion

		#region Outlander
		new Trait
		{
			Name = nameof(TraitEnum.Outlander),
			ProperName = "Outlander",
			Category = TraitCategoryEnum.RiseoftheRunelords,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/rise-of-the-runelords/outlander"),
			Description = "Choose one of the following: Lore Seeker: You gain a +1 trait bonus on Knowledge (arcana) checks, and Knowledge (arcana) is always a class skill for you. If you cast arcane spells, pick three spells on your spell list. You are particularly adept at casting these spells, so they function at +1 caster level when you cast them, and their save DCs (if any) gain a +1 bonus. Exile: You gain a +2 trait bonus on Initiative checks. Missionary: You gain a +1 trait bonus on Knowledge (religion) checks, and Knowledge (religion) is always a class skill for you. If you cast divine spells, pick three spells on your spell list. You are particularly adept at casting these spells, so they function at +1 caster level when you cast them, and their save DCs (if any) gain a +1 bonus.)",
		},
		#endregion

		#region Peg Leg
		new Trait
		{
			Name = nameof(TraitEnum.PegLeg),
			ProperName = "Peg Leg",
			Category = TraitCategoryEnum.SkullShackles,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/skull-shackles/peg-leg"),
			Description = "You gain a +1 trait bonus on Fortitude saves and a +1 trait bonus on damage rolls against sharks and other animals with the aquatic subtype.)",
		},
		#endregion

		#region Pioneer
		new Trait
		{
			Name = nameof(TraitEnum.Pioneer),
			ProperName = "Pioneer",
			Category = TraitCategoryEnum.Kingmaker,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/kingmaker/pioneer"),
			Description = "You begin play with a horse. Choose one of the following skills: Climb, Handle Animal, Knowledge (nature), Perception, Ride, Survival, or Swim—you gain a +1 trait bonus on this skill.)",
		},
		#endregion

		#region Reclaiming your Roots
		new Trait
		{
			Name = nameof(TraitEnum.ReclaimingyourRoots),
			ProperName = "Reclaiming your Roots",
			Category = TraitCategoryEnum.LegacyofFire,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/legacy-of-fire/reclaiming-your-roots"),
			Description = "You begin with a piece of jewelry worth 350 gp, or any masterwork weapon or armor worth not more than 350 gp, or a wand containing any 1st-level spell (CL 1st) with 20 charges remaining. If you ever lose this item, you suffer a –1 penalty on Will saves for 1 year.)",
		},
		#endregion

		#region Rescued
		new Trait
		{
			Name = nameof(TraitEnum.Rescued),
			ProperName = "Rescued",
			Category = TraitCategoryEnum.JadeRegent,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/jade-regent-traits/rescued"),
			Description = "You gain a +1 trait bonus on all attack rolls against foes that threaten your savior as well as one of the following: You gain a +2 trait bonus whenever you use cure spells to heal damage or you gain a +1 trait bonus on Acrobatics checks and Acrobatics is always a class skill for you.)",
		},
		#endregion

		#region Researching the Blot
		new Trait
		{
			Name = nameof(TraitEnum.ResearchingtheBlot),
			ProperName = "Researching the Blot",
			Category = TraitCategoryEnum.SecondDarkness,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/second-darkness/researching-the-blot"),
			Description = "You can use Spellcraft to identify magic items in the same way you can use Spellcraft to identify a potion. The DC to identify a magic item is equal to 20 + the item’s caster level.)",
		},
		#endregion

		#region Resurrected
		new Trait
		{
			Name = nameof(TraitEnum.Resurrected),
			ProperName = "Resurrected",
			Category = TraitCategoryEnum.MummysMask,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/mummy-s-mask/resurrected"),
			Description = "You gain a +2 trait bonus on saving throws against death effects. In addition, you do not die until your hit points drop to a negative amount equal to or lower than your Constitution score + 4.)",
		},
		#endregion

		#region Riverlander
		new Trait
		{
			Name = nameof(TraitEnum.Riverlander),
			ProperName = "Riverlander",
			Category = TraitCategoryEnum.Kingmaker,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/kingmaker/rostlander"),
			Description = "Your gain a +1 trait bonus on all Fortitude saves.)",
		},
		#endregion

		#region Ruin Raider
		new Trait
		{
			Name = nameof(TraitEnum.RuinRaider),
			ProperName = "Ruin Raider",
			Category = TraitCategoryEnum.ShatteredStar,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/shattered-star/ruin-raider"),
			Description = "You gain a +1 trait bonus on Appraise checks. Additionally, you gain a +4 bonus on Perception checks made to distinguish statue-like creatures (like caryatid columns and gargoyles) from actual sculptures.)",
		},
		#endregion

		#region Scouting for Fiends
		new Trait
		{
			Name = nameof(TraitEnum.ScoutingforFiends),
			ProperName = "Scouting for Fiends",
			Category = TraitCategoryEnum.SecondDarkness,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/second-darkness/scouting-for-fiends"),
			Description = "You gain a +1 trait bonus on all attack rolls made against foes you know to be evil outsiders.)",
		},
		#endregion

		#region Seeking Adventure
		new Trait
		{
			Name = nameof(TraitEnum.SeekingAdventure),
			ProperName = "Seeking Adventure",
			Category = TraitCategoryEnum.LegacyofFire,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/legacy-of-fire/seeking-adventure"),
			Description = "You begin with a wayfinder. A wayfinder is a magical compass that grants you a +2 circumstance bonus on Survival checks to avoid becoming lost, and can be commanded to emit light as the spell (CL 5th) as a standard action.)",
		},
		#endregion

		#region Serpent Runner
		new Trait
		{
			Name = nameof(TraitEnum.SerpentRunner),
			ProperName = "Serpent Runner",
			Category = TraitCategoryEnum.ShatteredStar,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/shattered-star/serpent-runner"),
			Description = "Choose one of the following benefits: a) Choose a specific type of armor. When wearing armor of that type, you treat its armor check penalty as if it were –1 lower, or b) when fighting with two weapons, the penalty imposed on your primary weapon is reduced by 1, or c) you gain a +2 trait bonus on Intimidate checks to demoralize opponents.)",
		},
		#endregion

		#region Shadow Child
		new Trait
		{
			Name = nameof(TraitEnum.ShadowChild),
			ProperName = "Shadow Child",
			Category = TraitCategoryEnum.CouncilofThieves,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/council-of-thieves/shadow-child"),
			Description = "When attacking targets in areas of dim light, you do not suffer the standard 20% miss chance on attack rolls for being in the poorly lit area.)",
		},
		#endregion

		#region Ship's Crew
		new Trait
		{
			Name = nameof(TraitEnum.ShipsCrew),
			ProperName = "Ships Crew",
			Category = TraitCategoryEnum.SerpentsSkull,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/serpent-s-skull/jenivere-crew"),
			Description = "Pick one of the following skills: Acrobatics, Climb, Knowledge (nature), Knowledge (geography), Swim, or Survival. You gain a +1 trait bonus on that skill, and that skill is always treated as a class skill for you.)",
		},
		#endregion

		#region Ship's Surgeon
		new Trait
		{
			Name = nameof(TraitEnum.ShipsSurgeon),
			ProperName = "Ships Surgeon",
			Category = TraitCategoryEnum.SkullShackles,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/skull-shackles/ship-s-surgeon"),
			Description = "You begin play with a fully stocked healer's kit and gain a +1 trait bonus on Craft (carpentry) and Heal checks, and Heal is always a class skill for you.)",
		},
		#endregion

		#region Sphinx Riddler
		new Trait
		{
			Name = nameof(TraitEnum.SphinxRiddler),
			ProperName = "Sphinx Riddler",
			Category = TraitCategoryEnum.MummysMask,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/mummy-s-mask/sphinx-riddler"),
			Description = "You gain a +1 trait bonus on Bluff and Diplomacy checks against sphinxes, and a +1 trait bonus on any skill check to decipher a puzzle or riddle. In addition, you may choose Sphinx as one of your bonus languages.)",
		},
		#endregion

		#region Stowaway
		new Trait
		{
			Name = nameof(TraitEnum.Stowaway),
			ProperName = "Stowaway",
			Category = TraitCategoryEnum.SerpentsSkull,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/serpent-s-skull/stowaway"),
			Description = "You gain a +1 trait bonus on Stealth checks and Survival checks to find food.)",
		},
		#endregion

		#region Student Survivalist
		new Trait
		{
			Name = nameof(TraitEnum.StudentSurvivalist),
			ProperName = "Student Survivalist",
			Category = TraitCategoryEnum.JadeRegent,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/jade-regent-traits/student-survivalist"),
			Description = "You have a helpful mentor NPC. You gain a +2 trait bonus on all Survival checks, and Survival is always a class skill for you. In addition, you gain a +1 trait bonus on all attack rolls against foes that threaten your mentor.)",
		},
		#endregion

		#region Subject of Study
		new Trait
		{
			Name = nameof(TraitEnum.SubjectofStudy),
			ProperName = "Subject of Study",
			Category = TraitCategoryEnum.CarrionCrown,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/carrion-crown/subject-of-study"),
			Description = "Choose a non-humanoid creature type (and subtype if outsider). You gain a +1 bonus on damage rolls against creatures of this type.)",
		},
		#endregion

		#region Sword Scion
		new Trait
		{
			Name = nameof(TraitEnum.SwordScion),
			ProperName = "Sword Scion",
			Category = TraitCategoryEnum.Kingmaker,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/kingmaker/sword-scion"),
			Description = "You begin play with a longsword or dueling sword and gain a +1 trait bonus on all attacks and combat maneuvers made with such weapons.)",
		},
		#endregion

		#region Teacher’s Pet
		new Trait
		{
			Name = nameof(TraitEnum.TeachersPet),
			ProperName = "Teacher’s Pet",
			Category = TraitCategoryEnum.CarrionCrown,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/carrion-crown/teacher-s-pet"),
			Description = "You gain a +2 trait bonus to one Knowledge skill of your choosing and consider it a class skill.)",
		},
		#endregion

		#region The Pathfinder's Exile
		new Trait
		{
			Name = nameof(TraitEnum.ThePathfindersExile),
			ProperName = "The Pathfinders Exile",
			Category = TraitCategoryEnum.CouncilofThieves,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/council-of-thieves/the-pathfinder-s-exile"),
			Description = "You gain a battered and tarnished, yet functional wayfinder. A wayfinder is a magical compass that grants you a +2 circumstance bonus on Survival checks to avoid becoming lost, and can be commanded to emit light as the spell (CL 5th) as a standard action.)",
		},
		#endregion

		#region Touched by the Sea
		new Trait
		{
			Name = nameof(TraitEnum.TouchedbytheSea),
			ProperName = "Touched by the Sea",
			Category = TraitCategoryEnum.SkullShackles,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/skull-shackles/touched-by-the-sea"),
			Description = "You gain a +1 trait bonus on Swim checks and Swim is always a class skill for you. In addition, penalties on attack rolls made underwater are lessened by 1.)",
		},
		#endregion

		#region Trap Finder
		new Trait
		{
			Name = nameof(TraitEnum.TrapFinder),
			ProperName = "Trap Finder",
			Category = TraitCategoryEnum.MummysMask,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/mummy-s-mask/trap-finder"),
			Description = "You gain a +1 trait bonus on Disable Device checks, and that skill is always a class skill for you. In addition, you can use Disable Device to disarm magic traps, like a rogue.)",
		},
		#endregion

		#region Undead Crusader
		new Trait
		{
			Name = nameof(TraitEnum.UndeadCrusader),
			ProperName = "Undead Crusader",
			Category = TraitCategoryEnum.MummysMask,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/mummy-s-mask/undead-crusader"),
			Description = "You gain a +1 trait bonus on damage rolls against undead creatures. In addition, you gain a +1 trait bonus on Knowledge (religion) checks, and that skill is always a class skill for you.)",
		},
		#endregion

		#region Unhappy Childhood
		new Trait
		{
			Name = nameof(TraitEnum.UnhappyChildhood),
			ProperName = "Unhappy Childhood",
			Category = TraitCategoryEnum.CurseoftheCrimsonThrone,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/curse-of-the-crimson-throne/unhappy-childhood"),
			Description = "You gain a +1 bonus on Reflex saving throws.)",
		},
		#endregion

		#region Younger Sibling
		new Trait
		{
			Name = nameof(TraitEnum.YoungerSibling),
			ProperName = "Younger Sibling",
			Category = TraitCategoryEnum.JadeRegent,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/campaign-traits/jade-regent-traits/younger-sibling"),
			Description = "You gain a +1 trait bonus on all attack rolls against foes that threaten your older sibling as well as one of the following: You gain a +1 trait bonus on Will saving throws or you gain a +1 trait bonus on all Fortitude saving throws. If you’re the younger sibling of a specific NPC (consult your GM), your quick reflexes give you a +1 trait bonus on all Reflex saving throws.)",
		},
		#endregion


		#endregion

		#region Equipment

		#region Augmented Disguise
		new Trait
		{
			Name = nameof(TraitEnum.AugmentedDisguise),
			ProperName = "Augmented Disguise",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/equipment-traits/augmented-disguise"),
			Description = "You gain a +2 trait bonus on Disguise checks when wearing a wig, false beard, or similar large prop, or if you are wearing a special costume or eye-catching bauble that reinforces your disguise.)",
		},
		#endregion

		#region Dealmaker
		new Trait
		{
			Name = nameof(TraitEnum.Dealmaker),
			ProperName = "Dealmaker",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/equipment-traits/dealmaker"),
			Description = "Once per week, when looking for an item with a price greater than the local community’s base value, make a DC 10 Diplomacy check; add 10 to the DC for each community size category between the current community and the community size with a base value sufficient for that item. Success means (with GM approval) you’re able to sell or purchase that item as if the local community were of sufficient size. Each additional attempt (successful or otherwise) in that community increases the DC by an additional +10.)",
		},
		#endregion

		#region Extremely Fashionable
		new Trait
		{
			Name = nameof(TraitEnum.ExtremelyFashionable),
			ProperName = "Extremely Fashionable",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/equipment-traits/extremely-fashionable"),
			Description = "Whenever you are wearing clean and presentable clothing and/or jewelry worth at least 150 gp, you gain a +1 trait bonus on Bluff, Diplomacy, and Intimidate checks. One of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Heirloom Weapon
		new Trait
		{
			Name = nameof(TraitEnum.HeirloomWeapon),
			ProperName = "Heirloom Weapon",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/equipment-traits/heirloom-weapon"),
			Description = "Choose a non-masterwork simple or martial weapon and one of the following benefits: a) You gain proficiency with that specific weapon; b) You gain a +1 trait bonus on attacks of opportunity with that specific weapon; or c) You gain a +2 trait bonus on one kind of combat maneuver when using that specific weapon. Note: This trait does not give you that item, it must still be purchased normally.)",
		},
		#endregion

		#region Improvisational Equipment
		new Trait
		{
			Name = nameof(TraitEnum.ImprovisationalEquipment),
			ProperName = "Improvisational Equipment",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/equipment-traits/improvisational-equipment"),
			Description = "When using an item for anything other than its intended purpose—such as using a crowbar as a grappling hook or an old shirt to bandage a deadly wound—reduce the improvisation penalty by 2. This does not apply to improvised weapon penalties. Your GM may rule that some things are just not suitable for use in certain ways; for example, gluing a dead orc’s face to your own face won’t help you disguise yourself as an orc.)",
		},
		#endregion

		#region Iron Liver
		new Trait
		{
			Name = nameof(TraitEnum.IronLiver),
			ProperName = "Iron Liver",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/equipment-traits/iron-liver"),
			Description = "You gain a +2 trait bonus on Fortitude saving throws against poison and drugs, and a +4 trait bonus on Fortitude saves to avoid the effects of alcohol.)",
		},
		#endregion

		#region Power of Suggestion
		new Trait
		{
			Name = nameof(TraitEnum.PowerofSuggestion),
			ProperName = "Power of Suggestion",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/equipment-traits/power-of-suggestion"),
			Description = "You may make a Bluff check to make observers believe that an object in your possession is actually a different object entirely. The DC for the check is 20 for items of a similar size, shape, and color (such as a glaive and a quarterstaff). Items of a different shape, size, or color raise the DC by 5 for each dissimilar aspect, or more if the dissimilarity is extreme. This deception lasts 1 minute; if the item is still in view, the observers may recognize their error unless you make another bluff check.)",
		},
		#endregion

		#region Prehensile Whip
		new Trait
		{
			Name = nameof(TraitEnum.PrehensileWhip),
			ProperName = "Prehensile Whip",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/equipment-traits/prehensile-whip"),
			Description = "You can use a whip as if it were a rope with a grappling hook at the end. Attaching your whip is a standard action, but detaching it is a full-round action.)",
		},
		#endregion

		#region Quick Learner
		new Trait
		{
			Name = nameof(TraitEnum.QuickLearner),
			ProperName = "Quick Learner",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/equipment-traits/quick-learner"),
			Description = "After your first attack in a combat with a weapon in which you are not proficient, the non-proficiency penalty decreases by 2 (to a –2 penalty). This effect lasts only while you have the weapon in hand; you must “relearn” the weapon each time you pick it up.)",
		},
		#endregion

		#region Rough and Ready
		new Trait
		{
			Name = nameof(TraitEnum.RoughandReady),
			ProperName = "Rough and Ready",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/equipment-traits/rough-and-ready"),
			Description = "When you use a tool of your trade (requiring at least 1 rank in the appropriate Craft or Profession skill) as a weapon, you do not take the improvised weapon penalty and instead receive a +1 trait bonus on your attack. This trait is commonly used with shovels, picks, blacksmith hammers, and other sturdy tools — lutes and brooms make terribly fragile weapons.)",
		},
		#endregion

		#region Stage Magic
		new Trait
		{
			Name = nameof(TraitEnum.StageMagic),
			ProperName = "Stage Magic",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/equipment-traits/stage-magic"),
			Description = "When you use an alchemical item such as a flask of alchemist’s fire, smokestick, thunderstone, or another appropriate alchemical item (GM’s discretion) as part of a performance, you gain a +2 trait bonus on your Perform check for the duration of that performance. The item is expended without its normal effects and only serves to make your performance more impressive; for example, you could pretend to ignite yourself with alchemist’s fire as part of a Perform (comedy) check or make a dramatic appearance with a smokestick as part of a Perform (act) check, but you would not actually take fire damage or gain concealment from smoke.)",
		},
		#endregion

		#region Stealthy Escape
		new Trait
		{
			Name = nameof(TraitEnum.StealthyEscape),
			ProperName = "Stealthy Escape",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/equipment-traits/stealthy-escape"),
			Description = "When trying to escape manacles, rope, or other similar restraints (but not grapples or similar attacks), you may make a Sleight of Hand check instead of your Escape Artist modifier. If you free yourself, you gain a +2 trait bonus on Bluff checks to pretend that you are still bound.)",
		},
		#endregion

		#region Thrown-Together Fashion
		new Trait
		{
			Name = nameof(TraitEnum.ThrownTogetherFashion),
			ProperName = "Thrown-Together Fashion",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/equipment-traits/thrown-together-fashion"),
			Description = "With a basic sewing kit or disguise kit, you can make a Disguise check to change one outfit into another outfit. The DC of this check is equal to 10 + the gp difference between costs of the outfits. The alteration takes 10 minutes per 1-gp difference in the cost of the outfits.)",
		},
		#endregion


		#endregion

		#region Faction

		#region Aid Allies
		new Trait
		{
			Name = nameof(TraitEnum.AidAllies),
			ProperName = "Aid Allies",
			TraitType = TraitTypeEnum.Basic,
			Description = "When using the aid another action, you give your ally a +3 bonus instead of a +2 bonus.)",
		},
		#endregion

		#region A Sure Thing
		new Trait
		{
			Name = nameof(TraitEnum.ASureThing),
			ProperName = "A Sure Thing",
			TraitType = TraitTypeEnum.Basic,
			Description = "Once per day, you gain a +2 bonus on a single attack against an evil-aligned creature. If the creature is not evil-aligned, this ability is wasted with no benefit.)",
		},
		#endregion

		#region Attuned to the Ancestors
		new Trait
		{
			Name = nameof(TraitEnum.AttunedtotheAncestors),
			ProperName = "Attuned to the Ancestors",
			TraitType = TraitTypeEnum.Basic,
			Description = "Once per day, you can surround yourself with an aura of unlife. Unintelligent undead ignore you unless you take action against them, per hide from undead. The protection lasts for 1 round per two character levels you possess. If you take any offensive action against any undead, this effect immediately ends. This is a supernatural ability.)",
		},
		#endregion

		#region Bad Reputation
		new Trait
		{
			Name = nameof(TraitEnum.BadReputation),
			ProperName = "Bad Reputation",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +2 trait bonus on Intimidate checks, and Intimidate becomes a class skill for you.)",
		},
		#endregion

		#region Beneficient Touch
		new Trait
		{
			Name = nameof(TraitEnum.BeneficientTouch),
			ProperName = "Beneficient Touch",
			TraitType = TraitTypeEnum.Basic,
			Description = "Once per day, when you cast a spell or use a class ability that heals hit point damage, reroll any 1s that appear on the dice and take the new roll (even if it is another 1).)",
		},
		#endregion

		#region Captain's Blade
		new Trait
		{
			Name = nameof(TraitEnum.CaptainsBlade),
			ProperName = "Captains Blade",
			TraitType = TraitTypeEnum.Basic,
			Description = "While on board any vessel afloat on water, you gain a +1 trait bonus on Acrobatics and Climb checks. One of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Comparative Religion
		new Trait
		{
			Name = nameof(TraitEnum.ComparativeReligion),
			ProperName = "Comparative Religion",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on Knowledge (religion) skill checks, and Knowledge (religion) becomes a class skill for you.)",
		},
		#endregion

		#region Dervish
		new Trait
		{
			Name = nameof(TraitEnum.Dervish),
			ProperName = "Dervish",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 dodge bonus to Armor Class against attacks of opportunity caused when you move out of or within a threatened area. Dodge bonuses stack with each other, unlike most types of bonuses.)",
		},
		#endregion

		#region Desert Shadow
		new Trait
		{
			Name = nameof(TraitEnum.DesertShadow),
			ProperName = "Desert Shadow",
			TraitType = TraitTypeEnum.Basic,
			Description = "When using the Stealth skill to move at full speed you no longer suffer a -5 penalty on your Stealth skill check.)",
		},
		#endregion

		#region Devil's Mark
		new Trait
		{
			Name = nameof(TraitEnum.DevilsMark),
			ProperName = "Devils Mark",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +2 trait bonus on all Bluff, Diplomacy, Intimidate, and Sense Motive checks when dealing with outsiders of the evil subtype.)",
		},
		#endregion

		#region Dunewalker
		new Trait
		{
			Name = nameof(TraitEnum.Dunewalker),
			ProperName = "Dunewalker",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +4 trait bonus on Fortitude checks to resist nonlethal damage from hot conditions and can always move through non-magical sand as if it were normal terrain.)",
		},
		#endregion

		#region Eastern Mysteries
		new Trait
		{
			Name = nameof(TraitEnum.EasternMysteries),
			ProperName = "Eastern Mysteries",
			TraitType = TraitTypeEnum.Basic,
			Description = "Once per day you may select one single spell that you are casting that allows for a saving throw. You may increase the DC of that spell by +2.)",
		},
		#endregion

		#region Expert Duelist
		new Trait
		{
			Name = nameof(TraitEnum.ExpertDuelist),
			ProperName = "Expert Duelist",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus to your Armor Class so long as you are adjacent to a single foe. This trait bonus is not applied to your Armor Class for touch attacks or when denied your Dex bonus.)",
		},
		#endregion

		#region Fashionable
		new Trait
		{
			Name = nameof(TraitEnum.Fashionable),
			ProperName = "Fashionable",
			TraitType = TraitTypeEnum.Basic,
			Description = "As long as you are wearing clothing and jewelry worth at least 80 gp, you gain a +1 trait bonus on Bluff, Diplomacy, and Sense Motive checks. One of these skills (your choice) becomes a class skill for you.)",
		},
		#endregion

		#region Fiendish Presence
		new Trait
		{
			Name = nameof(TraitEnum.FiendishPresence),
			ProperName = "Fiendish Presence",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on Diplomacy and Sense Motive checks. One of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Fires of Hell
		new Trait
		{
			Name = nameof(TraitEnum.FiresofHell),
			ProperName = "Fires of Hell",
			TraitType = TraitTypeEnum.Basic,
			Description = "Once per day, as a swift action, you can imbue a single weapon you hold with a nimbus of fire that deals an extra 1 point of fire damage for as many rounds as your Charisma bonus. This fire gives off light equivalent to a torch. This is a supernatural ability.)",
		},
		#endregion

		#region Force For Good
		new Trait
		{
			Name = nameof(TraitEnum.ForceForGood),
			ProperName = "Force For Good",
			TraitType = TraitTypeEnum.Basic,
			Description = "Your good-aligned spells function at +1 caster level. This trait makes your aura more powerful (one step higher), as outlined in the detect evil spell.)",
		},
		#endregion

		#region Fortified
		new Trait
		{
			Name = nameof(TraitEnum.Fortified),
			ProperName = "Fortified",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain the ability to negate a critical hit or sneak attack scored against you once per day. This functions as the fortification armor quality with a 20% chance of success.)",
		},
		#endregion

		#region Goldfinger
		new Trait
		{
			Name = nameof(TraitEnum.Goldfinger),
			ProperName = "Goldfinger",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on Disable Device and Sleight of Hand checks, and one of these skills (your choice) becomes a class skill for you.)",
		},
		#endregion

		#region Greasy Palm
		new Trait
		{
			Name = nameof(TraitEnum.GreasyPalm),
			ProperName = "Greasy Palm",
			TraitType = TraitTypeEnum.Basic,
			Description = "When bribing an NPC, you pay 10% less than a character without this trait would, garnering the same results.)",
		},
		#endregion

		#region Horse Lord
		new Trait
		{
			Name = nameof(TraitEnum.HorseLord),
			ProperName = "Horse Lord",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +2 trait bonus on Ride checks, and the Ride skill becomes a class skill for you.)",
		},
		#endregion

		#region Hunter's Eye
		new Trait
		{
			Name = nameof(TraitEnum.HuntersEye),
			ProperName = "Hunters Eye",
			TraitType = TraitTypeEnum.Basic,
			Description = "You do not suffer a penalty for the second range increment when using a longbow or shortbow and you are always considered proficient with one of these weapons (your choice).)",
		},
		#endregion

		#region I Know a Guy
		new Trait
		{
			Name = nameof(TraitEnum.IKnowaGuy),
			ProperName = "I Know a Guy",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +2 trait bonus on Diplomacy checks made to gather information and a +1 trait bonus on Knowledge (local) skill checks.)",
		},
		#endregion

		#region Impressive Presence
		new Trait
		{
			Name = nameof(TraitEnum.ImpressivePresence),
			ProperName = "Impressive Presence",
			TraitType = TraitTypeEnum.Basic,
			Description = "Once per day as a full-round action, you may attempt to distract adjacent foes with a lengthy display of your martial prowess. All adjacent foes must succeed on a Will save (DC 10 + 1/2 your level + your Charisma modifier) or gain the shaken condition. This condition persists for one round.)",
		},
		#endregion

		#region Indomitable
		new Trait
		{
			Name = nameof(TraitEnum.Indomitable),
			ProperName = "Indomitable",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on saving throws versus enchantment spells and effects.)",
		},
		#endregion

		#region Insider Knowledge
		new Trait
		{
			Name = nameof(TraitEnum.InsiderKnowledge),
			ProperName = "Insider Knowledge",
			TraitType = TraitTypeEnum.Basic,
			Description = "Choose either Diplomacy or Knowledge (local). You gain a +1 trait bonus on all related checks, and the chosen skill is always a class skill for you.)",
		},
		#endregion

		#region Loyalty
		new Trait
		{
			Name = nameof(TraitEnum.Loyalty),
			ProperName = "Loyalty",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on saving throws against enchantment spells and spell-like abilities)",
		},
		#endregion

		#region Master of Pentacles
		new Trait
		{
			Name = nameof(TraitEnum.MasterofPentacles),
			ProperName = "Master of Pentacles",
			TraitType = TraitTypeEnum.Basic,
			Description = "Once per day, when casting a spell of the conjuration school, you are at +2 caster level when determining the duration of the spell.)",
		},
		#endregion

		#region Medic
		new Trait
		{
			Name = nameof(TraitEnum.Medic),
			ProperName = "Medic",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +2 trait bonus on Heal checks made to treat diseases and poisons. Additionally, your caster level is considered one higher when casting spells of the healing subschool with remove in the spell’s name.)",
		},
		#endregion

		#region Meridian Strike
		new Trait
		{
			Name = nameof(TraitEnum.MeridianStrike),
			ProperName = "Meridian Strike",
			TraitType = TraitTypeEnum.Basic,
			Description = "Once per day when you roll damage on a successful critical hit, reroll any 1s and take the new roll (even if it is another 1).)",
		},
		#endregion

		#region Meticulous Artisan
		new Trait
		{
			Name = nameof(TraitEnum.MeticulousArtisan),
			ProperName = "Meticulous Artisan",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on Craft checks.)",
		},
		#endregion

		#region Mind Over Matter
		new Trait
		{
			Name = nameof(TraitEnum.MindOverMatter),
			ProperName = "Mind Over Matter",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on Will saving throws.)",
		},
		#endregion

		#region Mummy-Touched
		new Trait
		{
			Name = nameof(TraitEnum.MummyTouched),
			ProperName = "Mummy-Touched",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +2 trait bonus on saving throws versus diseases and curses.)",
		},
		#endregion

		#region Observant
		new Trait
		{
			Name = nameof(TraitEnum.Observant),
			ProperName = "Observant",
			TraitType = TraitTypeEnum.Basic,
			Description = "Choose Perception or Sense Motive. You gain a +1 trait bonus on all related checks, and the chosen skill is always a class skill for you.)",
		},
		#endregion

		#region Performance Artist
		new Trait
		{
			Name = nameof(TraitEnum.PerformanceArtist),
			ProperName = "Performance Artist",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on related Perform skill checks. This bonus increases to +5 when using that Perform skill to make money.)",
		},
		#endregion

		#region Proper Training
		new Trait
		{
			Name = nameof(TraitEnum.ProperTraining),
			ProperName = "Proper Training",
			TraitType = TraitTypeEnum.Basic,
			Description = "Choose either Knowledge (geography) or Knowledge (history). You gain a +1 trait bonus on all related checks, and the chosen skill is always a class skill for you.)",
		},
		#endregion

		#region Saint's Ward
		new Trait
		{
			Name = nameof(TraitEnum.SaintsWard),
			ProperName = "Saints Ward",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/faith-traits/st-clydwell-s-ward-mendev-crusaders"),
			Description = "As a standard action, you can recite a holy chant that affects demons as if you were under the effect of a sanctuary spell (caster level equal to 1/2 your Hit Dice + your Charisma modifier).)",
		},
		#endregion

		#region Secrets of the Sphinx
		new Trait
		{
			Name = nameof(TraitEnum.SecretsoftheSphinx),
			ProperName = "Secrets of the Sphinx",
			TraitType = TraitTypeEnum.Basic,
			Description = "Once per day, you may gain a +2 trait bonus on any single Knowledge skill check. Additionally, choose one Knowledge skill—this skill becomes a class skill for you.)",
		},
		#endregion

		#region Shadow Diplomat
		new Trait
		{
			Name = nameof(TraitEnum.ShadowDiplomat),
			ProperName = "Shadow Diplomat",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on Diplomacy checks, and Diplomacy becomes a class skill for you.)",
		},
		#endregion

		#region Shiv
		new Trait
		{
			Name = nameof(TraitEnum.Shiv),
			ProperName = "Shiv",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on damage rolls made with one- handed piercing or slashing weapons in a surprise round.)",
		},
		#endregion

		#region Sotto Voce
		new Trait
		{
			Name = nameof(TraitEnum.SottoVoce),
			ProperName = "Sotto Voce",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/magic-traits/tar-baphon-s-whisper-whispering-way"),
			Description = "You may cast sotto voce as a spell-like ability three times per day as a spell-like ability. This spell-like ability is cast at your highest caster level; if you have no caster level, it functions at CL 1st.)",
		},
		#endregion

		#region Soul-Drinker
		new Trait
		{
			Name = nameof(TraitEnum.SoulDrinker),
			ProperName = "Soul-Drinker",
			TraitType = TraitTypeEnum.Basic,
			Description = "Once per day as a swift action, you may gain a number of temporary hit points equal to the Hit Dice of your most recent enemy slain. This is a supernatural ability. These temporary hit points last for 1 minute.)",
		},
		#endregion

		#region Storyteller
		new Trait
		{
			Name = nameof(TraitEnum.Storyteller),
			ProperName = "Storyteller",
			TraitType = TraitTypeEnum.Basic,
			Description = "Once per scenario, you can make a Knowledge skill check with a trait bonus equal to your Intelligence modifier plus 3 (minimum +1). You can make this check even if you do not have ranks in the required Knowledge skill.)",
		},
		#endregion

		#region Teaching Mistake
		new Trait
		{
			Name = nameof(TraitEnum.TeachingMistake),
			ProperName = "Teaching Mistake",
			TraitType = TraitTypeEnum.Basic,
			Description = "Once per scenario, when you roll a natural 1 on any saving throw, you gain a +1 trait bonus on your next saving throw, used before the end of the scenario.)",
		},
		#endregion

		#region Tomb Raider
		new Trait
		{
			Name = nameof(TraitEnum.TombRaider),
			ProperName = "Tomb Raider",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 bonus on Perception and Knowledge (dungeoneering) checks, and one of these skills (your choice) becomes a class skill for you)",
		},
		#endregion

		#region Trouper
		new Trait
		{
			Name = nameof(TraitEnum.Trouper),
			ProperName = "Trouper",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on checks using a Perform skill of your choice and a +1 trait bonus on saving throws against abilities that rely upon the Perform skill to function, such as the bardic performance class ability.)",
		},
		#endregion

		#region Unorthodox Strategy
		new Trait
		{
			Name = nameof(TraitEnum.UnorthodoxStrategy),
			ProperName = "Unorthodox Strategy",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +2 trait bonus on Acrobatics checks made to move through an enemy’s threatened squares.)",
		},
		#endregion

		#region Vindictive
		new Trait
		{
			Name = nameof(TraitEnum.Vindictive),
			ProperName = "Vindictive",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on damage rolls against a single adjacent opponent who damaged you in the previous round of combat.)",
		},
		#endregion

		#region Watchdog
		new Trait
		{
			Name = nameof(TraitEnum.Watchdog),
			ProperName = "Watchdog",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on Sense Motive skill checks, and Sense Motive becomes a class skill for you.)",
		},
		#endregion

		#region Weapon Style
		new Trait
		{
			Name = nameof(TraitEnum.WeaponStyle),
			ProperName = "Weapon Style",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain proficiency in a monk weapon.)",
		},
		#endregion


		#endregion

		#region Race

		#region Adaptable Flatterer
		new Trait
		{
			Name = nameof(TraitEnum.AdaptableFlatterer),
			ProperName = "Adaptable Flatterer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/adaptable-flatterer-fetchling"),
			Description = "You gain a +1 trait bonus on Bluff checks and on attack rolls against opponents who are denied their Dexterity bonus to AC against you.)",
		},
		#endregion

		#region Adrift
		new Trait
		{
			Name = nameof(TraitEnum.Adrift),
			ProperName = "Adrift",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/adrift-aasimar"),
			Description = "You receive a +1 trait bonus on saving throws made to resist charm and compulsion effects.)",
		},
		#endregion

		#region Advantageous Distraction
		new Trait
		{
			Name = nameof(TraitEnum.AdvantageousDistraction),
			ProperName = "Advantageous Distraction",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/advantageous-distraction"),
			Description = "Once per day as a swift action, you can be momentarily distracted in combat—ducking an axe swing to inspect a toadstool, or stooping behind a tree to lick some bark and accidentally avoiding an arrow, and so on. When you activate this ability, you gain a +2 dodge bonus to your AC for 1 round.)",
		},
		#endregion

		#region Adventurous Explorer
		new Trait
		{
			Name = nameof(TraitEnum.AdventurousExplorer),
			ProperName = "Adventurous Explorer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/adventurous-explorer-song-o"),
			Description = "When frightened or shaken, you only take a -1 penalty on your rolls instead of -2.)",
		},
		#endregion

		#region Aerial Observer
		new Trait
		{
			Name = nameof(TraitEnum.AerialObserver),
			ProperName = "Aerial Observer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("https://sites.google.com/site/pathfinderogc/traits/race-traits/aerial-observer-sylph"),
			Description = "You gain a +2 trait bonus on Perception checks while you are at least 30 feet above ground level.)",
		},
		#endregion

		#region Alchemical Breath
		new Trait
		{
			Name = nameof(TraitEnum.AlchemicalBreath),
			ProperName = "Alchemical Breath",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/alchemical-breath-kobold-green-scaled"),
			Description = "You begin play with three pieces of the choking smoke variety of alchemical coal. Eating one of these pellets allows you to exhale noxious vapors, damaging and sickening your enemies. These pellets do not count against your starting character wealth.)",
		},
		#endregion

		#region Almost Human
		new Trait
		{
			Name = nameof(TraitEnum.AlmostHuman),
			ProperName = "Almost Human",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/almost-human"),
			Description = "You gain a + 4 trait bonus on Disguise checks to pass as human, and Disguise is always a class skill for you.)",
		},
		#endregion

		#region Animal Friend
		new Trait
		{
			Name = nameof(TraitEnum.AnimalFriend),
			ProperName = "Animal Friend",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/animal-friend-gnome"),
			Description = "You gain a +1 trait bonus on Will saving throws as long as an animal (Tiny or larger, must be at least indifferent toward you) is within 30 feet, and Handle Animal is always a class skill for you.)",
		},
		#endregion

		#region Animalistic Affliction
		new Trait
		{
			Name = nameof(TraitEnum.AnimalisticAffliction),
			ProperName = "Animalistic Affliction",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/animalistic-affliction-ulfen"),
			Description = "You gain a +1 trait bonus on Handle Animal and wild empathy checks.)",
		},
		#endregion

		#region Anticipate Evil
		new Trait
		{
			Name = nameof(TraitEnum.AnticipateEvil),
			ProperName = "Anticipate Evil",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/anticipate-evil-tiefling"),
			Description = "You gain a +1 trait bonus on opposed Dexterity-based skill checks against outsiders with the evil subtype. In addition, when your initiative is tied with such creatures, you always act first regardless of which of you has a higher initiative modifier.)",
		},
		#endregion

		#region Arcane Dabbler
		new Trait
		{
			Name = nameof(TraitEnum.ArcaneDabbler),
			ProperName = "Arcane Dabbler",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/arcane-dabbler-elf-racial-trait"),
			Description = "Choose a 0-level arcane spell. You may cast that spell once per day as a spell-like ability. Your caster level is equal to your highest class level in a spellcasting class; if you have no caster level, it functions at CL 1st. The spell-like ability's save DC is Intelligence- or Charisma-based (chosen when you select this trait).)",
		},
		#endregion

		#region Arcane Student
		new Trait
		{
			Name = nameof(TraitEnum.ArcaneStudent),
			ProperName = "Arcane Student",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/arcane-student"),
			Description = "You gain a +1 trait bonus on Knowledge (arcana) and Spellcraft checks, and you may make these checks untrained.)",
		},
		#endregion

		#region Arms Master
		new Trait
		{
			Name = nameof(TraitEnum.ArmsMaster),
			ProperName = "Arms Master",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/arms-master-tiefling-faultspawn"),
			Description = "You take a –2 penalty on attack rolls made with weapons with which you are not proficient instead of the normal –4.)",
		},
		#endregion

		#region Artistic Dilettante
		new Trait
		{
			Name = nameof(TraitEnum.ArtisticDilettante),
			ProperName = "Artistic Dilettante",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/artistic-dilettante"),
			Description = "You gain a +1 trait bonus on Appraise checks, and on checks for one Craft skill of your choice.)",
		},
		#endregion

		#region Aspiring Bard
		new Trait
		{
			Name = nameof(TraitEnum.AspiringBard),
			ProperName = "Aspiring Bard",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/aspiring-bard-human"),
			Description = "You gain a +1 trait bonus to one category of Perform checks and a +2 trait bonus to any Knowledge (local) checks that deal with the music scene.)",
		},
		#endregion

		#region Assimilated Native
		new Trait
		{
			Name = nameof(TraitEnum.AssimilatedNative),
			ProperName = "Assimilated Native",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Jungle,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/assimilated-native-mwangi"),
			Description = "You gain a +2 trait bonus on Intimidate checks to influence natives, but you suffer a -2 on Diplomacy checks to influence them.)",
		},
		#endregion

		#region Auspicious Tattoo
		new Trait
		{
			Name = nameof(TraitEnum.AuspiciousTattoo),
			ProperName = "Auspicious Tattoo",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/auspicious-tattoo"),
			Description = "You gain a +1 trait bonus on Will saving throws.)",
		},
		#endregion

		#region Balloon Headed
		new Trait
		{
			Name = nameof(TraitEnum.BalloonHeaded),
			ProperName = "Balloon Headed",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/balloon-headed"),
			Description = "You gain a +1 trait bonus on Perception checks, and Perception is always a class skill for you. Any Escape Artist checks that requires you to squeeze your head through a tight space take a –8 penalty.)",
		},
		#endregion

		#region Beast Bully
		new Trait
		{
			Name = nameof(TraitEnum.BeastBully),
			ProperName = "Beast Bully",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/beast-bully-tiefling"),
			Description = "You can make an Intimidate check instead of a Handle Animal check when trying to handle or push an animal.)",
		},
		#endregion

		#region Bent Body
		new Trait
		{
			Name = nameof(TraitEnum.BentBody),
			ProperName = "Bent Body",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/bent-body-tiefling-beastbrood"),
			Description = "You gain a +2 trait bonus to CMD when resisting grapple attempts.)",
		},
		#endregion

		#region Big Boned
		new Trait
		{
			Name = nameof(TraitEnum.BigBoned),
			ProperName = "Big Boned",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/big-boned-tiefling-hungerseed"),
			Description = "You gain a +1 trait bonus on combat maneuver checks made to overrun opponents, as well as a +1 trait bonus to your CMD against trip attempts.)",
		},
		#endregion

		#region Big Ears
		new Trait
		{
			Name = nameof(TraitEnum.BigEars),
			ProperName = "Big Ears",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/big-ears"),
			Description = "While this might not quite be the case, you gain a +2 bonus on all Perception checks made to hear noises. Additionally, you can hear noises that normally only dogs or other animals can hear, like the sound of a dog whistle.)",
		},
		#endregion

		#region Blade Bravado
		new Trait
		{
			Name = nameof(TraitEnum.BladeBravado),
			ProperName = "Blade Bravado",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/blade-bravado"),
			Description = "When wielding a one-handed weapon and nothing in your off hand, you gain a +1 trait bonus on Acrobatics and Bluff checks.)",
		},
		#endregion

		#region Blessing of Darkness
		new Trait
		{
			Name = nameof(TraitEnum.BlessingofDarkness),
			ProperName = "Blessing of Darkness",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/blessing-of-darkness-tiefling"),
			Description = "Whenever a spellcaster capable of channeling negative energy casts a beneficial spell on you, she acts as if she were one level higher for the purpose of determining that spell’s effects.)",
		},
		#endregion

		#region Blood of Dragons
		new Trait
		{
			Name = nameof(TraitEnum.BloodofDragons),
			ProperName = "Blood of Dragons",
			Category = TraitCategoryEnum.Bloodline,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/blood-of-dragons"),
			Description = "Choose one of the following: gain a +1 trait bonus on Perception checks, gain low-light vision, or gain a +2 trait bonus on saving throws against effects that cause sleep or paralysis.)",
		},
		#endregion

		#region Blood Stalker
		new Trait
		{
			Name = nameof(TraitEnum.BloodStalker),
			ProperName = "Blood Stalker",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/blood-stalker-tiefling-hellspawn"),
			Description = "You gain a +4 trait bonus on Survival checks made to track or follow a trail so long as you have dealt damage to the creature you are hunting within the last week.)",
		},
		#endregion

		#region Bog Scamp
		new Trait
		{
			Name = nameof(TraitEnum.BogScamp),
			ProperName = "Bog Scamp",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/bog-scamp-kobold-black-scaled"),
			Description = "You can swim through a deep bog at up to half your speed as a move action, instead of the normal quarter speed. Failing a swim check while in a deep bog doesn't cause you to go underwater, even if you fail by 5 or more, though such a failure still results in a lack of progress.)",
		},
		#endregion

		#region Born Damned
		new Trait
		{
			Name = nameof(TraitEnum.BornDamned),
			ProperName = "Born Damned",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/born-damned-tiefling"),
			Description = "You gain a +2 trait bonus on saving throws against curses and magical effects that produce curses.)",
		},
		#endregion

		#region Born in the Light
		new Trait
		{
			Name = nameof(TraitEnum.BornintheLight),
			ProperName = "Born in the Light",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/born-in-the-light---dhampir"),
			Description = "You gain a +2 bonus on checks and saves affected by the Endurance feat (this bonus does not stack with the bonus granted by the Endurance feat). When your light sensitivity causes you to become dazzled, you do not take the –1 penalty on sight-based Perception checks.)",
		},
		#endregion

		#region Born to the Water
		new Trait
		{
			Name = nameof(TraitEnum.BorntotheWater),
			ProperName = "Born to the Water",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/born-to-the-water-ijo"),
			Description = "You gain a +1 bonus on Swim checks and only need to make Swim checks once every 2 hours to avoid fatigue, instead of once each hour.)",
		},
		#endregion

		#region Bouncy
		new Trait
		{
			Name = nameof(TraitEnum.Bouncy),
			ProperName = "Bouncy",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/bouncy"),
			Description = "Whenever you take falling damage, the first 1d6 points of lethal damage suffered in the fall are automatically converted to nonlethal damage. You also gain a +2 trait bonus on all Reflex saves made to avoid unexpected falls.)",
		},
		#endregion

		#region Bralani's Step
		new Trait
		{
			Name = nameof(TraitEnum.BralanisStep),
			ProperName = "Bralanis Step",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/bralani-s-step-aasimar--musetouched"),
			Description = "Once per day, you may move an additional 5 feet as part of a move action.)",
		},
		#endregion

		#region Bred for War
		new Trait
		{
			Name = nameof(TraitEnum.BredforWar),
			ProperName = "Bred for War",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/bred-for-war"),
			Description = "You gain a +1 trait bonus on Intimidate checks and a +1 trait bonus on your CMB because of your great size. You must be at least 6 feet tall.)",
		},
		#endregion

		#region Brewmaster
		new Trait
		{
			Name = nameof(TraitEnum.Brewmaster),
			ProperName = "Brewmaster",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/brewmaster"),
			Description = "You gain a +1 trait bonus on Profession (brewer) and Craft (alchemy) checks, but you take a –1 penalty on Diplomacy checks made to change the attitude of dwarves who know that your family has shared brewing secrets with non-dwarves.)",
		},
		#endregion

		#region Brute
		new Trait
		{
			Name = nameof(TraitEnum.Brute),
			ProperName = "Brute",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/brute-half-orc"),
			Description = "You gain a +1 trait bonus on Intimidate checks, and Intimidate is always a class skill for you.)",
		},
		#endregion

		#region Buried Anxiety
		new Trait
		{
			Name = nameof(TraitEnum.BuriedAnxiety),
			ProperName = "Buried Anxiety",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/buried-anxiety-tiefling-spitespawn"),
			Description = "Pick a specific sort of object, color, sound, or similar relatively common phenomena. You gain a +2 trait bonus on saving throws made to resist fear effects except when you can see, hear, smell, or taste that which unnerves you.)",
		},
		#endregion

		#region Burnished Skin
		new Trait
		{
			Name = nameof(TraitEnum.BurnishedSkin),
			ProperName = "Burnished Skin",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/burnished-skin-aasimar--emberkin"),
			Description = "You gain a +2 trait bonus on saving throws made to disbelieve illusions.)",
		},
		#endregion

		#region Carefully Hidden
		new Trait
		{
			Name = nameof(TraitEnum.CarefullyHidden),
			ProperName = "Carefully Hidden",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/carefully-hidden-human"),
			Description = "You gain a +1 trait bonus to Will saves and a +2 trait bonus to saving throws versus divination effects.)",
		},
		#endregion

		#region Carnation Scales
		new Trait
		{
			Name = nameof(TraitEnum.CarnationScales),
			ProperName = "Carnation Scales",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/carnation-scales-kobold"),
			Description = "You gain a +1 bonus on Survival checks, and Survival is always a class skill for you. Most kobolds with carnation scales also have the day raider alternate racial trait.)",
		},
		#endregion

		#region Celestial Tracker
		new Trait
		{
			Name = nameof(TraitEnum.CelestialTracker),
			ProperName = "Celestial Tracker",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/celestial-tracker-aasimar--angelkin"),
			Description = "You gain a +1 trait bonus on Survival checks made to follow tracks. In addition, you treat trails as being up to 24 hours fresher than they actually are when using the Survival skill to follow tracks.)",
		},
		#endregion

		#region Chain Master
		new Trait
		{
			Name = nameof(TraitEnum.ChainMaster),
			ProperName = "Chain Master",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/chain-master-tiefling-shackleborn"),
			Description = "You gain a +2 trait bonus on combat maneuver checks made to trip opponents with a spiked chain or whip.)",
		},
		#endregion

		#region Child of Platinum
		new Trait
		{
			Name = nameof(TraitEnum.ChildofPlatinum),
			ProperName = "Child of Platinum",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/trait-race-child-of-zolurket"),
			Description = "You gain a +1 trait bonus to weapon damage against undead.)",
		},
		#endregion

		#region Clearheaded
		new Trait
		{
			Name = nameof(TraitEnum.Clearheaded),
			ProperName = "Clearheaded",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/clearheaded"),
			Description = "You gain a +1 trait bonus on opposed checks against the Bluff and Disguise skills and a +1 trait bonus on saving throws against illusion effects.)",
		},
		#endregion

		#region Clergy Member
		new Trait
		{
			Name = nameof(TraitEnum.ClergyMember),
			ProperName = "Clergy Member",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/clergy-member-aasimar"),
			Description = "You receive a +1 trait bonus on Diplomacy checks when interacting with ordained members of your religion, and once per week you can request aid from a temple of your faith. The GM has final say in what sort of aid you can reasonably request, but in general you may ask for the casting of a 1st-level spell or for a non-magical item worth 50 gp or less.)",
		},
		#endregion

		#region Cold Fortitude
		new Trait
		{
			Name = nameof(TraitEnum.ColdFortitude),
			ProperName = "Cold Fortitude",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/cold-fortitude-kobold-white-scaled"),
			Description = "You gain a +4 trait bonus on Fortitude saving throws against nonlethal cold damage.)",
		},
		#endregion

		#region Colonial Entitlement
		new Trait
		{
			Name = nameof(TraitEnum.ColonialEntitlement),
			ProperName = "Colonial Entitlement",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/colonial-entitlement-chelish-or-colonial-sargavan"),
			Description = "You gain a +2 trait bonus on Intimidate checks against primitives.)",
		},
		#endregion

		#region Colonial Sympathizer
		new Trait
		{
			Name = nameof(TraitEnum.ColonialSympathizer),
			ProperName = "Colonial Sympathizer",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Jungle,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/colonial-sympathizer-mwangi"),
			Description = "You gain a +1 trait bonus on Bluff and Diplomacy checks involving colonials and others with this trait.)",
		},
		#endregion

		#region Color Thief
		new Trait
		{
			Name = nameof(TraitEnum.ColorThief),
			ProperName = "Color Thief",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/color-thief"),
			Description = "You gain a +2 trait bonus on Stealth checks, providing you wear only light armor or no armor.)",
		},
		#endregion

		#region Creative Manipulator
		new Trait
		{
			Name = nameof(TraitEnum.CreativeManipulator),
			ProperName = "Creative Manipulator",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/creative-manipulator-changeling"),
			Description = "Once per day, you may reroll a Charisma check you just made. You must take the result of the second roll, even if it is worse.)",
		},
		#endregion

		#region Dark Magic Affinity
		new Trait
		{
			Name = nameof(TraitEnum.DarkMagicAffinity),
			ProperName = "Dark Magic Affinity",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/dark-magic-affinity-tiefling"),
			Description = "Whenever you cast a spell with the [evil] descriptor, you act as if you were one level higher for the purpose of determining that spell’s effects.)",
		},
		#endregion

		#region Deadly Rush
		new Trait
		{
			Name = nameof(TraitEnum.DeadlyRush),
			ProperName = "Deadly Rush",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/deadly-rush-tiefling-pitborn"),
			Description = "You gain a +2 trait bonus on critical hit confirmation rolls made as part of a charge.)",
		},
		#endregion

		#region Deathkeeper
		new Trait
		{
			Name = nameof(TraitEnum.Deathkeeper),
			ProperName = "Deathkeeper",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/deathkeeper-human"),
			Description = "You gain a +1 trait bonus on saving throws against the supernatural abilities of undead creatures.)",
		},
		#endregion

		#region Death’s Deputy
		new Trait
		{
			Name = nameof(TraitEnum.DeathsDeputy),
			ProperName = "Death’s Deputy",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/death-s-deputy-tiefling-grimspawn"),
			Description = "You gain a +2 trait bonus on the damage dealt for any attack that would already reduce your target to negative hit points without this trait.)",
		},
		#endregion

		#region Deathtouched
		new Trait
		{
			Name = nameof(TraitEnum.Deathtouched),
			ProperName = "Deathtouched",
			Category = TraitCategoryEnum.Bloodline,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/deathtouched"),
			Description = "You gain either a +1 trait bonus on Fortitude saving throws or a +2 trait bonus on saving throws against mind-affecting effects (your choice).)",
		},
		#endregion

		#region Deep Marker
		new Trait
		{
			Name = nameof(TraitEnum.DeepMarker),
			ProperName = "Deep Marker",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/deep-marker"),
			Description = "You gain a +1 trait bonus on Survival checks, and a +1 trait bonus on saving throws against fear effects.)",
		},
		#endregion

		#region Dilettante Artist
		new Trait
		{
			Name = nameof(TraitEnum.DilettanteArtist),
			ProperName = "Dilettante Artist",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/dilettante-artist-elf"),
			Description = "You gain a +1 trait bonus to one category of Perform checks and a +1 trait bonus to Diplomacy checks. One of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Dog-Sniff-Hate
		new Trait
		{
			Name = nameof(TraitEnum.DogSniffHate),
			ProperName = "Dog-Sniff-Hate",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/dog-sniff-hate"),
			Description = "You gain the scent special quality but only against canine creatures, like dogs or wolves, including monstrous hounds such as hell hounds, yeth hounds, and even werewolves. You gain a +2 trait bonus on attack rolls against dogs you can smell.)",
		},
		#endregion

		#region Dowsing
		new Trait
		{
			Name = nameof(TraitEnum.Dowsing),
			ProperName = "Dowsing",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/dowsing-suli"),
			Description = "You gain a +1 trait bonus on Survival checks. Whenever you succeed at a Survival check to follow tracks in desert terrain, you can always tell how long ago the tracks were made (though supernatural abilities and spells still impede this ability as appropriate).)",
		},
		#endregion

		#region Draconic Echo
		new Trait
		{
			Name = nameof(TraitEnum.DraconicEcho),
			ProperName = "Draconic Echo",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/draconic-echo-kobold-blue-scaled"),
			Description = "You are able to cast ghost sound twice per day as a spell-like ability. The caster level for this effect is equal to your character level. This spell-like ability's save DC is Intelligence-based.)",
		},
		#endregion

		#region Dualborn (Suli)
		new Trait
		{
			Name = nameof(TraitEnum.DualbornSuli),
			ProperName = "Dualborn (Suli)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/dualborn-suli"),
			Description = "You gain racial energy resistance only to the energy types you choose, and not to others. When using your elemental assault ability, you can only sheath your arms in the energy types selected, but you can choose to sheath your primary hand with one of the selected energy types and your off-hand with the other. Attacks made with each hand (or a weapon held in each hand) deal bonus energy damage of the selected type. While wielding a two-handed weapon, half of the bonus energy damage is one energy type and half is the other.)",
		},
		#endregion

		#region Earthsense (Oread)
		new Trait
		{
			Name = nameof(TraitEnum.EarthsenseOread),
			ProperName = "Earthsense (Oread)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/earthsense-oread"),
			Description = "As a swift action, you can gain tremorsense to a range of 60 feet until the beginning of your next turn. You can use this ability once per day at 1st level, plus one additional time per day at 5th level and every 5 levels thereafter, to a maximum of five times per day at 20th level.)",
		},
		#endregion

		#region Elaborate Trapper
		new Trait
		{
			Name = nameof(TraitEnum.ElaborateTrapper),
			ProperName = "Elaborate Trapper",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/elaborate-trapper-kobold-blue-scaled"),
			Description = "When creating a trap, if your Craft (trap) roll exceeds the DC of the check by 5 or more, that trap's Disable Device DC increases by 2.)",
		},
		#endregion

		#region Elven Reflexes
		new Trait
		{
			Name = nameof(TraitEnum.ElvenReflexes),
			ProperName = "Elven Reflexes",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/elven-reflexes-half-elf"),
			Description = "You gain a +2 trait bonus on Initiative checks.)",
		},
		#endregion

		#region Elven Serenity
		new Trait
		{
			Name = nameof(TraitEnum.ElvenSerenity),
			ProperName = "Elven Serenity",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/elven-serenity-racial-trait-half-elf-raised-by-elves"),
			Description = "You gain a +2 trait bonus on Diplomacy and Handle Animal checks to calm other creatures. You need not speak the same language to attempt a Diplomacy check in this manner.)",
		},
		#endregion

		#region Enlightened Warrior
		new Trait
		{
			Name = nameof(TraitEnum.EnlightenedWarrior),
			ProperName = "Enlightened Warrior",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/enlightened-warrior-aasimar--idyllkin"),
			Description = "You may take levels in monk even while maintaining a neutral or neutral good alignment.)",
		},
		#endregion

		#region Ethical Leader
		new Trait
		{
			Name = nameof(TraitEnum.EthicalLeader),
			ProperName = "Ethical Leader",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/ethical-leader-aasimar"),
			Description = "You gain a +1 trait bonus to your Leadership score if all your cohorts and followers have an alignment within one step of your alignment.)",
		},
		#endregion

		#region Ever Home
		new Trait
		{
			Name = nameof(TraitEnum.EverHome),
			ProperName = "Ever Home",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/ever-home"),
			Description = "You gain a +1 trait bonus on Knowledge (geography) and Sleight of Hand checks.)",
		},
		#endregion

		#region Ever Wary
		new Trait
		{
			Name = nameof(TraitEnum.EverWary),
			ProperName = "Ever Wary",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/ever-wary-tiefling"),
			Description = "During the surprise round and before your first action in combat, you can apply half your Dexterity bonus (if any) to your AC. You still count as flat-footed for the purposes of attacks and effects.)",
		},
		#endregion

		#region Expert Distractor (Ifrit)
		new Trait
		{
			Name = nameof(TraitEnum.ExpertDistractorIfrit),
			ProperName = "Expert Distractor (Ifrit)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/expert-distractor-ifrit"),
			Description = "Whenever you damage an opponent that is casting a spell with a melee attack that deals fire damage (such as a flaming weapon or a torch), the DC of the concentration check for your opponent to cast the spell is equal to 10 + the non-fire damage dealt + double the fire damage dealt + the spell's level (instead of just 10 + the damage dealt + the spell's level).)",
		},
		#endregion

		#region Eyes of the Sun
		new Trait
		{
			Name = nameof(TraitEnum.EyesoftheSun),
			ProperName = "Eyes of the Sun",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/eyes-of-the-sun-human"),
			Description = "You gain a +1 trait bonus on saving throws against effects that would cause you to become dazzled or blinded, and once per day when you would be dazzled or blinded by an effect, you can reduce the duration of that effect by half (minimum 1 round). You cannot use this ability if you are already dazzled or blinded or if you have the light sensitivity or light blindness special quality.)",
		},
		#endregion

		#region Failed Apprentice
		new Trait
		{
			Name = nameof(TraitEnum.FailedApprentice),
			ProperName = "Failed Apprentice",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/failed-apprentice-half-elf"),
			Description = "You gain a +1 trait bonus to saving throws against arcane spells.)",
		},
		#endregion

		#region Faith Healer
		new Trait
		{
			Name = nameof(TraitEnum.FaithHealer),
			ProperName = "Faith Healer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/faith-healer-aasimar"),
			Description = "You can make a Heal check weekly to earn money as though making a Profession check. In addition, you gain a +1 trait bonus on Heal checks.)",
		},
		#endregion

		#region Family Connections
		new Trait
		{
			Name = nameof(TraitEnum.FamilyConnections),
			ProperName = "Family Connections",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/family-connections-tiefling"),
			Description = "You gain a +2 trait bonus on Bluff and Diplomacy checks made against outsiders belonging to the evil subtype.)",
		},
		#endregion

		#region Fanatic
		new Trait
		{
			Name = nameof(TraitEnum.Fanatic),
			ProperName = "Fanatic",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/fanatic-human"),
			Description = "You gain +1 to Knowledge (arcana) and Knowledge (history) checks. One of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Fanatic
		new Trait
		{
			Name = nameof(TraitEnum.Fanatic),
			ProperName = "Fanatic",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/fanatic-human"),
			Description = "You gain a +1 trait bonus to Knowledge (arcana) and Knowledge (history) checks. One of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Fiend Blood
		new Trait
		{
			Name = nameof(TraitEnum.FiendBlood),
			ProperName = "Fiend Blood",
			Category = TraitCategoryEnum.Bloodline,
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/fiend-blood"),
			Description = "Choose one of the following skills: Bluff, Intimidate, or Knowledge (planes). You gain a +1 trait bonus on checks with that skill, and it is always a class skill for you.)",
		},
		#endregion

		#region Fiery Glare
		new Trait
		{
			Name = nameof(TraitEnum.FieryGlare),
			ProperName = "Fiery Glare",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/fiery-glare-ifrit"),
			Description = "You can always take 10 on Intimidate checks, even in combat.)",
		},
		#endregion

		#region Final Embrace
		new Trait
		{
			Name = nameof(TraitEnum.FinalEmbrace),
			ProperName = "Final Embrace",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/final-embrace-dhampir"),
			Description = "You gain a +2 trait bonus on grapple combat maneuver checks to pin an opponent.)",
		},
		#endregion

		#region Finish the Fight
		new Trait
		{
			Name = nameof(TraitEnum.FinishtheFight),
			ProperName = "Finish the Fight",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/finish-the-fight-racial-trait-half-orc-raised-by-orcs"),
			Description = "You gain a +1 trait bonus on attack rolls against opponents you already injured in the past 24 hours.)",
		},
		#endregion

		#region Firebug
		new Trait
		{
			Name = nameof(TraitEnum.Firebug),
			ProperName = "Firebug",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/firebug-kobold-red-scaled"),
			Description = "You are able to cast spark three times per day as a spell-like ability. The caster level is equal to your character level. This spell-like ability's save DC is Intelligence-based.)",
		},
		#endregion

		#region Fire-Tongued
		new Trait
		{
			Name = nameof(TraitEnum.FireTongued),
			ProperName = "Fire-Tongued",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/fire-tongued-kobold-red-scaled"),
			Description = "In addition to speaking Draconic, you begin play with the ability to speak Ignan.)",
		},
		#endregion

		#region Flair for Destruction
		new Trait
		{
			Name = nameof(TraitEnum.FlairforDestruction),
			ProperName = "Flair for Destruction",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/flair-for-destruction-tiefling-pitborn"),
			Description = "You gain a +1 trait bonus on weapon damage rolls made against objects and constructs.)",
		},
		#endregion

		#region Following Breeze
		new Trait
		{
			Name = nameof(TraitEnum.FollowingBreeze),
			ProperName = "Following Breeze",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/following-breeze-sylph"),
			Description = "As long as you get a running start, you gain a +2 trait bonus on Acrobatics checks made to jump. Your speed increases by 5 feet when you use the run action.)",
		},
		#endregion

		#region Forlorn
		new Trait
		{
			Name = nameof(TraitEnum.Forlorn),
			ProperName = "Forlorn",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/forlorn-elf"),
			Description = "You gain a +1 trait bonus on Fortitude saving throws.)",
		},
		#endregion

		#region Foul Belch
		new Trait
		{
			Name = nameof(TraitEnum.FoulBelch),
			ProperName = "Foul Belch",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/foul-belch"),
			Description = "Once per day as a standard action, you can force a particularly odious belch at a single opponent within 5 feet. The character affected must make a DC 12 Fortitude save or be sickened for 1d6 rounds. The save DC is Constitution-based.)",
		},
		#endregion

		#region Freedom Fighter
		new Trait
		{
			Name = nameof(TraitEnum.FreedomFighter),
			ProperName = "Freedom Fighter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/freedom-fighter-halfling"),
			Description = "You gain a +1 trait bonus on any skill check or attack roll made during the process of escaping capture or in helping a slave escape bondage, and Escape Artist is always a class skill for you.)",
		},
		#endregion

		#region Freedom Fighter
		new Trait
		{
			Name = nameof(TraitEnum.FreedomFighter),
			ProperName = "Freedom Fighter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/freedom-fighter-halfling"),
			Description = "You gain a +1 trait bonus on Stealth checks and a +1 trait bonus on attack rolls made during the surprise round.)",
		},
		#endregion

		#region Freed Slave
		new Trait
		{
			Name = nameof(TraitEnum.FreedSlave),
			ProperName = "Freed Slave",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/freed-slave-bellflower-network-halfling"),
			Description = "You gain a +1 trait bonus on Diplomacy and Knowledge (nobility) checks and Knowledge (nobility) is always a class skill for you.)",
		},
		#endregion

		#region Friendless
		new Trait
		{
			Name = nameof(TraitEnum.Friendless),
			ProperName = "Friendless",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/friendless-tiefling"),
			Description = "You can make Heal checks on yourself for the purposes of treating deadly wounds, diseases, and poisons.)",
		},
		#endregion

		#region Frost Spitter
		new Trait
		{
			Name = nameof(TraitEnum.FrostSpitter),
			ProperName = "Frost Spitter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/frost-spitter-kobold-white-scaled"),
			Description = "Once per day, you can quickly exhale to produce a frigid cloud of dense fog that quickly sinks to the ground. This freezing mist covers a 10-foot-square area with slippery ice that's as difficult to traverse as an ice sheet.)",
		},
		#endregion

		#region Genie Blood
		new Trait
		{
			Name = nameof(TraitEnum.GenieBlood),
			ProperName = "Genie Blood",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/trait-race-human-genie-blood"),
			Description = "Select an element (air, earth, fire, or water). You gain a +1 trait bonus on saving throws against attacks that utilize that element (cold for air, acid for earth, fire for fire, and electricity for water), and gain a +1 trait bonus on Bluff, Diplomacy, Intimidate, and Sense Motive checks made against creatures of that subtype.)",
		},
		#endregion

		#region Glib Barrister
		new Trait
		{
			Name = nameof(TraitEnum.GlibBarrister),
			ProperName = "Glib Barrister",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/glib-barrister-chelaxian"),
			Description = "You gain a +2 trait bonus on Linguistics checks to create forgeries.)",
		},
		#endregion

		#region Goblin Foolhardiness
		new Trait
		{
			Name = nameof(TraitEnum.GoblinFoolhardiness),
			ProperName = "Goblin Foolhardiness",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/goblin-foolhardiness"),
			Description = "When facing an enemy that’s larger than you are, if you have no allies in any adjacent squares, your posturing, bravado, and cussing grant you a +1 trait bonus on attack rolls with non-reach melee weapons.)",
		},
		#endregion

		#region God Scorn
		new Trait
		{
			Name = nameof(TraitEnum.GodScorn),
			ProperName = "God Scorn",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/god-scorn-tiefling-foulspawn"),
			Description = "You gain a +1 trait bonus on saving throws against divine spells.)",
		},
		#endregion

		#region Golden Scales
		new Trait
		{
			Name = nameof(TraitEnum.GoldenScales),
			ProperName = "Golden Scales",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/golden-scales-kobold"),
			Description = "You take a –1 penalty on Bluff checks and Diplomacy checks when dealing with other kobolds, but a +2 bonus on Bluff checks and Diplomacy checks when dealing with non-reptilian humanoids.)",
		},
		#endregion

		#region Goldsniffer
		new Trait
		{
			Name = nameof(TraitEnum.Goldsniffer),
			ProperName = "Goldsniffer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/goldsniffer"),
			Description = "You gain a +2 trait bonus on Perception checks related to metals, jewels, and gemstones.)",
		},
		#endregion

		#region Good Influence
		new Trait
		{
			Name = nameof(TraitEnum.GoodInfluence),
			ProperName = "Good Influence",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/good-influence-aasimar--lawbringers"),
			Description = "You gain a +1 trait bonus on Diplomacy checks when attempting to persuade a nongood creature to make a decision that benefits the cause of good, and when persuading a nonlawful creature to make a decision in line with the laws of the region. These bonuses stack if you attempt to persuade a nongood, nonlawful creature to take a lawful good action.)",
		},
		#endregion

		#region Grounded
		new Trait
		{
			Name = nameof(TraitEnum.Grounded),
			ProperName = "Grounded",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/grounded"),
			Description = "You gain a +2 trait bonus on balance-related Acrobatics checks, and a +1 trait bonus on Reflex saving throws.)",
		},
		#endregion

		#region Half-Forgotten Secrets
		new Trait
		{
			Name = nameof(TraitEnum.HalfForgottenSecrets),
			ProperName = "Half-Forgotten Secrets",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/half-forgotten-secrets-dhampir---ajibachanas"),
			Description = "You gain a +1 trait bonus on checks with two Knowledge skills of your choice, and one of these skills becomes a class skill.)",
		},
		#endregion

		#region Harrow Born
		new Trait
		{
			Name = nameof(TraitEnum.HarrowBorn),
			ProperName = "Harrow Born",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/harrow-born-varisian"),
			Description = "You start play with a harrow deck and you gain a +1 trait bonus on initiative checks.)",
		},
		#endregion

		#region Harrow Chosen
		new Trait
		{
			Name = nameof(TraitEnum.HarrowChosen),
			ProperName = "Harrow Chosen",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/harrow-chosen-varisia"),
			Description = "You begin play with a harrow deck. If you use this specific harrow deck as an additional focus component when you cast a divination spell, your caster level is treated as being 2 levels higher. Additionally, twice per week, you can spend 10 minutes consulting this harrow deck on a particular action to gain the effects of the spell augury as a spellcaster of your character level. No one other than you gains these benefits from this harrow deck. If your harrow deck is destroyed, it cannot be replaced. However, by returning to your family, paying 300 gp on materials, and spending 1 week immersed in the songs and stories of your people, you can create a new harrow deck that grants half the benefits of the lost heirloom.)",
		},
		#endregion

		#region Heat Fortitude
		new Trait
		{
			Name = nameof(TraitEnum.HeatFortitude),
			ProperName = "Heat Fortitude",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/heat-fortitude-kobold-red-scaled"),
			Description = "You gain a +4 trait bonus on Fortitude saving throws against nonlethal damage from heat.)",
		},
		#endregion

		#region Helpful
		new Trait
		{
			Name = nameof(TraitEnum.Helpful),
			ProperName = "Helpful",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/helpful"),
			Description = "Whenever you successfully perform an aid another action, you grant your ally a +4 bonus instead of the normal +2.)",
		},
		#endregion

		#region Historian
		new Trait
		{
			Name = nameof(TraitEnum.Historian),
			ProperName = "Historian",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/historian-human"),
			Description = "You gain a +1 trait bonus on Knowledge (history) checks and bardic knowledge checks, and Knowledge (history) is always a class skill for you.)",
		},
		#endregion

		#region Horse Lord
		new Trait
		{
			Name = nameof(TraitEnum.HorseLord),
			ProperName = "Horse Lord",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/horse-lord-keleshite"),
			Description = "You gain a +2 trait bonus on Handle Animal checks, and a +1 trait bonus on Ride checks. This trait applies only to horses.)",
		},
		#endregion

		#region Ice Walker
		new Trait
		{
			Name = nameof(TraitEnum.IceWalker),
			ProperName = "Ice Walker",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/ice-walker-kellid"),
			Description = "You gain a +1 trait bonus on saving throws against attacks that deal cold damage. Furthermore, you may ignore the Acrobatics penalty for ice and can move across ice at normal speed.)",
		},
		#endregion

		#region Icy Mementos
		new Trait
		{
			Name = nameof(TraitEnum.IcyMementos),
			ProperName = "Icy Mementos",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/icy-mementos-kobold-white-scaled"),
			Description = "You begin play with three bottles of liquid ice. These don't count against your starting character wealth.)",
		},
		#endregion

		#region Inciter
		new Trait
		{
			Name = nameof(TraitEnum.Inciter),
			ProperName = "Inciter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/inciter-tiefling"),
			Description = "You gain a +2 trait bonus on Bluff checks made to convince creatures to attack each other.)",
		},
		#endregion

		#region Infernal Influence
		new Trait
		{
			Name = nameof(TraitEnum.InfernalInfluence),
			ProperName = "Infernal Influence",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/infernal-influence-human"),
			Description = "You gain fire resistance 1 and a +1 trait bonus on Fortitude saving throws against poison.)",
		},
		#endregion

		#region Inheritor
		new Trait
		{
			Name = nameof(TraitEnum.Inheritor),
			ProperName = "Inheritor",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/inheritor-gillman"),
			Description = "Whenever you use the aid another action to aid an adjacent ally, increase the bonus you grant your ally by 1. This is a trait bonus.)",
		},
		#endregion

		#region Inheritor
		new Trait
		{
			Name = nameof(TraitEnum.Inheritor),
			ProperName = "Inheritor",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/azlanti-inheritor-azlanti"),
			Description = "You gain a +1 trait bonus on Knowledge (history) checks and a +2 trait bonus on Appraise checks related to objects of ancient origin or made to identify ioun stones.)",
		},
		#endregion

		#region Innocent
		new Trait
		{
			Name = nameof(TraitEnum.Innocent),
			ProperName = "Innocent",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/innocent-aasimar"),
			Description = "When you make a Bluff check to tell a lie, your target always wants to believe you, granting you the standard +5 bonus on your Bluff check. This bonus only applies if the lie you tell is either believable or unlikely.)",
		},
		#endregion

		#region Instant Friendship (Suli)
		new Trait
		{
			Name = nameof(TraitEnum.InstantFriendshipSuli),
			ProperName = "Instant Friendship (Suli)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/instant-friendship-suli"),
			Description = "Once per day, you can treat an Intimidate roll to improve a creature's attitude toward you as if you had used Diplomacy instead. You must use this ability after making the check but before the GM has revealed the result. If you continue threatening the target after making the check, the check automatically fails.)",
		},
		#endregion

		#region Iron Control
		new Trait
		{
			Name = nameof(TraitEnum.IronControl),
			ProperName = "Iron Control",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/iron-control-racial-trait-half-orc-raised-by-humans"),
			Description = "Whenever you're confused and roll to determine behavior in a given round, subtract 10 from the result.)",
		},
		#endregion

		#region Keeper of the Ancestral Scrolls
		new Trait
		{
			Name = nameof(TraitEnum.KeeperoftheAncestralScrolls),
			ProperName = "Keeper of the Ancestral Scrolls",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/keeper-of-the-ancestral-scrolls-tian"),
			Description = "You gain a +1 trait bonus on Knowledge (history), and Knowledge (nobility) checks, and one of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Kobold Faith
		new Trait
		{
			Name = nameof(TraitEnum.KoboldFaith),
			ProperName = "Kobold Faith",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/kobold-faith-kobold"),
			Description = "You gain a +2 trait bonus on Diplomacy checks when dealing with other kobolds. Additionally, if your deity grants the Artifice, Earth, or Trickery domain, then your kobold faith unlocks a corresponding subdomain: Trap, Radiation, or Ambush.)",
		},
		#endregion

		#region Kobold Herbalist
		new Trait
		{
			Name = nameof(TraitEnum.KoboldHerbalist),
			ProperName = "Kobold Herbalist",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/kobold-herbalist-kobold-green-scaled"),
			Description = "Once per day, you can attempt a DC 20 Survival check instead of a Craft (alchemy) check to create a single dose of scent cloak without paying any cost for raw materials. Any scent cloak created using this method must be used within 24 hours, or it becomes inert.)",
		},
		#endregion

		#region Lantern Spirit
		new Trait
		{
			Name = nameof(TraitEnum.LanternSpirit),
			ProperName = "Lantern Spirit",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/lantern-spirit-aasimar--lawbringers"),
			Description = "You feel a strange sense of nostalgia whenever you use your continual flame spell-like ability, and can use it as a move action instead of a standard action.)",
		},
		#endregion

		#region Latent Psion
		new Trait
		{
			Name = nameof(TraitEnum.LatentPsion),
			ProperName = "Latent Psion",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/latent-psion-human"),
			Description = "You gain a +2 trait bonus on saving throws against mind-affecting effects.)",
		},
		#endregion

		#region Legacy of Sand
		new Trait
		{
			Name = nameof(TraitEnum.LegacyofSand),
			ProperName = "Legacy of Sand",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/legacy-of-sand-half-orc"),
			Description = "You gain a +1 trait bonus on all Will saving throws.)",
		},
		#endregion

		#region Lettered
		new Trait
		{
			Name = nameof(TraitEnum.Lettered),
			ProperName = "Lettered",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/lettered"),
			Description = "Linguistics is always a class skill for you, and you gain a +1 trait bonus on Linguistics checks made for the purpose of deciphering writing in an unfamiliar language. You never draw a false conclusion if you fail your Linguistics check; instead, you simply realize you cannot make sense of the writing.)",
		},
		#endregion

		#region Lightning-Blessed
		new Trait
		{
			Name = nameof(TraitEnum.LightningBlessed),
			ProperName = "Lightning-Blessed",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/lightning-blessed-kobold-blue-scaled"),
			Description = "You begin play with three vials of bottled lighting. These don't count against your starting character wealth.)",
		},
		#endregion

		#region Lillend's Harp
		new Trait
		{
			Name = nameof(TraitEnum.LillendsHarp),
			ProperName = "Lillends Harp",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/lillend-s-harp-aasimar--musetouched"),
			Description = "You gain a +1 trait bonus on Perform (string) checks. This bonus increases to +2 when you make a Perform check as part of a bardic performance.)",
		},
		#endregion

		#region Linguistic Genius
		new Trait
		{
			Name = nameof(TraitEnum.LinguisticGenius),
			ProperName = "Linguistic Genius",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/linguistic-genius-dhampir---ru-shi"),
			Description = "You gain a +1 trait bonus on Linguistics checks, and learn to speak and read one additional language from your list of racial languages. Linguistics is always a class skill for you.)",
		},
		#endregion

		#region Liquid-Tongued
		new Trait
		{
			Name = nameof(TraitEnum.LiquidTongued),
			ProperName = "Liquid-Tongued",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/liquid-tongued-kobold-blue-scaled"),
			Description = "In addition to speaking Draconic, you begin play with the ability to speak Aquan.)",
		},
		#endregion

		#region Marid's Fury (Undine)
		new Trait
		{
			Name = nameof(TraitEnum.MaridsFuryUndine),
			ProperName = "Marids Fury (Undine)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/marid-s-fury-undine"),
			Description = "When you use your hydraulic push spell-like ability, it can extinguish magical fires as well as non-magical fires as long as you succeed at an opposed caster level check (the DC is equal to 11 + the magical fire's caster level).)",
		},
		#endregion

		#region Market Rat
		new Trait
		{
			Name = nameof(TraitEnum.MarketRat),
			ProperName = "Market Rat",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/market-rat-keleshite"),
			Description = "You gain a +1 trait bonus on Appraise and Knowledge (local) checks.)",
		},
		#endregion

		#region Martyr's Blood
		new Trait
		{
			Name = nameof(TraitEnum.MartyrsBlood),
			ProperName = "Martyrs Blood",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/martyr-s-blood-aasimar"),
			Description = "As long as your current hit point total is less than half of your maximum hit points possible, you gain a +1 trait bonus on attack rolls against evil foes.)",
		},
		#endregion

		#region Masterful Demeanor
		new Trait
		{
			Name = nameof(TraitEnum.MasterfulDemeanor),
			ProperName = "Masterful Demeanor",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/masterful-demeanor-human"),
			Description = "You gain a +3 trait bonus on Intimidate checks against members of non-human humanoid races.)",
		},
		#endregion

		#region Master of the Sudden Strike
		new Trait
		{
			Name = nameof(TraitEnum.MasteroftheSuddenStrike),
			ProperName = "Master of the Sudden Strike",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/master-of-the-sudden-strike-tian"),
			Description = "When you wield a masterwork version of any sword if you act before your opponent during the surprise round, you gain a +2 trait bonus on weapon damage rolls for the surprise round only. This additional damage is precision damage.)",
		},
		#endregion

		#region Militant Merchant
		new Trait
		{
			Name = nameof(TraitEnum.MilitantMerchant),
			ProperName = "Militant Merchant",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/militant-merchant-dwarf"),
			Description = "You gain a +1 trait bonus to Perception checks made to determine surprise, and Perception is always a class skill for you.)",
		},
		#endregion

		#region Mind Trapper
		new Trait
		{
			Name = nameof(TraitEnum.MindTrapper),
			ProperName = "Mind Trapper",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/mind-trapper-dhampir---svetocher"),
			Description = "You gain a +2 trait bonus on Charisma checks to convince an ally enchanted by one of your charm spells (such as charm person or charm monster) to do things it wouldn't normally do.)",
		},
		#endregion

		#region Motherless
		new Trait
		{
			Name = nameof(TraitEnum.Motherless),
			ProperName = "Motherless",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/motherless-tiefling"),
			Description = "You gain a +2 trait bonus on Bluff and Disguise checks made for the purpose of making you seem injured, sickly, or weak in some other way.)",
		},
		#endregion

		#region Nomadic
		new Trait
		{
			Name = nameof(TraitEnum.Nomadic),
			ProperName = "Nomadic",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/nomadic-bas-o"),
			Description = "You gain a +1 trait bonus on Knowledge (geography) and Survival checks, and one of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Numerological Gift
		new Trait
		{
			Name = nameof(TraitEnum.NumerologicalGift),
			ProperName = "Numerological Gift",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/numerological-gift-dhampir---ru-shi"),
			Description = "When you select this trait, roll 3d6. The resulting number becomes your numerological totem and can never be changed. Once per day, when you roll your totem number on a d20 (such as an attack roll, save, or skill check), you may treat that roll as if you had rolled a natural 20 on the die.)",
		},
		#endregion

		#region Old Before Your Time
		new Trait
		{
			Name = nameof(TraitEnum.OldBeforeYourTime),
			ProperName = "Old Before Your Time",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/old-before-your-time-dhampir---ancient-born"),
			Description = "Any creature trying to discern your true age must make a Perception or Sense Motive check opposed by your Bluff check; you gain a +5 trait bonus on This check. You gain a +2 trait bonus on Disguise checks if your disguise makes you look at least one age category older, and ignore the check penalty for disguising yourself as a different age category while doing so.)",
		},
		#endregion

		#region Ooze Defense
		new Trait
		{
			Name = nameof(TraitEnum.OozeDefense),
			ProperName = "Ooze Defense",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/ooze-defense-kobold-black-scaled"),
			Description = "You begin play with three alkali flasks. These don't count against your starting character wealth.)",
		},
		#endregion

		#region Open Hand and Mind
		new Trait
		{
			Name = nameof(TraitEnum.OpenHandandMind),
			ProperName = "Open Hand and Mind",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/open-hand-and-mind"),
			Description = "You gain a +1 trait bonus on Acrobatics and Knowledge (religion) checks. If you have a ki pool, once per day as a swift action, you may channel your ki during an unarmed strike, gaining a +2 trait bonus on one damage roll. This additional damage is precision damage.)",
		},
		#endregion

		#region Operatic
		new Trait
		{
			Name = nameof(TraitEnum.Operatic),
			ProperName = "Operatic",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/operatic-chelaxian"),
			Description = "You gain a +1 trait bonus on Perform (sing) checks. Furthermore you have memorized the works of many sung in an ancient tongue (choose an ancient language), granting you a +2 trait bonus on Linguistics checks when trying to decipher the chosen language.)",
		},
		#endregion

		#region Outcast
		new Trait
		{
			Name = nameof(TraitEnum.Outcast),
			ProperName = "Outcast",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/outcast"),
			Description = "You gain a +1 trait bonus on Survival skill checks, and Survival is always a class skill for you.)",
		},
		#endregion

		#region Pain Artist
		new Trait
		{
			Name = nameof(TraitEnum.PainArtist),
			ProperName = "Pain Artist",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/pain-artist-tiefling-shackleborn"),
			Description = "You gain a +2 trait bonus on Intimidate checks made against helpless creatures.)",
		},
		#endregion

		#region Pearl Diver
		new Trait
		{
			Name = nameof(TraitEnum.PearlDiver),
			ProperName = "Pearl Diver",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/pearl-diver-half-elf"),
			Description = "You gain a +2 trait bonus on Perception checks while underwater and can hold your breath for a number of rounds equal to three times your Constitution score before you risk drowning.)",
		},
		#endregion

		#region Perfect Servant
		new Trait
		{
			Name = nameof(TraitEnum.PerfectServant),
			ProperName = "Perfect Servant",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/perfect-servant"),
			Description = "You gain a +3 trait bonus on Diplomacy checks made to influence anyone with at least one level of Aristocrat.)",
		},
		#endregion

		#region Persuasive
		new Trait
		{
			Name = nameof(TraitEnum.Persuasive),
			ProperName = "Persuasive",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on Diplomacy checks. This bonus increases to +3 against creatures with the elf subtype.)",
		},
		#endregion

		#region Planar Negotiator
		new Trait
		{
			Name = nameof(TraitEnum.PlanarNegotiator),
			ProperName = "Planar Negotiator",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/planar-negotiator-aasimar"),
			Description = "Whenever you cast lesser planar ally, planar ally, or greater planar ally, you receive a 10% discount on the monetary cost required by the summoned outsiders. This bonus has no effect on services the outsiders may demand in order to strike a bargain.)",
		},
		#endregion

		#region Planetar's Visions
		new Trait
		{
			Name = nameof(TraitEnum.PlanetarsVisions),
			ProperName = "Planetars Visions",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/planetar-s-visions-aasimar--angelkin"),
			Description = "Whenever you succeed at a critical hit with a melee weapon against an evil outsider, you ignore an amount of the outsider's damage reduction (if any) equal to the critical multiplier of your weapon (this cannot reduce a creature's damage reduction to below 0).)",
		},
		#endregion

		#region Practiced Impression
		new Trait
		{
			Name = nameof(TraitEnum.PracticedImpression),
			ProperName = "Practiced Impression",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/practiced-impression-suli"),
			Description = "You gain a +2 trait bonus on Diplomacy checks made against NPCs whom you have known for less than 1 hour.)",
		},
		#endregion

		#region Prayer Breaker
		new Trait
		{
			Name = nameof(TraitEnum.PrayerBreaker),
			ProperName = "Prayer Breaker",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/prayer-breaker-tiefling-faultspawn"),
			Description = "If a divine spellcaster makes a concentration check to avoid losing a spell because of an injury you caused, increase the DC of that check by +2.)",
		},
		#endregion

		#region Prideful Temper
		new Trait
		{
			Name = nameof(TraitEnum.PridefulTemper),
			ProperName = "Prideful Temper",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/prideful-temper-tiefling"),
			Description = "You gain a +1 trait bonus on attack rolls made against creatures that have insulted you until you actually succeed in dealing damage.)",
		},
		#endregion

		#region Pride of the Diamond Empire
		new Trait
		{
			Name = nameof(TraitEnum.PrideoftheDiamondEmpire),
			ProperName = "Pride of the Diamond Empire",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/pride-of-the-diamond-empire-human"),
			Description = "If you succeed at a Will saving throw against a fear effect that would result in a lesser effect on a successful save (such as causing you to become shaken instead of panicked), you are instead unaffected.)",
		},
		#endregion

		#region Prolong Magic
		new Trait
		{
			Name = nameof(TraitEnum.ProlongMagic),
			ProperName = "Prolong Magic",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/prolong-magic-tiefling"),
			Description = "Whenever you use a spell-like ability gained through your tiefling heritage, it automatically acts as if affected by the Extend Spell metamagic feat.)",
		},
		#endregion

		#region Proud Tribesman
		new Trait
		{
			Name = nameof(TraitEnum.ProudTribesman),
			ProperName = "Proud Tribesman",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Jungle,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/proud-tribesman-mwangi"),
			Description = "You gain a +2 bonus on checks to Intimidate colonialists.)",
		},
		#endregion

		#region Providential Passenger
		new Trait
		{
			Name = nameof(TraitEnum.ProvidentialPassenger),
			ProperName = "Providential Passenger",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/providential-passenger"),
			Description = "Improve the starting attitude that ship captains, caravan leaders, and those with similar sorts of responsibilities have toward you by one step.)",
		},
		#endregion

		#region Purple Scales
		new Trait
		{
			Name = nameof(TraitEnum.PurpleScales),
			ProperName = "Purple Scales",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/purple-scales-kobold"),
			Description = "In addition to speaking Draconic, you begin play with the ability to speak one of the following: Aklo, Dwarven, Goblin, or Undercommon.)",
		},
		#endregion

		#region Pustular
		new Trait
		{
			Name = nameof(TraitEnum.Pustular),
			ProperName = "Pustular",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/pustular"),
			Description = "Whenever you’re subjected to an effect that causes the sickened condition, you may make two saving throws to avoid the effect (if a saving throw is allowed), taking the better of the two results as your actual saving throw.)",
		},
		#endregion

		#region Pyromancer
		new Trait
		{
			Name = nameof(TraitEnum.Pyromancer),
			ProperName = "Pyromancer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/pyromancer-aasimar--emberkin"),
			Description = "You gain a +1 trait bonus on damage rolls for any spell you cast with the fire descriptor. Spells that do not deal damage do not benefit from this trait.)",
		},
		#endregion

		#region Rapscallion
		new Trait
		{
			Name = nameof(TraitEnum.Rapscallion),
			ProperName = "Rapscallion",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/rapscallion-gnome"),
			Description = "You gain a +1 trait bonus to Escape Artist checks and a +1 trait bonus to initiative checks.)",
		},
		#endregion

		#region Relic Hunter
		new Trait
		{
			Name = nameof(TraitEnum.RelicHunter),
			ProperName = "Relic Hunter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/relic-hunter-human"),
			Description = "You gain a +1 trait bonus on Appraise and Knowledge (history) checks made to examine ruined buildings more than 1,000 years old as well as any ruined objects found in them. If such an item is magical, you gain a +1 trait bonus on Spellcraft checks to identify its properties and Use Magical Device checks to activate it.)",
		},
		#endregion

		#region Repel Sin
		new Trait
		{
			Name = nameof(TraitEnum.RepelSin),
			ProperName = "Repel Sin",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/repel-sin-tiefling-motherless"),
			Description = "You gain a +2 trait bonus on saving throws made against spells and effects with the [evil] descriptor.)",
		},
		#endregion

		#region Repulsive
		new Trait
		{
			Name = nameof(TraitEnum.Repulsive),
			ProperName = "Repulsive",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/repulsive-tiefling-foulspawn"),
			Description = "You gain a +1 trait bonus on combat maneuver checks made to overrun and reposition opponents.)",
		},
		#endregion

		#region Rude Songs
		new Trait
		{
			Name = nameof(TraitEnum.RudeSongs),
			ProperName = "Rude Songs",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/rude-songs"),
			Description = "Providing an opponent can hear and understand you, you gain a +2 trait bonus on all Perform (song) checks. Perform is always a class skill for you.)",
		},
		#endregion

		#region Ruthless
		new Trait
		{
			Name = nameof(TraitEnum.Ruthless),
			ProperName = "Ruthless",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/ruthless"),
			Description = "You gain a +1 trait bonus on attack rolls to confirm critical hits.)",
		},
		#endregion

		#region Sandy Ambush
		new Trait
		{
			Name = nameof(TraitEnum.SandyAmbush),
			ProperName = "Sandy Ambush",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/sandy-ambush-oread"),
			Description = "When prone in desert terrain, you gain a +2 trait bonus on Stealth checks and take only a –2 penalty on attack rolls (rather than –4) when attacking from prone.)",
		},
		#endregion

		#region Scholar of Ruins
		new Trait
		{
			Name = nameof(TraitEnum.ScholarofRuins),
			ProperName = "Scholar of Ruins",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/scholar-of-ruins-human"),
			Description = "You gain a +1 trait bonus to Knowledge (geography) and Knowledge (dungeoneering) checks. One of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Scrapper
		new Trait
		{
			Name = nameof(TraitEnum.Scrapper),
			ProperName = "Scrapper",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/scrapper"),
			Description = "You receive a +1 trait bonus on all Intimidate checks made to demoralize opponents and a +1 trait bonus on all Perception checks to avoid being surprised.)",
		},
		#endregion

		#region Scrounger
		new Trait
		{
			Name = nameof(TraitEnum.Scrounger),
			ProperName = "Scrounger",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/scrounger"),
			Description = "You can buy objects with the broken condition at half price (instead of the normal three-quarters price). The value of the unbroken version of these objects cannot exceed four times your character level. The price you pay for this object can never exceed more than twice your character level in gp (for example, at 5th level you can spend up to 10 gp on a broken object, meaning you can buy any object that, if not broken, has a value of 20 gp or less).)",
		},
		#endregion

		#region Seeker of Brightness
		new Trait
		{
			Name = nameof(TraitEnum.SeekerofBrightness),
			ProperName = "Seeker of Brightness",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/seeker-of-brightness"),
			Description = "Choose a Knowledge skill; you gain a +1 trait bonus on Knowledge checks of that type and on Perception checks.)",
		},
		#endregion

		#region Selective Health
		new Trait
		{
			Name = nameof(TraitEnum.SelectiveHealth),
			ProperName = "Selective Health",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/selective-health-aasimar"),
			Description = "You gain a +2 trait bonus on Fortitude saving throws against diseases. However, whenever you must make a Fortitude saving throw against a disease inflicted by an undead creature or evil outsider (such as mummy rot or a vrock's spores), you do not gain this bonus, and instead take a –2 penalty on your Fortitude save.)",
		},
		#endregion

		#region Sensual Graces
		new Trait
		{
			Name = nameof(TraitEnum.SensualGraces),
			ProperName = "Sensual Graces",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/sensual-graces-dhampir---svetocher"),
			Description = "You gain a +2 trait bonus on Bluff checks made against humanoids who would be attracted to you.)",
		},
		#endregion

		#region Shadow Stabber
		new Trait
		{
			Name = nameof(TraitEnum.ShadowStabber),
			ProperName = "Shadow Stabber",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/shadow-stabber-tiefling"),
			Description = "You gain a +2 trait bonus on melee weapon damage rolls made against foes that cannot see you.)",
		},
		#endregion

		#region Shield Bearer
		new Trait
		{
			Name = nameof(TraitEnum.ShieldBearer),
			ProperName = "Shield Bearer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/shield-bearer"),
			Description = "When performing a shield bash, you deal 1 additional point of damage. Also, once per day on your turn as a free action, you may provide one adjacent ally a +2 trait bonus to his Armor Class. This bonus lasts for 1 round, so long as you and the target remain adjacent to one another. You can only use this ability if you are using a shield. You retain your shield bonus to your armor class when using this ability.)",
		},
		#endregion

		#region Shift the Blame
		new Trait
		{
			Name = nameof(TraitEnum.ShifttheBlame),
			ProperName = "Shift the Blame",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/shift-the-blame-tiefling-spitespawn"),
			Description = "You gain a +1 trait bonus on Bluff and Diplomacy checks made to convince someone that another person is actually at fault for your actions.)",
		},
		#endregion

		#region Skater's Balance
		new Trait
		{
			Name = nameof(TraitEnum.SkatersBalance),
			ProperName = "Skaters Balance",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/skater-s-balance-kobold-white-scaled"),
			Description = "You don't need to spend extra movement to enter a square of an ice sheet, and the DCs of your Acrobatics checks on ice sheets don't increase by 5.)",
		},
		#endregion

		#region Slaver
		new Trait
		{
			Name = nameof(TraitEnum.Slaver),
			ProperName = "Slaver",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/slaver-ombo"),
			Description = "You gain a +2 trait bonus on Intimidate checks to influence primitives, but you suffer a -2 penalty on Bluff or Diplomacy checks to influence them.)",
		},
		#endregion

		#region Slave Smuggler
		new Trait
		{
			Name = nameof(TraitEnum.SlaveSmuggler),
			ProperName = "Slave Smuggler",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/slave-smuggler-halfling"),
			Description = "When hiding a Medium or smaller creature from an opponent actively searching you or your cargo, both you and the creature to be smuggled can attempt Stealth checks and select the higher of the two results for your smuggled ally to use while hiding.)",
		},
		#endregion

		#region Slippery Step
		new Trait
		{
			Name = nameof(TraitEnum.SlipperyStep),
			ProperName = "Slippery Step",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/slippery-step-undine"),
			Description = "You are always considered to have firm footing when fighting underwater, and you gain a +2 trait bonus on Acrobatics checks and Climb checks on wet surfaces or in wet terrain, including bogs, standing or running water, or a storm-tossed ship.)",
		},
		#endregion

		#region Slithering Stride
		new Trait
		{
			Name = nameof(TraitEnum.SlitheringStride),
			ProperName = "Slithering Stride",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/slithering-stride-kobold-green-scaled"),
			Description = "For 3 rounds per day, you can move through light or heavy undergrowth at full speed. This ability doesn't work in terrain that has been magically manipulated to impede motion.)",
		},
		#endregion

		#region Smoke Resistant
		new Trait
		{
			Name = nameof(TraitEnum.SmokeResistant),
			ProperName = "Smoke Resistant",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/smoke-resistant-kobold-red-scaled"),
			Description = "Your vision isn't impaired by non-magical smoke, and you gain a +5 trait bonus on Fortitude saves to avoid coughing and choking because of smoke inhalation. This trait confers no benefits against magically created smoke, such as that produced by pyrotechnics.)",
		},
		#endregion

		#region Snake Hater
		new Trait
		{
			Name = nameof(TraitEnum.SnakeHater),
			ProperName = "Snake Hater",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/snake-hater-aasimar--plumekith"),
			Description = "You gain a +2 trait bonus on Knowledge (dungeoneering) checks and Knowledge (dungeoneering) is always a class skill for you.)",
		},
		#endregion

		#region Snap Ignition
		new Trait
		{
			Name = nameof(TraitEnum.SnapIgnition),
			ProperName = "Snap Ignition",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/snap-ignition-ifrit"),
			Description = "As a full-round action, you can produce a small flame at the end of your finger that ignites combustible materials as a tindertwig. Alternatively, you can maintain a flame equivalent to a candle by spending a standard action each round to concentrate on it.)",
		},
		#endregion

		#region Sneaky Swimmer
		new Trait
		{
			Name = nameof(TraitEnum.SneakySwimmer),
			ProperName = "Sneaky Swimmer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/sneaky-swimmer-kobold-black-scaled"),
			Description = "Increase the number of rounds you can hold your breath underwater by an amount equal to your Constitution score. You gain a +2 bonus on Stealth checks in swamps and in underwater environments.)",
		},
		#endregion

		#region Soul Eater
		new Trait
		{
			Name = nameof(TraitEnum.SoulEater),
			ProperName = "Soul Eater",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/soul-eater-tiefling-grimspawn"),
			Description = "Whenever you use a coup de grace action to kill a creature (either by damage or through a failed Fortitude save), you gain a number of temporary hit points equal to half your character level (minimum 1) for 1 minute. These temporary hit points do not stack with multiple coups de grace.)",
		},
		#endregion

		#region Speech of the Wilds
		new Trait
		{
			Name = nameof(TraitEnum.SpeechoftheWilds),
			ProperName = "Speech of the Wilds",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/speech-of-the-wilds-aasimar--idyllkin"),
			Description = "You can speak one extra language.)",
		},
		#endregion

		#region Sphinxfriend
		new Trait
		{
			Name = nameof(TraitEnum.Sphinxfriend),
			ProperName = "Sphinxfriend",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/sphinxfriend-human"),
			Description = "You gain a +1 trait bonus on Diplomacy checks, Linguistics checks made to decipher writing, and to Sense Motive checks made to discern secret messages.)",
		},
		#endregion

		#region Spirits in the Stone
		new Trait
		{
			Name = nameof(TraitEnum.SpiritsintheStone),
			ProperName = "Spirits in the Stone",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/spirits-in-the-stone-human"),
			Description = "You gain a +2 trait bonus on Initiative checks and a +1 trait bonus on saving throws against traps and natural hazards.)",
		},
		#endregion

		#region Stargazer
		new Trait
		{
			Name = nameof(TraitEnum.Stargazer),
			ProperName = "Stargazer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/stargazer"),
			Description = "You gain a +1 trait bonus on Knowledge (geography) and Survival checks.)",
		},
		#endregion

		#region Statuesque (Oread)
		new Trait
		{
			Name = nameof(TraitEnum.StatuesqueOread),
			ProperName = "Statuesque (Oread)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/statuesque-oread"),
			Description = "Disguise becomes a class skill for you, and you gain a +2 trait bonus on Disguise checks to disguise yourself as a statue made of a specific type of stone, such as marble, sandstone, or alabaster. Furthermore, you take none of the penalties normally associated with disguising yourself as a different type of creature. You must choose the type of stone you resemble when you take this trait; once chosen, it cannot be changed.)",
		},
		#endregion

		#region Stoic Dignity
		new Trait
		{
			Name = nameof(TraitEnum.StoicDignity),
			ProperName = "Stoic Dignity",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/stoic-dignity-oread"),
			Description = "As long as you are conscious, you and all allies within 10 feet gain a +1 bonus on saving throws against mind-affecting effects you are not already suffering from. This is a trait bonus for you and a morale bonus for your allies.)",
		},
		#endregion

		#region Successful Shirker
		new Trait
		{
			Name = nameof(TraitEnum.SuccessfulShirker),
			ProperName = "Successful Shirker",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/successful-shirker-halfling"),
			Description = "You gain a +1 trait bonus on Stealth checks and a +3 trait bonus on Bluff and Diplomacy checks to avoid punishment by lawful authority.)",
		},
		#endregion

		#region Suicidal
		new Trait
		{
			Name = nameof(TraitEnum.Suicidal),
			ProperName = "Suicidal",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/suicidal-tiefling"),
			Description = "Once per day, as an immediate action, you can make yourself the target of any attack originally directed against a creature occupying an adjacent square.)",
		},
		#endregion

		#region Superior Clutch
		new Trait
		{
			Name = nameof(TraitEnum.SuperiorClutch),
			ProperName = "Superior Clutch",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/superior-clutch-tiefling-hungerseed"),
			Description = "You gain a +1 trait bonus on damage rolls when using weapons intended for creatures of a larger size.)",
		},
		#endregion

		#region Superstitious
		new Trait
		{
			Name = nameof(TraitEnum.Superstitious),
			ProperName = "Superstitious",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/superstitious"),
			Description = "You gain a +1 trait bonus on saving throws against arcane spells.)",
		},
		#endregion

		#region Tactile Telekinesis
		new Trait
		{
			Name = nameof(TraitEnum.TactileTelekinesis),
			ProperName = "Tactile Telekinesis",
			TraitType = TraitTypeEnum.Basic,
			Description = "Once per day as a swift action, you can add a trait bonus equal to your Intelligence modifier on Strength checks and Strength-based skill checks you attempt before the beginning of your next turn.)",
		},
		#endregion

		#region Tattooed Mystic
		new Trait
		{
			Name = nameof(TraitEnum.TattooedMystic),
			ProperName = "Tattooed Mystic",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/varisian-tattoo-varisia"),
			Description = "You gain a +1 trait bonus on saving throws against charm and compulsion effects. Additionally, you are proficient with bladed scarves and starknives.)",
		},
		#endregion

		#region Tempter's Tongue
		new Trait
		{
			Name = nameof(TraitEnum.TemptersTongue),
			ProperName = "Tempters Tongue",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/tempter-s-tongue-tiefling"),
			Description = "You gain a +1 trait bonus on Diplomacy checks and on opposed Charisma checks to influence creatures you have charmed (such as with charm person).)",
		},
		#endregion

		#region Thoroughbred
		new Trait
		{
			Name = nameof(TraitEnum.Thoroughbred),
			ProperName = "Thoroughbred",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/thoroughbred-human"),
			Description = "If you gain a horse as an animal companion or mount as one of your class abilities, its base speed increases by 5 feet and it gains a bonus trick that does not count against the normal limit of tricks known by the animal.)",
		},
		#endregion

		#region Thrall Spotter
		new Trait
		{
			Name = nameof(TraitEnum.ThrallSpotter),
			ProperName = "Thrall Spotter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/thrall-spotter-dhampir---ancient-born"),
			Description = "You gain a +5 trait bonus on Sense Motive checks made to determine whether a creature is acting under the effects of a charm or compulsion.)",
		},
		#endregion

		#region Thunderborn (Sylph)
		new Trait
		{
			Name = nameof(TraitEnum.ThunderbornSylph),
			ProperName = "Thunderborn (Sylph)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/thunderborn-sylph"),
			Description = "Once per day when you cast a spell that deals electricity damage, you can choose to make half of the damage electricity damage and the other half sonic damage.)",
		},
		#endregion

		#region Tongue of Many Towns
		new Trait
		{
			Name = nameof(TraitEnum.TongueofManyTowns),
			ProperName = "Tongue of Many Towns",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/tongue-of-many-towns"),
			Description = "You gain a +1 trait bonus on two of the following skills: Diplomacy, Knowledge (local), and Linguistics.)",
		},
		#endregion

		#region Tough Skin
		new Trait
		{
			Name = nameof(TraitEnum.ToughSkin),
			ProperName = "Tough Skin",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/tough-skin-tiefling-beastbrood"),
			Description = "You gain a +1 trait bonus to AC when opponents attempt to confirm critical hits with either bludgeoning or slashing weapons.)",
		},
		#endregion

		#region Toxophilite
		new Trait
		{
			Name = nameof(TraitEnum.Toxophilite),
			ProperName = "Toxophilite",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/toxophilite-aasimar--plumekith"),
			Description = "You gain a +2 trait bonus on attack rolls made to confirm critical hits with bows.)",
		},
		#endregion

		#region Trade Talk
		new Trait
		{
			Name = nameof(TraitEnum.TradeTalk),
			ProperName = "Trade Talk",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/trade-talk-racial-trait-half-elf-raised-by-humans"),
			Description = "You gain a +1 trait bonus on checks with the chosen skill, and a +1 trait bonus on Bluff and Sense Motive checks when dealing with people in the context of that craft or profession.)",
		},
		#endregion

		#region Trailblazer
		new Trait
		{
			Name = nameof(TraitEnum.Trailblazer),
			ProperName = "Trailblazer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/trailblazer"),
			Description = "While traversing any wilderness, you gain a +1 trait bonus on Survival checks, and gain a +1 trait bonus on Fortitude saving throws against diseases.)",
		},
		#endregion

		#region Trifler
		new Trait
		{
			Name = nameof(TraitEnum.Trifler),
			ProperName = "Trifler",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/trifler-varisian-wanderers-varisian-human"),
			Description = "You may cast prestidigitation three times per day as a spell-like ability. This spell-like ability is cast at your highest caster level; if you have no caster level, it functions at CL 1st.)",
		},
		#endregion

		#region Tropical Botanist
		new Trait
		{
			Name = nameof(TraitEnum.TropicalBotanist),
			ProperName = "Tropical Botanist",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/tropical-botanist-elf"),
			Description = "You gain a +1 trait bonus on Knowledge (nature) checks to locate or identify plants and on saving throws against the extraordinary abilities of plants.)",
		},
		#endregion

		#region Tunnel Fighter
		new Trait
		{
			Name = nameof(TraitEnum.TunnelFighter),
			ProperName = "Tunnel Fighter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/tunnel-fighter"),
			Description = "While underground, you receive a +2 trait bonus to initiative checks and a +1 trait bonus on weapon damage rolls for critical hits (this damage is multiplied on a critical hit).)",
		},
		#endregion

		#region Twilight Zeal
		new Trait
		{
			Name = nameof(TraitEnum.TwilightZeal),
			ProperName = "Twilight Zeal",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/twilight-zeal-tiefling"),
			Description = "You gain a +1 trait bonus on Will saving throws when in dim light or darkness.)",
		},
		#endregion

		#region Ugly Swine
		new Trait
		{
			Name = nameof(TraitEnum.UglySwine),
			ProperName = "Ugly Swine",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/ugly-swine"),
			Description = "You gain a +2 trait bonus on Disguise checks, and Disguise is always a class skill for you.)",
		},
		#endregion

		#region Undead Slayer
		new Trait
		{
			Name = nameof(TraitEnum.UndeadSlayer),
			ProperName = "Undead Slayer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/undead-slayer-dhampir"),
			Description = "You gain a +1 trait bonus on attack and damage rolls against undead creatures.)",
		},
		#endregion

		#region Underling
		new Trait
		{
			Name = nameof(TraitEnum.Underling),
			ProperName = "Underling",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/underling-tiefling"),
			Description = "You gain a +2 trait bonus on Bluff and Diplomacy checks made to either join or imply that you already belong to an evil organization.)",
		},
		#endregion

		#region Undine Loyalty
		new Trait
		{
			Name = nameof(TraitEnum.UndineLoyalty),
			ProperName = "Undine Loyalty",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/undine-loyalty-undine"),
			Description = "Choose one teamwork feat that requires an ally with the same feat to be adjacent to you. You may benefit from that teamwork feat as long as you have an ally within 10 feet of you (though your ally does not benefit from the teamwork feat unless it also has this trait or a similar ability).)",
		},
		#endregion

		#region Unearth Secrets
		new Trait
		{
			Name = nameof(TraitEnum.UnearthSecrets),
			ProperName = "Unearth Secrets",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/unearth-secrets-tiefling-hellspawn"),
			Description = "You gain a +2 trait bonus on Sense Motive checks when trying to get a hunch that might reveal a target’s hidden vice, dark impulse, or any other craving it would not want publicly revealed.)",
		},
		#endregion

		#region Unflappable Arrogance (Ifrit)
		new Trait
		{
			Name = nameof(TraitEnum.UnflappableArroganceIfrit),
			ProperName = "Unflappable Arrogance (Ifrit)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/unflappable-arrogance-ifrit"),
			Description = "The DC to demoralize you with the Intimidate skill increases by 5. If an opponent's Intimidate check would be high enough to cause you to become demoralized for more than 1 round, you are instead demoralized for only 1 round.)",
		},
		#endregion

		#region Unidentifiable Appeal
		new Trait
		{
			Name = nameof(TraitEnum.UnidentifiableAppeal),
			ProperName = "Unidentifiable Appeal",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/unidentifiable-appeal-dhampir---ajibachana"),
			Description = "You gain a +1 trait bonus on Disguise checks and a +1 trait bonus on Diplomacy checks made to influence those who would be attracted to you.)",
		},
		#endregion

		#region Vermin Wrangler
		new Trait
		{
			Name = nameof(TraitEnum.VerminWrangler),
			ProperName = "Vermin Wrangler",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/vermin-wrangler-gnome"),
			Description = "You gain a +2 trait bonus on Knowledge (dungeoneering) checks to identify vermin and on saving throws against vermin's extraordinary abilities.)",
		},
		#endregion

		#region Vile Kiss
		new Trait
		{
			Name = nameof(TraitEnum.VileKiss),
			ProperName = "Vile Kiss",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/vile-kiss-tiefling-motherless"),
			Description = "You gain a +2 trait bonus on combat maneuver checks to perform a dirty trick combat maneuver for the purpose of making your opponent sickened.)",
		},
		#endregion

		#region Voice of Velvet
		new Trait
		{
			Name = nameof(TraitEnum.VoiceofVelvet),
			ProperName = "Voice of Velvet",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/voice-of-velvet"),
			Description = "You gain a +1 trait bonus on Diplomacy and Perform (oratory) checks.)",
		},
		#endregion

		#region Warrior of Old
		new Trait
		{
			Name = nameof(TraitEnum.WarriorofOld),
			ProperName = "Warrior of Old",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/warrior-of-old"),
			Description = "You gain a +2 trait bonus on Initiative checks.)",
		},
		#endregion

		#region Warsmith
		new Trait
		{
			Name = nameof(TraitEnum.Warsmith),
			ProperName = "Warsmith",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/warsmith"),
			Description = "You gain a +1 trait bonus to damage rolls against creatures and objects made primarily of clay, crystal, earth, metal, or stone. Knowledge (engineering) is always a class skill for you.)",
		},
		#endregion

		#region Wary
		new Trait
		{
			Name = nameof(TraitEnum.Wary),
			ProperName = "Wary",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/wary-aasimar"),
			Description = "You gain a +1 trait bonus on Disguise and Sense Motive checks.)",
		},
		#endregion

		#region Well-Informed
		new Trait
		{
			Name = nameof(TraitEnum.WellInformed),
			ProperName = "Well-Informed",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/well-informed-halfling"),
			Description = "You gain a +1 trait bonus to Diplomacy checks and Knowledge (local) checks (when attempting to gather Information). One of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Whiteout (Undine)
		new Trait
		{
			Name = nameof(TraitEnum.WhiteoutUndine),
			ProperName = "Whiteout (Undine)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/whiteout-undine"),
			Description = "In areas of non-magical fog, rain, snow, or similar conditions (such as the spray of a waterfall), you gain the effects of concealment, but with a miss chance of 10%. If the precipitation would already grant you concealment, the miss chances stack.)",
		},
		#endregion

		#region Wind-Carried Voices (Sylph)
		new Trait
		{
			Name = nameof(TraitEnum.WindCarriedVoicesSylph),
			ProperName = "Wind-Carried Voices (Sylph)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/wind-carried-voices-sylph"),
			Description = "You gain a +1 trait bonus on Sense Motive  checks to tell when someone is lying to you. Additionally, at will, as long as you are outdoors or in an area where there is noticeable air movement, you can whisper to any creature from up to 30 feet away. You can only designate one person in sight to hear your voice, and nearby creatures can hear these messages with a successful DC 20 Perception check. This is an extraordinary ability that otherwise functions as message.)",
		},
		#endregion

		#region World Traveler
		new Trait
		{
			Name = nameof(TraitEnum.WorldTraveler),
			ProperName = "World Traveler",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/world-traveler-human"),
			Description = "Select one of the following skills: Diplomacy, Knowledge (local), or Sense Motive. You gain a +1 trait bonus to that skill, and it is always a class skill for you.)",
		},
		#endregion

		#region Youthful Mischief
		new Trait
		{
			Name = nameof(TraitEnum.YouthfulMischief),
			ProperName = "Youthful Mischief",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/youthful-mischief"),
			Description = "You gain a +1 trait bonus on Reflex saving throws.)",
		},
		#endregion

		#region Zest for Battle
		new Trait
		{
			Name = nameof(TraitEnum.ZestforBattle),
			ProperName = "Zest for Battle",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/race-traits/zest-for-battle"),
			Description = "Whenever you have a morale bonus to weapon attack rolls, you also receive a +1 trait bonus on weapon damage rolls.)",
		},
		#endregion


		#endregion

		#region Regional

		#region Aballonian Resilience
		new Trait
		{
			Name = nameof(TraitEnum.AballonianResilience),
			ProperName = "Aballonian Resilience",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +4 trait bonus on saves to avoid nonlethal damage from cold environments. In addition, you begin play with a cold-weather outfit at no cost.)",
		},
		#endregion

		#region Aberration Hunter
		new Trait
		{
			Name = nameof(TraitEnum.AberrationHunter),
			ProperName = "Aberration Hunter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/aberration-hunter-shenmen"),
			Description = "You gain a +1 trait bonus on attacks of opportunity against aberrations.)",
		},
		#endregion

		#region Acupuncturist
		new Trait
		{
			Name = nameof(TraitEnum.Acupuncturist),
			ProperName = "Acupuncturist",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/acupuncturist-chu-ye"),
			Description = "You gain a +2 trait bonus on all Fortitude saves made against poison effects.)",
		},
		#endregion

		#region Advocate for the Empire
		new Trait
		{
			Name = nameof(TraitEnum.AdvocatefortheEmpire),
			ProperName = "Advocate for the Empire",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/minkai-advocate-minkai"),
			Description = "You gain a +1 trait bonus on Bluff checks, and Bluff becomes a class skill for you.)",
		},
		#endregion

		#region Agent of the Sultana (Plane of Earth)
		new Trait
		{
			Name = nameof(TraitEnum.AgentoftheSultanaPlaneofEarth),
			ProperName = "Agent of the Sultana (Plane of Earth)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/agent-of-the-sultana-plane-of-earth"),
			Description = "You gain a +2 trait bonus on Disable Device checks to disarm any traps that you know deal f ire damage, and you gain a +2 trait bonus on attack rolls to confirm critical hits against creatures with the fire subtype.)",
		},
		#endregion

		#region Airship Captain (Plane of Air)
		new Trait
		{
			Name = nameof(TraitEnum.AirshipCaptainPlaneofAir),
			ProperName = "Airship Captain (Plane of Air)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/airship-captain-plane-of-air"),
			Description = "You gain a +2 trait bonus on Wisdom checks to move in a plane with subjective directional gravity (see planar rules) and a +2 trait bonus on driving checks (see the vehicle rules).)",
		},
		#endregion

		#region Akitonian Ferocity
		new Trait
		{
			Name = nameof(TraitEnum.AkitonianFerocity),
			ProperName = "Akitonian Ferocity",
			TraitType = TraitTypeEnum.Basic,
			Description = "Once per day, the first time you are brought below 0 hit points but not killed, you can fight on for 1 more round as if disabled. At the end of your next turn, unless brought to above 0 hit points, you immediately fall unconscious and begin dying.)",
		},
		#endregion

		#region Alabaster Odalisque
		new Trait
		{
			Name = nameof(TraitEnum.AlabasterOdalisque),
			ProperName = "Alabaster Odalisque",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/alabaster-odalisque"),
			Description = "You gain a +1 trait bonus on two Charisma-based skills of your choice. In addition, once per day as a swift action, you can brush your fingers against a closed door or stone wall up to 1 foot thick. Doing so allows you to ignore penalties on Perception checks to listen through the designated object for 1 minute.)",
		},
		#endregion

		#region Alchemical Prodigy1
		new Trait
		{
			Name = nameof(TraitEnum.AlchemicalProdigy1),
			ProperName = "Alchemical Prodigy1",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("https://sites.google.com/site/pathfinderogc/traits/regional-traits/alchemical-prodigy"),
			Description = "Choose one 1st-level spell from the bard, cleric, druid, or sorcerer/wizard spell list. If you have the Brew Potion feat, you may create potions of this spell as if it were on your spell list.)",
		},
		#endregion

		#region Alchemical Prodigy2
		new Trait
		{
			Name = nameof(TraitEnum.AlchemicalProdigy2),
			ProperName = "Alchemical Prodigy2",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("https://sites.google.com/site/pathfinderogc/traits/regional-traits/alchemical-prodigy-regional-qadira"),
			Description = "If you have the alchemy class feature, your alchemist level is considered 1 higher when calculating the duration of your extracts.)",
		},
		#endregion

		#region Alchemists Apprentice
		new Trait
		{
			Name = nameof(TraitEnum.AlchemistsApprentice),
			ProperName = "Alchemists Apprentice",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/alchemists-apprentice"),
			Description = "Upon imbibing a potion containing a spell on your formula list of a spell level you are capable of casting, you can attempt a Spellcraft check (DC 15 + extract level). On a success, you can immediately add the spell to your formula book.)",
		},
		#endregion

		#region Altruistic Diplomat
		new Trait
		{
			Name = nameof(TraitEnum.AltruisticDiplomat),
			ProperName = "Altruistic Diplomat",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/altruistic-diplomat-hwanggot"),
			Description = "You gain a +2 trait bonus on Diplomacy checks. You must be Lawful Good, Neutral Good, or Chaotic Good to take this trait.)",
		},
		#endregion

		#region Aquatic Survivalist (Plane of Water)
		new Trait
		{
			Name = nameof(TraitEnum.AquaticSurvivalistPlaneofWater),
			ProperName = "Aquatic Survivalist (Plane of Water)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/aquatic-survivalist-plane-of-water"),
			Description = "You gain a +2 trait bonus on Stealth checks while underwater. Once per day, you can attempt a Stealth check to hide in plain sight (as the ranger class feature of the same name) while underwater. This is only effective against creatures that rely on blindsense, blindsight, or tremorsense. Creatures with other senses perceive you normally.)",
		},
		#endregion

		#region Arcane Dabbler
		new Trait
		{
			Name = nameof(TraitEnum.ArcaneDabbler),
			ProperName = "Arcane Dabbler",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/wealthy-dabbler-regional-taldor"),
			Description = "Select two non-harmful arcane cantrips. You can cast these two cantrips once per day each (caster level 1st). If you have levels in a class that can cast these cantrips, your caster level for these cantrips is equal to that class level.)",
		},
		#endregion

		#region Arcane Graduate
		new Trait
		{
			Name = nameof(TraitEnum.ArcaneGraduate),
			ProperName = "Arcane Graduate",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/quantium-university-graduate-regional-nex"),
			Description = "You gain a +2 trait bonus on concentration checks when casting arcane spells.)",
		},
		#endregion

		#region Archeologist
		new Trait
		{
			Name = nameof(TraitEnum.Archeologist),
			ProperName = "Archeologist",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Jungle,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/osirionologist-regional-osirion"),
			Description = "You gain a +1 trait bonus on Knowledge (engineering) and Knowledge (history) checks, and one of them is always a class skill for you. In addition, you may choose an ancient language as one of your bonus languages.)",
		},
		#endregion

		#region Armor Master
		new Trait
		{
			Name = nameof(TraitEnum.ArmorMaster),
			ProperName = "Armor Master",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/sargavan-guard-regional-sargava"),
			Description = "When you wear armor of any sort, reduce the armor check penalty by 1, to a minimum penalty of 0.)",
		},
		#endregion

		#region Artifact Hunter
		new Trait
		{
			Name = nameof(TraitEnum.ArtifactHunter),
			ProperName = "Artifact Hunter",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Jungle,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/artifact-hunter-regional-mwangi-expanse"),
			Description = "You gain a +1 trait bonus on Knowledge (geography) and Knowledge (history) checks, and one of them is always a class skill for you.)",
		},
		#endregion

		#region Aspiring Hell Knight
		new Trait
		{
			Name = nameof(TraitEnum.AspiringHellKnight),
			ProperName = "Aspiring Hell Knight",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/aspiring-hellknight-regional-cheliax"),
			Description = "You gain a +1 trait bonus on Intimidate checks, and Intimidate is always a class skill for you.)",
		},
		#endregion

		#region Awakened from Stasis
		new Trait
		{
			Name = nameof(TraitEnum.AwakenedfromStasis),
			ProperName = "Awakened from Stasis",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain all the benefits of 8 hours of sleep in only 2 hours. This allows a spellcaster who must rest to prepare spells to do so after only 2 hours, but does not allow a spellcaster to prepare spells more than once per day.)",
		},
		#endregion

		#region Bandit
		new Trait
		{
			Name = nameof(TraitEnum.Bandit),
			ProperName = "Bandit",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.TheRiverLands,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/bandit-regional-river-kingdoms"),
			Description = "Choose one of the following skills: Escape Artist, Intimidate, or Stealth. You gain a +1 trait bonus on that skill, and it is always a class skill for you.)",
		},
		#endregion

		#region Betrayed Ex-Noble (City of Brass)
		new Trait
		{
			Name = nameof(TraitEnum.BetrayedExNobleCityofBrass),
			ProperName = "Betrayed Ex-Noble (City of Brass)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/betrayed-ex-noble-city-of-brass"),
			Description = "Whenever an enemy attempts to feint against you in combat, the DC to do so is equal to 10 + your base attack bonus + your Wisdom modifier, or 10 + your Intimidate bonus, whichever is higher.)",
		},
		#endregion

		#region Blooded
		new Trait
		{
			Name = nameof(TraitEnum.Blooded),
			ProperName = "Blooded",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/blooded-dwarf-regional-trait"),
			Description = "You receive a +1 trait bonus on weapon damage rolls against giants, goblins, and orcs.)",
		},
		#endregion

		#region Blood Steed
		new Trait
		{
			Name = nameof(TraitEnum.BloodSteed),
			ProperName = "Blood Steed",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/shoanti-steed"),
			Description = "You begin play with a combat trained light horse. While riding this horse bareback, you are treated as though you were riding it with a riding saddle (placing any actual saddle upon the horse negates this benefit). The horse can fend for itself outside of settlements in all but the most hostile environments. If whistled for outside of a community, the horse typically arrives within 1d6 minutes. If your horse is slain, you may receive a new horse by returning to your clan and performing a vigil for its spirit (a rite that costs 100 gp in rare herbs and incense).)",
		},
		#endregion

		#region Border Guard
		new Trait
		{
			Name = nameof(TraitEnum.BorderGuard),
			ProperName = "Border Guard",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/border-guard-kwanlai"),
			Description = "You gain a +2 trait bonus on rolls to confirm critical hits against foes with the aquatic subtype.)",
		},
		#endregion

		#region Born Rider
		new Trait
		{
			Name = nameof(TraitEnum.BornRider),
			ProperName = "Born Rider",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/hongal-bloodrider-hongal"),
			Description = "You gain a +1 trait bonus on Handle Animal and Ride checks.)",
		},
		#endregion

		#region Born under the Green Star
		new Trait
		{
			Name = nameof(TraitEnum.BornundertheGreenStar),
			ProperName = "Born under the Green Star",
			TraitType = TraitTypeEnum.Basic,
			Description = "You treat your caster level as 1 higher when casting spells and spell-like abilities with the mind-affecting descriptor.)",
		},
		#endregion

		#region Bounty Hunter
		new Trait
		{
			Name = nameof(TraitEnum.BountyHunter),
			ProperName = "Bounty Hunter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/bounty-hunter-regional-isger"),
			Description = "You gain a +1 trait bonus on Survival checks to find or follow tracks, and a +1 trait bonus on Perception checks to avoid being surprised.)",
		},
		#endregion

		#region Brave
		new Trait
		{
			Name = nameof(TraitEnum.Brave),
			ProperName = "Brave",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/intrepid-delver-jinin"),
			Description = "You gain a +2 trait bonus on saving throws against fear effects.)",
		},
		#endregion

		#region Builder's Apprentice
		new Trait
		{
			Name = nameof(TraitEnum.BuildersApprentice),
			ProperName = "Builders Apprentice",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/egorian-school-apprentice"),
			Description = "You gain a +3 trait bonus on Knowledge (engineering) checks and a +2 trait bonus on Perception checks to find secret doors or traps in buildings built in a specific style.)",
		},
		#endregion

		#region Candidate for Perfection
		new Trait
		{
			Name = nameof(TraitEnum.CandidateforPerfection),
			ProperName = "Candidate for Perfection",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/candidate-for-perfection-regional-jalmeray"),
			Description = "You gain a +1 trait bonus on attack of opportunity attack rolls made with unarmed strikes.)",
		},
		#endregion

		#region Cavalry Rider
		new Trait
		{
			Name = nameof(TraitEnum.CavalryRider),
			ProperName = "Cavalry Rider",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/lastwall-cavalry-rider-regional"),
			Description = "You gain a +1 trait bonus on Ride checks, and Ride is always a class skill for you.)",
		},
		#endregion

		#region Channel the Earth (Plane of Earth)
		new Trait
		{
			Name = nameof(TraitEnum.ChanneltheEarthPlaneofEarth),
			ProperName = "Channel the Earth (Plane of Earth)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/channel-the-earth-plane-of-earth"),
			Description = "Whenever you channel positive energy to heal living creatures, affected targets gain a +2 profane bonus to CMD to resist bull rush, reposition, and trip combat maneuvers. Alternately, if you channel negative energy to harm living creatures, affected targets take a –2 penalty to CMD against such combat maneuvers. This effect lasts 1 round.)",
		},
		#endregion

		#region Charger
		new Trait
		{
			Name = nameof(TraitEnum.Charger),
			ProperName = "Charger",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/linebreaker-regional-belkzen"),
			Description = "When charging, add 10 feet to your base speed.)",
		},
		#endregion

		#region Cheap to Feed
		new Trait
		{
			Name = nameof(TraitEnum.CheaptoFeed),
			ProperName = "Cheap to Feed",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/cheap-to-feed-osirion-varisia"),
			Description = "You gain a +3 trait bonus on Bluff checks made in order to gain food, water, or shelter.)",
		},
		#endregion

		#region Child of the Crusades
		new Trait
		{
			Name = nameof(TraitEnum.ChildoftheCrusades),
			ProperName = "Child of the Crusades",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/child-of-the-crusades-regional-mendev"),
			Description = "You have inherited their indomitable spirit, and you gain a +2 trait bonus on all saving throws against fear.)",
		},
		#endregion

		#region Child of the Necropolis
		new Trait
		{
			Name = nameof(TraitEnum.ChildoftheNecropolis),
			ProperName = "Child of the Necropolis",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/child-of-the-necropolis"),
			Description = "Your effective cleric level is 1 higher for the purposes of channeling positive energy to damage undead. Your effective cleric level cannot exceed your character level.)",
		},
		#endregion

		#region Chivalrous
		new Trait
		{
			Name = nameof(TraitEnum.Chivalrous),
			ProperName = "Chivalrous",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/chivalrous-regional-taldor"),
			Description = "You gain a +1 trait bonus to Diplomacy and Knowledge (history) checks.)",
		},
		#endregion

		#region Chosen Child
		new Trait
		{
			Name = nameof(TraitEnum.ChosenChild),
			ProperName = "Chosen Child",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/chosen-child-po-li"),
			Description = "Your starting money increases by 900 gp.)",
		},
		#endregion

		#region City Defender
		new Trait
		{
			Name = nameof(TraitEnum.CityDefender),
			ProperName = "City Defender",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/alkenstar-defender-regional-mana-wastes"),
			Description = "You gain a +1 trait bonus on all rolls to confirm critical hits with ranged weapons.)",
		},
		#endregion

		#region Clan Artisan
		new Trait
		{
			Name = nameof(TraitEnum.ClanArtisan),
			ProperName = "Clan Artisan",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/clan-artisan-xa-hoi"),
			Description = "Choose a Craft skill. You gain a +2 trait bonus on checks with the chosen skill, and it becomes a class skill for you.)",
		},
		#endregion

		#region Cliff Jumper
		new Trait
		{
			Name = nameof(TraitEnum.CliffJumper),
			ProperName = "Cliff Jumper",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/cliff-jumper"),
			Description = "You gain a +1 trait bonus on Acrobatics and Climb checks, and on Reflex saving throws to avoid falling.)",
		},
		#endregion

		#region Cliff-Master
		new Trait
		{
			Name = nameof(TraitEnum.CliffMaster),
			ProperName = "Cliff-Master",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/cliff-master-varisia"),
			Description = "You gain a +1 trait bonus on all Climb and Survival checks.)",
		},
		#endregion

		#region Clumsy Slave
		new Trait
		{
			Name = nameof(TraitEnum.ClumsySlave),
			ProperName = "Clumsy Slave",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/clumsy-slave-cheliax-katapesh"),
			Description = "The first time you attack someone with an attack that deals nonlethal damage, your target must make a Sense Motive opposed by your Bluff check minus the damage dealt to realize you actually intended to harm him; failure means he believe the injury was an accident on your part instead (though he may still want to punish you for it).)",
		},
		#endregion

		#region Coincunning
		new Trait
		{
			Name = nameof(TraitEnum.Coincunning),
			ProperName = "Coincunning",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/coincunning-janderhoff"),
			Description = "You receive a +2 trait bonus on Perception checks to notice coins, gems, jewelry, and valuable trade goods. You gain a chance to notice such goods whenever you pass within 10 feet of them, whether or not you are actively looking.)",
		},
		#endregion

		#region Coin Hoarder
		new Trait
		{
			Name = nameof(TraitEnum.CoinHoarder),
			ProperName = "Coin Hoarder",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/coin-hoarder-dwarf-regional-trait"),
			Description = "Your starting cash increases to 500 gp.)",
		},
		#endregion

		#region Cold Heart
		new Trait
		{
			Name = nameof(TraitEnum.ColdHeart),
			ProperName = "Cold Heart",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/cold-heart"),
			Description = "You gain a +2 trait bonus on saving throws against spells and effects with the emotion descriptor.)",
		},
		#endregion

		#region Commercial Savvy
		new Trait
		{
			Name = nameof(TraitEnum.CommercialSavvy),
			ProperName = "Commercial Savvy",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/commercial-savvy-regional"),
			Description = "Whenever you buy from or sell to a merchant, you treat a settlement's Base Value and Purchase Limit as 10% higher.)",
		},
		#endregion

		#region Community-Minded
		new Trait
		{
			Name = nameof(TraitEnum.CommunityMinded),
			ProperName = "Community-Minded",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/community-minded"),
			Description = "Any morale bonuses you confer upon your allies through your own abilities or spells last 2 additional rounds.)",
		},
		#endregion

		#region Confidante to the Oppressed
		new Trait
		{
			Name = nameof(TraitEnum.ConfidantetotheOppressed),
			ProperName = "Confidante to the Oppressed",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/confidante-to-the-oppressed"),
			Description = "You gain a +2 trait bonus on Diplomacy checks to improve the attitude of oppressed, enslaved, or imprisoned subjects, and unless they have reason to distrust you, their starting attitude toward you is at least indifferent, if not better.)",
		},
		#endregion

		#region Conscientious Miner
		new Trait
		{
			Name = nameof(TraitEnum.ConscientiousMiner),
			ProperName = "Conscientious Miner",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/conscientious-miner-jinin"),
			Description = "You gain a +1 trait bonus on Appraise checks, and a +1 trait bonus on Profession (miner) checks. In addition, Profession (miner) becomes a class skill for you.)",
		},
		#endregion

		#region Construct Crafter
		new Trait
		{
			Name = nameof(TraitEnum.ConstructCrafter),
			ProperName = "Construct Crafter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/oenopion-alchemist-regional-nex"),
			Description = "You gain a +1 trait bonus on Craft (alchemy) checks.)",
		},
		#endregion

		#region Corpse Dodger
		new Trait
		{
			Name = nameof(TraitEnum.CorpseDodger),
			ProperName = "Corpse Dodger",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/corpse-dodger"),
			Description = "Once per day, you can cast hide from undead as a spell-like ability. The casting time is a swift action and the caster level for this effect is always 1st; this ability is otherwise identical to the spell.)",
		},
		#endregion

		#region Cosmopolitan
		new Trait
		{
			Name = nameof(TraitEnum.Cosmopolitan),
			ProperName = "Cosmopolitan",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/cosmopolitan-goka"),
			Description = "You gain a +1 trait bonus on Linguistics checks, and Linguistics becomes a class skill for you.)",
		},
		#endregion

		#region Crusader Tactician
		new Trait
		{
			Name = nameof(TraitEnum.CrusaderTactician),
			ProperName = "Crusader Tactician",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/crusader-tactician-regional"),
			Description = "You gain a +1 trait bonus on Knowledge (engineering) and Knowledge (nobility) checks, and one of these skills is always a class skill for you.)",
		},
		#endregion

		#region Cynic
		new Trait
		{
			Name = nameof(TraitEnum.Cynic),
			ProperName = "Cynic",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/cynic-regional-mendev"),
			Description = "You gain a +1 trait bonus on Sense Motive checks, and Sense Motive is always a class skill for you.)",
		},
		#endregion

		#region Cypher Resistance
		new Trait
		{
			Name = nameof(TraitEnum.CypherResistance),
			ProperName = "Cypher Resistance",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/cypher-resistance-riddleport"),
			Description = "You gain a +2 trait bonus on saving throws against spells with the word “glyph” or “symbol” in their name.)",
		},
		#endregion

		#region Darklands Delver
		new Trait
		{
			Name = nameof(TraitEnum.DarklandsDelver),
			ProperName = "Darklands Delver",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/darklands-delver-the-darklands"),
			Description = "You gain a +1 trait bonus on Knowledge (dungeoneering) checks, and a +1 trait bonus on Survival checks made in the Darklands. One of these skills becomes class skill for you.)",
		},
		#endregion

		#region Dealer1
		new Trait
		{
			Name = nameof(TraitEnum.Dealer1),
			ProperName = "Dealer1",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/trait-regional-pesh-dealer"),
			Description = "You gain a +1 trait bonus on Sleight of Hand checks, and Sleight of Hand is always a class skill for you.)",
		},
		#endregion

		#region Dealer2
		new Trait
		{
			Name = nameof(TraitEnum.Dealer2),
			ProperName = "Dealer2",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/pesh-dealer"),
			Description = "You gain a +1 trait bonus on Sleight of Hand checks, and Sleight of Hand is always a class skill for you.)",
		},
		#endregion

		#region Deepsea Native
		new Trait
		{
			Name = nameof(TraitEnum.DeepseaNative),
			ProperName = "Deepsea Native",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/deepsea-native"),
			Description = "You gain a +2 trait bonus on Knowledge checks to identify aquatic monsters. Anytime you are looking through water and would take a penalty on vision-based Perception checks due to murkiness or other natural circumstances, reduce the penalty by 2.)",
		},
		#endregion

		#region Demon Eradicator
		new Trait
		{
			Name = nameof(TraitEnum.DemonEradicator),
			ProperName = "Demon Eradicator",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/demon-eradicator"),
			Description = "Anytime an outsider with the demon subtype must make a Will save against one of your spells, increase the DC of that save by +1.)",
		},
		#endregion

		#region Demon Slayer
		new Trait
		{
			Name = nameof(TraitEnum.DemonSlayer),
			ProperName = "Demon Slayer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/demon-slayer"),
			Description = "You gain a +2 trait bonus on weapon damage against demons, evil fey, and plants and animals corrupted by evil.)",
		},
		#endregion

		#region Desert Nomad
		new Trait
		{
			Name = nameof(TraitEnum.DesertNomad),
			ProperName = "Desert Nomad",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/desert-nomad-regional-thuvia"),
			Description = "You gain a +4 trait bonus on any saving throws made to resist the effects of being in hot conditions, and a +1 trait bonus on all saving throws against fire effects.)",
		},
		#endregion

		#region Destined For Greatness
		new Trait
		{
			Name = nameof(TraitEnum.DestinedForGreatness),
			ProperName = "Destined For Greatness",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.LargeCity,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/destined-for-greatness-large-city"),
			Description = "You start with a kit worth no more than 300 gp, and the expendable contents of the kit are automatically restored to their original capacity at no cost to you whenever you enter a settlement with a population of at least 2,500.)",
		},
		#endregion

		#region Devotee of the Holy Prophecies
		new Trait
		{
			Name = nameof(TraitEnum.DevoteeoftheHolyProphecies),
			ProperName = "Devotee of the Holy Prophecies",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/devotee-of-kalistrade-regional-druma"),
			Description = "You gain a +1 trait bonus on Appraise checks, and a +1 trait bonus on Bluff checks when trying to make a deal with nonbelievers.)",
		},
		#endregion

		#region Dim Seer
		new Trait
		{
			Name = nameof(TraitEnum.DimSeer),
			ProperName = "Dim Seer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/underbridge-dweller-magnimar"),
			Description = "You gain a +2 trait bonus on Perception checks in dim light, and Perception is always a class skill for you.)",
		},
		#endregion

		#region Diplomat
		new Trait
		{
			Name = nameof(TraitEnum.Diplomat),
			ProperName = "Diplomat",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Jungle,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/jungle-diplomat-the-valashmai-jungle"),
			Description = "You gain a +1 trait bonus on Diplomacy and Sense Motive checks.)",
		},
		#endregion

		#region Disbeliever1
		new Trait
		{
			Name = nameof(TraitEnum.Disbeliever1),
			ProperName = "Disbeliever1",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/passionate-believer-po-li"),
			Description = "You gain a +1 trait bonus on saving throws against divine spells.)",
		},
		#endregion

		#region Disbeliever2
		new Trait
		{
			Name = nameof(TraitEnum.Disbeliever2),
			ProperName = "Disbeliever2",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/rahadoumi-disbeliever-regional-rahadoum"),
			Description = "You gain a +2 trait bonus on saving throws against divine spells, but you must make a saving throw even when that magic is beneficial to you.)",
		},
		#endregion

		#region Discerning Beliefs
		new Trait
		{
			Name = nameof(TraitEnum.DiscerningBeliefs),
			ProperName = "Discerning Beliefs",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/discerning-beliefs-zi-ha"),
			Description = "You gain a +2 trait bonus on saving throws to disbelieve illusions.)",
		},
		#endregion

		#region Disease Resistant
		new Trait
		{
			Name = nameof(TraitEnum.DiseaseResistant),
			ProperName = "Disease Resistant",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/disease-resistant"),
			Description = "You gain a +1 trait bonus on saving throws against curses and diseases, including magical diseases.)",
		},
		#endregion

		#region Diver
		new Trait
		{
			Name = nameof(TraitEnum.Diver),
			ProperName = "Diver",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/oagan-diver-regional-the-sodden-lands"),
			Description = "You gain a +1 trait bonus on Swim checks, and Swim is always a class skill for you.)",
		},
		#endregion

		#region Divine Deceiver
		new Trait
		{
			Name = nameof(TraitEnum.DivineDeceiver),
			ProperName = "Divine Deceiver",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/divine-deceiver-regional"),
			Description = "Once per day as a full-round action, you can sacrifice a prepared arcane spell or spell slot to manifest healing magic. This acts as cure light wounds, except you heal 1d6 points of damage per level of the spell or spell slot sacrificed (maximum 5d6) and the hit points healed are temporary (lasting 1 hour).)",
		},
		#endregion

		#region Dominator
		new Trait
		{
			Name = nameof(TraitEnum.Dominator),
			ProperName = "Dominator",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/dominator-regional-belkzen"),
			Description = "You receive a +2 trait bonus on all attempts to demoralize an opponent in combat using the Intimidate skill.)",
		},
		#endregion

		#region Draconic Vigil
		new Trait
		{
			Name = nameof(TraitEnum.DraconicVigil),
			ProperName = "Draconic Vigil",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/draconic-vigil"),
			Description = "You gain a +1 bonus on initiative rolls when entering combat against creatures of the dragon type or humanoids of the orc subtype.)",
		},
		#endregion

		#region Dump Salvager
		new Trait
		{
			Name = nameof(TraitEnum.DumpSalvager),
			ProperName = "Dump Salvager",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/dump-salvager"),
			Description = "You gain a +3 trait bonus on Perception checks to search for concealed items.)",
		},
		#endregion

		#region Dungeon Dweller
		new Trait
		{
			Name = nameof(TraitEnum.DungeonDweller),
			ProperName = "Dungeon Dweller",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Dungeon,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/dungeon-dweller-any-subterranean-dungeon"),
			Description = "You start with one additional language chosen from the following list: Aklo, Dark Folk, Draconic, Goblin, Necril, Orc, or Undercommon. In addition, whenever you must attempt a Survival check to avoid getting lost in a dungeon, you may roll the check twice and take the better result.)",
		},
		#endregion

		#region Dusk Agent
		new Trait
		{
			Name = nameof(TraitEnum.DuskAgent),
			ProperName = "Dusk Agent",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/agent-of-dusk"),
			Description = "You have quite a bit more spending cash than most others of your age as a result, and start with twice the normal amount of starting gold. In addition, your reputation remains strong and any transactions you make in your home city are always beneficial to you; items you sell net you an additional 10% profit, and items you purchase there are 10% cheaper than normal. This discount also applies to your starting gear.)",
		},
		#endregion

		#region Dusk Agent
		new Trait
		{
			Name = nameof(TraitEnum.DuskAgent),
			ProperName = "Dusk Agent",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/trait-regional-duskwalker-agent"),
			Description = "You start with twice the normal amount of starting gold. In addition, any transactions you make in a specific market are always beneficial to you; items you sell there net you an additional 10% profit, and items you purchase there are 10% cheaper than normal. This discount also applies to your starting gear.)",
		},
		#endregion

		#region Dusk Dancer
		new Trait
		{
			Name = nameof(TraitEnum.DuskDancer),
			ProperName = "Dusk Dancer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/dusk-dancer-nidal"),
			Description = "You gain a +2 trait bonus on Reflex saving throws in dim light or darkness.)",
		},
		#endregion

		#region Elemental Pupil
		new Trait
		{
			Name = nameof(TraitEnum.ElementalPupil),
			ProperName = "Elemental Pupil",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/elemental-pupil-regional-qadira"),
			Description = "Choose one of the following energy types: acid, cold, electricity, or fire. When casting a spell of 1st level or higher that deals damage of your chosen energy type, the spell deals 1 extra point of damage of this type.)",
		},
		#endregion

		#region Emissary
		new Trait
		{
			Name = nameof(TraitEnum.Emissary),
			ProperName = "Emissary",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/emissary-kaer-maga"),
			Description = "You gain a +2 trait bonus on Diplomacy checks when dealing with aberrations, monstrous humanoids, undead, and creatures with the giant subtype.)",
		},
		#endregion

		#region Enemy of the Dead
		new Trait
		{
			Name = nameof(TraitEnum.EnemyoftheDead),
			ProperName = "Enemy of the Dead",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/enemy-of-the-undead-regional-geb"),
			Description = "You gain a +2 trait bonus on saving throws against any spells or spell-like abilities from an undead creature.)",
		},
		#endregion

		#region Eoxian Experiment
		new Trait
		{
			Name = nameof(TraitEnum.EoxianExperiment),
			ProperName = "Eoxian Experiment",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on saving throws against pain effects and the spell-like abilities of undead.)",
		},
		#endregion

		#region Equality for All
		new Trait
		{
			Name = nameof(TraitEnum.EqualityforAll),
			ProperName = "Equality for All",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/equality-for-all-andoran"),
			Description = "You gain a +2 trait bonus to your CMB and your CMD when facing opponents who are at least two sizes larger than you.)",
		},
		#endregion

		#region Evident Supporter
		new Trait
		{
			Name = nameof(TraitEnum.EvidentSupporter),
			ProperName = "Evident Supporter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/evident-supporter-regional"),
			Description = "The Sense Motive DC needed for a city guard, a politician, or other governmental functionary in a large town or larger settlement to gain a hunch about your trustworthiness is 25 (instead of 20). On a failed check, you're seen as trustworthy regardless of the situation.)",
		},
		#endregion

		#region Exiled Scholar
		new Trait
		{
			Name = nameof(TraitEnum.ExiledScholar),
			ProperName = "Exiled Scholar",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/exiled-scholar"),
			Description = "You gain a +1 trait bonus on Knowledge (arcana) and (religion) checks. In addition, choose one Knowledge skill; you can attempt untrained checks with this skill as long as the DC is lower than 15.)",
		},
		#endregion

		#region Expert Smuggler
		new Trait
		{
			Name = nameof(TraitEnum.ExpertSmuggler),
			ProperName = "Expert Smuggler",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/expert-smuggler-regional"),
			Description = "Other creatures never gain the +4 bonus on their Perception checks (opposed by your Sleight of Hand check) while frisking you.)",
		},
		#endregion

		#region Eye of the Falcon
		new Trait
		{
			Name = nameof(TraitEnum.EyeoftheFalcon),
			ProperName = "Eye of the Falcon",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/eye-of-the-falcon"),
			Description = "You gain a +1 trait bonus on saving throws against illusion (phantasm) spells and a +1 trait bonus on Sense Motive checks to know when you are being lied to, so long as you are face to face with the speaker in question.)",
		},
		#endregion

		#region Famed Performer
		new Trait
		{
			Name = nameof(TraitEnum.FamedPerformer),
			ProperName = "Famed Performer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/famed-performer"),
			Description = "Once per day when you start a bardic performance, you can increase the DC of the saving throw to resist your performance's effects by 1. This effect lasts until you switch performances or end your performance.)",
		},
		#endregion

		#region Fiery Dominance (Plane of Fire)
		new Trait
		{
			Name = nameof(TraitEnum.FieryDominancePlaneofFire),
			ProperName = "Fiery Dominance (Plane of Fire)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/fiery-dominance-plane-of-fire"),
			Description = "You gain a +1 trait bonus on Intimidate checks against humanoids of a subtype different from your own (or all non-human humanoids, if you are not a humanoid), and the DC for such creatures to demoralize you with Intimidate is 2 higher than usual.)",
		},
		#endregion

		#region Fixer
		new Trait
		{
			Name = nameof(TraitEnum.Fixer),
			ProperName = "Fixer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/fixer"),
			Description = "Once per day, you can tinker with a broken object to allow anyone who uses it to ignore the penalties for its broken condition for 24 hours (this does not affect the object’s hit points). At the end of this time, it regains the broken condition (but you can use this trait on it over and over again).)",
		},
		#endregion

		#region Flotsam
		new Trait
		{
			Name = nameof(TraitEnum.Flotsam),
			ProperName = "Flotsam",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Coastline,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/flotsam-coastline"),
			Description = "You gain a +2 bonus on Reflex saving throws against spells and effects with the fire descriptor.)",
		},
		#endregion

		#region Forbidden Knowledge
		new Trait
		{
			Name = nameof(TraitEnum.ForbiddenKnowledge),
			ProperName = "Forbidden Knowledge",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/forbidden-knowledge"),
			Description = "Anytime you would roll a Knowledge (planes) check, you may roll a Knowledge (history) or Knowledge (religion) check instead.)",
		},
		#endregion

		#region Freedom Fighter
		new Trait
		{
			Name = nameof(TraitEnum.FreedomFighter),
			ProperName = "Freedom Fighter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/andoren-freedom-fighter-regional-andoran"),
			Description = "You gain a +1 trait bonus on attack and damage rolls against slavers or any creature holding someone against their will.)",
		},
		#endregion

		#region Freedom Fighter
		new Trait
		{
			Name = nameof(TraitEnum.FreedomFighter),
			ProperName = "Freedom Fighter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/andoren-freedom-fighter-regional-andoran"),
			Description = "You gain a +1 trait bonus on attack and damage rolls against slavers or any creature holding someone against their will.)",
		},
		#endregion

		#region Freedom Fighter
		new Trait
		{
			Name = nameof(TraitEnum.FreedomFighter),
			ProperName = "Freedom Fighter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/freedom-fighter-shokuro"),
			Description = "You gain a +1 trait bonus on attacks made with improvised weapons. If you do not possess the Catch Off-Guard or Throw Anything feats, you still take penalties on these attack rolls as normal.)",
		},
		#endregion

		#region Freed Slave1
		new Trait
		{
			Name = nameof(TraitEnum.FreedSlave1),
			ProperName = "Freed Slave1",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/freed-slave-katapesh"),
			Description = "You gain a +1 trait bonus on Will saving throws.)",
		},
		#endregion

		#region Freed Slave2
		new Trait
		{
			Name = nameof(TraitEnum.FreedSlave2),
			ProperName = "Freed Slave2",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/freed-slave-regional-andoran"),
			Description = "You gain a +1 trait bonus on Will saves.)",
		},
		#endregion

		#region Friend of the Dead
		new Trait
		{
			Name = nameof(TraitEnum.FriendoftheDead),
			ProperName = "Friend of the Dead",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/friend-of-the-dead-regional-geb"),
			Description = "You gain a +2 trait bonus on Diplomacy checks against sentient undead.)",
		},
		#endregion

		#region Friend of the Fey
		new Trait
		{
			Name = nameof(TraitEnum.FriendoftheFey),
			ProperName = "Friend of the Fey",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/friend-of-the-fey-regional-lands-of-the-linnorm-kings"),
			Description = "You gain a +2 trait bonus on Diplomacy checks against fey creatures.)",
		},
		#endregion

		#region Frontier-Forged
		new Trait
		{
			Name = nameof(TraitEnum.FrontierForged),
			ProperName = "Frontier-Forged",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Frontier,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/frontier-forged"),
			Description = "You receive a +1 trait bonus on Perception checks and a +1 bonus on Survival checks made to get along in the wild.)",
		},
		#endregion

		#region Frostborn
		new Trait
		{
			Name = nameof(TraitEnum.Frostborn),
			ProperName = "Frostborn",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/frostborn-dwarf-regional-trait"),
			Description = "You gain a +4 trait bonus on any savings throws made to resist the effects of cold environments, as well as a +1 trait bonus on all saving throws against cold effects.)",
		},
		#endregion

		#region Gallant Imposter
		new Trait
		{
			Name = nameof(TraitEnum.GallantImposter),
			ProperName = "Gallant Imposter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/gallant-imposter"),
			Description = "You gain a +1 trait bonus on Knowledge (nobility) and Knowledge (religion) checks. In addition, you gain a +2 trait bonus on both Disguise and Bluff checks while attempting to impersonate a knight.)",
		},
		#endregion

		#region Gatekeeper
		new Trait
		{
			Name = nameof(TraitEnum.Gatekeeper),
			ProperName = "Gatekeeper",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/kyonin-gatekeeper-kyonin"),
			Description = "You gain a +1 trait bonus on Spellcraft checks to identify teleportation magic and a +1 trait bonus to caster level checks when casting teleportation spells. You know the proper commands to operate a particular elf gate (most likely an often used elf gate, but at the GM’s discretion it may be a less popular or out-of-the-way elf gate).)",
		},
		#endregion

		#region Genie-Caller
		new Trait
		{
			Name = nameof(TraitEnum.GenieCaller),
			ProperName = "Genie-Caller",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/genie-caller-regional-qadira"),
			Description = "Once per day, you may cast one conjuration (summoning) spell as if your caster level were 2 higher than normal.)",
		},
		#endregion

		#region Ghost Survivor
		new Trait
		{
			Name = nameof(TraitEnum.GhostSurvivor),
			ProperName = "Ghost Survivor",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/ghost-survivor"),
			Description = "You gain a +2 trait bonus on Knowledge (religion) checks to identify incorporeal undead and a +2 trait bonus on Fortitude saving throws against effects that inflict negative levels.)",
		},
		#endregion

		#region Ghoulish Affinity
		new Trait
		{
			Name = nameof(TraitEnum.GhoulishAffinity),
			ProperName = "Ghoulish Affinity",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/ghoulish-affinity"),
			Description = "You gain a +2 trait bonus on Perception checks to notice undead disguised as living creatures, and a +2 trait bonus on Fortitude saves against diseases and poisons inflicted by undead.)",
		},
		#endregion

		#region Glory of Old
		new Trait
		{
			Name = nameof(TraitEnum.GloryofOld),
			ProperName = "Glory of Old",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/glory-of-old-dwarf-regional-trait"),
			Description = "You receive a +1 trait bonus on saving throws against spells, spell-like abilities, and poison.)",
		},
		#endregion

		#region Gravelwalker
		new Trait
		{
			Name = nameof(TraitEnum.Gravelwalker),
			ProperName = "Gravelwalker",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.WarmMountains,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/gravelwalker-usually-under-warm-mountains"),
			Description = "You can move normally through such obstructed spaces, and can run or charge though them with a successful Acrobatics check.)",
		},
		#endregion

		#region Great Market Merchant
		new Trait
		{
			Name = nameof(TraitEnum.GreatMarketMerchant),
			ProperName = "Great Market Merchant",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/merchant-of-katheer-qadira-regional-trait"),
			Description = "You gain a +1 trait bonus to Appraise checks, and Appraise is always a class skill for you.)",
		},
		#endregion

		#region Grit Goggles
		new Trait
		{
			Name = nameof(TraitEnum.GritGoggles),
			ProperName = "Grit Goggles",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Deserts,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/grit-goggles-usually-under-deserts"),
			Description = "You gain a +2 trait bonus against being blinded by foreign objects (such as from a Dirty Trick combat maneuver) and you halve any reductions in visibility from the environment (such as from certain storms) and their corresponding penalties. For example, if you were in a sandstorm that normally reduces visibility to 25 feet and imparts a –4 penalty on Perception checks, you reduce visibility to 50 feet and take only a –2 penalty on Perception checks.)",
		},
		#endregion

		#region Group Fighter
		new Trait
		{
			Name = nameof(TraitEnum.GroupFighter),
			ProperName = "Group Fighter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/militia-amanandar"),
			Description = "You gain a +1 trait bonus on attacks made while flanking an opponent.)",
		},
		#endregion

		#region Guerilla
		new Trait
		{
			Name = nameof(TraitEnum.Guerilla),
			ProperName = "Guerilla",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/guerilla-dtang-ma"),
			Description = "You gain a +1 trait bonus on Knowledge (nature) checks as well as Survival checks made in the rainforest. One of these skills becomes a class skill for you.)",
		},
		#endregion

		#region Guide of the Streets
		new Trait
		{
			Name = nameof(TraitEnum.GuideoftheStreets),
			ProperName = "Guide of the Streets",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/absalom-hotspur-regional-absalom"),
			Description = "You gain a +1 trait bonus on Initiative checks and Knowledge (local) checks.)",
		},
		#endregion

		#region Heart of Clay
		new Trait
		{
			Name = nameof(TraitEnum.HeartofClay),
			ProperName = "Heart of Clay",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/heart-of-clay-lingshen"),
			Description = "You gain a +1 trait bonus on Fortitude saves.)",
		},
		#endregion

		#region Heavenly Touch
		new Trait
		{
			Name = nameof(TraitEnum.HeavenlyTouch),
			ProperName = "Heavenly Touch",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/heavenly-touch-tianjing"),
			Description = "At will, you can touch a dying creature to stabilize it as a standard action.)",
		},
		#endregion

		#region Heavy Hitter
		new Trait
		{
			Name = nameof(TraitEnum.HeavyHitter),
			ProperName = "Heavy Hitter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/quain-martial-artist-quain"),
			Description = "You gain a +1 trait bonus on damage rolls made with unarmed attacks.)",
		},
		#endregion

		#region Highlander
		new Trait
		{
			Name = nameof(TraitEnum.Highlander),
			ProperName = "Highlander",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.HillsorMountains,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/highlander-hills-or-mountains"),
			Description = "You gain a +1 trait bonus on Stealth checks, and Stealth is always a class skill for you. This trait bonus increases to +2 in hilly or rocky areas.)",
		},
		#endregion

		#region Hobgoblin Slayer
		new Trait
		{
			Name = nameof(TraitEnum.HobgoblinSlayer),
			ProperName = "Hobgoblin Slayer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/hobgoblin-slayer"),
			Description = "Whenever you’re within 60 feet of an enemy hobgoblin, you gain a +1 trait bonus on all weapon damage rolls.)",
		},
		#endregion

		#region Holy Tattoo
		new Trait
		{
			Name = nameof(TraitEnum.HolyTattoo),
			ProperName = "Holy Tattoo",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/holy-tattoo"),
			Description = "Your holy symbol tattoo functions in all ways as a holy symbol. When you use your holy symbol tattoo to keep a vampire at bay, the DC for the vampire to overcome its revulsion is 28 (rather than the normal 25).)",
		},
		#endregion

		#region Honeyed Tongue
		new Trait
		{
			Name = nameof(TraitEnum.HoneyedTongue),
			ProperName = "Honeyed Tongue",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/honeyed-tongue-amanandar"),
			Description = "You gain a +1 trait bonus on Diplomacy checks, and Diplomacy becomes a class skill for you.)",
		},
		#endregion

		#region Humble Beginnings
		new Trait
		{
			Name = nameof(TraitEnum.HumbleBeginnings),
			ProperName = "Humble Beginnings",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/humble-beginnings-varisia-smaller-settlements"),
			Description = "Choose one of the following: boot, bucket, frying pan, mug, rolling pin, spade, or stool. You are treated as having the Catch Off-Guard feat when wielding the chosen item. (These items should all be considered improvised melee weapons that deal 1d4 points of bludgeoning damage.))",
		},
		#endregion

		#region Hunter of Outsiders
		new Trait
		{
			Name = nameof(TraitEnum.HunterofOutsiders),
			ProperName = "Hunter of Outsiders",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/whisper-woods-hunter"),
			Description = "You gain a +2 trait bonus on Survival checks to track evil outsiders and a +2 trait bonus on initiative checks when you know your opponent is an evil outsider.)",
		},
		#endregion

		#region Imperial Soldier
		new Trait
		{
			Name = nameof(TraitEnum.ImperialSoldier),
			ProperName = "Imperial Soldier",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/imperial-soldier-regional-molthune"),
			Description = "Choose Heal, Intimidate, or Ride. You gain a +1 trait bonus on that skill, and it is always a class skill for you.)",
		},
		#endregion

		#region Inspiring Speaker
		new Trait
		{
			Name = nameof(TraitEnum.InspiringSpeaker),
			ProperName = "Inspiring Speaker",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/inspiring-speaker-regional-galt"),
			Description = "You gain a +1 trait bonus on Bluff and Diplomacy checks when addressing crowds of 10 people or more.)",
		},
		#endregion

		#region Instigator of Rebellion
		new Trait
		{
			Name = nameof(TraitEnum.InstigatorofRebellion),
			ProperName = "Instigator of Rebellion",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/instigator-of-rebellion-minkai"),
			Description = "You gain a +1 trait bonus on Diplomacy and Intimidate checks.)",
		},
		#endregion

		#region Iron Lungs
		new Trait
		{
			Name = nameof(TraitEnum.IronLungs),
			ProperName = "Iron Lungs",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Marshlands,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/iron-lungs-usually-under-marshlands"),
			Description = "You can hold your breath for twice as long and gain a +2 trait bonus on saving throws against the effects of inhaled poisons.)",
		},
		#endregion

		#region Iron Mind
		new Trait
		{
			Name = nameof(TraitEnum.IronMind),
			ProperName = "Iron Mind",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/iron-mind"),
			Description = "You gain a +2 trait bonus on saving throws against spells and effects that would reduce your Intelligence score or cause you to forget something.)",
		},
		#endregion

		#region Jungle Guide
		new Trait
		{
			Name = nameof(TraitEnum.JungleGuide),
			ProperName = "Jungle Guide",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/jungle-guide-regional-sargava"),
			Description = "You gain a +1 trait bonus on Handle Animal checks, and a +1 trait bonus on Survival checks in jungle terrain. One of these skills is always a class skill for you.)",
		},
		#endregion

		#region Jungle Walker
		new Trait
		{
			Name = nameof(TraitEnum.JungleWalker),
			ProperName = "Jungle Walker",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Jungle,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/jungle-walker-regional-mwangi-expanse"),
			Description = "You gain a +2 trait bonus on Survival checks in jungle terrain.)",
		},
		#endregion

		#region Justiciar
		new Trait
		{
			Name = nameof(TraitEnum.Justiciar),
			ProperName = "Justiciar",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/justiciar-regional"),
			Description = "You gain a +1 trait bonus on Diplomacy and Knowledge (local) checks to settle disputes or arbitrate laws. Once per day if you succeed at an Intimidate check to demoralize a foe who has repudiated or ignored a pronounced judgment you've made, you may choose to cause the creature to be sickened instead of shaken. The duration of the effect remains the same.)",
		},
		#endregion

		#region Keeper of the Veil
		new Trait
		{
			Name = nameof(TraitEnum.KeeperoftheVeil),
			ProperName = "Keeper of the Veil",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/keeper-of-the-veil-regional-qadira"),
			Description = "You gain a +1 competence bonus on Bluff and Disguise checks, and one of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Lair Snake
		new Trait
		{
			Name = nameof(TraitEnum.LairSnake),
			ProperName = "Lair Snake",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.DragonsLair,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/lair-snake-dragon-s-lair"),
			Description = "You gain a +1 trait bonus on Appraise checks, and your starting wealth increases by 200 gp.)",
		},
		#endregion

		#region Left Behind
		new Trait
		{
			Name = nameof(TraitEnum.LeftBehind),
			ProperName = "Left Behind",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/left-behind-mwangi-expanse-or-varisia"),
			Description = "You gain a +1 trait bonus on Diplomacy and Gather Information checks when interacting with forlorn elves and non-elf races.)",
		},
		#endregion

		#region Lesser Noble
		new Trait
		{
			Name = nameof(TraitEnum.LesserNoble),
			ProperName = "Lesser Noble",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/ustalavic-noble-regional-ustalav"),
			Description = "You gain a +1 trait bonus on Diplomacy and Knowledge (nobility) checks. In addition, your starting money is increased by 100 gp— your “birthright,” such as it is.)",
		},
		#endregion

		#region Lightning Rider
		new Trait
		{
			Name = nameof(TraitEnum.LightningRider),
			ProperName = "Lightning Rider",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/rider-of-paresh-regional-qadira"),
			Description = "When mounted and making a charge, your mount's speed is increased by 10 feet. You must have the Mounted Combat feat to take this trait.)",
		},
		#endregion

		#region Light Sleeper
		new Trait
		{
			Name = nameof(TraitEnum.LightSleeper),
			ProperName = "Light Sleeper",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/light-sleeper"),
			Description = "You need to sleep only 4 hours to get a full night's rest (restoring 1 hit point per character level). You do not receive extra benefits for sleeping additional hours, and you must still rest for 24 hours to receive the benefits of complete bed rest.)",
		},
		#endregion

		#region Local Know-It-All
		new Trait
		{
			Name = nameof(TraitEnum.LocalKnowItAll),
			ProperName = "Local Know-It-All",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/local-know-it-all-varisia"),
			Description = "Choose a community that you've lived in for at least 5 years. You gain a +2 trait bonus on Knowledge (local) checks related to that community.)",
		},
		#endregion

		#region Long Jumper
		new Trait
		{
			Name = nameof(TraitEnum.LongJumper),
			ProperName = "Long Jumper",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/roof-racer-korvosa"),
			Description = "When using the Acrobatics skill to make a long jump, you treat the DC of the skill check as if the distance being jumped were 5 feet shorter than it actually is.)",
		},
		#endregion

		#region Lucky Turnabout
		new Trait
		{
			Name = nameof(TraitEnum.LuckyTurnabout),
			ProperName = "Lucky Turnabout",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/winner-s-luck-riddleport"),
			Description = "Whenever you succeed at a Reflex saving throw, you may draw a weapon as an immediate action, or a hidden weapon as a move action.)",
		},
		#endregion

		#region Mammoth Master
		new Trait
		{
			Name = nameof(TraitEnum.MammothMaster),
			ProperName = "Mammoth Master",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/mammoth-master-regional-realm-of-the-mammoth-lords"),
			Description = "You gain a +4 trait bonus on Handle Animal checks related to large creatures such as mammoths, mastodons, woolly rhinoceroses, and other megafauna.)",
		},
		#endregion

		#region Master Illusionist
		new Trait
		{
			Name = nameof(TraitEnum.MasterIllusionist),
			ProperName = "Master Illusionist",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/iadaran-illusionist-regional-kyonin"),
			Description = "You gain a +1 trait bonus on caster level checks with illusion spells and a +1 trait bonus on Will saves to disbelieve illusions.)",
		},
		#endregion

		#region Master of Peaks
		new Trait
		{
			Name = nameof(TraitEnum.MasterofPeaks),
			ProperName = "Master of Peaks",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/master-of-peaks-the-wall-of-heaven"),
			Description = "You gain a +2 trait bonus on Fortitude saving throws made against the effects of cold dangers and altitude sickness.)",
		},
		#endregion

		#region Merchant’s Child
		new Trait
		{
			Name = nameof(TraitEnum.MerchantsChild),
			ProperName = "Merchant’s Child",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/merchant-s-child-regional-katapesh"),
			Description = "You gain a +1 trait bonus on Appraise checks, and Appraise is always a class skill for you.)",
		},
		#endregion

		#region Militia Veteran
		new Trait
		{
			Name = nameof(TraitEnum.MilitiaVeteran),
			ProperName = "Militia Veteran",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.TownorVillage,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/militia-veteran"),
			Description = "Select Profession (soldier), Ride, or Survival. You gain a +2 trait bonus on that skill, and it is always a class skill for you.)",
		},
		#endregion

		#region Miner
		new Trait
		{
			Name = nameof(TraitEnum.Miner),
			ProperName = "Miner",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/szaezan-crags-miner-bachuan"),
			Description = "You gain a +1 trait bonus on Appraise checks, and Appraise becomes a class skill for you.)",
		},
		#endregion

		#region Mordant Heritage
		new Trait
		{
			Name = nameof(TraitEnum.MordantHeritage),
			ProperName = "Mordant Heritage",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/mordant-heritage-regional-the-steaming-sea"),
			Description = "You gain a +1 trait bonus on Swim checks and a +1 trait bonus on saving throws against enchantment effects.)",
		},
		#endregion

		#region Mountain Guide
		new Trait
		{
			Name = nameof(TraitEnum.MountainGuide),
			ProperName = "Mountain Guide",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Mountains,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/mountain-guide-regional-five-kings-mountains"),
			Description = "You gain a +1 trait bonus on Knowledge (geography) and Survival checks when in mountainous areas, and Knowledge (geography) is always a class skill for you.)",
		},
		#endregion

		#region Natural Artist
		new Trait
		{
			Name = nameof(TraitEnum.NaturalArtist),
			ProperName = "Natural Artist",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/hwan-artist-hwanggot"),
			Description = "Choose a Perform skill. You gain a +1 trait bonus on checks with the chosen skill, and it becomes a class skill for you.)",
		},
		#endregion

		#region Natural Climber
		new Trait
		{
			Name = nameof(TraitEnum.NaturalClimber),
			ProperName = "Natural Climber",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/natural-climber"),
			Description = "You gain a +2 trait bonus on Acrobatics and Climb checks while climbing trees.)",
		},
		#endregion

		#region Navigator
		new Trait
		{
			Name = nameof(TraitEnum.Navigator),
			ProperName = "Navigator",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/trench-navigator-xidao"),
			Description = "You gain a +1 trait bonus on Knowledge (geography) checks, and a +1 trait bonus on Profession (sailor) checks. One of these skills becomes a class skill for you.)",
		},
		#endregion

		#region Noble
		new Trait
		{
			Name = nameof(TraitEnum.Noble),
			ProperName = "Noble",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/issian-noble-regional-brevoy"),
			Description = "You gain a +1 trait bonus on Knowledge (nobility) and Sense Motive checks.)",
		},
		#endregion

		#region Numerologist
		new Trait
		{
			Name = nameof(TraitEnum.Numerologist),
			ProperName = "Numerologist",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/numerologist"),
			Description = "Once per day, you can attempt a Perception check while studying a trap (a standard action). The DC of this check is equal to the Disable Device DC of the trap – 5. If you succeed, you identify the DC necessary to disable the trap, as well as the DC of the Reflex save (if any) to avoid its effects.)",
		},
		#endregion

		#region Obsequious Morsel
		new Trait
		{
			Name = nameof(TraitEnum.ObsequiousMorsel),
			ProperName = "Obsequious Morsel",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/obsequious-morsel-regional"),
			Description = "Once per day as a swift action, you can use sanctuary as a spell-like ability (caster level = your highest caster level, or 1st if you have no caster level), with a DC equal to 10 + 1/2 your caster level (minimum 0) + your Charisma modifier. Only undead must save to attack you (other creature types are not affected). The effect ends as soon as you attack a creature, as normal.)",
		},
		#endregion

		#region Offspring of the Ascension
		new Trait
		{
			Name = nameof(TraitEnum.OffspringoftheAscension),
			ProperName = "Offspring of the Ascension",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on Will saves against fear effects. Any time you become confused, reduce the duration of the effect by a number of rounds equal to your Wisdom modifier to a minimum of 1 round of confusion).)",
		},
		#endregion

		#region On Guard
		new Trait
		{
			Name = nameof(TraitEnum.OnGuard),
			ProperName = "On Guard",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/watching-taldor-qadira"),
			Description = "You gain a +1 trait bonus to Initiative checks, and if you are able to act during the surprise round of an encounter, you can draw a weapon (but not a potion or magic item) as a free action during that round.)",
		},
		#endregion

		#region Open-Minded Explorer
		new Trait
		{
			Name = nameof(TraitEnum.OpenMindedExplorer),
			ProperName = "Open-Minded Explorer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/open-minded-explorer-regional"),
			Description = "You gain a +1 trait bonus on Diplomacy checks. This bonus increases to +2 when you're speaking the racial or ethnic language of the target creature.)",
		},
		#endregion

		#region Orc Impaler
		new Trait
		{
			Name = nameof(TraitEnum.OrcImpaler),
			ProperName = "Orc Impaler",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/orc-impaler"),
			Description = "You gain a +2 trait bonus on rolls to confirm critical hits made as part of a charge. This bonus increases to +3 if the critical hit is made against a creature with the orc subtype.)",
		},
		#endregion

		#region Orphan
		new Trait
		{
			Name = nameof(TraitEnum.Orphan),
			ProperName = "Orphan",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/isgeri-orphan-regional-isger"),
			Description = "You gain a +1 trait bonus on Fortitude saves.)",
		},
		#endregion

		#region Paragon of Speed
		new Trait
		{
			Name = nameof(TraitEnum.ParagonofSpeed),
			ProperName = "Paragon of Speed",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/hermean-paragon-regional-the-steaming-sea"),
			Description = "You are quicker than normal members of your race, and gain a +2 trait bonus on Initiative checks.)",
		},
		#endregion

		#region Pearl Diver
		new Trait
		{
			Name = nameof(TraitEnum.PearlDiver),
			ProperName = "Pearl Diver",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/pearl-diver-xidao"),
			Description = "You gain a +1 trait bonus on Appraise and Swim checks.)",
		},
		#endregion

		#region Perseverance
		new Trait
		{
			Name = nameof(TraitEnum.Perseverance),
			ProperName = "Perseverance",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Mountains,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/perseverance-regional-five-kings-mountains"),
			Description = "When you have more than 1 Will saving throw to overcome an effect (such as greater command, hold person, or by using the good fortune ability of the Luck domain), you receive a +3 trait bonus on the extra Will saving throws against that effect.)",
		},
		#endregion

		#region Pirate
		new Trait
		{
			Name = nameof(TraitEnum.Pirate),
			ProperName = "Pirate",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/belem-pirate-minata"),
			Description = "You gain a +1 trait bonus on Profession (sailor) and Swim checks, and Swim is always a class skill for you. You might also have a peg leg or a hook for a hand, but that’s not so helpful.)",
		},
		#endregion

		#region Pirate2
		new Trait
		{
			Name = nameof(TraitEnum.Pirate2),
			ProperName = "Pirate2",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/goblin-pirate"),
			Description = "You gain a +1 trait bonus on Knowledge (geography) checks and Profession (sailor) checks, and one of these skills becomes a class skill for you.)",
		},
		#endregion

		#region Plainsman
		new Trait
		{
			Name = nameof(TraitEnum.Plainsman),
			ProperName = "Plainsman",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/plainsman"),
			Description = "You gain a +1 trait bonus on all Knowledge (geography) and Survival checks regarding the plains.)",
		},
		#endregion

		#region Planar Historian (Plane of Water)
		new Trait
		{
			Name = nameof(TraitEnum.PlanarHistorianPlaneofWater),
			ProperName = "Planar Historian (Plane of Water)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/planar-historian-plane-of-water"),
			Description = "You gain a +2 trait bonus on Knowledge (planes) checks to identify outsiders with the water subtype. In addition, you treat your caster level as 1 higher when casting conjuration (summoning) spells to summon outsiders with the water subtype.)",
		},
		#endregion

		#region Planar Scholar (Plane of Air)
		new Trait
		{
			Name = nameof(TraitEnum.PlanarScholarPlaneofAir),
			ProperName = "Planar Scholar (Plane of Air)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/planar-scholar-plane-of-air"),
			Description = "You gain a +1 trait bonus on Knowledge (planes) checks and checks made with one other Knowledge skill of your choice. This bonus increases to +3 when used to identify a creature with the air subtype. Knowledge (planes) becomes a class skill for you, and your bonus language options at 1st level include Auran. This choice is in addition to the bonus languages available to the character because of her race.)",
		},
		#endregion

		#region Pomp and Pageantry
		new Trait
		{
			Name = nameof(TraitEnum.PompandPageantry),
			ProperName = "Pomp and Pageantry",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/pomp-and-pageantry"),
			Description = "You gain a +1 trait bonus on Acrobatics, Diplomacy, Handle Animal, Intimidate, Perform, and Ride checks with class skills if you spend twice as long as it normally takes to make that check.)",
		},
		#endregion

		#region Powerful Bloodline
		new Trait
		{
			Name = nameof(TraitEnum.PowerfulBloodline),
			ProperName = "Powerful Bloodline",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/dtang-ma-bloodline-dtang-ma"),
			Description = "Choose one of the following sorcerer bloodlines: fey, maestro, starsoul, or stormborn. Once per day, you may use one of your bloodline powers as if your sorcerer level were 1 higher than normal. This trait does not give you access to bloodline powers whose level requirements you do not yet meet.)",
		},
		#endregion

		#region Precocious Spellcaster
		new Trait
		{
			Name = nameof(TraitEnum.PrecociousSpellcaster),
			ProperName = "Precocious Spellcaster",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/precocious-spellcaster"),
			Description = "Select one cantrip and one 1st-level spell; when you cast these spells, they function at one caster level higher than your actual caster level.)",
		},
		#endregion

		#region Privileged Slave
		new Trait
		{
			Name = nameof(TraitEnum.PrivilegedSlave),
			ProperName = "Privileged Slave",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/privileged-slave-kaoling"),
			Description = "You gain a +1 trait bonus on Bluff checks, and Bluff becomes a class skill for you.)",
		},
		#endregion

		#region Prospector
		new Trait
		{
			Name = nameof(TraitEnum.Prospector),
			ProperName = "Prospector",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/shenmen-prospector-shenmen"),
			Description = "You gain a +1 trait bonus on Appraise and Knowledge (dungeoneering) checks.)",
		},
		#endregion

		#region Purchased Loyalty
		new Trait
		{
			Name = nameof(TraitEnum.PurchasedLoyalty),
			ProperName = "Purchased Loyalty",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/purchased-loyalty-regional-druma"),
			Description = "Once per day, when protecting someone who has bought your services, you may roll twice when making a Will save against charm effects and take the better result.)",
		},
		#endregion

		#region Pure Legion Recruit
		new Trait
		{
			Name = nameof(TraitEnum.PureLegionRecruit),
			ProperName = "Pure Legion Recruit",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/pure-legion-recruit"),
			Description = "You gain a +2 trait bonus on Perception checks to see through disguises and mundane attempts to conceal religious iconography or dress. You also gain a +2 trait bonus on Sense Motive checks to see through lies about a target's religious beliefs and to understand secret messages relating to the gods.)",
		},
		#endregion

		#region Quick Reactor
		new Trait
		{
			Name = nameof(TraitEnum.QuickReactor),
			ProperName = "Quick Reactor",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/xa-hoi-soldier-xa-hoi"),
			Description = "You gain a +1 trait bonus on Reflex saving throws.)",
		},
		#endregion

		#region Rabble Rebel
		new Trait
		{
			Name = nameof(TraitEnum.RabbleRebel),
			ProperName = "Rabble Rebel",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/rabble-rebel-galt"),
			Description = "If you have at least three allies threatening your opponent, you gain a +2 bonus on Bluff checks to feint him and a +2 bonus on Sleight of Hand checks against him.)",
		},
		#endregion

		#region Rebel Leader
		new Trait
		{
			Name = nameof(TraitEnum.RebelLeader),
			ProperName = "Rebel Leader",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/rebel-leader-shokuro"),
			Description = "If you take the Leadership feat, you receive a +1 trait bonus to your Leadership score.)",
		},
		#endregion

		#region Reformed Acolyte
		new Trait
		{
			Name = nameof(TraitEnum.ReformedAcolyte),
			ProperName = "Reformed Acolyte",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/acolyte-of-razmir-regional-razmiran"),
			Description = "You gain a +1 trait bonus on Knowledge (local) and Knowledge (religion) checks, and one of these skills is always a class skill for you. This bonus increases to +2 when dealing with specifics of a specific faith.)",
		},
		#endregion

		#region Regional Influence
		new Trait
		{
			Name = nameof(TraitEnum.RegionalInfluence),
			ProperName = "Regional Influence",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/regional-influence-varisia"),
			Description = "You gain a +1 trait bonus on checks with one Profession skill and one of the following benefits:  a) Gain Infernal as a bonus language. If you already have this language, gain a +1 trait bonus on Diplomacy checks. b) Gain a +1 trait bonus on Swim checks.)",
		},
		#endregion

		#region Regional Recluse
		new Trait
		{
			Name = nameof(TraitEnum.RegionalRecluse),
			ProperName = "Regional Recluse",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/regional-recluse-varisia"),
			Description = "You gain a +1 trait bonus on Survival checks and one of the following benefits.  a) Gain a +1 trait bonus on Perception checks made at night. b) Gain proficiency with light shields. c) Gain Gnome as a bonus language. If you already have this language, gain a +1 trait bonus on Stealth checks made in forested areas. d) Gain a +1 bonus to damage on all attacks against creatures of the giant type. e) Gain Orc as a bonus language. If you already know this language, gain a +1 trait bonus on Intimidate checks)",
		},
		#endregion

		#region Region's Finest
		new Trait
		{
			Name = nameof(TraitEnum.RegionsFinest),
			ProperName = "Regions Finest",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/lingshen-s-finest-lingshen"),
			Description = "You gain a +1 trait bonus on all rolls to confirm critical hits.)",
		},
		#endregion

		#region Resilient
		new Trait
		{
			Name = nameof(TraitEnum.Resilient),
			ProperName = "Resilient",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/jungle-resilience-nagajor"),
			Description = "You gain a +2 trait bonus on Fortitude saving throws against poison effects.)",
		},
		#endregion

		#region Resolute
		new Trait
		{
			Name = nameof(TraitEnum.Resolute),
			ProperName = "Resolute",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/secret-revolutionary-regional-cheliax"),
			Description = "You gain a +1 trait bonus on Will saving throws against mind-affecting effects, and on Fortitude saving throws against drugs or poisons.)",
		},
		#endregion

		#region Rice Runner
		new Trait
		{
			Name = nameof(TraitEnum.RiceRunner),
			ProperName = "Rice Runner",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/rice-runner-wanshou"),
			Description = "You gain a +1 trait bonus on Acrobatics checks, and Acrobatics becomes a class skill for you.)",
		},
		#endregion

		#region Riverfolk
		new Trait
		{
			Name = nameof(TraitEnum.Riverfolk),
			ProperName = "Riverfolk",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.RiverLands,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/riverfolk-regional-river-kingdoms"),
			Description = "You gain a +2 trait bonus on Profession (sailor) checks and any skill checks involving rope use.)",
		},
		#endregion

		#region River Rat
		new Trait
		{
			Name = nameof(TraitEnum.RiverRat),
			ProperName = "River Rat",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.MarshorRiver,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/river-rat"),
			Description = "You gain a +1 trait bonus to damage dealt with a dagger and a +1 trait bonus to Swim checks. Swim is always a class skill for you.)",
		},
		#endregion

		#region Savage Breaker
		new Trait
		{
			Name = nameof(TraitEnum.SavageBreaker),
			ProperName = "Savage Breaker",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/savage-breaker-korvosa"),
			Description = "You gain a +2 trait bonus on combat maneuver checks made to sunder simple or primitive armor and weapons, or any other equipment the GM deems “barbarian-made.”)",
		},
		#endregion

		#region Savannah Child
		new Trait
		{
			Name = nameof(TraitEnum.SavannahChild),
			ProperName = "Savannah Child",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Plains,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/savannah-child"),
			Description = "Pick one of the following skills: Handle Animal, Knowledge (nature), or Ride. You gain a +1 trait bonus on that skill, and it is always a class skill for you.)",
		},
		#endregion

		#region Seafarer
		new Trait
		{
			Name = nameof(TraitEnum.Seafarer),
			ProperName = "Seafarer",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Islands,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/shackles-seafarer-regional-the-shackles"),
			Description = "You gain a +1 trait bonus on Knowledge (nature) and Knowledge (geography) checks while on the ocean. You also gain a +1 trait bonus on Swim checks, and Swim is always a class skill for you.)",
		},
		#endregion

		#region Seasoned Climber
		new Trait
		{
			Name = nameof(TraitEnum.SeasonedClimber),
			ProperName = "Seasoned Climber",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/seasoned-climber-the-wall-of-heaven"),
			Description = "You gain a +1 trait bonus on Climb checks, and Climb becomes a class skill for you.)",
		},
		#endregion

		#region Sea-Souled
		new Trait
		{
			Name = nameof(TraitEnum.SeaSouled),
			ProperName = "Sea-Souled",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.CoastlineorIsland,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/sea-souled"),
			Description = "You receive a +1 trait bonus on Swim checks, and you can always take 10 while Swimming.)",
		},
		#endregion

		#region Secret Cultist
		new Trait
		{
			Name = nameof(TraitEnum.SecretCultist),
			ProperName = "Secret Cultist",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/rahadoumi-cultist-regional-rahadoum"),
			Description = "You gain a +5 trait bonus on Bluff checks to receive secret messages, and a +5 trait bonus on Sense Motive checks to intercept secret messages from others of your faith.)",
		},
		#endregion

		#region Shadowcaster
		new Trait
		{
			Name = nameof(TraitEnum.Shadowcaster),
			ProperName = "Shadowcaster",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/nidalese-shadowcaster-regional-nidal"),
			Description = "Choose one spell with the shadow descriptor—from this point on, whenever you cast this spell, its effect manifest at +1 caster level.)",
		},
		#endregion

		#region Shadowsight
		new Trait
		{
			Name = nameof(TraitEnum.Shadowsight),
			ProperName = "Shadowsight",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/shadowsight-regional"),
			Description = "As a swift action once per day, your eyes can pierce the surrounding darkness—you gain the benefit of low-light vision for a number of rounds equal to your level.)",
		},
		#endregion

		#region Signaler
		new Trait
		{
			Name = nameof(TraitEnum.Signaler),
			ProperName = "Signaler",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/signaler-regional-molthune"),
			Description = "You gain a +5 trait bonus on Bluff checks to receive secret messages and a +5 trait bonus on Sense Motive checks to intercept messages.)",
		},
		#endregion

		#region Signature Spell
		new Trait
		{
			Name = nameof(TraitEnum.SignatureSpell),
			ProperName = "Signature Spell",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/secret-of-the-impossible-kingdom-regional-jalmeray"),
			Description = "Pick one spell when you choose this trait—from this point on, whenever you cast that spell, you do so at +1 caster level.)",
		},
		#endregion

		#region Silent Hunter
		new Trait
		{
			Name = nameof(TraitEnum.SilentHunter),
			ProperName = "Silent Hunter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/uskwood-hunter-regional-nidal"),
			Description = "You gain a +1 trait bonus on Stealth checks, and Stealth is always a class skill for you.)",
		},
		#endregion

		#region Silent Watcher
		new Trait
		{
			Name = nameof(TraitEnum.SilentWatcher),
			ProperName = "Silent Watcher",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/silent-watcher-regional-galt"),
			Description = "You gain a +1 trait bonus on Sense Motive checks in crowds, and a +1 trait bonus on Stealth checks in city streets.)",
		},
		#endregion

		#region Silvertongued
		new Trait
		{
			Name = nameof(TraitEnum.Silvertongued),
			ProperName = "Silvertongued",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/silvertongued-eunuch-quain"),
			Description = "You gain a +1 trait bonus on Knowledge (nobility) and Diplomacy checks.)",
		},
		#endregion

		#region Skymetal Affinity
		new Trait
		{
			Name = nameof(TraitEnum.SkymetalAffinity),
			ProperName = "Skymetal Affinity",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +2 trait bonus on Fortitude saves against the negative effects of skymetals, as well as a +2 trait bonus on Craft checks made to create weapons or armor out of skymetals.)",
		},
		#endregion

		#region Sky Spirit Worshiper
		new Trait
		{
			Name = nameof(TraitEnum.SkySpiritWorshiper),
			ProperName = "Sky Spirit Worshiper",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/sky-spirit-worshiper-shaguang"),
			Description = "You gain a +2 trait bonus on saving throws against fear effects.)",
		},
		#endregion

		#region Slayer of the Deep
		new Trait
		{
			Name = nameof(TraitEnum.SlayeroftheDeep),
			ProperName = "Slayer of the Deep",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/slayer-of-the-deep"),
			Description = "You gain a +1 trait bonus on damage rolls made against creatures of the aberration type.)",
		},
		#endregion

		#region Smuggler
		new Trait
		{
			Name = nameof(TraitEnum.Smuggler),
			ProperName = "Smuggler",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/undermarket-smuggler-goka"),
			Description = "You gain a +1 trait bonus on Bluff and Sleight of Hand checks.)",
		},
		#endregion

		#region Snake Bleeder
		new Trait
		{
			Name = nameof(TraitEnum.SnakeBleeder),
			ProperName = "Snake Bleeder",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/snake-bleeder-nagajor"),
			Description = "You gain a +2 trait bonus on Craft (alchemy) checks when brewing poisons, and Craft (alchemy) becomes a class skill for you.)",
		},
		#endregion

		#region Snowstride
		new Trait
		{
			Name = nameof(TraitEnum.Snowstride),
			ProperName = "Snowstride",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.ColdMountains,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/snowstride-usually-under-cold-mountains"),
			Description = "You gain a +1 trait bonus on Acrobatics checks made on slippery surfaces and enables you to trip or bull rush opponents two size categories larger than you instead of just one.)",
		},
		#endregion

		#region Soldier of the Faith
		new Trait
		{
			Name = nameof(TraitEnum.SoldieroftheFaith),
			ProperName = "Soldier of the Faith",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/soldier-of-the-faith-regional-razmiran"),
			Description = "You gain a +1 trait bonus on Intimidate checks, and Intimidate is always a class skill for you.)",
		},
		#endregion

		#region Solidarity (City of Brass)
		new Trait
		{
			Name = nameof(TraitEnum.SolidarityCityofBrass),
			ProperName = "Solidarity (City of Brass)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/solidarity-city-of-brass"),
			Description = "Any time you successfully use the aid another action to help an ally succeed at a Bluff or Escape Artist check, you add a +3 bonus to this check (rather than a +2 bonus).)",
		},
		#endregion

		#region Sound of Mind
		new Trait
		{
			Name = nameof(TraitEnum.SoundofMind),
			ProperName = "Sound of Mind",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("https://sites.google.com/site/pathfinderogc/traits/regional-traits/sound-of-mind-zi-ha"),
			Description = "You gain a +2 trait bonus on saving throws against mind-affecting effects.)",
		},
		#endregion

		#region Spell Duel Prodigy
		new Trait
		{
			Name = nameof(TraitEnum.SpellDuelProdigy),
			ProperName = "Spell Duel Prodigy",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("https://sites.google.com/site/pathfinderogc/traits/regional-traits/spell-duel-prodigy-regional"),
			Description = "You gain a +2 trait bonus on Spellcraft checks to identify a spell as it is being cast and on dispel checks to counterspell a spell.)",
		},
		#endregion

		#region Spellpiercer
		new Trait
		{
			Name = nameof(TraitEnum.Spellpiercer),
			ProperName = "Spellpiercer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/abendego-spellpiercer-regional-the-sodden-lands"),
			Description = "You gain a +2 trait bonus on concentration checks when spellcasting.)",
		},
		#endregion

		#region Spiritual Forester
		new Trait
		{
			Name = nameof(TraitEnum.SpiritualForester),
			ProperName = "Spiritual Forester",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Forests,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/spiritual-forester-the-forest-of-spirits"),
			Description = "You gain a +1 trait bonus on Knowledge (nature) and Knowledge (planes) checks, and one of these skills becomes a class skill for you.)",
		},
		#endregion

		#region Stable
		new Trait
		{
			Name = nameof(TraitEnum.Stable),
			ProperName = "Stable",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/log-roller-forest"),
			Description = "You gain a +1 trait bonus on Acrobatics checks and a +1 trait bonus to your CMB when attempting to resist trip attacks.)",
		},
		#endregion

		#region Storm Hunter
		new Trait
		{
			Name = nameof(TraitEnum.StormHunter),
			ProperName = "Storm Hunter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/storm-hunter-hongal"),
			Description = "When fighting in windy weather, you treat the wind category as one level lower for the purposes of determining penalties on ranged attacks made with normal weapons.)",
		},
		#endregion

		#region Storm Pilot
		new Trait
		{
			Name = nameof(TraitEnum.StormPilot),
			ProperName = "Storm Pilot",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/storm-pilot"),
			Description = "You gain a +2 trait bonus on Profession  (sailor) checks, and you treat the wind force of environmental wind effects (see Table: Wind Effects) as one step less powerful for the purposes of determining any penalties on ranged attacks and Fly checks as well as whether you would be checked or blown away.)",
		},
		#endregion

		#region Stormrunner
		new Trait
		{
			Name = nameof(TraitEnum.Stormrunner),
			ProperName = "Stormrunner",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Islands,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/stormrunner-regional-the-shackles"),
			Description = "You’re accustomed to the pitch and yaw of sailing vessels, even in a storm, and gain a +2 trait bonus on Acrobatics checks to keep your footing on uneven ground or unsteady surfaces.)",
		},
		#endregion

		#region Stream Nomad
		new Trait
		{
			Name = nameof(TraitEnum.StreamNomad),
			ProperName = "Stream Nomad",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Rivers,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/stream-nomad-usually-under-rivers"),
			Description = "You gain a +1 trait bonus on Swim checks, and Swim is always a class skill for you. You increase the speed of any raft, barge, keelboat, or rowboat you pilot by 4 miles per day (1/2 mile per hour).)",
		},
		#endregion

		#region Suck In Your Gut
		new Trait
		{
			Name = nameof(TraitEnum.SuckInYourGut),
			ProperName = "Suck In Your Gut",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/suck-in-your-gut-any"),
			Description = "You're able to move normally when squeezing and take only a –2 penalty on attack rolls and to AC.)",
		},
		#endregion

		#region Sun Orchid Harvester
		new Trait
		{
			Name = nameof(TraitEnum.SunOrchidHarvester),
			ProperName = "Sun Orchid Harvester",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Grasslands,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/sun-orchid-harvester-grasslands"),
			Description = "You gain a +1 bonus on Knowledge (nature) and Survival checks made in desert environments.)",
		},
		#endregion

		#region Superstitious
		new Trait
		{
			Name = nameof(TraitEnum.Superstitious),
			ProperName = "Superstitious",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Northlands,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/superstitious-regional-realm-of-the-mammoth-lords"),
			Description = "As long as you do not possess any levels in a class that grants arcane spellcasting power, you gain a +1 trait bonus on all saving throws against arcane spells.)",
		},
		#endregion

		#region Superstitious Ward
		new Trait
		{
			Name = nameof(TraitEnum.SuperstitiousWard),
			ProperName = "Superstitious Ward",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/superstitious-ward-regional-ustalav"),
			Description = "You may cast disrupt undead once per day as a spell-like ability. This is cast at your highest caster level gained; if you have no caster level, it functions at CL 1st.)",
		},
		#endregion

		#region Surface Stranger
		new Trait
		{
			Name = nameof(TraitEnum.SurfaceStranger),
			ProperName = "Surface Stranger",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Underground,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/surface-stranger"),
			Description = "Your miss chance for concealment or total concealment due to either mundane or magical darkness decreases by 10%. You are dazzled for 1 round when you are suddenly exposed to bright light.)",
		},
		#endregion

		#region Survivalist
		new Trait
		{
			Name = nameof(TraitEnum.Survivalist),
			ProperName = "Survivalist",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/mana-wastes-survivalist-regional-mana-wastes"),
			Description = "You gain a +1 trait bonus on Fortitude saves.)",
		},
		#endregion

		#region Survivalist
		new Trait
		{
			Name = nameof(TraitEnum.Survivalist),
			ProperName = "Survivalist",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/bellflowertiller"),
			Description = "You gain a +5 trait bonus on all Survival skill checks made to get along in the wild, travel in severe weather, keep from getting lost, or predict the weather.)",
		},
		#endregion

		#region Survivor
		new Trait
		{
			Name = nameof(TraitEnum.Survivor),
			ProperName = "Survivor",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/survivor"),
			Description = "You gain a +1 trait bonus to initiative and Sense Motive checks. Sense Motive is always a class skill for you.)",
		},
		#endregion

		#region Swamp Rebel
		new Trait
		{
			Name = nameof(TraitEnum.SwampRebel),
			ProperName = "Swamp Rebel",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/swamp-rebel-wanshou"),
			Description = "You gain a +2 trait bonus on Stealth checks in swampy terrain, and Stealth becomes a class skill for you.)",
		},
		#endregion

		#region Swamp Survivor
		new Trait
		{
			Name = nameof(TraitEnum.SwampSurvivor),
			ProperName = "Swamp Survivor",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Marshlands,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/swamp-survivor-marshlands"),
			Description = "You gain a +2 bonus on Survival checks to find fresh water, and magical liquids in your possession gain a +2 bonus on Will saves to avoid being corrupted or otherwise spoiled.)",
		},
		#endregion

		#region Swordsman's Page
		new Trait
		{
			Name = nameof(TraitEnum.SwordsmansPage),
			ProperName = "Swordsmans Page",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/swordlord-s-page-regional-brevoy"),
			Description = "You gain a +1 attack bonus to confirm critical hits when using an edged weapon you are proficient with.)",
		},
		#endregion

		#region Talented Blacksmith
		new Trait
		{
			Name = nameof(TraitEnum.TalentedBlacksmith),
			ProperName = "Talented Blacksmith",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/indentured-blacksmith-kaoling"),
			Description = "Choose Craft (armor) or Craft (weapons). You gain a +1 trait bonus on the chosen skill, and it becomes a class skill for you.)",
		},
		#endregion

		#region Tattooed Wanderer
		new Trait
		{
			Name = nameof(TraitEnum.TattooedWanderer),
			ProperName = "Tattooed Wanderer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/varisian-wanderer-regional-varisia"),
			Description = "Choose Perform (one type), Profession (fortuneteller), or Sleight of Hand. You gain a +1 trait bonus on this skill, and it is always a class skill for you.)",
		},
		#endregion

		#region Tattooed Wanderer
		new Trait
		{
			Name = nameof(TraitEnum.TattooedWanderer),
			ProperName = "Tattooed Wanderer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/varisian-wanderer-regional-varisia"),
			Description = "You gain a +1 trait bonus on Stealth checks. This trait bonus increases to +2 in hilly or rocky areas.)",
		},
		#endregion

		#region Technic Tinkerer
		new Trait
		{
			Name = nameof(TraitEnum.TechnicTinkerer),
			ProperName = "Technic Tinkerer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/technic-tinkerer-regional-numeria"),
			Description = "Choose a 0-level spell. You may cast that spell once per day as a spell-like ability. This is cast at your highest caster level gained; if you have no caster level, it functions at CL 1st.)",
		},
		#endregion

		#region Temple Guard
		new Trait
		{
			Name = nameof(TraitEnum.TempleGuard),
			ProperName = "Temple Guard",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/tianjing-temple-guard-tianjing"),
			Description = "You gain a +1 trait bonus on attacks of opportunity made with polearm weapons.)",
		},
		#endregion

		#region Thoughtful Wish-Maker (Plane of Fire)
		new Trait
		{
			Name = nameof(TraitEnum.ThoughtfulWishMakerPlaneofFire),
			ProperName = "Thoughtful Wish-Maker (Plane of Fire)",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/thoughtful-wish-maker-plane-of-fire"),
			Description = "You gain a +2 trait bonus on Sense Motive checks. Furthermore, if you succeed at a DC 25 Sense Motive check prior to making any wish granted by an outsider, you become aware of your wish's potential pitfalls. If you succeed at this check by 5 or more, you figure out how to word your wish in such a way that your words are not twisted.)",
		},
		#endregion

		#region Tiger Brigadier
		new Trait
		{
			Name = nameof(TraitEnum.TigerBrigadier),
			ProperName = "Tiger Brigadier",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/tiger-brigadier-bachuan"),
			Description = "You gain a +2 trait bonus on Intimidate checks made against anyone whose age is one or more aging steps above yours, and Intimidate becomes a class skill for you.)",
		},
		#endregion

		#region Touched of the Gods
		new Trait
		{
			Name = nameof(TraitEnum.TouchedoftheGods),
			ProperName = "Touched of the Gods",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/touched-by-the-sky-regional-numeria"),
			Description = "You have the ability to stabilize a dying creature with a touch as a standard action.)",
		},
		#endregion

		#region Town Gossip
		new Trait
		{
			Name = nameof(TraitEnum.TownGossip),
			ProperName = "Town Gossip",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/town-gossip-varisia"),
			Description = "Choose a community that you've lived in for at least 5 years. You gain a +2 trait bonus on Diplomacy checks while in that community.)",
		},
		#endregion

		#region Trained Medic
		new Trait
		{
			Name = nameof(TraitEnum.TrainedMedic),
			ProperName = "Trained Medic",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/venicaan-medic"),
			Description = "You gain a +2 trait bonus to Heal checks to treat diseases or poisons, and Heal is always a class skill for you.)",
		},
		#endregion

		#region Trap Savvy
		new Trait
		{
			Name = nameof(TraitEnum.TrapSavvy),
			ProperName = "Trap Savvy",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/trap-savvy-any"),
			Description = "You gain a +1 trait bonus on Craft (traps) checks, and gain a +1 bonus to AC against attacks by traps or on saving throws against effects created by traps.)",
		},
		#endregion

		#region Traveling Merchant
		new Trait
		{
			Name = nameof(TraitEnum.TravelingMerchant),
			ProperName = "Traveling Merchant",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/thuvian-merchant-regional-thuvia"),
			Description = "You gain a +1 trait bonus on Appraise, Bluff, and Sense Motive checks made for business deals and transactions.)",
		},
		#endregion

		#region Triaxian Tradition
		new Trait
		{
			Name = nameof(TraitEnum.TriaxianTradition),
			ProperName = "Triaxian Tradition",
			TraitType = TraitTypeEnum.Basic,
			Description = "Choose disease or cold. You gain a +2 trait bonus on saves against spells and spell-like abilities with the chosen descriptor. If you choose disease, you gain the bonus on Fortitude saves against non-magical diseases as well.)",
		},
		#endregion

		#region Tribesman
		new Trait
		{
			Name = nameof(TraitEnum.Tribesman),
			ProperName = "Tribesman",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/shoanti-tribesman-regional-varisia"),
			Description = "Choose Climb, Survival, or Swim. You gain a +1 trait bonus on this skill, and it is always a class skill for you.)",
		},
		#endregion

		#region True Believer
		new Trait
		{
			Name = nameof(TraitEnum.TrueBeliever),
			ProperName = "True Believer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/kwanlai-believer-kwanlai"),
			Description = "You gain a +2 trait bonus on concentration checks when casting divine spells.)",
		},
		#endregion

		#region Tundra Child
		new Trait
		{
			Name = nameof(TraitEnum.TundraChild),
			ProperName = "Tundra Child",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.TundraorColdRegions,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/tundra-child"),
			Description = "You gain a +4 trait bonus on saving throws made to resist the effects of being in cold conditions and a +1 trait bonus on saving throws against cold effects.)",
		},
		#endregion

		#region Underworld Explorer
		new Trait
		{
			Name = nameof(TraitEnum.UnderworldExplorer),
			ProperName = "Underworld Explorer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/underworld-explorer"),
			Description = "You gain a +1 trait bonus on Knowledge (dungeoneering) checks, and a +1 trait bonus on Survival checks made in a specific area. One of these skills becomes class skill for you.)",
		},
		#endregion

		#region Unflinching Faith
		new Trait
		{
			Name = nameof(TraitEnum.UnflinchingFaith),
			ProperName = "Unflinching Faith",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/unflinching-faith"),
			Description = "Once per day, you may reroll a Will saving throw made against an attack or effect that originates from an undead creature. You must decide to use this trait after the first saving throw is rolled, but before the results are revealed. You must take the result of the second roll, even if it is lower.)",
		},
		#endregion

		#region Urchin
		new Trait
		{
			Name = nameof(TraitEnum.Urchin),
			ProperName = "Urchin",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/trait-regional-nightstall-urchin"),
			Description = "You gain a +2 trait bonus on saving throws against fear effects, and when you do make a successful save against a fear effect, the resulting rush of bravado grants you a +1 trait bonus on attack rolls and all skill checks for the next minute.)",
		},
		#endregion

		#region Vagabond Child
		new Trait
		{
			Name = nameof(TraitEnum.VagabondChild),
			ProperName = "Vagabond Child",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Urban,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/vagabond-child"),
			Description = "Select one of the following skills: Disable Device or Sleight of Hand. You gain a +1 trait bonus on that skill, and it is always a class skill for you.)",
		},
		#endregion

		#region Veteran Jungle Guide
		new Trait
		{
			Name = nameof(TraitEnum.VeteranJungleGuide),
			ProperName = "Veteran Jungle Guide",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Jungle,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/valashmai-veteran-the-valashmai-jungle"),
			Description = "You gain a +1 trait bonus on Perception checks, and a +1 trait bonus on Survival checks in jungle terrain. One of these skills becomes a class skill for you.)",
		},
		#endregion

		#region Viking Blood
		new Trait
		{
			Name = nameof(TraitEnum.VikingBlood),
			ProperName = "Viking Blood",
			TraitType = TraitTypeEnum.Basic,
			Terrain = TerrainEnum.Northlands,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/viking-blood-regional-lands-of-the-linnorm-kings"),
			Description = "You gain a +1 trait bonus on Intimidate checks, and Intimidate is always a class skill for you.)",
		},
		#endregion

		#region Void Child
		new Trait
		{
			Name = nameof(TraitEnum.VoidChild),
			ProperName = "Void Child",
			TraitType = TraitTypeEnum.Basic,
			Description = "You gain a +1 trait bonus on saves against fear; this bonus increases to +2 whenever you are 30 feet or farther from your nearest ally.)",
		},
		#endregion

		#region Walking Ward
		new Trait
		{
			Name = nameof(TraitEnum.WalkingWard),
			ProperName = "Walking Ward",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/walking-ward-Regional-Qadira"),
			Description = "Choose one of the following energy types: acid, cold, electricity, or fire; you gain a +1 bonus on saving throws against spells that deal damage of this type or have this subtype.)",
		},
		#endregion

		#region Wardbreaker
		new Trait
		{
			Name = nameof(TraitEnum.Wardbreaker),
			ProperName = "Wardbreaker",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/wardbreaker-regional"),
			Description = "Once per day, you can attempt a melee touch attack against an opponent that you believe has a deflection bonus to AC. If your attack is successful, your foe's deflection bonus to AC is halved (to a minimum of +0) for a number of rounds equal to your Charisma modifier. You can use this ability twice per day at 10th level and three times per day at 20th level.)",
		},
		#endregion

		#region Warrior Poet
		new Trait
		{
			Name = nameof(TraitEnum.WarriorPoet),
			ProperName = "Warrior Poet",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/warrior-poet-dwarf-regional-trait"),
			Description = "You gain a +1 trait bonus on Knowledge checks related to dwarves (dwarven history, dwarven construction, and so on) and a +1 trait bonus on Fortitude saves in any round in which you use a bardic performance ability.)",
		},
		#endregion

		#region Wastes Explorer
		new Trait
		{
			Name = nameof(TraitEnum.WastesExplorer),
			ProperName = "Wastes Explorer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/mutabi-qi-explorer-shaguang"),
			Description = "You gain a +1 trait bonus on Knowledge (geography) checks and Survival checks made in the desert.)",
		},
		#endregion

		#region Wayang Spellhunter
		new Trait
		{
			Name = nameof(TraitEnum.WayangSpellhunter),
			ProperName = "Wayang Spellhunter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/wayang-spellhunter-minata"),
			Description = "Choose a spell of 3rd level or below. When you use the chosen spell with a metamagic feat, it uses up a spell slot one level lower than it normally would (does not reduce actual spell level.))",
		},
		#endregion

		#region Well Bred
		new Trait
		{
			Name = nameof(TraitEnum.WellBred),
			ProperName = "Well Bred",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/well-bred"),
			Description = "You gain a +1 trait bonus on Knowledge (history) and Knowledge (religion) checks but take a –1 penalty on all Sense Motive checks.)",
		},
		#endregion

		#region Wharf Rat
		new Trait
		{
			Name = nameof(TraitEnum.WharfRat),
			ProperName = "Wharf Rat",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/wharf-rat"),
			Description = "You gain a +2 trait bonus on skill checks involving climbing and rope use, and a +4 trait bonus on Appraise checks to determine the value of large quantities of bulk goods without opening their containers.)",
		},
		#endregion

		#region Whole-Hearted
		new Trait
		{
			Name = nameof(TraitEnum.WholeHearted),
			ProperName = "Whole-Hearted",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/whole-hearted-regional"),
			Description = "You gain a +2 trait bonus on saving throws against charms and compulsions.)",
		},
		#endregion

		#region Winter’s Soul
		new Trait
		{
			Name = nameof(TraitEnum.WintersSoul),
			ProperName = "Winter’s Soul",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/winter-s-soul-regional-irrisen"),
			Description = "You may cast ray of frost once per day as a spell-like ability. This is cast at your highest caster level gained; if you have no caster level, it functions at CL 1st.)",
		},
		#endregion

		#region Winter Warrior
		new Trait
		{
			Name = nameof(TraitEnum.WinterWarrior),
			ProperName = "Winter Warrior",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/winter-warrior-regional-irrisen"),
			Description = "You gain a +1 trait bonus on Stealth and Survival checks in ice- or snow-covered terrain.)",
		},
		#endregion

		#region Woodland Diplomat
		new Trait
		{
			Name = nameof(TraitEnum.WoodlandDiplomat),
			ProperName = "Woodland Diplomat",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/regional-traits/fangwood-diplomat-regional-nirmathas"),
			Description = "You gain a +1 trait bonus on Diplomacy checks, and Diplomacy is always a class skill for you.)",
		},
		#endregion


		#endregion

		#region Religion

		#region Affinity of the Elements
		new Trait
		{
			Name = nameof(TraitEnum.AffinityoftheElements),
			ProperName = "Affinity of the Elements",
			TraitType = TraitTypeEnum.Basic,
			Description = "The DC of saving throws to resist spells cast by you that have either the air, earth, fire, or water descriptor, is increased by +1. The type of element depends on which elemental lord you worship. Which bonus you receive is chosen when you take the trait and may not be changed.)",
		},
		#endregion

		#region Agent of Chance
		new Trait
		{
			Name = nameof(TraitEnum.AgentofChance),
			ProperName = "Agent of Chance",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/agent-of-chance-nivi-rhombodazzle"),
			Description = "Once a day, when an adjacent ally makes a skill check and doesn’t like the result, you can allow him a reroll as an immediate action. Your ally must take the result of the reroll, even if it is worse than the original roll.)",
		},
		#endregion

		#region Alluring
		new Trait
		{
			Name = nameof(TraitEnum.Alluring),
			ProperName = "Alluring",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/alluring-bolka"),
			Description = "You receive a +2 trait bonus on Diplomacy checks with those who find you attractive. You can use daze once per day as a spell-like ability, with a caster level equal to your character level.)",
		},
		#endregion

		#region Ambassador
		new Trait
		{
			Name = nameof(TraitEnum.Ambassador),
			ProperName = "Ambassador",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/ambassador-sun-goddess"),
			Description = "You gain a +2 trait bonus to Diplomacy checks.)",
		},
		#endregion

		#region Arcane Depth
		new Trait
		{
			Name = nameof(TraitEnum.ArcaneDepth),
			ProperName = "Arcane Depth",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/arcane-depth-nethys"),
			Description = "You gain a bonus of either +1 on Spellcraft checks or +2 on Knowledge (arcana) checks. Which bonus you receive is chosen when you take the trait and may not be changed.)",
		},
		#endregion

		#region A Shining Beacon
		new Trait
		{
			Name = nameof(TraitEnum.AShiningBeacon),
			ProperName = "A Shining Beacon",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/a-shining-beacon-iomedae"),
			Description = "You deal additional damage equal to your weapon’s critical hit modifier when you score a successful critical hit with a weapon on a demon. This damage is added only after the damage is totaled, and is not multiplied by the critical hit multiple.)",
		},
		#endregion

		#region Backstabber
		new Trait
		{
			Name = nameof(TraitEnum.Backstabber),
			ProperName = "Backstabber",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/backstabber"),
			Description = "When you hit a foe you are flanking, you deal an additional 1 point of damage (this damage is added to your base damage, and is multiplied on a critical hit). This additional damage is a trait bonus.)",
		},
		#endregion

		#region Battlefield Caster
		new Trait
		{
			Name = nameof(TraitEnum.BattlefieldCaster),
			ProperName = "Battlefield Caster",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/battlefield-caster"),
			Description = "You receive a +1 trait bonus on concentration checks to cast defensively and a +1 trait bonus to AC against attacks provoked by or readied against spellcasting.)",
		},
		#endregion

		#region Battlefield Surgeon
		new Trait
		{
			Name = nameof(TraitEnum.BattlefieldSurgeon),
			ProperName = "Battlefield Surgeon",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/battlefield-surgeon-zon-kuthon"),
			Description = "Heal is always a class skill for you, and you can use the treat deadly wounds aspect of the skill 1 additional time per creature per day.)",
		},
		#endregion

		#region Blade of Mercy
		new Trait
		{
			Name = nameof(TraitEnum.BladeofMercy),
			ProperName = "Blade of Mercy",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/blade-of-mercy-goddess-of-dawn"),
			Description = "When striking to inflict nonlethal damage with any slashing weapon, you do not take the normal -4 penalty on your attack roll, and gain a +1 trait bonus to any nonlethal damage you inflict with a slashing weapon.)",
		},
		#endregion

		#region Blessing of the Feast
		new Trait
		{
			Name = nameof(TraitEnum.BlessingoftheFeast),
			ProperName = "Blessing of the Feast",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/blessing-of-the-feast"),
			Description = "Whenever you eat the flesh or drink the blood of another creature of your own kind—a full-round action that provokes attacks of opportunity— you gain the favor of your god or goddess and receive a +1 natural armor bonus for 1 minute/level. You can only receive this benefit once per day.)",
		},
		#endregion

		#region Broken Mind
		new Trait
		{
			Name = nameof(TraitEnum.BrokenMind),
			ProperName = "Broken Mind",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/broken-mind-groetus"),
			Description = "You gain a +2 trait bonus on saving throws against madness and confusion effects.)",
		},
		#endregion

		#region Call for Help
		new Trait
		{
			Name = nameof(TraitEnum.CallforHelp),
			ProperName = "Call for Help",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/call-for-help-chaldira-zuzaristan"),
			Description = "Your allies gain a +1 trait bonus on rolls made against a creature threatening you when you use the total defense action.)",
		},
		#endregion

		#region Centered
		new Trait
		{
			Name = nameof(TraitEnum.Centered),
			ProperName = "Centered",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/centered-irori"),
			Description = "You gain a +1 trait bonus on saving throws against charms and compulsions, and the DC of any attempts to use the Intimidate skill on you increases by +1.)",
		},
		#endregion

		#region Child of Nature
		new Trait
		{
			Name = nameof(TraitEnum.ChildofNature),
			ProperName = "Child of Nature",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/child-of-nature-gozreh"),
			Description = "You gain a +2 trait bonus on Survival checks to find food and water, and a +1 trait bonus on Knowledge (nature) checks. One of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Cleansing Light
		new Trait
		{
			Name = nameof(TraitEnum.CleansingLight),
			ProperName = "Cleansing Light",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/cleansing-light-sarenrae"),
			Description = "When dealing damage to undead with your channel energy, you can reroll any damage die that shows a natural 1.)",
		},
		#endregion

		#region Cleansing the Twisted
		new Trait
		{
			Name = nameof(TraitEnum.CleansingtheTwisted),
			ProperName = "Cleansing the Twisted",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/cleansing-the-twisted-goddess-of-dawn"),
			Description = "You gain a +1 trait bonus to slashing weapon damage against aberrations.)",
		},
		#endregion

		#region Contract Master
		new Trait
		{
			Name = nameof(TraitEnum.ContractMaster),
			ProperName = "Contract Master",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/contract-master"),
			Description = "You gain a +1 trait bonus on Linguistics checks, and it becomes a class skill for you.)",
		},
		#endregion

		#region Corpse Cannibal
		new Trait
		{
			Name = nameof(TraitEnum.CorpseCannibal),
			ProperName = "Corpse Cannibal",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/corpse-cannibal"),
			Description = "You gain a +2 trait bonus on Fortitude saving throws against diseases and can gain sustenance from rotting flesh with no negative side effects.)",
		},
		#endregion

		#region Corpse Hunter
		new Trait
		{
			Name = nameof(TraitEnum.CorpseHunter),
			ProperName = "Corpse Hunter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/corpse-hunter-pharasma"),
			Description = "You receive a +1 trait bonus on all attacks made against undead.)",
		},
		#endregion

		#region Courtesan
		new Trait
		{
			Name = nameof(TraitEnum.Courtesan),
			ProperName = "Courtesan",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/courtesan"),
			Description = "You gain a +1 trait bonus on Sense Motive checks and Diplomacy checks to gather information, and one of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Dawn Renewal
		new Trait
		{
			Name = nameof(TraitEnum.DawnRenewal),
			ProperName = "Dawn Renewal",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/dawn-renewal"),
			Description = "When you use the Heal skill to provide long-term care, your patients heal an extra 2 hit points at sunrise.)",
		},
		#endregion

		#region Deathspeaker
		new Trait
		{
			Name = nameof(TraitEnum.Deathspeaker),
			ProperName = "Deathspeaker",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/deathspeaker-urgathoa"),
			Description = "You gain a +2 trait bonus on Diplomacy checks when dealing with undead, as well as a +2 trait bonus on Charisma checks made to influence undead (such as via the command undead spell).)",
		},
		#endregion

		#region Deck Fighter
		new Trait
		{
			Name = nameof(TraitEnum.DeckFighter),
			ProperName = "Deck Fighter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/deck-fighter-besmara"),
			Description = "You gain a +1 trait bonus on attacks of opportunity when fighting aboard a ship.)",
		},
		#endregion

		#region Defensive Strategist
		new Trait
		{
			Name = nameof(TraitEnum.DefensiveStrategist),
			ProperName = "Defensive Strategist",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/defensive-strategist"),
			Description = "You are not flat-footed when you are an unaware combatant. This includes a surprise round that you don’t get to act in, and before you get to act at the start of a battle.)",
		},
		#endregion

		#region Deformed
		new Trait
		{
			Name = nameof(TraitEnum.Deformed),
			ProperName = "Deformed",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/deformed-lamashtu"),
			Description = "Your deformities grant you a +1 trait bonus on Intimidate checks, and Intimidate becomes a class skill for you.)",
		},
		#endregion

		#region Demon Hunter
		new Trait
		{
			Name = nameof(TraitEnum.DemonHunter),
			ProperName = "Demon Hunter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/asmodean-demon-hunter-ruler-of-hell"),
			Description = "You gain a +3 trait bonus on Knowledge (planes) checks about demons and a +2 trait bonus on Will saving throws against mind-affecting spells and effects from demons.)",
		},
		#endregion

		#region Demonic Persuasion
		new Trait
		{
			Name = nameof(TraitEnum.DemonicPersuasion),
			ProperName = "Demonic Persuasion",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/demonic-persuasion-demon-lords"),
			Description = "You gain a +2 trait bonus on Diplomacy and Intimidate checks when dealing with creatures of the demon subtype.)",
		},
		#endregion

		#region Destructive Blows
		new Trait
		{
			Name = nameof(TraitEnum.DestructiveBlows),
			ProperName = "Destructive Blows",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/destructive-blows-rovagug"),
			Description = "You gain a +2 trait bonus on Strength checks made to break things, as well as on combat maneuver checks to sunder.)",
		},
		#endregion

		#region Devotee of a Dead God
		new Trait
		{
			Name = nameof(TraitEnum.DevoteeofaDeadGod),
			ProperName = "Devotee of a Dead God",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/devotee-of-a-dead-god-a-fallen-god"),
			Description = "You gain a +1 trait bonus on Diplomacy checks and Knowledge (religion) checks. One of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Divine Warrior
		new Trait
		{
			Name = nameof(TraitEnum.DivineWarrior),
			ProperName = "Divine Warrior",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/divine-warrior-goddess-of-valor"),
			Description = "Whenever you cast a divine spell that affects any melee weapons, choose one of those weapons; it gains a +1 trait bonus on damage rolls for the duration of the spell.)",
		},
		#endregion

		#region Ear for Music
		new Trait
		{
			Name = nameof(TraitEnum.EarforMusic),
			ProperName = "Ear for Music",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/ear-for-music-shelyn"),
			Description = "You gain a +1 trait bonus on one category of Perform checks and a +2 trait bonus on Knowledge (local) checks that deal with the local art or music scene.)",
		},
		#endregion

		#region Elven Pantheist
		new Trait
		{
			Name = nameof(TraitEnum.ElvenPantheist),
			ProperName = "Elven Pantheist",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/elven-pantheist-any-elven-deity"),
			Description = "You gain a +1 trait bonus on all Knowledge (religion) skill checks, and Knowledge (religion) is always a class skill for you.)",
		},
		#endregion

		#region Empty Heart, Full Heart
		new Trait
		{
			Name = nameof(TraitEnum.EmptyHeartFullHeart),
			ProperName = "Empty Heart, Full Heart",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/empty-heart-full-heart-naderi"),
			Description = "You gain a +1 trait bonus on all saving throws against charm effects, and any targets of your own charm spells suffer a –1 on their saves.)",
		},
		#endregion

		#region Empyreal Focus
		new Trait
		{
			Name = nameof(TraitEnum.EmpyrealFocus),
			ProperName = "Empyreal Focus",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/empyreal-focus-empyreal-lords"),
			Description = "Once per day, you gain a +2 trait bonus to any one skill check.)",
		},
		#endregion

		#region Eye of the Father
		new Trait
		{
			Name = nameof(TraitEnum.EyeoftheFather),
			ProperName = "Eye of the Father",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/eye-of-the-father"),
			Description = "You gain +1 trait bonus to a Craft skill of your choice, and Perform is always a class skill for you.)",
		},
		#endregion

		#region Eyes and Ears of the City
		new Trait
		{
			Name = nameof(TraitEnum.EyesandEarsoftheCity),
			ProperName = "Eyes and Ears of the City",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/eyes-and-ears-of-the-city-god-of-commerce"),
			Description = "You gain a +1 trait bonus on Perception checks, and Perception is always a class skill for you.)",
		},
		#endregion

		#region Eyes of the Wild
		new Trait
		{
			Name = nameof(TraitEnum.EyesoftheWild),
			ProperName = "Eyes of the Wild",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/eyes-of-the-wild-the-green-faith"),
			Description = "You gain a +2 trait bonus on Perception checks in natural settings.)",
		},
		#endregion

		#region Faithful Artist
		new Trait
		{
			Name = nameof(TraitEnum.FaithfulArtist),
			ProperName = "Faithful Artist",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/faithful-artist"),
			Description = "You gain a +1 trait bonus to one Perform skill, and Perform is always a class skill for you.)",
		},
		#endregion

		#region Faithful of the Dead God
		new Trait
		{
			Name = nameof(TraitEnum.FaithfuloftheDeadGod),
			ProperName = "Faithful of the Dead God",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/faithful-arodenite"),
			Description = "You gain a +1 trait bonus on Diplomacy checks; this bonus increases to +3 if you are dealing with a follower of a dead god.)",
		},
		#endregion

		#region Fatal Trapper
		new Trait
		{
			Name = nameof(TraitEnum.FatalTrapper),
			ProperName = "Fatal Trapper",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/fatal-trapper-zyphus"),
			Description = "You gain a +1 trait bonus on Craft (traps) checks and a +1 trait bonus on Disable Device checks made to disable traps.)",
		},
		#endregion

		#region Fiendish Confidence
		new Trait
		{
			Name = nameof(TraitEnum.FiendishConfidence),
			ProperName = "Fiendish Confidence",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/fiendish-confidence-asmodeus"),
			Description = "You gain a +1 trait bonus on Intimidate checks, and Intimidate becomes a class skill for you.)",
		},
		#endregion

		#region Flame of the Dawn
		new Trait
		{
			Name = nameof(TraitEnum.FlameoftheDawn),
			ProperName = "Flame of the Dawn",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/flame-of-the-dawnflower-sarenrae"),
			Description = "Whenever you score a critical hit with a scimitar, you deal an additional two points of fire damage to your target. If you ever abandon the worship of the associated deity, you immediately lose access to this trait’s benefits.)",
		},
		#endregion

		#region Flounderer
		new Trait
		{
			Name = nameof(TraitEnum.Flounderer),
			ProperName = "Flounderer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/flounderer-zogmugot"),
			Description = "You gain a +1 trait bonus on Swim checks, and can hold your breath for a number of rounds equal to three times your Constitution score before you risk drowning.)",
		},
		#endregion

		#region Fortified Drinker
		new Trait
		{
			Name = nameof(TraitEnum.FortifiedDrinker),
			ProperName = "Fortified Drinker",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/fortified-drinker"),
			Description = "Whenever you imbibe any alcoholic beverage, you gain a +2 trait bonus on saving throws against mind-affecting effects for 1 hour.)",
		},
		#endregion

		#region Good Dreams
		new Trait
		{
			Name = nameof(TraitEnum.GoodDreams),
			ProperName = "Good Dreams",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/good-dreams"),
			Description = "Each time you sleep, the GM tells you of a dangerous dream you had. Once per day, if you have to make a saving throw against a threat related or similar to that dream, you can roll twice and take the more favorable result. If you do not encounter circumstances similar to the threat or situation you dreamed, this trait has no effect that day. If you have the Halfling Jinx racial feature, you cannot select this trait, and vice versa.)",
		},
		#endregion

		#region Good Natured
		new Trait
		{
			Name = nameof(TraitEnum.GoodNatured),
			ProperName = "Good Natured",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/good-natured"),
			Description = "You gain a +2 trait bonus on all saving throws against fear effects.)",
		},
		#endregion

		#region Guardian of the Forge
		new Trait
		{
			Name = nameof(TraitEnum.GuardianoftheForge),
			ProperName = "Guardian of the Forge",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/guardian-of-the-forge"),
			Description = "You receive a +1 trait bonus on Knowledge (engineering) and Knowledge (history) checks. One of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Hatred of the Gods
		new Trait
		{
			Name = nameof(TraitEnum.HatredoftheGods),
			ProperName = "Hatred of the Gods",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/hatred-of-the-gods-rovagug"),
			Description = "You gain a +1 trait bonus on all saving throws against divine spells.)",
		},
		#endregion

		#region Holy Schemer
		new Trait
		{
			Name = nameof(TraitEnum.HolySchemer),
			ProperName = "Holy Schemer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/holy-schemer"),
			Description = "You gain a +1 trait bonus on Sense Motive checks, and it becomes a class skill for you.)",
		},
		#endregion

		#region Honeyed Words
		new Trait
		{
			Name = nameof(TraitEnum.HoneyedWords),
			ProperName = "Honeyed Words",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/honeyed-words"),
			Description = "You receive a +1 trait bonus on Diplomacy checks. In addition, you receive a +1 trait bonus to the DC of any charm or compulsion that does not provide ongoing control and results in peaceful acts, such as calm emotions, sleep, or a suggestion to lay down arms.)",
		},
		#endregion

		#region Honey-Tongued
		new Trait
		{
			Name = nameof(TraitEnum.HoneyTongued),
			ProperName = "Honey-Tongued",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/honey-tongued"),
			Description = "You gain a +1 trait bonus on Diplomacy or Bluff checks when dealing with agents of the law, whether judges, guards, or paladins.)",
		},
		#endregion

		#region Illuminator
		new Trait
		{
			Name = nameof(TraitEnum.Illuminator),
			ProperName = "Illuminator",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/illuminator-sarenrae"),
			Description = "You gain a +2 trait bonus on Diplomacy checks, and Diplomacy is always a class skill for you.)",
		},
		#endregion

		#region Inner Beauty
		new Trait
		{
			Name = nameof(TraitEnum.InnerBeauty),
			ProperName = "Inner Beauty",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/inner-beauty-shelyn"),
			Description = "You gain a +4 trait bonus to a single Bluff, Craft, Diplomacy, or Perform skill check once per day. You can choose whether to use it after making the check.)",
		},
		#endregion

		#region Inoculated
		new Trait
		{
			Name = nameof(TraitEnum.Inoculated),
			ProperName = "Inoculated",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/inoculated-urgathoa"),
			Description = "You gain a +2 trait bonus on saving throws against disease effects.)",
		},
		#endregion

		#region Intense Artist
		new Trait
		{
			Name = nameof(TraitEnum.IntenseArtist),
			ProperName = "Intense Artist",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/intense-artist-shelyn"),
			Description = "You gain a +1 trait bonus on two Perform skills of your choice, and Perform is always a class skill for you.)",
		},
		#endregion

		#region Iron Grip
		new Trait
		{
			Name = nameof(TraitEnum.IronGrip),
			ProperName = "Iron Grip",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/iron-grip-gorrum"),
			Description = "You gain a +2 trait bonus to your CMD vs. disarm maneuvers.)",
		},
		#endregion

		#region Know the Land
		new Trait
		{
			Name = nameof(TraitEnum.KnowtheLand),
			ProperName = "Know the Land",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/know-the-land-the-green-faith"),
			Description = "You gain a +1 trait bonus on Knowledge (nature) and Survival checks, and one of these skills becomes a class skill for you.)",
		},
		#endregion

		#region Loreseeker
		new Trait
		{
			Name = nameof(TraitEnum.Loreseeker),
			ProperName = "Loreseeker",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/loreseeker-lissala"),
			Description = "You gain a +2 trait bonus on Spellcraft checks made to identify magical items.)",
		},
		#endregion

		#region Lover of the Law
		new Trait
		{
			Name = nameof(TraitEnum.LoveroftheLaw),
			ProperName = "Lover of the Law",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/lover-of-the-law"),
			Description = "You gain a +1 trait bonus on saves vs. charm and compulsion spells, and may make a new save with an additional +1 trait bonus (for a total of +2) if directed to act against the law.)",
		},
		#endregion

		#region Magic is Life
		new Trait
		{
			Name = nameof(TraitEnum.MagicisLife),
			ProperName = "Magic is Life",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/magic-is-life-god-of-magic"),
			Description = "As long as you are under the effects of a spell, you gain a +2 trait bonus on saving throws against death effects. If you are reduced to negative hit points while you are under the effects of any spell, you automatically confirm stabilization checks to stop bleeding.)",
		},
		#endregion

		#region Mother's Rage
		new Trait
		{
			Name = nameof(TraitEnum.MothersRage),
			ProperName = "Mothers Rage",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/mother-s-rage"),
			Description = "You receive a +1 trait bonus on Survival checks, and you treat your caster level as +1 higher when summoning creatures.)",
		},
		#endregion

		#region Mother’s Teeth
		new Trait
		{
			Name = nameof(TraitEnum.MothersTeeth),
			ProperName = "Mother’s Teeth",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/mother-s-teeth"),
			Description = "You can make a bite attack for 1d2 points of damage as a secondary attack.)",
		},
		#endregion

		#region Nimble Fingers, Keen Mind
		new Trait
		{
			Name = nameof(TraitEnum.NimbleFingersKeenMind),
			ProperName = "Nimble Fingers, Keen Mind",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/nimble-fingers-keen-mind-brigh"),
			Description = "You gain a +1 trait bonus on Disable Device checks, and Disable Device becomes a class skill for you.)",
		},
		#endregion

		#region Opener of Doors
		new Trait
		{
			Name = nameof(TraitEnum.OpenerofDoors),
			ProperName = "Opener of Doors",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/opener-of-doors-alseta"),
			Description = "You gain a +2 trait bonus on Perception checks made to find and open secret doors.)",
		},
		#endregion

		#region Opportunistic
		new Trait
		{
			Name = nameof(TraitEnum.Opportunistic),
			ProperName = "Opportunistic",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/opportunistic"),
			Description = "You gain a +1 trait bonus on attacks of opportunity when using a dagger, sword, or whip.)",
		},
		#endregion

		#region Pain Is Pleasure
		new Trait
		{
			Name = nameof(TraitEnum.PainIsPleasure),
			ProperName = "Pain Is Pleasure",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/pain-is-pleasure"),
			Description = "You gain a +1 trait bonus on Fortitude and Will saves whenever you have fewer than half your maximum number of hit points.)",
		},
		#endregion

		#region Pantheist
		new Trait
		{
			Name = nameof(TraitEnum.Pantheist),
			ProperName = "Pantheist",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/sovyrian-pantheist-any-elven-deity"),
			Description = "You gain a +1 trait bonus on Knowledge (history) checks to recognize or evaluate art, Knowledge (architecture and engineering) checks, Survival checks to hunt game, Constitution checks to run, and Spellcraft checks involving crystals or gems.)",
		},
		#endregion

		#region Patient Optimist
		new Trait
		{
			Name = nameof(TraitEnum.PatientOptimist),
			ProperName = "Patient Optimist",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/patient-optimist-goddess-of-travel"),
			Description = "You gain a +2 trait bonus on Diplomacy checks to influence hostile or unfriendly creatures, and if you fail at such an attempt you may retry it once.)",
		},
		#endregion

		#region Peacemaker
		new Trait
		{
			Name = nameof(TraitEnum.Peacemaker),
			ProperName = "Peacemaker",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/erastil-s-speaker-erastil"),
			Description = "You gain a +1 trait bonus on Diplomacy checks, and Diplomacy is always a class skill for you.)",
		},
		#endregion

		#region Potent Concoctions
		new Trait
		{
			Name = nameof(TraitEnum.PotentConcoctions),
			ProperName = "Potent Concoctions",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/potent-concoctions-ghlaunder"),
			Description = "Choose any two poisons. When you attempt to inflict either of these poisons on an enemy, the DC to resist it is increased by +1.)",
		},
		#endregion

		#region Practiced Deception
		new Trait
		{
			Name = nameof(TraitEnum.PracticedDeception),
			ProperName = "Practiced Deception",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/practiced-deception-norgorbor"),
			Description = "You gain a +1 trait bonus on Disguise checks, and you can apply and remove a disguise in half the normal time.)",
		},
		#endregion

		#region Propitiation
		new Trait
		{
			Name = nameof(TraitEnum.Propitiation),
			ProperName = "Propitiation",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/propitiation-any-dwarven-deity"),
			Description = "At the start of each day, pick one of the following skills: Appraise, Bluff, Craft (pick one craft skill), Diplomacy, Intimidate, or Knowledge (local). You gain a +2 trait bonus on that skill until the start of the next day.)",
		},
		#endregion

		#region Provider
		new Trait
		{
			Name = nameof(TraitEnum.Provider),
			ProperName = "Provider",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/provider"),
			Description = "You gain a +1 trait bonus on any d20 roll to acquire food or water for others. Though this bonus most often applies to Survival checks, it could also apply to attacking monsters that are safe and nutritious to eat (mainly animals and plants). However, if you abuse this gift (for example, by using the bonus to defeat a bear, then only eating one bite of it), you suffer a –2 penalty on attacks, checks, and saves for 24 hours.)",
		},
		#endregion

		#region Purity of Faith
		new Trait
		{
			Name = nameof(TraitEnum.PurityofFaith),
			ProperName = "Purity of Faith",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/purity-of-faith-iomedae"),
			Description = "You gain +1 trait bonus on Will saves and a +1 bonus on saving throws against spells and effects originating from outsiders with the evil subtype.)",
		},
		#endregion

		#region Resigned
		new Trait
		{
			Name = nameof(TraitEnum.Resigned),
			ProperName = "Resigned",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/resigned"),
			Description = "You gain a +1 trait bonus when retrying a previously failed skill check or ability check, as well as when taking 20 on skill checks and ability checks.)",
		},
		#endregion

		#region Restless Hunger
		new Trait
		{
			Name = nameof(TraitEnum.RestlessHunger),
			ProperName = "Restless Hunger",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/restless-hunger-venkelvore"),
			Description = "If you have a piece of food (or something a goblin might consider food), you can quickly eat it as part of a charge attack once per day. Doing so increases your speed by 10 feet for 1 round.)",
		},
		#endregion

		#region River Freedom
		new Trait
		{
			Name = nameof(TraitEnum.RiverFreedom),
			ProperName = "River Freedom",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/river-freedom-hanspur"),
			Description = "While touching flowing water, you gain a +1 trait bonus on all saving throws against effects that would hamper your movement.)",
		},
		#endregion

		#region Sacred Avenger
		new Trait
		{
			Name = nameof(TraitEnum.SacredAvenger),
			ProperName = "Sacred Avenger",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/sacred-avenger-calistria"),
			Description = "When a creature damages you with a weapon, on your next turn you gain a +1 trait bonus on weapon damage against that creature. If this creature is your nemesis, this bonus increases to +2.)",
		},
		#endregion

		#region Sacred Smasher
		new Trait
		{
			Name = nameof(TraitEnum.SacredSmasher),
			ProperName = "Sacred Smasher",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/sacred-smasher"),
			Description = "You gain a +2 trait bonus on Strength checks to break an object.)",
		},
		#endregion

		#region Scaly Ally
		new Trait
		{
			Name = nameof(TraitEnum.ScalyAlly),
			ProperName = "Scaly Ally",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/scaly-ally-apsu"),
			Description = "You gain a +2 trait bonus on Diplomacy checks involving reptiles or those of draconic blood, whether they are good-aligned or not.)",
		},
		#endregion

		#region Searing Beacon
		new Trait
		{
			Name = nameof(TraitEnum.SearingBeacon),
			ProperName = "Searing Beacon",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/searing-beacon"),
			Description = "You deal additional precision damage equal to your Wisdom modifier when you score a critical hit with a melee weapon against an undead opponent.)",
		},
		#endregion

		#region Second Chance
		new Trait
		{
			Name = nameof(TraitEnum.SecondChance),
			ProperName = "Second Chance",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/lessons-of-chaldira-chaldira-zuzaristan"),
			Description = "Once per day, when you fail a saving throw, you can reroll the saving throw. You must take the second result even if it is worse.)",
		},
		#endregion

		#region Secret Knowledge
		new Trait
		{
			Name = nameof(TraitEnum.SecretKnowledge),
			ProperName = "Secret Knowledge",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/secret-knowledge-norgorbor"),
			Description = "When you initially take this trait, it has no effect. At any point thereafter, before making a check, you may choose one Knowledge skill. You gain a permanent +2 trait bonus on checks for that skill, and it becomes a class skill for you. Once this skill is chosen, it cannot be changed.)",
		},
		#endregion

		#region Seer of Reality
		new Trait
		{
			Name = nameof(TraitEnum.SeerofReality),
			ProperName = "Seer of Reality",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/seer-of-reality-irori"),
			Description = "You gain a +2 trait bonus on any saves involving illusion magic.)",
		},
		#endregion

		#region Self-Sacrifice
		new Trait
		{
			Name = nameof(TraitEnum.SelfSacrifice),
			ProperName = "Self-Sacrifice",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/self-sacrifice"),
			Description = "As a move action, you can use your own body to grant soft cover to an adjacent ally regardless of the difference in your respective sizes.)",
		},
		#endregion

		#region Sense of Order
		new Trait
		{
			Name = nameof(TraitEnum.SenseofOrder),
			ProperName = "Sense of Order",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/sense-of-order"),
			Description = "You gain a +3 trait bonus on any Perception check made to identify any changes to a location that have occurred since you last visited it.)",
		},
		#endregion

		#region Sensing Imperfection
		new Trait
		{
			Name = nameof(TraitEnum.SensingImperfection),
			ProperName = "Sensing Imperfection",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/sensing-imperfection"),
			Description = "Sense Motive is always a class skill for you, and you gain a +1 trait bonus on Sense Motive checks.)",
		},
		#endregion

		#region Serpentine Squeeze
		new Trait
		{
			Name = nameof(TraitEnum.SerpentineSqueeze),
			ProperName = "Serpentine Squeeze",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/serpentine-squeeze-ydersius"),
			Description = "You gain a +1 trait bonus on combat maneuver checks to grapple a foe, as well as a +1 trait bonus to your CMD whenever an opponent tries to grapple you.)",
		},
		#endregion

		#region Shadow Caster
		new Trait
		{
			Name = nameof(TraitEnum.ShadowCaster),
			ProperName = "Shadow Caster",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/kuthite-caster-zon-kuthon"),
			Description = "You gain a +4 trait bonus on concentration checks when casting spells with the darkness, pain, or shadow descriptors.)",
		},
		#endregion

		#region Shadow Whispers
		new Trait
		{
			Name = nameof(TraitEnum.ShadowWhispers),
			ProperName = "Shadow Whispers",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/shadow-whispers"),
			Description = "You gain a +1 trait bonus on Knowledge (local) checks and a +2 trait bonus on Intimidate checks made to demoralize opponents.)",
		},
		#endregion

		#region Spirit Guide
		new Trait
		{
			Name = nameof(TraitEnum.SpiritGuide),
			ProperName = "Spirit Guide",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/spirit-guide-pharasma"),
			Description = "You gain a +2 trait bonus on Knowledge (religion) checks, and Knowledge (religion) becomes class skill for you.)",
		},
		#endregion

		#region Spirit Talker
		new Trait
		{
			Name = nameof(TraitEnum.SpiritTalker),
			ProperName = "Spirit Talker",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/spirit-talker"),
			Description = "You gain a +1 racial bonus on Will saving throws against divine spells and spell-like effects employed against you by clerics or paladins of organized religions—but you suffer a –1 penalty on Will saving throws against divine spells cast by devotees of shamanistic faiths.)",
		},
		#endregion

		#region Starchild
		new Trait
		{
			Name = nameof(TraitEnum.Starchild),
			ProperName = "Starchild",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/starchild"),
			Description = "You can automatically determine where true north is. You gain a +4 trait bonus on Survival checks to avoid becoming lost.)",
		},
		#endregion

		#region Stoic Optimism
		new Trait
		{
			Name = nameof(TraitEnum.StoicOptimism),
			ProperName = "Stoic Optimism",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/stoic-optimism"),
			Description = "You receive a +2 trait bonus on saving throws against fear effects.)",
		},
		#endregion

		#region Strength of the Barghest
		new Trait
		{
			Name = nameof(TraitEnum.StrengthoftheBarghest),
			ProperName = "Strength of the Barghest",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/strength-of-the-barghest-hadregash"),
			Description = "Once per day as a free action, you can gain a +2 trait bonus on any Strength check or Strength-based skill check.)",
		},
		#endregion

		#region Strength of the Sun
		new Trait
		{
			Name = nameof(TraitEnum.StrengthoftheSun),
			ProperName = "Strength of the Sun",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/strength-of-the-sun-goddess-of-dawn"),
			Description = "During the day, you gain a +1 trait bonus on all Charisma-based checks.)",
		},
		#endregion

		#region Strip the Veils
		new Trait
		{
			Name = nameof(TraitEnum.StriptheVeils),
			ProperName = "Strip the Veils",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/strip-the-veils-sivanah"),
			Description = "You gain a +1 trait bonus on Sense Motive checks, and Sense Motive becomes a class skill for you.)",
		},
		#endregion

		#region Strong Heart
		new Trait
		{
			Name = nameof(TraitEnum.StrongHeart),
			ProperName = "Strong Heart",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/strong-heart-gorrum"),
			Description = "You gain a +1 trait bonus on saving throws against fear effects, and the DC of Intimidate checks made against you increases by +2.)",
		},
		#endregion

		#region Strong Swimmer
		new Trait
		{
			Name = nameof(TraitEnum.StrongSwimmer),
			ProperName = "Strong Swimmer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/strong-swimmer-gozreh"),
			Description = "You gain a +2 trait bonus on all Swim checks, and can hold your breath for an extra 2 rounds when underwater.)",
		},
		#endregion

		#region Strong Willed
		new Trait
		{
			Name = nameof(TraitEnum.StrongWilled),
			ProperName = "Strong Willed",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/strong-willed"),
			Description = "You gain a +2 trait bonus on saving throws against charm and compulsion effects.)",
		},
		#endregion

		#region Talented Organizer
		new Trait
		{
			Name = nameof(TraitEnum.TalentedOrganizer),
			ProperName = "Talented Organizer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/talented-organizer-milani"),
			Description = "You gain a +1 trait bonus on Sense Motive skill checks, and Sense Motive is always a class skill for you.)",
		},
		#endregion

		#region The City Protects
		new Trait
		{
			Name = nameof(TraitEnum.TheCityProtects),
			ProperName = "The City Protects",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/the-city-protects-god-of-commerce"),
			Description = "You gain a +2 trait bonus against fear effects. If you fail a save against a fear effect, you may make a new save each round you remain in the city to overcome the fear effect as long as the fear effect persists. If you are a paladin, this ability to make additional saves to overcome fear extends to all allies within your aura of courage.)",
		},
		#endregion

		#region The Flexing Arm
		new Trait
		{
			Name = nameof(TraitEnum.TheFlexingArm),
			ProperName = "The Flexing Arm",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/the-flexing-arm-kurgess"),
			Description = "You can use Strength instead of Dexterity as your base ability for Escape Artist skill checks.)",
		},
		#endregion

		#region Toilcrafter
		new Trait
		{
			Name = nameof(TraitEnum.Toilcrafter),
			ProperName = "Toilcrafter",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/toilcrafter-dwarf-religion-trait"),
			Description = "Choose one Craft or Profession skill in which you have at least 1 rank. Ranks in your chosen skill count as your caster level for the purpose of qualifying for the Craft Magic Arms and Armor feat. You may craft +1 armor, weapons, or shields (with no special qualities), substituting your rank in the chosen skill for your caster level. You must use the chosen skill for the check to create the item. Crafting in this fashion takes twice as long as normal. These items cannot be upgraded with new abilities.)",
		},
		#endregion

		#region Undead Slayer
		new Trait
		{
			Name = nameof(TraitEnum.UndeadSlayer),
			ProperName = "Undead Slayer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/undead-slayer-pharasma"),
			Description = "You gain a +1 trait bonus on weapon damage rolls against undead.)",
		},
		#endregion

		#region Underlying Principals
		new Trait
		{
			Name = nameof(TraitEnum.UnderlyingPrincipals),
			ProperName = "Underlying Principals",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/underlying-principals-nethys"),
			Description = "You gain a +1 trait bonus on Use Magic Device checks, and it becomes a class skill for you.)",
		},
		#endregion

		#region Under Siege
		new Trait
		{
			Name = nameof(TraitEnum.UnderSiege),
			ProperName = "Under Siege",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/under-siege-sun-goddess"),
			Description = "You gain a +1 trait bonus on Bluff and Sense Motive checks. One of these skills (your choice) is always a class skill for you.)",
		},
		#endregion

		#region Unhinged Mentality
		new Trait
		{
			Name = nameof(TraitEnum.UnhingedMentality),
			ProperName = "Unhinged Mentality",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/unhinged-mentality-lamashtu"),
			Description = "You gain a +2 trait bonus on saving throws against confusion, insanity, and fear effects.)",
		},
		#endregion

		#region Unspeakable Bond
		new Trait
		{
			Name = nameof(TraitEnum.UnspeakableBond),
			ProperName = "Unspeakable Bond",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/unspeakable-bond-great-old-ones-or-outer-gods"),
			Description = "You gain a +2 trait bonus on Diplomacy checks when dealing with creatures of the aberration type.)",
		},
		#endregion

		#region Venom-Drenched
		new Trait
		{
			Name = nameof(TraitEnum.VenomDrenched),
			ProperName = "Venom-Drenched",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/venom-drenched-norgorbor"),
			Description = "You are immune to one specific nonmagical poison. If you ingest a dose of that poison (even if it is a contact, inhaled, or injury poison), it remains in your system for 24 hours; any creature that bites you during that time is subject to the poison’s effects.)",
		},
		#endregion

		#region Veteran of Battle
		new Trait
		{
			Name = nameof(TraitEnum.VeteranofBattle),
			ProperName = "Veteran of Battle",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/veteran-of-battle"),
			Description = "You gain a +1 trait bonus on initiative checks, and if you are able to act during a surprise round, you may draw a weapon (but not a potion or magic item) as a free action during that round.)",
		},
		#endregion

		#region Vindictive Strike
		new Trait
		{
			Name = nameof(TraitEnum.VindictiveStrike),
			ProperName = "Vindictive Strike",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/vindictive-strike-gyronna"),
			Description = "Once per day during a combat encounter, you can choose to gain a +1 trait bonus on a single attack roll against the creature that last hit you.)",
		},
		#endregion

		#region Voice of Monsters
		new Trait
		{
			Name = nameof(TraitEnum.VoiceofMonsters),
			ProperName = "Voice of Monsters",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/voice-of-monsters"),
			Description = "Once per day, you can cast speak with animals. When you cast this spell, it can affect animals (as normal) as well as aberrations and magical beasts with an Intelligence of 2 or lower.)",
		},
		#endregion

		#region Wasp Whisperer
		new Trait
		{
			Name = nameof(TraitEnum.WaspWhisperer),
			ProperName = "Wasp Whisperer",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/wasp-whisperer-calistria"),
			Description = "You gain a +1 trait bonus on Fortitude saving throws against poison. You may make Diplomacy checks (or wild empathy checks if you are a druid or ranger) to improve a hostile or unfriendly insectile vermin’s attitude toward Indifferent.)",
		},
		#endregion

		#region Wisdom in the Flesh
		new Trait
		{
			Name = nameof(TraitEnum.WisdomintheFlesh),
			ProperName = "Wisdom in the Flesh",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/wisdom-in-the-flesh-god-of-perfection"),
			Description = "Select any Strength, Constitution, or Dexterity-based skill. You make checks with that skill using your Wisdom modifier instead of its normal ability score. That skill is always a class skill for you.)",
		},
		#endregion

		#region Wise Teacher
		new Trait
		{
			Name = nameof(TraitEnum.WiseTeacher),
			ProperName = "Wise Teacher",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/wise-teacher"),
			Description = "If you have 4 or more ranks in Survival or Knowledge (nature), when you aid another with these skills, you grant a +4 bonus on the check you are aiding instead of the normal +2.)",
		},
		#endregion

		#region Wolf Cub
		new Trait
		{
			Name = nameof(TraitEnum.WolfCub),
			ProperName = "Wolf Cub",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("http://www.d20pfsrd.com/traits/religion-traits/wolf-cub-zarongel"),
			Description = "Once per day as a standard action, you can take a deep breath through your nose to gain the scent ability for 1 minute.)",
		},
		#endregion


		#endregion

		#region Social

		#region Self-Reliant
		new Trait
		{
			Name = nameof(TraitEnum.SelfReliant),
			ProperName = "Self-Reliant",
			TraitType = TraitTypeEnum.Basic,
			URL = new Uri("https://www.d20pfsrd.com/traits/social-traits/self-reliant/"),
			Description = "When attempting Craft checks, you take no penalty when using improvised tools. At the GM's discretion, you can attempt certain Craft checks even when no tools are available, though you take a –2 penalty.)",
		},
		#endregion


		#endregion

	};
}
