namespace GoDungeon.Core.Interfaces
{
    public interface IAbilityModifierTable : IGameTable
    {
        /// <summary>
        /// Get the ability modifier by the ability score
        /// </summary>
        /// <param name="number">The ability score</param>
        /// <returns>The ability bonus entry</returns>
        IAbilityBonusSpellEntry GetEntryByScore(int number);
    }
}