using System;

namespace SumOfDigitPalindrome
{
    /*
         * Write a program to check if the sum of digits of a given number N is a palindrome number or not.

            Input:
            The first line of the input contains T denoting the number of testcases. T testcases follow. Then each of the T lines contains single positive integer N denoting the value of number.

            Output:
            For each testcase, in a new line, output "YES" if pallindrome else "NO". (without the quotes)

            Constraints:
            1 <= T <= 200
            1 <= N <= 1000

            Example:
            Input:
            2
            56
            98
            Output:
            YES
            NO
*/
    class SumOfDigitPalindrome
    {
        static void Main(string[] args)
        {
            int number = 560;
            bool result = IsDigitPalindrome(number);
            Console.WriteLine(result ? "YES" : "NO");
            number = 89;
            result = IsDigitPalindrome(number);
            Console.WriteLine(result ? "YES" : "NO");
        }

        private static bool IsDigitPalindrome(int number)
        {
            var arr = number.ToString().ToCharArray();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count += Int32.Parse(arr[i].ToString());
            }
            arr = count.ToString().ToCharArray();
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                if (arr[left] != arr[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
