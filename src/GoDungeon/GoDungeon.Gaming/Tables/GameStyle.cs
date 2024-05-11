using System;
using System.Collections.Generic;
using System.Data;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Xml.Linq;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Gaming.Tables
{
    internal class GameStyle
    {
    }
}
//PLAY STYLE
//By building a new world(or adopting an existing one) and creating the key events that launch your 
//campaign, you determined what your campaign is about. Next, you have to decide bow you want to run 
//your campaign.
//What's the right way to run a campaign? That depends on your play style and the motivations of your 
//players.
//Consider your players' tastes, your strengths as a DM, table rules (discussed in part 3), and the 
//type of
//game you want to run. Describe to the players how you envision the game experience and let them 
//give you input. The game is theirs, too. Lay that groundwork early, so your players can make 
//informed choices and help you maintain the type of game you want to run.
//Consider the following two exaggerated examples of play style.
//HACK AND SLASH
//The adventurers kick in the dungeon door, fight the monsters, and grab the treasure. This style of 
//play is straightforward, fun, exciting, and action-oriented. The players spend relatively little 
//time developing personas for their characters, roleplaying noncombat situations, or discussing 
//anything other than the immediate dangers of the dungeon.
//In such a game, the adventurers face clearly evil monsters and opponents and occasionally meet 
//clearly good and helpful NPCs. Don't expect the adventurers to anguish over what to do with 
//prisoners, or to debate whether it's right or wrong to invade and wipe out a bugbear lair. Don't 
//track money or time spent in town. Once they've completed a task, send the adventurers back into 
//the action as quickly as possible. Character motivation need be no more developed than a desire to 
//kill monsters and acquire treasure.
//IMMERSIVE STORYTELLING
//Waterdeep is threatened by political turmoil. The adventurers must convince the Masked Lords, the 
//city's secret rulers, to resolve their differences, but can do so

//A WORLD TO EXPLORE
//Much of a campaign involves the adventurers traveling from place to place, exploring the 
//environment, and learning about the fantasy world. This exploration can take place in any 
//environment, including a vast wilderness, a labyrinthine dungeon, the shadowy passages of the 
//Underdark, the crowded streets of a city, and the undulating waters of
//the sea. Determining a way around an obstacle, finding a hidden object, investigating a strange 
//feature of a dungeon, deciphering clues, solving puzzles, and bypassing or disabling traps can all 
//be part of exploration.
//Sometimes exploration is an incidental part of the game. For instance, you might gloss over an 
//unimportant journey by telling the players that they spend three uneventful days on the road before 
//moving along to the next point of interest.
//Other times exploration is the focus, a chance to describe a wondrous part of the world or story 
//that increases the
//players' feeling of immersion. Similarly, you should consider playing up exploration if your 
//players enjoy solving puzzles, finding their way around obstacles, and searching dungeon
//corridors for secret doors.                ,.

//CHAPTER I J A WORLD OF YOUR OWN
//only after both the characters and the lords have come
//to terms with their differing outlooks and agendas. This style of gaming is deep, complex, and 
//challenging. The focus isn't on combat but on negotiations, political maneuverings, and character 
//interaction. A whole game session might pass without a single attack roll.
//In thisstyle of game, the NPCs are as complex and richly detailed as the adventurers, although the 
//focus lies on motivation and personality, not game statistics. Expect long digressions from each 
//player about what his or her character does, and why. Going to a temple to ask a priest for advice 
//can be as important an encounter as fighting ores. (And don't expect the adventurers to fight the 
//ores at all unless they are motivated to do
//so.) A character will sometimes take actions against the player's better judgment, because "that's 
//what the character would do."
//Since combat isn't the focus, game rules take a back seat to character development. Ability check 
//modifiers and skill proficiencies take precedence over combat bonuses. Feel free to change or 
//ignore rules to fit the players' roleplaying needs, using the advice presented in part 3 of this 
//book.
//SOMETHING IN BETWEEN
//The style of play in most campaigns falls between these two extremes. There's plenty of action, but 
//the campaign offers an ongoing storyline and interaction between characters as well. Players 
//develop their characters' motivations and relish the chance to prove their skills
//in combat. To maintain the balance, provide a mixture of roleplaying encounters and combat 
//encounters. Even in a dungeon setting, you can present NPCs that aren't meant to be fought but 
//rather helped out, negotiated with, or just talked to.
//Think about your preferred style of play by considering these questions:
//Are you a fan of realism and gritty consequences, or are you more focused on making the game seem 
//like an action movie?
//Do you want the game to maintain a sense of medieval fantasy, or do you want to explore alternate 
//time lines or modern thinking?
//Do you want to maintain a serious tone, or is humor your goal?
//• Even if you are serious, is the action lighthearted or intense?
//Is bold action key, or do the players need to be
//thoughtful and cautious?
//Do you like to plan thoroughly in advance, or do you prefer improvising on the spot?
//Is the game full of varied D&D elements, or does it center on a theme such as horror?
//Is the game for all ages, or does it involve mature themes?
//Are you comfortable with moral ambiguity, such as allowing the characters to explore whether the 
//end justifies the means? Or are you happier with straight­ forward heroic principles, such as 
//justice, sacrifice,
//and helping the downtrodden?

