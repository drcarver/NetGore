using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;

using D20.Core.Abilities;
using D20.Core.Enum;
using D20.Core.Models;
using D20.Goods.Enum;
using D20.Goods.Interfaces;
using D20.Goods.Models;

using Microsoft.Maui.Controls.Compatibility;

using static System.Runtime.InteropServices.JavaScript.JSType;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace D20.Goods.Tables;

public class GearTable : GameTable, IGearTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public GearTable()
    {
        Name = nameof(GearTable);
        ProperName = "Gear Table";
        TableType = TableTypeEnum.GoodsTable;
        Description = "Adventuring Gear";
    }

    /// <summary>
    /// Initialize the game table. This is a separate method so 
    /// we can create a game table for it's meta properties
    /// with out creating the actual able values. A bit of 
    /// optimization to conserve memory on big tables
    /// </summary>
    public override void InitializeTable()
    {
        Table =
        [
            #region Abacus
            //Abacus 2gp 2lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Abacus),
                ProperName = "Abacus",
                Cost = new GoodsCost(2, new GoldPiece()),
                Weight = 2,
            },
            #endregion

            #region Acid
            //Acid(vial) 25gp 1lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Acid),
                ProperName = "Acid",
                Cost = new GoodsCost(25, new GoldPiece()),
                Weight = 1,
                Container = AdventuringGearEnum.Vial,
                Description =
                    "As an action, you can splash the contents of " +
                    "this vial onto a creature within 5 feet of you or throw " +
                    "the vial up to 20 feet, shattering it on impact. In " +
                    "either case, make a ranged attack against a creature " +
                    "or object, treating the acid as an improvised weapon. " +
                    "On a hit, the target takes 2d6 acid damage.",
            },

            #endregion

            #region Alchemist’s fire
            //Alchemist’s fire(flask) 50gp 1lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Alchemistsfire),
                ProperName = "Alchemist’s fire",
                Cost = new GoodsCost(50, new GoldPiece()),
                Weight = 1,
                Container= AdventuringGearEnum.Flask,
                Description =
                    "This sticky, adhesive fluid ignites " +
                    "when exposed to air.As an action, you can throw this " +
                    "flask up to 20 feet, shattering it on impact. Make a " +
                    "ranged attack against a creature or object, treating " +
                    "the alchemist's fire as an improvised weapon. On a  " +
                    "hit, the target takes 1d4 fire damage at the start of " +
                    "each of its turns. A creature can end this damage by " +
                    "using its action to make a DC 10 Dexterity check to " +
                    "extinguish the flames",
            },
            #endregion

            #region Arrows
            //Arrows(20) 1gp 1lb.
            new Ammunition
            {
                Name = nameof(AdventuringGearEnum.Arrows),
                ProperName = "Arrows",
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 1,
                Quantity = 20
            },
            #endregion

            #region Blowgun needles
            //Blowgun needles(50) 1gp 1lb.
            new Ammunition
            {
                Name = nameof(AdventuringGearEnum.BlowgunNeedles),
                ProperName = "Blowgun needles",
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 1,
                Quantity = 50
            },
            #endregion

            #region Crossbow bolts
            //Crossbow bolts(20) 1gp 1½lb.
            new Ammunition
            {
                Name = nameof(AdventuringGearEnum.Crossbowbolts),
                ProperName = "Crossbow bolts",
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = Convert.ToDecimal("1.5"),
                Quantity = 20
            },
            #endregion

            #region Sling bullets
            //Sling bullets(20) 4cp 1½lb.
            new Ammunition
            {
                Name = nameof(AdventuringGearEnum.Slingbullets),
                ProperName = "Sling bullets",
                Cost = new GoodsCost(4, new CopperPiece()),
                Weight = Convert.ToDecimal("1.5"),
                Quantity = 20
            },
            #endregion

            #region Antitoxin
            //Antitoxin(vial) 50gp —
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Antitoxin),
                ProperName = "Antitoxin",
                Cost = new GoodsCost(50, new GoldPiece()),
                Weight = 0,
                Container = AdventuringGearEnum.Vial,
                Description =
                    "A creature that drinks this vial of liquid " +
                    "gains advantage on saving throws against poison for " +
                    "1 hour. It confers no benefit to undead or constructs"
            },
            #endregion

            #region Crystal
            //Crystal 10gp 1lb.
            new ArcaneFocus
            {
                Name = nameof(AdventuringGearEnum.Crystal),
                ProperName = "Crystal",
                Cost = new GoodsCost(10, new GoldPiece()),
                Weight = 1,
                Description =
                    "An arcane focus is a special item— " +
                    "an orb, a crystal, a rod, a specially constructed staff, a " +
                    "wand-like length of wood, or some similar item— " +
                    "designed to channel the power of arcane spells. A " +
                    "sorcerer, warlock, or wizard can use such an item as " +
                    "a spellcasting focus.",
            },
            #endregion

            #region Orb
            //Orb 20gp 3lb.
            new ArcaneFocus
            {
                Name = nameof(AdventuringGearEnum.Orb),
                ProperName = "Orb",
                Cost = new GoodsCost(20, new GoldPiece()),
                Weight = 2,
                Description =
                    "An arcane focus is a special item— " +
                    "an orb, a crystal, a rod, a specially constructed staff, a " +
                    "wand-like length of wood, or some similar item— " +
                    "designed to channel the power of arcane spells. A " +
                    "sorcerer, warlock, or wizard can use such an item as " +
                    "a spellcasting focus.",
            },
            #endregion

            #region Rod
            //Rod 10gp 2lb.
            new ArcaneFocus
            {
                Name = nameof(AdventuringGearEnum.Rod),
                ProperName = "Rod",
                Cost = new GoodsCost(10, new GoldPiece()),
                Weight = 2,
                Description =
                    "An arcane focus is a special item— " +
                    "an orb, a crystal, a rod, a specially constructed staff, a " +
                    "wand-like length of wood, or some similar item— " +
                    "designed to channel the power of arcane spells. A " +
                    "sorcerer, warlock, or wizard can use such an item as " +
                    "a spellcasting focus.",
            },
            #endregion

            #region Staff
            //Staff 5gp 4lb.
            new ArcaneFocus
            {
                Name = nameof(AdventuringGearEnum.Staff),
                ProperName = "Staff",
                Cost = new GoodsCost(5, new GoldPiece()),
                Weight = 4,
                Description =
                    "An arcane focus is a special item— " +
                    "an orb, a crystal, a rod, a specially constructed staff, a " +
                    "wand-like length of wood, or some similar item— " +
                    "designed to channel the power of arcane spells. A " +
                    "sorcerer, warlock, or wizard can use such an item as " +
                    "a spellcasting focus.",
            },
            #endregion

            #region Wand
            //Wand 10gp 1lb.
            new ArcaneFocus
            {
                Name = nameof(AdventuringGearEnum.Wand),
                ProperName = "Wand",
                Cost = new GoodsCost(5, new GoldPiece()),
                Weight = 4,
                Description =
                    "An arcane focus is a special item— " +
                    "an orb, a crystal, a rod, a specially constructed staff, a " +
                    "wand-like length of wood, or some similar item— " +
                    "designed to channel the power of arcane spells. A " +
                    "sorcerer, warlock, or wizard can use such an item as " +
                    "a spellcasting focus.",
            },
            #endregion

            #region Backpack
            //Backpack 2gp 5lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Backpack),
                ProperName = "Backpack",
                Cost = new GoodsCost(2, new GoldPiece()),
                Weight = 5,
            },
            #endregion

            #region Ball bearings
            //Ball bearings(bag of	1,000) 1gp 2lb.
            new BagOf
            {
                Name = nameof(AdventuringGearEnum.Ballbearings),
                ProperName = "Ball bearings",
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 21,
                Quantity = 1000,
                Description =
                    "As an action, you can spill these " +
                    "tiny metal balls from their pouch to cover a level, " +
                    "square area that is 10 feet on a side. A creature " +
                    "moving across the covered area must succeed on a " +
                    "DC 10 Dexterity saving throw or fall prone. A " +
                    "creature moving through the area at half speed " +
                    "doesn’t need to make the save.",
            },
            #endregion

            #region Barrel
            //Barrel 2gp 70lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Barrel),
                ProperName = "Barrel",
                Cost = new GoodsCost(2, new GoldPiece()),
                Weight = 70,
            },
            #endregion

            #region Basket
            //Basket 4sp 2lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Basket),
                ProperName = "Basket",
                Cost = new GoodsCost(2, new SilverPiece()),
                Weight = 2,
            },
            #endregion

            #region Bedroll
            //Bedroll 1gp 7lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Bedroll),
                ProperName = "Bedroll",
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 7,
            },
            #endregion

            #region Bell
            //Bell 1gp —
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Bell),
                ProperName = "Bell",
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 0,
            },
            #endregion

            #region Blanket
            //Blanket 5sp 3lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Blanket),
                ProperName = "Blanket",
                Cost = new GoodsCost(5, new SilverPiece()),
                Weight = 3,
            },
            #endregion

            #region Block and tackle
            //Block and tackle 1gp 5lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Blockandtackle),
                ProperName = "Block and tackle",
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 5,
                Description =
                    "A set of pulleys with a cable " +
                    "threaded through them and a hook to attach to " +
                    "objects, a block and tackle allows you to hoist up to " +
                    "four times the weight you can normally lift.",
            },
            #endregion

            #region Book
            //Book 25gp 5lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Book),
                ProperName = "Book",
                Cost = new GoodsCost(25, new GoldPiece()),
                Weight = 5,
                Description =
                    "A book might contain poetry, historical " +
                    "accounts, information pertaining to a particular field " +
                    "of lore, diagrams and notes on gnomish contraptions, " +
                    "or just about anything else that can be represented " +
                    "using text or pictures.",
            },
            #endregion

            #region Glass Bottle
            //Glass Bottle 2gp 2lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.GlassBottle),
                ProperName = "Glass Bottle",
                Cost = new GoodsCost(2, new GoldPiece()),
                Weight = 2,
            },
            #endregion

            #region Bucket
            //Bucket 5cp 2lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Bucket),
                ProperName = "Bucket",
                Cost = new GoodsCost(5, new CopperPiece()),
                Weight = 2,
            },
            #endregion

            #region Caltrops
            //Caltrops(bag of 20) 1gp 2lb.
            new BagOf
            {
                Name = nameof(AdventuringGearEnum.Caltrops),
                ProperName = "Caltrops",
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 2,
                Quantity = 20,
                Description =
                    "As an action, you can spread a bag of " +
                    "caltrops to cover a square area that is 5 feet on a side. " +
                    "Any creature that enters the area must succeed on a " +
                    "DC 15 Dexterity saving throw or stop moving this " +
                    "turn and take 1 piercing damage. Taking this damage " +
                    "reduces the creature’s walking speed by 10 feet until " +
                    "the creature regains at least 1 hit point. A creature " +
                    "moving through the area at half speed doesn’t need " +
                    "to make the save."
            },
            #endregion

            #region Candle
            //Candle 1cp —
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Candle),
                ProperName = "Candle",
                Cost = new GoodsCost(1, new CopperPiece()),
                Weight = 0,
                Description =
                    "For 1 hour, a candle sheds bright light in a " +
                    "5-foot radius and dim light for an additional 5 feet.",
            },
            #endregion

            #region Crossbow bolt Case
            //Crossbow bolt Case  1gp 1lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.CrossbowboltCase),
                ProperName = "Crossbow Case",
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 1,
                Description = "This wooden case can hold up to twenty crossbow bolts.",
            },
            #endregion

            #region Map or scroll Case
            //Case,	map or scroll 1gp 1lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.MapOrScroll),
                ProperName = "Map or scroll Case",
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 1,
                Description =
                    "This cylindrical leather case can hold up " +
                    "to ten rolled-up sheets of paper or five " +
                    "rolled-up sheets of parchment.",
            },
            #endregion

            #region Chain
            //Chain(10 feet) 5gp 10lb.
            new ByLength
            {
                Name = nameof(AdventuringGearEnum.Chain),
                ProperName = "Chain",
                Cost = new GoodsCost(5, new GoldPiece()),
                Weight = 10,
                Length = new Height(10, 0),
                Description =
                    "A chain has 10 hit points. It can be burst " +
                    "with a successful DC 20 Strength check.",
            },
            #endregion

            #region Chalk
            //Chalk(1 piece) 1cp —
            new MiscellaneousItem
            {
                Name = nameof(AdventuringGearEnum.Chalk),
                ProperName = "Chalk",
                Cost = new GoodsCost(1, new CopperPiece()),
                Weight = 0,
                Quantity = 1,
                Description = "1 Piece",
            },
            #endregion

            #region Chest
            //Chest 5gp 25lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Chest),
                ProperName = "Chest",
                Cost = new GoodsCost(5, new GoldPiece()),
                Weight = 25,
                Container = AdventuringGearEnum.Chest,
            },
            #endregion

            #region Climber’s kit
            //Climber’s kit 25gp 12lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Climberskit),
                ProperName = "Climber’s kit",
                Cost = new GoodsCost(25, new GoldPiece()),
                Weight = 12,
                Description =
                    "A climber’s kit includes special " +
                    "pitons, boot tips, gloves, and a harness.You can use " +
                    "the climber’s kit as an action to anchor yourself; " +
                    "when you do, you can’t fall more than 25 feet from " +
                    "the point where you anchored yourself, and you " +
                    "can’t climb more than 25 feet away from that point " +
                    "without undoing the anchor.",
            },
            #endregion

            #region Common Clothes
            //Common Clothes 5sp 3lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.CommonClothes),
                ProperName = "Common Clothes",
                Cost = new GoodsCost(5, new SilverPiece()),
                Weight = 3,
            },
            #endregion

            #region Costume Clothes
            //Costume Clothes 5gp 4lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.CostumeClothes),
                ProperName = "Costume Clothes",
                Cost = new GoodsCost(5, new GoldPiece()),
                Weight = 4,
            },
            #endregion

            #region Fine Clothes
            //Clothes, fine 15gp 6lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.FineClothes),
                ProperName = "Fine Clothes",
                Cost = new GoodsCost(15, new GoldPiece()),
                Weight = 6,
            },
            #endregion

            #region Traveler’s Clothes
            //Clothes,	traveler’s 2gp 4lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.TravelersClothes),
                ProperName = "Traveler’s Clothes",
                Cost = new GoodsCost(2, new GoldPiece()),
                Weight = 4,
            },
            #endregion

            #region Component Pouch
            //Component pouch 25gp 2lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.ComponentPouch),
                ProperName = "Component Pouch",
                Cost = new GoodsCost(25, new GoldPiece()),
                Weight = 2,
                Description =
                    "A component pouch is a small, " +
                    "watertight leather belt pouch that has compartments " +
                    "to hold all the material components and other " +
                    "special items you need to cast your spells, except for " +
                    "those components that have a specific cost(as " +
                    "indicated in a spell's description).",
            },
            #endregion

            #region Crowbar
            //Crowbar 2gp 5lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Crowbar),
                ProperName = "Crowbar",
                Cost = new GoodsCost(2, new GoldPiece()),
                Weight = 5,
                Description =
                    "Using a crowbar grants advantage to " +
                    "Strength checks where the crowbar’s leverage can " +
                    "be applied.",
            },
            #endregion

            #region Sprig of mistletoe
            //Sprig of mistletoe 1gp —
            new DruidicFocus
            {
                Name = nameof(AdventuringGearEnum.SprigOfMistletoe),
                ProperName = "Sprig of mistletoe",
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 0,
                Description =
                    "A druidic focus might be a sprig of " +
                    "mistletoe or holly, a wand or scepter made of yew or " +
                    "another special wood, a staff drawn whole out of a " +
                    "living tree, or a totem object incorporating feathers, " +
                    "fur, bones, and teeth from sacred animals.A druid " +
                    "can use such an object as a spellcasting focus.",
            },
            #endregion

            #region Totem
            //Totem 1gp —
            new DruidicFocus
            {
                Name = nameof(AdventuringGearEnum.Totem),
                ProperName = "Totem",
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 0,
                Description =
                    "A druidic focus might be a sprig of " +
                    "mistletoe or holly, a wand or scepter made of yew or " +
                    "another special wood, a staff drawn whole out of a " +
                    "living tree, or a totem object incorporating feathers, " +
                    "fur, bones, and teeth from sacred animals.A druid " +
                    "can use such an object as a spellcasting focus.",
            },
            #endregion

            #region Wooden staff
            //Wooden staff 5gp 4lb.
            new DruidicFocus
            {
                Name = nameof(AdventuringGearEnum.Woodenstaff),
                ProperName = "Wooden staff",
                Cost = new GoodsCost(5, new GoldPiece()),
                Weight = 4,
                Description =
                    "A druidic focus might be a sprig of " +
                    "mistletoe or holly, a wand or scepter made of yew or " +
                    "another special wood, a staff drawn whole out of a " +
                    "living tree, or a totem object incorporating feathers, " +
                    "fur, bones, and teeth from sacred animals.A druid " +
                    "can use such an object as a spellcasting focus.",
            },
            #endregion

            #region Yew wand
            //Yew wand 10gp 1lb.
            new DruidicFocus
            {
                Name = nameof(AdventuringGearEnum.Yewwand),
                ProperName = "Yew wand",
                Cost = new GoodsCost(10, new GoldPiece()),
                Weight = 1,
                Description =
                    "A druidic focus might be a sprig of " +
                    "mistletoe or holly, a wand or scepter made of yew or " +
                    "another special wood, a staff drawn whole out of a " +
                    "living tree, or a totem object incorporating feathers, " +
                    "fur, bones, and teeth from sacred animals.A druid " +
                    "can use such an object as a spellcasting focus.",
            },
            #endregion

            #region Fishing tackle
            //Fishing tackle 1gp 4 lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Fishingtackle),
                ProperName = "Fishing tackle",
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 4,
                Description =
                    "This kit includes a wooden rod, " +
                    "silken line, corkwood bobbers, steel hooks, lead " +
                    "sinkers, velvet lures, and narrow netting.",

            },
            #endregion

            #region Flask
            //Flask or tankard 2cp 1lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Flask),
                ProperName = "Flask",
                Cost = new GoodsCost(2, new CopperPiece()),
                Weight = 1,
                Container = AdventuringGearEnum.Flask
            },
            #endregion

            #region Tankard
            //Flask or tankard 2cp 1lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Tankard),
                ProperName = "Tankard",
                Cost = new GoodsCost(2, new CopperPiece()),
                Weight = 1,
                Container = AdventuringGearEnum.Tankard
            },
            #endregion

            #region Grappling hook
            //Grappling hook 2gp 4lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Grapplinghook),
                ProperName = "Grappling hook",
                Cost = new GoodsCost(2, new GoldPiece()),
                Weight = 4,
            },
            #endregion

            #region Hammer
            //Hammer 1gp 3lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Hammer),
                ProperName = "Hammer",
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 3,
            },
            #endregion        

            #region Sledge Hammer 
            //Hammer, sledge 2gp 10lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.SledgeHammer),
                ProperName = "Sledge Hammer",
                Cost = new GoodsCost(2, new GoldPiece()),
                Weight = 10,
            },
            #endregion        

            #region Healer’s kit 
            //Healer’s kit 5gp 3lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.HealersKit),
                ProperName = "Healer’s kit",
                Cost = new GoodsCost(5, new GoldPiece()),
                Weight = 3,
                Description =
                    "This kit is a leather pouch containing " +
                    "bandages, salves, and splints. The kit has ten uses. As " +
                    "an action, you can expend one use of the kit to " +
                    "stabilize a creature that has 0 hit points, without " +
                    "needing to make a Wisdom (Medicine) check.",
            },
            #endregion        

            #region Amulet 
            //Amulet 5gp 1lb.
            new HolySymbol
            {
                Name = nameof(AdventuringGearEnum.Amulet),
                ProperName = "Amulet",
                Cost = new GoodsCost(5, new GoldPiece()),
                Weight = 1,
                Description =
                    "A holy symbol is a representation of " +
                    "a god or pantheon.It might be an amulet depicting a " +
                    "symbol representing a deity, the same symbol " +
                    "carefully engraved or inlaid as an emblem on a " +
                    "shield, or a tiny box holding a fragment of a sacred " +
                    "relic. A cleric or paladin can use a " +
                    "holy symbol as a spellcasting focus.To use the " +
                    "symbol in this way, the caster must hold it in hand, " +
                    "wear it visibly, or bear it on a shield.",
            },
            #endregion        

            #region Emblem 
            //Emblem 5gp —
            new HolySymbol
            {
                Name = nameof(AdventuringGearEnum.Emblem),
                ProperName = "Emblem",
                Cost = new GoodsCost(5, new GoldPiece()),
                Weight = 0,
                Description =
                    "A holy symbol is a representation of " +
                    "a god or pantheon.It might be an amulet depicting a " +
                    "symbol representing a deity, the same symbol " +
                    "carefully engraved or inlaid as an emblem on a " +
                    "shield, or a tiny box holding a fragment of a sacred " +
                    "relic. A cleric or paladin can use a " +
                    "holy symbol as a spellcasting focus.To use the " +
                    "symbol in this way, the caster must hold it in hand, " +
                    "wear it visibly, or bear it on a shield.",
            },
            #endregion        

            #region Reliquary 
            //Reliquary 5gp 2lb.
            new HolySymbol
            {
                Name = nameof(AdventuringGearEnum.Reliquary),
                ProperName = "Reliquary",
                Cost = new GoodsCost(5, new GoldPiece()),
                Weight = 2,
                Description =
                    "A holy symbol is a representation of " +
                    "a god or pantheon.It might be an amulet depicting a " +
                    "symbol representing a deity, the same symbol " +
                    "carefully engraved or inlaid as an emblem on a " +
                    "shield, or a tiny box holding a fragment of a sacred " +
                    "relic. A cleric or paladin can use a " +
                    "holy symbol as a spellcasting focus.To use the " +
                    "symbol in this way, the caster must hold it in hand, " +
                    "wear it visibly, or bear it on a shield.",
            },
            #endregion        

            #region Holy water 
            //Holy water(flask) 25gp 1lb
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Holywater),
                ProperName = "Holy water",
                Cost = new GoodsCost(25, new GoldPiece()),
                Weight = 1,
                Container = AdventuringGearEnum.Flask,
                Description =
                    "As an action, you can splash the " +
                    "contents of this flask onto a creature within 5 feet of " +
                    "you or throw it up to 20 feet, shattering it on impact. " +
                    "In either case, make a ranged attack against a target " +
                    "creature, treating the holy water as an improvised " +
                    "weapon.If the target is a fiend or undead, it takes " +
                    "2d6 radiant damage.\r\n " +
                    "A cleric or paladin may create holy water by " +
                    "performing a special ritual.The ritual takes 1 hour to " +
                    "perform, uses 25 gp worth of powdered silver, and " +
                    "requires the caster to expend a 1st-level spell slot.",
            },
            #endregion        

            #region Hourglass
            //Hourglass 25gp 1lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Hourglass),
                ProperName = "Hourglass",
                Cost = new GoodsCost(25, new GoldPiece()),
                Weight = 1,
            },
            #endregion        

            #region Hunting trap
            //Hunting trap 5gp 25lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Huntingtrap),
                ProperName = "Hunting trap",
                Cost = new GoodsCost(5, new GoldPiece()),
                Weight = 25,
                Description =
                    "When you use your action to set it, " +
                    "this trap forms a saw-toothed steel ring that snaps " +
                    "shut when a creature steps on a pressure plate in the " +
                    "center. The trap is affixed by a heavy chain to an " +
                    "immobile object, such as a tree or a spike driven into " +
                    "the ground. A creature that steps on the plate must " +
                    "succeed on a DC 13 Dexterity saving throw or take " +
                    "1d4 piercing damage and stop moving. Thereafter, " +
                    "until the creature breaks free of the trap, its " +
                    "movement is limited by the length of the chain " +
                    "(typically 3 feet long). A creature can use its action " +
                    "to make a DC 13 Strength check, freeing itself or " +
                    "another creature within its reach on a success. Each " +
                    "failed check deals 1 piercing damage to the trapped " +
                    "creature",
            },
            #endregion        

            #region Ink
            //Ink(1	ounce bottle) 10gp —
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Ink),
                ProperName = "Ink",
                Cost = new GoodsCost(10, new GoldPiece()),
                Weight = 0,
                Container = AdventuringGearEnum.Bottle1Ounce
            },
            #endregion        

            #region Ink pen
            //Ink pen 2cp —
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Inkpen),
                ProperName = "Ink pen",
                Cost = new GoodsCost(2, new CopperPiece()),
                Weight = 0,
            },
            #endregion        

            #region Jug
            //Jug or pitcher 2cp 4lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Jug),
                ProperName = "Jug",
                Cost = new GoodsCost(2, new CopperPiece()),
                Weight = 4,
            },
            #endregion        

            #region Pitcher
            //Jug or pitcher 2cp 4lb.
            new GearTableEntry
            {
                Name = nameof(AdventuringGearEnum.Pitcher),
                ProperName = "Pitcher",
                Cost = new GoodsCost(2, new CopperPiece()),
                Weight = 4,
            },
            #endregion        
        ];
    }
}

