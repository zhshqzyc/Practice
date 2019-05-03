using System;

namespace ClosestNumber
{
    class ClosedNumber
    {
        /*
        Given non-zero two integers N and M. The problem is to find the number closest to N and divisible by M. If there are more than one such number, then output the one having maximum absolute value.

        Input:
        The first line consists of an integer T i.e number of test cases. T testcases follow.  The first and only line of each test case contains two space separated integers N and M.

        Output:
        For each testcase, in a new line, print the closest number to N which is also divisible by M.

        Constraints: 
        1 <= T <= 100
        -1000 <= N, M <= 1000

        Example:
        Input:
        2
        13 4
        -15 6
        Output:
        12
        -18
*/
        private const int m = 4;
        static void Main(string[] args)
        {
            int n = 13;
            Console.WriteLine(PrintResult(n));
        }

        private static int PrintResult(int n)
        {
            int forward = n;
            int backward = n;
            if (n % m == 0)
            {
                return n;
            }
            else
            {
                while (forward % m != 0 || backward % m != 0)
                {
                    forward++;
                    backward--;
                    if (forward % m == 0)
                       return forward;
                    else if (backward % m == 0)
                    {
                        return backward;
                    }
                }
            }
            return Int32.MaxValue;
        }
    }
}
