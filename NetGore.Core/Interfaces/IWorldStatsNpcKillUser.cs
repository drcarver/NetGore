﻿using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsNpcKillUser
{
    Map? Map { get; set; }
    CharacterTemplate? NPCTemplate { get; set; }
    ushort NpcX { get; set; }
    ushort NpcY { get; set; }
    Character User { get; set; }
    Guid UserId { get; set; }
    short UserLevel { get; set; }
    ushort UserX { get; set; }
    ushort UserY { get; set; }
    DateTime When { get; set; }
}