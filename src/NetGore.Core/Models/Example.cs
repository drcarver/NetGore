using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

/// <summary>
/// A simple example for testing
/// </summary>
public class Example : DataObject, IExample
{
    [SetsRequiredMembers]
    public Example() 
    { 
    }
}
