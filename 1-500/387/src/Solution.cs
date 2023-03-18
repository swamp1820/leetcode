namespace src;

public class Solution
{
    public int FirstUniqChar(string s) {
        var hash = new HashSet<char>();
        var result = -1;
        for (int i =0; i<s.Length; i++)
        {
            // добавим символ, если его не было
            if (hash.Add(s[i]))
            {
                bool isUnique = true;
                // найдем его повтор
                for (int j=i+1; j<s.Length;j++)
                {
                    if (s[j] == s[i])
                    {    
                        isUnique = false;                   
                        break;
                    }
                }
                // если повторов нет - вернем i
                if (isUnique)
                {
                    return i;
                }
            }
        }

        return result;
    }
}