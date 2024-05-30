using System;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters.ViewModels.Humanoid
{
    public partial class HumanoidRaceViewModel : CreatureViewModel, IHumanoidRace
    {
        protected HumanoidRaceViewModel
        (
            IServiceProvider services,
            ILoggerFactory logger
        ) : base(services, logger)
        {
        }
    }
}
