using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public partial class EquipmentCostViewModel : ObservableObject, IEquipmentCost
    {
        /// <summary>
        /// The cost of a good
        /// </summary>
        /// <param name="amount">The amount of coins</param>
        /// <param name="coin">The coins</param>
        public EquipmentCostViewModel(int amount, ICoin coin)
        {
            Quantity = amount;
            Cost = coin;
        }

        /// <summary>
        /// The cost of the equipment
        /// </summary>
        [ObservableProperty]
        private ICoin? cost;

        /// <summary>
        /// The Quantity of the item
        /// </summary>
        [ObservableProperty]
        private decimal quantity;
    }
}
