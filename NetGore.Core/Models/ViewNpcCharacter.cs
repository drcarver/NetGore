using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class ViewNpcCharacter : ViewBase, IViewNpcCharacter
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ViewNpcCharacter()
    {
    }
}
