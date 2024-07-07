//
// The Spell Information Table
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;

using GoDungeon.Spells.Enum;
using GoDungeon.Spells.Interfaces;
using GoDungeon.Spells.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Spells.Tables;

/// <summary>
/// The Spell Information Table
/// </summary>
public partial class SpellInfoTable : NamedTable, ISpellInfoTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public SpellInfoTable()
	{
		Name = nameof(SpellInfoTable);
		ProperName = "Spell Information Table";
		TableType = TableTypeEnum.SpellTable;
		Description = "The Spell Information Table";
	}

	/// <summary>
	/// Initialize the table.  This is a separate method so
	/// we can create a game table for it's meta properties
	/// with out creating the actual table values.  A bit of
	/// optimization to conserve memory on big tables
	/// </summary>
	public override void InitializeTable()
	{
		if (Table == null || Table.Count == 0)
		{
			Table = new ObservableCollection<IGameTableEntry>
			{
				#region Acid Arrow
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.AcidArrow),
					ProperName = "Acid Arrow",
					SpellType = SpellNameEnum.AcidArrow,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "powdered rhubarb leaf and an adder’s stomach"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Acid Splash
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.AcidSplash),
					ProperName = "Acid Splash",
					SpellType = SpellNameEnum.AcidSplash,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Aid
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Aid),
					ProperName = "Aid",
					SpellType = SpellNameEnum.Aid,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a tiny strip of white cloth"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 8,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Alarm
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Alarm),
					ProperName = "Alarm",
					SpellType = SpellNameEnum.Alarm,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a tiny bell and a piece of fine silver wire"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 8,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Alter Self
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.AlterSelf),
					ProperName = "Alter Self",
					SpellType = SpellNameEnum.AlterSelf,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Animal Friendship
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.AnimalFriendship),
					ProperName = "Animal Friendship",
					SpellType = SpellNameEnum.AnimalFriendship,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a morsel of food"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 24,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Animal Messenger
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.AnimalMessenger),
					ProperName = "Animal Messenger",
					SpellType = SpellNameEnum.AnimalMessenger,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a morsel of food"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 24,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Animal Shapes
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.AnimalShapes),
					ProperName = "Animal Shapes",
					SpellType = SpellNameEnum.AnimalShapes,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 24,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Animate Dead
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.AnimateDead),
					ProperName = "Animate Dead",
					SpellType = SpellNameEnum.AnimateDead,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a drop of blood, a piece of flesh, and a pinch of bone dust"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Animate Objects
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.AnimateObjects),
					ProperName = "Animate Objects",
					SpellType = SpellNameEnum.AnimateObjects,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Antilife Shell
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.AntilifeShell),
					ProperName = "Antilife Shell",
					SpellType = SpellNameEnum.AntilifeShell,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Radius,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Antimagic Field
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.AntimagicField),
					ProperName = "Antimagic Field",
					SpellType = SpellNameEnum.AntimagicField,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Sphere,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a pinch of powdered iron or iron filings"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Antipathy/Sympathy
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.AntipathySympathy),
					ProperName = "Antipathy/Sympathy",
					SpellType = SpellNameEnum.AntipathySympathy,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "either a lump of alum soaked in vinegar for the **antipathy** effect or a drop of honey for the **sympathy** effect"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Days,
					},
				},
				#endregion

				#region Arcane Eye
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ArcaneEye),
					ProperName = "Arcane Eye",
					SpellType = SpellNameEnum.ArcaneEye,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a bit of bat fur"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Arcane Hand
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ArcaneHand),
					ProperName = "Arcane Hand",
					SpellType = SpellNameEnum.ArcaneHand,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "an eggshell and a snakeskin glove"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Arcane Lock
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ArcaneLock),
					ProperName = "Arcane Lock",
					SpellType = SpellNameEnum.ArcaneLock,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "gold dust worth at least 25 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.UntilDispelled,
					},
				},
				#endregion

				#region Arcane Sword
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ArcaneSword),
					ProperName = "Arcane Sword",
					SpellType = SpellNameEnum.ArcaneSword,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a miniature platinum sword with a grip and pommel of copper and zinc, worth 250 gp"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Arcanist's Magic Aura
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ArcanistsMagicAura),
					ProperName = "Arcanist's Magic Aura",
					SpellType = SpellNameEnum.ArcanistsMagicAura,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a small square of silk"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 24,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Astral Projection
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.AstralProjection),
					ProperName = "Astral Projection",
					SpellType = SpellNameEnum.AstralProjection,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "for each creature you affect with this spell, you must provide one jacinth worth at least 1,000 gp and one ornately carved bar of silver worth at least 100 gp, all of which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Special,
					},
				},
				#endregion

				#region Augury
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Augury),
					ProperName = "Augury",
					SpellType = SpellNameEnum.Augury,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Radius,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "specially marked sticks, bones, or similar tokens worth at least 25 gp"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Awaken
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Awaken),
					ProperName = "Awaken",
					SpellType = SpellNameEnum.Awaken,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(8, DurationEnum.Hours),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "an agate worth at least 1,000 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Bane
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Bane),
					ProperName = "Bane",
					SpellType = SpellNameEnum.Bane,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a drop of blood"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Banishment
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Banishment),
					ProperName = "Banishment",
					SpellType = SpellNameEnum.Banishment,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "an item distasteful to the target"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Barkskin
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Barkskin),
					ProperName = "Barkskin",
					SpellType = SpellNameEnum.Barkskin,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a handful of oak bark"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Beacon of Hope
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.BeaconofHope),
					ProperName = "Beacon of Hope",
					SpellType = SpellNameEnum.BeaconofHope,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Bestow Curse
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.BestowCurse),
					ProperName = "Bestow Curse",
					SpellType = SpellNameEnum.BestowCurse,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Black Tentacles
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.BlackTentacles),
					ProperName = "Black Tentacles",
					SpellType = SpellNameEnum.BlackTentacles,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a piece of tentacle from a giant octopus or a giant squid"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Blade Barrier
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.BladeBarrier),
					ProperName = "Blade Barrier",
					SpellType = SpellNameEnum.BladeBarrier,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Bless
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Bless),
					ProperName = "Bless",
					SpellType = SpellNameEnum.Bless,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a sprinkling of holy water"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Blight
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Blight),
					ProperName = "Blight",
					SpellType = SpellNameEnum.Blight,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Blindness/Deafness
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.BlindnessDeafness),
					ProperName = "Blindness/Deafness",
					SpellType = SpellNameEnum.BlindnessDeafness,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Blink
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Blink),
					ProperName = "Blink",
					SpellType = SpellNameEnum.Blink,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Blur
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Blur),
					ProperName = "Blur",
					SpellType = SpellNameEnum.Blur,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Branding Smite
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.BrandingSmite),
					ProperName = "Branding Smite",
					SpellType = SpellNameEnum.BrandingSmite,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Burning Hands
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.BurningHands),
					ProperName = "Burning Hands",
					SpellType = SpellNameEnum.BurningHands,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 15,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Cone,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Call Lightning
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.CallLightning),
					ProperName = "Call Lightning",
					SpellType = SpellNameEnum.CallLightning,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Calm Emotions
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.CalmEmotions),
					ProperName = "Calm Emotions",
					SpellType = SpellNameEnum.CalmEmotions,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Chain Lightning
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ChainLightning),
					ProperName = "Chain Lightning",
					SpellType = SpellNameEnum.ChainLightning,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a bit of fur; a piece of amber, glass, or a crystal rod; and three silver pins"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Charm Person
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.CharmPerson),
					ProperName = "Charm Person",
					SpellType = SpellNameEnum.CharmPerson,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Chill Touch
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ChillTouch),
					ProperName = "Chill Touch",
					SpellType = SpellNameEnum.ChillTouch,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Round,
					},
				},
				#endregion

				#region Circle of Death
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.CircleofDeath),
					ProperName = "Circle of Death",
					SpellType = SpellNameEnum.CircleofDeath,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "the powder of a crushed black pearl worth at least 500 gp"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Clairvoyance
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Clairvoyance),
					ProperName = "Clairvoyance",
					SpellType = SpellNameEnum.Clairvoyance,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 1,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a focus worth at least 100 gp, either a jeweled horn for hearing or a glass eye for seeing"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Clone
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Clone),
					ProperName = "Clone",
					SpellType = SpellNameEnum.Clone,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a diamond worth at least 1,000 gp and at least 1 cubic inch of flesh of the creature that is to be cloned, which the spell consumes, and a vessel worth at least 2,000 gp that has a sealable lid and is large enough to hold a Medium creature, such as a huge urn, coffin, mud- filled cyst in the ground, or crystal container filled with salt water"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Cloudkill
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Cloudkill),
					ProperName = "Cloudkill",
					SpellType = SpellNameEnum.Cloudkill,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Color Spray
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ColorSpray),
					ProperName = "Color Spray",
					SpellType = SpellNameEnum.ColorSpray,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 15,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Cone,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a pinch of powder or sand that is colored red, yellow, and blue"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Round,
					},
				},
				#endregion

				#region Command
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Command),
					ProperName = "Command",
					SpellType = SpellNameEnum.Command,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Round,
					},
				},
				#endregion

				#region Commune
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Commune),
					ProperName = "Commune",
					SpellType = SpellNameEnum.Commune,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "incense and a vial of holy or unholy water"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Commune with Nature
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.CommunewithNature),
					ProperName = "Commune with Nature",
					SpellType = SpellNameEnum.CommunewithNature,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Comprehend Languages
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ComprehendLanguages),
					ProperName = "Comprehend Languages",
					SpellType = SpellNameEnum.ComprehendLanguages,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a pinch of soot and salt"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Compulsion
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Compulsion),
					ProperName = "Compulsion",
					SpellType = SpellNameEnum.Compulsion,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Cone of Cold
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ConeofCold),
					ProperName = "Cone of Cold",
					SpellType = SpellNameEnum.ConeofCold,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Cone,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a small crystal or glass cone"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Confusion
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Confusion),
					ProperName = "Confusion",
					SpellType = SpellNameEnum.Confusion,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "three nut shells"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Conjure Animals
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ConjureAnimals),
					ProperName = "Conjure Animals",
					SpellType = SpellNameEnum.ConjureAnimals,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Conjure Celestial
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ConjureCelestial),
					ProperName = "Conjure Celestial",
					SpellType = SpellNameEnum.ConjureCelestial,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Conjure Elemental
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ConjureElemental),
					ProperName = "Conjure Elemental",
					SpellType = SpellNameEnum.ConjureElemental,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "burning incense for air, soft clay for earth, sulfur and phosphorus for fire, or water and sand for water"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Conjure Fey
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ConjureFey),
					ProperName = "Conjure Fey",
					SpellType = SpellNameEnum.ConjureFey,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Conjure Minor Elementals
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ConjureMinorElementals),
					ProperName = "Conjure Minor Elementals",
					SpellType = SpellNameEnum.ConjureMinorElementals,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Conjure Woodland Beings
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ConjureWoodlandBeings),
					ProperName = "Conjure Woodland Beings",
					SpellType = SpellNameEnum.ConjureWoodlandBeings,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "one holly berry per creature summoned"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Contact Other Plane
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ContactOtherPlane),
					ProperName = "Contact Other Plane",
					SpellType = SpellNameEnum.ContactOtherPlane,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Contagion
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Contagion),
					ProperName = "Contagion",
					SpellType = SpellNameEnum.Contagion,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 7,
						SpellDurationUnits = SpellDurationUnitsEnum.Days,
					},
				},
				#endregion

				#region Contingency
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Contingency),
					ProperName = "Contingency",
					SpellType = SpellNameEnum.Contingency,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a statuette of yourself carved from ivory and decorated with gems worth at least 1,500 gp"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Days,
					},
				},
				#endregion

				#region Continual Flame
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ContinualFlame),
					ProperName = "Continual Flame",
					SpellType = SpellNameEnum.ContinualFlame,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "ruby dust worth 50 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.UntilDispelled,
					},
				},
				#endregion

				#region Control Water
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ControlWater),
					ProperName = "Control Water",
					SpellType = SpellNameEnum.ControlWater,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 300,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a drop of water and a pinch of dust"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Control Weather
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ControlWeather),
					ProperName = "Control Weather",
					SpellType = SpellNameEnum.ControlWeather,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 5,
						DistanceType = SpellDistanceEnum.Mile,
						SpellEffectType = SpellEffectTypeEnum.Radius,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "burning incense and bits of earth and wood mixed in water"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 8,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Counterspell
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Counterspell),
					ProperName = "Counterspell",
					SpellType = SpellNameEnum.Counterspell,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = false,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Create Food and Water
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.CreateFoodandWater),
					ProperName = "Create Food and Water",
					SpellType = SpellNameEnum.CreateFoodandWater,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Create or Destroy Water
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.CreateorDestroyWater),
					ProperName = "Create or Destroy Water",
					SpellType = SpellNameEnum.CreateorDestroyWater,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a drop of water if creating water or a few grains of sand if destroying it"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Create Undead
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.CreateUndead),
					ProperName = "Create Undead",
					SpellType = SpellNameEnum.CreateUndead,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "one clay pot filled with grave dirt, one clay pot filled with brackish water, and one 150 gp black onyx stone for each corpse"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Creation
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Creation),
					ProperName = "Creation",
					SpellType = SpellNameEnum.Creation,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a tiny piece of matter of the same type of the item you plan to create"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Special,
					},
				},
				#endregion

				#region Cure Wounds
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.CureWounds),
					ProperName = "Cure Wounds",
					SpellType = SpellNameEnum.CureWounds,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Dancing Lights
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.DancingLights),
					ProperName = "Dancing Lights",
					SpellType = SpellNameEnum.DancingLights,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a bit of phosphorus or wychwood, or a glowworm"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Darkness
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Darkness),
					ProperName = "Darkness",
					SpellType = SpellNameEnum.Darkness,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = true,
						MaterialComponents = "bat fur and a drop of pitch or piece of coal"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Darkvision
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Darkvision),
					ProperName = "Darkvision",
					SpellType = SpellNameEnum.Darkvision,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "either a pinch of dried carrot or an agate"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 8,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Daylight
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Daylight),
					ProperName = "Daylight",
					SpellType = SpellNameEnum.Daylight,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Death Ward
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.DeathWard),
					ProperName = "Death Ward",
					SpellType = SpellNameEnum.DeathWard,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 8,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Delayed Blast Fireball
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.DelayedBlastFireball),
					ProperName = "Delayed Blast Fireball",
					SpellType = SpellNameEnum.DelayedBlastFireball,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a tiny ball of bat guano and sulfur"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Demiplane
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Demiplane),
					ProperName = "Demiplane",
					SpellType = SpellNameEnum.Demiplane,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = false,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Detect Evil and Good
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.DetectEvilandGood),
					ProperName = "Detect Evil and Good",
					SpellType = SpellNameEnum.DetectEvilandGood,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Detect Magic
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.DetectMagic),
					ProperName = "Detect Magic",
					SpellType = SpellNameEnum.DetectMagic,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Detect Poison and Disease
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.DetectPoisonandDisease),
					ProperName = "Detect Poison and Disease",
					SpellType = SpellNameEnum.DetectPoisonandDisease,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a yew leaf"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Detect Thoughts
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.DetectThoughts),
					ProperName = "Detect Thoughts",
					SpellType = SpellNameEnum.DetectThoughts,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a copper piece"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Dimension Door
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.DimensionDoor),
					ProperName = "Dimension Door",
					SpellType = SpellNameEnum.DimensionDoor,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 500,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Disguise Self
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.DisguiseSelf),
					ProperName = "Disguise Self",
					SpellType = SpellNameEnum.DisguiseSelf,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Disintegrate
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Disintegrate),
					ProperName = "Disintegrate",
					SpellType = SpellNameEnum.Disintegrate,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a lodestone and a pinch of dust"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Dispel Evil and Good
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.DispelEvilandGood),
					ProperName = "Dispel Evil and Good",
					SpellType = SpellNameEnum.DispelEvilandGood,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "holy water or powdered silver and iron"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Dispel Magic
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.DispelMagic),
					ProperName = "Dispel Magic",
					SpellType = SpellNameEnum.DispelMagic,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Divination
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Divination),
					ProperName = "Divination",
					SpellType = SpellNameEnum.Divination,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "incense and a sacrificial offering appropriate to your religion, together worth at least 25 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Divine Favor
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.DivineFavor),
					ProperName = "Divine Favor",
					SpellType = SpellNameEnum.DivineFavor,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Divine Word
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.DivineWord),
					ProperName = "Divine Word",
					SpellType = SpellNameEnum.DivineWord,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Dominate Beast
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.DominateBeast),
					ProperName = "Dominate Beast",
					SpellType = SpellNameEnum.DominateBeast,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Dominate Monster
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.DominateMonster),
					ProperName = "Dominate Monster",
					SpellType = SpellNameEnum.DominateMonster,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Dominate Person
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.DominatePerson),
					ProperName = "Dominate Person",
					SpellType = SpellNameEnum.DominatePerson,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Dream
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Dream),
					ProperName = "Dream",
					SpellType = SpellNameEnum.Dream,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Special,
						SpellEffectType = SpellEffectTypeEnum.Special,
						RangeType = SpellDistanceTypeEnum.Special
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a handful of sand, a dab of ink, and a writing quill plucked from a sleeping bird"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 8,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Druidcraft
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Druidcraft),
					ProperName = "Druidcraft",
					SpellType = SpellNameEnum.Druidcraft,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Earthquake
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Earthquake),
					ProperName = "Earthquake",
					SpellType = SpellNameEnum.Earthquake,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 500,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a pinch of dirt, a piece of rock, and a lump of clay"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Eldritch Blast
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.EldritchBlast),
					ProperName = "Eldritch Blast",
					SpellType = SpellNameEnum.EldritchBlast,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Enhance Ability
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.EnhanceAbility),
					ProperName = "Enhance Ability",
					SpellType = SpellNameEnum.EnhanceAbility,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "fur or a feather from a beast"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Enlarge/Reduce
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.EnlargeReduce),
					ProperName = "Enlarge/Reduce",
					SpellType = SpellNameEnum.EnlargeReduce,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a pinch of powdered iron"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Entangle
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Entangle),
					ProperName = "Entangle",
					SpellType = SpellNameEnum.Entangle,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Enthrall
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Enthrall),
					ProperName = "Enthrall",
					SpellType = SpellNameEnum.Enthrall,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Etherealness
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Etherealness),
					ProperName = "Etherealness",
					SpellType = SpellNameEnum.Etherealness,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = true,
						SpellDuration = 8,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Expeditious Retreat
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ExpeditiousRetreat),
					ProperName = "Expeditious Retreat",
					SpellType = SpellNameEnum.ExpeditiousRetreat,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Eyebite
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Eyebite),
					ProperName = "Eyebite",
					SpellType = SpellNameEnum.Eyebite,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Fabricate
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Fabricate),
					ProperName = "Fabricate",
					SpellType = SpellNameEnum.Fabricate,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Faerie Fire
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FaerieFire),
					ProperName = "Faerie Fire",
					SpellType = SpellNameEnum.FaerieFire,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Faithful Hound
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FaithfulHound),
					ProperName = "Faithful Hound",
					SpellType = SpellNameEnum.FaithfulHound,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a tiny silver whistle, a piece of bone, and a thread"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 8,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region False Life
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FalseLife),
					ProperName = "False Life",
					SpellType = SpellNameEnum.FalseLife,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a small amount of alcohol or distilled spirits"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Fear
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Fear),
					ProperName = "Fear",
					SpellType = SpellNameEnum.Fear,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Cone,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a white feather or the heart of a hen"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Feather Fall
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FeatherFall),
					ProperName = "Feather Fall",
					SpellType = SpellNameEnum.FeatherFall,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = true,
						MaterialComponents = "a small feather or piece of down"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Feeblemind
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Feeblemind),
					ProperName = "Feeblemind",
					SpellType = SpellNameEnum.Feeblemind,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a handful of clay, crystal, glass, or mineral spheres"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Find Familiar
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FindFamiliar),
					ProperName = "Find Familiar",
					SpellType = SpellNameEnum.FindFamiliar,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "10 gp worth of charcoal, incense, and herbs that must be consumed by fire in a brass brazier"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Find Steed
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FindSteed),
					ProperName = "Find Steed",
					SpellType = SpellNameEnum.FindSteed,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Find the Path
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FindthePath),
					ProperName = "Find the Path",
					SpellType = SpellNameEnum.FindthePath,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a set of divinatory tools--such as bones, ivory sticks, cards, teeth, or carved runes--worth 100 gp and an object from the location you wish to find"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Day,
					},
				},
				#endregion

				#region Find Traps
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FindTraps),
					ProperName = "Find Traps",
					SpellType = SpellNameEnum.FindTraps,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Finger of Death
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FingerofDeath),
					ProperName = "Finger of Death",
					SpellType = SpellNameEnum.FingerofDeath,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Fireball
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Fireball),
					ProperName = "Fireball",
					SpellType = SpellNameEnum.Fireball,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a tiny ball of bat guano and sulfur"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Fire Bolt
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FireBolt),
					ProperName = "Fire Bolt",
					SpellType = SpellNameEnum.FireBolt,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Fire Shield
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FireShield),
					ProperName = "Fire Shield",
					SpellType = SpellNameEnum.FireShield,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a bit of phosphorus or a firefly"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Fire Storm
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FireStorm),
					ProperName = "Fire Storm",
					SpellType = SpellNameEnum.FireStorm,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Flame Blade
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FlameBlade),
					ProperName = "Flame Blade",
					SpellType = SpellNameEnum.FlameBlade,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "leaf of sumac"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Flame Strike
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FlameStrike),
					ProperName = "Flame Strike",
					SpellType = SpellNameEnum.FlameStrike,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "pinch of sulfur"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Flaming Sphere
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FlamingSphere),
					ProperName = "Flaming Sphere",
					SpellType = SpellNameEnum.FlamingSphere,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a bit of tallow, a pinch of brimstone, and a dusting of powdered iron"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Flesh to Stone
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FleshtoStone),
					ProperName = "Flesh to Stone",
					SpellType = SpellNameEnum.FleshtoStone,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a pinch of lime, water, and earth"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Floating Disk
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FloatingDisk),
					ProperName = "Floating Disk",
					SpellType = SpellNameEnum.FloatingDisk,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a drop of mercury"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Fly
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Fly),
					ProperName = "Fly",
					SpellType = SpellNameEnum.Fly,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a wing feather from any bird"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Fog Cloud
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FogCloud),
					ProperName = "Fog Cloud",
					SpellType = SpellNameEnum.FogCloud,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Forbiddance
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Forbiddance),
					ProperName = "Forbiddance",
					SpellType = SpellNameEnum.Forbiddance,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a sprinkling of holy water, rare incense, and powdered ruby worth at least 1,000 gp"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Day,
					},
				},
				#endregion

				#region Forcecage
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Forcecage),
					ProperName = "Forcecage",
					SpellType = SpellNameEnum.Forcecage,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 100,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "ruby dust worth 1,500 gp"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Foresight
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Foresight),
					ProperName = "Foresight",
					SpellType = SpellNameEnum.Foresight,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a hummingbird feather"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 8,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Freedom of Movement
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FreedomofMovement),
					ProperName = "Freedom of Movement",
					SpellType = SpellNameEnum.FreedomofMovement,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a leather strap, bound around the arm or a similar appendage"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Freezing Sphere
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.FreezingSphere),
					ProperName = "Freezing Sphere",
					SpellType = SpellNameEnum.FreezingSphere,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 300,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a small crystal sphere"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Gaseous Form
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.GaseousForm),
					ProperName = "Gaseous Form",
					SpellType = SpellNameEnum.GaseousForm,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a bit of gauze and a wisp of smoke"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Gate
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Gate),
					ProperName = "Gate",
					SpellType = SpellNameEnum.Gate,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a diamond worth at least 5,000 gp"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Geas
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Geas),
					ProperName = "Geas",
					SpellType = SpellNameEnum.Geas,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 30,
						SpellDurationUnits = SpellDurationUnitsEnum.Days,
					},
				},
				#endregion

				#region Gentle Repose
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.GentleRepose),
					ProperName = "Gentle Repose",
					SpellType = SpellNameEnum.GentleRepose,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a pinch of salt and one copper piece placed on each of the corpse's eyes, which must remain there for the duration"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Days,
					},
				},
				#endregion

				#region Giant Insect
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.GiantInsect),
					ProperName = "Giant Insect",
					SpellType = SpellNameEnum.GiantInsect,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Glibness
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Glibness),
					ProperName = "Glibness",
					SpellType = SpellNameEnum.Glibness,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Globe of Invulnerability
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.GlobeofInvulnerability),
					ProperName = "Globe of Invulnerability",
					SpellType = SpellNameEnum.GlobeofInvulnerability,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Radius,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a glass or crystal bead that shatters when the spell ends"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Glyph of Warding
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.GlyphofWarding),
					ProperName = "Glyph of Warding",
					SpellType = SpellNameEnum.GlyphofWarding,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "incense and powdered diamond worth at least 200 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.UntilDispelledorTriggered,
					},
				},
				#endregion

				#region Goodberry
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Goodberry),
					ProperName = "Goodberry",
					SpellType = SpellNameEnum.Goodberry,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a sprig of mistletoe"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Grease
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Grease),
					ProperName = "Grease",
					SpellType = SpellNameEnum.Grease,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a bit of pork rind or butter"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Greater Invisibility
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.GreaterInvisibility),
					ProperName = "Greater Invisibility",
					SpellType = SpellNameEnum.GreaterInvisibility,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Greater Restoration
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.GreaterRestoration),
					ProperName = "Greater Restoration",
					SpellType = SpellNameEnum.GreaterRestoration,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "diamond dust worth at least 100 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Guardian of Faith
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.GuardianofFaith),
					ProperName = "Guardian of Faith",
					SpellType = SpellNameEnum.GuardianofFaith,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 8,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Guards and Wards
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.GuardsandWards),
					ProperName = "Guards and Wards",
					SpellType = SpellNameEnum.GuardsandWards,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "burning incense, a small measure of brimstone and oil, a knotted string, a small amount of monster blood, and a small silver rod worth at least 10 gp"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 24,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Guidance
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Guidance),
					ProperName = "Guidance",
					SpellType = SpellNameEnum.Guidance,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Guiding Bolt
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.GuidingBolt),
					ProperName = "Guiding Bolt",
					SpellType = SpellNameEnum.GuidingBolt,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Round,
					},
				},
				#endregion

				#region Gust of Wind
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.GustofWind),
					ProperName = "Gust of Wind",
					SpellType = SpellNameEnum.GustofWind,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Line,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a legume seed"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Hallow
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Hallow),
					ProperName = "Hallow",
					SpellType = SpellNameEnum.Hallow,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(24, DurationEnum.Hours),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "herbs, oils, and incense worth at least 1,000 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.UntilDispelled,
					},
				},
				#endregion

				#region Hallucinatory Terrain
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.HallucinatoryTerrain),
					ProperName = "Hallucinatory Terrain",
					SpellType = SpellNameEnum.HallucinatoryTerrain,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 300,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a stone, a twig, and a bit of green plant"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 24,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Harm
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Harm),
					ProperName = "Harm",
					SpellType = SpellNameEnum.Harm,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Haste
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Haste),
					ProperName = "Haste",
					SpellType = SpellNameEnum.Haste,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a shaving of licorice root"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Heal
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Heal),
					ProperName = "Heal",
					SpellType = SpellNameEnum.Heal,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Healing Word
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.HealingWord),
					ProperName = "Healing Word",
					SpellType = SpellNameEnum.HealingWord,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Heat Metal
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.HeatMetal),
					ProperName = "Heat Metal",
					SpellType = SpellNameEnum.HeatMetal,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a piece of iron and a flame"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Hellish Rebuke
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.HellishRebuke),
					ProperName = "Hellish Rebuke",
					SpellType = SpellNameEnum.HellishRebuke,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Heroes' Feast
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.HeroesFeast),
					ProperName = "Heroes' Feast",
					SpellType = SpellNameEnum.HeroesFeast,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a gem-encrusted bowl worth at least 1,000 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Heroism
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Heroism),
					ProperName = "Heroism",
					SpellType = SpellNameEnum.Heroism,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Hideous Laughter
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.HideousLaughter),
					ProperName = "Hideous Laughter",
					SpellType = SpellNameEnum.HideousLaughter,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "tiny tarts and a feather that is waved in the air"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Hold Monster
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.HoldMonster),
					ProperName = "Hold Monster",
					SpellType = SpellNameEnum.HoldMonster,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a small, straight piece of iron"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Hold Person
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.HoldPerson),
					ProperName = "Hold Person",
					SpellType = SpellNameEnum.HoldPerson,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a small, straight piece of iron"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Holy Aura
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.HolyAura),
					ProperName = "Holy Aura",
					SpellType = SpellNameEnum.HolyAura,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a tiny reliquary worth at least 1,000 gp containing a sacred relic, such as a scrap of cloth from a saint's robe or a piece of parchment from a religious text"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Hunter's Mark
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.HuntersMark),
					ProperName = "Hunter's Mark",
					SpellType = SpellNameEnum.HuntersMark,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Hypnotic Pattern
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.HypnoticPattern),
					ProperName = "Hypnotic Pattern",
					SpellType = SpellNameEnum.HypnoticPattern,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = false,
						Somatic = true,
						Material = true,
						MaterialComponents = "a glowing stick of incense or a crystal vial filled with phosphorescent material"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Ice Storm
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.IceStorm),
					ProperName = "Ice Storm",
					SpellType = SpellNameEnum.IceStorm,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 300,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a pinch of dust and a few drops of water"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Identify
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Identify),
					ProperName = "Identify",
					SpellType = SpellNameEnum.Identify,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a pearl worth at least 100 gp and an owl feather"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Illusory Script
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.IllusoryScript),
					ProperName = "Illusory Script",
					SpellType = SpellNameEnum.IllusoryScript,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = false,
						Somatic = true,
						Material = true,
						MaterialComponents = "a lead-based ink worth at least 10 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Days,
					},
				},
				#endregion

				#region Imprisonment
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Imprisonment),
					ProperName = "Imprisonment",
					SpellType = SpellNameEnum.Imprisonment,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a vellum depiction or a carved statuette in the likeness of the target, and a special component that varies according to the version of the spell you choose, worth at least 500 gp per Hit Die of the target"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.UntilDispelled,
					},
				},
				#endregion

				#region Incendiary Cloud
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.IncendiaryCloud),
					ProperName = "Incendiary Cloud",
					SpellType = SpellNameEnum.IncendiaryCloud,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Inflict Wounds
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.InflictWounds),
					ProperName = "Inflict Wounds",
					SpellType = SpellNameEnum.InflictWounds,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Insect Plague
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.InsectPlague),
					ProperName = "Insect Plague",
					SpellType = SpellNameEnum.InsectPlague,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 300,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a few grains of sugar, some kernels of grain, and a smear of fat"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Instant Summons
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.InstantSummons),
					ProperName = "Instant Summons",
					SpellType = SpellNameEnum.InstantSummons,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a sapphire worth 1,000 gp"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.UntilDispelled,
					},
				},
				#endregion

				#region Invisibility
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Invisibility),
					ProperName = "Invisibility",
					SpellType = SpellNameEnum.Invisibility,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "an eyelash encased in gum arabic"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Irresistible Dance
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.IrresistibleDance),
					ProperName = "Irresistible Dance",
					SpellType = SpellNameEnum.IrresistibleDance,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Jump
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Jump),
					ProperName = "Jump",
					SpellType = SpellNameEnum.Jump,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a grasshopper's hind leg"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Knock
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Knock),
					ProperName = "Knock",
					SpellType = SpellNameEnum.Knock,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Legend Lore
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.LegendLore),
					ProperName = "Legend Lore",
					SpellType = SpellNameEnum.LegendLore,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "incense worth at least 250 gp, which the spell consumes, and four ivory strips worth at least 50 gp each"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Lesser Restoration
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.LesserRestoration),
					ProperName = "Lesser Restoration",
					SpellType = SpellNameEnum.LesserRestoration,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Levitate
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Levitate),
					ProperName = "Levitate",
					SpellType = SpellNameEnum.Levitate,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "either a small leather loop or a piece of golden wire bent into a cup shape with a long shank on one end"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Light
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Light),
					ProperName = "Light",
					SpellType = SpellNameEnum.Light,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = true,
						MaterialComponents = "a firefly or phosphorescent moss"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Lightning Bolt
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.LightningBolt),
					ProperName = "Lightning Bolt",
					SpellType = SpellNameEnum.LightningBolt,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 100,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Line,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a bit of fur and a rod of amber, crystal, or glass"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Locate Animals or Plants
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.LocateAnimalsorPlants),
					ProperName = "Locate Animals or Plants",
					SpellType = SpellNameEnum.LocateAnimalsorPlants,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a bit of fur from a bloodhound"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Locate Creature
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.LocateCreature),
					ProperName = "Locate Creature",
					SpellType = SpellNameEnum.LocateCreature,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a bit of fur from a bloodhound"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Locate Object
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.LocateObject),
					ProperName = "Locate Object",
					SpellType = SpellNameEnum.LocateObject,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a forked twig"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Longstrider
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Longstrider),
					ProperName = "Longstrider",
					SpellType = SpellNameEnum.Longstrider,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a pinch of dirt"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Mage Armor
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MageArmor),
					ProperName = "Mage Armor",
					SpellType = SpellNameEnum.MageArmor,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a piece of cured leather"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 8,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Mage Hand
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MageHand),
					ProperName = "Mage Hand",
					SpellType = SpellNameEnum.MageHand,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Magic Circle
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MagicCircle),
					ProperName = "Magic Circle",
					SpellType = SpellNameEnum.MagicCircle,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "holy water or powdered silver and iron worth at least 100 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Magic Jar
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MagicJar),
					ProperName = "Magic Jar",
					SpellType = SpellNameEnum.MagicJar,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a gem, crystal, reliquary, or some other ornamental container worth at least 500 gp"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.UntilDispelled,
					},
				},
				#endregion

				#region Magic Missile
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MagicMissile),
					ProperName = "Magic Missile",
					SpellType = SpellNameEnum.MagicMissile,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Magic Mouth
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MagicMouth),
					ProperName = "Magic Mouth",
					SpellType = SpellNameEnum.MagicMouth,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a small bit of honeycomb and jade dust worth at least 10 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.UntilDispelled,
					},
				},
				#endregion

				#region Magic Weapon
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MagicWeapon),
					ProperName = "Magic Weapon",
					SpellType = SpellNameEnum.MagicWeapon,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Magnificent Mansion
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MagnificentMansion),
					ProperName = "Magnificent Mansion",
					SpellType = SpellNameEnum.MagnificentMansion,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 300,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a miniature portal carved from ivory, a small piece of polished marble, and a tiny silver spoon, each item worth at least 5 gp"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 24,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Major Image
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MajorImage),
					ProperName = "Major Image",
					SpellType = SpellNameEnum.MajorImage,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a bit of fleece"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Mass Cure Wounds
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MassCureWounds),
					ProperName = "Mass Cure Wounds",
					SpellType = SpellNameEnum.MassCureWounds,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Mass Heal
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MassHeal),
					ProperName = "Mass Heal",
					SpellType = SpellNameEnum.MassHeal,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Mass Healing Word
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MassHealingWord),
					ProperName = "Mass Healing Word",
					SpellType = SpellNameEnum.MassHealingWord,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Mass Suggestion
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MassSuggestion),
					ProperName = "Mass Suggestion",
					SpellType = SpellNameEnum.MassSuggestion,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = true,
						MaterialComponents = "a snake's tongue and either a bit of honeycomb or a drop of sweet oil"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 24,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Maze
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Maze),
					ProperName = "Maze",
					SpellType = SpellNameEnum.Maze,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Meld into Stone
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MeldintoStone),
					ProperName = "Meld into Stone",
					SpellType = SpellNameEnum.MeldintoStone,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 8,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Mending
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Mending),
					ProperName = "Mending",
					SpellType = SpellNameEnum.Mending,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "two lodestones"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Message
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Message),
					ProperName = "Message",
					SpellType = SpellNameEnum.Message,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a short piece of copper wire"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Round,
					},
				},
				#endregion

				#region Meteor Swarm
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MeteorSwarm),
					ProperName = "Meteor Swarm",
					SpellType = SpellNameEnum.MeteorSwarm,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 1,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Mind Blank
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MindBlank),
					ProperName = "Mind Blank",
					SpellType = SpellNameEnum.MindBlank,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 24,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Minor Illusion
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MinorIllusion),
					ProperName = "Minor Illusion",
					SpellType = SpellNameEnum.MinorIllusion,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = false,
						Somatic = true,
						Material = true,
						MaterialComponents = "a bit of fleece"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Mirage Arcane
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MirageArcane),
					ProperName = "Mirage Arcane",
					SpellType = SpellNameEnum.MirageArcane,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Sight,
						SpellEffectType = SpellEffectTypeEnum.Sight,
						RangeType = SpellDistanceTypeEnum.Sight
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Days,
					},
				},
				#endregion

				#region Mirror Image
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MirrorImage),
					ProperName = "Mirror Image",
					SpellType = SpellNameEnum.MirrorImage,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Mislead
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Mislead),
					ProperName = "Mislead",
					SpellType = SpellNameEnum.Mislead,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = false,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Misty Step
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MistyStep),
					ProperName = "Misty Step",
					SpellType = SpellNameEnum.MistyStep,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Modify Memory
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ModifyMemory),
					ProperName = "Modify Memory",
					SpellType = SpellNameEnum.ModifyMemory,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Moonbeam
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Moonbeam),
					ProperName = "Moonbeam",
					SpellType = SpellNameEnum.Moonbeam,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "several seeds of any moonseed plant and a piece of opalescent feldspar"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Move Earth
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.MoveEarth),
					ProperName = "Move Earth",
					SpellType = SpellNameEnum.MoveEarth,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "an iron blade and a small bag containing a mixture of soils--clay, loam, and sand"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 2,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Nondetection
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Nondetection),
					ProperName = "Nondetection",
					SpellType = SpellNameEnum.Nondetection,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a pinch of diamond dust worth 25 gp sprinkled over the target, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 8,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Passwall
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Passwall),
					ProperName = "Passwall",
					SpellType = SpellNameEnum.Passwall,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a pinch of sesame seeds"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Pass without Trace
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.PasswithoutTrace),
					ProperName = "Pass without Trace",
					SpellType = SpellNameEnum.PasswithoutTrace,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "ashes from a burned leaf of mistletoe and a sprig of spruce"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Phantasmal Killer
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.PhantasmalKiller),
					ProperName = "Phantasmal Killer",
					SpellType = SpellNameEnum.PhantasmalKiller,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Phantom Steed
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.PhantomSteed),
					ProperName = "Phantom Steed",
					SpellType = SpellNameEnum.PhantomSteed,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Planar Ally
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.PlanarAlly),
					ProperName = "Planar Ally",
					SpellType = SpellNameEnum.PlanarAlly,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Planar Binding
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.PlanarBinding),
					ProperName = "Planar Binding",
					SpellType = SpellNameEnum.PlanarBinding,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a jewel worth at least 1,000 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 24,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Plane Shift
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.PlaneShift),
					ProperName = "Plane Shift",
					SpellType = SpellNameEnum.PlaneShift,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a forked, metal rod worth at least 250 gp, attuned to a particular plane of existence"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Plant Growth
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.PlantGrowth),
					ProperName = "Plant Growth",
					SpellType = SpellNameEnum.PlantGrowth,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Poison Spray
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.PoisonSpray),
					ProperName = "Poison Spray",
					SpellType = SpellNameEnum.PoisonSpray,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Polymorph
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Polymorph),
					ProperName = "Polymorph",
					SpellType = SpellNameEnum.Polymorph,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a caterpillar cocoon"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Power Word Kill
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.PowerWordKill),
					ProperName = "Power Word Kill",
					SpellType = SpellNameEnum.PowerWordKill,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Power Word Stun
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.PowerWordStun),
					ProperName = "Power Word Stun",
					SpellType = SpellNameEnum.PowerWordStun,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Prayer of Healing
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.PrayerofHealing),
					ProperName = "Prayer of Healing",
					SpellType = SpellNameEnum.PrayerofHealing,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Prestidigitation
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Prestidigitation),
					ProperName = "Prestidigitation",
					SpellType = SpellNameEnum.Prestidigitation,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Prismatic Spray
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.PrismaticSpray),
					ProperName = "Prismatic Spray",
					SpellType = SpellNameEnum.PrismaticSpray,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Cone,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Prismatic Wall
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.PrismaticWall),
					ProperName = "Prismatic Wall",
					SpellType = SpellNameEnum.PrismaticWall,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Private Sanctum
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.PrivateSanctum),
					ProperName = "Private Sanctum",
					SpellType = SpellNameEnum.PrivateSanctum,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a thin sheet of lead, a piece of opaque glass, a wad of cotton or cloth, and powdered chrysolite"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 24,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Produce Flame
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ProduceFlame),
					ProperName = "Produce Flame",
					SpellType = SpellNameEnum.ProduceFlame,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Programmed Illusion
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ProgrammedIllusion),
					ProperName = "Programmed Illusion",
					SpellType = SpellNameEnum.ProgrammedIllusion,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a bit of fleece and jade dust worth at least 25 gp"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.UntilDispelled,
					},
				},
				#endregion

				#region Project Image
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ProjectImage),
					ProperName = "Project Image",
					SpellType = SpellNameEnum.ProjectImage,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 500,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a small replica of you made from materials worth at least 5 gp"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Day,
					},
				},
				#endregion

				#region Protection from Energy
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ProtectionfromEnergy),
					ProperName = "Protection from Energy",
					SpellType = SpellNameEnum.ProtectionfromEnergy,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Protection from Evil and Good
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ProtectionfromEvilandGood),
					ProperName = "Protection from Evil and Good",
					SpellType = SpellNameEnum.ProtectionfromEvilandGood,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "holy water or powdered silver and iron, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Protection from Poison
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ProtectionfromPoison),
					ProperName = "Protection from Poison",
					SpellType = SpellNameEnum.ProtectionfromPoison,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Purify Food and Drink
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.PurifyFoodandDrink),
					ProperName = "Purify Food and Drink",
					SpellType = SpellNameEnum.PurifyFoodandDrink,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Raise Dead
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.RaiseDead),
					ProperName = "Raise Dead",
					SpellType = SpellNameEnum.RaiseDead,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a diamond worth at least 500 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Ray of Enfeeblement
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.RayofEnfeeblement),
					ProperName = "Ray of Enfeeblement",
					SpellType = SpellNameEnum.RayofEnfeeblement,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Ray of Frost
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.RayofFrost),
					ProperName = "Ray of Frost",
					SpellType = SpellNameEnum.RayofFrost,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Regenerate
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Regenerate),
					ProperName = "Regenerate",
					SpellType = SpellNameEnum.Regenerate,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a prayer wheel and holy water"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Reincarnate
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Reincarnate),
					ProperName = "Reincarnate",
					SpellType = SpellNameEnum.Reincarnate,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "rare oils and unguents worth at least 1,000 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Remove Curse
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.RemoveCurse),
					ProperName = "Remove Curse",
					SpellType = SpellNameEnum.RemoveCurse,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Resilient Sphere
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ResilientSphere),
					ProperName = "Resilient Sphere",
					SpellType = SpellNameEnum.ResilientSphere,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a hemispherical piece of clear crystal and a matching hemispherical piece of gum arabic"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Resistance
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Resistance),
					ProperName = "Resistance",
					SpellType = SpellNameEnum.Resistance,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a miniature cloak"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Resurrection
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Resurrection),
					ProperName = "Resurrection",
					SpellType = SpellNameEnum.Resurrection,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a diamond worth at least 1,000 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Reverse Gravity
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ReverseGravity),
					ProperName = "Reverse Gravity",
					SpellType = SpellNameEnum.ReverseGravity,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 100,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a lodestone and iron filings"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Revivify
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Revivify),
					ProperName = "Revivify",
					SpellType = SpellNameEnum.Revivify,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "diamonds worth 300 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Rope Trick
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.RopeTrick),
					ProperName = "Rope Trick",
					SpellType = SpellNameEnum.RopeTrick,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "powdered corn extract and a twisted loop of parchment"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Sacred Flame
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.SacredFlame),
					ProperName = "Sacred Flame",
					SpellType = SpellNameEnum.SacredFlame,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Sanctuary
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Sanctuary),
					ProperName = "Sanctuary",
					SpellType = SpellNameEnum.Sanctuary,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a small silver mirror"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Scorching Ray
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ScorchingRay),
					ProperName = "Scorching Ray",
					SpellType = SpellNameEnum.ScorchingRay,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Scrying
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Scrying),
					ProperName = "Scrying",
					SpellType = SpellNameEnum.Scrying,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a focus worth at least 1,000 gp, such as a crystal ball, a silver mirror, or a font filled with holy water"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Secret Chest
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.SecretChest),
					ProperName = "Secret Chest",
					SpellType = SpellNameEnum.SecretChest,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "an exquisite chest, 3 feet by 2 feet by 2 feet, constructed from rare materials worth at least 5,000 gp, and a Tiny replica made from the same materials worth at least 50 gp"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Seeming
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Seeming),
					ProperName = "Seeming",
					SpellType = SpellNameEnum.Seeming,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 8,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region See Invisibility
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.SeeInvisibility),
					ProperName = "See Invisibility",
					SpellType = SpellNameEnum.SeeInvisibility,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a pinch of talc and a small sprinkling of powdered silver"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Sending
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Sending),
					ProperName = "Sending",
					SpellType = SpellNameEnum.Sending,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Unlimited,
						SpellEffectType = SpellEffectTypeEnum.Unlimited,
						RangeType = SpellDistanceTypeEnum.Unlimited
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a short piece of fine copper wire"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Round,
					},
				},
				#endregion

				#region Sequester
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Sequester),
					ProperName = "Sequester",
					SpellType = SpellNameEnum.Sequester,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a powder composed of diamond, emerald, ruby, and sapphire dust worth at least 5,000 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.UntilDispelled,
					},
				},
				#endregion

				#region Shapechange
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Shapechange),
					ProperName = "Shapechange",
					SpellType = SpellNameEnum.Shapechange,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a jade circlet worth at least 1,500 gp, which you must place on your head before you cast the spell"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Shatter
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Shatter),
					ProperName = "Shatter",
					SpellType = SpellNameEnum.Shatter,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a chip of mica"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Shield
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Shield),
					ProperName = "Shield",
					SpellType = SpellNameEnum.Shield,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Round,
					},
				},
				#endregion

				#region Shield of Faith
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ShieldofFaith),
					ProperName = "Shield of Faith",
					SpellType = SpellNameEnum.ShieldofFaith,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a small parchment with a bit of holy text written on it"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Shillelagh
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Shillelagh),
					ProperName = "Shillelagh",
					SpellType = SpellNameEnum.Shillelagh,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "mistletoe, a shamrock leaf, and a club or quarterstaff"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Shocking Grasp
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ShockingGrasp),
					ProperName = "Shocking Grasp",
					SpellType = SpellNameEnum.ShockingGrasp,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Silence
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Silence),
					ProperName = "Silence",
					SpellType = SpellNameEnum.Silence,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Silent Image
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.SilentImage),
					ProperName = "Silent Image",
					SpellType = SpellNameEnum.SilentImage,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a bit of fleece"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Simulacrum
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Simulacrum),
					ProperName = "Simulacrum",
					SpellType = SpellNameEnum.Simulacrum,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(12, DurationEnum.Hours),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "snow or ice in quantities sufficient to made a life-size copy of the duplicated creature; some hair, fingernail clippings, or other piece of that creature's body placed inside the snow or ice; and powdered ruby worth 1,500 gp, sprinkled over the duplicate and consumed by the spell"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.UntilDispelled,
					},
				},
				#endregion

				#region Sleep
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Sleep),
					ProperName = "Sleep",
					SpellType = SpellNameEnum.Sleep,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a pinch of fine sand, rose petals, or a cricket"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Sleet Storm
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.SleetStorm),
					ProperName = "Sleet Storm",
					SpellType = SpellNameEnum.SleetStorm,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a pinch of dust and a few drops of water"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Slow
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Slow),
					ProperName = "Slow",
					SpellType = SpellNameEnum.Slow,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a drop of molasses"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Spare the Dying
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.SparetheDying),
					ProperName = "Spare the Dying",
					SpellType = SpellNameEnum.SparetheDying,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Speak with Animals
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.SpeakwithAnimals),
					ProperName = "Speak with Animals",
					SpellType = SpellNameEnum.SpeakwithAnimals,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Speak with Dead
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.SpeakwithDead),
					ProperName = "Speak with Dead",
					SpellType = SpellNameEnum.SpeakwithDead,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "burning incense"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Speak with Plants
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.SpeakwithPlants),
					ProperName = "Speak with Plants",
					SpellType = SpellNameEnum.SpeakwithPlants,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Radius,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Spider Climb
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.SpiderClimb),
					ProperName = "Spider Climb",
					SpellType = SpellNameEnum.SpiderClimb,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a drop of bitumen and a spider"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Spike Growth
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.SpikeGrowth),
					ProperName = "Spike Growth",
					SpellType = SpellNameEnum.SpikeGrowth,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "seven sharp thorns or seven small twigs, each sharpened to a point"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Spiritual Weapon
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.SpiritualWeapon),
					ProperName = "Spiritual Weapon",
					SpellType = SpellNameEnum.SpiritualWeapon,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Spirit Guardians
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.SpiritGuardians),
					ProperName = "Spirit Guardians",
					SpellType = SpellNameEnum.SpiritGuardians,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 15,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Radius,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a holy symbol"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Stinking Cloud
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.StinkingCloud),
					ProperName = "Stinking Cloud",
					SpellType = SpellNameEnum.StinkingCloud,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a rotten egg or several skunk cabbage leaves"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Stoneskin
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Stoneskin),
					ProperName = "Stoneskin",
					SpellType = SpellNameEnum.Stoneskin,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "diamond dust worth 100 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Stone Shape
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.StoneShape),
					ProperName = "Stone Shape",
					SpellType = SpellNameEnum.StoneShape,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "soft clay, which must be worked into roughly the desired shape of the stone object"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Storm of Vengeance
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.StormofVengeance),
					ProperName = "Storm of Vengeance",
					SpellType = SpellNameEnum.StormofVengeance,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Sight,
						SpellEffectType = SpellEffectTypeEnum.Sight,
						RangeType = SpellDistanceTypeEnum.Sight
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Suggestion
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Suggestion),
					ProperName = "Suggestion",
					SpellType = SpellNameEnum.Suggestion,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = true,
						MaterialComponents = "a snake's tongue and either a bit of honeycomb or a drop of sweet oil"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 8,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Sunbeam
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Sunbeam),
					ProperName = "Sunbeam",
					SpellType = SpellNameEnum.Sunbeam,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Line,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a magnifying glass"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Sunburst
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Sunburst),
					ProperName = "Sunburst",
					SpellType = SpellNameEnum.Sunburst,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "fire and a piece of sunstone"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Symbol
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Symbol),
					ProperName = "Symbol",
					SpellType = SpellNameEnum.Symbol,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "mercury, phosphorus, and powdered diamond and opal with a total value of at least 1,000 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.UntilDispelledorTriggered,
					},
				},
				#endregion

				#region Telekinesis
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Telekinesis),
					ProperName = "Telekinesis",
					SpellType = SpellNameEnum.Telekinesis,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Telepathic Bond
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.TelepathicBond),
					ProperName = "Telepathic Bond",
					SpellType = SpellNameEnum.TelepathicBond,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "pieces of eggshell from two different kinds of creatures"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Teleport
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Teleport),
					ProperName = "Teleport",
					SpellType = SpellNameEnum.Teleport,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Teleportation Circle
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.TeleportationCircle),
					ProperName = "Teleportation Circle",
					SpellType = SpellNameEnum.TeleportationCircle,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = true,
						MaterialComponents = "rare chalks and inks infused with precious gems with 50 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Round,
					},
				},
				#endregion

				#region Thaumaturgy
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Thaumaturgy),
					ProperName = "Thaumaturgy",
					SpellType = SpellNameEnum.Thaumaturgy,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Thunderwave
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Thunderwave),
					ProperName = "Thunderwave",
					SpellType = SpellNameEnum.Thunderwave,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 15,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Cube,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Time Stop
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.TimeStop),
					ProperName = "Time Stop",
					SpellType = SpellNameEnum.TimeStop,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Tiny Hut
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.TinyHut),
					ProperName = "Tiny Hut",
					SpellType = SpellNameEnum.TinyHut,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Hemisphere,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a small crystal bead"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 8,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Tongues
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Tongues),
					ProperName = "Tongues",
					SpellType = SpellNameEnum.Tongues,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = true,
						MaterialComponents = "a small clay model of a ziggurat"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Transport via Plants
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.TransportviaPlants),
					ProperName = "Transport via Plants",
					SpellType = SpellNameEnum.TransportviaPlants,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Round,
					},
				},
				#endregion

				#region Tree Stride
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.TreeStride),
					ProperName = "Tree Stride",
					SpellType = SpellNameEnum.TreeStride,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region True Polymorph
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.TruePolymorph),
					ProperName = "True Polymorph",
					SpellType = SpellNameEnum.TruePolymorph,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a drop of mercury, a dollop of gum arabic, and a wisp of smoke"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region True Resurrection
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.TrueResurrection),
					ProperName = "True Resurrection",
					SpellType = SpellNameEnum.TrueResurrection,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a sprinkle of holy water and diamonds worth at least 25,000 gp, which the spell consumes"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region True Seeing
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.TrueSeeing),
					ProperName = "True Seeing",
					SpellType = SpellNameEnum.TrueSeeing,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "an ointment for the eyes that costs 25 gp; is made from mushroom powder, saffron, and fat; and is consumed by the spell"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region True Strike
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.TrueStrike),
					ProperName = "True Strike",
					SpellType = SpellNameEnum.TrueStrike,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = false,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Round,
					},
				},
				#endregion

				#region Unseen Servant
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.UnseenServant),
					ProperName = "Unseen Servant",
					SpellType = SpellNameEnum.UnseenServant,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a piece of string and a bit of wood"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Vampiric Touch
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.VampiricTouch),
					ProperName = "Vampiric Touch",
					SpellType = SpellNameEnum.VampiricTouch,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Vicious Mockery
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ViciousMockery),
					ProperName = "Vicious Mockery",
					SpellType = SpellNameEnum.ViciousMockery,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Wall of Fire
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.WallofFire),
					ProperName = "Wall of Fire",
					SpellType = SpellNameEnum.WallofFire,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a small piece of phosphorus"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Wall of Force
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.WallofForce),
					ProperName = "Wall of Force",
					SpellType = SpellNameEnum.WallofForce,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a pinch of powder made by crushing a clear gemstone"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Wall of Ice
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.WallofIce),
					ProperName = "Wall of Ice",
					SpellType = SpellNameEnum.WallofIce,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a small piece of quartz"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Wall of Stone
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.WallofStone),
					ProperName = "Wall of Stone",
					SpellType = SpellNameEnum.WallofStone,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a small block of granite"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Wall of Thorns
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.WallofThorns),
					ProperName = "Wall of Thorns",
					SpellType = SpellNameEnum.WallofThorns,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a handful of thorns"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

				#region Warding Bond
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.WardingBond),
					ProperName = "Warding Bond",
					SpellType = SpellNameEnum.WardingBond,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a pair of platinum rings worth at least 50 gp each, which you and the target must wear for the duration"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Water Breathing
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.WaterBreathing),
					ProperName = "Water Breathing",
					SpellType = SpellNameEnum.WaterBreathing,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a short reed or piece of straw"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 24,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Water Walk
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.WaterWalk),
					ProperName = "Water Walk",
					SpellType = SpellNameEnum.WaterWalk,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a piece of cork"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Web
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Web),
					ProperName = "Web",
					SpellType = SpellNameEnum.Web,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a bit of spiderweb"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Hour,
					},
				},
				#endregion

				#region Weird
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Weird),
					ProperName = "Weird",
					SpellType = SpellNameEnum.Weird,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Wind Walk
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.WindWalk),
					ProperName = "Wind Walk",
					SpellType = SpellNameEnum.WindWalk,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "fire and holy water"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 8,
						SpellDurationUnits = SpellDurationUnitsEnum.Hours,
					},
				},
				#endregion

				#region Wind Wall
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.WindWall),
					ProperName = "Wind Wall",
					SpellType = SpellNameEnum.WindWall,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = true,
						MaterialComponents = "a tiny fan and a feather of exotic origin"
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = true,
						UpToo = true,
						SpellDuration = 1,
						SpellDurationUnits = SpellDurationUnitsEnum.Minute,
					},
				},
				#endregion

				#region Wish
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.Wish),
					ProperName = "Wish",
					SpellType = SpellNameEnum.Wish,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Word of Recall
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.WordofRecall),
					ProperName = "Word of Recall",
					SpellType = SpellNameEnum.WordofRecall,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 5,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = false,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 0,
						SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous,
					},
				},
				#endregion

				#region Zone of Truth
				new SpellTableEntryViewModel
				{
					Name = nameof(SpellNameEnum.ZoneofTruth),
					ProperName = "Zone of Truth",
					SpellType = SpellNameEnum.ZoneofTruth,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Abjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new SpellComponentViewModel
					{
						Verbal = true,
						Somatic = true,
						Material = false,
					},
					SpellDuration = new SpellDurationViewModel
					{
						Concentration = false,
						UpToo = false,
						SpellDuration = 10,
						SpellDurationUnits = SpellDurationUnitsEnum.Minutes,
					},
				},
				#endregion

			};
		}
	}
}
