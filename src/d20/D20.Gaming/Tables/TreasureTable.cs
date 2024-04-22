using System.Diagnostics.CodeAnalysis;

using D20.Core;
using D20.Core.Enum;
using D20.Core.Models;
using D20.Gaming.Enum;
using D20.Gaming.Interfaces;
using D20.Gaming.Models;

namespace D20.Gaming.Tables;

/// <summary>
/// This table lists treasure by value
/// </summary>
public class TreasureTable : GameTable, ITreasureTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public TreasureTable()
    {
        Name = nameof(TreasureTable);
        ProperName = "Treasure Table";
        TableType = TableTypeEnum.GamingTable;
        Description = "This table lists treasure by value";
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
            #region Low-Quality Gems (10 gp)
            //Low-Quality Gems (10 gp): 
            new GemStoneEntry
            {
                TreasureType = TreasureTypeEnum.LowQualityGem,
                Value = 10,
                GemStones = 
                [
                    "agates", 
                    "azurite", 
                    "blue quartz", 
                    "hematite",
                    "lapis lazuli", 
                    "malachite", 
                    "obsidian", 
                    "rhodochrosite", 
                    "tigereye", 
                    "turquoise", 
                    "freshwater(irregular) pearl"
                ],
            },
            #endregion

            #region Semi-Precious Gems (20-50 gp) (1d4 * 10) + 10
            //Semi-Precious Gems (20-50 gp): bloodstone", "carnelian", "chalcedony", "chrysoprase", "citrine", "jasper", "moonstone", "onyx", "peridot", "rock crystal (clear quartz)", "sard", "sardonyx", "rose, smoky, or star rose quartz", "zircon 
            new GemStoneEntry
            {
                TreasureType = TreasureTypeEnum.SemiPreciousGem,
                Value = new Dice("1d4").Total * 10 + 10,
                GemStones =
                [
                    "bloodstone", 
                    "carnelian", 
                    "chalcedony", 
                    "chrysoprase", 
                    "citrine", 
                    "jasper",
                    "moonstone", 
                    "onyx", 
                    "peridot", 
                    "rock crystal(clear quartz)", 
                    "sard", 
                    "sardonyx",
                    "smoky rose quartz", 
                    "star rose quartz", 
                    "zircon",
                ],
            },
            #endregion

            #region Medium Quality Gemstones (100 gp) (1d4 * 10 + 60)
            //Medium Quality Gemstones (100 gp): amber", "amethyst", "chrysoberyl", "coral", "red or brown-green garnet", "jade", "jet", "white, golden, pink, or silver pearl", "red, red-brown, or deep green spinel", "tourmaline
            new GemStoneEntry
            {
                TreasureType = TreasureTypeEnum.MediumQualityGem,
                Value = new Dice("1d4").Total * 10 + 60,
                GemStones =
                [
                    "amber", 
                    "amethyst", 
                    "chrysoberyl",
                    "coral", 
                    "red garnet",
                    "brown-green garnet",
                    "jade", 
                    "jet", 
                    "white pearl",
                    "golden pearl",
                    "pink pearl",
                    "silver pearl",
                    "red spinel",
                    "red-brown spinel",
                    "deep green spinel",
                    "tourmaline",
                ],
            },
            #endregion

            #region High Quality Gemstones (200-500 gp) (1d4 * 100) + 100
            //High Quality Gemstones (500 gp): alexandrite", "aquamarine", "violet garnet", "black pearl", "deep blue spinel", "golden yellow topaz
            new GemStoneEntry
            {
                TreasureType = TreasureTypeEnum.HighQualityGem,
                Value = new Dice("1d4").Total * 100 + 100,
                GemStones =
                [
                    "alexandrite", 
                    "aquamarine", 
                    "violet garnet", 
                    "black pearl", 
                    "deep blue spinel", 
                    "golden yellow topaz",
                ],
            },
            #endregion

            #region Jewels (500-1,000 gp) (1d6 * 100) + 400
            //Jewels (1,000 gp): emerald", "white, black, or fire opal", "blue sapphire", "fiery yellow or rich purple corundum", "blue or black star sapphire
            new JewelsEntry
            {
                TreasureType = TreasureTypeEnum.Jewels,
                Value = (new Dice("1d6").Total * 100) + 400,
                Jewels =
                [
                    "emerald", 
                    "white opal",
                    "black opal",
                    "fire opal",
                    "blue sapphire", 
                    "fiery yellow corundum",
                    "rich purple corundum",
                    "blue star sapphire",
                    "black star sapphire",
                ],
            },
            #endregion

            #region Grand Jewels (5,000-16000 gp) (1d12 * 1000) + 4000
            //Grand Jewels (5,000 gp or more): clearest bright green emerald; diamond; jacinth; ruby
            new JewelsEntry
            {
                TreasureType = TreasureTypeEnum.GrandJewel,
                Value = (new Dice("1d12").Total * 1000) + 4000,
                Jewels =
                [
                    "clearest bright green emerald",
                    "diamond",
                    "jacinth",
                    "ruby"
                ],
            },
            #endregion

            #region Jewelry, Minor (20-50 gp) (1d4 * 10) + 10;
            //Jewelry, Minor (50 gp): This category includes relatively small pieces of jewelry crafted from materials like brass, bronze, copper, ivory, or even exotic woods, sometimes set with tiny or flawed low-quality gems. Minor jewelry includes rings, bracelets, and earrings.
            new JewelryEntry
            {
                TreasureType = TreasureTypeEnum.MinorJewelry,
                Value = (new Dice("1d4").Total * 10) + 10,
                Jewelry =
                [
                    "brass ring",
                    "bronze ring",
                    "copper ring",
                    "ivory ring",
                    "brass bracelet",
                    "bronze bracelet",
                    "copper bracelet",
                    "ivory bracelet",
                    "brass earing",
                    "bronze earing",
                    "copper earing",
                    "ivory earing",
                ],
            },
            #endregion

            #region Jewelry, Normal (800–1500 gp) (1d8 * 100) + 700
            //Jewelry, Normal (800–1500 gp): Most jewelry is made of silver, gold, jade, or coral, often ornamented with semi-precious or even medium-quality gemstones. Normal jewelry includes all types of minor jewelry plus armbands, necklaces, and brooches.
            new JewelryEntry
            {
                TreasureType = TreasureTypeEnum.NormalJewelry,
                Value =  new Dice("1d8").Total * 100 + 700,
                Jewelry =
                [
                    "silver ring",
                    "gold ring",
                    "jade ring",
                    "coral ring",
                    "silver bracelet",
                    "gold bracelet",
                    "jade bracelet",
                    "coral bracelet",
                    "silver earing",
                    "gold earing",
                    "jade earing",
                    "coral earing",
                    "silver armband",
                    "gold armband",
                    "jade armband",
                    "coral armband",
                    "silver necklace",
                    "gold necklace",
                    "jade necklace",
                    "coral necklace",
                    "silver brooch",
                    "gold brooch",
                    "jade brooch",
                    "coral brooch",
                ],
            },
            #endregion

            #region Jewelry, Precious (2000-12000 gp or more) (1d12 * 1000 + 100)
            //Jewelry, Precious (500 gp or more): Truly precious jewelry is crafted from gold, mithral, platinum, or similar rare metals. Such objects include normal jewelry types plus crowns, scepters, pendants, and other large items.            new JewelryEntry
            new JewelryEntry
            {
                TreasureType = TreasureTypeEnum.PreciousJewelry,
                Value =  new Dice("1d12").Total * 1000 + 100,
                Jewelry =
                [
                    "gold ring",
                    "mithral ring",
                    "platinum ring",
                    "gold bracelet",
                    "mithral bracelet",
                    "platinum bracelet",
                    "gold earing",
                    "mithral earing",
                    "platinum earing",
                    "gold armband",
                    "mithral armband",
                    "platinum armband",
                    "gold necklace",
                    "mithral necklace",
                    "platinum necklace",
                    "gold brooch",
                    "mithral brooch",
                    "platinum brooch",
                    "gold crown",
                    "mithral crown",
                    "platinum crown",
                    "gold scepter",
                    "mithral scepter",
                    "platinum scepter",
                    "gold pendant",
                    "mithral pendant",
                    "platinum pendant",
                ],
            },
            #endregion
        ];
    }
}
