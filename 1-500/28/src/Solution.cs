namespace src;

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int point = -1;
        if (haystack.Length < needle.Length)
        {
            return point;
        }

        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack.Length - i < needle.Length)
            {
                return point;
            }
            if (haystack[i] == needle[0])
            {
                point = i;
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        point = -1;
                        break;
                    }
                    if (j==needle.Length-1 && haystack[i + j] == needle[j])
                    {
                        return point;
                    }
                }
            }
        }

        return point;
    }
}