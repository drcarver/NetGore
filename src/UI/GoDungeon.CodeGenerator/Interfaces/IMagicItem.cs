using GoDungeon.Core.Enum;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface IMagicItem : ICodeGen
{
    /// <summary>
    /// The type of magic item
    /// </summary>
    MagicItemTypeEnum ItemType { get; }
}
