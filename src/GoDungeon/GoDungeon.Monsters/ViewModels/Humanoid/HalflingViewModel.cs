using System;

using GoDungeon.Background.Interfaces;
using GoDungeon.Background.Tables.Dragonborn;
using GoDungeon.Core;
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;
using GoDungeon.Monsters.Interfaces;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters.ViewModels.Humanoid
{
    /// <summary>
    /// Social and amicable by nature, halflings fit 
    /// equally well in both communities of humans 
    /// and those of their wily kinsfolk. Prone to 
    /// wanderlust, halflings can be found anywhere 
    /// civilized humanoids settle.
    /// </summary>
    public class HalflingViewModel : CharacterRaceViewModel, IHalfling
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="serviceProvider">The service provider</param>
        /// <param name="loggerFactory">The logger factory</param>
        /// <param name="lightFoot">The light foot sub-race</param>
        public HalflingViewModel(
            IServiceProvider serviceProvider,
            ILoggerFactory loggerFactory,
            bool lightFoot = false)
            : base(loggerFactory, serviceProvider)
        {
            // Initialize  the character from the race features
            Initialize();

            // Now generate the characters background
            // First the homeland
            var homelandTable = serviceProvider.GetRequiredService<IDragonbornHomelandTable>();
            homelandTable.InitializeTable();
            IUnusualHomelandTable unusualHomelandTable = serviceProvider.GetRequiredService<IUnusualHomelandTable>();
            unusualHomelandTable.InitializeTable();
            GetHomeland(homelandTable, unusualHomelandTable);

            // Net the parents
            var parentsTable = serviceProvider.GetRequiredService<IDragonbornParentsTable>();
            parentsTable.InitializeTable();
            GetParents(parentsTable);

            // Next the Circumstance of birth
            GetCircumstanceOfBirth();

            // Set the alignment
            SetAlignment(AlignmentFilterEnum.GoodOnly);

            // Next set the short description
            SetShortDescription();

            if (lightFoot)
            {
                SetLightFoot();
            }
        }

        /// <summary>
        /// As a lightfoot halfling, you can easily hide from 
        /// notice, even using other people  as cover. You’re
        /// inclined to be affable and get along well with others.
        /// <para>
        /// Lightfoots are more prone to wanderlust than 
        /// other halflings, and often dwell alongside other races 
        /// or take up a nomadic life.
        /// </para>
        /// </summary>
        private void SetLightFoot()
        {
            //Ability	Score	Increase. Your	Charisma	score	
            //increases	by	1.
            Charisma.RacialModifier = 1;

            // Naturally Stealthy. You can attempt to hide even 
            // when you are obscured only by a creature that is at 
            // least one size larger than you
            Traits.Add(TraitEnum.NaturallyStealthy);
        }

        /// <summary>
        /// Initialize the halfling
        /// </summary>
        /// <param name="alignmentTable"></param>
        private void Initialize()
        {
            //Type: Halflings are humanoids with the halfling subtype.
            Race = RaceEnum.Halfling;
            RaceType = RaceTypeEnum.Humanoid;
            RaceSubType.Add(RaceSubTypeEnum.Halfling);

            //Ability Score Increase. Your Dexterity score increases by 2.
            Dexterity.RacialModifier = 2;

            //Size. Halflings average about 3 feet tall and weigh 
            //about 40 pounds. Your size is Small.
            Size = SizeEnum.Small;
            SetHeightAndWeight();

            //Age. A halfling reaches adulthood at the age of 20 
            //and generally lives into the middle of his or her 
            //second century.
            Age = 20;

            // Speed. Your base walking speed is 25 feet.
            Speed = 25;

            //Languages. You can speak, read, and write 
            //Common and Halfling. The Halfling language isn’t 
            //secret, but halflings are loath to share it with others. 
            //They write very little, so they don’t have a rich body 
            //of literature. Their oral tradition, however, is very 
            //strong. Almost all halflings speak Common to 
            //converse with the people in whose lands they dwell 
            //or through which they are traveling.
            Languages.Add(LanguageEnum.Common);
            Languages.Add(LanguageEnum.Halfling);

            // You are lucky, brave and nimble
            Traits.Add(TraitEnum.Lucky);
            Traits.Add(TraitEnum.Brave);
            Traits.Add(TraitEnum.HalflingNimbleness);
        }

        /// <summary>
        /// Generate the character background
        /// </summary>
        private void GenerateRaceBackground(IServiceProvider services)
        {
            #region Siblings
            //var siblings = (BackgroundTableEntryViewModel?) siblingsTable.GetRandomRangeEntry();
            //if (siblings?.Name != "No siblings" && !string.IsNullOrEmpty(siblings?.Name))
            //{
            //    var total = new Dice(siblings.Name).Total;
            //    for (int i = 0; i < total; i++)
            //    {
            //        var creatureSiblings = new Halfling();

            //       // Set relative age of sibling
            //       var relativeAge = relativeAgeofSiblingTable.GetRandomRangeEntry();
            //        if (relativeAge?.Name == "Younger")
            //        {
            //            creatureSiblings.Age -= new Dice("1d4").Total;
            //        }
            //        if (relativeAge?.Name == "Older")
            //        {
            //            creatureSiblings.Age += new Dice("1d4").Total;
            //        }

            //        Siblings.Add(creatureSiblings);
            //    }
            //    if (Siblings.Count > 0)
            //    {
            //        if (!Traits.Contains(TraitEnum.KinGuardian))
            //        {
            //            Traits.Add(TraitEnum.KinGuardian);
            //        }
            //    }
            //}
            #endregion
        }

        //Table: Random Height and Weight
        //Gender Base Height    Height Modifier Base Weight Weight Modifier
        //Male	    2 ft. 8 in.	 +2d4 in.        30 lbs. +(2d4 lbs.)
        //Female	2 ft. 6 in.	 +2d4 in.        25 lbs. +(2d4 lbs.)
        /// <summary>
        /// The Height and Weight
        /// </summary>
        /// <param name="creature">The player character</param>
        public override void SetHeightAndWeight()
        {
            switch (Gender)
            {
                case GenderEnum.Male:
                    Height = new HeightViewModel(2, 8).Add("2d4");
                    Weight = 30 + new Dice("2d4").Total;
                    break;
                case GenderEnum.Female:
                    Height = new HeightViewModel(2, 6).Add("2d4");
                    Weight = 25 + new Dice("2d4").Total;
                    break;
            }
        }
    }
}

