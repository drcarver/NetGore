using CommunityToolkit.Mvvm.ComponentModel;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels
{
    public partial class HeightViewModel : ObservableObject, IHeight
    {
        /// <summary>
        /// The height in feet
        /// </summary>
        [ObservableProperty]
        private int feet = 0;

        /// <summary>
        /// The height in inches
        /// </summary>
        [ObservableProperty]
        private int inches = 0;

        /// <summary>
        /// Add the new 
        /// </summary>
        /// <param name="dice"></param>
        public HeightViewModel Add(string dice)
        {
            // convert height to inches and add the dice total
            var totalInches = Feet * 12 + Inches 
                + new Dice(dice).Total;

            // Now convert total inches back to a height
            Feet = totalInches / 12;
            var feet2 = Feet * 12;
            Inches = totalInches - feet2;

            // return the new height
            return this;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="feet">Height in feet</param>
        /// <param name="inches">Height with inches</param>
        public HeightViewModel(int feet, int inches)
        {
            Feet = feet;
            Inches = inches;
        }
    }
}