﻿using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class ViewUserCharacter : ViewBase, IViewUserCharacter
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ViewUserCharacter()
    {
    }
}