//CHARACTER NAMES              
//Part of your campaign style has to do with naming characters. It's a good idea to establish some 
//ground rules with your players at the start of a new campaign.In a group consisting of Sithis,
//Travok, Anastrianna, and Kairon, the human fighter named Bob II sticks out, especially when he's 
//identical to Bob I, who was killed by kobolds. If everyone takes a lighthearted approach  to names,
//that's fine. If the group would rather take the characters and their names a little more seriously, 
//urge Bob's player to come up with a more appropriate name.
//Player character names should match each other in flavor or concept, and theyshould also match the
//flavor of your campaign world-so should the nonplayer characters' names and place names you create. 
//Travok and Kairon don't want to undertake a quest for Lord Cupcake, visit Gumdrop Island, or take 
//down a crazy wizard named Ray.
//CONTINUING OR EPISODIC CAMPAIGNS
//The backbone of a campaign is a connected series of adventures, but you can connect them in two 
//different ways.
//In a continuing campaign, the connected adventures share a sense of a larger purpose or a recurring 
//theme (or themes). The adventures might feature returning villains, grand conspiracies, or a single 
//mastermind who's ultimately behind every adventure of the campaign.
//A continuing campaign designed with a theme and a story arc in mind can feel like a great fantasy 
//epic. The players derive the satisfaction of knowing the actions they take during one adventure 
//matter in the next. Plotting and running that kind of campaign can be demanding on the DM, but the 
//payoff is a great and memorable story.
//An episodic campaign,.in contrast, is like a television
//show where each week's episode is a self-contained story that doesn't play into any overarching 
//plot. It might be built on a premise that explains its nature: the player characters are 
//adventurers-for-hire, or explorers venturing into the unknown and facing a string of unrelated 
//dangers. They might even be archaeologists, venturing into one ancient ruin after another in search 
//of artifacts. An episodic game like this letsyou create
//adventures-or buy published ones-and drop them into your campaign without worrying about how they 
//fit with the adventures that came before and foll.ow after.
//CAMPAIGN  THEME     
//A theme in a campaign, as in a work of literature, expresses the deeper meaning of a story and the 
//fundamental elements of human experience that the story explores. Your campaign doesn't have to be 
//a work of literature, but it can still draw on common themes that lend a distinctive .flavor to its 
//stories. Consider these examples:
//Acampaign about confronting the inevitability of mortality, whether embodied in undead monsters or 
//expressed through the death of loved ones.
//Acampaign revolving around an insidious evil, whether dark gods, monstrous races such as the 
//yuan-ti, or creatures of unknown realms far removed from mortal concerns. As heroes confront this 
//evil,
//they must face the selfish, cold tendencies of their own kind as well.
//Acampaign featuring troubled heroes who confront not only the savagery of the bestial creatures of 
//the world, but also the beast within-the rage and fury that lies in their own hearts.
//Acampaign exploring the insatiable thirst for power
//and domination, whether embodied by the hosts of the Nine Hells or by humanoid rulers bent on 
//conquering the world.
//With a theme such as "confrontation with mortality," you can craft a broad range of adventures that 
//aren't necessarily connected by a common villain. One adventure might feature the dead bursting 
//from their graves and threatening to overwhelm a whole town.
//In the next adventure, a mad wizard creates a flesh golem in an effort to revive his lost love. A 
//villain could go to extreme lengths to achieve immortality to avoid confronting its own demise. The 
//adventurers might help a ghost accept death and move on, or one of the adventurers might even 
//become a ghost!
//VARIATIONS ON A THEME
//Mixing things up once in a while allows your players to enjoy a variety of adventures. Even a 
//tightly themed campaign can stray now and then. If your campaign
//heavily involves intrigue, mystery, and roleplaying, your players might enjoy the occasional 
//dungeon crawl­ especialJy if the tangent is revealed to relate to a larger plot in the campaign. If 
//most of your adventures are dungeon expeditions, shift gears with a tense urban mystery that 
//eventually leads the party into a dungeon crawl in an abandoned building or tower. lf you run 
//horror adventures week after week, try using a villain who turns out to be ordinary, perhaps even 
//silly. Comic relief is a great variation on almost any D&D campaign, though players usually provide 
//it themselves.

