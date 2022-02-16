using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Week1
{
    static public class CountingSort
    {

        public static List<int> PerformAction(List<int> arr)
        {

            var max = arr.Max();

            var counting = new List<int>();

            for (int i = 0; i <= max; i++)
                counting.Add(0);

            for (int i = 0; i < arr.Count(); i++)
            {
                var value = arr[i];

                counting[value] += 1;

            }

            foreach (var item in counting)
            {
                Console.WriteLine(item);
            }

            return arr;
        }

    }
}
