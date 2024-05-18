namespace GoDungeon.RandomDungeon.Interfaces
{
    public interface ISettlement
    {
        /// <summary>
        /// THe population of the city
        /// </summary>
        string? Population { get; set; }

        /// <summary>
        /// The type of government
        /// </summary>
        string? Government { get; set; }

        /// <summary>
        /// The type of defense the settlement has
        /// </summary>
        string? Defense { get; set; }

        /// <summary>
        /// The types of commerce of for the settlement
        /// </summary>
        string? Commerce { get; set; }

        /// <summary>
        /// The organizations in the city
        /// </summary>
        string? Organizations { get; set; }
    }
}