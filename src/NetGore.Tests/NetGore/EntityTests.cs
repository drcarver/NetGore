using System.Linq;
using NetGore.World;
using NUnit.Framework;
using NUnit.Framework.Legacy;

using SFML.Graphics;

namespace NetGore.Tests.NetGore
{
    [TestFixture]
    public class EntityTests
    {
        #region Unit tests

        [Test]
        public void HitTestTest()
        {
            var e = new TestEntity(Vector2.Zero, new Vector2(10, 10));
            ClassicAssert.IsTrue(e.Contains(new Vector2(0, 0)));
            ClassicAssert.IsTrue(e.Contains(new Vector2(10, 0)));
            ClassicAssert.IsTrue(e.Contains(new Vector2(0, 10)));
            ClassicAssert.IsTrue(e.Contains(new Vector2(10, 10)));
            ClassicAssert.IsTrue(e.Contains(new Vector2(5, 5)));

            ClassicAssert.IsFalse(e.Contains(new Vector2(-1, 0)));
            ClassicAssert.IsFalse(e.Contains(new Vector2(0, -1)));
            ClassicAssert.IsFalse(e.Contains(new Vector2(-1, -1)));
            ClassicAssert.IsFalse(e.Contains(new Vector2(11, 0)));
            ClassicAssert.IsFalse(e.Contains(new Vector2(0, 11)));
            ClassicAssert.IsFalse(e.Contains(new Vector2(11, 11)));
        }

        [Test]
        public void IntersectTest()
        {
            var a = new TestEntity(Vector2.Zero, new Vector2(10, 10));
            var b = new TestEntity(Vector2.Zero, new Vector2(10, 10));

            ClassicAssert.IsTrue(a.Intersects(b));

            a.Position = new Vector2(9, 9);
            ClassicAssert.IsTrue(a.Intersects(b));

            a.Position = new Vector2(-9, -9);
            ClassicAssert.IsTrue(a.Intersects(b));

            a.Position = new Vector2(-9, 0);
            ClassicAssert.IsTrue(a.Intersects(b));

            a.Position = new Vector2(0, -9);
            ClassicAssert.IsTrue(a.Intersects(b));

            a.Position = new Vector2(-11, -11);
            ClassicAssert.IsFalse(a.Intersects(b));

            a.Position = new Vector2(-11, 0);
            ClassicAssert.IsFalse(a.Intersects(b));

            a.Position = new Vector2(0, -11);
            ClassicAssert.IsFalse(a.Intersects(b));

            a.Position = new Vector2(11, 11);
            ClassicAssert.IsFalse(a.Intersects(b));
        }

        [Test]
        public void MoveTest()
        {
            var e = new TestEntity(new Vector2(10, 10), new Vector2(10, 10));
            ClassicAssert.AreEqual(10, e.Position.X);
            ClassicAssert.AreEqual(10, e.Position.Y);
            ClassicAssert.AreEqual(10, e.Size.X);
            ClassicAssert.AreEqual(10, e.Size.Y);

            e.Move(new Vector2(5, 10));
            ClassicAssert.AreEqual(15, e.Position.X);
            ClassicAssert.AreEqual(20, e.Position.Y);
            ClassicAssert.AreEqual(10, e.Size.X);
            ClassicAssert.AreEqual(10, e.Size.Y);
        }

        [Test]
        public void TeleportTest()
        {
            var e = new TestEntity(new Vector2(10, 10), new Vector2(10, 10));
            ClassicAssert.AreEqual(10, e.Position.X);
            ClassicAssert.AreEqual(10, e.Position.Y);
            ClassicAssert.AreEqual(10, e.Size.X);
            ClassicAssert.AreEqual(10, e.Size.Y);

            e.Position = new Vector2(5, 10);
            ClassicAssert.AreEqual(5, e.Position.X);
            ClassicAssert.AreEqual(10, e.Position.Y);
            ClassicAssert.AreEqual(10, e.Size.X);
            ClassicAssert.AreEqual(10, e.Size.Y);
        }

        #endregion

        class TestEntity : Entity
        {
            public TestEntity(Vector2 pos, Vector2 size) : base(pos, size)
            {
            }

            /// <summary>
            /// When overridden in the derived class, gets if this <see cref="Entity"/> will collide against
            /// walls. If false, this <see cref="Entity"/> will pass through walls and completely ignore them.
            /// </summary>
            public override bool CollidesAgainstWalls
            {
                get { return true; }
            }
        }
    }
}