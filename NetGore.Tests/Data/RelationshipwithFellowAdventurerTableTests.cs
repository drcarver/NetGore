using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;
using NetGore.Data.Background;
using NetGore.Data.Interfaces;
using NetGore.Data.Models;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class RelationshipwithFellowAdventurerTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        var table = new RelationshipwithFellowAdventurerTable();
        ClassicAssert.IsTrue(table.Description == "Relationship with Fellow Adventurer Table");
        ClassicAssert.IsTrue(table.DiceSides == 100);

        for (int i = 1; i <= table.DiceSides; i++)
        {
            var entry = table.GetEntryByNumber(i);
            ClassicAssert.IsTrue(VerifyEntry(i, entry), $"Table entry {i} - Name = {entry?.Name} is incorrect");
        }
    }

    /// <summary>
    /// Verify a random table entry
    /// </summary>
    /// <param name="i">The index for the table</param>
    /// <param name="entry">The random entry</param>
    /// <returns>True if correct</returns>
    private static bool VerifyEntry(int i, IGameTableEntry entry)
    {
        if (entry == null)
        {
            return false;
        }

        switch (i)
        {
            //01–05	Family
            case int n when (n>= 1 && n <= 5):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Family);

            //06–10	Friend of a friend
            case int n when (n >= 6 && n <= 10):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Friendofafriend);

            //11–15	Tavern buddies
            case int n when (n >= 11 && n <= 15):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Tavernbuddies);

            //16–20	Hunting companions
            case int n when (n >= 16 && n <= 20):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Huntingcompanions);

            //21–25	Business associates, current or former
            case int n when (n >= 21 && n <= 25):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Businessassociates);

            //26–30	Contractor and employer
            case int n when (n >= 26 && n <= 30):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Contractorandemployer);

            //31–35	Former allies
            case int n when (n >= 31 && n <= 35):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Formerallies);

            //36–40	Former enemies
            case int n when (n >= 36 && n <= 40):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Formerenemies);

            //41–45	Friendly competitors
            case int n when (n >= 41 && n <= 45):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Friendlycompetitors);

            //46–50	Romantic competitors, current or former
            case int n when (n >= 46 && n <= 50):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Romanticcompetitors);

            //51–55	Know each other by reputation only
            case int n when (n >= 51 && n <= 55):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.KnownByRepution);

            //56–60	Former inmates(prison, asylum, or captivity) or former inmate and captor
            case int n when (n >= 56 && n <= 60):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Formerinmates);

            //61–65	Criminal connections
            case int n when (n >= 61 && n <= 65):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Criminalconnections);

            //66–70	Servants or apprentices to the same master
            case int n when (n >= 66 && n <= 70):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Servants);

            //71–75	Met on a pilgrimage, caravan, or journey
            case int n when (n >= 71 && n <= 75):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Metonapilgrimage);

            //76–80	Veterans of a skirmish or war
            case int n when (n >= 76 && n <= 80):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Veterans);

            //81–85	Follow(or followed) the same faith or cult
            case int n when (n >= 81 && n <= 85):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Follow);

            //86–90	Best friends
            case int n when (n >= 86 && n <= 90):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Bestfriends);

            //91–95	Gaming or gambling associates
            case int n when (n >= 91 && n <= 95):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Gaming);

            //96–100	From the same hometown or region
            case int n when (n >= 96 && n <= 100):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Hometown);
        }
        return false;
    }
}
