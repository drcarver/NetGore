// Half-RedDragonVeteran
//
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters;

public partial class Half-RedDragonVeteran : CreatureViewModel
{
	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="services">The collection of services from the DI</param>
	/// <param name="logger">The logger factory from the DI</param>
	public Half-RedDragonVeteran(
		IServiceProvider services,
		ILoggerFactory logger)
		: base(services, logger)
	{
		Name = nameof(Half-RedDragonVeteran);
		RaceType = RaceTypeEnum.humanoid (human);
		ChallengeRating = 5;
	}
}