//TIERS OF PLAY
//As characters grow in power, their ability to change the world around them grows with them. It 
//helps to think ahead when creating your campaign to account for this change. As the characters make 
//a greater impact on the world, they face greater danger whether they want to
//or not. Powerful factions see them as a threat and plot against them, while friendly ones court 
//their favor in hopes of striking a useful alliance.
//The tiers of play represent the ideal milestones for introducing new world- shaking events to the 
//campaign. As the characters resolve one event, a new danger arises or the prior trouble transforms 
//into a new threat in response to the characters' actions. Events need to grow in magnitude and 
//scope, increasing the stakes and drama as the characters become increasingly powerful.

//CHAPTER. I I A WORLD OF YOUR OWN

//This approach also allows you to break your design work down into smaller pieces. Create material 
//such as adventures, NPCs, maps, and so on for one tier at a time. You only need to worry about the 
//details of the next tier as the characters approach it. Even better, as
//the campaign takes unexpected turns in response to the players' choices, you don't have to worry 
//about redoing much work.
//LEVELS 1-4: LOCAL HEROES    
//Characters in this tier are still learning the range of class features that define them, including 
//their choice of specialization. But even 1st-level characters are heroes, set apart from the common 
//people by natural characteristics, learned skills, and the hint of a greater destiny that lies 
//before them.
//At the start of their careers, characters use 1st- and 2nd-level spells and wield mundane gear. The 
//magic items they find include common consumable items (potions and scrolls) and a very few uncommon
//permanent items. Their magic can have a big impact in a single encounter, but it doesn't change the 
//course of an adventure.
//The fate of a village might hang on the success or failure of low-level adventurers, who trust 
//their lives to their fledgling abilities. These characters navigate dangerous terrain and explore 
//haunted crypts, where they can expect to fight savage ores, ferocious wolves, giant spiders, evil 
//cultists, bloodthirsty ghouls, and hired thugs.If they face even a young dragon, they're better off 
//avoiding a fight.
//LEVELS 5-10: HEROES OF THE REALM
//By the time they reach this tier, adventurers have mastered the basics of their class features, 
//though they continue to improve throughout these levels. They have found their place in the world 
//and have begun to involve themselves in the dangers that surround them.
//Dedicated spellcasters learn 3rd-level spells at the start of this tier. Suddenly characters can 
//fly, damage large numbers of foes with fireball and lightning bolt spells, and even breathe 
//underwater. They master 5th-level spells by the end of the tier, and spells such as teleportation 
//circle, scrying, flame strike, legend lore, and raise dead can have a significant impact on
//their adventures. They start acquiring more permanent magic items (uncommon and rare ones) as well,
//which will serve them for the rest of their careers.
//The fate of a region might depend on the adventures that characters of levels 5 to 10 undertake. 
//These adventurers venture into fearsome wilds and ancient ruins, where they confront savage giants,
//ferocious hydras, fearless golems, evil yuan-ti, scheming devils, bloodthirsty demons, crafty mind 
//flayers, and drow assassins. They might have a chance of defeating a young dragon that has 
//established a lair but not yet extended its reach far into the surrounding territory.
//LEVELS 11-16: MASTERS OF THE REALM     
//By 11th level, characters are shining examples of courage and determination-true paragons in the 
//world, set well apart from the masses. At this tier, adventurers are far more versatile than they 
//were at lower levels, and they can usually find the right tool for a given challenge.
//Dedicated spellcasters gain access to 6th-level spells at 11th level, including spells that 
//completely change the way adventurers interact with the world. Their big, flashy spells are 
//significant in combat-disintegrate, blade barrier, and heal, for example-but behind-the­ scenes 
//spells such as word of recall, find the path, contingency, teleport, and true seeing alter the way
//players approach their adventures. Each spell level after that point introduces new effects with an
//equally large impact. The adventurers find rare magic items (and very rare ones) that bestow 
//similarly powerful abilities.
//The fate of a nation or even the world depends on momentous quests that such characters undertake. 
//Adventurers explore uncharted regions and delve into long-forgotten dungeons, where they confront 
//terrible masterminds of the lower planes, cunning rakshasas and beholders, and hungry purple worms. 
//They might encounter and even defeat a powerful adult dragon that has established a lair and a 
//significant presence in the world.
//At this tier, adventurers make their mark on the world in a variety of ways, from the consequences 
//of their adventures to the manner in which theyspend their hard-won treasure and exploit their 
//well-deserved
//reputations. Characters of this level construct fortresses on land deeded them by local rulers.They 
//found guilds, temples, or martial orders. They take on apprentices
//or students of their own. They broker peace between nations or lead them into war. And their 
//formidable reputations attract the attention of very powerful foes.
//LEVELS 17-20: MASTERS OF THE
//WORLD   
//By 17th level, characters have superheroic capabilities, and their deeds and adventures are the 
//stuff of legend. Ordinary people can hardly dream of such heights of power-or such terrible 
//dangers.
//Dedicated spellcasters at this tier wield earthshaking 9th-level spells such as wish, gate, storm of 
//vengeance, and astral projection. Characters have several rare
//and very rare magic items at their disposal. and begin discovering legendary items such as a vorpal 
//sword or a staff of the magi.
//Adventures at these levels have far-reaching consequences, possibly determining the fate of 
//millions in the Material Plane and even places beyond. Characters traverse otherworldly realms and 
//explore demiplanes and other extraplanar locales, where they fight savage balor demons, titans,
//archdevils, lich archmages, and even avatars of the gods themselves. The dragons theyencounter are 
//wyrms of tremendous power, whose sleep troubles kingdoms and whose waking threatens existence 
//itself.


