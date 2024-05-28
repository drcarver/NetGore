// Bronze Dragon Wyrmling
//
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters;

public partial class Bronze Dragon Wyrmling : CreatureViewModel
{
	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="services">The collection of services from the DI</param>
	/// <param name="logger">The logger factory from the DI</param>
	public Bronze Dragon Wyrmling(
		IServiceProvider services,
		ILoggerFactory logger)
		: base(services, logger)
	{
		Name = nameof(Bronze Dragon Wyrmling);
		RaceType = RaceTypeEnum.dragon;
		ChallengeRating = 2;
	}
}
