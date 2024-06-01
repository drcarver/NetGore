using System.Diagnostics.Eventing.Reader;

using GoDungeon.Core.Abilities;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.CommandLineTools.CodeGen;

internal class ParseMarkdown
{
    /// <summary>
    /// Constructor
    /// </summary>
    internal ParseMarkdown()
    {
        AlignmentTable.InitializeTable();
    }

    /// <summary>
    /// The monster information
    /// </summary>
    internal static ICreature? Creature { get; set; } = new CreatureViewModel();
    internal static List<ICreature> CreatureList { get; set; } = new List<ICreature>();

    /// <summary>
    /// Get the monster from the markDown file
    /// </summary>
    internal static void ParseMonster(List<string> markDown)
    {
        Program.Creature = new CreatureViewModel();
        GetMonsterInfo(markDown);
        GetSizeRaceType(markDown);
        GetAbilities(markDown);
        CreatureList.Add(Program.Creature);
    }

    /// <summary>
    /// Decode the monsterInfo from the start of the file
    /// </summary>
    /// <param name="markDown">The lines in the file</param>
    private static void GetMonsterInfo(List<string> markDown)
    {
        for (int i = 0; i < markDown.Count(); i++)
        {
            var fields = markDown[i].Split(':');
            if (fields.Count() != 2)
            {
                continue;
            }

            if (fields[0].Trim() == "name")
            {
                Program.Creature.Name = Utilities.CleanupForCSharp(fields[1].Trim());
                Program.Creature.ProperName = fields[1].Trim();
            }

            if (fields[0].Trim() == "type")
            {
                RaceTypeEnum raceType;
                Enum.TryParse(fields[1].Trim(), true, out raceType);
                Program.Creature.RaceType = raceType;
                continue;
            }
            
            if (fields[0].Trim() == "cr")
            {
                Program.Creature.ChallengeRating = Convert.ToDecimal(fields[1].Trim());
                continue;
            }
        }

        // Remove the top 3 lines that have the info
        markDown.RemoveAt(0);
        markDown.RemoveAt(0);
        markDown.RemoveAt(0);
        
        // eliminate all the blank lines at the beginning
        do
        {
            markDown.RemoveAt(0);
        } while (string.IsNullOrEmpty(markDown[0].TrimEnd()));
    }

