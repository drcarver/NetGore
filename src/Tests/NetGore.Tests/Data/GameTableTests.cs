using D20.Core.Models;

using NetGore.Data;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data.Core;

[TestFixture]
public class GameTableTests
{
    [Test]
    public void GameTableTest()
    {
        var tables = DataServices.FindSubClassesOf<GameTable>();
        ClassicAssert.IsTrue(tables.Count() == 24, $"Table Count={tables.Count()}");
    }
}

