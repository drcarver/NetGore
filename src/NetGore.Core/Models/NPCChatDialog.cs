using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class NPCChatDialog : BaseObject, INPCChatDialog
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected NPCChatDialog()
    {
    }
}