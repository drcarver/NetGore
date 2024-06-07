using System;
using System.ComponentModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels
{
    /// <summary>
    /// The base object for all data models
    /// </summary>
    public partial class MovementViewModel : ObservableObject, IMovement
    {
        /// <summary>
        /// The movement type
        /// </summary>
        [ObservableProperty]
        private MovementEnum movementType;

        /// <summary>
        /// The speed on ft per round
        /// </summary>
        [ObservableProperty]
        private int speed;
    }
}
