//
// The Spell Information Table
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

using GoDungeon.Spells.Enum;
using GoDungeon.Spells.Interfaces;
using GoDungeon.Spells.ViewModels;

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
					Name=nameof(SpellNameEnum.AcidArrow),
					ProperName="Acid Arrow",
					SpellType=SpellNameEnum.AcidArrow,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Acid Splash
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.AcidSplash),
					ProperName="Acid Splash",
					SpellType=SpellNameEnum.AcidSplash,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Aid
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Aid),
					ProperName="Aid",
					SpellType=SpellNameEnum.Aid,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Paladin,  },
				},
				#endregion

				#region Alarm
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Alarm),
					ProperName="Alarm",
					SpellType=SpellNameEnum.Alarm,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Ranger, ClassEnum.Wizard,  },
				},
				#endregion

				#region Alter Self
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.AlterSelf),
					ProperName="Alter Self",
					SpellType=SpellNameEnum.AlterSelf,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Animal Friendship
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.AnimalFriendship),
					ProperName="Animal Friendship",
					SpellType=SpellNameEnum.AnimalFriendship,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid, ClassEnum.Ranger,  },
				},
				#endregion

				#region Animal Messenger
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.AnimalMessenger),
					ProperName="Animal Messenger",
					SpellType=SpellNameEnum.AnimalMessenger,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid, ClassEnum.Ranger,  },
				},
				#endregion

				#region Animal Shapes
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.AnimalShapes),
					ProperName="Animal Shapes",
					SpellType=SpellNameEnum.AnimalShapes,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid,  },
				},
				#endregion

				#region Animate Dead
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.AnimateDead),
					ProperName="Animate Dead",
					SpellType=SpellNameEnum.AnimateDead,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Wizard,  },
				},
				#endregion

				#region Animate Objects
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.AnimateObjects),
					ProperName="Animate Objects",
					SpellType=SpellNameEnum.AnimateObjects,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Antilife Shell
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.AntilifeShell),
					ProperName="Antilife Shell",
					SpellType=SpellNameEnum.AntilifeShell,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Radius,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid,  },
				},
				#endregion

				#region Antimagic Field
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.AntimagicField),
					ProperName="Antimagic Field",
					SpellType=SpellNameEnum.AntimagicField,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Sphere,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Wizard,  },
				},
				#endregion

				#region Antipathy/Sympathy
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.AntipathySympathy),
					ProperName="Antipathy/Sympathy",
					SpellType=SpellNameEnum.AntipathySympathy,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Wizard,  },
				},
				#endregion

				#region Arcane Eye
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ArcaneEye),
					ProperName="Arcane Eye",
					SpellType=SpellNameEnum.ArcaneEye,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Arcane Hand
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ArcaneHand),
					ProperName="Arcane Hand",
					SpellType=SpellNameEnum.ArcaneHand,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Arcane Lock
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ArcaneLock),
					ProperName="Arcane Lock",
					SpellType=SpellNameEnum.ArcaneLock,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Arcane Sword
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ArcaneSword),
					ProperName="Arcane Sword",
					SpellType=SpellNameEnum.ArcaneSword,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Wizard,  },
				},
				#endregion

				#region Arcanist's Magic Aura
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ArcanistsMagicAura),
					ProperName="Arcanist's Magic Aura",
					SpellType=SpellNameEnum.ArcanistsMagicAura,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Astral Projection
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.AstralProjection),
					ProperName="Astral Projection",
					SpellType=SpellNameEnum.AstralProjection,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Augury
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Augury),
					ProperName="Augury",
					SpellType=SpellNameEnum.Augury,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Radius,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Awaken
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Awaken),
					ProperName="Awaken",
					SpellType=SpellNameEnum.Awaken,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(8, DurationEnum.Hours),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid,  },
				},
				#endregion

				#region Bane
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Bane),
					ProperName="Bane",
					SpellType=SpellNameEnum.Bane,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric,  },
				},
				#endregion

				#region Banishment
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Banishment),
					ProperName="Banishment",
					SpellType=SpellNameEnum.Banishment,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Paladin, ClassEnum.Cleric, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Barkskin
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Barkskin),
					ProperName="Barkskin",
					SpellType=SpellNameEnum.Barkskin,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Ranger,  },
				},
				#endregion

				#region Beacon of Hope
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.BeaconofHope),
					ProperName="Beacon of Hope",
					SpellType=SpellNameEnum.BeaconofHope,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Bestow Curse
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.BestowCurse),
					ProperName="Bestow Curse",
					SpellType=SpellNameEnum.BestowCurse,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Wizard,  },
				},
				#endregion

				#region Black Tentacles
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.BlackTentacles),
					ProperName="Black Tentacles",
					SpellType=SpellNameEnum.BlackTentacles,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Blade Barrier
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.BladeBarrier),
					ProperName="Blade Barrier",
					SpellType=SpellNameEnum.BladeBarrier,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Bless
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Bless),
					ProperName="Bless",
					SpellType=SpellNameEnum.Bless,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Paladin,  },
				},
				#endregion

				#region Blight
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Blight),
					ProperName="Blight",
					SpellType=SpellNameEnum.Blight,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Blindness/Deafness
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.BlindnessDeafness),
					ProperName="Blindness/Deafness",
					SpellType=SpellNameEnum.BlindnessDeafness,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Blink
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Blink),
					ProperName="Blink",
					SpellType=SpellNameEnum.Blink,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Blur
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Blur),
					ProperName="Blur",
					SpellType=SpellNameEnum.Blur,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Branding Smite
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.BrandingSmite),
					ProperName="Branding Smite",
					SpellType=SpellNameEnum.BrandingSmite,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Paladin,  },
				},
				#endregion

				#region Burning Hands
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.BurningHands),
					ProperName="Burning Hands",
					SpellType=SpellNameEnum.BurningHands,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 15,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Cone,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Call Lightning
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.CallLightning),
					ProperName="Call Lightning",
					SpellType=SpellNameEnum.CallLightning,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid,  },
				},
				#endregion

				#region Calm Emotions
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.CalmEmotions),
					ProperName="Calm Emotions",
					SpellType=SpellNameEnum.CalmEmotions,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric,  },
				},
				#endregion

				#region Chain Lightning
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ChainLightning),
					ProperName="Chain Lightning",
					SpellType=SpellNameEnum.ChainLightning,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Charm Person
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.CharmPerson),
					ProperName="Charm Person",
					SpellType=SpellNameEnum.CharmPerson,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Chill Touch
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ChillTouch),
					ProperName="Chill Touch",
					SpellType=SpellNameEnum.ChillTouch,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Circle of Death
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.CircleofDeath),
					ProperName="Circle of Death",
					SpellType=SpellNameEnum.CircleofDeath,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Clairvoyance
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Clairvoyance),
					ProperName="Clairvoyance",
					SpellType=SpellNameEnum.Clairvoyance,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 1,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Clone
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Clone),
					ProperName="Clone",
					SpellType=SpellNameEnum.Clone,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Cloudkill
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Cloudkill),
					ProperName="Cloudkill",
					SpellType=SpellNameEnum.Cloudkill,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Color Spray
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ColorSpray),
					ProperName="Color Spray",
					SpellType=SpellNameEnum.ColorSpray,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 15,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Cone,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Command
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Command),
					ProperName="Command",
					SpellType=SpellNameEnum.Command,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Paladin,  },
				},
				#endregion

				#region Commune
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Commune),
					ProperName="Commune",
					SpellType=SpellNameEnum.Commune,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Commune with Nature
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.CommunewithNature),
					ProperName="Commune with Nature",
					SpellType=SpellNameEnum.CommunewithNature,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Ranger,  },
				},
				#endregion

				#region Comprehend Languages
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ComprehendLanguages),
					ProperName="Comprehend Languages",
					SpellType=SpellNameEnum.ComprehendLanguages,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Compulsion
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Compulsion),
					ProperName="Compulsion",
					SpellType=SpellNameEnum.Compulsion,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard,  },
				},
				#endregion

				#region Cone of Cold
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ConeofCold),
					ProperName="Cone of Cold",
					SpellType=SpellNameEnum.ConeofCold,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Cone,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Confusion
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Confusion),
					ProperName="Confusion",
					SpellType=SpellNameEnum.Confusion,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Conjure Animals
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ConjureAnimals),
					ProperName="Conjure Animals",
					SpellType=SpellNameEnum.ConjureAnimals,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Ranger,  },
				},
				#endregion

				#region Conjure Celestial
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ConjureCelestial),
					ProperName="Conjure Celestial",
					SpellType=SpellNameEnum.ConjureCelestial,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Conjure Elemental
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ConjureElemental),
					ProperName="Conjure Elemental",
					SpellType=SpellNameEnum.ConjureElemental,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Wizard,  },
				},
				#endregion

				#region Conjure Fey
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ConjureFey),
					ProperName="Conjure Fey",
					SpellType=SpellNameEnum.ConjureFey,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Warlock,  },
				},
				#endregion

				#region Conjure Minor Elementals
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ConjureMinorElementals),
					ProperName="Conjure Minor Elementals",
					SpellType=SpellNameEnum.ConjureMinorElementals,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Wizard,  },
				},
				#endregion

				#region Conjure Woodland Beings
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ConjureWoodlandBeings),
					ProperName="Conjure Woodland Beings",
					SpellType=SpellNameEnum.ConjureWoodlandBeings,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Ranger,  },
				},
				#endregion

				#region Contact Other Plane
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ContactOtherPlane),
					ProperName="Contact Other Plane",
					SpellType=SpellNameEnum.ContactOtherPlane,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Contagion
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Contagion),
					ProperName="Contagion",
					SpellType=SpellNameEnum.Contagion,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid,  },
				},
				#endregion

				#region Contingency
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Contingency),
					ProperName="Contingency",
					SpellType=SpellNameEnum.Contingency,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Continual Flame
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ContinualFlame),
					ProperName="Continual Flame",
					SpellType=SpellNameEnum.ContinualFlame,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Wizard,  },
				},
				#endregion

				#region Control Water
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ControlWater),
					ProperName="Control Water",
					SpellType=SpellNameEnum.ControlWater,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 300,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Wizard,  },
				},
				#endregion

				#region Control Weather
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ControlWeather),
					ProperName="Control Weather",
					SpellType=SpellNameEnum.ControlWeather,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 5,
						DistanceType = SpellDistanceEnum.Mile,
						SpellEffectType = SpellEffectTypeEnum.Radius,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Wizard,  },
				},
				#endregion

				#region Counterspell
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Counterspell),
					ProperName="Counterspell",
					SpellType=SpellNameEnum.Counterspell,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Create Food and Water
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.CreateFoodandWater),
					ProperName="Create Food and Water",
					SpellType=SpellNameEnum.CreateFoodandWater,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Paladin,  },
				},
				#endregion

				#region Create or Destroy Water
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.CreateorDestroyWater),
					ProperName="Create or Destroy Water",
					SpellType=SpellNameEnum.CreateorDestroyWater,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid,  },
				},
				#endregion

				#region Create Undead
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.CreateUndead),
					ProperName="Create Undead",
					SpellType=SpellNameEnum.CreateUndead,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Creation
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Creation),
					ProperName="Creation",
					SpellType=SpellNameEnum.Creation,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Cure Wounds
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.CureWounds),
					ProperName="Cure Wounds",
					SpellType=SpellNameEnum.CureWounds,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Paladin, ClassEnum.Ranger,  },
				},
				#endregion

				#region Dancing Lights
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.DancingLights),
					ProperName="Dancing Lights",
					SpellType=SpellNameEnum.DancingLights,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Darkness
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Darkness),
					ProperName="Darkness",
					SpellType=SpellNameEnum.Darkness,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Darkvision
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Darkvision),
					ProperName="Darkvision",
					SpellType=SpellNameEnum.Darkvision,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Ranger, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Daylight
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Daylight),
					ProperName="Daylight",
					SpellType=SpellNameEnum.Daylight,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Paladin, ClassEnum.Ranger, ClassEnum.Sorcerer,  },
				},
				#endregion

				#region Death Ward
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.DeathWard),
					ProperName="Death Ward",
					SpellType=SpellNameEnum.DeathWard,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Paladin,  },
				},
				#endregion

				#region Delayed Blast Fireball
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.DelayedBlastFireball),
					ProperName="Delayed Blast Fireball",
					SpellType=SpellNameEnum.DelayedBlastFireball,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Demiplane
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Demiplane),
					ProperName="Demiplane",
					SpellType=SpellNameEnum.Demiplane,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Detect Evil and Good
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.DetectEvilandGood),
					ProperName="Detect Evil and Good",
					SpellType=SpellNameEnum.DetectEvilandGood,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Paladin,  },
				},
				#endregion

				#region Detect Magic
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.DetectMagic),
					ProperName="Detect Magic",
					SpellType=SpellNameEnum.DetectMagic,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Paladin, ClassEnum.Ranger, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Detect Poison and Disease
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.DetectPoisonandDisease),
					ProperName="Detect Poison and Disease",
					SpellType=SpellNameEnum.DetectPoisonandDisease,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Paladin, ClassEnum.Ranger,  },
				},
				#endregion

				#region Detect Thoughts
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.DetectThoughts),
					ProperName="Detect Thoughts",
					SpellType=SpellNameEnum.DetectThoughts,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Dimension Door
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.DimensionDoor),
					ProperName="Dimension Door",
					SpellType=SpellNameEnum.DimensionDoor,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 500,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Disguise Self
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.DisguiseSelf),
					ProperName="Disguise Self",
					SpellType=SpellNameEnum.DisguiseSelf,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Disintegrate
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Disintegrate),
					ProperName="Disintegrate",
					SpellType=SpellNameEnum.Disintegrate,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Dispel Evil and Good
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.DispelEvilandGood),
					ProperName="Dispel Evil and Good",
					SpellType=SpellNameEnum.DispelEvilandGood,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Paladin,  },
				},
				#endregion

				#region Dispel Magic
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.DispelMagic),
					ProperName="Dispel Magic",
					SpellType=SpellNameEnum.DispelMagic,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Paladin, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Divination
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Divination),
					ProperName="Divination",
					SpellType=SpellNameEnum.Divination,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Divine Favor
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.DivineFavor),
					ProperName="Divine Favor",
					SpellType=SpellNameEnum.DivineFavor,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Paladin,  },
				},
				#endregion

				#region Divine Word
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.DivineWord),
					ProperName="Divine Word",
					SpellType=SpellNameEnum.DivineWord,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Dominate Beast
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.DominateBeast),
					ProperName="Dominate Beast",
					SpellType=SpellNameEnum.DominateBeast,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Sorcerer,  },
				},
				#endregion

				#region Dominate Monster
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.DominateMonster),
					ProperName="Dominate Monster",
					SpellType=SpellNameEnum.DominateMonster,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Dominate Person
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.DominatePerson),
					ProperName="Dominate Person",
					SpellType=SpellNameEnum.DominatePerson,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Dream
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Dream),
					ProperName="Dream",
					SpellType=SpellNameEnum.Dream,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Special,
						SpellEffectType = SpellEffectTypeEnum.Special,
						RangeType = SpellDistanceTypeEnum.Special
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Druidcraft
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Druidcraft),
					ProperName="Druidcraft",
					SpellType=SpellNameEnum.Druidcraft,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid,  },
				},
				#endregion

				#region Earthquake
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Earthquake),
					ProperName="Earthquake",
					SpellType=SpellNameEnum.Earthquake,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 500,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Sorcerer,  },
				},
				#endregion

				#region Eldritch Blast
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.EldritchBlast),
					ProperName="Eldritch Blast",
					SpellType=SpellNameEnum.EldritchBlast,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Warlock,  },
				},
				#endregion

				#region Enhance Ability
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.EnhanceAbility),
					ProperName="Enhance Ability",
					SpellType=SpellNameEnum.EnhanceAbility,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Sorcerer,  },
				},
				#endregion

				#region Enlarge/Reduce
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.EnlargeReduce),
					ProperName="Enlarge/Reduce",
					SpellType=SpellNameEnum.EnlargeReduce,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Entangle
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Entangle),
					ProperName="Entangle",
					SpellType=SpellNameEnum.Entangle,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid,  },
				},
				#endregion

				#region Enthrall
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Enthrall),
					ProperName="Enthrall",
					SpellType=SpellNameEnum.Enthrall,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Warlock,  },
				},
				#endregion

				#region Etherealness
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Etherealness),
					ProperName="Etherealness",
					SpellType=SpellNameEnum.Etherealness,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Expeditious Retreat
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ExpeditiousRetreat),
					ProperName="Expeditious Retreat",
					SpellType=SpellNameEnum.ExpeditiousRetreat,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Eyebite
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Eyebite),
					ProperName="Eyebite",
					SpellType=SpellNameEnum.Eyebite,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Fabricate
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Fabricate),
					ProperName="Fabricate",
					SpellType=SpellNameEnum.Fabricate,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Faerie Fire
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FaerieFire),
					ProperName="Faerie Fire",
					SpellType=SpellNameEnum.FaerieFire,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid,  },
				},
				#endregion

				#region Faithful Hound
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FaithfulHound),
					ProperName="Faithful Hound",
					SpellType=SpellNameEnum.FaithfulHound,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region False Life
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FalseLife),
					ProperName="False Life",
					SpellType=SpellNameEnum.FalseLife,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Fear
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Fear),
					ProperName="Fear",
					SpellType=SpellNameEnum.Fear,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Cone,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Feather Fall
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FeatherFall),
					ProperName="Feather Fall",
					SpellType=SpellNameEnum.FeatherFall,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Feeblemind
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Feeblemind),
					ProperName="Feeblemind",
					SpellType=SpellNameEnum.Feeblemind,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Find Familiar
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FindFamiliar),
					ProperName="Find Familiar",
					SpellType=SpellNameEnum.FindFamiliar,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Find Steed
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FindSteed),
					ProperName="Find Steed",
					SpellType=SpellNameEnum.FindSteed,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Paladin,  },
				},
				#endregion

				#region Find the Path
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FindthePath),
					ProperName="Find the Path",
					SpellType=SpellNameEnum.FindthePath,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid,  },
				},
				#endregion

				#region Find Traps
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FindTraps),
					ProperName="Find Traps",
					SpellType=SpellNameEnum.FindTraps,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Ranger,  },
				},
				#endregion

				#region Finger of Death
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FingerofDeath),
					ProperName="Finger of Death",
					SpellType=SpellNameEnum.FingerofDeath,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Fireball
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Fireball),
					ProperName="Fireball",
					SpellType=SpellNameEnum.Fireball,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Fire Bolt
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FireBolt),
					ProperName="Fire Bolt",
					SpellType=SpellNameEnum.FireBolt,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Fire Shield
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FireShield),
					ProperName="Fire Shield",
					SpellType=SpellNameEnum.FireShield,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Fire Storm
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FireStorm),
					ProperName="Fire Storm",
					SpellType=SpellNameEnum.FireStorm,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Sorcerer,  },
				},
				#endregion

				#region Flame Blade
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FlameBlade),
					ProperName="Flame Blade",
					SpellType=SpellNameEnum.FlameBlade,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid,  },
				},
				#endregion

				#region Flame Strike
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FlameStrike),
					ProperName="Flame Strike",
					SpellType=SpellNameEnum.FlameStrike,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Flaming Sphere
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FlamingSphere),
					ProperName="Flaming Sphere",
					SpellType=SpellNameEnum.FlamingSphere,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Wizard,  },
				},
				#endregion

				#region Flesh to Stone
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FleshtoStone),
					ProperName="Flesh to Stone",
					SpellType=SpellNameEnum.FleshtoStone,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Floating Disk
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FloatingDisk),
					ProperName="Floating Disk",
					SpellType=SpellNameEnum.FloatingDisk,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Fly
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Fly),
					ProperName="Fly",
					SpellType=SpellNameEnum.Fly,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Fog Cloud
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FogCloud),
					ProperName="Fog Cloud",
					SpellType=SpellNameEnum.FogCloud,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Ranger, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Forbiddance
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Forbiddance),
					ProperName="Forbiddance",
					SpellType=SpellNameEnum.Forbiddance,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Forcecage
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Forcecage),
					ProperName="Forcecage",
					SpellType=SpellNameEnum.Forcecage,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 100,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Foresight
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Foresight),
					ProperName="Foresight",
					SpellType=SpellNameEnum.Foresight,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Freedom of Movement
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FreedomofMovement),
					ProperName="Freedom of Movement",
					SpellType=SpellNameEnum.FreedomofMovement,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Ranger,  },
				},
				#endregion

				#region Freezing Sphere
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.FreezingSphere),
					ProperName="Freezing Sphere",
					SpellType=SpellNameEnum.FreezingSphere,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 300,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Gaseous Form
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.GaseousForm),
					ProperName="Gaseous Form",
					SpellType=SpellNameEnum.GaseousForm,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Gate
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Gate),
					ProperName="Gate",
					SpellType=SpellNameEnum.Gate,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Geas
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Geas),
					ProperName="Geas",
					SpellType=SpellNameEnum.Geas,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Paladin, ClassEnum.Wizard,  },
				},
				#endregion

				#region Gentle Repose
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.GentleRepose),
					ProperName="Gentle Repose",
					SpellType=SpellNameEnum.GentleRepose,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Wizard,  },
				},
				#endregion

				#region Giant Insect
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.GiantInsect),
					ProperName="Giant Insect",
					SpellType=SpellNameEnum.GiantInsect,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid,  },
				},
				#endregion

				#region Glibness
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Glibness),
					ProperName="Glibness",
					SpellType=SpellNameEnum.Glibness,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Warlock,  },
				},
				#endregion

				#region Globe of Invulnerability
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.GlobeofInvulnerability),
					ProperName="Globe of Invulnerability",
					SpellType=SpellNameEnum.GlobeofInvulnerability,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Radius,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Glyph of Warding
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.GlyphofWarding),
					ProperName="Glyph of Warding",
					SpellType=SpellNameEnum.GlyphofWarding,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Wizard,  },
				},
				#endregion

				#region Goodberry
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Goodberry),
					ProperName="Goodberry",
					SpellType=SpellNameEnum.Goodberry,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Ranger,  },
				},
				#endregion

				#region Grease
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Grease),
					ProperName="Grease",
					SpellType=SpellNameEnum.Grease,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Greater Invisibility
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.GreaterInvisibility),
					ProperName="Greater Invisibility",
					SpellType=SpellNameEnum.GreaterInvisibility,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Greater Restoration
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.GreaterRestoration),
					ProperName="Greater Restoration",
					SpellType=SpellNameEnum.GreaterRestoration,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid,  },
				},
				#endregion

				#region Guardian of Faith
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.GuardianofFaith),
					ProperName="Guardian of Faith",
					SpellType=SpellNameEnum.GuardianofFaith,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Guards and Wards
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.GuardsandWards),
					ProperName="Guards and Wards",
					SpellType=SpellNameEnum.GuardsandWards,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Wizard,  },
				},
				#endregion

				#region Guidance
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Guidance),
					ProperName="Guidance",
					SpellType=SpellNameEnum.Guidance,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid,  },
				},
				#endregion

				#region Guiding Bolt
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.GuidingBolt),
					ProperName="Guiding Bolt",
					SpellType=SpellNameEnum.GuidingBolt,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Gust of Wind
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.GustofWind),
					ProperName="Gust of Wind",
					SpellType=SpellNameEnum.GustofWind,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Line,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Hallow
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Hallow),
					ProperName="Hallow",
					SpellType=SpellNameEnum.Hallow,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(24, DurationEnum.Hours),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Hallucinatory Terrain
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.HallucinatoryTerrain),
					ProperName="Hallucinatory Terrain",
					SpellType=SpellNameEnum.HallucinatoryTerrain,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 300,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Harm
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Harm),
					ProperName="Harm",
					SpellType=SpellNameEnum.Harm,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Haste
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Haste),
					ProperName="Haste",
					SpellType=SpellNameEnum.Haste,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Heal
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Heal),
					ProperName="Heal",
					SpellType=SpellNameEnum.Heal,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid,  },
				},
				#endregion

				#region Healing Word
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.HealingWord),
					ProperName="Healing Word",
					SpellType=SpellNameEnum.HealingWord,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid,  },
				},
				#endregion

				#region Heat Metal
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.HeatMetal),
					ProperName="Heat Metal",
					SpellType=SpellNameEnum.HeatMetal,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid,  },
				},
				#endregion

				#region Hellish Rebuke
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.HellishRebuke),
					ProperName="Hellish Rebuke",
					SpellType=SpellNameEnum.HellishRebuke,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Warlock,  },
				},
				#endregion

				#region Heroes' Feast
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.HeroesFeast),
					ProperName="Heroes' Feast",
					SpellType=SpellNameEnum.HeroesFeast,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid,  },
				},
				#endregion

				#region Heroism
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Heroism),
					ProperName="Heroism",
					SpellType=SpellNameEnum.Heroism,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Paladin,  },
				},
				#endregion

				#region Hideous Laughter
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.HideousLaughter),
					ProperName="Hideous Laughter",
					SpellType=SpellNameEnum.HideousLaughter,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Wizard,  },
				},
				#endregion

				#region Hold Monster
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.HoldMonster),
					ProperName="Hold Monster",
					SpellType=SpellNameEnum.HoldMonster,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Hold Person
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.HoldPerson),
					ProperName="Hold Person",
					SpellType=SpellNameEnum.HoldPerson,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Holy Aura
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.HolyAura),
					ProperName="Holy Aura",
					SpellType=SpellNameEnum.HolyAura,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Hunter's Mark
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.HuntersMark),
					ProperName="Hunter's Mark",
					SpellType=SpellNameEnum.HuntersMark,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Ranger,  },
				},
				#endregion

				#region Hypnotic Pattern
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.HypnoticPattern),
					ProperName="Hypnotic Pattern",
					SpellType=SpellNameEnum.HypnoticPattern,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Ice Storm
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.IceStorm),
					ProperName="Ice Storm",
					SpellType=SpellNameEnum.IceStorm,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 300,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Identify
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Identify),
					ProperName="Identify",
					SpellType=SpellNameEnum.Identify,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Wizard,  },
				},
				#endregion

				#region Illusory Script
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.IllusoryScript),
					ProperName="Illusory Script",
					SpellType=SpellNameEnum.IllusoryScript,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Imprisonment
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Imprisonment),
					ProperName="Imprisonment",
					SpellType=SpellNameEnum.Imprisonment,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Incendiary Cloud
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.IncendiaryCloud),
					ProperName="Incendiary Cloud",
					SpellType=SpellNameEnum.IncendiaryCloud,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Inflict Wounds
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.InflictWounds),
					ProperName="Inflict Wounds",
					SpellType=SpellNameEnum.InflictWounds,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Insect Plague
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.InsectPlague),
					ProperName="Insect Plague",
					SpellType=SpellNameEnum.InsectPlague,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 300,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Sorcerer,  },
				},
				#endregion

				#region Instant Summons
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.InstantSummons),
					ProperName="Instant Summons",
					SpellType=SpellNameEnum.InstantSummons,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Invisibility
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Invisibility),
					ProperName="Invisibility",
					SpellType=SpellNameEnum.Invisibility,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Irresistible Dance
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.IrresistibleDance),
					ProperName="Irresistible Dance",
					SpellType=SpellNameEnum.IrresistibleDance,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Wizard,  },
				},
				#endregion

				#region Jump
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Jump),
					ProperName="Jump",
					SpellType=SpellNameEnum.Jump,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Ranger, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Knock
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Knock),
					ProperName="Knock",
					SpellType=SpellNameEnum.Knock,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Legend Lore
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.LegendLore),
					ProperName="Legend Lore",
					SpellType=SpellNameEnum.LegendLore,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Wizard,  },
				},
				#endregion

				#region Lesser Restoration
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.LesserRestoration),
					ProperName="Lesser Restoration",
					SpellType=SpellNameEnum.LesserRestoration,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Paladin, ClassEnum.Ranger,  },
				},
				#endregion

				#region Levitate
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Levitate),
					ProperName="Levitate",
					SpellType=SpellNameEnum.Levitate,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Light
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Light),
					ProperName="Light",
					SpellType=SpellNameEnum.Light,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Lightning Bolt
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.LightningBolt),
					ProperName="Lightning Bolt",
					SpellType=SpellNameEnum.LightningBolt,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 100,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Line,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Locate Animals or Plants
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.LocateAnimalsorPlants),
					ProperName="Locate Animals or Plants",
					SpellType=SpellNameEnum.LocateAnimalsorPlants,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid, ClassEnum.Ranger,  },
				},
				#endregion

				#region Locate Creature
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.LocateCreature),
					ProperName="Locate Creature",
					SpellType=SpellNameEnum.LocateCreature,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Paladin, ClassEnum.Ranger, ClassEnum.Wizard,  },
				},
				#endregion

				#region Locate Object
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.LocateObject),
					ProperName="Locate Object",
					SpellType=SpellNameEnum.LocateObject,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Paladin, ClassEnum.Ranger, ClassEnum.Wizard,  },
				},
				#endregion

				#region Longstrider
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Longstrider),
					ProperName="Longstrider",
					SpellType=SpellNameEnum.Longstrider,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid, ClassEnum.Ranger, ClassEnum.Wizard,  },
				},
				#endregion

				#region Mage Armor
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MageArmor),
					ProperName="Mage Armor",
					SpellType=SpellNameEnum.MageArmor,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Mage Hand
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MageHand),
					ProperName="Mage Hand",
					SpellType=SpellNameEnum.MageHand,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Magic Circle
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MagicCircle),
					ProperName="Magic Circle",
					SpellType=SpellNameEnum.MagicCircle,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Paladin, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Magic Jar
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MagicJar),
					ProperName="Magic Jar",
					SpellType=SpellNameEnum.MagicJar,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Magic Missile
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MagicMissile),
					ProperName="Magic Missile",
					SpellType=SpellNameEnum.MagicMissile,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Magic Mouth
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MagicMouth),
					ProperName="Magic Mouth",
					SpellType=SpellNameEnum.MagicMouth,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Wizard,  },
				},
				#endregion

				#region Magic Weapon
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MagicWeapon),
					ProperName="Magic Weapon",
					SpellType=SpellNameEnum.MagicWeapon,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Paladin, ClassEnum.Wizard,  },
				},
				#endregion

				#region Magnificent Mansion
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MagnificentMansion),
					ProperName="Magnificent Mansion",
					SpellType=SpellNameEnum.MagnificentMansion,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 300,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Wizard,  },
				},
				#endregion

				#region Major Image
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MajorImage),
					ProperName="Major Image",
					SpellType=SpellNameEnum.MajorImage,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Mass Cure Wounds
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MassCureWounds),
					ProperName="Mass Cure Wounds",
					SpellType=SpellNameEnum.MassCureWounds,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid,  },
				},
				#endregion

				#region Mass Heal
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MassHeal),
					ProperName="Mass Heal",
					SpellType=SpellNameEnum.MassHeal,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Mass Healing Word
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MassHealingWord),
					ProperName="Mass Healing Word",
					SpellType=SpellNameEnum.MassHealingWord,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Mass Suggestion
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MassSuggestion),
					ProperName="Mass Suggestion",
					SpellType=SpellNameEnum.MassSuggestion,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Maze
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Maze),
					ProperName="Maze",
					SpellType=SpellNameEnum.Maze,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Meld into Stone
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MeldintoStone),
					ProperName="Meld into Stone",
					SpellType=SpellNameEnum.MeldintoStone,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid,  },
				},
				#endregion

				#region Mending
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Mending),
					ProperName="Mending",
					SpellType=SpellNameEnum.Mending,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Message
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Message),
					ProperName="Message",
					SpellType=SpellNameEnum.Message,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Meteor Swarm
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MeteorSwarm),
					ProperName="Meteor Swarm",
					SpellType=SpellNameEnum.MeteorSwarm,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 1,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Mind Blank
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MindBlank),
					ProperName="Mind Blank",
					SpellType=SpellNameEnum.MindBlank,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Wizard,  },
				},
				#endregion

				#region Minor Illusion
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MinorIllusion),
					ProperName="Minor Illusion",
					SpellType=SpellNameEnum.MinorIllusion,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Mirage Arcane
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MirageArcane),
					ProperName="Mirage Arcane",
					SpellType=SpellNameEnum.MirageArcane,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Sight,
						SpellEffectType = SpellEffectTypeEnum.Sight,
						RangeType = SpellDistanceTypeEnum.Sight
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid, ClassEnum.Wizard,  },
				},
				#endregion

				#region Mirror Image
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MirrorImage),
					ProperName="Mirror Image",
					SpellType=SpellNameEnum.MirrorImage,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Mislead
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Mislead),
					ProperName="Mislead",
					SpellType=SpellNameEnum.Mislead,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Wizard,  },
				},
				#endregion

				#region Misty Step
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MistyStep),
					ProperName="Misty Step",
					SpellType=SpellNameEnum.MistyStep,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Modify Memory
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ModifyMemory),
					ProperName="Modify Memory",
					SpellType=SpellNameEnum.ModifyMemory,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Wizard,  },
				},
				#endregion

				#region Moonbeam
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Moonbeam),
					ProperName="Moonbeam",
					SpellType=SpellNameEnum.Moonbeam,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid,  },
				},
				#endregion

				#region Move Earth
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.MoveEarth),
					ProperName="Move Earth",
					SpellType=SpellNameEnum.MoveEarth,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Nondetection
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Nondetection),
					ProperName="Nondetection",
					SpellType=SpellNameEnum.Nondetection,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Ranger, ClassEnum.Wizard,  },
				},
				#endregion

				#region Passwall
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Passwall),
					ProperName="Passwall",
					SpellType=SpellNameEnum.Passwall,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Pass without Trace
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.PasswithoutTrace),
					ProperName="Pass without Trace",
					SpellType=SpellNameEnum.PasswithoutTrace,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Ranger,  },
				},
				#endregion

				#region Phantasmal Killer
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.PhantasmalKiller),
					ProperName="Phantasmal Killer",
					SpellType=SpellNameEnum.PhantasmalKiller,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Phantom Steed
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.PhantomSteed),
					ProperName="Phantom Steed",
					SpellType=SpellNameEnum.PhantomSteed,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Planar Ally
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.PlanarAlly),
					ProperName="Planar Ally",
					SpellType=SpellNameEnum.PlanarAlly,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Planar Binding
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.PlanarBinding),
					ProperName="Planar Binding",
					SpellType=SpellNameEnum.PlanarBinding,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Wizard,  },
				},
				#endregion

				#region Plane Shift
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.PlaneShift),
					ProperName="Plane Shift",
					SpellType=SpellNameEnum.PlaneShift,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard, ClassEnum.Druid,  },
				},
				#endregion

				#region Plant Growth
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.PlantGrowth),
					ProperName="Plant Growth",
					SpellType=SpellNameEnum.PlantGrowth,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid, ClassEnum.Ranger,  },
				},
				#endregion

				#region Poison Spray
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.PoisonSpray),
					ProperName="Poison Spray",
					SpellType=SpellNameEnum.PoisonSpray,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Polymorph
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Polymorph),
					ProperName="Polymorph",
					SpellType=SpellNameEnum.Polymorph,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Power Word Kill
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.PowerWordKill),
					ProperName="Power Word Kill",
					SpellType=SpellNameEnum.PowerWordKill,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Power Word Stun
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.PowerWordStun),
					ProperName="Power Word Stun",
					SpellType=SpellNameEnum.PowerWordStun,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Prayer of Healing
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.PrayerofHealing),
					ProperName="Prayer of Healing",
					SpellType=SpellNameEnum.PrayerofHealing,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Prestidigitation
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Prestidigitation),
					ProperName="Prestidigitation",
					SpellType=SpellNameEnum.Prestidigitation,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Prismatic Spray
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.PrismaticSpray),
					ProperName="Prismatic Spray",
					SpellType=SpellNameEnum.PrismaticSpray,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Cone,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Prismatic Wall
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.PrismaticWall),
					ProperName="Prismatic Wall",
					SpellType=SpellNameEnum.PrismaticWall,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Private Sanctum
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.PrivateSanctum),
					ProperName="Private Sanctum",
					SpellType=SpellNameEnum.PrivateSanctum,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Produce Flame
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ProduceFlame),
					ProperName="Produce Flame",
					SpellType=SpellNameEnum.ProduceFlame,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid,  },
				},
				#endregion

				#region Programmed Illusion
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ProgrammedIllusion),
					ProperName="Programmed Illusion",
					SpellType=SpellNameEnum.ProgrammedIllusion,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Wizard,  },
				},
				#endregion

				#region Project Image
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ProjectImage),
					ProperName="Project Image",
					SpellType=SpellNameEnum.ProjectImage,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 500,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Wizard,  },
				},
				#endregion

				#region Protection from Energy
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ProtectionfromEnergy),
					ProperName="Protection from Energy",
					SpellType=SpellNameEnum.ProtectionfromEnergy,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Ranger, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Protection from Evil and Good
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ProtectionfromEvilandGood),
					ProperName="Protection from Evil and Good",
					SpellType=SpellNameEnum.ProtectionfromEvilandGood,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Paladin, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Protection from Poison
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ProtectionfromPoison),
					ProperName="Protection from Poison",
					SpellType=SpellNameEnum.ProtectionfromPoison,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Paladin, ClassEnum.Ranger,  },
				},
				#endregion

				#region Purify Food and Drink
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.PurifyFoodandDrink),
					ProperName="Purify Food and Drink",
					SpellType=SpellNameEnum.PurifyFoodandDrink,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Paladin,  },
				},
				#endregion

				#region Raise Dead
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.RaiseDead),
					ProperName="Raise Dead",
					SpellType=SpellNameEnum.RaiseDead,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Paladin,  },
				},
				#endregion

				#region Ray of Enfeeblement
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.RayofEnfeeblement),
					ProperName="Ray of Enfeeblement",
					SpellType=SpellNameEnum.RayofEnfeeblement,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Ray of Frost
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.RayofFrost),
					ProperName="Ray of Frost",
					SpellType=SpellNameEnum.RayofFrost,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Regenerate
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Regenerate),
					ProperName="Regenerate",
					SpellType=SpellNameEnum.Regenerate,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid,  },
				},
				#endregion

				#region Reincarnate
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Reincarnate),
					ProperName="Reincarnate",
					SpellType=SpellNameEnum.Reincarnate,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid,  },
				},
				#endregion

				#region Remove Curse
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.RemoveCurse),
					ProperName="Remove Curse",
					SpellType=SpellNameEnum.RemoveCurse,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Paladin, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Resilient Sphere
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ResilientSphere),
					ProperName="Resilient Sphere",
					SpellType=SpellNameEnum.ResilientSphere,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Resistance
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Resistance),
					ProperName="Resistance",
					SpellType=SpellNameEnum.Resistance,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid,  },
				},
				#endregion

				#region Resurrection
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Resurrection),
					ProperName="Resurrection",
					SpellType=SpellNameEnum.Resurrection,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric,  },
				},
				#endregion

				#region Reverse Gravity
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ReverseGravity),
					ProperName="Reverse Gravity",
					SpellType=SpellNameEnum.ReverseGravity,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 100,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Revivify
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Revivify),
					ProperName="Revivify",
					SpellType=SpellNameEnum.Revivify,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Paladin,  },
				},
				#endregion

				#region Rope Trick
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.RopeTrick),
					ProperName="Rope Trick",
					SpellType=SpellNameEnum.RopeTrick,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Sacred Flame
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.SacredFlame),
					ProperName="Sacred Flame",
					SpellType=SpellNameEnum.SacredFlame,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Sanctuary
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Sanctuary),
					ProperName="Sanctuary",
					SpellType=SpellNameEnum.Sanctuary,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Scorching Ray
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ScorchingRay),
					ProperName="Scorching Ray",
					SpellType=SpellNameEnum.ScorchingRay,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Scrying
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Scrying),
					ProperName="Scrying",
					SpellType=SpellNameEnum.Scrying,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(10, DurationEnum.Minutes),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Secret Chest
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.SecretChest),
					ProperName="Secret Chest",
					SpellType=SpellNameEnum.SecretChest,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Seeming
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Seeming),
					ProperName="Seeming",
					SpellType=SpellNameEnum.Seeming,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region See Invisibility
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.SeeInvisibility),
					ProperName="See Invisibility",
					SpellType=SpellNameEnum.SeeInvisibility,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Sending
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Sending),
					ProperName="Sending",
					SpellType=SpellNameEnum.Sending,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Unlimited,
						SpellEffectType = SpellEffectTypeEnum.Unlimited,
						RangeType = SpellDistanceTypeEnum.Unlimited
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Wizard,  },
				},
				#endregion

				#region Sequester
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Sequester),
					ProperName="Sequester",
					SpellType=SpellNameEnum.Sequester,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Shapechange
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Shapechange),
					ProperName="Shapechange",
					SpellType=SpellNameEnum.Shapechange,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Wizard,  },
				},
				#endregion

				#region Shatter
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Shatter),
					ProperName="Shatter",
					SpellType=SpellNameEnum.Shatter,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Shield
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Shield),
					ProperName="Shield",
					SpellType=SpellNameEnum.Shield,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Shield of Faith
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ShieldofFaith),
					ProperName="Shield of Faith",
					SpellType=SpellNameEnum.ShieldofFaith,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Paladin,  },
				},
				#endregion

				#region Shillelagh
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Shillelagh),
					ProperName="Shillelagh",
					SpellType=SpellNameEnum.Shillelagh,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid,  },
				},
				#endregion

				#region Shocking Grasp
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ShockingGrasp),
					ProperName="Shocking Grasp",
					SpellType=SpellNameEnum.ShockingGrasp,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Silence
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Silence),
					ProperName="Silence",
					SpellType=SpellNameEnum.Silence,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Ranger,  },
				},
				#endregion

				#region Silent Image
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.SilentImage),
					ProperName="Silent Image",
					SpellType=SpellNameEnum.SilentImage,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Simulacrum
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Simulacrum),
					ProperName="Simulacrum",
					SpellType=SpellNameEnum.Simulacrum,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(12, DurationEnum.Hours),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Sleep
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Sleep),
					ProperName="Sleep",
					SpellType=SpellNameEnum.Sleep,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Sleet Storm
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.SleetStorm),
					ProperName="Sleet Storm",
					SpellType=SpellNameEnum.SleetStorm,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Slow
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Slow),
					ProperName="Slow",
					SpellType=SpellNameEnum.Slow,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Spare the Dying
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.SparetheDying),
					ProperName="Spare the Dying",
					SpellType=SpellNameEnum.SparetheDying,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Speak with Animals
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.SpeakwithAnimals),
					ProperName="Speak with Animals",
					SpellType=SpellNameEnum.SpeakwithAnimals,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid, ClassEnum.Ranger,  },
				},
				#endregion

				#region Speak with Dead
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.SpeakwithDead),
					ProperName="Speak with Dead",
					SpellType=SpellNameEnum.SpeakwithDead,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric,  },
				},
				#endregion

				#region Speak with Plants
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.SpeakwithPlants),
					ProperName="Speak with Plants",
					SpellType=SpellNameEnum.SpeakwithPlants,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Radius,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid, ClassEnum.Ranger,  },
				},
				#endregion

				#region Spider Climb
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.SpiderClimb),
					ProperName="Spider Climb",
					SpellType=SpellNameEnum.SpiderClimb,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Spike Growth
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.SpikeGrowth),
					ProperName="Spike Growth",
					SpellType=SpellNameEnum.SpikeGrowth,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Ranger,  },
				},
				#endregion

				#region Spiritual Weapon
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.SpiritualWeapon),
					ProperName="Spiritual Weapon",
					SpellType=SpellNameEnum.SpiritualWeapon,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(0, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Spirit Guardians
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.SpiritGuardians),
					ProperName="Spirit Guardians",
					SpellType=SpellNameEnum.SpiritGuardians,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 15,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Radius,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Stinking Cloud
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.StinkingCloud),
					ProperName="Stinking Cloud",
					SpellType=SpellNameEnum.StinkingCloud,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 90,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Stoneskin
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Stoneskin),
					ProperName="Stoneskin",
					SpellType=SpellNameEnum.Stoneskin,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Ranger, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Stone Shape
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.StoneShape),
					ProperName="Stone Shape",
					SpellType=SpellNameEnum.StoneShape,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Wizard,  },
				},
				#endregion

				#region Storm of Vengeance
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.StormofVengeance),
					ProperName="Storm of Vengeance",
					SpellType=SpellNameEnum.StormofVengeance,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Sight,
						SpellEffectType = SpellEffectTypeEnum.Sight,
						RangeType = SpellDistanceTypeEnum.Sight
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid,  },
				},
				#endregion

				#region Suggestion
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Suggestion),
					ProperName="Suggestion",
					SpellType=SpellNameEnum.Suggestion,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Sunbeam
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Sunbeam),
					ProperName="Sunbeam",
					SpellType=SpellNameEnum.Sunbeam,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Line,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Sunburst
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Sunburst),
					ProperName="Sunburst",
					SpellType=SpellNameEnum.Sunburst,
					Level = 8,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 150,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Symbol
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Symbol),
					ProperName="Symbol",
					SpellType=SpellNameEnum.Symbol,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Wizard,  },
				},
				#endregion

				#region Telekinesis
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Telekinesis),
					ProperName="Telekinesis",
					SpellType=SpellNameEnum.Telekinesis,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Telepathic Bond
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.TelepathicBond),
					ProperName="Telepathic Bond",
					SpellType=SpellNameEnum.TelepathicBond,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Teleport
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Teleport),
					ProperName="Teleport",
					SpellType=SpellNameEnum.Teleport,
					Level = 7,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Teleportation Circle
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.TeleportationCircle),
					ProperName="Teleportation Circle",
					SpellType=SpellNameEnum.TeleportationCircle,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Thaumaturgy
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Thaumaturgy),
					ProperName="Thaumaturgy",
					SpellType=SpellNameEnum.Thaumaturgy,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Thunderwave
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Thunderwave),
					ProperName="Thunderwave",
					SpellType=SpellNameEnum.Thunderwave,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 15,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Cube,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Druid, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Time Stop
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.TimeStop),
					ProperName="Time Stop",
					SpellType=SpellNameEnum.TimeStop,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Tiny Hut
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.TinyHut),
					ProperName="Tiny Hut",
					SpellType=SpellNameEnum.TinyHut,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Hemisphere,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Wizard,  },
				},
				#endregion

				#region Tongues
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Tongues),
					ProperName="Tongues",
					SpellType=SpellNameEnum.Tongues,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Transport via Plants
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.TransportviaPlants),
					ProperName="Transport via Plants",
					SpellType=SpellNameEnum.TransportviaPlants,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 10,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid,  },
				},
				#endregion

				#region Tree Stride
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.TreeStride),
					ProperName="Tree Stride",
					SpellType=SpellNameEnum.TreeStride,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Ranger,  },
				},
				#endregion

				#region True Polymorph
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.TruePolymorph),
					ProperName="True Polymorph",
					SpellType=SpellNameEnum.TruePolymorph,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region True Resurrection
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.TrueResurrection),
					ProperName="True Resurrection",
					SpellType=SpellNameEnum.TrueResurrection,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Hour),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid,  },
				},
				#endregion

				#region True Seeing
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.TrueSeeing),
					ProperName="True Seeing",
					SpellType=SpellNameEnum.TrueSeeing,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region True Strike
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.TrueStrike),
					ProperName="True Strike",
					SpellType=SpellNameEnum.TrueStrike,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Sorcerer, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Unseen Servant
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.UnseenServant),
					ProperName="Unseen Servant",
					SpellType=SpellNameEnum.UnseenServant,
					Level = 1,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Vampiric Touch
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.VampiricTouch),
					ProperName="Vampiric Touch",
					SpellType=SpellNameEnum.VampiricTouch,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Warlock, ClassEnum.Wizard,  },
				},
				#endregion

				#region Vicious Mockery
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ViciousMockery),
					ProperName="Vicious Mockery",
					SpellType=SpellNameEnum.ViciousMockery,
					Level = 0,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard,  },
				},
				#endregion

				#region Wall of Fire
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.WallofFire),
					ProperName="Wall of Fire",
					SpellType=SpellNameEnum.WallofFire,
					Level = 4,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Wall of Force
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.WallofForce),
					ProperName="Wall of Force",
					SpellType=SpellNameEnum.WallofForce,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Wall of Ice
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.WallofIce),
					ProperName="Wall of Ice",
					SpellType=SpellNameEnum.WallofIce,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Wall of Stone
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.WallofStone),
					ProperName="Wall of Stone",
					SpellType=SpellNameEnum.WallofStone,
					Level = 5,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Wall of Thorns
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.WallofThorns),
					ProperName="Wall of Thorns",
					SpellType=SpellNameEnum.WallofThorns,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid,  },
				},
				#endregion

				#region Warding Bond
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.WardingBond),
					ProperName="Warding Bond",
					SpellType=SpellNameEnum.WardingBond,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Touch
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Water Breathing
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.WaterBreathing),
					ProperName="Water Breathing",
					SpellType=SpellNameEnum.WaterBreathing,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Ranger, ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Water Walk
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.WaterWalk),
					ProperName="Water Walk",
					SpellType=SpellNameEnum.WaterWalk,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric, ClassEnum.Druid, ClassEnum.Ranger, ClassEnum.Sorcerer,  },
				},
				#endregion

				#region Web
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Web),
					ProperName="Web",
					SpellType=SpellNameEnum.Web,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Weird
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Weird),
					ProperName="Weird",
					SpellType=SpellNameEnum.Weird,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Wizard,  },
				},
				#endregion

				#region Wind Walk
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.WindWalk),
					ProperName="Wind Walk",
					SpellType=SpellNameEnum.WindWalk,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Minute),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 30,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid,  },
				},
				#endregion

				#region Wind Wall
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.WindWall),
					ProperName="Wind Wall",
					SpellType=SpellNameEnum.WindWall,
					Level = 3,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 120,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Druid, ClassEnum.Ranger,  },
				},
				#endregion

				#region Wish
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.Wish),
					ProperName="Wish",
					SpellType=SpellNameEnum.Wish,
					Level = 9,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 0,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Creature,
						RangeType = SpellDistanceTypeEnum.Self
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Sorcerer, ClassEnum.Wizard,  },
				},
				#endregion

				#region Word of Recall
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.WordofRecall),
					ProperName="Word of Recall",
					SpellType=SpellNameEnum.WordofRecall,
					Level = 6,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 5,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Cleric,  },
				},
				#endregion

				#region Zone of Truth
				new SpellTableEntryViewModel
				{
					Name=nameof(SpellNameEnum.ZoneofTruth),
					ProperName="Zone of Truth",
					SpellType=SpellNameEnum.ZoneofTruth,
					Level = 2,
					MagicSchool = MagicSchoolEnum.Conjuration,
					CastingTime = new CastingTimeViewModel(1, DurationEnum.Action),
					SpellRange = new SpellRangeViewModel
					{
						Unit = 60,
						DistanceType = SpellDistanceEnum.Feet,
						SpellEffectType = SpellEffectTypeEnum.Location,
						RangeType = SpellDistanceTypeEnum.Ranged
					},
					SpellComponents = new ObservableCollection<string>(),
					Casters = new ObservableCollection<ClassEnum> {ClassEnum.Bard, ClassEnum.Cleric, ClassEnum.Paladin,  },
				},
				#endregion

			};
		}
	}
}
