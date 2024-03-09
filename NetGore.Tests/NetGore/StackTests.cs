using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace NetGore.Tests.NetGore
{
    [TestFixture]
    public class StackTests
    {
        #region Unit tests

        [Test]
        public void SortAscTest()
        {
            var rnd = new Random();
            var s = new Stack<int>();

            for (var i = 0; i < 100; i++)
            {
                s.Push(rnd.Next(0, 1000));
            }

            s.Sort();

            ClassicAssert.AreEqual(100, s.Count);

            var last = s.Pop();
            while (s.Count > 0)
            {
                var popped = s.Pop();
                ClassicAssert.LessOrEqual(last, popped);
                last = popped;
            }
        }

        [Test]
        public void SortAscWhereTest()
        {
            var rnd = new Random();
            var s = new Stack<int>();

            for (var i = 0; i < 100; i++)
            {
                s.Push(rnd.Next(0, 1000));
            }

            s.Sort(item => item > 500);

            var last = s.Pop();

            ClassicAssert.LessOrEqual(500, last);

            while (s.Count > 0)
            {
                var popped = s.Pop();
                ClassicAssert.LessOrEqual(last, popped);
                last = popped;
            }
        }

        [Test]
        public void SortDescTest()
        {
            var rnd = new Random();
            var s = new Stack<int>();

            for (var i = 0; i < 100; i++)
            {
                s.Push(rnd.Next(0, 1000));
            }

            s.SortDescending();

            ClassicAssert.AreEqual(100, s.Count);

            var last = s.Pop();
            while (s.Count > 0)
            {
                var popped = s.Pop();
                ClassicAssert.GreaterOrEqual(last, popped);
                last = popped;
            }
        }

        [Test]
        public void SortDescWhereTest()
        {
            var rnd = new Random();
            var s = new Stack<int>();

            for (var i = 0; i < 100; i++)
            {
                s.Push(rnd.Next(0, 1000));
            }

            s.SortDescending(item => item < 500);

            var last = s.Pop();

            ClassicAssert.GreaterOrEqual(500, last);

            while (s.Count > 0)
            {
                var popped = s.Pop();
                ClassicAssert.GreaterOrEqual(last, popped);
                last = popped;
            }
        }

        #endregion
    }
}