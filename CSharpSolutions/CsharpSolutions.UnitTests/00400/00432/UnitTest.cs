using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSolutions._00400._00432;

namespace CsharpSolutions.UnitTests._00400._00432
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void VoidTest()
        {
            var a = new AllOne();
            Assert.AreEqual("", a.GetMinKey(), "No min key when no elements");
            Assert.AreEqual("", a.GetMaxKey(),  "No max key when no elements");
        }

        [TestMethod]
        public void OneElement()
        {
            var a = new AllOne();
            a.Inc("first");
            Assert.AreEqual("first", a.GetMinKey(), "Min should be first key");
            Assert.AreEqual("first", a.GetMaxKey(), "Max should be first key");
            a.Dec("first");
            Assert.AreEqual("", a.GetMinKey(), "No min key when all elements removed");
            Assert.AreEqual("", a.GetMaxKey(), "No max key when all elements removed");
        }

        [TestMethod]
        public void TwoElements()
        {
            var a = new AllOne();
            a.Inc("first");
            a.Inc("second");
            a.Inc("second");
            Assert.AreEqual("first", a.GetMinKey(),  "Min should be first key");
            Assert.AreEqual("second", a.GetMaxKey(), "Max should be second key");
            a.Dec("second");
            a.Dec("second");
            Assert.AreEqual("first", a.GetMinKey(), "Min should be first key");
            Assert.AreEqual("first", a.GetMaxKey(), "Max should be first key");
            a.Dec("first");
            Assert.AreEqual("", a.GetMinKey(), "No min key when all elements removed");
            Assert.AreEqual("", a.GetMaxKey(), "No max key when all elements removed");
        }

        [TestMethod]
        public void LeetCodeCase2Of15()
        {
            //["AllOne","inc","inc","getMaxKey","getMinKey","inc","getMaxKey","getMinKey"]
            //[[],["hello"],["hello"],[],[],["leet"],[],[]]

            var a = new AllOne();
            a.Inc("hello");
            a.Inc("hello");
            Assert.AreEqual("hello", a.GetMaxKey(), "Max should be hello");
            Assert.AreEqual("hello", a.GetMinKey(), "Min should be hello");
            a.Inc("leet");
            Assert.AreEqual("hello", a.GetMaxKey(), "Max should be hello");
            Assert.AreEqual("leet", a.GetMinKey(), "Min should be leet");


        }
    }
}
