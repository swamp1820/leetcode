namespace src;

public class Solution
{
    // это работает быстрее
    public int LongestPalindrome(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int result = 0;
        bool hasSingle = false;
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            var value = dict.GetValueOrDefault(c);
            if (value == 0)
            {
                dict.Add(c, 1);
            }
            else
            {
                dict[c] = ++value;
            }
        }

        foreach (KeyValuePair<char, int> kvp in dict)
        {
            if (kvp.Value % 2 == 0)
            {
                result += kvp.Value;
            }
            else if (kvp.Value % 2 == 1)
            {
                if (kvp.Value > 2)
                {
                    result += kvp.Value - 1;
                }
                hasSingle = true;
            }
        }

        return result + (hasSingle ? 1 : 0);
    }
    
    // это работает, но медленно
    public int LongestPalindromeDumb(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (char c in s)
        {
            var value = dict.GetValueOrDefault(c);
            if (value == 0)
            {
                dict.Add(c, 1);
            }
            else
            {
                dict[c] = ++value;
            }
        }
        return dict.Where(x => x.Value % 2 == 0).Select(x => x.Value).Sum() +
        dict.Where(x => x.Value > 2 && x.Value % 2 == 1).Select(x => x.Value - 1).Sum() +
        (dict.Where(x => x.Value % 2 == 1).Any() ? 1 : 0);
    }


}