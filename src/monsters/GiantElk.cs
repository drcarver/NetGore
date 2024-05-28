// GiantElk
//
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters;

public partial class GiantElk : CreatureViewModel
{
	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="services">The collection of services from the DI</param>
	/// <param name="logger">The logger factory from the DI</param>
	public GiantElk(
		IServiceProvider services,
		ILoggerFactory logger)
		: base(services, logger)
	{
		Name = nameof(GiantElk);
		RaceType = RaceTypeEnum.beast;
		ChallengeRating = 2;
	}
}
