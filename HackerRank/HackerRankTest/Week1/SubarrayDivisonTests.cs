using HackerRank.Week1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HackerRankTest
{
    [TestClass]
    public class SubarrayDivisonTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = SubarrayDivison.Birthday(new List<int> { 5, 5, 3, 2, 2,2, 1, 2, 5, 3, 5, 5, 4, 3, 3, 5 }, 13,3);

            Assert.AreEqual(result, 3);
        }
    }
}
