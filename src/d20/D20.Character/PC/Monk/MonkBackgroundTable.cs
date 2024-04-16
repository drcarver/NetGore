//using System.Diagnostics.CodeAnalysis;

//using D20.Character.Enum;
//using D20.Character.Models;
//using D20.Core.Enum;
//using D20.Core.Models;

//namespace D20.Character.PC.Monk;

//public class MonkBackgroundTable : RandomTable, IMonkBackgroundTable
//{
//    /// <summary>
//    /// Constructor
//    /// </summary>
//    [SetsRequiredMembers]
//    public MonkBackgroundTable()
//    {
//        Name = nameof(MonkLevelTable);
//        ProperName = "Monk backgrounds";
//        TableType = TableTypeEnum.CharacterTable;
//        DiceSides = 100;
//        Description =
//            "Monk Backgrounds to determine the event that " +
//            "caused you to first experience your rage.";
//    }

//    //Table: Monk Backgrounds
//    //d%	Result
//    //01–10	Vengeance When you were young, a great wrong was done to you, a loved one, your family, or your people.This experience tore you apart and reduced you to a being of primal emotions. Dreams of vengeance became your only promise of comfort.You gain access to the Axe to Grind combat trait, the Foeslayer story feat, and the Vengeance story feat.
//    //11–20	Champion of a God   At your coming-of-age ritual, your deity, totem, or patron spirit sparked your soul with a religious zeal. This entity might be a beast spirit, a warmongering god, a demon lord, or some other supernatural entity.In the name of this otherworldly force you become an unstoppable warrior—the bane of all your tribe’s foes. You gain access to the Inspired faith trait and the Champion story feat.
//    //21–30	Conquest Upon coming of age, you went on your first raid, where you learned the thrill of violence and chaos and the satisfaction that came with the spoils of your victory. When your enemies dare to stand against you, your rage rekindles until you have conquered and subdued them. You gain access to the Killer combat trait.
//    //31–40	Hated Foe   In your formative years, you learned to despise a certain individual, tribe, kingdom, empire, race, or monster due to some slight it inflicted upon you or your people.This foe lurks ever close to your thoughts. So intense is your hatred that the mere thought of this foe can incite your rage.You gain access to the Reckless combat trait and the Foeslayer story feat.
//    //41–50	Personal Flaw   There is a part of yourself that you hate more than anything else. In your adolescence, you first realized this imperfection—to your lasting shame. This might be a gentle part of yourself you wish to eliminate or a brutal, prideful, greedy, or monstrous side you can’t control. Your rage is fueled by self-loathing, or by projecting this part of yourself onto a foe you wish to destroy. You gain access to the Axe to Grind combat trait.
//    //51–60	Hatred of Civilization When you first encountered civilization in your youth, its weak and decadent people revolted you.Once, such people were free and strong, but rules and laws made them feeble.Your rage is the wild part—the pure part—of yourself that separates you from the craven ways of “civilized” people.You gain access to the Savage social trait.
//    //61–70	Persecution You grew up under the persecution of another power—perhaps a rival tribe, an expansionistic empire, or a tribe of violent monsters. Beaten and bloodied, your people barely survived the onslaught. But the beatings made you strong and taught you how to channel the pain into something useful.Since that time, the flame of rage has burned inside you, waiting to be released against your oppressors.You gain access to the Bullied combat trait.
//    //71–80	One of a Dying Breed You grew up knowing that your people were slowly dying out—that your extinction was inevitable in the face of the changing world. In youthful vigor, you declared that your fire would not be snuffed without a fight. Your rage stems from the desperate desire to be remembered, to make a mark upon the world before the sun sets on your dwindling kind.When you rage, a single thought permeates your burning mind: If you’re going down, you’re taking everyone with you.You gain access to the Reactionary combat trait.
//    //81–90	Chaos Embraced  You grew up in wild lands where there were no laws except for those of nature—the laws of the predator and the prey. You searched for meaning in the world, in the gods, in the prayers of priests, in the patterns of the stars, but you found nothing. There is no true order to the natural universe except for that of raw and unbridled power. Chaos is the natural state of all things, and that’s how you like it.You gain access to the Unpredictable social trait.
//    //91–100	Bloodthirsty The first time you spilled a deserving foe’s blood and watched the thing’s life ebb out onto the hard ground, you found yourself filled with a mad, euphoric ecstasy like none other.The memory of this visceral experience returns to you in every battle, like an insatiable addiction that can only be abated with further bloodshed. You gain access to the Bloodthirsty combat trait and the Innocent Blood story feat.
//    /// <summary>
//    /// Initialize the game table.  This is a seperate method so 
//    /// we can create a game table for it's meta properties with 
//    /// out creating the actual able values.  A bit of optimiation 
//    /// to conserve memeory on big tables
//    /// </summary>
//    public override void InitializeTable()
//    {
//        Table =
//        [
//            #region "Vengeance"
//            //01–10	Vengeance When you were young, a great wrong was done to you, a loved one, your family, or your people.This experience tore you apart and reduced you to a being of primal emotions. Dreams of vengeance became your only promise of comfort.You gain access to the Axe to Grind combat trait, the Foeslayer story feat, and the Vengeance story feat.
//            new BackgroundTableEntry
//            {
//                Range = new Range(01, 10),
//                Name = nameof(MonkBackgroundEnum.Vengeance),
//                ProperName = "Vengeance",
//                Description =
//                    "When you were young, a great wrong was done " +
//                    "to you, a loved one, your family, or your " +
//                    "people. This experience tore you apart and " +
//                    "reduced you to a being of primal emotions. " +
//                    "Dreams of vengeance became your only promise " +
//                    "of comfort.You gain access to the Axe to " +
//                    "Grind combat trait, the Foeslayer story " +
//                    "feat, and the Vengeance story feat.",
//                Traits =
//                [
//                    TraitEnum.Foeslayer,
//                    TraitEnum.Vengeance,
//                ]
//            },
//            #endregion

