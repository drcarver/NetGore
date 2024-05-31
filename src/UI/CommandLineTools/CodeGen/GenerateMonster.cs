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
        stream.WriteLine($"\t\tChallengeRating = {Program.Creature.ChallengeRating};");
        //stream.WriteLine($"\t\tExperiencePoints = {Program.Creature.ExperiencePoints}");
        stream.WriteLine("\t}");
        stream.WriteLine("}");
    }
}
