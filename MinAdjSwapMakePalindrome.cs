Console.WriteLine(getNoOfSwaps("mamad"));
Console.WriteLine(getNoOfSwaps("asflkj"));
Console.WriteLine(getNoOfSwaps("aabb"));
Console.WriteLine(getNoOfSwaps("ntiin"));
bool isValidStringPalindrome(string s)
{
    if (s == null) return false;
    HashSet<char> ts = new HashSet<char>();

    foreach (var item in s.ToCharArray())
    {
        if (ts.Contains(item))
        {
            ts.Remove(item);
        }
        else
        {
            ts.Add(item);
        }
    }
    return ts.Count < 2;
}
void swap(char[] chars, int k, int i)
{
    char temp = chars[k];
    chars[k] = chars[i];
    chars[i] = temp;
}
int getNoOfSwaps(string s)
{
    if (s.Length == 0) return -1;
    int noOfSwaps = 0;
    if (isValidStringPalindrome(s))
    {
        char[] chars = s.ToCharArray();
        int left = 0;
        int right = chars.Length - 1;
        // LOOP TILL CROSS
        while (right > left)
        {
            // # CASE 1 - RIGHT = LEFT
            if (chars[left] == chars[right])
            {
                left++;
                right--;
            }
            // # CASE 2 - RIGHT != LEFT
            else
            {
                // # FIND THE RIGHTMOST CHAR TO MATCH THE LEFT
                int mid = right;
                while (mid > left && chars[left] != chars[mid])
                {
                    mid -= 1;
                }
                // # CASE 1 - CHAR NOT FOUND - SWAP ONCE WITH RIGHT NEIGHBOR, AND CONTINUE WITHOUT CLOSING WINDOW
                // # THIS LONER CHAR WILL EVENTUALLY END UP IN THE MIDDLE OF THE STRING
                if (mid == left)
                {
                    swap(chars, mid, mid + 1);
                    noOfSwaps++;
                }
                else
                {
                    // # CASE 2 - CHAR FOUND - SWAP WITH RIGHT NEIGHBOR UNTIL IT ENDS UP AT THE RIGHT
                    for (int i = mid; i < right; i++)
                    {
                        swap(chars, i, i + 1);
                        noOfSwaps++;
                    }
                    left++;
                    right--;
                }
            }
        }
    }
    else return -1;
    return noOfSwaps;
}