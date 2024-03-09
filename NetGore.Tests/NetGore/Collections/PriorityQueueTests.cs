using System.Linq;
using NetGore.Collections;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace NetGore.Tests.NetGore.Collections
{
    [TestFixture]
    public class PriorityQueueTests
    {
        #region Unit tests

        [Test]
        public void SimpleTest()
        {
            var Test = new PriorityQueue<int>();

            Test.Push(5);
            Test.Push(12);
            Test.Push(1);

            ClassicAssert.IsTrue(Test[0] == 1, "Assert1 (should == 1) + " + Test[0]);
            var i = Test.Pop();
            ClassicAssert.IsTrue(i == 1, "i should equal 1" + i);

            ClassicAssert.IsTrue(Test[0] == 5, "Assert2 (should == 5) + " + Test[0]);
            i = Test.Pop();
            ClassicAssert.IsTrue(i == 5, "i should equal 5" + i);

            ClassicAssert.IsTrue(Test[0] == 12, "Assert3 (should == 12) + " + Test[0]);
            i = Test.Pop();
            ClassicAssert.IsTrue(i == 12, "i should = 12" + i);

            Test.Push(11);
            Test.Push(10);
            Test.Push(9);
            Test.Push(8);

            Test.RemoveLocation(9);
            ClassicAssert.IsTrue(Test[0] == 8, "Assert5 (Should equal 8) + " + Test[0]);

            Test.Push(11);
            Test.Push(10);
            Test.Push(9);
            Test.Push(8);

            ClassicAssert.IsTrue(Test.Count == 7, "Assert6 (Should equal 7) + " + Test.Count);
            ClassicAssert.IsTrue(Test.Peek() == 8, "Assert7 (Should equal 8) + " + Test.Peek());
            ClassicAssert.IsTrue(Test.Pop() == 8, "Assert8 (Should equal 8)");
            ClassicAssert.IsTrue(Test.Pop() == 8, "Assert8++ (should equal 8)");
            ClassicAssert.IsTrue(Test.Peek() == 9, "Assert9 (Should equal 9) + " + Test.Peek());
            Test.RemoveLocation(9);
            ClassicAssert.IsTrue(Test.Peek() == 10);

            Test.Clear();

            ClassicAssert.IsTrue(Test.Count == 0, "Assert10 (Should equal 0) + " + Test.Count);
        }

        #endregion
    }
}