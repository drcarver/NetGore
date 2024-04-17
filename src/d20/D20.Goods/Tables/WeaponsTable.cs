using System.Diagnostics.CodeAnalysis;

using D20.Core.Enum;
using D20.Core.Models;
using D20.Goods.Enum;
using D20.Goods.Interfaces;
using D20.Goods.Models;

namespace D20.Goods.Tables;

/// <summary>
/// Your class grants proficiency in certain weapons,
/// reflecting both the class’s focus and the tools you 
/// are most likely to use.Whether you favor a longsword 
/// or a longbow, your weapon and your ability to wield it
/// effectively can mean the difference between life and
/// death while adventuring,
/// </summary>
public class WeaponsTable : GameTable, IWeaponsTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public WeaponsTable()
    {
        Name = nameof(WeaponsTable);
        ProperName = "Weapons Table";
        TableType = TableTypeEnum.GoodsTable;
        Description =
            "Your class grants proficiency in certain weapons, " +
            "reflecting both the class’s focus and the tools you are " +
            "most likely to use.Whether you favor a longsword or " +
            "a longbow, your weapon and your ability to wield it " +
            "effectively can mean the difference between life and " +
            "death while adventuring";    
    }

    /// <summary>
    /// Initialize the game table.  This is a separate method so 
    /// we can create a game table for it's meta properties
    /// with out creating the actual able values.  A bit of 
    /// optimization to conserve memory on big tables
    /// </summary>
    public override void InitializeTable()
    {
        Table =
        [
            #region Club
            //Club 1  sp 1d4  bludgeoning 2   lb.Light
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Club),
                Equipment = EquipmentEnum.Club,
                ProperName = "Club",
                EquipmentCategory = EquipmentCategoryEnum.SimpleWeapon,
                Cost = new GoodsCost(1, new SilverPiece()),
                Damage = "1d4",
                DamageType = DamageType.Bludgeoning,
                Weight = 2,
                Light = true
            },
            #endregion

            #region Dagger
            //Dagger 2	gp 1d4	piercing 1	lb. ,	light,	thrown(range  20/60)
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Dagger),
                Equipment = EquipmentEnum.Dagger,
                ProperName = "Dagger",
                EquipmentCategory = EquipmentCategoryEnum.SimpleWeapon,
                Cost = new GoodsCost(2, new GoldPiece()),
                Damage = "1d4",
                DamageType = DamageType.Piercing,
                Weight = 1,
                Light = true,
                Thrown = true,
                Range = new Range(20, 60)
            },
            #endregion

            #region Greatclub
            //Greatclub 2	sp 1d8	bludgeoning 10	lb.Two-handed
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Greatclub),
                Equipment = EquipmentEnum.Greatclub,
                ProperName = "Greatclub",
                EquipmentCategory = EquipmentCategoryEnum.SimpleWeapon,
                Cost = new GoodsCost(2, new SilverPiece()),
                Damage = "1d8",
                DamageType = DamageType.Bludgeoning,
                Weight = 10,
                TwoHanded = true,
            },
            #endregion

            #region Handaxe
            //Handaxe 5	gp 1d6	slashing 2	lb.Light,	thrown(range  20/60)
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Handaxe),
                Equipment = EquipmentEnum.Handaxe,
                ProperName = "Handaxe",
                EquipmentCategory = EquipmentCategoryEnum.SimpleWeapon,
                Cost = new GoodsCost(5, new GoldPiece()),
                Damage = "1d6",
                DamageType = DamageType.Slashing,
                Weight = 2,
                Light = true,
                Thrown = true,
                Range = new Range(20, 60)
            },
            #endregion

            #region Javelin
            //Javelin 5	sp 1d6	piercing 2	lb.Thrown(range  30/120)
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Javelin),
                Equipment = EquipmentEnum.Javelin,
                ProperName = "Javelin",
                EquipmentCategory = EquipmentCategoryEnum.SimpleWeapon,
                Cost = new GoodsCost(5, new SilverPiece()),
                Damage = "1d6",
                DamageType = DamageType.Piercing,
                Weight = 2,
                Thrown = true,
                Range = new Range(30, 120)
            },
            #endregion

            #region Light hammer
            //Light hammer 2 gp 1d4	bludgeoning 2 lb.Light,	thrown(range  20/60)
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Lighthammer),
                Equipment = EquipmentEnum.Lighthammer,
                ProperName = "Light hammer",
                EquipmentCategory = EquipmentCategoryEnum.SimpleWeapon,
                Cost = new GoodsCost(2, new GoldPiece()),
                Damage = "1d4",
                DamageType = DamageType.Bludgeoning,
                Weight = 2,
                Light= true,
                Thrown = true,
                Range = new Range(20, 60)
            },
            #endregion

            #region Mace
            //Mace 5	gp 1d6	bludgeoning 4	lb. —
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Mace),
                Equipment = EquipmentEnum.Mace,
                ProperName = "Mace",
                EquipmentCategory = EquipmentCategoryEnum.SimpleWeapon,
                Cost = new GoodsCost(5, new GoldPiece()),
                Damage = "1d6",
                DamageType = DamageType.Bludgeoning,
                Weight = 4,
            },
            #endregion

            #region Quarterstaff
            //Quarterstaff 2 sp 1d6	bludgeoning 4 lb.Versatile(1d8)
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Quarterstaff),
                Equipment = EquipmentEnum.Quarterstaff,
                ProperName = "Quarterstaff",
                EquipmentCategory = EquipmentCategoryEnum.SimpleWeapon,
                Cost = new GoodsCost(2, new SilverPiece()),
                Damage = "1d6",
                DamageType = DamageType.Bludgeoning,
                Weight = 4,
                Versatile = "1d8"
            },
            #endregion

            #region Quarterstaff
            //Sickle 1 gp 1d4 slashing 2 lb. Light
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Sickle),
                Equipment = EquipmentEnum.Sickle,
                ProperName = "Sickle",
                EquipmentCategory = EquipmentCategoryEnum.SimpleWeapon,
                Cost = new GoodsCost(1, new GoldPiece()),
                Damage = "1d4",
                DamageType = DamageType.Slashing,
                Weight = 2,
                Light = true,
            },
            #endregion

            #region Spear
            //Spear 1 gp 1d6 piercing 3	lb.Thrown(range 20/60), versatile(1d8)
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Spear),
                Equipment = EquipmentEnum.Spear,
                ProperName = "Spear",
                EquipmentCategory = EquipmentCategoryEnum.SimpleWeapon,
                Cost = new GoodsCost(1, new GoldPiece()),
                Damage = "1d6",
                DamageType = DamageType.Piercing,
                Weight = 3,
                Thrown = true,
                Range = new Range(20, 60),
                Versatile = "1d8"
            },
            #endregion

            #region Light Crossbow
            //Crossbow, light 25 gp 1d8	piercing 5lb.Ammunition(range  80/320),	loading, two-handed
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.LightCrossbow),
                Equipment = EquipmentEnum.LightCrossbow,
                ProperName = "Light Crossbow",
                EquipmentCategory = EquipmentCategoryEnum.SimpleWeapon,
                Cost = new GoodsCost(2, new GoldPiece()),
                Damage = "1d8",
                DamageType = DamageType.Piercing,
                Weight = 5,
                Ammunition = true,
                Range = new Range(80, 320),
                Loading = true,
                TwoHanded = true,
            },
            #endregion

            #region Dart
            //Dart 5cp 1d4	piercing 1/4lb. Finesse, thrown(range  20/60)
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Dart),
                Equipment = EquipmentEnum.Dart,
                ProperName = "Dart",
                EquipmentCategory = EquipmentCategoryEnum.SimpleWeapon,
                Cost = new GoodsCost(5, new CopperPiece()),
                Damage = "1d4",
                DamageType = DamageType.Piercing,
                Weight = Convert.ToDecimal(0.25),
                Finesse = true,
                Range = new Range(20, 60),
                Thrown = true,
            },
            #endregion

            #region Shortbow
            //Shortbow 25gp 1d6	piercing 2lb.Ammunition (range  80/320),	two-handed
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Shortbow),
                Equipment = EquipmentEnum.Shortbow,
                ProperName = "Shortbow",
                EquipmentCategory = EquipmentCategoryEnum.SimpleWeapon,
                Cost = new GoodsCost(25, new CopperPiece()),
                Damage = "1d6",
                DamageType = DamageType.Piercing,
                Weight = 2,
                Ammunition = true,
                Range = new Range(80, 320),
                TwoHanded = true,
            },
            #endregion

            #region Sling
            //Sling 1sp 1d4	bludgeoning — Ammunition(range  30/120)
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Sling),
                Equipment = EquipmentEnum.Sling,
                ProperName = "Sling",
                EquipmentCategory = EquipmentCategoryEnum.SimpleWeapon,
                Cost = new GoodsCost(1, new SilverPiece()),
                Damage = "1d4",
                DamageType = DamageType.Bludgeoning,
                Weight = 0,
                Ammunition = true,
                Range = new Range(30, 120),
                TwoHanded = true,
            },
            #endregion

            #region Battleaxe
            //Battleaxe 10gp 1d8 slashing 4lb.Versatile(1d10)
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Battleaxe),
                Equipment = EquipmentEnum.Battleaxe,
                ProperName = "Battleaxe",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(10, new GoldPiece()),
                Damage = "1d8",
                DamageType = DamageType.Slashing,
                Weight = 4,
                Versatile = "1d10",
            },
            #endregion

            #region Flail
            //Flail 10gp 1d8 bludgeoning 2lb. —
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Flail),
                Equipment = EquipmentEnum.Flail,
                ProperName = "Flail",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(10, new GoldPiece()),
                Damage = "1d8",
                DamageType = DamageType.Bludgeoning,
                Weight = 2,
            },
            #endregion

            #region Glaive
            //Glaive 20gp 1d10 slashing 6lb. Heavy,	reach, two-handed
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Glaive),
                Equipment = EquipmentEnum.Glaive,
                ProperName = "Glaive",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(20, new GoldPiece()),
                Damage = "1d10",
                DamageType = DamageType.Slashing,
                Weight = 6,
                Heavy = true,
                Reach = true,
                TwoHanded = true,
            },
            #endregion

            #region Greataxe
            //Greataxe 30gp 1d12 slashing 7lb. Heavy, two-handed
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Greataxe),
                Equipment = EquipmentEnum.Greataxe,
                ProperName = "Greataxe",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(30, new GoldPiece()),
                Damage = "1d12",
                DamageType = DamageType.Slashing,
                Weight = 7,
                Heavy = true,
                TwoHanded = true,
            },
            #endregion

            #region Greatsword
            //Greatsword 50gp 2d6 slashing 6lb.Heavy, two-handed
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Greatsword),
                Equipment = EquipmentEnum.Greatsword,
                ProperName = "Greatsword",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(50, new GoldPiece()),
                Damage = "2d6",
                DamageType = DamageType.Slashing,
                Weight = 6,
                Heavy = true,
                TwoHanded = true,
            },
            #endregion

            #region Halberd
            //Halberd 20gp 1d10	slashing 6lb. Heavy, reach, two-handed
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Halberd),
                Equipment = EquipmentEnum.Halberd,
                ProperName = "Halberd",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(20, new GoldPiece()),
                Damage = "1d10",
                DamageType = DamageType.Slashing,
                Weight = 6,
                Heavy = true,
                Reach = true,
                TwoHanded = true,
            },
            #endregion

            #region Lance
            //Lance 10gp 1d12 piercing 6lb.Reach, special
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Lance),
                Equipment = EquipmentEnum.Lance,
                ProperName = "Lance",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(10, new GoldPiece()),
                Damage = "1d12",
                DamageType = DamageType.Piercing,
                Weight = 6,
                Reach = true,
                Special = true,
                Description =
                    "You have disadvantage when you use a " +
                    "lance to attack a target within 5 feet of you. Also, a " +
                    "lance requires two hands to wield when you aren’t " +
                    "mounted.",
            },
            #endregion

            #region Longsword
            //Longsword 15gp 1d8 slashing 3lb.Versatile(1d10)
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Longsword),
                Equipment = EquipmentEnum.Longsword,
                ProperName = "Longsword",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(15, new GoldPiece()),
                Damage = "1d8",
                DamageType = DamageType.Slashing,
                Weight = 3,
                Versatile = "1d10",
            },
            #endregion

            #region Maul
            //Maul 10gp 2d6	bludgeoning 10lb.Heavy,	two-handed
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Maul),
                Equipment = EquipmentEnum.Maul,
                ProperName = "Maul",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(10, new GoldPiece()),
                Damage = "2d6",
                DamageType = DamageType.Bludgeoning,
                Weight = 10,
                Heavy = true,
                TwoHanded = true,
            },
            #endregion

            #region Morningstar
            //Morningstar 15gp 1d8	piercing 4lb. —
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Morningstar),
                Equipment = EquipmentEnum.Morningstar,
                ProperName = "Morningstar",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(15, new GoldPiece()),
                Damage = "1d8",
                DamageType = DamageType.Piercing,
                Weight = 4,
            },
            #endregion

            #region Pike
            //Pike 5gp 1d10	piercing 18lb.Heavy, reach,	two-handed
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Pike),
                Equipment = EquipmentEnum.Pike,
                ProperName = "Pike",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(5, new GoldPiece()),
                Damage = "1d10",
                DamageType = DamageType.Piercing,
                Weight = 18,
                Heavy = true,
                Reach = true,
                TwoHanded = true,
            },
            #endregion

            #region Rapier
            //Rapier 25gp 1d8 piercing 2lb.Finesse
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Rapier),
                Equipment = EquipmentEnum.Rapier,
                ProperName = "Rapier",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(25, new GoldPiece()),
                Damage = "1d8",
                DamageType = DamageType.Piercing,
                Weight = 2,
                Finesse = true,
            },
            #endregion

            #region Scimitar
            //Scimitar 25gp 1d6	slashing 3lb.Finesse,light
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Scimitar),
                Equipment = EquipmentEnum.Scimitar,
                ProperName = "Scimitar",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(25, new GoldPiece()),
                Damage = "1d6",
                DamageType = DamageType.Slashing,
                Weight = 3,
                Finesse = true,
                Light = true,
            },
            #endregion

            #region Shortsword
            //Shortsword 10gp 1d6 piercing 2lb.Finesse,	light
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Shortsword),
                Equipment = EquipmentEnum.Shortsword,
                ProperName = "Shortsword",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(10, new GoldPiece()),
                Damage = "1d6",
                DamageType = DamageType.Piercing,
                Weight = 2,
                Finesse = true,
                Light = true,
            },
            #endregion

            #region Trident
            //Trident 5gp 1d6 piercing 4lb.Thrown(range  20/60), versatile(1d8)
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Trident),
                Equipment = EquipmentEnum.Trident,
                ProperName = "Trident",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(5, new GoldPiece()),
                Damage = "1d6",
                DamageType = DamageType.Piercing,
                Weight = 4,
                Thrown = true,
                Range = new Range(20, 60),
                Versatile = "1d8",
            },
            #endregion

            #region War pick
            //War pick 5gp 1d8 piercing 2lb. —
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Warpick),
                Equipment = EquipmentEnum.Warpick,
                ProperName = "War pick",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(5, new GoldPiece()),
                Damage = "1d8",
                DamageType = DamageType.Piercing,
                Weight = 2,
            },
            #endregion

            #region Warhammer
            //Warhammer 15gp 1d8 bludgeoning 2lb. Versatile(1d10)
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Warhammer),
                Equipment = EquipmentEnum.Warhammer,
                ProperName = "Warhammer",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(15, new GoldPiece()),
                Damage = "1d8",
                DamageType = DamageType.Bludgeoning,
                Weight = 2,
                Versatile = "1d10"
            },
            #endregion

            #region Whip
            //Whip 2gp 1d4 slashing 3lb. Finesse, reach
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Whip),
                Equipment = EquipmentEnum.Whip,
                ProperName = "Whip",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(2, new GoldPiece()),
                Damage = "1d4",
                DamageType = DamageType.Slashing,
                Weight = 3,
                Finesse = true,
                Reach = true,
            },
            #endregion

            #region Blowgun
            //Blowgun 10gp 1 piercing 1lb. Ammunition(range 25/100), loading
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Blowgun),
                Equipment = EquipmentEnum.Blowgun,
                ProperName = "Blowgun",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(10, new GoldPiece()),
                Damage = "1d1",
                DamageType = DamageType.Piercing,
                Weight = 1,
                Ammunition = true,
                Loading = true,
                Range =  new Range(25, 100)
            },
            #endregion

            #region Hand Crossbow
            //Crossbow, hand 75gp 1d6 piercing 3lb .Ammunition(range  30/120),	light,	loading
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.HandCrossbow),
                Equipment = EquipmentEnum.HandCrossbow,
                ProperName = "Hand Crossbow",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(75, new GoldPiece()),
                Damage = "1d6",
                DamageType = DamageType.Piercing,
                Weight = 3,
                Ammunition = true,
                Loading = true,
                Light = true,
                Range =  new Range(30, 120)
            },
            #endregion

            #region Heavy Crossbow
            //Crossbow, heavy 50gp 1d10	piercing 18lb. Ammunition(range  100/400),heavy,loading,two-handed
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.HeavyCrossbow),
                Equipment = EquipmentEnum.HeavyCrossbow,
                ProperName = "Heavy Crossbow",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(50, new GoldPiece()),
                Damage = "1d10",
                DamageType = DamageType.Piercing,
                Weight = 18,
                Ammunition = true,
                Loading = true,
                Heavy = true,
                TwoHanded = true,
                Range =  new Range(100, 400)
            },
            #endregion

            #region Longbow
            //Longbow 50gp 1d8 piercing 2lb.Ammunition(range  150/600),	heavy,	two-handed
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Longbow),
                Equipment = EquipmentEnum.Longbow,
                ProperName = "Longbow",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(50, new GoldPiece()),
                Damage = "1d8",
                DamageType = DamageType.Piercing,
                Weight = 2,
                Ammunition = true,
                Heavy = true,
                TwoHanded = true,
                Range =  new Range(150, 600)
            },
            #endregion

            #region Net
            //Net 1gp — 3lb. Special,thrown(range  5/15)
            new WeaponEntry
            {
                Name = nameof(EquipmentEnum.Net),
                Equipment = EquipmentEnum.Net,
                ProperName = "Net",
                EquipmentCategory = EquipmentCategoryEnum.MartialWeapon,
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 3,
                Special = true,
                Thrown = true,
                Range =  new Range(5, 15),
                Description =
                    "A Large or smaller creature hit by a net is  " +
                    "restrained until it is freed.A net has no effect on " +
                    "creatures that are formless, or creatures that are " +
                    "Huge or larger.A creature can use its action to make " +
                    "a DC 10 Strength check, freeing itself or another " +
                    "creature within its reach on a success.Dealing 5  " +
                    "slashing damage to the net (AC 10) also frees the " +
                    "creature without harming it, ending the effect and " +
                    "destroying the net. " +
                    "When you use an action, bonus action, or reaction " +
                    "to attack with a net, you can make only one attack " +
                    "regardless of the number of attacks you can " +
                    "normally make",

            },
            #endregion
        ];
    }
}

