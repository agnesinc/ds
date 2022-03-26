using HackerRank.Week1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HackerRankTest
{
    [TestClass]
    public class PairsOfIntegersTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            PairsOfIntegers.GetPairs(new List<int> { 1, 3, 4 });
        }

        [TestMethod]
        public void TestMethod2()
        {
            PairsOfIntegers.consecutiveRanges(new int[] { 1,3, 4, 5, 6, 7, 8 });
        }
    }
}
