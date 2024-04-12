using System.Diagnostics.CodeAnalysis;

using D20.Core.Enum;
using D20.Core.Models;
using D20.Goods.Enum;
using D20.Goods.Interfaces;
using D20.Goods.Models;

namespace D20.Goods.Tables;

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
public class ArmorTable : GameTable, IArmorTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ArmorTable()
    {
        Name = nameof(ArmorTable);
        ProperName = "Armor Table";
        TableType = TableTypeEnum.GoodsTable;
        Description = "Adventurers have  access to a " +
            "variety of armor types, ranging from " +
            "leather armor to chain mail to costly " +
            "plate armor, with several other kinds " +
            "of armor in between. The  Armor table " +
            "collects the most commonly available " +
            "types of armor found in the game and " +
            "separates them into three categories: " +
            "light armor, medium  armor, and " +
            "heavy armor. Many warriors supplement " +
            "their armor with a shield. The Armor " +
            "table shows the cost, weight, and " +
            "other  properties of the common types " +
            "of armor";
        Table =
        [
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
        ];
    }
}
