using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.Core.Interfaces;
using GoDungeon.Monsters.ViewModels;

namespace GoDungeon.CodeGenerator.CodeGen;

public class GenerateMonster : IGenerateMonster
{
    /// <summary>
    /// Constructor
    /// </summary>
    public GenerateMonster() 
    {
    }

    /// <summary>
    /// Generate the .cs class for the monster
    /// </summary>
    /// <param name="stream">The monster file stream</param>
    /// <param name="creature">THe creature to generate</param>
    public void GenerateMonsterClass(TextWriter stream, ICreature creature, string rootdir)
    {
        GenerateHeader(stream, creature);
        GenerateInterfaceFile(stream, creature, rootdir);
        GenerateLists();
    }

    /// <summary>
    /// Generate the class header
    /// </summary>
    /// <param name="stream">The monster file stream</param>
    /// <param name="creature">THe creature to generate</param>
    private void GenerateHeader(TextWriter stream, ICreature creature)
    {
        stream.WriteLine($"// {creature.ProperName}");
        stream.WriteLine("//");
        stream.WriteLine("using GoDungeon.Core.Enum;");
        stream.WriteLine("using GoDungeon.Core.ViewModels;");
        stream.WriteLine();
        stream.WriteLine("using Microsoft.Extensions.Logging;");
        stream.WriteLine();
        stream.WriteLine($"namespace GoDungeon.Monsters;");
        stream.WriteLine();
        stream.WriteLine($"public partial class {creature.Name} : CreatureViewModel");
        stream.WriteLine("{");
        stream.WriteLine($"\t/// <summary>");
        stream.WriteLine($"\t/// Constructor");
        stream.WriteLine($"\t/// </summary>");
        stream.WriteLine($"\t/// <param name=\"services\">The collection of services from the DI</param>");
        stream.WriteLine($"\t/// <param name=\"logger\">The logger factory from the DI</param>");
        stream.WriteLine($"\tpublic {creature.Name}(");
        stream.WriteLine("\t\tIServiceProvider services,");
        stream.WriteLine("\t\tILoggerFactory logger)");
        stream.WriteLine("\t\t: base(services, logger)");
        stream.WriteLine("\t{");
        stream.WriteLine($"\t\tName = nameof({creature.Name});");
        stream.WriteLine($"\t\tProperName = \"{creature.ProperName}\";");
        stream.WriteLine($"\t\tRaceType = RaceTypeEnum.{creature.RaceType};");
        foreach (var subType in creature.RaceSubType)
        {
            stream.WriteLine($"\t\tRaceSubType.Add(RaceSubTypEnum.{subType});");
        }
        stream.WriteLine($"\t\tChallengeRating = {creature.ChallengeRating};");
        //stream.WriteLine($"\t\tExperiencePoints = {creature.ExperiencePoints}");
        stream.WriteLine();
        stream.WriteLine("\t\t// Abilities");
        stream.WriteLine($"\t\tStrength = new Strength(this, {creature.Strength.Score});");
        stream.WriteLine($"\t\tIntelligence = new Intelligence(this, {creature.Intelligence.Score});");
        stream.WriteLine($"\t\tWisdom = new Wisdom(this, {creature.Wisdom.Score});");
        stream.WriteLine($"\t\tDexterity = new Dexterity(this, {creature.Dexterity.Score});");
        stream.WriteLine($"\t\tConstitution = new Constitution(this, {creature.Constitution.Score});");
        stream.WriteLine($"\t\tCharisma = new Charisma(this, {creature.Charisma.Score});");
        stream.WriteLine("\t}");
        stream.WriteLine("}");
    }

    /// <summary>
    /// Generate the associated enum and lists from the full creature lists
    /// </summary>
    private void GenerateLists()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="creature"></param>
    private void GenerateInterfaceFile(TextWriter stream, ICreature creature, string rootdir)
    {
        // Convert the file to a .cs interface
        var interfaceFile = $@"{rootdir}Interfaces/I{creature.Name}.cs";
        using (StreamWriter writer = File.CreateText(interfaceFile))
        {
            writer.WriteLine("//");
            writer.WriteLine($"// {creature.ProperName}.");
            writer.WriteLine("//");
            writer.WriteLine("using GoDungeon.Core.Interfaces;");
            writer.WriteLine();
            writer.WriteLine("namespace GoDungeon.Monsters.Interfaces");
            writer.WriteLine("{");
            writer.WriteLine("\t/// <summary>");
            writer.WriteLine($"\t/// {creature.ProperName}.");
            writer.WriteLine($"\t/// </summary>");
            writer.WriteLine($"\tpublic interface I{creature.Name} : ICreature");
            writer.WriteLine("\t{");
            writer.WriteLine("\t}");
            writer.WriteLine("}");
        }
    }

    /// <summary>
    /// Generate the MonsterEnum
    /// </summary>
    private void GenerateEnum(List<MonsterInfoViewModel> monsterInfoList, string rootdir)
    {
        // Convert the monster list to a .cs enum
        var monsterEnumFile = $@"{rootdir}enum/MonsterEnum.cs";
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
            for (int i = 0; i < monsterInfoList.Count(); i++)
            {
                writer.WriteLine($"\t{monsterInfoList[i].Name} = {i},");
            }
            writer.WriteLine("}");
        }
    }
}