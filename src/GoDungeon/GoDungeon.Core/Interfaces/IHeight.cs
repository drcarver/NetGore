using CommunityToolkit.Mvvm.ComponentModel;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Interfaces
{
    public interface IHeight
    {
        /// <summary>
        /// The height in feet
        /// </summary>
        int Feet { get; set; }

        /// <summary>
        /// The height in inches
        /// </summary>
        int Inches { get; set; }

        /// <summary>
        /// Add the new 
        /// </summary>
        /// <param name="dice"></param>
        public HeightViewModel Add(string dice);
    }
}