//CHAPTER l I A WORLD OF YOUR OWN

//Characters who reach 20th level have attained the pinnacle of mortal achievement. Their deeds are 
//recorded in theannals of history and recounted by
//bards for centuries. Their ultimate destinies come to pass. A cleric might be taken up into 
//theheavens to serve as a god's right hand. A warlock could become a patron to other warlocks. 
//Perhaps a wizard unlocks
//the secret to immortality (or undeath) and spends eons exploring the farthest reaches of the 
//multiverse. A druid might become one with theland, transforming into a nature spirit of a 
//particular place or an aspect of the wild. Other characters could found clans or dynasties that 
//revere the memory of their honored ancestors
//from generation to generation, create masterpieces of epic literature that are sungand retold for 
//thousands of years, or establish guilds or orders that keep the adventurers' principles anddreams 
//alive.
//Reaching thispoint doesn't necessarily dictate the end of the campaign. These powerful characters 
//might be called on to undertake grand adventures on the cosmic stage. And as a result of these 
//adventures, their capabilities can continue to evolve. Characters gain no more levels at this 
//point, but they can stilladvance in meaningful ways and continue performing epic deeds that resound 
//throughout the multiverse. Chapter 7 details epicboons you can use as rewards for these characters 
//to maintain a sense of progress.
//STARTING AT HIGHER LEVEL
//Experienced players familiar with thecapabilities of the character classes and impatient for more 
//significant adventures might welcome the idea of starting a campaign with characters above 1st 
//level. Creating a higher-level character uses the same character creation steps outlined in the 
//Player's Handbook. Such a
//character has more hit points, class features, and spells, and probably starts with better 
//equipment.
//Starting equipment for characters above 1st level is entirely at your discretion, since you give 
//out treasure at your own pace. That said, you can use the Starting Equipment table as a guide.

