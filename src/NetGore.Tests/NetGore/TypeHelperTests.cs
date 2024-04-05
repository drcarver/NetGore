using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace NetGore.Tests.NetGore
{
    [TestFixture]
    public class TypeHelperTests
    {
        static Type GetNestedType(Type type, string typeName)
        {
            return type.GetNestedType(typeName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
        }

        #region Unit tests

        [Test]
        public void IsClassTypeTreePublicTest()
        {
            var a = typeof(A);
            var aa = GetNestedType(a, "AA");
            var aaa = GetNestedType(aa, "AAA");
            var aab = GetNestedType(aa, "AAB");

            var b = typeof(B);
            var ba = GetNestedType(b, "BA");
            var bb = GetNestedType(b, "BB");
            var bba = GetNestedType(bb, "BBA");

            ClassicAssert.IsTrue(TypeHelper.IsClassTypeTreePublic(a));
            ClassicAssert.IsFalse(TypeHelper.IsClassTypeTreePublic(aa));
            ClassicAssert.IsFalse(TypeHelper.IsClassTypeTreePublic(aaa));
            ClassicAssert.IsFalse(TypeHelper.IsClassTypeTreePublic(aab));

            ClassicAssert.IsFalse(TypeHelper.IsClassTypeTreePublic(b));
            ClassicAssert.IsFalse(TypeHelper.IsClassTypeTreePublic(ba));
            ClassicAssert.IsFalse(TypeHelper.IsClassTypeTreePublic(bb));
            ClassicAssert.IsFalse(TypeHelper.IsClassTypeTreePublic(bba));

            ClassicAssert.IsTrue(TypeHelper.IsClassTypeTreePublic(typeof(TypeHelperTests)));
        }

        [Test]
        public void NonNullableToNullableInvalid2Test()
        {
            Assert.Throws<ArgumentException>(() => TypeHelper.NonNullableToNullable(typeof(string)));
        }

        [Test]
        public void NonNullableToNullableInvalidTest()
        {
            Assert.Throws<ArgumentException>(() => TypeHelper.NonNullableToNullable(typeof(object)));
        }

        [Test]
        public void NonNullableToNullableValidAlreadyNullableTest()
        {
            var t = TypeHelper.NonNullableToNullable(typeof(int?));
            ClassicAssert.AreEqual(typeof(int?), t);
        }

        [Test]
        public void NonNullableToNullableValidTest()
        {
            var t = TypeHelper.NonNullableToNullable(typeof(int));
            ClassicAssert.AreEqual(typeof(int?), t);
        }

        [Test]
        public void NullableToNonNullableInvalid2Test()
        {
            Assert.Throws<ArgumentException>(() => TypeHelper.NullableToNonNullable(typeof(object)));
        }

        [Test]
        public void NullableToNonNullableInvalid3Test()
        {
            Assert.Throws<ArgumentException>(() => TypeHelper.NullableToNonNullable(typeof(string)));
        }

        [Test]
        public void NullableToNonNullableInvalidTest()
        {
            Assert.Throws<ArgumentException>(() => TypeHelper.NullableToNonNullable(typeof(int)));
        }

        [Test]
        public void NullableToNonNullableValidTest()
        {
            var t = TypeHelper.NullableToNonNullable(typeof(int?));
            ClassicAssert.AreEqual(typeof(int), t);
        }

        #endregion

        [SuppressMessage("Microsoft.Design", "CA1053:StaticHolderTypesShouldNotHaveConstructors")]
        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public class A
        {
            class AA
            {
                public class AAA
                {
                }

                class AAB
                {
                }
            }
        }

        class B
        {
            public class BA
            {
            }

            class BB
            {
                public class BBA
                {
                }
            }
        }
    }
}