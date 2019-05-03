using System;

namespace ArmstrongNumbers
{
    class ArmstrongNumbers
    {
        /*
        For a given 3 digit number, find whether it is armstrong number or not. An Armstrong number of three digits is an integer such that the sum of the cubes of its digits is equal to the number itself. For example, 371 is an Armstrong number since 33 + 73 + 13 = 371

        Input:
        First line contains an integer, the number of test cases 'T'. T testcases follow. Each test case contains a positive integer N.

        Output:
        For each testcase, in a new line, print "Yes" if it is a armstrong number else print "No".

        Constraints:
        1 <= T <= 31
        100 <= N < 1000

        Example:
        Input:
        1
        371
        Output:
        Yes
        */
        static void Main(string[] args)
        {
            int number = 371;
            var result = IsNumberArmstrongNumber(number);
            Console.WriteLine(result ? "YES" : "NO");
        }

        private static bool IsNumberArmstrongNumber(int number)
        {
            var str = number.ToString();
            var chars = str.ToCharArray();
            int result = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                var x = Convert.ToInt32(chars[i].ToString());
                result += x * x * x;
            }
            if (result.ToString() == str)
                return true;
            return false;
        }
    }
}
