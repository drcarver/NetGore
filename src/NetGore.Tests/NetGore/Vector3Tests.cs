using System;
using System.Linq;
using NetGore.Extensions;
using NUnit.Framework;
using NUnit.Framework.Legacy;

using SFML.Graphics;

namespace NetGore.Tests.NetGore
{
    [TestFixture]
    public class Vector3Tests
    {
        #region Unit tests

        [Test]
        public void AbsTest()
        {
            for (var x = -10; x < 10; x++)
            {
                for (var y = -10; y < 10; y++)
                {
                    for (var z = -10; z < 10; z++)
                    {
                        var v = new Vector3(x, y, z);
                        v = v.Abs();
                        ClassicAssert.LessOrEqual(0, v.X);
                        ClassicAssert.LessOrEqual(0, v.Y);
                        ClassicAssert.LessOrEqual(0, v.Z);
                    }
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
                var v = new Vector3(r.NextFloat() * max, r.NextFloat() * max, r.NextFloat() * max);
                var c = v.Ceiling();
                ClassicAssert.AreEqual(Math.Ceiling(v.X), c.X);
                ClassicAssert.AreEqual(Math.Ceiling(v.Y), c.Y);
                ClassicAssert.AreEqual(Math.Ceiling(v.Z), c.Z);
            }
        }

        [Test]
        public void FloorTest()
        {
            const int max = 1000;

            var r = new Random(102);

            for (var i = 0; i < 30; i++)
            {
                var v = new Vector3(r.NextFloat() * max, r.NextFloat() * max, r.NextFloat() * max);
                var c = v.Floor();
                ClassicAssert.AreEqual(Math.Floor(v.X), c.X);
                ClassicAssert.AreEqual(Math.Floor(v.Y), c.Y);
                ClassicAssert.AreEqual(Math.Floor(v.Z), c.Z);
            }
        }

        [Test]
        public void IsGreaterOrEqualTest()
        {
            for (var x1 = -2; x1 < 2; x1++)
            {
                for (var y1 = -2; y1 < 2; y1++)
                {
                    for (var z1 = -5; z1 < 5; z1++)
                    {
                        for (var x2 = -2; x2 < 2; x2++)
                        {
                            for (var y2 = -2; y2 < 2; y2++)
                            {
                                for (var z2 = -5; z2 < 5; z2++)
                                {
                                    var v1 = new Vector3(x1, y1, z1);
                                    var v2 = new Vector3(x2, y2, z2);

                                    var b1 = (v1.X >= v2.X && v1.Y >= v2.Y && v1.Z >= v2.Z);
                                    ClassicAssert.AreEqual(b1, v1.IsGreaterOrEqual(v2));

                                    var b2 = (v2.X >= v1.X && v2.Y >= v1.Y && v2.Z >= v1.Z);
                                    ClassicAssert.AreEqual(b2, v2.IsGreaterOrEqual(v1));
                                }
                            }
                        }
                    }
                }
            }
        }

        [Test]
        public void IsGreaterThanTest()
        {
            for (var x1 = -2; x1 < 2; x1++)
            {
                for (var y1 = -2; y1 < 2; y1++)
                {
                    for (var z1 = -5; z1 < 5; z1++)
                    {
                        for (var x2 = -2; x2 < 2; x2++)
                        {
                            for (var y2 = -2; y2 < 2; y2++)
                            {
                                for (var z2 = -5; z2 < 5; z2++)
                                {
                                    var v1 = new Vector3(x1, y1, z1);
                                    var v2 = new Vector3(x2, y2, z2);

                                    var b1 = (v1.X > v2.X && v1.Y > v2.Y && v1.Z > v2.Z);
                                    ClassicAssert.AreEqual(b1, v1.IsGreaterThan(v2));

                                    var b2 = (v2.X > v1.X && v2.Y > v1.Y && v2.Z > v1.Z);
                                    ClassicAssert.AreEqual(b2, v2.IsGreaterThan(v1));
                                }
                            }
                        }
                    }
                }
            }
        }

        [Test]
        public void IsLessOrEqualTest()
        {
            for (var x1 = -2; x1 < 2; x1++)
            {
                for (var y1 = -2; y1 < 2; y1++)
                {
                    for (var z1 = -5; z1 < 5; z1++)
                    {
                        for (var x2 = -2; x2 < 2; x2++)
                        {
                            for (var y2 = -2; y2 < 2; y2++)
                            {
                                for (var z2 = -5; z2 < 5; z2++)
                                {
                                    var v1 = new Vector3(x1, y1, z1);
                                    var v2 = new Vector3(x2, y2, z2);

                                    var b1 = (v1.X <= v2.X && v1.Y <= v2.Y && v1.Z <= v2.Z);
                                    ClassicAssert.AreEqual(b1, v1.IsLessOrEqual(v2));

                                    var b2 = (v2.X <= v1.X && v2.Y <= v1.Y && v2.Z <= v1.Z);
                                    ClassicAssert.AreEqual(b2, v2.IsLessOrEqual(v1));
                                }
                            }
                        }
                    }
                }
            }
        }

        [Test]
        public void IsLessThanTest()
        {
            for (var x1 = -2; x1 < 2; x1++)
            {
                for (var y1 = -2; y1 < 2; y1++)
                {
                    for (var z1 = -5; z1 < 5; z1++)
                    {
                        for (var x2 = -2; x2 < 2; x2++)
                        {
                            for (var y2 = -2; y2 < 2; y2++)
                            {
                                for (var z2 = -5; z2 < 5; z2++)
                                {
                                    var v1 = new Vector3(x1, y1, z1);
                                    var v2 = new Vector3(x2, y2, z2);

                                    var b1 = (v1.X < v2.X && v1.Y < v2.Y && v1.Z < v2.Z);
                                    ClassicAssert.AreEqual(b1, v1.IsLessThan(v2));

                                    var b2 = (v2.X < v1.X && v2.Y < v1.Y && v2.Z < v1.Z);
                                    ClassicAssert.AreEqual(b2, v2.IsLessThan(v1));
                                }
                            }
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
                var v = new Vector3(r.NextFloat() * max, r.NextFloat() * max, r.NextFloat() * max);
                var c = v.Round();
                ClassicAssert.AreEqual(Math.Round(v.X), c.X);
                ClassicAssert.AreEqual(Math.Round(v.Y), c.Y);
                ClassicAssert.AreEqual(Math.Round(v.Z), c.Z);
            }
        }

        [Test]
        public void SumTest()
        {
            for (var x = -10; x < 10; x++)
            {
                for (var y = -10; y < 10; y++)
                {
                    for (var z = -10; z < 10; z++)
                    {
                        var v = new Vector3(x, y, z);
                        ClassicAssert.AreEqual(x + y + z, v.Sum());
                    }
                }
            }
        }

        #endregion
    }
}