//er-
//• STARTING EQUIPMENT
//FLAVORS OF FANTASY
//DUNGEONS & DRAGONS is a fantasy game, but that broad category encompasses a lot of variety. Many 
//different flavors of fantasy exist in fiction and film. Do you want
//a horrific campaign inspired by the works ofH. P. Lovecraft or Clark Ashton Smith? Or do you 
//envision a world of muscled barbarians and nimble thieves, along the lines of theclassic 
//sword-and-sorcery books by Robert E. Howard and Fritz Leiber? Your choice can have a impact on the 
//flavor of your campaign.
//HEROIC FANTASY
//Heroic fantasy is the baseline assumed by the D&D rules. The Player's Handbook describes this 
//baseline: a multitude of humanoid races coexist with humans in fantastic worlds. Adventurers bring 
//magical powers to bear against the monstrous threats they face. These characters typically come 
//from ordinary backgrounds,
//but something impels them into an adventuring life. The adventurers are the "heroes" of the 
//campaign. but they might not be truly heroic, instead pursuing this life for selfish reasons. 
//Technology and society are based on medieval norms, though the culture isn't necessarily European. 
//Campaigns often revolve around delving into ancient dungeons in search of treasure or in an effort 
//to destroy monsters or villains.
//This genre is also common in fantasy fiction. Most novels set in the Forgotten Realms are best 
//described as heroic fantasy, following in the footsteps of many of the authors listed in appendix E 
//of the Player's Handbook.
//SWORD AND SORCERY
//A grim, hulking fighter disembowels the high priest of the serpent god on his own altar. A laughing 
//rogue spends ill-gotten gains on cheap wine in filthy taverns.
//Hardy adventurers venture into theunexplored jungle in search of the fabled City of GoldenMasks.
//A sword-and-sorcerycampaign emulates some of the
//classic works of fantasy fiction, a tradition that goes back to the roots of the game. Hereyou'll 
//find a dark, gritty world of evil sorcerers and decadent cities, where
//,

//Character Level 1st-4th
//5th-10th
//11th-16th
//17th-20th

//Low Magic Campaign Normal starting equipment 500 gp plus 1d10 x 25 gp,. normal starting equipment

//5,000 gp plus 1d10 x 250 gp, one uncommon magic item, normal starting equipment

//20,000 gp plus ld10 x 250 gp, two uncommon magic items, normal starting equipment

//Standard Campaign Normal starting equipment 500 gp plus 1dl0 x 25 gp, normal starting equipment

//5,000 gp plus 1d10 x 250 gp, two uncommon magic items, normal starting equipment

//20,000 gp plus 1d10 x 250 gp, two uncommon magic items, one rare item, normal starting equipment

//High Magic Campaign Normal starting equipment 500 gp plus 1d10 x 25 gp, one uncommon magic item,
//normal starting equipment 5,000 gp plus 1d10 x 250 gp,
//three uncommon magic items, one rare item, normal starting equipment
//20,000 gp plus 1d10 x 250 gp, three uncommon magic items, two rare items, one very rare item,
//normal starting equipment



//CHAPTER l I A WORLD OF YOUR OWN

