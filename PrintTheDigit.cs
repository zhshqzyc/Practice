using System;

namespace PrintTheKthDigit
{
    class PrintTheDigit
    {
        /*
          Given two numbers A and B, find Kth digit from right of AB.

            Input:
            The first line of the input contains T denoting the number of test cases. T testcases follow.  Each of the next T lines contains three space separated positive integers denoting the value of a , b and k respectively.

            Output:
            For each test case, in a new line, output the Kth digit from right of AB in new line.

            Constraints:
            1 <= T <= 100
            1 <= A , B <=15
            1 <= K <= |totaldigits in AB|

            Example:
            Input:
            2
            3 3 1
            5 2 2
            Output:
            7
            2
         * */
        static void Main(string[] args)
        {
            int a = 3;
            int b = 3;
            int k = 1;
            long result = (long)Math.Pow(a, b);
            int count = 1;
            if (k != count)
            {
                while (k != count)
                {
                    count++;
                    int remainder = (int)(result % 10);
                    result = result / 10;
                }
            }
            result = result % 10;
            Console.WriteLine(result);
        }
    }
}