//            #region "Champion of a God"
//            //11–20	Champion of a God   At your coming-of-age ritual, your deity, totem, or patron spirit sparked your soul with a religious zeal. This entity might be a beast spirit, a warmongering god, a demon lord, or some other supernatural entity.In the name of this otherworldly force you become an unstoppable warrior—the bane of all your tribe’s foes. You gain access to the Inspired faith trait and the Champion story feat.
//            new BackgroundTableEntry
//            {
//                Range = new Range(11, 20),
//                Name = nameof(MonkBackgroundEnum.ChampionofaGod),
//                ProperName = "Champion of a God",
//                Description =
//                    "At your coming-of-age ritual, your deity, " +
//                    "totem, or patron spirit sparked your soul  " +
//                    "with a religious zeal. This entity might " +
//                    "be a beast spirit, a warmongering god, " +
//                    "a demon lord, or some other supernatural " +
//                    "entity.In the name of this otherworldly " +
//                    "force you become an unstoppable warrior—the " +
//                    "bane of all your tribe’s foes. You gain " +
//                    "access to the Inspired faith trait and the " +
//                    "Champion story feat.",
//                Traits =
//                [
//                    TraitEnum.Inspired,
//                    TraitEnum.Champion,
//                ]
//            },
//            #endregion

//            #region "Conquest"
//            //21–30	Conquest Upon coming of age, you went on your first raid, where you learned the thrill of violence and chaos and the satisfaction that came with the spoils of your victory. When your enemies dare to stand against you, your rage rekindles until you have conquered and subdued them. You gain access to the Killer combat trait.
//            new BackgroundTableEntry
//            {
//                Range = new Range(21, 30),
//                Name = nameof(MonkBackgroundEnum.Conquest),
//                ProperName = "Conquest",
//                Description =
//                    "Upon coming of age, you went on your first " +
//                    "raid, where you learned the thrill of " +
//                    "violence and chaos and the satisfaction " +
//                    "that came with the spoils of your victory. " +
//                    "When your enemies dare to stand against you, " +
//                    "your rage rekindles until you have " +
//                    "conquered and subdued them. You gain access " +
//                    "to the Killer combat trait.",
//                Traits =
//                [
//                    TraitEnum.Killer,
//                ]
//            },
//            #endregion

