using GoDungeon.Core.Interfaces;

namespace GoDungeon.Character.Interfaces
{
    public interface IClassService
    {
        /// <summary>
        /// Set the class for the player
        /// </summary>
        void SetClass(ICharacter playerCharacter);
    }
}