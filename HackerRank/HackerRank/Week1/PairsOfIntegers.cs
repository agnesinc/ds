using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Week1
{
    public class PairsOfIntegers
    {

        public static List<List<int>> GetPairs(List<int> inputList)
        {
            var listOfLists = new List<List<int>>();



            for (int i = 0; i < inputList.Count(); i++)
            {
                var tempList = new List<int>();

                var element = inputList[i];

                int prevElement = -1;

                if (i != 0)
                    prevElement = inputList[i - 1];


                if (element == prevElement + 1)
                {
                    tempList.Add(element);
                }
                else
                {
                    listOfLists.Add(new List<int> { element });
                    tempList.Clear();
                }
            }
            return listOfLists;
        }
    }
}
