using NetGore.Data;
using NetGore.Data.Models;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data.Core;

[TestFixture]
public class GameTableTests
{
    [Test]
    public void GameTableTest()
    {
        var tables = DataServices.FindSubClassesOf<GameTable>();
        ClassicAssert.IsTrue(tables.Count() == 23, $"Table Count={tables.Count()}");
    }
}

