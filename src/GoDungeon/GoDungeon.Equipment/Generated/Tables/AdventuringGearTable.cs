//
// Adventuring Gear
// Containing file adventuring\equipment\adventuring_gear.md
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Equipment.Enum;
using GoDungeon.Equipment.Interfaces;
using GoDungeon.Equipment.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Equipment.Tables;

/// <summary>
/// Adventuring Gear
/// </summary>
public partial class AdventuringGearTable : NamedTable, IAdventuringGearTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public AdventuringGearTable()
	{
		Name = nameof(AdventuringGearTable);
		ProperName = "Adventuring Gear Table";
		Description = "Adventuring Gear";
	}

	/// <summary>
	/// Initialize the table.  This is a separate method so
	/// we can create a game table for it's meta properties
	/// with out creating the actual table values.  A bit of
	/// optimization to conserve memory on big tables
	/// </summary>
	public override void InitializeTable()
	{
		if (Table == null || Table.Count == 0)
		{
			Table = new ObservableCollection<IGameTableEntry>()
			{
				#region Abacus
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Abacus),
					ProperName = "Abacus",
					Cost = "2 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Acid (vial)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Acidvial),
					ProperName = "Acid (vial)",
					Cost = "25 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Alchemist's fire (flask)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Alchemistsfireflask),
					ProperName = "Alchemist's fire (flask)",
					Cost = "50 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Antitoxin (vial)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Antitoxinvial),
					ProperName = "Antitoxin (vial)",
					Cost = "50 gp",
					Weight = "-",
				},
				#endregion

				#region Backpack
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Backpack),
					ProperName = "Backpack",
					Cost = "2 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Ball bearings (bag of 1,000)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Ballbearingsbagof1000),
					ProperName = "Ball bearings (bag of 1,000)",
					Cost = "1 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Barrel
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Barrel),
					ProperName = "Barrel",
					Cost = "2 gp",
					Weight = "70 lb.",
				},
				#endregion

				#region Basket
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Basket),
					ProperName = "Basket",
					Cost = "4 sp",
					Weight = "2 lb.",
				},
				#endregion

				#region Bedroll
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Bedroll),
					ProperName = "Bedroll",
					Cost = "1 gp",
					Weight = "7 lb.",
				},
				#endregion

				#region Bell
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Bell),
					ProperName = "Bell",
					Cost = "1 gp",
					Weight = "-",
				},
				#endregion

				#region Blanket
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Blanket),
					ProperName = "Blanket",
					Cost = "5 sp",
					Weight = "3 lb.",
				},
				#endregion

				#region Block and tackle
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Blockandtackle),
					ProperName = "Block and tackle",
					Cost = "1 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Book
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Book),
					ProperName = "Book",
					Cost = "25 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Bottle, glass
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Bottleglass),
					ProperName = "Bottle, glass",
					Cost = "2 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Bucket
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Bucket),
					ProperName = "Bucket",
					Cost = "5 cp",
					Weight = "2 lb.",
				},
				#endregion

				#region Caltrops (bag of 20)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Caltropsbagof20),
					ProperName = "Caltrops (bag of 20)",
					Cost = "1 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Candle
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Candle),
					ProperName = "Candle",
					Cost = "1 cp",
					Weight = "-",
				},
				#endregion

				#region Case, crossbow bolt
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Casecrossbowbolt),
					ProperName = "Case, crossbow bolt",
					Cost = "1 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Case, map or scroll
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Casemaporscroll),
					ProperName = "Case, map or scroll",
					Cost = "1 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Chain (10 feet)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Chain10feet),
					ProperName = "Chain (10 feet)",
					Cost = "5 gp",
					Weight = "10 lb.",
				},
				#endregion

				#region Chalk (1 piece)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Chalk1piece),
					ProperName = "Chalk (1 piece)",
					Cost = "1 cp",
					Weight = "-",
				},
				#endregion

				#region Chest
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Chest),
					ProperName = "Chest",
					Cost = "5 gp",
					Weight = "25 lb.",
				},
				#endregion

				#region Climber's kit
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Climberskit),
					ProperName = "Climber's kit",
					Cost = "25 gp",
					Weight = "12 lb.",
				},
				#endregion

				#region Clothes, common
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Clothescommon),
					ProperName = "Clothes, common",
					Cost = "5 sp",
					Weight = "3 lb.",
				},
				#endregion

				#region Clothes, costume
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Clothescostume),
					ProperName = "Clothes, costume",
					Cost = "5 gp",
					Weight = "4 lb.",
				},
				#endregion

				#region Clothes, fine
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Clothesfine),
					ProperName = "Clothes, fine",
					Cost = "15 gp",
					Weight = "6 lb.",
				},
				#endregion

				#region Clothes, traveler's
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Clothestravelers),
					ProperName = "Clothes, traveler's",
					Cost = "2 gp",
					Weight = "4 lb.",
				},
				#endregion

				#region Component pouch
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Componentpouch),
					ProperName = "Component pouch",
					Cost = "25 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Crowbar
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Crowbar),
					ProperName = "Crowbar",
					Cost = "2 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Fishing tackle
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Fishingtackle),
					ProperName = "Fishing tackle",
					Cost = "1 gp",
					Weight = "4 lb.",
				},
				#endregion

				#region Flask or tankard
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Flaskortankard),
					ProperName = "Flask or tankard",
					Cost = "2 cp",
					Weight = "1 lb.",
				},
				#endregion

				#region Grappling hook
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Grapplinghook),
					ProperName = "Grappling hook",
					Cost = "2 gp",
					Weight = "4 lb.",
				},
				#endregion

				#region Hammer
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Hammer),
					ProperName = "Hammer",
					Cost = "1 gp",
					Weight = "3 lb.",
				},
				#endregion

				#region Hammer, sledge
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Hammersledge),
					ProperName = "Hammer, sledge",
					Cost = "2 gp",
					Weight = "10 lb.",
				},
				#endregion

				#region Healer's kit
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Healerskit),
					ProperName = "Healer's kit",
					Cost = "5 gp",
					Weight = "3 lb.",
				},
				#endregion

				#region Holy water (flask)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Holywaterflask),
					ProperName = "Holy water (flask)",
					Cost = "25 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Hourglass
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Hourglass),
					ProperName = "Hourglass",
					Cost = "25 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Hunting trap
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Huntingtrap),
					ProperName = "Hunting trap",
					Cost = "5 gp",
					Weight = "25 lb.",
				},
				#endregion

				#region Ink (1 ounce bottle)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Ink1ouncebottle),
					ProperName = "Ink (1 ounce bottle)",
					Cost = "10 gp",
					Weight = "-",
				},
				#endregion

				#region Ink pen
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Inkpen),
					ProperName = "Ink pen",
					Cost = "2 cp",
					Weight = "-",
				},
				#endregion

				#region Jug or pitcher
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Jugorpitcher),
					ProperName = "Jug or pitcher",
					Cost = "2 cp",
					Weight = "4 lb.",
				},
				#endregion

				#region Ladder (10 foot)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Ladder10foot),
					ProperName = "Ladder (10 foot)",
					Cost = "1 sp",
					Weight = "25 lb.",
				},
				#endregion

				#region Lamp
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Lamp),
					ProperName = "Lamp",
					Cost = "5 sp",
					Weight = "1 lb.",
				},
				#endregion

				#region Lantern, bullseye
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Lanternbullseye),
					ProperName = "Lantern, bullseye",
					Cost = "10 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Lantern, hooded
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Lanternhooded),
					ProperName = "Lantern, hooded",
					Cost = "5 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Lock
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Lock),
					ProperName = "Lock",
					Cost = "10 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Magnifying glass
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Magnifyingglass),
					ProperName = "Magnifying glass",
					Cost = "100 gp",
					Weight = "-",
				},
				#endregion

				#region Manacles
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Manacles),
					ProperName = "Manacles",
					Cost = "2 gp",
					Weight = "6 lb.",
				},
				#endregion

				#region Mess kit
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Messkit),
					ProperName = "Mess kit",
					Cost = "2 sp",
					Weight = "1 lb.",
				},
				#endregion

				#region Mirror, steel
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Mirrorsteel),
					ProperName = "Mirror, steel",
					Cost = "5 gp",
					Weight = "1/2 lb.",
				},
				#endregion

				#region Oil (flask)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Oilflask),
					ProperName = "Oil (flask)",
					Cost = "1 sp",
					Weight = "1 lb.",
				},
				#endregion

				#region Paper (one sheet)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Paperonesheet),
					ProperName = "Paper (one sheet)",
					Cost = "2 sp",
					Weight = "-",
				},
				#endregion

				#region Parchment (one sheet)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Parchmentonesheet),
					ProperName = "Parchment (one sheet)",
					Cost = "1 sp",
					Weight = "-",
				},
				#endregion

				#region Perfume (vial)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Perfumevial),
					ProperName = "Perfume (vial)",
					Cost = "5 gp",
					Weight = "-",
				},
				#endregion

				#region Pick, miner's
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Pickminers),
					ProperName = "Pick, miner's",
					Cost = "2 gp",
					Weight = "10 lb.",
				},
				#endregion

				#region Piton
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Piton),
					ProperName = "Piton",
					Cost = "5 cp",
					Weight = "1/4 lb.",
				},
				#endregion

				#region Poison, basic (vial)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Poisonbasicvial),
					ProperName = "Poison, basic (vial)",
					Cost = "100 gp",
					Weight = "-",
				},
				#endregion

				#region Pole (10-foot)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Pole10foot),
					ProperName = "Pole (10-foot)",
					Cost = "5 cp",
					Weight = "7 lb.",
				},
				#endregion

				#region Pot, iron
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Potiron),
					ProperName = "Pot, iron",
					Cost = "2 gp",
					Weight = "10 lb.",
				},
				#endregion

				#region Potion of healing
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Potionofhealing),
					ProperName = "Potion of healing",
					Cost = "50 gp",
					Weight = "1/2 lb.",
				},
				#endregion

				#region Pouch
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Pouch),
					ProperName = "Pouch",
					Cost = "5 sp",
					Weight = "1 lb.",
				},
				#endregion

				#region Quiver
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Quiver),
					ProperName = "Quiver",
					Cost = "1 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Ram, portable
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Ramportable),
					ProperName = "Ram, portable",
					Cost = "4 gp",
					Weight = "35 lb.",
				},
				#endregion

				#region Rations (1 day)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Rations1day),
					ProperName = "Rations (1 day)",
					Cost = "5 sp",
					Weight = "2 lb.",
				},
				#endregion

				#region Robes
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Robes),
					ProperName = "Robes",
					Cost = "1 gp",
					Weight = "4 lb.",
				},
				#endregion

				#region Rope, hempen (50 feet)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Ropehempen50feet),
					ProperName = "Rope, hempen (50 feet)",
					Cost = "1 gp",
					Weight = "10 lb.",
				},
				#endregion

				#region Rope, silk (50 feet)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Ropesilk50feet),
					ProperName = "Rope, silk (50 feet)",
					Cost = "10 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Sack
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Sack),
					ProperName = "Sack",
					Cost = "1 cp",
					Weight = "1/2 lb.",
				},
				#endregion

				#region Scale, merchant's
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Scalemerchants),
					ProperName = "Scale, merchant's",
					Cost = "5 gp",
					Weight = "3 lb.",
				},
				#endregion

				#region Sealing wax
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Sealingwax),
					ProperName = "Sealing wax",
					Cost = "5 sp",
					Weight = "-",
				},
				#endregion

				#region Shovel
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Shovel),
					ProperName = "Shovel",
					Cost = "2 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Signal whistle
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Signalwhistle),
					ProperName = "Signal whistle",
					Cost = "5 cp",
					Weight = "-",
				},
				#endregion

				#region Signet ring
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Signetring),
					ProperName = "Signet ring",
					Cost = "5 gp",
					Weight = "-",
				},
				#endregion

				#region Soap
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Soap),
					ProperName = "Soap",
					Cost = "2 cp",
					Weight = "-",
				},
				#endregion

				#region Spellbook
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Spellbook),
					ProperName = "Spellbook",
					Cost = "50 gp",
					Weight = "3 lb.",
				},
				#endregion

				#region Spikes, iron (10)
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Spikesiron10),
					ProperName = "Spikes, iron (10)",
					Cost = "1 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Spyglass
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Spyglass),
					ProperName = "Spyglass",
					Cost = "1,000 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Tent, two-person
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Tenttwoperson),
					ProperName = "Tent, two-person",
					Cost = "2 gp",
					Weight = "20 lb.",
				},
				#endregion

				#region Tinderbox
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Tinderbox),
					ProperName = "Tinderbox",
					Cost = "5 sp",
					Weight = "1 lb.",
				},
				#endregion

				#region Torch
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Torch),
					ProperName = "Torch",
					Cost = "1 cp",
					Weight = "1 lb.",
				},
				#endregion

				#region Vial
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Vial),
					ProperName = "Vial",
					Cost = "1 gp",
					Weight = "-",
				},
				#endregion

				#region Waterskin
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Waterskin),
					ProperName = "Waterskin",
					Cost = "2 sp",
					Weight = "5 lb. (full)",
				},
				#endregion

				#region Whetstone
				new AdventuringGearTableEntryViewModel
				{
					Name = nameof(AdventuringGearEnum.Whetstone),
					ProperName = "Whetstone",
					Cost = "1 cp",
					Weight = "1 lb.",
				},
				#endregion

			};
		}
	}
}
