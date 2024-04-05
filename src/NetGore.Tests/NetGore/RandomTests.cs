using System;
using System.Linq;
using NetGore.Extensions;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace NetGore.Tests.NetGore
{
    [TestFixture]
    public class RandomTests
    {
        #region Unit tests

        [Test]
        public void NextFloatTest()
        {
            var r = new Random(555);
            var last = 0f;

            for (var i = 0; i < 20; i++)
            {
                var f = r.NextFloat();
                ClassicAssert.AreNotEqual(last, f);
                ClassicAssert.Less(f, 1f);
                ClassicAssert.GreaterOrEqual(f, 0f);
                last = f;
            }
        }

        #endregion
    }
}