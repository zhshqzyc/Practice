using System;

namespace ReverseDigits
{
    class ReverseDigits
    {
        /*
            Write a program to reverse digits of a number N.

            Input:
            The first line of input contains an integer T, denoting the number of test cases. T testcases follow. Each test case contains an integer N.

            Output:
            For each test case, print the reverse digits of number N .

            Constraints:
            1 ≤ T ≤ 104
            1 ≤ N ≤ 1015

            Example:
            Input:
            2
            200
            122
            Output:
            2
            221
         * */
        static void Main(string[] args)
        {
            int n = 200;
            var arr = n.ToString();
            var newArr = new char[arr.Length];
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                newArr[arr.Length - 1 - i] = arr[i];
            }
            Console.WriteLine(new string(newArr).TrimStart('0'));
        }
    }
}
