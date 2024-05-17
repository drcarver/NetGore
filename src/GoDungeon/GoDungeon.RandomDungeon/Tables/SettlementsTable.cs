using System;
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.RandomDungeon.Enum;
using GoDungeon.RandomDungeon.Interfaces;
using GoDungeon.RandomDungeon.ViewModels;

namespace GoDungeon.RandomDungeon.Tables
{
    public class SettlementTable : RandomTable, ISettlementsTable
    {
        /// <summary>
        /// A settlement gives the adventurers a place to live, train, and recuperate 
        /// between adventures.An entire campaign can center on a particular town or 
        /// city.  Such a settlement is the launching pad from which the
        /// characters go out into the wider world.
        /// </summary>
        public SettlementTable()
        {
            Name = nameof(SettlementTable);
            ProperName = "Settlements Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description =
                "A settlement gives the adventurers a place to live, train, " +
                "and recuperate between adventures. An entire campaign can " +
                "center on a particular town or city. Such a settlement is " +
                "the launching pad from which the characters go out into the " +
                "wider world.";
        }

        //Settlement Table
        //d20 Settlement
        //1-13  Village
        //14-17  Town
        //17-20  City
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
                    #region 1-13  Village
                    //VILLAGE
                    //Population: Up to about 1,000
                    //Government: A noble(usually not a resident) rules the village, with an appointed agent(a reeve)
                    //in residence to adjudicate disputes and collect taxes.
                    //Defense: The reeve might have a small force of soldiers.Otherwise, the village relies on a citizen
                    //militia.
                    //Commerce: Basic supplies are readily available, possibly from an inn or a trading post.Other goods
                    //are available from traveling merchants.
                    //Organizations:A village might contain one or two temples or shrines, but few or no other
                    //organizations.
                    //Most settlements are agricultural villages, supporting
                    //•Themselves and nearby towns or cities with crops and meat. Villagers produce food in one way or
                    //another-if not by tending the crops, then supporting those who do by shoeing horses, weaving
                    //clothes, milling grain, and he like.The goods they produce feed their families and supply trade
                    //with nearby settlements.
                    //A village's population is dispersed around a large area of land. Farmers live on their land, which 
                    //spreads them widely around the village center.At the heart of the
                    //Village, a handful of structures cluster together: a well, a marketplace, a small temple or two, a
                    //gathering place, and perhaps an inn for travelers.
                    //1-13  Village
                    new SettlementTableEntryViewModel
                    {
                        Range = new Range(01, 13),
                        Name = nameof(SettlementEnum.Village),
                        ProperName = nameof(SettlementEnum.Village),
                        Description = "Most settlements are agricultural villages, supporting themselves and nearby towns or cities with crops and meat. Villagers produce food in one way or another-if not by tending the crops, then supporting those who do by shoeing horses, weaving clothes, milling grain, and he like.The goods they produce feed their families and supply trade with nearby settlements.",
                        Population = "Up to about 1,000",
                        Government = "A noble (usually not a resident) rules the village, with an appointed agent (a reeve) in residence to adjudicate disputes and collect taxes.",
                        Defense = "The reeve might have a small force of soldiers.Otherwise, the village relies on a citizen militia.",
                        Commerce = "Basic supplies are readily available, possibly from an inn or a trading post. Other goods are available from traveling merchants.",
                        Organizations = "A village might contain one or two temples or shrines, but few or no other organizations."
                    },
                    #endregion

                    #region 14-17  Town
                    //TOWN
                    //Population: Up to about 6,000
                    //Government: A resident noble rules and appoints a lord mayor to oversee administration. An elected
                    //town council represents the interests of the middle class.
                    //Defense: The noble commands a sizable army of professional soldiers, as well as personal
                    //bodyguards.
                    //Commerce: Basic supplies are readily available, though exotic goods and services are harde·r to
                    //find.Inns and taverns support travelers.
                    //Organizations:The town contains several temples, as well as various merchant guilds and other
                    //organizations.
                    //Towns are major trade centers, situated where important industries and reliable trade routes
                    //enabled the population to grow. These settlements rely on commerce: the import of raw materials and
                    //food from surrounding Villages, and the export of crafted items to those villages, as well as to other towns and cities.
                    //A town's population is more diverse than that of most villages.
                    //Towns arise where roads intersect waterways, at the meeting of major land trade routes, around
                    //strategic defensive locations, or near significant mines or similar natural resources.
                    new SettlementTableEntryViewModel
                    {
                        Range = new Range(14, 17),
                        Name = nameof(SettlementEnum.Town),
                        ProperName = nameof(SettlementEnum.Town),
                        Description = "Towns are major trade centers, situated where important industries and reliable trade routes enabled the population to grow. These settlements rely on commerce: the import of raw materials and food from surrounding Villages, and the export of crafted items to those villages, as well as to other towns and cities.",
                        Population = "Up to about 6,000",
                        Government = "A resident noble rules and appoints a lord mayor to oversee administration. An elected town council represents the interests of the middle class.",
                        Defense = "The noble commands a sizable army of professional soldiers, as well as personal bodyguards.",
                        Commerce = "Basic supplies are readily available, though exotic goods and services are harder to find. Inns and taverns support travelers.",
                        Organizations = "The town contains several temples, as well as various merchant guilds and other organizations."
                    },
                    #endregion

