using System.Collections.Generic;
using System.Linq;
using NetGore.Stats;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace NetGore.Tests.Stats
{
    [TestFixture]
    public class StatCollectionTests
    {
        static IEnumerable<IStatCollection<ST>> CreateStatCollections()
        {
            return new IStatCollection<ST>[] { new StatCollection<ST>(StatCollectionType.Base) };
        }

        #region Unit tests

        [Test]
        public void DeepCopyTest()
        {
            foreach (var c in CreateStatCollections())
            {
                c.SetAll(50);
                c[ST.A] = 10;

                var copy = c.DeepCopy();
                ClassicAssert.AreNotSame(copy, c);
                ClassicAssert.IsTrue(c.HasSameValues(copy));
                ClassicAssert.AreEqual(c.StatCollectionType, copy.StatCollectionType);

                c[ST.A] = 15;

                ClassicAssert.AreEqual((int) c[ST.A], 15);
                ClassicAssert.AreEqual((int) copy[ST.A], 10);
            }
        }

        [Test]
        public void HasAllGreaterOrEqualValuesTest()
        {
            var b = new StatCollection<ST>(StatCollectionType.Base);
            b[ST.A] = 10;
            b[ST.B] = 11;

            foreach (var c in CreateStatCollections())
            {
                c[ST.A] = 10;
                c[ST.B] = 11;

                ClassicAssert.IsTrue(c.HasAllGreaterOrEqualValues(b));
                ClassicAssert.IsTrue(b.HasAllGreaterOrEqualValues(c));

                c[ST.A] = 11;
                ClassicAssert.IsTrue(c.HasAllGreaterOrEqualValues(b));
                ClassicAssert.IsFalse(b.HasAllGreaterOrEqualValues(c));

                c[ST.A] = 10;
                c[ST.B] = 12;
                ClassicAssert.IsTrue(c.HasAllGreaterOrEqualValues(b));
                ClassicAssert.IsFalse(b.HasAllGreaterOrEqualValues(c));

                c[ST.A] = 11;
                c[ST.B] = 12;
                ClassicAssert.IsTrue(c.HasAllGreaterOrEqualValues(b));
                ClassicAssert.IsFalse(b.HasAllGreaterOrEqualValues(c));

                c[ST.A] = 9;
                c[ST.B] = 12;
                ClassicAssert.IsFalse(c.HasAllGreaterOrEqualValues(b));
                ClassicAssert.IsFalse(b.HasAllGreaterOrEqualValues(c));

                c[ST.A] = 10;
                c[ST.B] = 10;
                ClassicAssert.IsFalse(c.HasAllGreaterOrEqualValues(b));
                ClassicAssert.IsTrue(b.HasAllGreaterOrEqualValues(c));

                c[ST.A] = 5;
                c[ST.B] = 5;
                ClassicAssert.IsFalse(c.HasAllGreaterOrEqualValues(b));
                ClassicAssert.IsTrue(b.HasAllGreaterOrEqualValues(c));
            }
        }

        [Test]
        public void HasAllGreaterValuesTest()
        {
            var b = new StatCollection<ST>(StatCollectionType.Base);
            b[ST.A] = 10;
            b[ST.B] = 11;

            foreach (var c in CreateStatCollections())
            {
                c[ST.A] = 10;
                c[ST.B] = 11;

                ClassicAssert.IsFalse(c.HasAllGreaterValues(b));
                ClassicAssert.IsFalse(b.HasAllGreaterValues(c));

                c[ST.A] = 11;
                ClassicAssert.IsFalse(c.HasAllGreaterValues(b));
                ClassicAssert.IsFalse(b.HasAllGreaterValues(c));

                c[ST.A] = 10;
                c[ST.B] = 12;
                ClassicAssert.IsFalse(c.HasAllGreaterValues(b));
                ClassicAssert.IsFalse(b.HasAllGreaterValues(c));

                c[ST.A] = 11;
                c[ST.B] = 12;
                ClassicAssert.IsTrue(c.HasAllGreaterValues(b));
                ClassicAssert.IsFalse(b.HasAllGreaterValues(c));

                c[ST.A] = 9;
                c[ST.B] = 12;
                ClassicAssert.IsFalse(c.HasAllGreaterValues(b));
                ClassicAssert.IsFalse(b.HasAllGreaterValues(c));

                c[ST.A] = 10;
                c[ST.B] = 10;
                ClassicAssert.IsFalse(c.HasAllGreaterValues(b));
                ClassicAssert.IsFalse(b.HasAllGreaterValues(c));

                c[ST.A] = 5;
                c[ST.B] = 5;
                ClassicAssert.IsFalse(c.HasAllGreaterValues(b));
                ClassicAssert.IsTrue(b.HasAllGreaterValues(c));
            }
        }

        [Test]
        public void HasAnyGreaterOrEqualValuesTest()
        {
            var b = new StatCollection<ST>(StatCollectionType.Base);
            b[ST.A] = 10;
            b[ST.B] = 11;

            foreach (var c in CreateStatCollections())
            {
                c[ST.A] = 10;
                c[ST.B] = 11;

                ClassicAssert.IsTrue(c.HasAnyGreaterOrEqualValues(b));
                ClassicAssert.IsTrue(b.HasAnyGreaterOrEqualValues(c));

                c[ST.A] = 11;
                ClassicAssert.IsTrue(c.HasAnyGreaterOrEqualValues(b));
                ClassicAssert.IsTrue(b.HasAnyGreaterOrEqualValues(c));

                c[ST.A] = 10;
                c[ST.B] = 12;
                ClassicAssert.IsTrue(c.HasAnyGreaterOrEqualValues(b));
                ClassicAssert.IsTrue(b.HasAnyGreaterOrEqualValues(c));

                c[ST.A] = 11;
                c[ST.B] = 12;
                ClassicAssert.IsTrue(c.HasAnyGreaterOrEqualValues(b));
                ClassicAssert.IsFalse(b.HasAnyGreaterOrEqualValues(c));

                c[ST.A] = 9;
                c[ST.B] = 12;
                ClassicAssert.IsTrue(c.HasAnyGreaterOrEqualValues(b));
                ClassicAssert.IsTrue(b.HasAnyGreaterOrEqualValues(c));

                c[ST.A] = 10;
                c[ST.B] = 10;
                ClassicAssert.IsTrue(c.HasAnyGreaterOrEqualValues(b));
                ClassicAssert.IsTrue(b.HasAnyGreaterOrEqualValues(c));

                c[ST.A] = 5;
                c[ST.B] = 5;
                ClassicAssert.IsFalse(c.HasAnyGreaterOrEqualValues(b));
                ClassicAssert.IsTrue(b.HasAnyGreaterOrEqualValues(c));
            }
        }

        [Test]
        public void HasAnyGreaterValuesTest()
        {
            var b = new StatCollection<ST>(StatCollectionType.Base);
            b[ST.A] = 10;
            b[ST.B] = 11;

            foreach (var c in CreateStatCollections())
            {
                c[ST.A] = 10;
                c[ST.B] = 11;

                ClassicAssert.IsFalse(c.HasAnyGreaterValues(b));
                ClassicAssert.IsFalse(b.HasAnyGreaterValues(c));

                c[ST.A] = 11;
                ClassicAssert.IsTrue(c.HasAnyGreaterValues(b));
                ClassicAssert.IsFalse(b.HasAnyGreaterValues(c));

                c[ST.A] = 10;
                c[ST.B] = 12;
                ClassicAssert.IsTrue(c.HasAnyGreaterValues(b));
                ClassicAssert.IsFalse(b.HasAnyGreaterValues(c));

                c[ST.A] = 11;
                c[ST.B] = 12;
                ClassicAssert.IsTrue(c.HasAnyGreaterValues(b));
                ClassicAssert.IsFalse(b.HasAnyGreaterValues(c));

                c[ST.A] = 9;
                c[ST.B] = 12;
                ClassicAssert.IsTrue(c.HasAnyGreaterValues(b));
                ClassicAssert.IsTrue(b.HasAnyGreaterValues(c));

                c[ST.A] = 10;
                c[ST.B] = 10;
                ClassicAssert.IsFalse(c.HasAnyGreaterValues(b));
                ClassicAssert.IsTrue(b.HasAnyGreaterValues(c));

                c[ST.A] = 5;
                c[ST.B] = 5;
                ClassicAssert.IsFalse(c.HasAnyGreaterValues(b));
                ClassicAssert.IsTrue(b.HasAnyGreaterValues(c));
            }
        }

        [Test]
        public void HasSameValuesTest()
        {
            var b = new StatCollection<ST>(StatCollectionType.Base);
            b[ST.A] = 10;
            b[ST.B] = 11;

            foreach (var c in CreateStatCollections())
            {
                c[ST.A] = 0;
                c[ST.B] = 0;

                ClassicAssert.IsFalse(c.HasSameValues(b));
                ClassicAssert.IsFalse(b.HasSameValues(c));

                c[ST.A] = 10;

                ClassicAssert.IsFalse(c.HasSameValues(b));
                ClassicAssert.IsFalse(b.HasSameValues(c));

                c[ST.B] = 11;

                ClassicAssert.IsTrue(c.HasSameValues(b));
                ClassicAssert.IsTrue(b.HasSameValues(c));

                c[ST.A] = 0;

                ClassicAssert.IsFalse(c.HasSameValues(b));
                ClassicAssert.IsFalse(b.HasSameValues(c));
            }
        }

        [Test]
        public void SetAllTest()
        {
            foreach (var c in CreateStatCollections())
            {
                c.SetAll(50);
                foreach (var v in c)
                {
                    ClassicAssert.AreEqual(50, (int) v.Value);
                }

                c.SetAll(75);
                foreach (var v in c)
                {
                    ClassicAssert.AreEqual(75, (int) v.Value);
                }
            }
        }

        [Test]
        public void StatChangedTest()
        {
            foreach (var c in CreateStatCollections())
            {
                var changed = false;

                ClassicAssert.IsFalse(changed);

                c[ST.A] = 1;

                ClassicAssert.IsFalse(changed);

                c.StatChanged += delegate { changed = true; };

                ClassicAssert.IsFalse(changed);

                c[ST.A] = 1;

                ClassicAssert.IsFalse(changed);

                c[ST.A] = 2;

                ClassicAssert.IsTrue(changed);
            }
        }

        #endregion

        enum ST : byte
        {
            A,
            B
        }
    }
}