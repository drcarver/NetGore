using GoDungeon.Core.Abilities;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.CommandLineTools.CodeGen;

internal class ParseMarkdown
{
    /// <summary>
    /// The monster information
    /// </summary>
    internal static ICreature? Creature { get; set; } = new CreatureViewModel();

    /// <summary>
    /// Get the monster from the markDown file
    /// </summary>
    internal static void ParseMonster(List<string> markDown)
    {
        GetMonsterInfo(markDown);
        //GetSizeRaceType(markDown);
        GetAbilities(markDown);
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
    //private static void GetSizeRaceType(List<string> markDown)
    //{
    //    #region Size
    //    // Get the size first.
    //    SizeEnum sizeEnum;
    //    int spacePosition = markdownLine.IndexOf(' ');
    //    string rawSizeEnum = markdownLine.Substring(1, spacePosition - 1);
    //    if (Enum.TryParse(rawSizeEnum, true, out sizeEnum))
    //    {
    //        Program.Creature.Size = sizeEnum;
    //    }
    //    else
    //    {
    //        Console.WriteLine($"Failed to convert {rawSizeEnum} to a SizeEnum");
    //    }
    //    #endregion

    //    #region RaceType
    //    // Next the RaceType.
    //    RaceTypeEnum raceTypeEnum;
    //    string rawRaceTypeEnum;
    //    int commaPosition = markdownLine.IndexOf(',');
    //    int leftParenPosition = markdownLine.IndexOf('(');
    //    int rightParenPosition = markdownLine.IndexOf(')');
    //    if (leftParenPosition > 0)
    //    {
    //        rawRaceTypeEnum = markdownLine.Substring(spacePosition, leftParenPosition - 1);
    //    }
    //    else
    //    {
    //        rawRaceTypeEnum = markdownLine.Substring(spacePosition, commaPosition - 1);
    //    }
    //    if (Enum.TryParse(rawRaceTypeEnum, true, out raceTypeEnum))
    //    {
    //        Program.Creature.RaceType = raceTypeEnum;
    //    }
    //    else
    //    {
    //        Console.WriteLine($"Failed to convert {rawRaceTypeEnum} to a RaceTypeEnum");
    //    }
    //    #endregion
    //}

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
