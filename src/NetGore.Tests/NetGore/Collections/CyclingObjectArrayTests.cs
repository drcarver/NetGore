using System.Linq;
using NetGore.Collections;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace NetGore.Tests.NetGore.Collections
{
    [TestFixture]
    public class CyclingObjectArrayTests
    {
        #region Unit tests

        [Test]
        public void NextFreeKeyTest()
        {
            var c = CyclingObjectArray.CreateUsingByteKey<string>();

            for (var i = 5; i < 10; i++)
            {
                c[(byte)i] = i.ToString();
            }

            for (var i = 0; i < 20; i++)
            {
                var key = c.Add(i.ToString());
                ClassicAssert.IsTrue(key < 5 || key >= 10, "key: " + key);
                ClassicAssert.AreEqual(c[key], i.ToString());
            }
        }

        [Test]
        public void NextKeyFreeTest()
        {
            var c = CyclingObjectArray.CreateUsingByteKey<string>();
            var i = c.NextFreeKey();
            var j = c.NextFreeKey();
            ClassicAssert.AreNotEqual(i, j);
        }

        [Test]
        public void NextKeyTest()
        {
            var c = CyclingObjectArray.CreateUsingByteKey<string>();
            var i = c.NextFreeKey();
            var j = c.NextFreeKey();
            ClassicAssert.AreEqual(i, j - 1);
        }

        [Test]
        public void RotateTest()
        {
            var c = CyclingObjectArray.CreateUsingByteKey<string>();
            int start = c.NextFreeKey();
            var expected = start + 1;
            int curr;

            while ((curr = c.NextFreeKey()) != start)
            {
                ClassicAssert.AreEqual(expected, curr);
                expected++;
                if (expected > c.MaxIndex)
                    expected = c.MinIndex;
            }
        }

        [Test]
        public void SkipUsedTest()
        {
            var c = CyclingObjectArray.CreateUsingByteKey<string>();

            for (var i = 0; i < 10; i++)
            {
                c.Add(i.ToString());
            }

            var usedKeys = c.Keys.ToImmutable();

            for (var i = c.MinIndex; i < c.MaxIndex; i++)
            {
                var key = c.NextFreeKey();
                ClassicAssert.IsFalse(c.IsSet(key));
                ClassicAssert.IsNull(c[key]);
            }

            foreach (var k in usedKeys)
            {
                ClassicAssert.IsTrue(c.IsSet(k));
                ClassicAssert.IsNotNull(c[k]);
            }
        }

        #endregion
    }
}