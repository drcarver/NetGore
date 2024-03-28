using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

using Microsoft.EntityFrameworkCore.Metadata.Internal;

using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NetGore.Data.Background;

/// <summary>
/// This table is best used by the adventuring party 
/// as a whole to determine starting relationships 
/// between the characters. One player begins the 
/// process by choosing someone in the group and 
/// rolling to learn the relationship between her 
/// and the second character. Then the next player 
/// chooses a different character and rolls to 
/// determine their relationship, and so on, until 
/// finally the last player rolls to determine his 
/// relationship with the first character. It is 
/// easiest to do this sitting around a table, with 
/// each player passing the dice clockwise until the 
/// dice have completed a full turn around the table.
/// <para>
/// You can also use this table free-form if you wish, 
/// rolling for your relationship for as many or as 
/// few of the other characters as you care to define; 
/// however, the first method guarantees that every 
/// character has connections to two other characters 
/// to improve group cohesion.
/// </para>
/// </summary>
public partial class BackgroundTables
{
    //Table: Relationship with Fellow Adventurer
    //d%	Result
    //01–05	Family or close as family—close friends, close/distant relatives, relatives by marriage/adoption
    //06–10	Friend of a friend
    //11–15	Tavern buddies
    //16–20	Hunting companions
    //21–25	Business associates, current or former
    //26–30	Contractor and employer
    //31–35	Former allies
    //36–40	Former enemies
    //41–45	Friendly competitors
    //46–50	Romantic competitors, current or former
    //51–55	Know each other by reputation only
    //56–60	Former inmates(prison, asylum, or captivity) or former inmate and captor
    //61–65	Criminal connections
    //66–70	Servants or apprentices to the same master
    //71–75	Met on a pilgrimage, caravan, or journey
    //76–80	Veterans of a skirmish or war
    //81–85	Follow(or followed) the same faith or cult
    //86–90	Best friends
    //91–95	Gaming or gambling associates
    //96–100	From the same hometown or region
    /// <summary>
    /// Relationship with Fellow Adventurer
    /// </summary>
    public static RandomTable RelationshipwithFellowAdventurerTable { get; } = new()
    {
        Name = "Relationship with Fellow Adventurer Table",
        DiceSides = 100,
        Table =
        [
            #region Family
            //01–05	Family or close as family—close friends, close/distant relatives, relatives by marriage/adoption
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 05,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Family),
                ProperName = "Family",
                Description =
                    "Family or close as family—close " +
                    "friends, close/distant relatives, " +
                    "relatives by marriage/adoption",
            },
            #endregion

