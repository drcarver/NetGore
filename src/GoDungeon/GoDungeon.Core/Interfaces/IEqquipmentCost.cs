namespace GoDungeon.Core.Interfaces
{
    public interface IEquipmentCost
    {
        /// <summary>
        /// The cost of the equipment
        /// </summary>
        ICoin Cost { get; set; }

        /// <summary>
        /// The Quantity of the item
        /// </summary>
        decimal Quantity { get; set; }
    }
}