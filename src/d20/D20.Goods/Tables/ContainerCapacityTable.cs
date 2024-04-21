using System.Diagnostics.CodeAnalysis;

using D20.Core.Enum;
using D20.Core.Models;
using D20.Goods.Enum;
using D20.Goods.Models;

namespace D20.Goods.Tables;

public class ContainerCapacityTable : NamedTable, IContainerCapacityTable
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
                Name = nameof(EquipmentEnum.Backpack),
                ProperName = nameof(EquipmentEnum.Backpack),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Backpack,
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
                Name = nameof(EquipmentEnum.Barrel),
                ProperName = nameof(EquipmentEnum.Barrel),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Barrel,
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
                Name = nameof(EquipmentEnum.Basket),
                ProperName = nameof(EquipmentEnum.Basket),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Basket,
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

            #region Bottle 1 Ounce
            //Bottle 1 Ounce liquid
            new ContainerCapacityEntry
            {
                Name = nameof(EquipmentEnum.Bottle1Ounce),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Bottle1Ounce,
                ProperName = "Bottle 1 Ounce",
                Capacity =
                [
                    new Capacity
                    {
                        Quantity = Convert.ToDecimal("1"),
                        CapacityUnitType =  CapacityUnitTypeEnum.Ounce,
                        Description = "Ounce liquid"
                    },
                ]
            },
            #endregion

            #region Bottle - 1.5 Pints
            //Bottle 1½	pints liquid
            new ContainerCapacityEntry
            {
                Name = nameof(EquipmentEnum.Bottle),
                ProperName = nameof(EquipmentEnum.Bottle),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Bottle,
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
                Name = nameof(EquipmentEnum.Bucket),
                ProperName = nameof(EquipmentEnum.Bucket),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Bucket,
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
                Name = nameof(EquipmentEnum.Chest),
                ProperName = nameof(EquipmentEnum.Chest),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Chest,
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
                Name = nameof(EquipmentEnum.Flask),
                ProperName = nameof(EquipmentEnum.Flask),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Flask,
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
                Name = nameof(EquipmentEnum.Tankard),
                ProperName = nameof(EquipmentEnum.Tankard),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Tankard,
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
                Name = nameof(EquipmentEnum.Jug),
                ProperName = nameof(EquipmentEnum.Jug),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Jug,
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
                Name = nameof(EquipmentEnum.Pitcher),
                ProperName = nameof(EquipmentEnum.Pitcher),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Pitcher,
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
                Name = nameof(EquipmentEnum.IronPot),
                ProperName = "Iron Pot",
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.IronPot,
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
                Name = nameof(EquipmentEnum.Pouch),
                ProperName = nameof(EquipmentEnum.Pouch),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Pouch,
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
                Name = nameof(EquipmentEnum.Sack),
                ProperName = nameof(EquipmentEnum.Sack),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Sack,
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
                Name = nameof(EquipmentEnum.Vial),
                ProperName = nameof(EquipmentEnum.Vial),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Vial,
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
                Name = nameof(EquipmentEnum.Waterskin),
                ProperName = nameof(EquipmentEnum.Waterskin),
                EquipmentCategory = EquipmentCategoryEnum.Container,
                Equipment = EquipmentEnum.Waterskin,
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

