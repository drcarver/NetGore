// Frost Giant
//
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters;

public partial class Frost Giant : CreatureViewModel
{
	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="services">The collection of services from the DI</param>
	/// <param name="logger">The logger factory from the DI</param>
	public Frost Giant(
		IServiceProvider services,
		ILoggerFactory logger)
		: base(services, logger)
	{
		Name = nameof(Frost Giant);
		RaceType = RaceTypeEnum.giant;
		ChallengeRating = 8;
	}
}