//he protagonists are motivated more by greed and self­
//<>.terest than by altruistic virtue. Fighter, rogue, and
//.arbarian characters tend to be far morecommon than 1zards, clerics, or paladins. In such a pulp 
//fantasy
//5etting, those who wield magic often symbolize the
//d cadence and corruption of civilization, and wizards are the classic villains of these settings. 
//Magic items are 'lerefore rare and often dangerous.
//Certain DUNGEONS & DRAGONS novels follow in the
//!steps of classic sword-and-sorcery novels. The world
//. 'Athas (as featured in numerous Dark Sun novels and ame products), with its heroic gladiators and 
//tyrannical
//--orcerer-kings, belongs squarely in this genre.
//LPIC FANTASY    
//-\.devout paladin in gleaming plate armor braces her
//.a.nee as she charges a dragon. Bidding farewell to his
//:; ear love, a noble wizard sets forth on a quest to close
//..ae gate to the Nine Hells that has opened in the remote
//-ilderness. A close-knit band of loyal friends strives to
//:ercome the forces of a tyrannical overlord.
//An epic-fantasy campaign emphasizes the conflict etween good and evil as a prominent element
//'the game, with the adventurers more or less
//,..quareJy on the side of good. These characters
//_-e heroes in the best sense, driven by a higher
//.urpose than selfish gain or ambition, and facing
//-credible dangers without blinking. Characters
//-ight struggle with moral quandaries, fighting
//; be evil tendencies within themselves as well as


//'le evil that threatens the world. And the stories of  1·
//>iese campaigns often include an element of romance:
//"'"3gic affairs between star-crossed lovers, passion that
//-anscends even death, and chaste adoration between  ,
//-out knights and the monarchs and nobles theyserve.
//The novels of the Dragonlance saga exemplify the
//.radition of epic fantasy in D&D.
//_, fYTHIC FANTASY
//lliJe an angry god tries time and again to destroy him, clever rogue makes the long journey home 
//from war.
//Braving the terrifying guardians of the underworld, a
//-:ible warrior ventures into the darkness to retrieve the
//:-JUI of her lost love. Calling on their divine parentage, group of demigods undertake twelve 
//labors to win the s•  blessings for other mortals.
//mythic-fantasycampaign draws on the themes and
//-- ries of ancient myth and legend, from Gilgamesh
//Cu Chulainn. Adventurers attempt mighty feats of
//_Jend, aided or hindered by the gods or their agents-
//n, d they might have divine blood themselves. The
//-onsters andvillains they face probably have a similai-9 19
//-..igin. The minotaur in the dungeon isn't just another uU-headed humanoid, but the 
//Minotaur-misbegotten
//::spring of a philandering god. Adventures might le!3d heroes through a series of trials to the 
//realms of the
//"'"Xisin search of a gift or favor.
//Such a campaign can draw on the myths and legends
//- any culture, not just the familiar Greek tales.

