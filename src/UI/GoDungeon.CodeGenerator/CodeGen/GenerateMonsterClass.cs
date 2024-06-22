using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.Core.Interfaces;
using GoDungeon.Monsters.ViewModels;

namespace GoDungeon.CodeGenerator.CodeGen;

public partial class GenerateModel : IGenerateModel
{
    /// <summary>
    /// Generate the .cs class for the monster
    /// </summary>
    /// <param name="stream">The monster file stream</param>
    /// <param name="creature">The creature to generate</param>
    public void GenerateMonsterClass(TextWriter stream, ICreature creature, string rootdir)
    {
        GenerateMonsterHeader(stream, creature);
        GenerateMonsterInterfaceFile(stream, creature, rootdir);
    }

    /// <summary>
    /// Generate the class header
    /// </summary>
    /// <param name="stream">The monster file stream</param>
    /// <param name="creature">The creature to generate</param>
    private void GenerateMonsterHeader(TextWriter stream, ICreature creature)
    {
        stream.WriteLine($"// {creature.ProperName}");
        stream.WriteLine("//");
        stream.WriteLine("using GoDungeon.Core.Abilities;");
        stream.WriteLine("using GoDungeon.Core.Enum;");
        stream.WriteLine("using GoDungeon.Core.ViewModels;");
        stream.WriteLine();
        stream.WriteLine($"using GoDungeon.Monsters.Interfaces;");
        stream.WriteLine();
        stream.WriteLine("using Microsoft.Extensions.Logging;");
        stream.WriteLine();
        stream.WriteLine($"namespace GoDungeon.Monsters;");
        stream.WriteLine();
        stream.WriteLine($"public partial class {creature.Name}ViewModel : CreatureViewModel, I{creature.Name}");
        stream.WriteLine("{");
        stream.WriteLine($"\t/// <summary>");
        stream.WriteLine($"\t/// Initialize the view model");
        stream.WriteLine($"\t/// </summary>");
        stream.WriteLine($"\tprivate void Initialize()");
        stream.WriteLine("\t{");
        stream.WriteLine($"\t\tName = \"{creature.Name}\";");
        stream.WriteLine($"\t\tProperName = \"{creature.ProperName}\";");
        stream.WriteLine($"\t\tRaceType = RaceTypeEnum.{creature.RaceType};");
        foreach (var subType in creature.RaceSubType)
        {
            stream.WriteLine($"\t\tRaceSubType.Add(RaceSubTypeEnum.{subType});");
        }
        stream.WriteLine($"\t\tChallengeRating = {creature.ChallengeRating};");
        //stream.WriteLine($"\t\tExperiencePoints = {creature.ExperiencePoints}");
        stream.WriteLine();
        stream.WriteLine("\t\t// Abilities");
        stream.WriteLine($"\t\tStrength = new Strength({creature.Strength.Score}, this);");
        stream.WriteLine($"\t\tIntelligence = new Intelligence({creature.Intelligence.Score}, this);");
        stream.WriteLine($"\t\tWisdom = new Wisdom({creature.Wisdom.Score}, this);");
        stream.WriteLine($"\t\tDexterity = new Dexterity({creature.Dexterity.Score}, this);");
        stream.WriteLine($"\t\tConstitution = new Constitution({creature.Constitution.Score}, this);");
        stream.WriteLine($"\t\tCharisma = new Charisma({creature.Charisma.Score}, this);");
        stream.WriteLine("\t}");
        stream.WriteLine("}");
    }

    /// <summary>
    /// Generate interface files
    /// </summary>
    /// <param name="stream">The output stream</param>
    /// <param name="creature">The creature the file is being generated for</param>
    private void GenerateMonsterInterfaceFile(TextWriter stream, ICreature creature, string rootdir)
    {
        // Convert the file to a .cs interface
        var interfaceFile = $@"{rootdir}monsters/Interfaces/I{creature.Name}.cs";
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