//            #region "Hated Foe"
//            //31–40	Hated Foe   In your formative years, you learned to despise a certain individual, tribe, kingdom, empire, race, or monster due to some slight it inflicted upon you or your people.This foe lurks ever close to your thoughts. So intense is your hatred that the mere thought of this foe can incite your rage.You gain access to the Reckless combat trait and the Foeslayer story feat.
//            new BackgroundTableEntry
//            {
//                Range = new Range(31, 40),
//                Name = nameof(MonkBackgroundEnum.HatedFoe),
//                ProperName = "Hated Foe",
//                Description =
//                    "In your formative years, you learned to " +
//                    "despise a certain individual, tribe, " +
//                    "kingdom, empire, race, or monster due " +
//                    "to some slight it inflicted upon you or " +
//                    "your people. This foe lurks ever close " +
//                    "to your thoughts. So intense is your " +
//                    "hatred that the mere thought of this " +
//                    "foe can incite your rage.You gain " +
//                    "access to the Reckless combat trait and " +
//                    "the Foeslayer story feat.",
//                Traits =
//                [
//                    TraitEnum.Reckless,
//                    TraitEnum.Foeslayer
//                ]
//            },
//            #endregion

//            #region "Personal Flaw"
//            //41–50	Personal Flaw   There is a part of yourself that you hate more than anything else. In your adolescence, you first realized this imperfection—to your lasting shame. This might be a gentle part of yourself you wish to eliminate or a brutal, prideful, greedy, or monstrous side you can’t control. Your rage is fueled by self-loathing, or by projecting this part of yourself onto a foe you wish to destroy. You gain access to the Axe to Grind combat trait.
//            new BackgroundTableEntry
//            {
//                Range = new Range(41, 50),
//                Name = nameof(MonkBackgroundEnum.PersonalFlaw),
//                ProperName = "Personal Flaw",
//                Description =
//                    "There is a part of yourself that you hate " +
//                    "more than anything else. In your adolescence, " +
//                    "you first realized this imperfection—to your " +
//                    "lasting shame. This might be a gentle part " +
//                    "of yourself you wish to eliminate or a brutal, " +
//                    "prideful, greedy, or monstrous side you can’t " +
//                    "control. Your rage is fueled by self-loathing, " +
//                    "or by projecting this part of yourself onto " +
//                    "a foe you wish to destroy. You gain access " +
//                    "to the Axe to Grind combat trait.",
//                Traits =
//                [
//                    TraitEnum.AxetoGrind,
//                ]
//            },
//            #endregion

//            #region "Hatred of Civilization"
//            //51–60	Hatred of Civilization When you first encountered civilization in your youth, its weak and decadent people revolted you.Once, such people were free and strong, but rules and laws made them feeble.Your rage is the wild part—the pure part—of yourself that separates you from the craven ways of “civilized” people.You gain access to the Savage social trait.
//            new BackgroundTableEntry
//            {
//                Range = new Range(51, 60),
//                Name = nameof(MonkBackgroundEnum.HatredofCivilization),
//                ProperName = "Hatred of Civilization",
//                Description =
//                    "When you first encountered civilization in " +
//                    "your youth, its weak and decadent people " +
//                    "revolted you. Once, such people were free " +
//                    "and strong, but rules and laws made them } +" +
//                    "feeble. Your rage is the wild part—the pure " +
//                    "part—of yourself that separates you from the " +
//                    "craven ways of “civilized” people. You gain " +
//                    "access to the Savage social trait.",
//                Traits =
//                [
//                    TraitEnum.Savage,
//                ]
//            },
//            #endregion

//            #region "Persecution"
//            //61–70	Persecution You grew up under the persecution of another power—perhaps a rival tribe, an expansionistic empire, or a tribe of violent monsters. Beaten and bloodied, your people barely survived the onslaught. But the beatings made you strong and taught you how to channel the pain into something useful.Since that time, the flame of rage has burned inside you, waiting to be released against your oppressors.You gain access to the Bullied combat trait.
//            new BackgroundTableEntry
//            {
//                Range = new Range(61, 70),
//                Name = nameof(MonkBackgroundEnum.Persecution),
//                ProperName = "Persecution",
//                Description =
//                    "You grew up under the persecution of another " +
//                    "power—perhaps a rival tribe, an expansionistic " +
//                    "empire, or a tribe of violent monsters. " +
//                    "Beaten and bloodied, your people barely " +
//                    "survived the onslaught. But the beatings " +
//                    "made you strong and taught you how to " +
//                    "channel the pain into something useful. " +
//                    "Since that time, the flame of rage has " +
//                    "burned inside you, waiting to be released " +
//                    "against your oppressors. You gain access " +
//                    "to the Bullied combat trait.",
//                Traits =
//                [
//                    TraitEnum.Bullied,
//                ]
//            },
//            #endregion

