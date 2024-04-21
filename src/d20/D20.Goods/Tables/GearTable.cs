using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

using D20.Core;
using D20.Core.Enum;
using D20.Core.Models;
using D20.Goods.Enum;
using D20.Goods.Interfaces;
using D20.Goods.Models;

namespace D20.Goods.Tables;

public class EquipmentTable : NamedTable, IEquipmentTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public EquipmentTable()
    {
        Name = nameof(EquipmentTable);
        ProperName = "Equipment Table";
        TableType = TableTypeEnum.GoodsTable;
        Description = "Equipment including armor and weapons";
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
            #region Armor and shields
            //Adventurers have access to  a variety of armor 
            //types, ranging from leather armor to chain mail to
            //costly plate armor, with several other kinds of armor
            //in between. The Armor table collects the most commonly
            //available types of armor found in	the game and
            //separates them into three categories:	light armor,
            //medium armor,	and heavy armor. Many warriors
            //supplement their armor with a shield. The Armor
            //table shows the cost, weight, and other properties
            //of the common types of armor.

            #region Light - Padded
            //Padded 5	gp 11+Dex modifier — Disadvantage 8	lb.
            new ArmorEntry
            {
                Name = nameof(EquipmentEnum.Padded),
                ProperName = "Padded",
                Description = "Padded armor consists of quilted " +
                    "layers  of cloth and batting.",
                EquipmentCategory = EquipmentCategoryEnum.LightArmor,
                Equipment = EquipmentEnum.Padded,
                Cost = new GoodsCost(5, new GoldPiece()),
                AC = 11,
                MaxDexterity = int.MaxValue,
                Stealth = false,
                Strength = null,
                Weight = 8,
            },
            #endregion

            #region Light - Leather
            //Leather 10 gp 11+Dex modifier — — 10	lb.
            new ArmorEntry
            {
                Name = nameof(EquipmentEnum.Leather),
                Description = "The breastplate and " +
                    "shoulder protectors  of this " +
                    "armor are made of leather that " +
                    "has been stiffened by being " +
                    "boiled in oil. The rest of the " +
                    "armor is made of softer and more " +
                    "flexible materials.",
                EquipmentCategory = EquipmentCategoryEnum.LightArmor,
                Equipment = EquipmentEnum.Leather,
                Cost = new GoodsCost(10, new GoldPiece()),
                AC = 11,
                MaxDexterity = int.MaxValue,
                Stealth = true,
                Strength = null,
                Weight = 10,
            },
            #endregion

            #region Light - Studded leather
            // Studded leather 45 gp 12+Dex modifier — — 13	lb.
            new ArmorEntry
            {
                Name = nameof(EquipmentEnum.StuddedLeather),
                ProperName = "Studded leather",
                Description = "Made from tough but " +
                    "flexible leather, studded " +
                    "leather is reinforced with " +
                    "close-set rivets or spikes.",
                EquipmentCategory = EquipmentCategoryEnum.LightArmor,
                Equipment = EquipmentEnum.StuddedLeather,
                Cost = new GoodsCost(45, new GoldPiece()),
                AC = 12,
                MaxDexterity = int.MaxValue,
                Stealth = true,
                Strength = null,
                Weight = 13,
            },
            #endregion

            #region Medium - Hide
            //Hide 10gp 12+Dex modifier(max 2) — — 12	lb.
            new ArmorEntry
            {
                Name = nameof(EquipmentEnum.Hide),
                Description = "This crude armor " +
                    "consists of thick furs and pelts. " +
                    "It is commonly worn by barbarian " +
                    "tribes, evil humanoids, and other " +
                    "folk who lack access to the tools " +
                    "and materials needed to create " +
                    "better armor",
                EquipmentCategory = EquipmentCategoryEnum.MediumArmor,
                Equipment = EquipmentEnum.Hide,
                Cost = new GoodsCost(10, new GoldPiece()),
                AC = 12,
                MaxDexterity = 2,
                Stealth = true,
                Strength = null,
                Weight = 12,
            },
            #endregion

            #region Medium - Chain shirt
            //Chain shirt 50gp 13+Dex modifier(max 2) — — 20lb.
            new ArmorEntry
            {
                Name = nameof(EquipmentEnum.ChainShirt),
                Description = "Made of interlocking " +
                    "metal rings, a chain shirt is " +
                    "worn between layers of clothing " +
                    "or  leather. This armor offers " +
                    "modest protection to the wearer’s " +
                    "upper body and allows the sound " +
                    "of the rings rubbing against one " +
                    "another to be muffled by outer " +
                    "layers.",
                EquipmentCategory = EquipmentCategoryEnum.MediumArmor,
                Equipment = EquipmentEnum.ChainShirt,
                Cost = new GoodsCost(50, new GoldPiece()),
                AC = 13,
                MaxDexterity = 2,
                Stealth = true,
                Strength = null,
                Weight = 20,
            },
            #endregion

            #region Medium - Scale mail
            //Scale mail 50	gp 14+Dex modifier(max 2) — Disadvantage 45	lb.
            new ArmorEntry
            {
                Name = nameof(EquipmentEnum.ScaleMail),
                ProperName = "Scale mail",
                Description = "This armor consists of " +
                    "a coat and leggings (and perhaps " +
                    "a separate skirt) of leather " +
                    "covered with overlapping pieces " +
                    "of metal, much like the scales " +
                    "of a fish. The suit includes " +
                    "gauntlets.",
                EquipmentCategory = EquipmentCategoryEnum.MediumArmor,
                Equipment = EquipmentEnum.ScaleMail,
                Cost = new GoodsCost(50, new GoldPiece()),
                AC = 14,
                MaxDexterity = 2,
                Stealth = false,
                Strength = null,
                Weight = 45,
            },
            #endregion

            #region Medium - Breastplate
            //Breastplate 400gp 14+Dex modifier(max 2) — — 20	lb.
            new ArmorEntry
            {
                Name = nameof(EquipmentEnum.Breastplate),
                Description = "This armor consists of " +
                    "a fitted metal chest piece worn " +
                    "with supple leather. Although it " +
                    "leaves the legs and arms relatively " +
                    "unprotected, this armor provides " +
                    "good protection for the wearer’s " +
                    "vital organs while leaving the " +
                    "wearer relatively unencumbered.",
                EquipmentCategory = EquipmentCategoryEnum.MediumArmor,
                Equipment = EquipmentEnum.Breastplate,
                Cost = new GoodsCost(400, new GoldPiece()),
                AC = 14,
                MaxDexterity = 2,
                Stealth = false,
                Strength = null,
                Weight = 20,
            },
            #endregion

            #region Medium - Half plate
            //Half plate 750gp 15+Dex modifier(max 2) — Disadvantage 40	lb.
            new ArmorEntry
            {
                Name = nameof(EquipmentEnum.Halfplate),
                ProperName = "Half plate",
                Description = "Half plate consists of " +
                    "shaped metal plates that cover " +
                    "most of the wearer’s body. It " +
                    "does not include leg protection " +
                    "beyond simple greaves that are " +
                    "attached with leather straps.",
                EquipmentCategory = EquipmentCategoryEnum.MediumArmor,
                Equipment = EquipmentEnum.Halfplate,
                Cost = new GoodsCost(750, new GoldPiece()),
                AC = 15,
                MaxDexterity = 2,
                Stealth = false,
                Strength = null,
                Weight = 40,
            },
            #endregion

            #region Heavy Armor - Ring mail
            //Ring mail 30gp 14 — Disadvantage 40	lb.
            new ArmorEntry
            {
                Name = nameof(EquipmentEnum.Ringmail),
                ProperName = "Ring mail",
                Description = "This armor is leather " +
                    "armor with heavy rings sewn into " +
                    "it. The rings help reinforce the " +
                    "armor against blows from swords " +
                    "and axes. Ring mail is inferior " +
                    "to chain mail, and it's usually " +
                    "worn only by those who can’t " +
                    "afford better armor.",
                EquipmentCategory = EquipmentCategoryEnum.HeavyArmor,
                Equipment = EquipmentEnum.Ringmail,
                Cost = new GoodsCost(30, new GoldPiece()),
                AC = 14,
                MaxDexterity = null,
                Stealth = false,
                Strength = null,
                Weight = 40,
            },
            #endregion

            #region Heavy Armor - Chain mail
            //Chain mail 75gp 16 Str 13 Disadvantage 55lb.
            new ArmorEntry
            {
                Name = nameof(EquipmentEnum.Chainmail),
                ProperName = "Chain mail",
                Description = "Made of interlocking " +
                    "metal rings, chain mail includes " +
                    "a layer of quilted fabric worn " +
                    "underneath the mail to prevent " +
                    "chafing and to cushion the " +
                    "impact of blows. The suit includes " +
                    "gauntlets.",
                EquipmentCategory = EquipmentCategoryEnum.HeavyArmor,
                Equipment = EquipmentEnum.Chainmail,
                Cost = new GoodsCost(75, new GoldPiece()),
                AC = 16,
                MaxDexterity = null,
                Stealth = false,
                Strength = 13,
                Weight = 55,
            },
            #endregion

            #region Heavy Armor - Splint
            //Splint 200gp 17 Str 15 Disadvantage 60lb.
            new ArmorEntry
            {
                Name = nameof(EquipmentEnum.Splint),
                Description = "This armor is made of " +
                    "narrow vertical strips of metal " +
                    "riveted to a backing of leather " +
                    "that is worn over cloth padding. " +
                    "Flexible chain mail protects the " +
                    "joints.",
                EquipmentCategory = EquipmentCategoryEnum.HeavyArmor,
                Equipment = EquipmentEnum.Splint,
                Cost = new GoodsCost(200, new GoldPiece()),
                AC = 17,
                MaxDexterity = null,
                Stealth = false,
                Strength = 15,
                Weight = 60,
            },
            #endregion

            #region Heavy Armor - Plate
            //Plate 1,500gp 18 Str 15 Disadvantage 65lb.
            new ArmorEntry
            {
                Name = nameof(EquipmentEnum.Plate),
                Description = "Plate consists of " +
                    "shaped, interlocking metal plates " +
                    "to cover the entire body. A suit " +
                    "of plate includes gauntlets, heavy " +
                    "leather boots, a visored helmet, " +
                    "and thick layers of padding " +
                    "underneath the armor. Buckles and " +
                    "straps distribute the weight over " +
                    "the body.",
                EquipmentCategory = EquipmentCategoryEnum.HeavyArmor,
                Equipment = EquipmentEnum.Plate,
                Cost = new GoodsCost(1500, new GoldPiece()),
                AC = 18,
                MaxDexterity = null,
                Stealth = false,
                Strength = 15,
                Weight = 65,
            },
            #endregion

            #region Shield
            //Shield 10	gp +2 — — 6	lb.
            new ArmorEntry
            {
                Name = nameof(EquipmentEnum.Shield),
                EquipmentCategory = EquipmentCategoryEnum.Shields,
                Equipment = EquipmentEnum.Shield,
                Cost = new GoodsCost(10, new GoldPiece()),
                AC = 2,
                MaxDexterity = null,
                Stealth = false,
                Strength = null,
                Weight = 6,
            },
            #endregion

            #endregion

            #region Weapons
            // Your class grants proficiency in certain weapons,
            // reflecting both the class’s focus and the tools you 
            // are most likely to use.Whether you favor a longsword 
            // or a longbow, your weapon and your ability to wield it
            // effectively can mean the difference between life and
            // death while adventuring,

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
                DamageType = DamageTypeEnum.Bludgeoning,
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
                DamageType = DamageTypeEnum.Piercing,
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
                DamageType = DamageTypeEnum.Bludgeoning,
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
                DamageType = DamageTypeEnum.Slashing,
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
                DamageType = DamageTypeEnum.Piercing,
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
                DamageType = DamageTypeEnum.Bludgeoning,
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
                DamageType = DamageTypeEnum.Bludgeoning,
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
                DamageType = DamageTypeEnum.Bludgeoning,
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
                DamageType = DamageTypeEnum.Slashing,
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
                DamageType = DamageTypeEnum.Piercing,
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
                DamageType = DamageTypeEnum.Piercing,
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
                DamageType = DamageTypeEnum.Piercing,
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
                DamageType = DamageTypeEnum.Piercing,
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
                DamageType = DamageTypeEnum.Bludgeoning,
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
                DamageType = DamageTypeEnum.Slashing,
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
                DamageType = DamageTypeEnum.Bludgeoning,
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
                DamageType = DamageTypeEnum.Slashing,
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
                DamageType = DamageTypeEnum.Slashing,
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
                DamageType = DamageTypeEnum.Slashing,
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
                DamageType = DamageTypeEnum.Slashing,
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
                DamageType = DamageTypeEnum.Piercing,
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
                DamageType = DamageTypeEnum.Slashing,
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
                DamageType = DamageTypeEnum.Bludgeoning,
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
                DamageType = DamageTypeEnum.Piercing,
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
                DamageType = DamageTypeEnum.Piercing,
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
                DamageType = DamageTypeEnum.Piercing,
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
                DamageType = DamageTypeEnum.Slashing,
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
                DamageType = DamageTypeEnum.Piercing,
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
                DamageType = DamageTypeEnum.Piercing,
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
                DamageType = DamageTypeEnum.Piercing,
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
                DamageType = DamageTypeEnum.Bludgeoning,
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
                DamageType = DamageTypeEnum.Slashing,
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
                DamageType = DamageTypeEnum.Piercing,
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
                DamageType = DamageTypeEnum.Piercing,
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
                DamageType = DamageTypeEnum.Piercing,
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
                DamageType = DamageTypeEnum.Piercing,
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

            #endregion

            #region Adventuring Gear

            #region Abacus
            //Abacus 2gp 2lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Abacus),
                ProperName = nameof(EquipmentEnum.Abacus),
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Abacus,
                Cost = new GoodsCost(2, new GoldPiece()),
                Weight = 2,
            },
            #endregion

            #region Acid
            //Acid(vial) 25gp 1lb.
            new ContainedBy
            {
                Name = nameof(EquipmentEnum.Acid),
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Acid,
                ProperName = nameof(EquipmentEnum.Acid),
                Cost = new GoodsCost(25, new GoldPiece()),
                Weight = 1,
                Container = EquipmentEnum.Vial,
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
            new ContainedBy
            {
                Name = nameof(EquipmentEnum.Alchemistsfire),
                ProperName = "Alchemist’s fire",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Alchemistsfire,
                Cost = new GoodsCost(50, new GoldPiece()),
                Weight = 1,
                Container= EquipmentEnum.Flask,
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
                Name = nameof(EquipmentEnum.Arrows),
                ProperName = nameof(EquipmentEnum.Arrows),
                EquipmentCategory = EquipmentCategoryEnum.Ammunition,
                Equipment = EquipmentEnum.Arrows,
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 1,
                Quantity = 20
            },
            #endregion

            #region Blowgun needles
            //Blowgun needles(50) 1gp 1lb.
            new Ammunition
            {
                Name = nameof(EquipmentEnum.BlowgunNeedles),
                ProperName = "Blowgun needles",
                EquipmentCategory = EquipmentCategoryEnum.Ammunition,
                Equipment = EquipmentEnum.BlowgunNeedles,
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 1,
                Quantity = 50
            },
            #endregion

            #region Crossbow bolts
            //Crossbow bolts(20) 1gp 1½lb.
            new Ammunition
            {
                Name = nameof(EquipmentEnum.Crossbowbolts),
                ProperName = "Crossbow bolts",
                Cost = new GoodsCost(1, new GoldPiece()),
                EquipmentCategory = EquipmentCategoryEnum.Ammunition,
                Equipment = EquipmentEnum.Crossbowbolts,
                Weight = Convert.ToDecimal("1.5"),
                Quantity = 20
            },
            #endregion

            #region Sling bullets
            //Sling bullets(20) 4cp 1½lb.
            new Ammunition
            {
                Name = nameof(EquipmentEnum.Slingbullets),
                ProperName = "Sling bullets",
                EquipmentCategory = EquipmentCategoryEnum.Ammunition,
                Equipment = EquipmentEnum.Slingbullets,
                Cost = new GoodsCost(4, new CopperPiece()),
                Weight = Convert.ToDecimal("1.5"),
                Quantity = 20
            },
            #endregion

            #region Antitoxin
            //Antitoxin(vial) 50gp —
            new ContainedBy
            {
                Name = nameof(EquipmentEnum.Antitoxin),
                ProperName = "Antitoxin",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Antitoxin,
                Cost = new GoodsCost(50, new GoldPiece()),
                Weight = 0,
                Container = EquipmentEnum.Vial,
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
                Name = nameof(EquipmentEnum.Crystal),
                ProperName = nameof(EquipmentEnum.Crystal),
                EquipmentCategory = EquipmentCategoryEnum.ArcaneFocus,
                Equipment = EquipmentEnum.Crystal,
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
                Name = nameof(EquipmentEnum.Orb),
                ProperName = "Orb",
                EquipmentCategory = EquipmentCategoryEnum.ArcaneFocus,
                Equipment = EquipmentEnum.Orb,
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
                Name = nameof(EquipmentEnum.Rod),
                ProperName = nameof(EquipmentEnum.Rod),
                EquipmentCategory = EquipmentCategoryEnum.ArcaneFocus,
                Equipment = EquipmentEnum.Rod,
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
                Name = nameof(EquipmentEnum.Staff),
                ProperName = nameof(EquipmentEnum.Staff),
                EquipmentCategory = EquipmentCategoryEnum.ArcaneFocus,
                Equipment = EquipmentEnum.Staff,
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
                Name = nameof(EquipmentEnum.Wand),
                ProperName = nameof(EquipmentEnum.Wand),
                EquipmentCategory = EquipmentCategoryEnum.ArcaneFocus,
                Equipment = EquipmentEnum.Wand,
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
                Name = nameof(EquipmentEnum.Backpack),
                ProperName = nameof(EquipmentEnum.Backpack),
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Backpack,
                Cost = new GoodsCost(2, new GoldPiece()),
                Weight = 5,
            },
            #endregion

            #region Ball bearings
            //Ball bearings(bag of	1,000) 1gp 2lb.
            new BagOf
            {
                Name = nameof(EquipmentEnum.Ballbearings),
                ProperName = "Ball bearings",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Ballbearings,
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
                Name = nameof(EquipmentEnum.Barrel),
                ProperName = nameof(EquipmentEnum.Barrel),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Barrel,
                Cost = new GoodsCost(2, new GoldPiece()),
                Weight = 70,
            },
            #endregion

            #region Basket
            //Basket 4sp 2lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Basket),
                ProperName = nameof(EquipmentEnum.Basket),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Basket,
                Cost = new GoodsCost(2, new SilverPiece()),
                Weight = 2,
            },
            #endregion

            #region Bedroll
            //Bedroll 1gp 7lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Bedroll),
                ProperName = nameof(EquipmentEnum.Bedroll),
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Bedroll,
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 7,
            },
            #endregion

            #region Bell
            //Bell 1gp —
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Bell),
                ProperName = nameof(EquipmentEnum.Bell),
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Bell,
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 0,
            },
            #endregion

            #region Blanket
            //Blanket 5sp 3lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Blanket),
                ProperName = nameof(EquipmentEnum.Blanket),
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Blanket,
                Cost = new GoodsCost(5, new SilverPiece()),
                Weight = 3,
            },
            #endregion

            #region Block and tackle
            //Block and tackle 1gp 5lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Blockandtackle),
                ProperName = "Block and tackle",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Blockandtackle,
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
                Name = nameof(EquipmentEnum.Book),
                ProperName = nameof(EquipmentEnum.Book),
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Book,
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
                Name = nameof(EquipmentEnum.GlassBottle),
                ProperName = "Glass Bottle",
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.GlassBottle,
                Cost = new GoodsCost(2, new GoldPiece()),
                Weight = 2,
            },
            #endregion

            #region Bucket
            //Bucket 5cp 2lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Bucket),
                ProperName = nameof(EquipmentEnum.Bucket),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Bucket,
                Cost = new GoodsCost(5, new CopperPiece()),
                Weight = 2,
            },
            #endregion

            #region Caltrops
            //Caltrops(bag of 20) 1gp 2lb.
            new BagOf
            {
                Name = nameof(EquipmentEnum.Caltrops),
                ProperName = nameof(EquipmentEnum.Caltrops),
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Caltrops,
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
                Name = nameof(EquipmentEnum.Candle),
                ProperName = nameof(EquipmentEnum.Candle),
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Candle,
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
                Name = nameof(EquipmentEnum.CrossbowboltCase),
                ProperName = "Crossbow bolt Case",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.CrossbowboltCase,
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 1,
                Description = "This wooden case can hold up to twenty crossbow bolts.",
            },
            #endregion

            #region Map or scroll Case
            //Case,	map or scroll 1gp 1lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.MapOrScroll),
                ProperName = "Map or scroll Case",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.MapOrScroll,
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
                Name = nameof(EquipmentEnum.Chain),
                ProperName = nameof(EquipmentEnum.Chain),
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Chain,
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
                Name = nameof(EquipmentEnum.Chalk),
                ProperName = nameof(EquipmentEnum.Chalk),
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Chalk,
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
                Name = nameof(EquipmentEnum.Chest),
                ProperName = nameof(EquipmentEnum.Chest),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Chest,
                Cost = new GoodsCost(5, new GoldPiece()),
                Weight = 25,
            },
            #endregion

            #region Climber’s kit
            //Climber’s kit 25gp 12lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Climberskit),
                ProperName = "Climber’s kit",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Climberskit,
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
                Name = nameof(EquipmentEnum.CommonClothes),
                ProperName = "Common Clothes",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.CommonClothes,
                Cost = new GoodsCost(5, new SilverPiece()),
                Weight = 3,
            },
            #endregion

            #region Costume Clothes
            //Costume Clothes 5gp 4lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.CostumeClothes),
                ProperName = "Costume Clothes",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.CostumeClothes,
                Cost = new GoodsCost(5, new GoldPiece()),
                Weight = 4,
            },
            #endregion

            #region Fine Clothes
            //Clothes, fine 15gp 6lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.FineClothes),
                ProperName = "Fine Clothes",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.FineClothes,
                Cost = new GoodsCost(15, new GoldPiece()),
                Weight = 6,
            },
            #endregion

            #region Traveler’s Clothes
            //Clothes,	traveler’s 2gp 4lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.TravelersClothes),
                ProperName = "Traveler’s Clothes",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.TravelersClothes,
                Cost = new GoodsCost(2, new GoldPiece()),
                Weight = 4,
            },
            #endregion

            #region Component Pouch
            //Component pouch 25gp 2lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.ComponentPouch),
                ProperName = "Component Pouch",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.ComponentPouch,
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
                Name = nameof(EquipmentEnum.Crowbar),
                ProperName = nameof(EquipmentEnum.Crowbar),
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Crowbar,
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
                Name = nameof(EquipmentEnum.SprigOfMistletoe),
                ProperName = "Sprig of mistletoe",
                EquipmentCategory = EquipmentCategoryEnum.DruidicFocus,
                Equipment = EquipmentEnum.SprigOfMistletoe,
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
                Name = nameof(EquipmentEnum.Totem),
                ProperName = nameof(EquipmentEnum.Totem),
                EquipmentCategory = EquipmentCategoryEnum.DruidicFocus,
                Equipment = EquipmentEnum.Totem,
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
                Name = nameof(EquipmentEnum.Woodenstaff),
                ProperName = "Wooden staff",
                EquipmentCategory = EquipmentCategoryEnum.DruidicFocus,
                Equipment = EquipmentEnum.Woodenstaff,
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
                Name = nameof(EquipmentEnum.Yewwand),
                ProperName = "Yew wand",
                EquipmentCategory = EquipmentCategoryEnum.DruidicFocus,
                Equipment = EquipmentEnum.Yewwand,
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
                Name = nameof(EquipmentEnum.Fishingtackle),
                ProperName = "Fishing tackle",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Fishingtackle,
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
                Name = nameof(EquipmentEnum.Flask),
                ProperName = nameof(EquipmentEnum.Flask),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Flask,
                Cost = new GoodsCost(2, new CopperPiece()),
                Weight = 1,
            },
            #endregion

            #region Tankard
            //Flask or tankard 2cp 1lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Tankard),
                ProperName = nameof(EquipmentEnum.Tankard),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Tankard,
                Cost = new GoodsCost(2, new CopperPiece()),
                Weight = 1,
            },
            #endregion

            #region Grappling hook
            //Grappling hook 2gp 4lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Grapplinghook),
                ProperName = "Grappling hook",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Grapplinghook,
                Cost = new GoodsCost(2, new GoldPiece()),
                Weight = 4,
            },
            #endregion

            #region Hammer
            //Hammer 1gp 3lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Hammer),
                ProperName = nameof(EquipmentEnum.Hammer),
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Hammer,
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 3,
            },
            #endregion        

            #region Sledge Hammer 
            //Hammer, sledge 2gp 10lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.SledgeHammer),
                ProperName = "Sledge Hammer",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.SledgeHammer,
                Cost = new GoodsCost(2, new GoldPiece()),
                Weight = 10,
            },
            #endregion        

            #region Healer’s kit 
            //Healer’s kit 5gp 3lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.HealersKit),
                ProperName = "Healer’s kit",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.HealersKit,
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
                Name = nameof(EquipmentEnum.Amulet),
                ProperName = nameof(EquipmentEnum.Amulet),
                EquipmentCategory = EquipmentCategoryEnum.HolySymbol,
                Equipment = EquipmentEnum.Amulet,
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
                Name = nameof(EquipmentEnum.Emblem),
                ProperName = nameof(EquipmentEnum.Emblem),
                EquipmentCategory = EquipmentCategoryEnum.HolySymbol,
                Equipment = EquipmentEnum.Emblem,
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
                Name = nameof(EquipmentEnum.Reliquary),
                ProperName = nameof(EquipmentEnum.Reliquary),
                EquipmentCategory = EquipmentCategoryEnum.HolySymbol,
                Equipment = EquipmentEnum.Reliquary,
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
            new ContainedBy
            {
                Name = nameof(EquipmentEnum.Holywater),
                ProperName = "Holy water",
                EquipmentCategory = EquipmentCategoryEnum.HolySymbol,
                Equipment = EquipmentEnum.Holywater,
                Cost = new GoodsCost(25, new GoldPiece()),
                Weight = 1,
                Container = EquipmentEnum.Flask,
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
                Name = nameof(EquipmentEnum.Hourglass),
                ProperName = nameof(EquipmentEnum.Hourglass),
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Hourglass,
                Cost = new GoodsCost(25, new GoldPiece()),
                Weight = 1,
            },
            #endregion        

            #region Hunting trap
            //Hunting trap 5gp 25lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Huntingtrap),
                ProperName = "Hunting trap",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Huntingtrap,
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
            new ContainedBy
            {
                Name = nameof(EquipmentEnum.Ink),
                ProperName = nameof(EquipmentEnum.Ink),
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Ink,
                Cost = new GoodsCost(10, new GoldPiece()),
                Weight = 0,
                Container = EquipmentEnum.Bottle1Ounce
            },
            #endregion        

            #region Ink pen
            //Ink pen 2cp —
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Inkpen),
                ProperName = "Ink pen",
                EquipmentCategory = EquipmentCategoryEnum.Gear,
                Equipment = EquipmentEnum.Inkpen,
                Cost = new GoodsCost(2, new CopperPiece()),
                Weight = 0,
            },
            #endregion        

            #region Jug
            //Jug or pitcher 2cp 4lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Jug),
                ProperName = nameof(EquipmentEnum.Jug),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Jug,
                Cost = new GoodsCost(2, new CopperPiece()),
                Weight = 4,
            },
            #endregion        

            #region Pitcher
            //Jug or pitcher 2cp 4lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Pitcher),
                ProperName = nameof(EquipmentEnum.Pitcher),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Pitcher,
                Cost = new GoodsCost(2, new CopperPiece()),
                Weight = 4,
            },
            #endregion

            #endregion

            #region Tools
            
            #region Alchemist’s supplies
            //Alchemist’s supplies 50	gp 8	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.AlchemistsSupplies),
                ProperName = "Alchemist’s supplies",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.AlchemistsSupplies,
                Cost = new GoodsCost(50, new GoldPiece()),
                Weight = 8,
            },
            #endregion
            
            #region Brewer’s supplies
            //Brewer’s supplies 20	gp 9	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.BrewersSupplies),
                ProperName = "Brewer’s supplies",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.BrewersSupplies,
                Cost = new GoodsCost(20, new GoldPiece()),
                Weight = 9,
            },
            #endregion
            
            #region Calligrapher's supplies
            //Calligrapher's supplies 10	gp 5	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.CalligraphersSupplies),
                ProperName = "Calligrapher's supplies",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.CalligraphersSupplies,
                Cost = new GoodsCost(10, new GoldPiece()),
                Weight = 5,
            },
            #endregion
            
            #region Carpenter’s tools
            //Carpenter’s tools 8	gp 6	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.CarpentersTools),
                ProperName = "Carpenter’s tools",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.CarpentersTools,
                Cost = new GoodsCost(8, new GoldPiece()),
                Weight = 6,
            },
            #endregion
            
            #region Cartographer’s tools
            //Cartographer’s tools 15	gp 6	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.CartographersTools),
                ProperName = "Cartographer’s tools",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.CartographersTools,
                Cost = new GoodsCost(15, new GoldPiece()),
                Weight = 6,
            },
            #endregion
            
            #region Cobbler’s tools
            //Cobbler’s tools 5	gp 5	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.CobblersTools),
                ProperName = "Cobbler’s tools",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.CobblersTools,
                Cost = new GoodsCost(5, new GoldPiece()),
                Weight = 5,
            },
            #endregion
            
            #region Cook’s utensils
            //Cook’s utensils 1	gp 8	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.CooksUtensils),
                ProperName = "Cook’s utensils",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.CooksUtensils,
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 8,
            },
            #endregion
            
            #region Glassblower’s tools
            //Glassblower’s tools 30	gp 5	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.GlassblowersTools),
                ProperName = "Glassblower’s tools",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.GlassblowersTools,
                Cost = new GoodsCost(30, new GoldPiece()),
                Weight = 5,
            },
            #endregion
            
            #region Jeweler’s tools
            //Jeweler’s tools 25	gp 2	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.JewelersTools),
                ProperName = "Jeweler’s tools",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.JewelersTools,
                Cost = new GoodsCost(25, new GoldPiece()),
                Weight = 2,
            },
            #endregion
            
            #region Leatherworker’s tools
            //Leather worker's tools 5	gp 5	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.LeatherworkersTools),
                ProperName = "Leatherworker’s tools",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.LeatherworkersTools,
                Cost = new GoodsCost(5, new GoldPiece()),
                Weight = 5,
            },
            #endregion
            
            #region Mason’s tools
            //Mason’s tools 10	gp 8	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.MasonsTools),
                ProperName = "Mason’s tools",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.MasonsTools,
                Cost = new GoodsCost(10, new GoldPiece()),
                Weight = 8,
            },
            #endregion
            
            #region Painter’s supplies
            //Painter’s supplies 10	gp 5	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.PaintersSupplies),
                ProperName = "Painter’s supplies",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.PaintersSupplies,
                Cost = new GoodsCost(10, new GoldPiece()),
                Weight = 5,
            },
            #endregion
            
            #region Potter’s tools
            //Potter’s tools 10	gp 3	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.PottersTools),
                ProperName = "Potter’s tools",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.PottersTools,
                Cost = new GoodsCost(10, new GoldPiece()),
                Weight = 3,
            },
            #endregion
            
            #region Smith’s tools
            //Smith’s tools 20	gp 8	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.SmithsTools),
                ProperName = "Smith’s tools",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.SmithsTools,
                Cost = new GoodsCost(20, new GoldPiece()),
                Weight = 8,
            },
            #endregion
            
            #region Tinker’s tools
            //Tinker’s tools 50	gp 10	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.TinkersTools),
                ProperName = "Tinker’s tools",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.TinkersTools,
                Cost = new GoodsCost(50, new GoldPiece()),
                Weight = 10,
            },
            #endregion
            
            #region Weaver’s tools
            //Weaver’s tools 1	gp 5	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.WeaversTools),
                ProperName = "Weaver’s tools",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.WeaversTools,
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 5,
            },
            #endregion
            
            #region Woodcarver’s tools
            //Woodcarver’s tools 1	gp 5	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.WoodcarversTools),
                ProperName = "Woodcarver’s tools",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.WoodcarversTools,
                Cost = new GoodsCost(1, new GoldPiece()),
                Weight = 5,
            },
            #endregion
            
            #region Disguise kit
            //Disguise kit 25	gp 3	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.DisguiseKit),
                ProperName = "Disguise kit",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.DisguiseKit,
                Cost = new GoodsCost(25, new GoldPiece()),
                Weight = 3,
            },
            #endregion
            
            #region Forgery kit
            //Forgery kit 15	gp 5	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.ForgeryKit),
                ProperName = "Forgery kit",
                EquipmentCategory = EquipmentCategoryEnum.Artisanstools,
                Equipment = EquipmentEnum.ForgeryKit,
                Cost = new GoodsCost(15, new GoldPiece()),
                Weight = 5,
            },
            #endregion
            
            #region Dice set
            //Dice set 1	sp —
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.DiceSet),
                ProperName = "Dice set",
                EquipmentCategory = EquipmentCategoryEnum.Tools,
                Equipment = EquipmentEnum.DiceSet,
                Cost = new GoodsCost(1, new SilverPiece()),
                Weight = 0,
            },
            #endregion
            
            #region Playing card set
            //Playing card set 5	sp —
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.PlayingCardSet),
                ProperName = "Playing card set",
                EquipmentCategory = EquipmentCategoryEnum.Tools,
                Equipment = EquipmentEnum.PlayingCardSet,
                Cost = new GoodsCost(5, new SilverPiece()),
                Weight = 0,
            },
            #endregion
            
            #region Herbalism kit
            //Herbalism kit 5	gp 3	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.HerbalismKit),
                ProperName = "Herbalism kit",
                EquipmentCategory = EquipmentCategoryEnum.Tools,
                Equipment = EquipmentEnum.HerbalismKit,
                Cost = new GoodsCost(5, new GoldPiece()),
                Weight = 3,
            },
            #endregion
            
            #region Bagpipes
            //Bagpipes 30	gp 6	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Bagpipes),
                ProperName = nameof(EquipmentEnum.Bagpipes),
                EquipmentCategory = EquipmentCategoryEnum.MusicalInstrument,
                Equipment = EquipmentEnum.Bagpipes,
                Cost = new GoodsCost(30, new GoldPiece()),
                Weight = 6,
            },
            #endregion
            
            #region Drum
            //Drum 6	gp 3	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Drum),
                ProperName = nameof(EquipmentEnum.Drum),
                EquipmentCategory = EquipmentCategoryEnum.MusicalInstrument,
                Equipment = EquipmentEnum.Drum,
                Cost = new GoodsCost(6, new GoldPiece()),
                Weight = 3,
            },
            #endregion
            
            #region Dulcimer
            //Dulcimer 25	gp 10	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Dulcimer),
                ProperName = nameof(EquipmentEnum.Dulcimer),
                EquipmentCategory = EquipmentCategoryEnum.MusicalInstrument,
                Equipment = EquipmentEnum.Dulcimer,
                Cost = new GoodsCost(25, new GoldPiece()),
                Weight = 10,
            },
            #endregion
            
            #region Flute
            //Flute 2	gp 1	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Flute),
                ProperName = nameof(EquipmentEnum.Flute),
                EquipmentCategory = EquipmentCategoryEnum.MusicalInstrument,
                Equipment = EquipmentEnum.Flute,
                Cost = new GoodsCost(2, new GoldPiece()),
                Weight = 1,
            },
            #endregion
            
            #region Lute
            //Lute 35	gp 2	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Lute),
                ProperName = nameof(EquipmentEnum.Lute),
                EquipmentCategory = EquipmentCategoryEnum.MusicalInstrument,
                Equipment = EquipmentEnum.Lute,
                Cost = new GoodsCost(35, new GoldPiece()),
                Weight = 2,
            },
            #endregion
            
            #region Lyre
            //Lyre 30	gp 2	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Lyre),
                ProperName = nameof(EquipmentEnum.Lyre),
                EquipmentCategory = EquipmentCategoryEnum.MusicalInstrument,
                Equipment = EquipmentEnum.Lyre,
                Cost = new GoodsCost(30, new GoldPiece()),
                Weight = 2,
            },
            #endregion
            
            #region Horn
            //Horn 3	gp 2	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Horn),
                ProperName = nameof(EquipmentEnum.Horn),
                EquipmentCategory = EquipmentCategoryEnum.MusicalInstrument,
                Equipment = EquipmentEnum.Horn,
                Cost = new GoodsCost(3, new GoldPiece()),
                Weight = 2,
            },
            #endregion

            #region Pan flute
            //Pan flute 12	gp 2	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.PanFlute),
                ProperName = "Pan flute",
                EquipmentCategory = EquipmentCategoryEnum.MusicalInstrument,
                Equipment = EquipmentEnum.PanFlute,
                Cost = new GoodsCost(12, new GoldPiece()),
                Weight = 2,
            },
            #endregion

            #region Shawm
            //Shawm 2	gp 1	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Shawm),
                ProperName = nameof(EquipmentEnum.Shawm),
                EquipmentCategory = EquipmentCategoryEnum.MusicalInstrument,
                Equipment = EquipmentEnum.Shawm,
                Cost = new GoodsCost(2, new GoldPiece()),
                Weight = 1,
            },
            #endregion

            #region Viol
            //Viol 30	gp 1	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.Viol),
                ProperName = nameof(EquipmentEnum.Viol),
                EquipmentCategory = EquipmentCategoryEnum.MusicalInstrument,
                Equipment = EquipmentEnum.Viol,
                Cost = new GoodsCost(30, new GoldPiece()),
                Weight = 1,
            },
            #endregion

            #region Navigator’s tools
            //Navigator’s tools 25	gp 2	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.NavigatorsTools),
                ProperName = "Navigator’s tools",
                EquipmentCategory = EquipmentCategoryEnum.Tools,
                Equipment = EquipmentEnum.NavigatorsTools,
                Cost = new GoodsCost(25, new GoldPiece()),
                Weight = 2,
            },
            #endregion

            #region Poisoner’s kit
            //Poisoner’s kit 50	gp 2	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.PoisonersKit),
                ProperName = "Poisoner’s kit",
                EquipmentCategory = EquipmentCategoryEnum.Tools,
                Equipment = EquipmentEnum.PoisonersKit,
                Cost = new GoodsCost(50, new GoldPiece()),
                Weight = 2,
            },
            #endregion

            #region Thieves’ tools
            //Thieves’	tools 25	gp 1	lb.
            new GearTableEntry
            {
                Name = nameof(EquipmentEnum.ThievesTools),
                ProperName = "Thieves' Tools",
                EquipmentCategory = EquipmentCategoryEnum.Tools,
                Equipment = EquipmentEnum.ThievesTools,
                Cost = new GoodsCost(25, new GoldPiece()),
                Weight = 1,
            },
            #endregion

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

