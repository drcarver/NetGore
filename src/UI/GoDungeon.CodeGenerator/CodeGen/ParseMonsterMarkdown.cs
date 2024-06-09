using System.Diagnostics;

using GoDungeon.CodeGenerator.CodeGen;
using GoDungeon.Core.Abilities;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Models;
using GoDungeon.Core.ViewModels;
using GoDungeon.Monsters.ViewModels;

namespace GoDungeon.CommandLineTools.CodeGen;

public partial class ParseMarkdown
{
    /// <summary>
    /// Get the monster from the markDown file
    /// </summary>
    public ICreature? ParseMonster(List<string> markDown)
    {
        var monsterInfo = GetMonsterInfo(markDown);
        MonsterInfoList.Add(monsterInfo);
        if (MonsterLists.IsWere(monsterInfo))
        {
            return null;
        }
        var creature = CreateCreature(monsterInfo);
        GetSizeRaceType(markDown, creature);
        GetMonsterAbilities(markDown, creature);
        GetMonsterArmorClass(markDown, creature);
        GetMonsterHitPoints(markDown, creature);
        GetMonsterSpeed(markDown, creature);
        CreatureList.Add(creature);
        return creature;
    }

    /// <summary>
    /// Get the monster speed
    /// </summary>
    /// <param name="markDown">The markdown file for the monster</param>
    /// <param name="creature">The creature being created from the markdown</param>
    private void GetMonsterSpeed(List<string> markDown, ICreature creature)
    {
        for (int i = 0; i < markDown.Count(); i++)
        {
            if (markDown[i].StartsWith("**Speed**"))
            {
                string rawSpeed = markDown[i].Replace("**Speed**", string.Empty).Replace("ft", " ft").Trim();
                string[] movements = rawSpeed.Split(',');

                // Get the movement speeds
                for (int s = 0; s < movements.Length; s++)
                {
                    int speed = 0;
                    int lparens = movements[s].Trim().IndexOf('(');
                    int rparens = movements[s].Trim().IndexOf(')');
                    string[] rawMovementWithSpace;
                    string modifier = string.Empty;
                    if (lparens > 0 && rparens > 0)
                    {
                        int modifierLength = rparens - lparens + 2;
                        if (modifierLength + lparens > movements[s].Length)
                        {
                            modifierLength -= 1;
                        }
                        modifier = movements[s].Substring(lparens, modifierLength);
                        movements[s] = movements[s].Substring(0, lparens - 1);
                    }
                    rawMovementWithSpace = movements[s].Trim().Split(' ');
                    List<string> rawMovement = new List<string>();
                    for (int r = 0; r < rawMovementWithSpace.Length; r++)
                    {
                        if (!string.IsNullOrEmpty(rawMovementWithSpace[r].Trim()))
                        {
                            rawMovement.Add(rawMovementWithSpace[r].Trim());
                        }
                    }
                    if (rawMovement.Count() == 2)
                    {
                        MovementRateEnum movementRateEnum;
                        if (!Enum.TryParse(rawMovement[1].Replace(".", string.Empty).Trim(), true, out movementRateEnum))
                        {
                            Debug.WriteLine($"Unknown MovementRateEnum {rawMovement[1]}");
                        }
                        if (int.TryParse(rawMovement[0].Trim(), out speed))
                        {
                            creature.Speed.Add(new MovementViewModel
                            {
                                Speed = speed,
                                MovementType = MovementEnum.Normal,
                                MovementRate = movementRateEnum,
                                MovementModifier = modifier
                            });
                        }
                    }
                    if (rawMovement.Count() == 3)
                    {
                        MovementEnum movementEnum;
                        MovementRateEnum movementRateEnum;
                        if (!Enum.TryParse<MovementEnum>(rawMovement[0], true, out movementEnum))
                        {
                            Debug.WriteLine($"Unknown MovementEnum {rawMovement[0]}");
                        }
                        if (!Enum.TryParse<MovementRateEnum>(rawMovement[2].Replace(".", string.Empty).Trim(), true, out movementRateEnum))
                        {
                            Debug.WriteLine($"Unknown MovementRateEnum {rawMovement[2]}");
                        }
                        if (int.TryParse(rawMovement[1], out speed))
                        {
                            creature.Speed.Add(new MovementViewModel
                            {
                                Speed = speed,
                                MovementType = movementEnum,
                                MovementRate = movementRateEnum,
                                MovementModifier = modifier
                            });
                        }
                        if (modifier != string.Empty && speed == 0)
                        {
                            creature.Speed.Add(new MovementViewModel
                            {
                                MovementModifier = modifier
                            });
                        }
                    }
                }
                markDown.RemoveAt(i);
                return;
            }
        }
    }