//            #region "One of a Dying Breed"
//            //71–80	One of a Dying Breed You grew up knowing that your people were slowly dying out—that your extinction was inevitable in the face of the changing world. In youthful vigor, you declared that your fire would not be snuffed without a fight. Your rage stems from the desperate desire to be remembered, to make a mark upon the world before the sun sets on your dwindling kind.When you rage, a single thought permeates your burning mind: If you’re going down, you’re taking everyone with you.You gain access to the Reactionary combat trait.
//            new BackgroundTableEntry
//            {
//                Range = new Range(71, 80),
//                Name = nameof(MonkBackgroundEnum.OneofaDyingBreed),
//                ProperName = "One of a Dying Breed",
//                Description =
//                    "You grew up knowing that your people were " +
//                    "slowly dying out—that your extinction was " +
//                    "inevitable in the face of the changing world. " +
//                    "In youthful vigor, you declared that your " +
//                    "fire would not be snuffed without a fight. " +
//                    "Your rage stems from the desperate desire " +
//                    "to be remembered, to make a mark upon the " +
//                    "world before the sun sets on your dwindling " +
//                    "kind. When you rage, a single thought " +
//                    "permeates your burning mind: If you’re " +
//                    "going down, you’re taking everyone with " +
//                    "you. You gain access to the Reactionary " +
//                    "combat trait.",
//                Traits =
//                [
//                    TraitEnum.Reactionary,
//                ]
//            },
//            #endregion

//            #region "Chaos Embraced"
//            //81–90	Chaos Embraced  You grew up in wild lands where there were no laws except for those of nature—the laws of the predator and the prey. You searched for meaning in the world, in the gods, in the prayers of priests, in the patterns of the stars, but you found nothing. There is no true order to the natural universe except for that of raw and unbridled power. Chaos is the natural state of all things, and that’s how you like it.You gain access to the Unpredictable social trait.
//            new BackgroundTableEntry
//            {
//                Range = new Range(81, 90),
//                Name = nameof(MonkBackgroundEnum.ChaosEmbraced),
//                ProperName = "Chaos Embraced",
//                Description =
//                    "You grew up in wild lands where there were " +
//                    "no laws except for those of nature—the laws " +
//                    "of the predator and the prey. You searched " +
//                    "for meaning in the world, in the gods, in " +
//                    "the prayers of priests, in the patterns " +
//                    "of the stars, but you found nothing. There " +
//                    "is no true order to the natural universe " +
//                    "except for that of raw and unbridled power. " +
//                    "Chaos is the natural state of all things, " +
//                    "and that’s how you like it. You gain access " +
//                    "to the Unpredictable social trait.",
//                Traits =
//                [
//                    TraitEnum.Unpredictable,
//                ]
//            },
//            #endregion

//            #region "Bloodthirsty"
//            //91–100	Bloodthirsty The first time you spilled a deserving foe’s blood and watched the thing’s life ebb out onto the hard ground, you found yourself filled with a mad, euphoric ecstasy like none other.The memory of this visceral experience returns to you in every battle, like an insatiable addiction that can only be abated with further bloodshed. You gain access to the Bloodthirsty combat trait and the Innocent Blood story feat.
//            new BackgroundTableEntry
//            {
//                Range = new Range(91, 100),
//                Name = nameof(MonkBackgroundEnum.Bloodthirsty),
//                ProperName = "Bloodthirsty",
//                Description =
//                    "The first time you spilled a deserving foe’s " +
//                    "blood and watched the thing’s life ebb out " +
//                    "onto the hard ground, you found yourself " +
//                    "filled with a mad, euphoric ecstasy like " +
//                    "none other. The memory of this visceral " +
//                    "experience returns to you in every battle, " +
//                    "like an insatiable addiction that can only " +
//                    "be abated with further bloodshed. You gain " +
//                    "access to the Bloodthirsty combat trait " +
//                    "and the Innocent Blood story feat",
//                Traits =
//                [
//                    TraitEnum.Bloodthirsty,
//                    TraitEnum.InnocentBlood,
//                ]
//            },
//            #endregion
//        ];
//    }   
//}