//DARK FANTASY
//Vampires brood on the battlements of their accursed castles. Necromancers toil in dark dungeons to 
//create horridservants made of dead flesh. Devils corrupt the innocent, and werewolves prowl 
//thenight. All of these elements evoke horrific aspects of the fantasy genre.
//lf you want to put a horror spin on your campaign, you have plenty of material to work with. 
//TheMonster Manual is full ofcreatures that perfectly suit a storyline of supernatural horror. The 
//most important element of such a campaign. though, isn't covered by the rules. A dark-fantasy 
//setting requires an atmosphere of building dread, created through careful pacing and evocative 
//description. Your players contribute too; they have to
//be willing toembrace the mood you're trying to evoke. Whether you want to run a full-fledged 
//dark-fantasy campaign or a single creepy adventure, you should discuss your plans with theplayers 
//ahead of time to make sure they're on board. Horror canbe intense and personal, and not everyone is 
//comfortable with such a game.
//Novels and game products set in Ravenloft, the DemipJane of Dread, explore dark-fantasy elements in 
//a D&D context.
//INTRIGUE
//The corrupt vizier schemes with the baron's oldest daughter to assassinate the baron. A hobgoblin 
//army sends doppelganger spies to infiltrate the city before the invasion. At the embassy ball, the 
//spy in theroyal court makes contact with his employer.
//Political intrigue, espionage, sabotage, and similar cloak-and-dagger activities can provide the 
//basis for an excitingD&D campaign. In this kind of game, the characters might care more about skill 
//training and making contacts than about attack spells and magic weapons. Roleplaying and social 
//interaction take on
//greater importance than combat, and the party might go for several sessions without seeing a 
//monster.
//Again, make sure your players know ahead of time that you want to run thiskindofcampaign. 
//Otherwise, a player might create a defense-focuseddwarf paladin, only to find he is out of place 
//among half-elf diplomats and tiefling spies.
//The Brimstone Angels novels by Erin M. Evans focus
//on intrigue in the Forgotten Realms setting, from the backstabbing politics of theNine Hells to 
//thecontested succession of Cormyrean royalty.
//MYSTERY
//Who stole three legendary magic weapons and hid them away in a remote dungeon, leaving a cryptic 
//clue to their location? Who placed the duke into amagical slumber, and what can be done to awaken 
//him? Who murdered the guildmaster, and how did the killer get into the guild's locked vault?
//A mystery-themed campaign puts the characters in the role of investigators, perhaps traveling from 
//town to town to crack tough cases the local authorities can't handle. Such a campaign emphasizes 
//puzzles and problem-solving in addition to combat prowess.
//A larger mystery might even set the stage for the whole campaign. Why did someone kill 
//thecharacters' mentor, setting them on the path of adventure? Who really controls the Cult of 
//theRed Hand? In this case, the characters might uncover clues to the greater mystery only once in a 
//while; individual adventures might be at best tangentially related to that theme. A diet of nothing 
//but puzzles can become frustrating, so be sure to mix up the kinds of encounters you present.
//Novels in various D&D settings have explored the mystery genre with a fantasy twist. In particular,
//Murder in Cormyr (by Chet Williamson), Murder in Halruaa (by Richard S. Meyers), and Spellstorm (by 
//Ed Greenwood) are mysteries set in the Forgotten Realms. Murder
//in Tarsis (byJohn Maddox Roberts) takes the same approach in the Dragonlance setting.
//SWASHBUCKLING
//Rapier-wieldingsailors fight off boarding sabuagin. Ghouls lurk in derelict ships, waiting to 
//devour treasure hunters. Dashingrogues and charming paladins weave their way through palace 
//intrigues and leap from balconies onto waiting horses below.
//The swashbuckling adventures of pirates and musketeers suggest opportunities for a dynamic 
//campaign. The characters typically spend more time in cities, royal courts, and seafaring vessels 
//than in dungeon delves, making interaction skills
//important (though not to the extent of a pure intrigue campaign). Nevertheless, the heroes might 
//end up in classic dungeon situations, such as searching storm sewers beneath the palace to find the 
//evil duke's hidden cbambers.
//A good example of a swashbuckling rogue in the Forgotten Realms is Jack Ravenwild, who appears in 
//novels by Richard Baker (City of Ravens and Prince ofRavens).
//WAR
//A hobgoblin army marches toward the city, leading elephants and giants to batter down the 
//stronghold's walls and ramparts. Dragons wheel above a barbarian horde, scattering enemies as the 
//raging warriors
//cut a swath through fieldand forest. Salamanders muster at an efreeti's command, poised to assault 
//an astral fortress.

//arfare in a fantasy world is rife with opportunities adventure. A war campaign isn't generally 
//concerned
//• lhe specifics of troop movements, but instead u.. s on the heroes whose actions turn the tide of
//• ie. The characters carry out specific missions:
//·urea magical standard that empowers undead l!:tllies.gather reinforcements to break a siege, or
//_. through the enemy's flank to reach a demonic
//---:mmander.In other situations, the party supports larger army by holding a strategic location 
//until
//-forcements arrive, killing enemy scouts before
//.  can report, or cutting off supply lines.Information
//-ering and diplomatic missions can supplement the
//-re combat-oriented adventures.
//ne War of the Lance in the Dragonlance Chronicles and the War of the Spider Queen in the novel
//....es of the same name are prominent examples of
//-sin D&Dnovels.
//t'XIA
//· a sensei disappears mysteriously, her young dems must take her place and hunt down the oni
//rizing their village. Accomplished heroes, masters eir respective martial arts, return home to free 
//their ge from an evil hobgoblin warlord. The rakshasa
//srer of a nearby monastery performs rituals to raise led ghosts from their rest.
//-'i rampaign that draws on elements of Asian martial-
//- moviesis a perfect match for D&D.Players can the appearance of their characters and gear
//:er they like for thecampaign, and spells need only
//"'r flavor changes so that they better reflect such a

