string s = "abcda";
int i = 0;
for (; i < s.Length - 1; i++)
{
    if (s[i] > s[i + 1])
    {
        break;
    }
}
Console.WriteLine(s.Substring(0, i) + s.Substring(i + 1, s.Length - i - 1));
