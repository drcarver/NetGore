using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.CodeGenerator.Models;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface ICodeGen : IStandardTableEntry
{
    /// <summary>
    /// The ParseModel for this markdown file
    /// </summary>
    public ParseModel ParseModel { get; }
}
