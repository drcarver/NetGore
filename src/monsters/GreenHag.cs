// GreenHag
//
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters;

public partial class GreenHag : CreatureViewModel
{
	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="services">The collection of services from the DI</param>
	/// <param name="logger">The logger factory from the DI</param>
	public GreenHag(
		IServiceProvider services,
		ILoggerFactory logger)
		: base(services, logger)
	{
		Name = nameof(GreenHag);
		RaceType = RaceTypeEnum.fey;
		ChallengeRating = 3;
	}
}
