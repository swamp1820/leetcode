namespace src;

public class Solution
{
    public bool IsAnagram(string s, string t) {
        if (s.Length!=t.Length)
        {
            return false;
        }
        // ИЗИ, хэши должны совпадать
        // можно и без LINQ, но все равно будет тривиально
        return s.ToCharArray().Sum(x=>(int)x*((int)x/2)) == t.ToCharArray().Sum(x=>((int)x*((int)x/2)));
    }
}