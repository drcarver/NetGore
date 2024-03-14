using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IGuildEvent
{
    string? Arg0 { get; set; }
    string? Arg1 { get; set; }
    string? Arg2 { get; set; }
    Character Character { get; set; }
    DateTime Created { get; set; }
    byte Event { get; set; }
    Guild Guild { get; set; }
    Character? TargetCharacter { get; set; }
}