            #region Friend of a friend
            //06–10	Friend of a friend
            new RandomTableEntry
            {
                LowerRange = 06,
                UpperRange = 10,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Friendofafriend),
                ProperName = "Friend of a friend",
                Description =
                    "Family or close as family—close " +
                    "friends, close/distant relatives, " +
                    "relatives by marriage/adoption",
            },
            #endregion

            #region Tavern buddies
            //11–15	Tavern buddies
            new RandomTableEntry
            {
                LowerRange = 11,
                UpperRange = 15,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Tavernbuddies),
                ProperName = "Tavern buddies",
            },
            #endregion

            #region Hunting companions
            //16–20	Hunting companions
            new RandomTableEntry
            {
                LowerRange = 16,
                UpperRange = 20,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Huntingcompanions),
                ProperName = "Hunting companions",
            },
            #endregion

            #region Business associates
            //21–25	Business associates, current or former
            new RandomTableEntry
            {
                LowerRange = 21,
                UpperRange = 25,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Businessassociates),
                ProperName = "Business associates",
                Description = "Business associates, current or former"
            },
            #endregion

            #region Contractor and employer
            //26–30	Contractor and employer
            new RandomTableEntry
            {
                LowerRange = 26,
                UpperRange = 30,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Contractorandemployer),
                ProperName = "Contractor and employer",
                Description = "Contractor and employer"
            },
            #endregion

            #region Former allies
            //31–35	Former allies
            new RandomTableEntry
            {
                LowerRange = 31,
                UpperRange = 35,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Formerallies),
                ProperName = "Former allies",
            },
            #endregion

            #region Former enemies
            //36–40	Former enemies
            new RandomTableEntry
            {
                LowerRange = 36,
                UpperRange = 40,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Formerenemies),
                ProperName = "Former enemies"
            },
            #endregion

            #region Friendly competitors
            //41–45	Friendly competitors
            new RandomTableEntry
            {
                LowerRange = 41,
                UpperRange = 45,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Friendlycompetitors),
                ProperName = "Friendly competitors"
            },
            #endregion

            #region Romantic competitors
            //46–50	Romantic competitors, current or former
            new RandomTableEntry
            {
                LowerRange = 46,
                UpperRange = 50,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Romanticcompetitors),
                ProperName = "Romantic competitors",
                Description = "Romantic competitors, current or former"
            },
            #endregion

            #region Know each other by reputation only
            //51–55	Know each other by reputation only
            new RandomTableEntry
            {
                LowerRange = 51,
                UpperRange = 55,
                Name = nameof(RelationshipwithFellowAdventurerEnum.KnownByRepution),
                ProperName = "Know each other by reputation only",
            },
            #endregion

            #region Former inmates
            //56–60	Former inmates(prison, asylum, or captivity) or former inmate and captor
            new RandomTableEntry
            {
                LowerRange = 56,
                UpperRange = 60,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Formerinmates),
                ProperName = "Former inmates",
                Description = "Former inmates(prison, asylum, or captivity) or former inmate and captor"
            },
            #endregion

            #region Criminal connections
            //61–65	Criminal connections
            new RandomTableEntry
            {
                LowerRange = 61,
                UpperRange = 65,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Criminalconnections),
                ProperName = "Criminal connections",
            },
            #endregion

            #region Servants
            //66–70	Servants or apprentices to the same master
            new RandomTableEntry
            {
                LowerRange = 66,
                UpperRange = 70,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Servants),
                ProperName = "Servants",
                Description = "Servants or apprentices to the same master"
            },
            #endregion

            #region Met on a pilgrimage
            //71–75	Met on a pilgrimage, caravan, or journey
            new RandomTableEntry
            {
                LowerRange = 71,
                UpperRange = 75,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Metonapilgrimage),
                ProperName = "Met on a pilgrimage",
                Description = "Met on a pilgrimage, caravan, or journey"
            },
            #endregion

            #region Veterans
            //76–80	Veterans of a skirmish or war
            new RandomTableEntry
            {
                LowerRange = 76,
                UpperRange = 80,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Veterans),
                ProperName = "Veterans",
                Description = "Veterans of a skirmish or war"
            },
            #endregion

            #region Follow
            //81–85	Follow(or followed) the same faith or cult
            new RandomTableEntry
            {
                LowerRange = 81,
                UpperRange = 85,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Follow),
                ProperName = "Follow",
                Description = "Follow (or followed) the same faith or cult"
            },
            #endregion

            #region Best friends
            //86–90	Best friends
            new RandomTableEntry
            {
                LowerRange = 86,
                UpperRange = 90,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Bestfriends),
                ProperName = "Best friends",
            },
            #endregion

            #region Gaming
            //91–95	Gaming or gambling associates
            new RandomTableEntry
            {
                LowerRange = 91,
                UpperRange = 95,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Gaming),
                ProperName = "Gaming or gambling associates",
            },
            #endregion

            #region Hometown
            //96–100	From the same hometown or region
            new RandomTableEntry
            {
                LowerRange = 96,
                UpperRange = 100,
                Name = nameof(RelationshipwithFellowAdventurerEnum.Hometown),
                ProperName = "From the same hometown or region",
            },
            #endregion
        ]
    };
}
