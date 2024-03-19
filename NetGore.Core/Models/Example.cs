using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

/// <summary>
/// A simple example for testing
/// </summary>
public class Example : BaseObject, IExample
{
    [SetsRequiredMembers]
    public Example() 
    { 
    }
}