//Ladder(10-foot) 1sp 25lb.
//Lamp 5sp 1lb.
//Lantern, bullseye 10gp 2lb.
//Lantern, hooded 5gp 2lb.
//Lock 10gp 1lb.
//Magnifying glass 100gp —
//Manacles 2gp 6lb.
//Mess kit 2sp 1lb.
//Mirror, steel 5gp 1/2lb.
//Oil(flask) 1sp 1lb.
//Paper(one sheet) 2sp —
//Parchment(one sheet) 1sp —
//Perfume(vial) 5gp —
//Pick,	miner’s 2gp 10lb.
//Piton 5cp 1/4	lb.
//Poison,basic(vial) 100gp —
//Pole(10-foot) 5cp 7lb.
//Pot, iron 2gp 10lb.
//Potion of healing 50gp 1/2	lb.
//Pouch 5sp 1lb.
//Quiver 1gp 1lb.
//Ram,	portable 4gp 35lb.
//Rations(1	day) 5sp 2lb.
//Robes 1gp 4lb.
//Rope,	hempen(50 feet) 1gp 10lb.
//Rope,	silk(50	feet) 10gp 5lb.
//Sack 1cp 1/2lb.
//Scale, merchant’s 5gp 3lb.
//Sealing wax 5sp —
//Shovel 2gp 5lb.
//Signal whistle 5cp —
//Signet ring 5gp —
//Soap 2cp —
//Spell book 50gp 3lb.
//Spikes, iron(10) 1gp 5lb.
//Spyglass 1000gp 1lb.
//Tent,	two-person 2gp 20lb.
//Tinderbox 5sp 1lb.
//Torch 1cp 1lb.
//Vial 1gp —
//Waterskin 2sp 5lb. (full)
//Whetstone 1cp 1lb.

