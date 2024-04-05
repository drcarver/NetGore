using System;
using System.Linq;
using NetGore.Extensions;
using NUnit.Framework;
using NUnit.Framework.Legacy;

using SFML.Graphics;

namespace NetGore.Tests.NetGore
{
    [TestFixture]
    public class Vector2Tests
    {
        #region Unit tests

        [Test]
        public void AbsTest()
        {
            for (var x = -10; x < 10; x++)
            {
                for (var y = -10; y < 10; y++)
                {
                    var v = new Vector2(x, y);
                    v = v.Abs();
                    ClassicAssert.LessOrEqual(0, v.X);
                    ClassicAssert.LessOrEqual(0, v.Y);
                }
            }
        }

        [Test]
        public void CeilingTest()
        {
            const int max = 1000;

            var r = new Random(987);

            for (var i = 0; i < 30; i++)
            {
                var v = new Vector2(r.NextFloat() * max, r.NextFloat() * max);
                var c = v.Ceiling();
                ClassicAssert.AreEqual(Math.Ceiling(v.X), c.X);
                ClassicAssert.AreEqual(Math.Ceiling(v.Y), c.Y);
            }
        }

        [Test]
        public void FloorTest()
        {
            const int max = 1000;

            var r = new Random(102);

            for (var i = 0; i < 30; i++)
            {
                var v = new Vector2(r.NextFloat() * max, r.NextFloat() * max);
                var c = v.Floor();
                ClassicAssert.AreEqual(Math.Floor(v.X), c.X);
                ClassicAssert.AreEqual(Math.Floor(v.Y), c.Y);
            }
        }

        [Test]
        public void IsGreaterOrEqualTest()
        {
            for (var x1 = -10; x1 < 10; x1++)
            {
                for (var y1 = -10; y1 < 10; y1++)
                {
                    for (var x2 = -10; x2 < 10; x2++)
                    {
                        for (var y2 = -10; y2 < 10; y2++)
                        {
                            var v1 = new Vector2(x1, y1);
                            var v2 = new Vector2(x2, y2);

                            var b1 = (v1.X >= v2.X && v1.Y >= v2.Y);
                            ClassicAssert.AreEqual(b1, v1.IsGreaterOrEqual(v2));

                            var b2 = (v2.X >= v1.X && v2.Y >= v1.Y);
                            ClassicAssert.AreEqual(b2, v2.IsGreaterOrEqual(v1));
                        }
                    }
                }
            }
        }

        [Test]
        public void IsGreaterThanTest()
        {
            for (var x1 = -10; x1 < 10; x1++)
            {
                for (var y1 = -10; y1 < 10; y1++)
                {
                    for (var x2 = -10; x2 < 10; x2++)
                    {
                        for (var y2 = -10; y2 < 10; y2++)
                        {
                            var v1 = new Vector2(x1, y1);
                            var v2 = new Vector2(x2, y2);

                            var b1 = (v1.X > v2.X && v1.Y > v2.Y);
                            ClassicAssert.AreEqual(b1, v1.IsGreaterThan(v2));

                            var b2 = (v2.X > v1.X && v2.Y > v1.Y);
                            ClassicAssert.AreEqual(b2, v2.IsGreaterThan(v1));
                        }
                    }
                }
            }
        }

        [Test]
        public void IsLessOrEqualTest()
        {
            for (var x1 = -10; x1 < 10; x1++)
            {
                for (var y1 = -10; y1 < 10; y1++)
                {
                    for (var x2 = -10; x2 < 10; x2++)
                    {
                        for (var y2 = -10; y2 < 10; y2++)
                        {
                            var v1 = new Vector2(x1, y1);
                            var v2 = new Vector2(x2, y2);

                            var b1 = (v1.X <= v2.X && v1.Y <= v2.Y);
                            ClassicAssert.AreEqual(b1, v1.IsLessOrEqual(v2));

                            var b2 = (v2.X <= v1.X && v2.Y <= v1.Y);
                            ClassicAssert.AreEqual(b2, v2.IsLessOrEqual(v1));
                        }
                    }
                }
            }
        }

        [Test]
        public void IsLessThanTest()
        {
            for (var x1 = -10; x1 < 10; x1++)
            {
                for (var y1 = -10; y1 < 10; y1++)
                {
                    for (var x2 = -10; x2 < 10; x2++)
                    {
                        for (var y2 = -10; y2 < 10; y2++)
                        {
                            var v1 = new Vector2(x1, y1);
                            var v2 = new Vector2(x2, y2);

                            var b1 = (v1.X < v2.X && v1.Y < v2.Y);
                            ClassicAssert.AreEqual(b1, v1.IsLessThan(v2));

                            var b2 = (v2.X < v1.X && v2.Y < v1.Y);
                            ClassicAssert.AreEqual(b2, v2.IsLessThan(v1));
                        }
                    }
                }
            }
        }

        [Test]
        public void RoundTest()
        {
            const int max = 1000;

            var r = new Random(578);

            for (var i = 0; i < 30; i++)
            {
                var v = new Vector2(r.NextFloat() * max, r.NextFloat() * max);
                var c = v.Round();
                ClassicAssert.AreEqual(Math.Round(v.X), c.X);
                ClassicAssert.AreEqual(Math.Round(v.Y), c.Y);
            }
        }

        [Test]
        public void SumTest()
        {
            for (var x = -10; x < 10; x++)
            {
                for (var y = -10; y < 10; y++)
                {
                    var v = new Vector2(x, y);
                    ClassicAssert.AreEqual(x + y, v.Sum());
                }
            }
        }

        #endregion
    }
}