using GoDungeon.Core.Interfaces;

namespace GoDungeon.Gaming.Interfaces
{
    public interface IExperiencePointAwardEntry : IGameTableEntry
    {
        /// <summary>
        /// Challenge Rating
        /// </summary>
        decimal ChallengeRating { get; set; }

        /// <summary>
        /// Total XP
        /// </summary>
        int TotalXP { get; set; }

        /// <summary>
        /// Individual XP for a party of 1-3 characters
        /// </summary>
        int Individual1to3XP { get; set; }

        /// <summary>
        /// Individual XP for a party of 4-5 characters
        /// </summary>
        int Individual4to5XP { get; set; }

        /// <summary>
        /// Individual XP for a party of 6+ characters
        /// </summary>
        int Individual6PlusXP { get; set; }
    }
}