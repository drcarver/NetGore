using System;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace NetGore.Tests.NetGore
{
    [TestFixture]
    public class IsBetweenTests
    {
        #region Unit tests

        [Test]
        public void IsBetweenByteTest()
        {
            for (byte i = 0; i < 40; i++)
            {
                for (byte j = 0; j < 40; j++)
                {
                    for (byte k = 0; k < 60; k++)
                    {
                        var b = k.IsBetween(i, j);

                        bool b2;
                        if (i < j)
                            b2 = (k >= i && k <= j);
                        else
                            b2 = (k >= j && k <= i);

                        ClassicAssert.AreEqual(b, b2);
                    }
                }
            }
        }

        [Test]
        public void IsBetweenDateTimeTest()
        {
            var i = new DateTime(0);
            while ((i = i.AddTicks(1)) < new DateTime(40))
            {
                var j = new DateTime(0);
                while ((j = j.AddTicks(1)) < new DateTime(40))
                {
                    var k = new DateTime(0);
                    while ((k = k.AddTicks(1)) < new DateTime(60))
                    {
                        var b = k.IsBetween(i, j);

                        bool b2;
                        if (i < j)
                            b2 = (k >= i && k <= j);
                        else
                            b2 = (k >= j && k <= i);

                        ClassicAssert.AreEqual(b, b2);
                    }
                }
            }
        }

        [Test]
        public void IsBetweenDecimalTest()
        {
            for (decimal i = -20; i < 20; i++)
            {
                for (decimal j = -20; j < 20; j++)
                {
                    for (decimal k = -30; k < 30; k++)
                    {
                        var b = k.IsBetween(i, j);

                        bool b2;
                        if (i < j)
                            b2 = (k >= i && k <= j);
                        else
                            b2 = (k >= j && k <= i);

                        ClassicAssert.AreEqual(b, b2);
                    }
                }
            }
        }

        [Test]
        public void IsBetweenDoubleTest()
        {
            for (double i = -20; i < 20; i++)
            {
                for (double j = -20; j < 20; j++)
                {
                    for (double k = -30; k < 30; k++)
                    {
                        var b = k.IsBetween(i, j);

                        bool b2;
                        if (i < j)
                            b2 = (k >= i && k <= j);
                        else
                            b2 = (k >= j && k <= i);

                        ClassicAssert.AreEqual(b, b2);
                    }
                }
            }
        }

        [Test]
        public void IsBetweenFloatTest()
        {
            for (float i = -20; i < 20; i++)
            {
                for (float j = -20; j < 20; j++)
                {
                    for (float k = -30; k < 30; k++)
                    {
                        var b = k.IsBetween(i, j);

                        bool b2;
                        if (i < j)
                            b2 = (k >= i && k <= j);
                        else
                            b2 = (k >= j && k <= i);

                        ClassicAssert.AreEqual(b, b2);
                    }
                }
            }
        }

        [Test]
        public void IsBetweenIntTest()
        {
            for (var i = -20; i < 20; i++)
            {
                for (var j = -20; j < 20; j++)
                {
                    for (var k = -30; k < 30; k++)
                    {
                        var b = k.IsBetween(i, j);

                        bool b2;
                        if (i < j)
                            b2 = (k >= i && k <= j);
                        else
                            b2 = (k >= j && k <= i);

                        ClassicAssert.AreEqual(b, b2);
                    }
                }
            }
        }

        [Test]
        public void IsBetweenLongTest()
        {
            for (long i = -20; i < 20; i++)
            {
                for (long j = -20; j < 20; j++)
                {
                    for (long k = -30; k < 30; k++)
                    {
                        var b = k.IsBetween(i, j);

                        bool b2;
                        if (i < j)
                            b2 = (k >= i && k <= j);
                        else
                            b2 = (k >= j && k <= i);

                        ClassicAssert.AreEqual(b, b2);
                    }
                }
            }
        }

        [Test]
        public void IsBetweenSByteTest()
        {
            for (sbyte i = -20; i < 20; i++)
            {
                for (sbyte j = -20; j < 20; j++)
                {
                    for (sbyte k = -30; k < 30; k++)
                    {
                        var b = k.IsBetween(i, j);

                        bool b2;
                        if (i < j)
                            b2 = (k >= i && k <= j);
                        else
                            b2 = (k >= j && k <= i);

                        ClassicAssert.AreEqual(b, b2);
                    }
                }
            }
        }

        [Test]
        public void IsBetweenShortTest()
        {
            for (short i = -20; i < 20; i++)
            {
                for (short j = -20; j < 20; j++)
                {
                    for (short k = -30; k < 30; k++)
                    {
                        var b = k.IsBetween(i, j);

                        bool b2;
                        if (i < j)
                            b2 = (k >= i && k <= j);
                        else
                            b2 = (k >= j && k <= i);

                        ClassicAssert.AreEqual(b, b2);
                    }
                }
            }
        }

        [Test]
        public void IsBetweenUIntTest()
        {
            for (uint i = 0; i < 40; i++)
            {
                for (uint j = 0; j < 40; j++)
                {
                    for (uint k = 0; k < 60; k++)
                    {
                        var b = k.IsBetween(i, j);

                        bool b2;
                        if (i < j)
                            b2 = (k >= i && k <= j);
                        else
                            b2 = (k >= j && k <= i);

                        ClassicAssert.AreEqual(b, b2);
                    }
                }
            }
        }

        [Test]
        public void IsBetweenULongTest()
        {
            for (ulong i = 0; i < 40; i++)
            {
                for (ulong j = 0; j < 40; j++)
                {
                    for (ulong k = 0; k < 60; k++)
                    {
                        var b = k.IsBetween(i, j);

                        bool b2;
                        if (i < j)
                            b2 = (k >= i && k <= j);
                        else
                            b2 = (k >= j && k <= i);

                        ClassicAssert.AreEqual(b, b2);
                    }
                }
            }
        }

        [Test]
        public void IsBetweenUShortTest()
        {
            for (ushort i = 0; i < 40; i++)
            {
                for (ushort j = 0; j < 40; j++)
                {
                    for (ushort k = 0; k < 60; k++)
                    {
                        var b = k.IsBetween(i, j);

                        bool b2;
                        if (i < j)
                            b2 = (k >= i && k <= j);
                        else
                            b2 = (k >= j && k <= i);

                        ClassicAssert.AreEqual(b, b2);
                    }
                }
            }
        }

        #endregion
    }
}