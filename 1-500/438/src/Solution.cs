namespace src;

public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        List<int> result = new List<int>();
        if (s.Length < p.Length)
        {
            return result;
        }
        // вообще можно (и наверное рекомендуется) оптимизировать через HashSet
        // но вроде и так приняли 
        for (int i = 0; i <= s.Length - p.Length; i++)
        {
            if (p.ToCharArray().Sum(x => (int)x * ((int)x / 2)) ==
            s.Substring(i, p.Length).ToCharArray().Sum(x => (int)x * ((int)x / 2)))
            {
                result.Add(i);
            }
        }

        return result;
    }

}