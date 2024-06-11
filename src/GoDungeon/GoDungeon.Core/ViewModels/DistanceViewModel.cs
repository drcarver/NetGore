using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels
{
    public partial class DistanceViewModel : ObservableObject, IDistance
    {
        /// <summary>
        /// The distance
        /// </summary>
        [ObservableProperty]
        private int unit = 0;

        /// <summary>
        /// The type of distance
        /// </summary>
        [ObservableProperty]
        private DistanceEnum distanceType = DistanceEnum.Feet;
    }
}