    /// <summary>
    /// Create a creature based on the monster info
    /// </summary>
    /// <param name="The monster info to create the creature from."></param>
    private ICreature CreateCreature(MonsterInfoViewModel monsterInfo)
    {
        return ServiceProvider.GetRequiredService<ICreature>();
        //IHumanoidRaceFactory humanoidRaceFactory = new RaceFactory(); 
    }

    /// <summary>
    /// Get the monster armor class
    /// </summary>
    /// <param name="markDown">The markdown file for the monster</param>
    /// <param name="creature">The creature being created from the markdown</param>
    private void GetMonsterArmorClass(List<string> markDown, ICreature creature)
    {
        for (int i = 0; i < markDown.Count(); i++)
        {
            if (markDown[i].StartsWith("**Armor Class**"))
            {
                string rawArmorClass = markDown[i].Replace("**Armor Class**", string.Empty).Trim();
                int leftParen = rawArmorClass.IndexOf('(');
                int rightParen = rawArmorClass.IndexOf(')');
                string armorType = string.Empty;

                if (creature.Name.ToLower().Trim().StartsWith("were"))
                {
                    return;
                }

                // Get the armor class
                int armorClass;
                if (leftParen > 0)
                {
                    int.TryParse(rawArmorClass.Substring(0, leftParen - 1).Trim(), out armorClass);
                }
                else
                {
                    int.TryParse(rawArmorClass, out armorClass);
                }
                creature.ArmorClass = new ArmorClassViewModel();
                if (leftParen > 0)
                {
                    armorType = rawArmorClass.Substring(leftParen + 1, rightParen - leftParen - 1).Trim();
                }
                if (armorType != string.Empty)
                {
                    switch (armorType)
                    {
                        case "natural armor":
                            creature.ArmorClass.ArmorAndShield = (int)ArmorAndShieldEnum.Natural;
                            break;
                        case "scale mail":
                        case "splint":
                        case "breastplate":
                        case "patchwork armor":
                        case "scale mail, shield":
                        case "barding scraps":
                        case "chain mail, shield":
                        case "chain mail":
                        case "chain shirt":
                        case "chain shirt, shield":
                        case "hide armor":
                        case "hide armor, shield":
                        case "plate":
                        case "leather armor":
                        case "leather armor, shield":
                        case "studded leather":
                        case "studded leather, shield":
                        case "16 with barkskin":
                        case "15 with mage armor":
                        case "armor scraps":
                            break;
                        case "natural armor, shield":
                            creature.ArmorClass.ArmorAndShield = (int) ArmorAndShieldEnum.Natural;
                            creature.ArmorClass.ShieldBonus = 1;
                            break;
                        default:
                            break;
                    }
                }
                markDown.RemoveAt(i);
                return;
            }
        }
    }

    /// <summary>
    /// Get the monster hit points
    /// </summary>
    /// <param name="markDown">The markdown file for the monster</param>
    /// <param name="creature">The creature being created from the markdown</param>
    private void GetMonsterHitPoints(List<string> markDown, ICreature creature)
    {
        for (int i = 0; i < markDown.Count(); i++)
        {
            if (markDown[i].StartsWith("**Hit Points**"))
            {
                string rawHitPoints = markDown[i].Replace("**Hit Points**", string.Empty).Trim();
                int leftParen = rawHitPoints.IndexOf('(');
                int rightParen = rawHitPoints.IndexOf(')');
                int hitPoints;
                if (leftParen > 0)
                {
                    int.TryParse(rawHitPoints.Substring(0, leftParen - 1), out hitPoints);
                    creature.HitPoints = new HitPointsViewModel(hitPoints, creature);
                }
                else
                {
                    int.TryParse(rawHitPoints, out hitPoints);
                    creature.HitPoints = new HitPointsViewModel(hitPoints, creature);
                }
                string hitDice = string.Empty;
                if (leftParen > 0)
                {
                    hitDice = rawHitPoints.Substring(leftParen + 1, rightParen - leftParen - 1);
                    creature.HitPoints = new HitPointsViewModel(hitDice, creature);
                    int total = 0;
                    for (int j = 0; j < creature.HitPoints.LevelDice.Count(); j++)
                    {
                        total += creature.HitPoints.LevelDice[j];
                    }
                }
                else
                {
                    creature.HitPoints = new HitPointsViewModel(hitPoints, creature);
                }

                markDown.RemoveAt(i);
            }
        }
    }

