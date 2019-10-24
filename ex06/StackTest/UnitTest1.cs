using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem2;

namespace StackTest
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void CheckPut()
        {
            Stack s1 = new Stack(10);
            s1.Put(1);
            s1.Put(2);
            s1.Put(3);
            s1.Put(4);
            Assert.AreEqual(3, s1.Count());
        }
        [TestMethod]
        public void checkPop()
        {
            Stack s2 = new Stack(10);
            s2.Put(1);
            s2.Put(2);
            s2.Put(3);
            s2.Put(4);
            Assert.AreEqual(4, s2.Pop());
        }
        [TestMethod]
        public void checkPeek()
        {
            Stack s3 = new Stack(10);
            s3.Put(1);
            s3.Put(2);
            s3.Put(3);
            s3.Put(4);
            Assert.AreEqual(4, s3.Peek());
        }
        [TestMethod]
        public void checkCount()
        {
            Stack s4 = new Stack(10);
            s4.Put(1);
            s4.Put(2);
            s4.Put(3);
            s4.Put(4);
            Assert.AreEqual(3, s4.Count());
        }
        [TestMethod]
        public void checkClear()
        {

        }
    }
}