using System;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

// ReSharper disable RedundantCast

namespace NetGore.Tests.NetGore
{
    [TestFixture]
    public class StringParserTests
    {
        #region Unit tests

        [Test]
        public void ParseBoolTest()
        {
            var type = typeof(bool);

            StringParser.CanParseType(type);

            object outFalse;
            StringParser.TryParse(Parser.Invariant.ToString(false), type, out outFalse);
            ClassicAssert.AreEqual((bool)false, (bool)outFalse);

            object outTrue;
            StringParser.TryParse(Parser.Invariant.ToString(true), type, out outTrue);
            ClassicAssert.AreEqual((bool)true, (bool)outTrue);
        }

        [Test]
        public void ParseByteTest()
        {
            var type = typeof(byte);
            const int min = byte.MinValue;
            const int max = byte.MaxValue;

            StringParser.CanParseType(type);

            for (var i = Math.Max(-200, min); i < Math.Min(max, 200); i++)
            {
                var s = Parser.Invariant.ToString(i);
                object o;
                StringParser.TryParse(s, type, out o);
                ClassicAssert.AreEqual((byte)i, (byte)o);
            }

            object outMin;
            StringParser.TryParse(Parser.Invariant.ToString(min), type, out outMin);
            ClassicAssert.AreEqual((byte)min, (byte)outMin);

            object outMax;
            StringParser.TryParse(Parser.Invariant.ToString(min), type, out outMax);
            ClassicAssert.AreEqual((byte)min, (byte)outMax);
        }

        [Test]
        public void ParseDoubleTest()
        {
            var type = typeof(double);
            const double min = double.MinValue;
            const double max = double.MaxValue;

            StringParser.CanParseType(type);

            for (var i = (int)Math.Max(-200, min); i < Math.Min(max, 200); i++)
            {
                var s = Parser.Invariant.ToString(i);
                object o;
                StringParser.TryParse(s, type, out o);
                ClassicAssert.AreEqual((double)i, (double)o);
            }
        }

        [Test]
        public void ParseFloatTest()
        {
            var type = typeof(float);
            const float min = float.MinValue;
            const float max = float.MaxValue;

            StringParser.CanParseType(type);

            for (var i = (int)Math.Max(-200, min); i < Math.Min(max, 200); i++)
            {
                var s = Parser.Invariant.ToString(i);
                object o;
                StringParser.TryParse(s, type, out o);
                ClassicAssert.AreEqual((float)i, (float)o);
            }
        }

        [Test]
        public void ParseIntTest()
        {
            var type = typeof(int);
            const int min = int.MinValue;
            const int max = int.MaxValue;

            StringParser.CanParseType(type);

            for (var i = Math.Max(-200, min); i < Math.Min(max, 200); i++)
            {
                var s = Parser.Invariant.ToString(i);
                object o;
                StringParser.TryParse(s, type, out o);
                ClassicAssert.AreEqual((int)i, (int)o);
            }

            object outMin;
            StringParser.TryParse(Parser.Invariant.ToString(min), type, out outMin);
            ClassicAssert.AreEqual((int)min, (int)outMin);

            object outMax;
            StringParser.TryParse(Parser.Invariant.ToString(min), type, out outMax);
            ClassicAssert.AreEqual((int)min, (int)outMax);
        }

        [Test]
        public void ParseSByteTest()
        {
            var type = typeof(sbyte);
            const int min = sbyte.MinValue;
            const int max = sbyte.MaxValue;

            StringParser.CanParseType(type);

            for (var i = Math.Max(-200, min); i < Math.Min(max, 200); i++)
            {
                var s = Parser.Invariant.ToString(i);
                object o;
                StringParser.TryParse(s, type, out o);
                ClassicAssert.AreEqual((sbyte)i, (sbyte)o);
            }

            object outMin;
            StringParser.TryParse(Parser.Invariant.ToString(min), type, out outMin);
            ClassicAssert.AreEqual((sbyte)min, (sbyte)outMin);

            object outMax;
            StringParser.TryParse(Parser.Invariant.ToString(min), type, out outMax);
            ClassicAssert.AreEqual((sbyte)min, (sbyte)outMax);
        }

        [Test]
        public void ParseShortTest()
        {
            var type = typeof(short);
            const int min = short.MinValue;
            const int max = short.MaxValue;

            StringParser.CanParseType(type);

            for (var i = Math.Max(-200, min); i < Math.Min(max, 200); i++)
            {
                var s = Parser.Invariant.ToString(i);
                object o;
                StringParser.TryParse(s, type, out o);
                ClassicAssert.AreEqual((short)i, (short)o);
            }

            object outMin;
            StringParser.TryParse(Parser.Invariant.ToString(min), type, out outMin);
            ClassicAssert.AreEqual((short)min, (short)outMin);

            object outMax;
            StringParser.TryParse(Parser.Invariant.ToString(min), type, out outMax);
            ClassicAssert.AreEqual((short)min, (short)outMax);
        }

        [Test]
        public void ParseUIntTest()
        {
            var type = typeof(uint);
            const uint min = uint.MinValue;
            const uint max = uint.MaxValue;

            StringParser.CanParseType(type);

            for (var i = (uint)Math.Max(-200, min); i < Math.Min(max, 200); i++)
            {
                var s = Parser.Invariant.ToString(i);
                object o;
                StringParser.TryParse(s, type, out o);
                ClassicAssert.AreEqual((uint)i, (uint)o);
            }

            object outMin;
            StringParser.TryParse(Parser.Invariant.ToString(min), type, out outMin);
            ClassicAssert.AreEqual((uint)min, (uint)outMin);

            object outMax;
            StringParser.TryParse(Parser.Invariant.ToString(min), type, out outMax);
            ClassicAssert.AreEqual((uint)min, (uint)outMax);
        }

        [Test]
        public void ParseUShortTest()
        {
            var type = typeof(ushort);
            const int min = ushort.MinValue;
            const int max = ushort.MaxValue;

            StringParser.CanParseType(type);

            for (var i = Math.Max(-200, min); i < Math.Min(max, 200); i++)
            {
                var s = Parser.Invariant.ToString(i);
                object o;
                StringParser.TryParse(s, type, out o);
                ClassicAssert.AreEqual((ushort)i, (ushort)o);
            }

            object outMin;
            StringParser.TryParse(Parser.Invariant.ToString(min), type, out outMin);
            ClassicAssert.AreEqual((ushort)min, (ushort)outMin);

            object outMax;
            StringParser.TryParse(Parser.Invariant.ToString(min), type, out outMax);
            ClassicAssert.AreEqual((ushort)min, (ushort)outMax);
        }

        #endregion
    }
}