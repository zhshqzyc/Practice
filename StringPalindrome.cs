// See https://aka.ms/new-console-template for more information
string s = "aabbaa";
Console.WriteLine(ifStringPalindrome(s));
bool ifStringPalindrome(string s)
{
    if (s == null) return false;
    for (int i = 0; i < s.Length / 2; i++)
    {
        if (s[i] != s[s.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}