using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class NPCChat : BaseObject, INPCChat
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected NPCChat()
    {
    }
}