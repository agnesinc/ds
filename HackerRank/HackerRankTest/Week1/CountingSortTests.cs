using HackerRank.Week1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HackerRankTest
{
    [TestClass]
    public class CountingSortTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            CountingSort.PerformAction(new List<int> { 1, 1,3,2,1 });
        }
    }
}