//Your halfling	character	has	a	number	of	traits	in	
//common	with	all	other	halflings.
//Ability	Score	Increase. Your	Dexterity	score	
//increases	by	2.
//Age.	A	halfling	reaches	adulthood	at	the	age	of	20	
//and	generally	lives	into	the	middle	of	his	or	her	
//second	century.
//Alignment. Most	halflings	are	lawful	good.	As	a	
//rule, they	are	good-hearted	and	kind, hate	to	see	
//others	in	pain, and	have	no	tolerance	for	oppression.	
//They	are	also	very	orderly	and	traditional, leaning	
//heavily	on	the	support	of	their community	and	the	
//comfort	of	their	old	ways.
//Size. Halflings	average	about	3	feet	tall	and	weigh	
//about	40	pounds.	Your	size	is	Small.
//Speed. Your	base	walking	speed	is	25	feet.
//Lucky. When	you	roll	a	1	on	the	GoDungeon	for	an	attack	
//roll, ability	check, or	saving	throw, you	can	reroll	the	
//die	and	must	use	the	new roll.
//Brave.You have    advantage on	saving	throws	
//against	being	frightened.
//Halfling	Nimbleness.	You	can	move	through	the	
//space	of	any	creature	that	is	of	a	size	larger	than	
//yours.
//Languages. You	can	speak, read, and	write	
//Common	and	Halfling.	The	Halfling	language	isn’t	
//secret, but	halflings	are	loath	to	share	it	with	others.	
//They	write	very	little, so	they	don’t	have	a	rich	body	
//of	literature.	Their	oral	tradition, however,    is	very	
//strong.	Almost	all	halflings	speak	Common	to	
//converse	with	the	people	in	whose	lands	they	dwell	
//or	through	which	they	are	traveling.
//Lightfoot
//As	a	lightfoot	halfling, you	can	easily	hide	from	
//notice, even    using other people  as cover.You’re
//inclined	to	be	affable	and	get	along	well	with	others.
//Lightfoots	are	more	prone	to	wanderlust	than	
//other	halflings, and	often	dwell	alongside	other	races	
//or	take	up	a	nomadic	life.
//Ability	Score	Increase. Your	Charisma	score	
//increases	by	1.
//Naturally	Stealthy. You	can	attempt	to	hide	even	
//when	you	are	obscured	only	by	a	creature	that	is	at	
//least	one	size	larger	than	you
