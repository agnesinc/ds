using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Week1
{
    public class PairsOfIntegers
    {
        // Function to find consecutive ranges
        public static List<String> consecutiveRanges(int[] a)
        {
            int length = 1;
            List<String> list = new List<String>();

            // If the array is empty,
            // return the list
            if (a.Length == 0)
            {
                return list;
            }

            // Traverse the array from first position
            for (int i = 1; i <= a.Length; i++)
            {

                // Check the difference between the
                // current and the previous elements
                // If the difference doesn't equal to 1
                // just increment the length variable.
                if (i == a.Length || a[i] - a[i - 1] != 1)
                {

                    // If the range contains
                    // only one element.
                    // add it into the list.
                    if (length == 1)
                    {
                        list.Add(
                            String.Join("", a[i - length]));
                    }
                    else
                    {

                        // Build the range between the first
                        // element of the range and the
                        // current previous element as the
                        // last range.
                        list.Add(a[i - length] +
                        " -> " + a[i - 1]);
                    }

                    // After finding the first range
                    // initialize the length by 1 to
                    // build the next range.
                    length = 1;
                }
                else
                {
                    length++;
                }
            }
            return list;
        }

        public static List<List<int>> GetPairs(List<int> inputList)
        {
            var listOfLists = new List<List<int>>();

            //bool increamented = false;
            var tempList = new List<int>();
            for (int i = 0; i < inputList.Count(); i++)
            {

                var element = inputList[i];

                if (i == 0)
                    tempList.Add(element);
                else
                {
                    var prevElement = inputList[i - 1];
                    if (element != prevElement + 1)
                    {
                        listOfLists.Add(tempList);
                        tempList.Clear();
                        tempList.Add(element);
                    }
                    else
                    {
                        listOfLists.Add(new List<int> { element });
                    }
                }
            }
            listOfLists.Add(tempList);
            return listOfLists;
        }


    }
}
