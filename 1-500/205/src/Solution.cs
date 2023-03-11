namespace src;

public class Solution
{
    // перебором
    public bool IsIsomorphic(string s, string t)
    {
        for (int i = 0; i < s.Length - 1; i++)
        {
            for (int j = i + 1; j < s.Length; j++)
            {
                if (s[i] == s[j] && t[i] != t[j])
                {
                    return false;
                }
            }

            for (int j = i + 1; j < s.Length; j++)
            {
                if (t[i] == t[j] && s[i] != s[j])
                {
                    return false;
                }
            }
        }

        return true;
    }


    // через словарь, подсмотренно
    // работает быстрее (один проход по строкам)
    public bool IsIsomorphicMapping(string s, string t)
    {
        int[] ST = new int[256];
        Array.Fill(ST, -1);

        int[] TS = new int[256];
        Array.Fill(TS, -1);


        for (int i = 0; i < s.Length; ++i)
        {
            char c1 = s[i];
            char c2 = t[i];

            if (ST[c1]==-1 && TS[c2]==-1)
            {
                ST[c1] = c2;
                TS[c2] = c1;
            }
            else if (!(ST[c1] == c2 && TS[c2] == c1)) {
                return false;
            }
        }

        return true;
    }
}