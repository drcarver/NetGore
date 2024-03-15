using NetGore.Core.Models;

namespace NetGore.Core.Interfaces
{
    public interface IViewBase
    {
        AIID? AIID { get; set; }
        Body Body { get; set; }
        int Cash { get; set; }
        CharacterTemplate CharacterTemplate { get; set; }
        NPCChatDialog? ChatDialog { get; set; }
        int Exp { get; set; }
        int HP { get; set; }
        short Level { get; set; }
        Map LoadMap { get; set; }
        ushort LoadX { get; set; }
        ushort LoadY { get; set; }
        ushort MoveSpeed { get; set; }
        int MP { get; set; }
        Map? RespawnMap { get; set; }
        float RespawnX { get; set; }
        float RespawnY { get; set; }
        Shop? Shop { get; set; }
        short StatAgi { get; set; }
        short StatDefence { get; set; }
        short StatInt { get; set; }
        short StatMaxhit { get; set; }
        short StatMaxhp { get; set; }
        short StatMaxmp { get; set; }
        short StatMinhit { get; set; }
        int StatPoints { get; set; }
        short StatStr { get; set; }
    }
}