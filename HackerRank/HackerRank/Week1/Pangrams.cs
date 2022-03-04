using System.Linq;

namespace HackerRank.Week1
{
    /*
        A pangram is a string that contains every letter of the alphabet. Given a sentence determine whether it is a pangram in the English alphabet. Ignore case. Return either pangram or not pangram as appropriate.

        Example

        The string contains all letters in the English alphabet, so return pangram.

        Function Description

        Complete the function pangrams in the editor below. It should return the string pangram if the input string is a pangram. Otherwise, it should return not pangram.

        pangrams has the following parameter(s):

        string s: a string to test
        Returns

        string: either pangram or not pangram
        Input Format

        A single line with string .

        Constraints


        Each character of , 

        Sample Input

        Sample Input 0

        We promptly judged antique ivory buckles for the next prize

        Sample Output 0

        pangram

        Sample Explanation 0

        All of the letters of the alphabet are present in the string.

        Sample Input 1

        We promptly judged antique ivory buckles for the prize

        Sample Output 1

        not pangram

        Sample Explanation 0

        The string lacks an x.
     
    */
    public class Pangrams
    {
        public static string pangrams(string s)
        {
            /*
             Checking the ASCII value and find char for that ASCII value char in incoming string
             Note the way to get an ASCII value of a char and vice versa
            */
            s = s.ToLower();
            bool isPangram = false;
            for (int i = 97; i < 123; i++)
            {
                isPangram = s.Any(c => c == (char)i);
                if (!isPangram)
                    break;
            }
            return isPangram == true ? "pangram" : "not pangram";
        }

    }
}
