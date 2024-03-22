using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class ActiveStatusEffect : DataObject, IActiveStatusEffect
{
    [SetsRequiredMembers]
    public ActiveStatusEffect()
    {
    }
}