using System.Diagnostics.CodeAnalysis;

using D20.Core.Enum;
using D20.Core.Models;
using D20.Goods.Enum;
using D20.Goods.Models;

namespace D20.Goods.Tables;

public class ContainerCapacityTable : GameTable, IContainerCapacityTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ContainerCapacityTable()
    {
        Name = nameof(ContainerCapacityTable);
        ProperName = "Container Capacity Table";
        TableType = TableTypeEnum.GoodsTable;
        Description = "Container Capacity";
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
            #region Backpack
            //Backpack* 1	cubic foot/30	pounds of  gear
            new ContainerCapacityEntry
            {
                Name = nameof(AdventuringGearEnum.Backpack),
                ProperName = "Backpack",
                Description =
                    "You can also strap items, such as a bedroll " +
                    "or a coil of rope, to the outside of a " +
                    "backpack.",
                Capacity = 
                [
                    new Capacity
                    {
                        Quantity = 1,
                        CapacityUnitType =  CapacityUnitTypeEnum.CubicFeet,
                        Description = "cubic foot"
                    },
                    new Capacity
                    {
                        Quantity = 30,
                        CapacityUnitType =  CapacityUnitTypeEnum.Pound,
                        Description = "pounds of  gear"
                    },
                ]
            },
            #endregion

            #region Barrel
            //Barrel 40	gallons liquid, 4	cubic feet    solid
            new ContainerCapacityEntry
            {
                Name = nameof(AdventuringGearEnum.Barrel),
                ProperName = "Barrel",
                Capacity =
                [
                    new Capacity
                    {
                        Quantity = 40,
                        CapacityUnitType =  CapacityUnitTypeEnum.Gallon,
                        Description = "gallons liquid"
                    },
                    new Capacity
                    {
                        Quantity = 4,
                        CapacityUnitType =  CapacityUnitTypeEnum.CubicFeet,
                        Description = "cubic feet solid"
                    },
                ]
            },
            #endregion

            #region Basket
            //Basket 2 cubic feet/40 pounds of  gear
            new ContainerCapacityEntry
            {
                Name = nameof(AdventuringGearEnum.Basket),
                ProperName = "Basket",
                Capacity =
                [
                    new Capacity
                    {
                        Quantity = 2,
                        CapacityUnitType =  CapacityUnitTypeEnum.CubicFeet,
                        Description = "cubic feet"
                    },
                    new Capacity
                    {
                        Quantity = 40,
                        CapacityUnitType =  CapacityUnitTypeEnum.Pound,
                        Description = "pounds of  gear"
                    },
                ]
            },
            #endregion

            #region Bottle
            //Bottle 1½	pints liquid
            new ContainerCapacityEntry
            {
                Name = nameof(AdventuringGearEnum.Bottle),
                ProperName = "Bottle",
                Capacity =
                [
                    new Capacity
                    {
                        Quantity = Convert.ToDecimal("1.5"),
                        CapacityUnitType =  CapacityUnitTypeEnum.Pint,
                        Description = "pints liquid"
                    },
                ]
            },
            #endregion

            #region Bucket
            //Bucket 3	gallons liquid, 1/2	cubic foot    solid
            new ContainerCapacityEntry
            {
                Name = nameof(AdventuringGearEnum.Bucket),
                ProperName = "Bucket",
                Capacity =
                [
                    new Capacity
                    {
                        Quantity = 3,
                        CapacityUnitType =  CapacityUnitTypeEnum.Gallon,
                        Description = "gallons liquid"
                    },
                    new Capacity
                    {
                        Quantity = Convert.ToDecimal(".5"),
                        CapacityUnitType =  CapacityUnitTypeEnum.CubicFeet,
                        Description = "cubic foot solid"
                    },
                ]
            },
            #endregion

            #region Chest
            //Chest 12	cubic feet/300	pounds of  gear
            new ContainerCapacityEntry
            {
                Name = nameof(AdventuringGearEnum.Chest),
                ProperName = "Chest",
                Capacity =
                [
                    new Capacity
                    {
                        Quantity = 12,
                        CapacityUnitType =  CapacityUnitTypeEnum.CubicFeet,
                        Description = "cubic feet"
                    },
                    new Capacity
                    {
                        Quantity = 300,
                        CapacityUnitType =  CapacityUnitTypeEnum.Pound,
                        Description = "pounds of  gear"
                    },
                ]
            },
            #endregion

            #region Flask
            //Flask   or tankard 1	pint liquid
            new ContainerCapacityEntry
            {
                Name = nameof(AdventuringGearEnum.Flask),
                ProperName = "Flask",
                Capacity =
                [
                    new Capacity
                    {
                        Quantity = 1,
                        CapacityUnitType =  CapacityUnitTypeEnum.Pint,
                        Description = "pint liquid"
                    },
                ]
            },
            #endregion

            #region Tankard
            //Flask   or tankard 1	pint liquid
            new ContainerCapacityEntry
            {
                Name = nameof(AdventuringGearEnum.Tankard),
                ProperName = "Tankard",
                Capacity =
                [
                    new Capacity
                    {
                        Quantity = 1,
                        CapacityUnitType =  CapacityUnitTypeEnum.Pint,
                        Description = "pint liquid"
                    },
                ]
            },
            #endregion

            #region Jug
            //Jug or  pitcher 1	gallon liquid
            new ContainerCapacityEntry
            {
                Name = nameof(AdventuringGearEnum.Jug),
                ProperName = "Jug",
                Capacity =
                [
                    new Capacity
                    {
                        Quantity = 1,
                        CapacityUnitType =  CapacityUnitTypeEnum.Gallon,
                        Description = "gallon liquid"
                    },
                ]
            },
            #endregion

            #region Pitcher
            //Jug or  pitcher 1	gallon liquid
            new ContainerCapacityEntry
            {
                Name = nameof(AdventuringGearEnum.Pitcher),
                ProperName = "Pitcher",
                Capacity =
                [
                    new Capacity
                    {
                        Quantity = 1,
                        CapacityUnitType =  CapacityUnitTypeEnum.Gallon,
                        Description = "gallon liquid"
                    },
                ]
            },
            #endregion

            #region Iron Pot	
            //Pot,	iron 1	gallon liquid
            new ContainerCapacityEntry
            {
                Name = nameof(AdventuringGearEnum.IronPot),
                ProperName = "Iron Pot",
                Capacity =
                [
                    new Capacity
                    {
                        Quantity = 1,
                        CapacityUnitType =  CapacityUnitTypeEnum.Gallon,
                        Description = "gallon liquid"
                    },
                ]
            },
            #endregion

            #region Pouch	
            //Pouch 1/5	cubic foot/6	pounds of  gear
            new ContainerCapacityEntry
            {
                Name = nameof(AdventuringGearEnum.Pouch),
                ProperName = "Pouch",
                Capacity =
                [
                    new Capacity
                    {
                        Quantity = Convert.ToDecimal(".2"),
                        CapacityUnitType =  CapacityUnitTypeEnum.CubicFeet,
                        Description = "cubic foot"
                    },
                    new Capacity
                    {
                        Quantity = 6,
                        CapacityUnitType =  CapacityUnitTypeEnum.Pound,
                        Description = "pounds of  gear"
                    },
                ]
            },
            #endregion

            #region Sack	
            //Sack 1	cubic foot/30	pounds of  gear
            new ContainerCapacityEntry
            {
                Name = nameof(AdventuringGearEnum.Sack),
                ProperName = "Sack",
                Capacity =
                [
                    new Capacity
                    {
                        Quantity = 1,
                        CapacityUnitType =  CapacityUnitTypeEnum.CubicFeet,
                        Description = "cubic foot"
                    },
                    new Capacity
                    {
                        Quantity = 30,
                        CapacityUnitType =  CapacityUnitTypeEnum.Pound,
                        Description = "pounds of  gear"
                    },
                ]
            },
            #endregion

            #region Vial	
            //Vial 4	ounces liquid
            new ContainerCapacityEntry
            {
                Name = nameof(AdventuringGearEnum.Vial),
                ProperName = "Vial",
                Capacity =
                [
                    new Capacity
                    {
                        Quantity = 4,
                        CapacityUnitType =  CapacityUnitTypeEnum.Ounce,
                        Description = "ounces liquid"
                    },
                ]
            },
            #endregion

            #region Waterskin	
            //Waterskin 4	pints liquid
            new ContainerCapacityEntry
            {
                Name = nameof(AdventuringGearEnum.Waterskin),
                ProperName = "Waterskin",
                Capacity =
                [
                    new Capacity
                    {
                        Quantity = 4,
                        CapacityUnitType =  CapacityUnitTypeEnum.Pint,
                        Description = "pints liquid"
                    },
                ]
            },
            #endregion
        ];
    }
}