//g. For example, when the characters use spells
//,,, pedal abilities that teleport them short distances, actually make high-flying acrobatic leaps. 
//Ability
//-;.s toclimb don't involve careful searching for holds
//'e, characters bounce up walls or from tree to tree.
//:riorsstun their opponents by striking pressure
//-. Flavorful descriptions of actions in the game
//• change the nuts and bolts of the rules, but they
//i.e all the difference in the feel of a campaign.
//- ""'lilarly, a class doesn't need new rules to reflect
//•ural influence; a new name can do the trick. A
//•·ooal Chinese wuxia hero might be a paladjn
//as a sword called the Oath of Vengeance, while a


//_nese samurai might be a paladin with aparticular '"of Devotion (bushido) that includes fealty to a
//daimyo) among its tenets. A ninja is a monk who
//-.ies the Way of Shadow. Whether called a wu jen,
//--kai, oraswami, a wizard, sorcerer, or warlock "clCter worksjust finein a game inspired by 
//medieval
//- ..., cultures.

//. IA WEAPON NAMES
//-  .ng players refer to a tetsubo or a katana rather than
//:-eatclub or a longsword can enhance the flavor of
//-Xia campaign. The Wuxia Weapon Names table "alternative names for common weapons from Players 
//Handbook and identifies their real-world
//cultural origins. An altemati\·e name changes none of
//the weapon's properties as ther are described in the
//Players Handbook.
//CROSSING THE STREAMS
//The renowned paladin Murlynd, from the world of Oerth (as featured in Greyhawk novels and game 
//products), dresses in the traditional garb of Earth's Old West and wears a pair of six-shooters 
//strapped to his waist. The Mace of St. Cuthbert, a holy weapon belonging to Greyhawk's god of 
//justice, found its way
//to the Victoria and Albert Museum in London in 1985. Somewhere in the Barrier Peaks of Oerth, the 
//wreckage of a spacefaring vessel is said to lie, with bizarre alien lifeforms and strange items of 
//technology on board. And the famous wizard Elminster of the Forgotten Realms has been said to make 
//occasional appearances in the kitchen of Canadian writer Ed Greenwood-where he is sometimes joined 
//by wizards from the worlds of Oerth and Krynn (homeworld of the Dragonlaoce saga).
//Deep in D&D's rootsare elements of science fiction and science fantasy, and your campaign might 
//draw on those sources as well. It's okay to send your characters hurtling through a magic mirror 
//toLewis
//Carroll's Wonderland, put them aboard a ship traveling between the stars, or set your campaign in a 
//far-future world where laser blasters and magic missiles exist side by side. The possibilities are 
//limitless. Chapter
//9, "Dungeon Master's Workshop," provides tools for exploring those possibilities.

//WUXIA WEAPON NAMES

//Weapon Battleaxe Club Dagger Dart
//Flail Glaive Greatclub
//Greatsword Halberd Handaxe Javelin
//Other Names (Culture)
//fu (China); masakari(Japan)
//bian(China); tonfa(Japan)
//bishou, tamo (China); kozuka, tanto (Japan)
//shuriken (Japan)
//nunchaku (Japan)
//guandao (China); bisento, naginata (Japan)
//tetsubo (Japan)
//changdao (China); nodachi(Japan)
//Ji(China); kamayari(Japan)
//ono(Japan)
//mau(China); uchi - ne(Japan)
//Lance umayari(Japan)
//Longbow daikyu(Japan)
//Longsword jian(China); katana(Japan) Mace chui(China); kanabo(Japan)
//Pike mao(China); nagaeyari(Japan) Quarterstaff gun(China); bo(Japan)
//Scimitar Shortbow Shortsword Sickle Spear Trident War pick
//liuyedao (China); wakizashi(Japan)
//hankyu(Japan) shuangdao(China) kama(Japan)
//qiang(China); yari(Japan)
//cha(China); magariyari(Japan)
//fang(China); kuwa(Japan)
