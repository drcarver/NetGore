using GoDungeon.Core.Abilities;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.CommandLineTools.CodeGen;

internal static class Utilities
{
    /// <summary>
    /// Clean up a string so it can be used as a C# variable
    /// </summary>
    /// <param name="name">The name to fix-up</param>
    /// <returns>The string as a c# variable name</returns>
    internal static string? CleanupForCSharp(string name)
    {
        var cleanName = name;
        if (name.Contains("("))
        {
            cleanName = name.Substring(name.IndexOf("(")+1);
        }
        return cleanName
            .Replace(" ", string.Empty)
            .Replace("/", string.Empty)
            .Replace("\\", string.Empty)
            .Replace("-", string.Empty)
            .Replace("'", string.Empty)
            .Replace(")", string.Empty)
            .Trim();
    }
}
