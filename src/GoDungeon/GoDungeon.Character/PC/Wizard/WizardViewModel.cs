using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Character.PC.Wizard
{
    /// <summary>
    /// Wizards have a talent for song and story, and they come to 
    /// their careers by developing this talent as they pick up 
    /// on a smattering of other skills. 
    /// </summary>
    public partial class WizardViewModel : CharacterClassBaseViewModel
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
        public WizardViewModel(
            ILoggerFactory loggerFactory)
        {
            ClassEnum = Core.Enum.ClassEnum.Wizard;
            Name = nameof(Core.Enum.ClassEnum.Wizard);
            Description =
                "Wizards have a talent for song and story, and they come to " +
                "their careers by developing this talent as they pick up " +
                "on a smattering of other skills.";
        }
    }
}
