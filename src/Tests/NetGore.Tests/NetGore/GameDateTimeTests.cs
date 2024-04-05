using NetGore.Features.GameTime;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.NetGore
{
    [TestFixture]
    public class GameDateTimeTests
    {
        #region Unit tests

        [Test]
        public void AddOperatorTest()
        {
            var a = new GameDateTime(50);
            var b = new GameDateTime(25);

            ClassicAssert.AreEqual(new GameDateTime(75), a + b);
            ClassicAssert.AreEqual(new GameDateTime(75), b + a);
        }

        [Test]
        public void EqualsOperatorTest()
        {
            var a = new GameDateTime(512);
            var b = new GameDateTime(512);
            var c = new GameDateTime(312);

            ClassicAssert.IsTrue(a == b);
            ClassicAssert.IsTrue(b == a);
            ClassicAssert.IsFalse(a == c);
            ClassicAssert.IsFalse(b == c);
        }

        [Test]
        public void EqualsTest()
        {
            var a = new GameDateTime(512);
            var b = new GameDateTime(512);
            var c = new GameDateTime(312);

            ClassicAssert.AreEqual(a, b);
            ClassicAssert.AreEqual(b, a);
            ClassicAssert.AreNotEqual(a, c);
            ClassicAssert.AreNotEqual(b, c);

            ClassicAssert.IsTrue(a.Equals(b));
            ClassicAssert.IsTrue(b.Equals(a));
            ClassicAssert.IsFalse(a.Equals(c));
            ClassicAssert.IsFalse(b.Equals(c));
        }

        [Test]
        public void GreaterThanOperatorTest()
        {
            var less = new GameDateTime(100);
            var more = new GameDateTime(200);

            ClassicAssert.IsFalse(less > more);
            ClassicAssert.IsTrue(more > less);
        }

        [Test]
        public void GreaterThanOrEqualToOperatorTest()
        {
            var less = new GameDateTime(100);
            var more = new GameDateTime(200);
            var less2 = new GameDateTime(100);

            ClassicAssert.IsFalse(less >= more);
            ClassicAssert.IsTrue(more >= less);
            ClassicAssert.IsTrue(less >= less2);
            ClassicAssert.IsTrue(less2 >= less);
        }

        [Test]
        public void LessThanOperatorTest()
        {
            var less = new GameDateTime(100);
            var more = new GameDateTime(200);

            ClassicAssert.IsTrue(less < more);
            ClassicAssert.IsFalse(more < less);
        }

        [Test]
        public void LessThanOrEqualToOperatorTest()
        {
            var less = new GameDateTime(100);
            var more = new GameDateTime(200);
            var less2 = new GameDateTime(100);

            ClassicAssert.IsTrue(less < more);
            ClassicAssert.IsFalse(more < less);
            ClassicAssert.IsTrue(less <= less2);
            ClassicAssert.IsTrue(less2 <= less);
        }

        [Test]
        public void NotEqualsOperatorTest()
        {
            var a = new GameDateTime(512);
            var b = new GameDateTime(512);
            var c = new GameDateTime(312);

            ClassicAssert.IsFalse(a != b);
            ClassicAssert.IsFalse(b != a);
            ClassicAssert.IsTrue(a != c);
            ClassicAssert.IsTrue(b != c);
        }

        [Test]
        public void SubtractOperatorTest()
        {
            var a = new GameDateTime(50);
            var b = new GameDateTime(25);

            ClassicAssert.AreEqual(new GameDateTime(25), a - b);
        }

        [Test]
        public void TimeOffsetTest()
        {
            var clientTime = DateTime.Now;

            var serverTime = new DateTime(clientTime.Year, clientTime.Month, clientTime.Day,
                clientTime.Hour - (clientTime.Hour <= 1 ? 0 : 1), clientTime.Minute, clientTime.Second);
            GameDateTime.SetServerTimeOffset(serverTime);

            ClassicAssert.AreEqual((clientTime.Hour <= 1 ? 0 : 1), Math.Round(GameDateTime.ServerTimeOffset.TotalHours));
        }

        [Test]
        public void ToFromMinutesTest()
        {
            const int minutes = 123123;
            var gt = new GameDateTime(minutes);
            ClassicAssert.AreEqual(minutes, (int)gt.TotalRealMinutes);
            ClassicAssert.AreEqual(gt, new GameDateTime((int)gt.TotalRealMinutes));
        }

        #endregion
    }
}