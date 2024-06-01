
using System.Security.Cryptography.X509Certificates;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.CommandLineTools.CodeGen;

internal static class GenerateMonster
{
    /// <summary>
    /// Generate the class header
    /// </summary>
    /// <param name="filePath">Path to the file</param>
    internal static void GenerateHeader(TextWriter stream)
    {
        stream.WriteLine($"// {Program.Creature.ProperName}");
        stream.WriteLine("//");
        stream.WriteLine("using GoDungeon.Core.Enum;");
        stream.WriteLine("using GoDungeon.Core.ViewModels;");
        stream.WriteLine();
        stream.WriteLine("using Microsoft.Extensions.Logging;");
        stream.WriteLine();
        stream.WriteLine($"namespace GoDungeon.Monsters;");
        stream.WriteLine();
        stream.WriteLine($"public partial class {Program.Creature.Name} : CreatureViewModel");
        stream.WriteLine("{");
        stream.WriteLine($"\t/// <summary>");
        stream.WriteLine($"\t/// Constructor");
        stream.WriteLine($"\t/// </summary>");
        stream.WriteLine($"\t/// <param name=\"services\">The collection of services from the DI</param>");
        stream.WriteLine($"\t/// <param name=\"logger\">The logger factory from the DI</param>");
        stream.WriteLine($"\tpublic {Program.Creature.Name}(");
        stream.WriteLine("\t\tIServiceProvider services,");
        stream.WriteLine("\t\tILoggerFactory logger)");
        stream.WriteLine("\t\t: base(services, logger)");
        stream.WriteLine("\t{");
        stream.WriteLine($"\t\tName = nameof({Program.Creature.Name});");
        stream.WriteLine($"\t\tProperName = \"{Program.Creature.ProperName}\";");
        stream.WriteLine($"\t\tRaceType = RaceTypeEnum.{Program.Creature.RaceType};");
        foreach (var subType in Program.Creature.RaceSubType)
        {
            stream.WriteLine($"\t\tRaceSubType.Add(RaceSubTypEnum.{subType});");
        }
        stream.WriteLine($"\t\tChallengeRating = {Program.Creature.ChallengeRating};");
        //stream.WriteLine($"\t\tExperiencePoints = {Program.Creature.ExperiencePoints}");
        stream.WriteLine();
        stream.WriteLine("\t\t// Abilities");
        stream.WriteLine($"\t\tStrength = new Strength(this, {Program.Creature.Strength.Score});");
        stream.WriteLine($"\t\tIntelligence = new Intelligence(this, {Program.Creature.Intelligence.Score});");
        stream.WriteLine($"\t\tWisdom = new Wisdom(this, {Program.Creature.Wisdom.Score});");
        stream.WriteLine($"\t\tDexterity = new Dexterity(this, {Program.Creature.Dexterity.Score});");
        stream.WriteLine($"\t\tConstitution = new Constitution(this, {Program.Creature.Constitution.Score});");
        stream.WriteLine($"\t\tCharisma = new Charisma(this, {Program.Creature.Charisma.Score});");
        stream.WriteLine("\t}");
        stream.WriteLine("}");
    }

    /// <summary>
    /// Generate the associated enums and lists from the full creature lists
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    internal static void GenerateLists()
    {
        GenerateEnum();
    }

    /// <summary>
    /// Generate the MonsterEnum
    /// </summary>
    private static void GenerateEnum()
    {
        // Convert the monsterlist to a .cs enum
        var monsterEnumFile = $@"{{MONSTERROOT/enum/MonsterEnum.cs";
        using (StreamWriter writer = File.CreateText(monsterEnumFile))
        {
            writer.WriteLine("//");
            writer.WriteLine($"// The monster enumeration");
            writer.WriteLine("//");
            writer.WriteLine();
            writer.WriteLine("namespace GoDungeon.Monsters.Enum");
            writer.WriteLine("{");
            writer.WriteLine();
            writer.WriteLine("public enum MonsterEnum : int");
            writer.WriteLine("{");
            for (int i = 0; i < ParseMarkdown.CreatureList.Count; i++)
            {
                writer.WriteLine($"\t{ParseMarkdown.CreatureList[i].Name} = {i},");
            }
            writer.WriteLine("}");
        }
    }
}