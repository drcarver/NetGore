// Flying Sword
//
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters;

public partial class Flying Sword : CreatureViewModel
{
	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="services">The collection of services from the DI</param>
	/// <param name="logger">The logger factory from the DI</param>
	public Flying Sword(
		IServiceProvider services,
		ILoggerFactory logger)
		: base(services, logger)
	{
		Name = nameof(Flying Sword);
		RaceType = RaceTypeEnum.construct;
		ChallengeRating = .25;
	}
}
