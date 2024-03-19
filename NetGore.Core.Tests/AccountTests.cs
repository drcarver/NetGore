using NetGore.Core.Models;

using NUnit.Framework.Legacy;

namespace NetGore.Core.Tests;

[TestFixture]
internal class AccountTests
{
    [Test]
    public void CreateTest()
    {
        var account = new Account();
        ClassicAssert.IsNotNull(account);
    }
}
