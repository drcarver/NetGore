// Aboleth
//
using GoDungeon.Core.Abilities;
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;

using GoDungeon.Monsters.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters;

public partial class AbolethViewModel : CreatureViewModel, IAboleth
{
	/// <summary>
	/// Initialize the view model
	/// </summary>
	private void Initialize()
	{
		Name = "Aboleth";
		ProperName = "Aboleth";
		RaceType = RaceTypeEnum.Aberration;
		ChallengeRating = 0;

		// Abilities
		Strength = new Strength(21, this);
		Intelligence = new Intelligence(18, this);
		Wisdom = new Wisdom(15, this);
		Dexterity = new Dexterity(9, this);
		Constitution = new Constitution(15, this);
		Charisma = new Charisma(18, this);
	}
}
