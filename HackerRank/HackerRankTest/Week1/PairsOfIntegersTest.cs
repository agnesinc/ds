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
    }
}
