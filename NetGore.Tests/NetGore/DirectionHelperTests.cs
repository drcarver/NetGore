using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

using SFML.Graphics;

namespace NetGore.Tests.NetGore
{
    [TestFixture]
    public class DirectionHelperTests
    {
        #region Unit tests

        [Test]
        public void DirectionEastTest()
        {
            var v = new Vector2(1, 0);
            ClassicAssert.AreEqual(Direction.East, DirectionHelper.FromVector(v));
        }

        [Test]
        public void DirectionNorthEastTest()
        {
            var v = new Vector2(1, -1);
            ClassicAssert.AreEqual(Direction.NorthEast, DirectionHelper.FromVector(v));
        }

        [Test]
        public void DirectionNorthTest()
        {
            var v = new Vector2(0, -1);
            ClassicAssert.AreEqual(Direction.North, DirectionHelper.FromVector(v));
        }

        [Test]
        public void DirectionNorthWestTest()
        {
            var v = new Vector2(-1, -1);
            ClassicAssert.AreEqual(Direction.NorthWest, DirectionHelper.FromVector(v));
        }

        [Test]
        public void DirectionNullTest()
        {
            var v = new Vector2(0, 0);
            ClassicAssert.AreEqual(null, DirectionHelper.FromVector(v));
        }

        [Test]
        public void DirectionSouthEastTest()
        {
            var v = new Vector2(1, 1);
            ClassicAssert.AreEqual(Direction.SouthEast, DirectionHelper.FromVector(v));
        }

        [Test]
        public void DirectionSouthTest()
        {
            var v = new Vector2(0, 1);
            ClassicAssert.AreEqual(Direction.South, DirectionHelper.FromVector(v));
        }

        [Test]
        public void DirectionSouthWestTest()
        {
            var v = new Vector2(-1, 1);
            ClassicAssert.AreEqual(Direction.SouthWest, DirectionHelper.FromVector(v));
        }

        [Test]
        public void DirectionWestTest()
        {
            var v = new Vector2(-1, 0);
            ClassicAssert.AreEqual(Direction.West, DirectionHelper.FromVector(v));
        }

        #endregion
    }
}