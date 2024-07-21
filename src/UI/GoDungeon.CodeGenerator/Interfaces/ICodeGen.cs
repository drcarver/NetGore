using GoDungeon.CodeGenerator.Models;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface ICodeGen : IStandardTableEntry
{
    /// <summary>
    /// The file headers
    /// </summary>
    List<string> FileHeaders { get; }

    /// <summary>
    /// The ParseModel for this markdown file
    /// </summary>
    public ParseModel ParseModel { get; }
}
