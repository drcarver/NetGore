// Acolyte
//
using GoDungeon.Core.Abilities;
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;

using GoDungeon.Monsters.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters;

public partial class AcolyteViewModel : CreatureViewModel, IAcolyte
{
	/// <summary>
	/// Initialize the view model
	/// </summary>
	private void Initialize()
	{
		Name = "Acolyte";
		ProperName = "Acolyte";
		RaceType = RaceTypeEnum.Humanoid;
		RaceSubType.Add(RaceSubTypeEnum.Any);
		ChallengeRating = 0;

		// Abilities
		Strength = new Strength(10, this);
		Intelligence = new Intelligence(10, this);
		Wisdom = new Wisdom(14, this);
		Dexterity = new Dexterity(10, this);
		Constitution = new Constitution(10, this);
		Charisma = new Charisma(11, this);
	}
}
