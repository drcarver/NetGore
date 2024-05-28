// Giant Constrictor Snake
//
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters;

public partial class Giant Constrictor Snake : CreatureViewModel
{
	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="services">The collection of services from the DI</param>
	/// <param name="logger">The logger factory from the DI</param>
	public Giant Constrictor Snake(
		IServiceProvider services,
		ILoggerFactory logger)
		: base(services, logger)
	{
		Name = nameof(Giant Constrictor Snake);
		RaceType = RaceTypeEnum.beast;
		ChallengeRating = 2;
	}
}
