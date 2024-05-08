using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Character.PC.Druid
{
    /// <summary>
    /// Druids come by their primal power in various ways. One 
    /// druid might receive her power from an elemental creature, 
    /// and another might learn it from a beast or the fey. 
    /// </summary>
    public class DruidViewModel : CharacterClassBaseViewModel, IDruid
    {
        /// <summary>
        /// Level up the character with this class
        /// </summary>
        /// <param name="character"></param>
        public override void LevelUp(ICharacterClass character)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public DruidViewModel(
            ILoggerFactory loggerFactory)
        {
            Name = nameof(DruidViewModel);
            Description =
                "Druids come by their primal power in various " +
                "ways. One druid might receive her power from " +
                "an elemental creature, and another might learn " +
                "it from a beast or the fey.";
        }
    }
}
