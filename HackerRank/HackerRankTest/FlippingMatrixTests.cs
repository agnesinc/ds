using HackerRank.Week1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HackerRankTest
{
    [TestClass]
    public class FlippingMatrixTests
    {
        [TestMethod]
        public void TestMethod1()
        {

            int result = FlippingMatrix.PerformTask(new List<List<int>> { new List<int> { 112,42,83,119 }, new List<int> { 56,125,56,49} , new List<int> { 15,78,101,43 } , new List<int> { 62,98,114,108 } });

            Assert.AreEqual(result, 414);


            int result1 = FlippingMatrix.PerformTask(new List<List<int>> { new List<int> { 107, 54, 128, 15 }, new List<int> { 12, 75, 110, 138 }, new List<int> { 100, 96, 34, 85 }, new List<int> { 75, 15, 28, 112 } });

            Assert.AreEqual(result1, 488);
        }

        [TestMethod]
        public void TestMethod2()
        {
            long result = FlippingMatrix.Solution("aabcdd");
            Assert.AreEqual(result, 4);
            long result2 = FlippingMatrix.Solution("nndNfdfdf");
            Assert.AreEqual(result2, 4);

            long result1 = FlippingMatrix.Solution("nnnabcddgkopxznn");
            Assert.AreEqual(result1, 8);

        }
        }
    }