    /// <summary>
    /// Get  the size, race type, race sub type and alignment
    /// </summary>
    /// <param name="markDown">The text from the markdown file.</param>
    /// <param name="writer">The TextWriter</param>
    private static void GetSizeRaceType(List<string> markDown)
    {
        for (int i = 0; i < markDown.Count; i++)
        {
            // Find the first header
            if (!markDown[i].TrimStart().StartsWith("# "))
            {
                continue;
            }
            int commaPosition = markDown[i + 1].IndexOf(',');
            int leftParenPosition = markDown[i + 1].IndexOf('(');
            int rightParenPosition = markDown[i + 1].IndexOf(')');
            // subrace type has multiple members
            if (commaPosition < rightParenPosition && commaPosition > leftParenPosition)
            {
                commaPosition = markDown[i + 1].LastIndexOf(",");
            }

            int spacePosition = markDown[i + 1].IndexOf(' ');
            if (leftParenPosition > commaPosition)
            {
                leftParenPosition = -1;
                rightParenPosition = -1;
            }

            Program.Creature.ProperName = markDown[i].Trim().Replace("# ", string.Empty);
            Program.Creature.Name = Utilities.CleanupForCSharp(markDown[i].Trim().Replace("# ", string.Empty));

            #region Size
            // Get the size first.
            SizeEnum sizeEnum;
            string rawSizeEnum = markDown[i + 1].Substring(1, spacePosition - 1);
            if (Enum.TryParse(rawSizeEnum, true, out sizeEnum))
            {
                Program.Creature.Size = sizeEnum;
            }
            else
            {
                Console.WriteLine($"Failed to convert {rawSizeEnum} to a SizeEnum");
            }
            #endregion

            #region RaceType
            // Next the RaceType.
            RaceTypeEnum raceTypeEnum;
            string rawRaceTypeEnum;
            if (leftParenPosition > 0)
            {
                rawRaceTypeEnum = markDown[i + 1].Substring(spacePosition, leftParenPosition - spacePosition).Trim();
            }
            else 
            {
                rawRaceTypeEnum = markDown[i + 1].Substring(spacePosition, commaPosition - spacePosition).Trim();
            }
            if (Enum.TryParse(Utilities.CleanupForCSharp(rawRaceTypeEnum), true, out raceTypeEnum))
            {
                Program.Creature.RaceType = raceTypeEnum;
            }
            else
            {
                Console.WriteLine($"Failed to convert {rawRaceTypeEnum} to a RaceTypeEnum");
            }
            #endregion

            #region RaceSubType
            // Next the RaceSubType.
            RaceSubTypeEnum raceSubTypeEnum;
            string rawRaceSubTypeEnum;
            if (leftParenPosition > 0)
            {
                rawRaceSubTypeEnum = markDown[i + 1].Substring(leftParenPosition + 1, rightParenPosition - leftParenPosition - 1);
                if (Enum.TryParse(rawRaceSubTypeEnum, true, out raceSubTypeEnum) && !rawRaceSubTypeEnum.Contains(","))
                {
                    Program.Creature.RaceSubType.Add(raceSubTypeEnum);
                }
                else
                {
                    switch (rawRaceSubTypeEnum.Trim())
                    {
                        case "any race":
                            Program.Creature.RaceSubType.Add(RaceSubTypeEnum.Any);
                            break;
                        case "devil, shapechanger":
                            Program.Creature.RaceSubType.Add(RaceSubTypeEnum.Devil);
                            Program.Creature.RaceSubType.Add(RaceSubTypeEnum.Shapechanger);
                            break;
                        case "demon, shapechanger":
                            Program.Creature.RaceSubType.Add(RaceSubTypeEnum.Demon);
                            Program.Creature.RaceSubType.Add(RaceSubTypeEnum.Shapechanger);
                            break;
                        case "human, shapechanger":
                            Program.Creature.RaceSubType.Add(RaceSubTypeEnum.Human);
                            Program.Creature.RaceSubType.Add(RaceSubTypeEnum.Shapechanger);
                            break;
                        default:
                            Console.WriteLine($"Failed to convert {rawRaceSubTypeEnum} to a RaceSubTypeEnum");
                            break;
                    }
                }
            }
            #endregion

            #region Alignment
            int lastUnder = markDown[i + 1].LastIndexOf("_");
            string rawAlignment = markDown[i + 1].Substring(commaPosition + 1, lastUnder - commaPosition - 1);
            AlignmentEnum alignmentEnum;
            if (Enum.TryParse(Utilities.CleanupForCSharp(rawAlignment.Trim()), true, out alignmentEnum))
            {
                Program.Creature.Alignment = alignmentEnum;
            }
            else
            {
                switch (rawAlignment.Trim())
                { 
                    case "any non-lawful alignment":
                        Program.Creature.Alignment = AlignmentEnum.AnyNonLawful;
                        break;
                    case "any non-good alignment":
                        Program.Creature.Alignment = AlignmentEnum.AnyNonGood;
                        break;
                    case "any evil alignment":
                        Program.Creature.Alignment = AlignmentEnum.AnyEvil;
                        break;
                    case "any chaotic alignment":
                        Program.Creature.Alignment = AlignmentEnum.AnyChaotic;
                        break;
                    // Cloud giants only.  
                    case "neutral good (50%) or neutral evil (50%)":
                        Program.Creature.Alignment = AlignmentEnum.NeutralGoodOrNeutralEvil;
                        break;
                    case "any alignment":
                        Program.Creature.Alignment = AlignmentEnum.Any;
                        break;
                    case "unaligned":
                        Program.Creature.Alignment = AlignmentEnum.UnAligned;
                        break;
                    default:
                        Console.WriteLine($"Unknown Alignment={rawAlignment}");
                        break;
                }
            }
            #endregion
            // Remove th two lines just parsed
            markDown.RemoveAt(i);
            markDown.RemoveAt(i);
        }
    }

    /// <summary>
    /// Generate abilities
    /// </summary>
    /// <param name="markdownLines">The markdown file</param>
    /// <param name="writer">The TextWriter</param>
    private static void GetAbilities(List<string> markDown)
    {
        for (int i = 0; i < markDown.Count(); i++)
        {
            if (!markDown[i].TrimStart().StartsWith("|"))
            {
                continue;
            }

            var abilities = markDown[i + 2].Split('|');
            var header = markDown[i].Split('|');
            for (int h = 0; h < header.Length; h++)
            {
                switch (header[h].Trim())
                {
                    case "STR":
                        int str;
                        int.TryParse(abilities[h].Trim().Substring(0, 2), out str);
                        Program.Creature.Strength = new Strength(str, Program.Creature);
                        break;
                    case "DEX":
                        int dex;
                        int.TryParse(abilities[h].Trim().Substring(0, 2), out dex);
                        Program.Creature.Dexterity = new Dexterity(dex, Program.Creature);
                        break;
                    case "CON":
                        int con;
                        int.TryParse(abilities[h].Trim().Substring(0, 2), out con);
                        Program.Creature.Constitution = new Constitution(con, Program.Creature);
                        break;
                    case "INT":
                        int Int;
                        int.TryParse(abilities[h].Trim().Substring(0, 2), out Int);
                        Program.Creature.Intelligence = new Intelligence(Int, Program.Creature);
                        break;
                    case "WIS":
                        int wis;
                        int.TryParse(abilities[h].Trim().Substring(0, 2), out wis);
                        Program.Creature.Wisdom = new Wisdom(wis, Program.Creature);
                        break;
                    case "CHA":
                        int cha;
                        int.TryParse(abilities[h].Trim().Substring(0, 2), out cha);
                        Program.Creature.Charisma = new Charisma(cha, Program.Creature);
                        break;
                }
            }
            markDown.RemoveAt(i + 2);
            markDown.RemoveAt(i + 1);
            markDown.RemoveAt(i);
            break;
        }
    }
}
