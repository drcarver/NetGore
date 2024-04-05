using System.Linq;
using NetGore.IO;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace NetGore.Tests.NetGore.IO
{
    [TestFixture]
    public class PathStringTests
    {
        #region Unit tests

        [Test]
        public void BackRootTest()
        {
            ClassicAssert.AreEqual(new PathString(@"C:\"), new PathString(@"C:\One").Back());
        }

        [Test]
        public void BackTest()
        {
            ClassicAssert.AreEqual(new PathString(@"C:\One"), new PathString(@"C:\One\Two").Back());
        }

        [Test]
        public void EqualsTest()
        {
            ClassicAssert.AreEqual(new PathString(@"C:\One\Two"), new PathString(@"C:\One\Two"));
        }

        [Test]
        public void JoinATest()
        {
            var s = new PathString(@"C:\One");
            var s2 = s.Join(@"Two");
            ClassicAssert.AreEqual(new PathString(@"C:\One\Two"), s2);
        }

        [Test]
        public void JoinBTest()
        {
            var s = new PathString(@"C:\One\");
            var s2 = s.Join(@"Two");
            ClassicAssert.AreEqual(new PathString(@"C:\One\Two"), s2);
        }

        [Test]
        public void JoinCTest()
        {
            var s = new PathString(@"C:\One");
            var s2 = s.Join(@"\Two");
            ClassicAssert.AreEqual(new PathString(@"C:\One\Two"), s2);
        }

        [Test]
        public void JoinDTest()
        {
            var s = new PathString(@"C:\One\");
            var s2 = s.Join(@"\Two");
            ClassicAssert.AreEqual(new PathString(@"C:\One\Two"), s2);
        }

        [Test]
        public void JoinETest()
        {
            var s = new PathString(@"C:\One\");
            var s2 = s.Join(@"\Two\");
            ClassicAssert.AreEqual(new PathString(@"C:\One\Two"), s2);
        }

        [Test]
        public void JoinFTest()
        {
            var s = new PathString(@"C:\One\");
            var s2 = s.Join(@"Two\");
            ClassicAssert.AreEqual(new PathString(@"C:\One\Two"), s2);
        }

        [Test]
        public void JoinGTest()
        {
            var s = new PathString(@"C:\One");
            var s2 = s.Join(@"Two\");
            ClassicAssert.AreEqual(new PathString(@"C:\One\Two"), s2);
        }

        [Test]
        public void JoinHTest()
        {
            var s = new PathString(@"C:\One");
            var s2 = s.Join(@"\Two\");
            ClassicAssert.AreEqual(new PathString(@"C:\One\Two"), s2);
        }

        [Test]
        public void ToStringEqualsStringTest()
        {
            ClassicAssert.AreEqual(@"C:\One\Two", new PathString(@"C:\One\Two").ToString());
            ClassicAssert.AreEqual(@"C:\One\Two", new PathString(@"C:\One\Two\").ToString());
        }

        #endregion
    }
}