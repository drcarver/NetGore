using NUnit.Framework.Legacy;

namespace NetGore.Tests
{
    [TestFixture]
    public class GrhIndexTests
    {
        [Test]
        public void CreateTest()
        {
            new GrhIndex(5);
            new GrhIndex(GrhIndex.MinValue);
            new GrhIndex(GrhIndex.MaxValue);
        }

        [Test]
        public void EqualsTest()
        {
            ClassicAssert.AreEqual(new GrhIndex(5), new GrhIndex(5));
            ClassicAssert.IsTrue(new GrhIndex(5) == new GrhIndex(5));
            ClassicAssert.IsTrue(new GrhIndex(5).Equals(new GrhIndex(5)));
        }

        [Test]
        public void IsInvalidTest()
        {
            ClassicAssert.IsTrue(GrhIndex.Invalid.IsInvalid);
            ClassicAssert.IsTrue(new GrhIndex().IsInvalid);
        }

        [Test]
        public void NotEqualTest()
        {
            ClassicAssert.AreNotEqual(new GrhIndex(5), new GrhIndex(6));
            ClassicAssert.IsTrue(new GrhIndex(5) != new GrhIndex(6));
            ClassicAssert.IsFalse(new GrhIndex(5).Equals(new GrhIndex(6)));
        }
    }
}