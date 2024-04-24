namespace D20.Core.Models
{
    public class Height
    {
        /// <summary>
        /// The height in feet
        /// </summary>
        public int Feet { get; private set; } = 0;

        /// <summary>
        /// The height in inches
        /// </summary>
        public int Inches { get; private set; } = 0;

        /// <summary>
        /// Add the new 
        /// </summary>
        /// <param name="dice"></param>
        public Height Add(string dice)
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
        public Height(int feet, int inches)
        {
            Feet = feet;
            Inches = inches;
        }
    }
}