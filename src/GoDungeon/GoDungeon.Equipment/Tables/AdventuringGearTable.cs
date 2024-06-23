//
// Adventuring Gear
// Containing file adventuring\equipment\adventuring_gear.md
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

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
					Item = "Abacus",
					Cost = "2 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Acid (vial)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Acid (vial)",
					Cost = "25 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Alchemist's fire (flask)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Alchemist's fire (flask)",
					Cost = "50 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Antitoxin (vial)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Antitoxin (vial)",
					Cost = "50 gp",
					Weight = "-",
				},
				#endregion

				#region Backpack
				new AdventuringGearTableEntryViewModel
				{
					Item = "Backpack",
					Cost = "2 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Ball bearings (bag of 1,000)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Ball bearings (bag of 1,000)",
					Cost = "1 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Barrel
				new AdventuringGearTableEntryViewModel
				{
					Item = "Barrel",
					Cost = "2 gp",
					Weight = "70 lb.",
				},
				#endregion

				#region Basket
				new AdventuringGearTableEntryViewModel
				{
					Item = "Basket",
					Cost = "4 sp",
					Weight = "2 lb.",
				},
				#endregion

				#region Bedroll
				new AdventuringGearTableEntryViewModel
				{
					Item = "Bedroll",
					Cost = "1 gp",
					Weight = "7 lb.",
				},
				#endregion

				#region Bell
				new AdventuringGearTableEntryViewModel
				{
					Item = "Bell",
					Cost = "1 gp",
					Weight = "-",
				},
				#endregion

				#region Blanket
				new AdventuringGearTableEntryViewModel
				{
					Item = "Blanket",
					Cost = "5 sp",
					Weight = "3 lb.",
				},
				#endregion

				#region Block and tackle
				new AdventuringGearTableEntryViewModel
				{
					Item = "Block and tackle",
					Cost = "1 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Book
				new AdventuringGearTableEntryViewModel
				{
					Item = "Book",
					Cost = "25 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Bottle, glass
				new AdventuringGearTableEntryViewModel
				{
					Item = "Bottle, glass",
					Cost = "2 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Bucket
				new AdventuringGearTableEntryViewModel
				{
					Item = "Bucket",
					Cost = "5 cp",
					Weight = "2 lb.",
				},
				#endregion

				#region Caltrops (bag of 20)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Caltrops (bag of 20)",
					Cost = "1 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Candle
				new AdventuringGearTableEntryViewModel
				{
					Item = "Candle",
					Cost = "1 cp",
					Weight = "-",
				},
				#endregion

				#region Case, crossbow bolt
				new AdventuringGearTableEntryViewModel
				{
					Item = "Case, crossbow bolt",
					Cost = "1 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Case, map or scroll
				new AdventuringGearTableEntryViewModel
				{
					Item = "Case, map or scroll",
					Cost = "1 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Chain (10 feet)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Chain (10 feet)",
					Cost = "5 gp",
					Weight = "10 lb.",
				},
				#endregion

				#region Chalk (1 piece)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Chalk (1 piece)",
					Cost = "1 cp",
					Weight = "-",
				},
				#endregion

				#region Chest
				new AdventuringGearTableEntryViewModel
				{
					Item = "Chest",
					Cost = "5 gp",
					Weight = "25 lb.",
				},
				#endregion

				#region Climber's kit
				new AdventuringGearTableEntryViewModel
				{
					Item = "Climber's kit",
					Cost = "25 gp",
					Weight = "12 lb.",
				},
				#endregion

				#region Clothes, common
				new AdventuringGearTableEntryViewModel
				{
					Item = "Clothes, common",
					Cost = "5 sp",
					Weight = "3 lb.",
				},
				#endregion

				#region Clothes, costume
				new AdventuringGearTableEntryViewModel
				{
					Item = "Clothes, costume",
					Cost = "5 gp",
					Weight = "4 lb.",
				},
				#endregion

				#region Clothes, fine
				new AdventuringGearTableEntryViewModel
				{
					Item = "Clothes, fine",
					Cost = "15 gp",
					Weight = "6 lb.",
				},
				#endregion

				#region Clothes, traveler's
				new AdventuringGearTableEntryViewModel
				{
					Item = "Clothes, traveler's",
					Cost = "2 gp",
					Weight = "4 lb.",
				},
				#endregion

				#region Component pouch
				new AdventuringGearTableEntryViewModel
				{
					Item = "Component pouch",
					Cost = "25 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Crowbar
				new AdventuringGearTableEntryViewModel
				{
					Item = "Crowbar",
					Cost = "2 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Fishing tackle
				new AdventuringGearTableEntryViewModel
				{
					Item = "Fishing tackle",
					Cost = "1 gp",
					Weight = "4 lb.",
				},
				#endregion

				#region Flask or tankard
				new AdventuringGearTableEntryViewModel
				{
					Item = "Flask or tankard",
					Cost = "2 cp",
					Weight = "1 lb.",
				},
				#endregion

				#region Grappling hook
				new AdventuringGearTableEntryViewModel
				{
					Item = "Grappling hook",
					Cost = "2 gp",
					Weight = "4 lb.",
				},
				#endregion

				#region Hammer
				new AdventuringGearTableEntryViewModel
				{
					Item = "Hammer",
					Cost = "1 gp",
					Weight = "3 lb.",
				},
				#endregion

				#region Hammer, sledge
				new AdventuringGearTableEntryViewModel
				{
					Item = "Hammer, sledge",
					Cost = "2 gp",
					Weight = "10 lb.",
				},
				#endregion

				#region Healer's kit
				new AdventuringGearTableEntryViewModel
				{
					Item = "Healer's kit",
					Cost = "5 gp",
					Weight = "3 lb.",
				},
				#endregion

				#region Holy water (flask)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Holy water (flask)",
					Cost = "25 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Hourglass
				new AdventuringGearTableEntryViewModel
				{
					Item = "Hourglass",
					Cost = "25 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Hunting trap
				new AdventuringGearTableEntryViewModel
				{
					Item = "Hunting trap",
					Cost = "5 gp",
					Weight = "25 lb.",
				},
				#endregion

				#region Ink (1 ounce bottle)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Ink (1 ounce bottle)",
					Cost = "10 gp",
					Weight = "-",
				},
				#endregion

				#region Ink pen
				new AdventuringGearTableEntryViewModel
				{
					Item = "Ink pen",
					Cost = "2 cp",
					Weight = "-",
				},
				#endregion

				#region Jug or pitcher
				new AdventuringGearTableEntryViewModel
				{
					Item = "Jug or pitcher",
					Cost = "2 cp",
					Weight = "4 lb.",
				},
				#endregion

				#region Ladder (10 foot)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Ladder (10 foot)",
					Cost = "1 sp",
					Weight = "25 lb.",
				},
				#endregion

				#region Lamp
				new AdventuringGearTableEntryViewModel
				{
					Item = "Lamp",
					Cost = "5 sp",
					Weight = "1 lb.",
				},
				#endregion

				#region Lantern, bullseye
				new AdventuringGearTableEntryViewModel
				{
					Item = "Lantern, bullseye",
					Cost = "10 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Lantern, hooded
				new AdventuringGearTableEntryViewModel
				{
					Item = "Lantern, hooded",
					Cost = "5 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Lock
				new AdventuringGearTableEntryViewModel
				{
					Item = "Lock",
					Cost = "10 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Magnifying glass
				new AdventuringGearTableEntryViewModel
				{
					Item = "Magnifying glass",
					Cost = "100 gp",
					Weight = "-",
				},
				#endregion

				#region Manacles
				new AdventuringGearTableEntryViewModel
				{
					Item = "Manacles",
					Cost = "2 gp",
					Weight = "6 lb.",
				},
				#endregion

				#region Mess kit
				new AdventuringGearTableEntryViewModel
				{
					Item = "Mess kit",
					Cost = "2 sp",
					Weight = "1 lb.",
				},
				#endregion

				#region Mirror, steel
				new AdventuringGearTableEntryViewModel
				{
					Item = "Mirror, steel",
					Cost = "5 gp",
					Weight = "1/2 lb.",
				},
				#endregion

				#region Oil (flask)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Oil (flask)",
					Cost = "1 sp",
					Weight = "1 lb.",
				},
				#endregion

				#region Paper (one sheet)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Paper (one sheet)",
					Cost = "2 sp",
					Weight = "-",
				},
				#endregion

				#region Parchment (one sheet)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Parchment (one sheet)",
					Cost = "1 sp",
					Weight = "-",
				},
				#endregion

				#region Perfume (vial)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Perfume (vial)",
					Cost = "5 gp",
					Weight = "-",
				},
				#endregion

				#region Pick, miner's
				new AdventuringGearTableEntryViewModel
				{
					Item = "Pick, miner's",
					Cost = "2 gp",
					Weight = "10 lb.",
				},
				#endregion

				#region Piton
				new AdventuringGearTableEntryViewModel
				{
					Item = "Piton",
					Cost = "5 cp",
					Weight = "1/4 lb.",
				},
				#endregion

				#region Poison, basic (vial)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Poison, basic (vial)",
					Cost = "100 gp",
					Weight = "-",
				},
				#endregion

				#region Pole (10-foot)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Pole (10-foot)",
					Cost = "5 cp",
					Weight = "7 lb.",
				},
				#endregion

				#region Pot, iron
				new AdventuringGearTableEntryViewModel
				{
					Item = "Pot, iron",
					Cost = "2 gp",
					Weight = "10 lb.",
				},
				#endregion

				#region Potion of healing
				new AdventuringGearTableEntryViewModel
				{
					Item = "Potion of healing",
					Cost = "50 gp",
					Weight = "1/2 lb.",
				},
				#endregion

				#region Pouch
				new AdventuringGearTableEntryViewModel
				{
					Item = "Pouch",
					Cost = "5 sp",
					Weight = "1 lb.",
				},
				#endregion

				#region Quiver
				new AdventuringGearTableEntryViewModel
				{
					Item = "Quiver",
					Cost = "1 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Ram, portable
				new AdventuringGearTableEntryViewModel
				{
					Item = "Ram, portable",
					Cost = "4 gp",
					Weight = "35 lb.",
				},
				#endregion

				#region Rations (1 day)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Rations (1 day)",
					Cost = "5 sp",
					Weight = "2 lb.",
				},
				#endregion

				#region Robes
				new AdventuringGearTableEntryViewModel
				{
					Item = "Robes",
					Cost = "1 gp",
					Weight = "4 lb.",
				},
				#endregion

				#region Rope, hempen (50 feet)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Rope, hempen (50 feet)",
					Cost = "1 gp",
					Weight = "10 lb.",
				},
				#endregion

				#region Rope, silk (50 feet)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Rope, silk (50 feet)",
					Cost = "10 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Sack
				new AdventuringGearTableEntryViewModel
				{
					Item = "Sack",
					Cost = "1 cp",
					Weight = "1/2 lb.",
				},
				#endregion

				#region Scale, merchant's
				new AdventuringGearTableEntryViewModel
				{
					Item = "Scale, merchant's",
					Cost = "5 gp",
					Weight = "3 lb.",
				},
				#endregion

				#region Sealing wax
				new AdventuringGearTableEntryViewModel
				{
					Item = "Sealing wax",
					Cost = "5 sp",
					Weight = "-",
				},
				#endregion

				#region Shovel
				new AdventuringGearTableEntryViewModel
				{
					Item = "Shovel",
					Cost = "2 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Signal whistle
				new AdventuringGearTableEntryViewModel
				{
					Item = "Signal whistle",
					Cost = "5 cp",
					Weight = "-",
				},
				#endregion

				#region Signet ring
				new AdventuringGearTableEntryViewModel
				{
					Item = "Signet ring",
					Cost = "5 gp",
					Weight = "-",
				},
				#endregion

				#region Soap
				new AdventuringGearTableEntryViewModel
				{
					Item = "Soap",
					Cost = "2 cp",
					Weight = "-",
				},
				#endregion

				#region Spellbook
				new AdventuringGearTableEntryViewModel
				{
					Item = "Spellbook",
					Cost = "50 gp",
					Weight = "3 lb.",
				},
				#endregion

				#region Spikes, iron (10)
				new AdventuringGearTableEntryViewModel
				{
					Item = "Spikes, iron (10)",
					Cost = "1 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Spyglass
				new AdventuringGearTableEntryViewModel
				{
					Item = "Spyglass",
					Cost = "1,000 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Tent, two-person
				new AdventuringGearTableEntryViewModel
				{
					Item = "Tent, two-person",
					Cost = "2 gp",
					Weight = "20 lb.",
				},
				#endregion

				#region Tinderbox
				new AdventuringGearTableEntryViewModel
				{
					Item = "Tinderbox",
					Cost = "5 sp",
					Weight = "1 lb.",
				},
				#endregion

				#region Torch
				new AdventuringGearTableEntryViewModel
				{
					Item = "Torch",
					Cost = "1 cp",
					Weight = "1 lb.",
				},
				#endregion

				#region Vial
				new AdventuringGearTableEntryViewModel
				{
					Item = "Vial",
					Cost = "1 gp",
					Weight = "-",
				},
				#endregion

				#region Waterskin
				new AdventuringGearTableEntryViewModel
				{
					Item = "Waterskin",
					Cost = "2 sp",
					Weight = "5 lb. (full)",
				},
				#endregion

				#region Whetstone
				new AdventuringGearTableEntryViewModel
				{
					Item = "Whetstone",
					Cost = "1 cp",
					Weight = "1 lb.",
				},
				#endregion

			};
		}
	}
}