                    #region 18-20  City
                    //CITY
                    //Population: Up to about 25,000
                    //Government: A resident noble presides, with several other nobles sharing responsibility for 
                    //surrounding areas and government functions.One such noble is the lord mayor, who oversees the city
                    //administration.An elected city council represents the middle class and might hold more actual
                    //power than the lord mayor.Other groups serve as important power centers as well.
                    //Defense: The city supports an army of professional soldiers, guards, and town watch.Each noble in
                    //residence maintains a small force of personal bodyguards.
                    //Commerce: Almost any goods or services are readily available. Many inns and taverns support
                    //travelers.
                    //Organizations: A multitude of temples, guilds, and other organizations, some of which hold
                    //significant power in city affairs, can be found within the
                    //city's walls.
                    //Cities are cradles of civilization.Their larger populations require considerable support from both
                    //surrounding villages and trade routes, so they're rare.
                    //Cities typically thrive in areas where large expanses of fertile, arable land surround a location
                    //accessible to trade, almost always on a navigable waterway.
                    //Cities almost always have walls, and the stages of a city's growth are easily identified by the 
                    //expansion of the walls beyond the central core. These internal walls naturally divide the city into
                    //wards(neighborhoods defined by specific features), which have their own representatives on the
                    //city council and their own noble administrators.
                    //Cities that hold more than twenty-five thousand people are extremely rare. Metropolises such as 
                    //Waterdeep in the Forgotten Realms, Sharn in Eberron, and the Free City of Greyhawk stand as vital
                    //beacons of civilization in the D&D worlds.
                    //ATMOSPHERE
                    //What do the adventurers first notice as they approach or enter a settlement? The towering wall
                    //bristling with soldiers? The beggars with hands outstretched, pleading for aid outside the gate? 
                    //The noisy hubbub of merchants and buyers thronging the market square? The overpowering stench of
                    //manure?
                    //Sensory details help bring a settlement to life and vividly communicate its personality to your
                    //players. Settle on a single defining factor that sums up a settlement's personality and extrapolate 
                    //from there. Maybe a city is built around canals, like real-world Venice. That key element suggests
                    //a wealth of sensory details: the sight of colorful boats floating on muddy waters, the sound of
                    //lapping waves and perhaps singing gondoliers, the smells of fish and waste polluting
                    //the water, the feel of humidity. Or perhaps the city is shrouded in fog much of the time, and you
                    //describe the tendrils of cold mist reaching through every crack and cranny, the muffled sounds of
                    //hooves on cobblestones, the cold air with the smell of rain, and a sense of mystery and lurking
                    //danger.
                    //The climate and terrain of a settlement's environment, its origin and inhabitants, its government 
                    //and political position, and its commercial importance all have a bearing on its overall atmosphere. 
                    //A city nestled against the edge of a jungle has a very different feel than one
                    //on the edge of a desert.Elf and dwarf cities present a distinct aesthetic, clearly identifiable in
                    //contrast to human-built ones. Soldiers patrol the streets to quell
                    //any hint of dissent in a city ruled by a tyrant, while a city fostering an early system of
                    //democracy might boast an open-air market where philosophical ideas are traded as freely as produce.
                    //All the possible combinations of these factors can inspire endless variety in the settlements of
                    //your campaign world.
                    new SettlementTableEntryViewModel
                    {
                        Range = new Range(18, 20),
                        Name = nameof(SettlementEnum.City),
                        ProperName = nameof(SettlementEnum.City),
                        Description = "Cities are cradles of civilization.Their larger populations require considerable support from both surrounding villages and trade routes, so they're rare. Cities typically thrive in areas where large expanses of fertile, arable land surround a location accessible to trade, almost always on a navigable waterway. Cities almost always have walls, and the stages of a city's growth are easily identified by the expansion of the walls beyond the central core. These internal walls naturally divide the city into wards (neighborhoods defined by specific features), which have their own representatives on the city council and their own noble administrators. Cities that hold more than twenty-five thousand people are extremely rare.",
                        Population = "Up to about 25,000",
                        Government = "A resident noble presides, with several other nobles sharing responsibility for surrounding areas and government functions.One such noble is the lord mayor, who oversees the city administration. An elected city council represents the middle class and might hold more actual power than the lord mayor.Other groups serve as important power centers as well.",
                        Defense = "The city supports an army of professional soldiers, guards, and town watch.Each noble in residence maintains a small force of personal bodyguards.",
                        Commerce = "Almost any goods or services are readily available. Many inns and taverns support travelers.",
                        Organizations = "A multitude of temples, guilds, and other organizations, some of which hold significant power in city affairs, can be found within the city's walls."
                    },
                    #endregion
                };
            }
        }
    }
}
