using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Week1
{
    public class SubarrayDivison
    {
        public static int Birthday(List<int> s, int d, int m)
        {
            int pieces = 0;

            int n = s.Count();

            for (int i = 0; i <= n-m; i++)
            {
                int total = 0;
                for (int j = 0; j < m; j++)
                {
                    int index = j + i;
                    if (index > n - 1)
                        index = n - 1;

                    Console.WriteLine("index" + index);

                    total += s[index];

                    Console.WriteLine("total" + total);

                }
                if (total == d)
                    pieces += 1;

            }

            return pieces;
        }


    }
}
