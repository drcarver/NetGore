using System.Diagnostics.CodeAnalysis;

using D20.Background.Enum;
using D20.Background.Interfaces;
using D20.Background.Models;
using D20.Core.Interfaces;
using D20.Monsters.Interfaces;
using D20.Monsters.Models.Humanoid;

using Microsoft.Extensions.Logging;

namespace D20.Monsters.Models;

public class CharacterRace : HumanoidRace, ICharacterRace
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public CharacterRace(ILoggerFactory loggerFactory)
    {
    }

    /// <summary>
    /// The creatures homeland
    /// </summary>
    public IBackgroundTableEntry? Homeland { get; private set; }

    /// <summary>
    /// The traits for this creature
    /// </summary>
    public List<TraitEnum> Traits { get; private set; } = [];

    /// <summary>
    /// The creature's parents
    /// </summary>
    public BackgroundTableEntry? Parents { get; private set; }

    /// <summary>
    /// The creature's circumstance of birth
    /// </summary>
    public BackgroundTableEntry? CircumstanceOfBirth { get; private set; }

    /// <summary>
    /// THe creature's parents profession
    /// </summary>
    public IBackgroundTableEntry? ParentProfession { get; private set; }

    /// <summary>
    /// Adopted parents if needed
    /// </summary>
    public IBackgroundTableEntry? AdoptedParents { get; private set; }

    /// <summary>
    /// Set the character background
    /// </summary>
    /// <param name="homelandTable"></param>
    /// <param name="unusualHomelandTable"></param>
    protected virtual void GetHomeland(
        IRandomTable homelandTable,
        IRandomTable unusualHomelandTable)
    {
        homelandTable?.InitializeTable();
        Homeland = (IBackgroundTableEntry?)homelandTable?.GetRandomRangeEntry();
        if (Homeland?.Name == "UnusualHomeland")
        {
            unusualHomelandTable?.InitializeTable();
            Homeland = (IBackgroundTableEntry?)unusualHomelandTable?.GetRandomRangeEntry();
        }
        if (Homeland?.Traits != null)
        {
            foreach (var trait in Homeland.Traits)
            {
                if (!Traits.Contains(trait))
                {
                    Traits.Add(trait);
                }
            }
        }
    }

    /// <summary>
    /// Get the parent info
    /// </summary>
    /// <param name="parentsTable">The parents table</param>
    protected virtual void GetParents(IRandomTable parentsTable)
    {
        parentsTable?.InitializeTable();
        Parents = (BackgroundTableEntry?)parentsTable?.GetRandomRangeEntry();
        if (Parents?.Traits != null)
        {
            foreach (var trait in Parents.Traits)
            {
                if (Traits.Contains(trait))
                {
                    Traits.Add(trait);
                }
            }
        }
    }

    /// <summary>
    /// Get circumstances of birth.  This will populate a
    /// number of properties based on the results.
    /// </summary>
    /// <param name="circumstanceofBirthTable"></param>
    protected virtual void GetCircumstanceofBirth(
        IRandomTable circumstanceofBirthTable,
        IProfessionTable professionTable,
        INobilityTable nobilityTable,
        IAdoptedOutsideYourRaceTable adoptedOutsideYourRaceTable)
    {
        circumstanceofBirthTable.InitializeTable();
        professionTable.InitializeTable();
        CircumstanceOfBirth = (BackgroundTableEntry?)circumstanceofBirthTable?.GetRandomRangeEntry();
        switch (CircumstanceOfBirth?.Name)
        {
            case nameof(CircumstanceofBirthEnum.LowerClassBirth):
                ParentProfession = (IBackgroundTableEntry?)professionTable?.GetRandomRangeEntry(20);
                break;
            case nameof(CircumstanceofBirthEnum.NobleBirth):
                nobilityTable.InitializeTable();
                ParentProfession = (IBackgroundTableEntry?)nobilityTable?.GetRandomRangeEntry();
                break;
            case nameof(CircumstanceofBirthEnum.AdoptedOutsideYourRace):
                adoptedOutsideYourRaceTable.InitializeTable();
                AdoptedParents = (IBackgroundTableEntry?)adoptedOutsideYourRaceTable?.GetRandomRangeEntry();
                break;
            default:
                ParentProfession = (IBackgroundTableEntry?)professionTable?.GetRandomRangeEntry();
                break;
        }

        // Copy over the traits
        if (CircumstanceOfBirth?.Traits != null)
        {
            foreach (var trait in CircumstanceOfBirth.Traits)
            {
                if (Traits.Contains(trait))
                {
                    Traits.Add(trait);
                }
            }
        }
        if (ParentProfession?.Traits != null)
        {
            foreach (var trait in ParentProfession.Traits)
            {
                if (Traits.Contains(trait))
                {
                    Traits.Add(trait);
                }
            }
        }
    }
}
