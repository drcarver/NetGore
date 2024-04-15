using System.Diagnostics.CodeAnalysis;

using D20.Core.Abilities;
using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Core.Models;

namespace D20.Core.Tables;

/// <summary>
/// The strength modifier table.  
/// </summary>
public class StrengthModifierTable : GameTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public StrengthModifierTable()
    {
        Name = nameof(StrengthModifierTable);
        ProperName = "Strength, Carrying Capacity";
        TableType = TableTypeEnum.CharacterTable;
    }

    //Strength, Carrying Capacity
    //Score Light Load(lbs.)   Medium Load(lbs.)  Heavy Load(lbs.)   Modifier Examples    Description
    //— (no score)	—	—	—	—	Allip, shadow, will-o’-wisp A creature with no Strength score is likely to be incorporeal(like ghosts)
    //0	0	0	0	—	—	Too weak to move in any way and is unconscious.
    //1	0-3	4–6	7–10	–5	Lantern archon, bat, toad   Morbidly weak, has significant trouble lifting own limbs
    //2	0-6	7–13	14–20	–4	Rat swarm   Needs help to stand, can be knocked over by strong breezes
    //3	0-10	11–20	21–30	–4	 	 
    //4	0-13	14–26	27–40	–3	Grig, monstrous centipede   Knocked off balance by swinging something dense
    //5	0-16	17–33	34–50	–3	 	 
    //6	0-20	21–40	41–60	–2	Hawk, cockatrice, pixie Difficulty pushing an object of their weight
    //7	0-23	24–46	47–70	–2	 	 
    //8	0-26	27–53	54–80	–1	Quasit, badger Has trouble even lifting heavy objects
    //9	0-30	31–60	61–90	–1	 	 
    //10	0-33	34–66	67–100	+0	Human Can literally pull their own weight
    //11	0-38	39–76	77–115	+0	 	 
    //12	0-43	44–86	87–130	+1	Dog, pony, ghoul Carries heavy objects for short distances
    //13	0-50	51–100	101–150	+1	 	 
    //14	0-58	59–116	117–175	+2	Gnoll, dire badger, baboon  Visibly toned, throws small objects for long distances
    //15	0-66	67–133	134–200	+2	 	 
    //16	0-76	77–153	154–230	+3	Black pudding, choker, shark    Carries heavy objects with one arm
    //17	0-86	87–173	174–260	+3	 	 
    //18	0-100	101–200	201–300	+4	Centaur, displacer beast, minotaur  Can break objects like wood with bare hands
    //19	0-116	117–233	234–350	+4	 	 
    //20	0-133	134–266	267–400	+5	Ape, ogre, flesh golem, gorgon  Able to out-wrestle a work animal or catch a falling person
    //21	0-153	154–306	307–460	+5	 	 
    //22	0-173	174–346	347–520	+6	Rhinoceros, ogre destroyer  Can pull very heavy objects at appreciable speeds
    //23	0-200	201–400	401–600	+6	 	 
    //24	0-233	234–466	467–700	+7	Troll berserker Pinnacle of brawn, able to out-lift several people
    //25	0-266	267–533	534–800	+7	Hill giant, marilith demon	 
    //26	0-306	307–613	614–920	+8	 	 
    //27	0-346	347–693	694–1,040	+8	 	 
    //28	0-400	401–800	801–1,200	+9	 	 
    //29	0-466	467–933	934–1,400	+9	 	 
    //30	0-532	533–1,066	1,067–1,600	+10	Fire giant, triceratops, elephant   Amongst the strongest creatures to have ever existed    
    /// <summary>
    /// Initialize the game table.  This is a seperate method so we can create a game table for it;s meta properties
    /// with out creating the table.  A bit of optimiation to conserve memeory
    /// </summary>
    public override void InitializeTable()
    {
        Table =
        [
            //0	0	0	0
            new AbilityBonusStrengthEntry
            {
                Score = new Range(0, 0),
                LightLoad = new Range(0, 0),
                MediumLoad = new Range(0, 0),
                HeavyLoad = new Range(0, 0),
                Modifier = 0,
             },
            //1	0-3	4–6	7–10	–5
            new AbilityBonusStrengthEntry
            {
                Score = new Range(1, 1),
                LightLoad = new Range(0, 3),
                MediumLoad = new Range(4, 6),
                HeavyLoad = new Range(7, 10),
                Modifier = -5,
             },
            //2	0-6	7–13	14–20	–4
            new AbilityBonusStrengthEntry
            {
                Score = new Range(2, 2),
                LightLoad = new Range(0, 6),
                MediumLoad = new Range(7, 13),
                HeavyLoad = new Range(14, 20),
                Modifier = -4,
            },
            //3	0-10	11–20	21–30	–4	 	 
            new AbilityBonusStrengthEntry
            {
                Score = new Range(3, 3),
                LightLoad = new Range(0, 10),
                MediumLoad = new Range(11, 20),
                HeavyLoad = new Range(21, 30),
                Modifier = -4,
            },
            //4	0-13	14–26	27–40	–3
            new AbilityBonusStrengthEntry
            {
                Score = new Range(4, 4),
                LightLoad = new Range(0, 13),
                MediumLoad = new Range(14, 26),
                HeavyLoad = new Range(27, 40),
                Modifier = -3,
            },
            //5	0-16	17–33	34–50	–3	 	 
            new AbilityBonusStrengthEntry
            {
                Score = new Range(5, 5),
                LightLoad = new Range(0, 16),
                MediumLoad = new Range(17, 33),
                HeavyLoad = new Range(34, 50),
                Modifier = -3,
            },
            //6	0-20	21–40	41–60	–2
            new AbilityBonusStrengthEntry
            {
                Score = new Range(6, 6),
                LightLoad = new Range(0, 20),
                MediumLoad = new Range(21, 40),
                HeavyLoad = new Range(41, 60),
                Modifier = -2,
            },
            //7	0-23	24–46	47–70	–2	 	 
            new AbilityBonusStrengthEntry
            {
                Score = new Range(7, 7),
                LightLoad = new Range(0, 23),
                MediumLoad = new Range(24, 46),
                HeavyLoad = new Range(47, 70),
                Modifier = -2,
            },
            //8	0-26	27–53	54–80	–1
            new AbilityBonusStrengthEntry
            {
                Score = new Range(8, 8),
                LightLoad = new Range(0, 26),
                MediumLoad = new Range(27, 53),
                HeavyLoad = new Range(54, 80),
                Modifier = -1,
            },
            //9	0-30	31–60	61–90	–1	 	 
            new AbilityBonusStrengthEntry
            {
                Score = new Range(9, 9),
                LightLoad = new Range(0, 30),
                MediumLoad = new Range(31, 60),
                HeavyLoad = new Range(61, 90),
                Modifier = -1,
            },
            //10	0-33	34–66	67–100	+0
            new AbilityBonusStrengthEntry
            {
                Score = new Range(10, 10),
                LightLoad = new Range(0, 33),
                MediumLoad = new Range(34, 66),
                HeavyLoad = new Range(67, 100),
                Modifier = 0,
            },
            //11	0-38	39–76	77–115	+0	 	 
            new AbilityBonusStrengthEntry
            {
                Score = new Range(11, 11),
                LightLoad = new Range(0, 38),
                MediumLoad = new Range(39, 76),
                HeavyLoad = new Range(77, 115),
                Modifier = 0,
            },
            //12	0-43	44–86	87–130	+1
            new AbilityBonusStrengthEntry
            {
                Score = new Range(12, 12),
                LightLoad = new Range(0, 43),
                MediumLoad = new Range(44, 86),
                HeavyLoad = new Range(87, 130),
                Modifier = 1,
            },
            //13	0-50	51–100	101–150	+1	 	 
            new AbilityBonusStrengthEntry
            {
                Score = new Range(13, 13),
                LightLoad = new Range(0, 50),
                MediumLoad = new Range(51, 100),
                HeavyLoad = new Range(101, 150),
                Modifier = 1,
            },
            //14	0-58	59–116	117–175	+2
            new AbilityBonusStrengthEntry
            {
                Score = new Range(14, 14),
                LightLoad = new Range(0, 50),
                MediumLoad = new Range(59, 116),
                HeavyLoad = new Range(117, 175),
                Modifier = 2,
            },
            //15	0-66	67–133	134–200	+2	 	 
            new AbilityBonusStrengthEntry
            {
                Score = new Range(15, 15),
                LightLoad = new Range(0, 66),
                MediumLoad = new Range(67, 133),
                HeavyLoad = new Range(134, 200),
                Modifier = 2,
            },
            //16	0-76	77–153	154–230	+3
            new AbilityBonusStrengthEntry
            {
                Score = new Range(16, 16),
                LightLoad = new Range(0, 76),
                MediumLoad = new Range(77, 153),
                HeavyLoad = new Range(154, 230),
                Modifier = 3,
            },
            //17	0-86	87–173	174–260	+3	 	 
            new AbilityBonusStrengthEntry
            {
                Score = new Range(17, 17),
                LightLoad = new Range(0, 86),
                MediumLoad = new Range(87, 173),
                HeavyLoad = new Range(174, 260),
                Modifier = 3,
            },
            //18	0-100	101–200	201–300	+4
            new AbilityBonusStrengthEntry
            {
                Score = new Range(18, 18),
                LightLoad = new Range(0, 100),
                MediumLoad = new Range(101, 200),
                HeavyLoad = new Range(201, 300),
                Modifier = 4,
            },
            //19	0-116	117–233	234–350	+4	 	 
            new AbilityBonusStrengthEntry
            {
                Score = new Range(19, 19),
                LightLoad = new Range(0, 116),
                MediumLoad = new Range(117, 233),
                HeavyLoad = new Range(234, 350),
                Modifier = 4,
            },
            //20	0-133	134–266	267–400	+5
            new AbilityBonusStrengthEntry
            {
                Score = new Range(20, 20),
                LightLoad = new Range(0, 133),
                MediumLoad = new Range(134, 266),
                HeavyLoad = new Range(267, 400),
                Modifier = 5,
            },
            //21	0-153	154–306	307–460	+5	 	 
            new AbilityBonusStrengthEntry
            {
                Score = new Range(21, 21),
                LightLoad = new Range(0, 153),
                MediumLoad = new Range(154, 306),
                HeavyLoad = new Range(307, 460),
                Modifier = 5,
            },
            //22	0-173	174–346	347–520	+6
            new AbilityBonusStrengthEntry
            {
                Score = new Range(22, 22),
                LightLoad = new Range(0, 173),
                MediumLoad = new Range(174, 346),
                HeavyLoad = new Range(347, 520),
                Modifier = 6,
            },
            //23	0-200	201–400	401–600	+6	 	 
            new AbilityBonusStrengthEntry
            {
                Score = new Range(23, 23),
                LightLoad = new Range(0, 200),
                MediumLoad = new Range(201, 400),
                HeavyLoad = new Range(401, 600),
                Modifier = 6,
            },
            //24	0-233	234–466	467–700	+7
            new AbilityBonusStrengthEntry
            {
                Score = new Range(24, 24),
                LightLoad = new Range(0, 233),
                MediumLoad = new Range(234, 466),
                HeavyLoad = new Range(467, 700),
                Modifier = 7,
            },
            //25	0-266	267–533	534–800	+7
            new AbilityBonusStrengthEntry
            {
                Score = new Range(25, 25),
                LightLoad = new Range(0, 266),
                MediumLoad = new Range(267, 533),
                HeavyLoad = new Range(534, 800),
                Modifier = 7,
            },
            //26	0-306	307–613	614–920	+8	 	 
            new AbilityBonusStrengthEntry
            {
                Score = new Range(26, 26),
                LightLoad = new Range(0, 266),
                MediumLoad = new Range(267, 533),
                HeavyLoad = new Range(534, 800),
                Modifier = 8,
            },
            //27	0-346	347–693	694–1,040	+8	 	 
            new AbilityBonusStrengthEntry
            {
                Score = new Range(27, 27),
                LightLoad = new Range(0, 346),
                MediumLoad = new Range(347, 693),
                HeavyLoad = new Range(694, 1040),
                Modifier = 8,
            },
            //28	0-400	401–800	801–1,200	+9	 	 
            new AbilityBonusStrengthEntry
            {
                Score = new Range(28, 28),
                LightLoad = new Range(0, 400),
                MediumLoad = new Range(401, 800),
                HeavyLoad = new Range(801, 1200),
                Modifier = 9,
            },
            //29	0-466	467–933	934–1,400	+9	 	 
            new AbilityBonusStrengthEntry
            {
                Score = new Range(29, 29),
                LightLoad = new Range(0, 466),
                MediumLoad = new Range(467, 933),
                HeavyLoad = new Range(934, 1400),
                Modifier = 9,
            },
            //30	0-532	533–1,066	1,067–1,600	+10    
            new AbilityBonusStrengthEntry
            {
                Score = new Range(30, 30),
                LightLoad = new Range(0, 532),
                MediumLoad = new Range(533, 1066),
                HeavyLoad = new Range(1067, 1600),
                Modifier = 10,
            },
        ];
    }
}