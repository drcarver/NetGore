using System;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace NetGore.Tests.NetGore
{
    [TestFixture]
    public class StringRulesTests
    {
        const int _maxLength = 10000;
        const int _minLength = 1;
        const string _sLower = "abcdefghijklmnopqrstuvwxyz";
        const string _sNumeric = "1234567890";
        const string _sPunctuation = "-_,.!?\"";
        const string _sSentence = "Hello World!";
        const string _sUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string _sUpperLower = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string _sWhitespace = "    ";

        #region Unit tests

        [Test]
        public void AllTest()
        {
            var r = new StringRules(_minLength, _maxLength, CharType.All);
            ClassicAssert.IsTrue(r.IsValid(_sLower));
            ClassicAssert.IsTrue(r.IsValid(_sUpper));
            ClassicAssert.IsTrue(r.IsValid(_sUpperLower));
            ClassicAssert.IsTrue(r.IsValid(_sNumeric));
            ClassicAssert.IsTrue(r.IsValid(_sPunctuation));
            ClassicAssert.IsTrue(r.IsValid(_sSentence));
            ClassicAssert.IsTrue(r.IsValid(_sWhitespace));
        }

        [Test]
        public void AlphaLowerTest()
        {
            var r = new StringRules(_minLength, _maxLength, CharType.AlphaLower);
            ClassicAssert.IsTrue(r.IsValid(_sLower));
            ClassicAssert.IsFalse(r.IsValid(_sUpper));
            ClassicAssert.IsFalse(r.IsValid(_sUpperLower));
            ClassicAssert.IsFalse(r.IsValid(_sNumeric));
            ClassicAssert.IsFalse(r.IsValid(_sPunctuation));
            ClassicAssert.IsFalse(r.IsValid(_sSentence));
            ClassicAssert.IsFalse(r.IsValid(_sWhitespace));
        }

        [Test]
        public void AlphaTest()
        {
            var r = new StringRules(_minLength, _maxLength, CharType.Alpha);
            ClassicAssert.IsTrue(r.IsValid(_sLower));
            ClassicAssert.IsTrue(r.IsValid(_sUpper));
            ClassicAssert.IsTrue(r.IsValid(_sUpperLower));
            ClassicAssert.IsFalse(r.IsValid(_sNumeric));
            ClassicAssert.IsFalse(r.IsValid(_sPunctuation));
            ClassicAssert.IsFalse(r.IsValid(_sSentence));
            ClassicAssert.IsFalse(r.IsValid(_sWhitespace));
        }

        [Test]
        public void AlphaUpperTest()
        {
            var r = new StringRules(_minLength, _maxLength, CharType.AlphaUpper);
            ClassicAssert.IsFalse(r.IsValid(_sLower));
            ClassicAssert.IsTrue(r.IsValid(_sUpper));
            ClassicAssert.IsFalse(r.IsValid(_sUpperLower));
            ClassicAssert.IsFalse(r.IsValid(_sNumeric));
            ClassicAssert.IsFalse(r.IsValid(_sPunctuation));
            ClassicAssert.IsFalse(r.IsValid(_sSentence));
            ClassicAssert.IsFalse(r.IsValid(_sWhitespace));
        }

        [Test]
        public void EmptyInputTest()
        {
            var r = new StringRules(_minLength, _maxLength, CharType.All);
            ClassicAssert.IsFalse(r.IsValid(string.Empty));
        }

        [Test]
        public void InvalidCharTypesTest()
        {
            Assert.Throws<ArgumentException>(delegate { new StringRules(_minLength, _maxLength, 0); });
        }

        [Test]
        public void InvalidMaxLengthTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(delegate { new StringRules(10, 8, CharType.AlphaLower); });
        }

        [Test]
        public void InvalidMinLengthTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(delegate { new StringRules(-1, _maxLength, CharType.AlphaLower); });
        }

        [Test]
        public void NullInputTest()
        {
            var r = new StringRules(_minLength, _maxLength, CharType.All);
            ClassicAssert.IsFalse(r.IsValid(null));
        }

        [Test]
        public void NumericTest()
        {
            var r = new StringRules(_minLength, _maxLength, CharType.Numeric);
            ClassicAssert.IsFalse(r.IsValid(_sLower));
            ClassicAssert.IsFalse(r.IsValid(_sUpper));
            ClassicAssert.IsFalse(r.IsValid(_sUpperLower));
            ClassicAssert.IsTrue(r.IsValid(_sNumeric));
            ClassicAssert.IsFalse(r.IsValid(_sPunctuation));
            ClassicAssert.IsFalse(r.IsValid(_sSentence));
            ClassicAssert.IsFalse(r.IsValid(_sWhitespace));
        }

        [Test]
        public void PropertyTest()
        {
            var r = new StringRules(_minLength, _maxLength, CharType.AlphaLower);
            ClassicAssert.AreEqual(_minLength, r.MinLength);
            ClassicAssert.AreEqual(_maxLength, r.MaxLength);
            ClassicAssert.AreEqual(CharType.AlphaLower, r.AllowedChars);
        }

        [Test]
        public void PunctuationTest()
        {
            var r = new StringRules(_minLength, _maxLength, CharType.Punctuation);
            ClassicAssert.IsFalse(r.IsValid(_sLower));
            ClassicAssert.IsFalse(r.IsValid(_sUpper));
            ClassicAssert.IsFalse(r.IsValid(_sUpperLower));
            ClassicAssert.IsFalse(r.IsValid(_sNumeric));
            ClassicAssert.IsTrue(r.IsValid(_sPunctuation));
            ClassicAssert.IsFalse(r.IsValid(_sSentence));
            ClassicAssert.IsFalse(r.IsValid(_sWhitespace));
        }

        [Test]
        public void StringTooLongTest()
        {
            var r = new StringRules(_minLength, _minLength, CharType.Alpha | CharType.Punctuation | CharType.Whitespace);
            ClassicAssert.IsFalse(r.IsValid(_sLower));
            ClassicAssert.IsFalse(r.IsValid(_sUpper));
            ClassicAssert.IsFalse(r.IsValid(_sUpperLower));
            ClassicAssert.IsFalse(r.IsValid(_sNumeric));
            ClassicAssert.IsFalse(r.IsValid(_sPunctuation));
            ClassicAssert.IsFalse(r.IsValid(_sSentence));
            ClassicAssert.IsFalse(r.IsValid(_sWhitespace));
        }

        [Test]
        public void StringTooShortTest()
        {
            var r = new StringRules(_maxLength, _maxLength, CharType.Alpha | CharType.Punctuation | CharType.Whitespace);
            ClassicAssert.IsFalse(r.IsValid(_sLower));
            ClassicAssert.IsFalse(r.IsValid(_sUpper));
            ClassicAssert.IsFalse(r.IsValid(_sUpperLower));
            ClassicAssert.IsFalse(r.IsValid(_sNumeric));
            ClassicAssert.IsFalse(r.IsValid(_sPunctuation));
            ClassicAssert.IsFalse(r.IsValid(_sSentence));
            ClassicAssert.IsFalse(r.IsValid(_sWhitespace));
        }

        [Test]
        public void WhitespaceTest()
        {
            var r = new StringRules(_minLength, _maxLength, CharType.Whitespace);
            ClassicAssert.IsFalse(r.IsValid(_sLower));
            ClassicAssert.IsFalse(r.IsValid(_sUpper));
            ClassicAssert.IsFalse(r.IsValid(_sUpperLower));
            ClassicAssert.IsFalse(r.IsValid(_sNumeric));
            ClassicAssert.IsFalse(r.IsValid(_sPunctuation));
            ClassicAssert.IsFalse(r.IsValid(_sSentence));
            ClassicAssert.IsTrue(r.IsValid(_sWhitespace));
        }

        #endregion
    }
}