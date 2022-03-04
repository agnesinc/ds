using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Week1
{
    public class FlippingMatrix
    {
        

        /*
* Sean invented a game involving a
matrix where each cell of the matrix contains an integer. Hecan reverse any of its rows or columns any number of times. The goal of the game is to maximize the sumof the elements in the
submatrix located in the upper-left quadrant of the matrix.
Given the initial configurations for
matrices, help Sean reverse the rows and columns of each matrix in thebest possible way so that the sum of the elements in the matrix's upper-left quadrant is maximal.
Example
1
2
3
4
It is
and we want to maximize the top left quadrant, a
matrix. Reverse row
:
1
2
4
3
And now reverse column
:
4
2
1
3
The maximal sum is
.
Function Description
Complete the
flippingMatrix
function in the editor below.
flippingMatrix has the following parameters:
-
int matrix[2n][2n]:
a 2-dimensional array of integers
Returns
-
int:
the maximum sum possible.
*/
        public static int PerformTask(List<List<int>> matrix)
        {
            int n = matrix.Count;
            int sum = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    list.Clear();
                    list.Add(matrix[i][j]);
                    list.Add(matrix[i][n - j - 1]);
                    list.Add(matrix[n - i - 1][j]);
                    list.Add(matrix[n - i - 1][n - j - 1]);
                    sum += list.Max();
                }
            }
            return sum;
        }


        public static long Solution(string s)
        {
            // Type your solution here

            List<char> characters= new List<char>();
            List<int> counts = new List<int>();
            int count = 0;
            //nnnabcddgkopnn
            foreach (char c in s)
            {
                if (!characters.Contains(c))
                {
                    characters.Add(c);
                    //count += 1;
                }
                else
                {
                    counts.Add(characters.Count());
                    //count = 0;
                    characters.Clear();
                    characters.Add(c);
                }
            }

            return counts.Max();

        }


    }
}

