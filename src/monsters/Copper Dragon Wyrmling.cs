// Copper Dragon Wyrmling
//
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters;

public partial class Copper Dragon Wyrmling : CreatureViewModel
{
	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="services">The collection of services from the DI</param>
	/// <param name="logger">The logger factory from the DI</param>
	public Copper Dragon Wyrmling(
		IServiceProvider services,
		ILoggerFactory logger)
		: base(services, logger)
	{
		Name = nameof(Copper Dragon Wyrmling);
		RaceType = RaceTypeEnum.dragon;
		ChallengeRating = 1;
	}
}
