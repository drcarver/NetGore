using System;
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.RandomDungeon.Enum;
using GoDungeon.RandomDungeon.Interfaces;

namespace GoDungeon.RandomDungeon.Tables
{
    /// <summary>
    /// </summary>
    public class WorldShakingEventsTable : RandomTable, IWorldShakingEventsTable
    {
        /// <summary>
        /// </summary>
        public WorldShakingEventsTable()
        {
            Name = nameof(WorldShakingEventsTable);
            ProperName = "World-Shaking Events Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description =
                "";
        }
 
        /// <summary>
        /// Initialize the game table.  This is a separate method so we 
        /// can create a game table for it's meta properties
        /// with out creating the actual able values.  A bit of 
        /// optimization to conserve memory on big tables
        /// </summary>
        public override void InitializeTable()
        {
            if (Table == null || Table.Count == 0)
            {
                Table = new ObservableCollection<IGameTableEntry>
                {
                    #region Square, 20 x 20 ft.; passage on each wall
                    //1   Square, 20 x 20 ft.; passage on each wall
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 01),
                        Name = nameof(StartingAreaEnum.Square20ft),
                    },
                    #endregion
                };
            }
        }
    }
    //1-2.
    //RISE OR FALL OF A LEADER ORAN ERA
    //Eras are often defined by the prominent leaders, innovators, and tyrants of the day.These people
    //change the world and etch their signatures indelibly on the pages of history. When they rise to
    //power, they shape the time and place where they live in monumental ways. When they fall from power
    //or pass away, the ghost of their presence lingers.
    //Determine the kind of leader that influences the new or passing era.You can choose the type of
    //leader or determine one randomly using the Leader Types table.
    //LEADER TYPES
    //d6 Leader Type
    //l  Political
    //2  Religious
    //3  Military
    //4  Crime/underworld
    //5  Art/culture
    //6  Philosophy/learning/magic
    //Political leaders are monarchs, nobles, and chiefs.Religious leaders include deities' avatars, 
    //high priests, and messiahs, as well as those in charge of monasteries and leaders of influential
    //religious sects.Major military leaders control the armed forces of countries.They include
    //military dictators, warlords, and the heads of
    //a ruler's war council. Minor military leaders include the heads of local militias, gangs, and other 
    //martial organizations. At the broadest scale, a criminal or underworld leader wields power through
    //a network of spies, bribes, and black-market trade. On the smallest scale, these are local gang
    //bosses, pirate captains, and brigands. A leader in art or culture is a virtuoso whose work reflects
    //the spirit of the age and changes the way
    //people think: a prominent playwright, bard, or court fool in whose words, art, or performance the
    //people perceive universal truth.Ona smaller scale, this might be an influential local poet,
    //minstrel.satirist, or sculptor.
    //A major leader in philosophy, learning, or magic is a genius philosopher, a counselor to emperors,
    //an
    //enlightened thinker, the head of the highest institution of learning in the world, or an archmage.
    //A minor leader

    //might be a local sage, seer, hedge wizard, wise elder. or teacher.
    //Rise ofa Leader, Beginning ofan Era.In dramatic stories, a new leader's rise often comes at the end 
    //of a period of struggle or turmoil.Sometimes it'sa war or uprising; other times it's an election, 
    //the death of a
    //tyrant, a prophecy fulfilled, or the appointment of a hero.Conversely, the new leader might be a
    //tyrant, a fiend, or black-hearted villain, andtheera that just ended could have been one of peace, 
    //tranquility, and justice.
    //A new leader shakes the foundations of your campaign world and begins a new era in the selected
    //region.How does this person or this era begin to affect the world?
    //Here are several things to consider when determining the leader's impact on the world:
    //Name one thing that has been consistently true about the world, which is now no longer true due to
    //this leader's rise or influence. This is the biggest change that occurs when the new leader takes 
    //power and becomes the prevailing trait that defines the era, the characteristic for which it is 
    //remembered.
    //Name the person (or people) whose death, defeat, or loss opened the door for this leader to take
    //power. This might be a military defeat, the overthrow of old ideas, a cultural rebirth, or
    //something else. Who
    //died, lost, or was defeated? What weren't they willing to compromise? Was the new leader complicit 
    //in
    //the death, defeat, or loss, or was the opportunity
    //serendipitous?
    //Despite the leader's virtues, one flaw in particular outrages a certain segment of the populace. 
    //What is that flaw? What person or group of persons will dotheir utmost to foil this leader because
    //of it?
    //Conversely, what is this leader's greatest virtue, and who rises to the leader's defense because of
    //it?
    //Who believes in this leader now, but stillretains doubts? This is someone close to the leader, who
    //has the leader's trust andknows his or her secret fears, doubts, or vices.
    //Fall ofa Leader, End ofan Era.All that begins must end.With the fall of kings and queens, the
    //maps of the world are redrawn.Laws change. new customs become all the rage, and old ones fall
    //outof favor.The attitude of the citizens toward their fallen leader shifts subtly at first and
    //then changes dramatically as they look back or reminisce about the time before.
    //The fallenleader might have been a benevolent ruler, an influential citizen, or even an adversary
    //to the characters.How does the death of this person affect those formerly under his or her
    //influence? ]i.ere are
    //several things to consider when determining the effects of a leader's passing:
    //Name one positive change that the leader brought to his or her domain or sphere of influence.Does
    //that change persist after the leader's death?
    //State the general mood or attitude of the people under this person's power. What important fact 
    //didn't they realize about this person or his or her reign, which will later come to light?
    //Name one person or group that tries to fill theleader's shoes in the resulting power vacuum.
    //Name one person or group that plotted against this leader.
    //Name three things for which thisleader will be
    //remembered.
    //3. CATACLYSMIC DISASTER
    //Earthquake.famine, fire, plague.flood-disasters on a grand scale can eradicate whole
    //civilizations without warning.Natural (or magical) catastrophes redraw maps, destroy economies,
    //and alter worlds.Sometimes the survivors rebuild from the ruins.The Great Chicago Fire, for 
    //instance, provided an opportunity to rebuild the city according to a modern plan. Most of the time
    //thedisaster leaves only ruins-buried under ash like Pompeii.or sunk beneath the waves like
    //Atlantis.
    //You can choose the cataclysm or determine one randomly using the Cataclysmic Disasters table.

    //CATACLYSMIC DISASTERS
    //dlO Cataclysmic Disaster
    //l  Earthquake
    //2  Famine/drought
    //3  Fire
    //4  Flood
    //s  Plague/disease
    //6  Rain of fire(meteoric impact)
    //7  Storm(hurricane, tornado, tsunami)
    //8  Volcanic eruption
    //9  Magic gone awry or a planar warp
    //10  Divine judgment

    //Some of the disasters on the table might not make immediate sense in the context of your campaign
    //world.A flood in the desert? A volcanic eruption on grassy plains?If you randomly determine a
    //disaster that conflicts with your setting, you can reroll, but the challenge of justifying the
    //catastrophe can produce interesting results.
    //With two exceptions.the disasters on the table resemble those that affect our own world. Think
    //ofplanar warps and magic gone awry like nuclear incidents; they're big events that unnaturally 
    //alter
    //the land and its people.For example, in the Eberron campaign setting, a magical catastrophe lays
    //waste to an entire country, transforming it into a hostile wasteland and ending the Last War.
    //Divine judgment is something else entirely.This disaster takes whatever form you want, but it's 
    //always a big, bold, unsubtle sign of a deity's displeasure.
    //You might decide to wipe a town, region, or nation off the map of your world. A disaster ravages
    //the land and effectively eliminates a place the characters once knew. Leave one or two survivors to
    //tell the characters what happened, and ensure that the characters feel the depth of the
    //catastrophe.What are the ongoing effects of this cataclysm? The following points can help you
    //define the nature and consequences of the disaster:
    //Decide what caused this cataclysm and where it originated.
    //An omen presaged this event, or a series of signs and omens.Describe the omen in detail.

    //Describe or name the creature that warned the populace about the oncoming disas.ter.Who listened? 
    //Who were the lucky (or unlucky) ones who survived? Describe what the area looks like after the
    //disaster, in contrast to how it looked before.

    //- ASSAULT OR INVASION
    //One of the most common world-shaking events, an vasion occurs when one group forcibly takes over
    //another, usually by military strength, but also by
    //nfiltration and occupation.
    //An assault differs from an invasion in that the anacking force isn't necessarily interested in 
    //occupation or taking power. On the other hand, an assault might be he first step of an invasion.
    //Regardless of the scale, a world-shaking assault or
    //; nvasion stands out because its repercussions change he characters' world, and its effects echo 
    //Jong after the nitial attack or takeover.
    //Imagine that part of your campaign world is attacked r invaded.Depending on the current scale of
    //your
    //-ampaign, the area might be as small as a section fa city or as large as a continent, world, or
    //plane of
    //xistence.
    //Define the aggressor and whether it represents a
    //:.mown enemy or a previously unknown adversary.Select a threat that already poses a danger to the
    //area rou've chosen, or use the Invading Forces table to determine the aggressor.

    //INVADING FORCES
    //d8 Invading Force
    //A criminal enterprise
    //2  Monsters or a unique monster
    //3  A planar threat
    //4  A past adversary reawakened, reborn, or resurgent
    //5  A splinter faction
    //6  A savage tribe
    //7  A secret society
    //8  A traitorous ally

    //Now consider these other aspects of the conflict:
    //Name one element of the invasion or assault that the· defenders didn't expect or couldn't repel.
    //Something happened to the first defenders whostood against the invasion or assault-something no one
    //wants to talk about.What was it?
    //The attackers or invaders had a motive for their action that wasn't obvious or understood at first. 
    //What was it?
    //Who turned traitor, and at what point did they turn? Why did they do it? Did an attacker try to
    //stop the incursion, or did a prominent defender throw in with the invaders?
    //5. REBELLION, REVOLUTION, OVERTHROW
    //Dissatisfied with the current order, a person or group of people overturns the dominant regime and
    //takes over-or fails to take over.Regardless of the result, a
    //revolution (even an attempted one) can shape the destiny of nations.
    //The scale of a revolution need not involve the common masses against the nobility.A revolution can
    //be as small as a merchants' guild revolting against its leadership
    //or a temple overthrowing its priesthood in favor of a new creed.The spirits of the forest might
    //attempt to overthrow the forces of civilization in a nearby city that cut down trees for timber.
    //Alternatively, the scale can be as dramatic as humanity rising to overthrow the gods.


    //Imagine that part of your campaign world erupts in revolution.Pick a power group in your current
    //campaign and name (or invent) a group that opposes it. fomenting revolution. Then let the following
    //points help you flesh out the conflict:
    //.,  • Name three things the rebels want or hope to achieve.
    //t9 The rebels achieve a victory against those they wish to overthrow, even if it'sa pyrrhic 
    //victory.Which of their three goals do they achieve? How long is this achievement likely to last?
    //• State the cost exacted upon the old order after its
    //fall from power.Does anyone from the former power group remain in power during the next regime? If
    //the old order remains in power, describe one way that its leaders punish the revolutionaries.
    //One of the rebellion's prominent leaders-in some respects the face of the revolution-was driven by 
    //a personal reason for his or her part in events.Describe this person and state the true reason he
    //or she led the rebellion.
    //What problem existed before the revolution that persists in spite of it?
    //6. EXTINCTION OR DEPLETION
    //Something that once existed in the campaign world is gone.The lost resource might be a precious
    //metal, a species of plant or animal that held an important
    //place in the local ecology, or an entire race or culture of people. Its absence causes a chain
    //reaction that affects every creature that uses or relies on it.
    //You can eliminate a people, place, or thing that previously existed in a certain location or area
    //in your campaign world.On a small scale, the last of a family
    //.dynasty passes away or a once-thriving mining town in the region dries up and becomes a ghost
    //town.On a grand scale, magic dies, the last dragon is slain, or the final fey noble departs the
    //world.
    //What is gone from the world-or the region of the world you've chosen-that once existed there? If 
    //the answer isn't immediately evident, consult the Extinction or Depleti,on table for ideas.

    //EXTINCTION OR DEPLETION
    //d8  Lost Resource
    //A kind of animal (insect, bird, fish, livestock)
    //2  Habitable land
    //3  Magic or magic-users (all magic, or specific kinds or schools of magic)
    //4  A mineral resource(gems, metals, ores)
    //5  A type of monster(unicorn, manticore, dragon)
    //6  A people(family line, clan, culture, race)
    //7  A kind of plant(crop, tree, herb, forest)
    //8  A waterway(river, lake, ocean)

    //Then consider these additional questions:
    //• Name a territory, race, or type of creature that relied on the thing that was lost.How do they
    //compensate? How do they attempt tosubstitute for what was lost?

    //Who or what is to blame for the loss?
    //Describe an immediate consequence of the loss.Forecast one way that the lossimpacts or changes the
    //world in the long term. Who or what suffers the most as a result of the loss? Who or what benefits
    //the most from it?
    //7. NEW ORGANIZATION
    //The foundation of a new order, kingdom.religion, society, cabal, or cult can shake the world with
    //its actions, doctrine, dogma, and policies.On a local scale, a new organization contends with
    //existing power groups, influencing, subverting, dominating, or allying with them to create a
    //stronger base of power.Large and powerful organizations can exert enough influence to rule the
    //world.Some new organizations benefit the populace, while others grow to threaten the civilization
    //they once protected.
    //Perhaps an important new organization arises in one part of your world.It could have humble or
    //auspicious beginnings, but one thing is certain: it is destined to change the world as long as it
    //progresses along its present course.Sometimes an organization's alignment is apparent from 
    //inception, but its morality can remain ambiguous until its doctrines, policies, and traditions are
    //revealed over time. Choose the type of organization, or use the New Organizations table to generate
    //ideas.

    //NEW ORGANIZATIONS
    //dl0 New Organization
    //Crime syndicate/bandit confederacy
    //2  Guild (masons, apothecaries, goldsmiths)
    //3  Magical circle/society
    //4  Military/knightly order
    //5  New family dynasty/tribe/clan
    //6  Philosophy/discipline dedicated to a principle or ideal
    //7  Realm (village, town, duchy, kingdom)
    //8  Religion/sect/denomination
    //9  School/university
    //10  Secret society/cult/cabal

    //Then consider some or all of the following options:
    //The new order supplants a current power group in the world, gaining territory, converts, or
    //defectors and
    //reducing the previous power group's numbers. Who or
    //what does the foundation of this new order supplant? The new order appeals to a specific audience.
    //Decide whether this order attracts a certain race, social class, or character class.
    //The leader of this new order is known for a particular quality valued by his or her followers.
    //Elaborate on why they respect him or her for this quality, and
    //what actions this leader has taken to retain the followers' support.
    //A rival group opposes the foundation of this new organization.Choose an existing power group from
    //your campaign to oppose the new organization, or create one from the categories on the table.
    //Decide why they oppose the new group, who leads them, and what they plan to do to stop their rival.
    //8. DISCOVERY, EXPANSION, INVENTION
    //Discoveries of new lands expand the map and change the boundaries of empires.Discoveries of new
    //magic or technology expand the boundaries of what was once
    //thought possible.New resources or archaeological finds create opportunity and wealth and set
    //prospectors and power groups in motion to vie for their control.
    //A new discovery-or rediscovery-can impact your campaign world in a meaningful way, shaping the
    //course of history and the events of the age.Think of this discovery as a big adventure hook or
    //series of hooks.
    //This is also an opportunity to create a unique monster, item, god, plane, or race for your world. 
    //As long as the discovery matters, it doesn't have to be wholly original, just flavored for your 
    //campaign.
    //A discovery is particularly impressive when the adventurers in your campaign are the ones who make
    //it. If they discover a new mineral with magical properties, map a new land that's eminently 
    //suitable for colonization.or uncover an ancient weapon with the power to wreak devastation on your
    //world.they are likely to set major events in motion.This gives the players the opportunity to see
    //exactly how much influence their actions have on your world.
    //Decide on the type of discovery that is made or use the Discoveries table to generate ideas.

    //DISCOVERIES
    //dl0  Discovery
    //Ancient ruin/lost city of a legendary race
    //2  Animal/monster/magical mutation
    //3  Invention/technology/magic (helpful, destructive)
    //4  New (or forgotten) god or planar entity
    //5  New (or rediscovered) artifact or religious relic
    //6  New land (island, continent, lost world, demiplane)
    //7  Otherworldly object (planar portal, alien spacecraft)
    //8  People (race, tribe, lost civilization, colony)
    //9  Plant (miracle herb, fungal parasite, sentient plant)
    //10  Resource or wealth (gold, gems, mithral)

    //Once you have determined the type of discovery, flesh it out by deciding exactly what it is, who
    //discovered
    //it, and what potential effect it could have on the world. Ideally, previous adventures in your
    //campaign will help you 611 in the blanks, but also keep the following in mind:
    //This discovery benefits a particular person, group, or faction more than others.Who benefits most?
    //Name three benefits they stand to gain from this discovery.This discovery directly harms another
    //person, group, or faction. Who is harmed the most?
    //, This discovery has consequences. Name three repercussions or side effects. Who ignores the
    //repercussions?
    //Name two or three individuals or factions struggling to possess or control this discovery.Who is 
    //likely to win? What do they stand to gain, and what are they willing to do to control the
    //discovery?

    //9. PREDICTION, OMEN, PROPHECY
    //Sometimes the foretelling of a world-shaking event becomes a world-shaking event: an omen that
    //predicts the fall ofempires, the doom of races, and the end
    //of the world. Sometimes an omen points to change for the good, such as the arrival of alegendary
    //hero or savior.But the most dramatic prophecies warn of future tragedies and predict dark ages.
    //Unlike other world-shaking events, the outcome doesn't happen immediately. Instead, individuals or 
    //factions strive to fulfill or avert the prophecy-or shape the exact way il will
    //befulfilled-according to how it will affect them.The prophecy's helpers or hinderers create 
    //adventure hooks in the campaign by the actions they take.A prophecy should foretell a big event on
    //a grand scale, since it will take time to come true (or be averted).
    //Imagine that a world-shaking prophecy comes to light.
    //If events continue on their present course, the prophecy willcome true and the world will change
    //dramatically as a result.Don't shy away from making this prophecy both significant and alarming, 
    //keeping in mind the following points:
    //Create a prophecy that foretells a major change to the campaign world. You can build one from
    //scratch using ideas from the current campaign or randomly determine a world-shaking event and fl sh 
    //out thedetails.
    //Write a list of three or more omens that will occur before the prophecy comes to pass.You can use
    //events that have already occurred in the campaign so that the prophecy is closer to being
    //fulfilled.The rest are events that might or might not happen, depending on the actions of the
    //characters.
    //Describe the person or creature that discovered the prophecy and how it was found. What did this
    //creature gain by revealing it? What did this person lose or sacrifice?
    //Describe the individual or faction that supports the prophecy and works to ensure its fulfillment,
    //and the one that will doallin itspower to avert the prophecy.What is the first step each takes?
    //Who suffers for their efforts?
    //One part of theprophecy is wrong.Choose one of the omens you listed or oneof the details you
    //created for the world-shaking event that the omen predicts. The chosen omen is false, and if 
    //applicable, its opposite is true instead.
    //10. MYTH AND LEGEND
    //If wars, plagues, discoveries, and the like canbe called regular world-shaking events, mythic
    //events exceed and surpass them. A mythic event might occur as the fulfillment of an ancient or
    //long-forgotten prophecy. or it might be an act of divine intervention.
    //Once again, your current campaign probably provides a few ideas for the shape of this event.If you
    //need inspiration, roll ad8ontheWorld-Shaking Events table.instead of the normal dl0.Address the
    //bullet-point notes for that disaster, but magnify the result to the grandest scale you can imagine.

    //The rise or fall ofa leader or era is the death or
    //birth of a god, or the end of an age or the world.A cataclysmic disaster is a world-drowning
    //deluge, an ice age, or a zombie apocalypse. An assault or invasion is a world war, a world-spanning
    //demonic incursion, the awakening of a world-threatening monster, or the final clash between good
    //and evil. A rebellion dethrones a god or gods.or raises a new force(such as a demon
    //lord) to divinity.A new organization is a world-spanning empire or a pantheon of new gods.A
    //discovery is a doomsday device or a portal to eldritch dimensions where world-shattering cosmic
    //horrors dwell.
}
