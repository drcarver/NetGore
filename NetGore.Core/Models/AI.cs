﻿using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class AI : DataObject, IAI
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AI()
    {
    }
}