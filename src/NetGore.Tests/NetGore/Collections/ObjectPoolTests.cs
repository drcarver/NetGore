using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using NetGore.Collections;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace NetGore.Tests.Collections
{
    [TestFixture]
    public class ObjectPoolTests
    {
        static ObjectPool<MyTestObj> CreateTestPool()
        {
            return new ObjectPool<MyTestObj>(x => new MyTestObj(), null, null, false);
        }

        #region Unit tests

        [Test]
        public void ClearTest()
        {
            var pool = CreateTestPool();
            for (var i = 0; i < 25; i++)
            {
                pool.Acquire();
            }

            ClassicAssert.AreEqual(25, pool.LiveObjects);

            pool.Clear();
            ClassicAssert.AreEqual(0, pool.LiveObjects);
        }

        [Test]
        public void ExtensiveAllocationTest()
        {
            var pool = CreateTestPool();
            var objs = new List<MyTestObj>(1000);
            var expectedLive = 0;

            for (var i = 0; i < 1000; i++)
            {
                objs.Add(pool.Acquire());
                expectedLive++;
            }

            ClassicAssert.AreEqual(expectedLive, pool.LiveObjects);

            for (var i = 250; i < 150; i -= 2)
            {
                pool.Free(objs[i]);
                objs.RemoveAt(i);
                expectedLive--;
            }

            ClassicAssert.AreEqual(expectedLive, pool.LiveObjects);

            for (var i = 0; i < 50; i += 2)
            {
                objs.Add(pool.Acquire());
                expectedLive++;
            }

            ClassicAssert.AreEqual(expectedLive, pool.LiveObjects);

            foreach (var obj in objs)
            {
                pool.Free(obj);
            }

            ClassicAssert.AreEqual(0, pool.LiveObjects);
        }

        [Test]
        public void FreeAllNullParameterTest()
        {
            var pool = CreateTestPool();

            Assert.Throws<ArgumentNullException>(() => pool.FreeAll(null));
        }

        [Test]
        public void FreeAllTest()
        {
            var pool = CreateTestPool();
            MyTestObj testObj = null;
            for (var i = 0; i < 25; i++)
            {
                testObj = pool.Acquire();
            }

            ClassicAssert.AreEqual(25, pool.LiveObjects);

            pool.FreeAll(x => x == null);
            ClassicAssert.AreEqual(25, pool.LiveObjects);

            pool.FreeAll(x => x == testObj);
            ClassicAssert.AreEqual(24, pool.LiveObjects);

            pool.FreeAll(x => x == testObj);
            ClassicAssert.AreEqual(24, pool.LiveObjects);

            pool.FreeAll(x => x != testObj);
            ClassicAssert.AreEqual(0, pool.LiveObjects);
        }

        [Test]
        public void FreeInvalidObjectTest()
        {
            var pool = CreateTestPool();

            pool.Free(new MyTestObj());
        }

        [Test]
        public void FreeNullParameterTest()
        {
            var pool = CreateTestPool();

            Assert.Throws<ArgumentNullException>(() => pool.Free(null));
        }

        [Test]
        public void NullCreatorTest()
        {
            Assert.Throws<ArgumentNullException>(() => new ObjectPool<MyTestObj>(null, false));
        }

        [Test]
        public void SimpleAllocationTest()
        {
            var pool = CreateTestPool();
            ClassicAssert.AreEqual(0, pool.LiveObjects);

            var obj = pool.Acquire();
            ClassicAssert.AreEqual(1, pool.LiveObjects);

            pool.Free(obj);
            ClassicAssert.AreEqual(0, pool.LiveObjects);
        }

        #endregion

        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public class MyTestObj : IPoolable
        {
            #region IPoolable Members

            /// <summary>
            /// Gets or sets the index of the object in the pool. This value should never be used by anything
            /// other than the pool that owns this object.
            /// </summary>
            public int PoolIndex { get; set; }

            #endregion
        }
    }
}