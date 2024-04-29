using System.Diagnostics.CodeAnalysis;

using GoDungeon.Background.Interfaces;

using Microsoft.Extensions.Logging;
using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.Character.PC.Fighter
{
    public class Fighter : CharacterClassBaseViewModel, IFighter
    {
        private ILogger logger;

        /// <summary>
        /// Level up the character with this class
        /// </summary>
        /// <param name="character"></param>
        public override void LevelUp(ICharacter character)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Fighter(
            ILoggerFactory loggerFactory,
            IFighterLevelTable fighterLevelTable,
            IFighterBackgroundTable fighterBackgroundTable)
        {
            // The logger
            logger = loggerFactory.CreateLogger<Fighter>();

            // The fighter levels
            ClassLevelTable = (IClassLevelTable) fighterLevelTable;
            ClassLevelTable.InitializeTable();

            // The fighter background
            fighterBackgroundTable.InitializeTable();
            Background = (IBackgroundTableEntry?)fighterBackgroundTable.GetRandomRangeEntry();

            // Name and description
            Name = nameof(Fighter);
            Description =
                "Fighters excel at combat—defeating their enemies, " +
                "controlling the flow of battle, and surviving " +
                "such sorties themselves. While their specific " +
                "weapons and methods grant them a wide variety " +
                "of tactics, few can match fighters for sheer " +
                "battle prowess.";
        }
    }
}
