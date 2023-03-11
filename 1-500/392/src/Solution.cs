namespace src;

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        var p = 0; // храним индекс последнего совпадения+1
        for (int i = 0; i <= s.Length - 1; i++)
        {
            for (int j = p; j <= t.Length - 1; j++)
            {
                if (s[i] == t[j])
                {
                    // если это совпала последний символ, то возвращаем true
                    if (i == s.Length - 1)
                    {
                        return true;
                    }
                    // выходим из цикла, начнем поиск с последнего места+1
                    p = ++j;
                    break;
                }
                else if(j == t.Length-1)
                {
                    return false;
                }
            }

            if(i == s.Length - 1) // если это последний символ s, но мы так и не нашли его в t
            {
                return false;
            }
        }
        return true; // сработает при пустом s
    }
}