using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICharacterTemplate
{
    AI? AI { get; set; }
    Alliance Alliance { get; set; }
    Body Body { get; set; }
    NPCChat? ChatDialog { get; set; }
    int Exp { get; set; }
    int GiveCash { get; set; }
    int GiveExp { get; set; }
    int Level { get; set; }
    int MoveSpeed { get; set; }
    int Respawn { get; set; }
    Shop? Shop { get; set; }
    int StatPoints { get; set; }
}