    /// <summary>
    /// Decode the monsterInfo from the start of the file
    /// </summary>
    /// <param name="markDown">The markdown file for the monster</param>
    private MonsterInfoViewModel GetMonsterInfo(List<string> markDown)
    {
        MonsterInfoViewModel monsterInfo = new MonsterInfoViewModel();
        for (int i = 0; i < markDown.Count(); i++)
        {
            var fields = markDown[i].Split(':');
            if (fields.Count() != 2)
            {
                continue;
            }

            if (fields[0].Trim() == "name")
            {
                monsterInfo.Name = Utilities.CleanupForCSharp(fields[1].Trim());
                monsterInfo.ProperName = fields[1].Trim();
            }

            if (fields[0].Trim() == "type")
            {
                RaceTypeEnum raceType;
                Enum.TryParse(fields[1].Trim(), true, out raceType);
                monsterInfo.RaceType = raceType;
                continue;
            }

            if (fields[0].Trim() == "cr")
            {
                monsterInfo.ChallengeRating = Convert.ToDecimal(fields[1].Trim());
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

        return monsterInfo;
    }

    /// <summary>
    /// Get  the size, race type, race sub type and alignment
    /// </summary>
    /// <param name="markDown">The markdown file for the monster</param>
    /// <param name="creature">The creature being created from the markdown</param>
    private void GetSizeRaceType(List<string> markDown, ICreature creature)
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

            creature.ProperName = markDown[i].Trim().Replace("# ", string.Empty);
            creature.Name = Utilities.CleanupForCSharp(markDown[i].Trim().Replace("# ", string.Empty));

            #region Size
            // Get the size first.
            SizeEnum sizeEnum;
            string rawSizeEnum = markDown[i + 1].Substring(1, spacePosition - 1);
            if (Enum.TryParse(rawSizeEnum, true, out sizeEnum))
            {
                creature.Size = sizeEnum;
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
                creature.RaceType = raceTypeEnum;
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
                    creature.RaceSubType.Add(raceSubTypeEnum);
                }
                else
                {
                    switch (rawRaceSubTypeEnum.Trim())
                    {
                        case "any race":
                            creature.RaceSubType.Add(RaceSubTypeEnum.Any);
                            break;
                        case "devil, shapechanger":
                            creature.RaceSubType.Add(RaceSubTypeEnum.Devil);
                            creature.RaceSubType.Add(RaceSubTypeEnum.Shapechanger);
                            break;
                        case "demon, shapechanger":
                            creature.RaceSubType.Add(RaceSubTypeEnum.Demon);
                            creature.RaceSubType.Add(RaceSubTypeEnum.Shapechanger);
                            break;
                        case "human, shapechanger":
                            creature.RaceSubType.Add(RaceSubTypeEnum.Human);
                            creature.RaceSubType.Add(RaceSubTypeEnum.Shapechanger);
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
                creature.Alignment = alignmentEnum;
            }
            else
            {
                switch (rawAlignment.Trim())
                {
                    case "any non-lawful alignment":
                        creature.Alignment = AlignmentEnum.AnyNonLawful;
                        break;
                    case "any non-good alignment":
                        creature.Alignment = AlignmentEnum.AnyNonGood;
                        break;
                    case "any evil alignment":
                        creature.Alignment = AlignmentEnum.AnyEvil;
                        break;
                    case "any chaotic alignment":
                        creature.Alignment = AlignmentEnum.AnyChaotic;
                        break;
                    // Cloud giants only.  
                    case "neutral good (50%) or neutral evil (50%)":
                        creature.Alignment = AlignmentEnum.NeutralGoodOrNeutralEvil;
                        break;
                    case "any alignment":
                        creature.Alignment = AlignmentEnum.Any;
                        break;
                    case "unaligned":
                        creature.Alignment = AlignmentEnum.UnAligned;
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
    /// <param name="markDown">The markdown file for the monster</param>
    /// <param name="creature">The creature being created from the markdown</param>
    private void GetMonsterAbilities(List<string> markDown, ICreature creature)
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
                        creature.Strength = new Strength(str, creature);
                        break;
                    case "DEX":
                        int dex;
                        int.TryParse(abilities[h].Trim().Substring(0, 2), out dex);
                        creature.Dexterity = new Dexterity(dex, creature);
                        break;
                    case "CON":
                        int con;
                        int.TryParse(abilities[h].Trim().Substring(0, 2), out con);
                        creature.Constitution = new Constitution(con, creature);
                        break;
                    case "INT":
                        int Int;
                        int.TryParse(abilities[h].Trim().Substring(0, 2), out Int);
                        creature.Intelligence = new Intelligence(Int, creature);
                        break;
                    case "WIS":
                        int wis;
                        int.TryParse(abilities[h].Trim().Substring(0, 2), out wis);
                        creature.Wisdom = new Wisdom(wis, creature);
                        break;
                    case "CHA":
                        int cha;
                        int.TryParse(abilities[h].Trim().Substring(0, 2), out cha);
                        creature.Charisma = new Charisma(cha, creature);
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
