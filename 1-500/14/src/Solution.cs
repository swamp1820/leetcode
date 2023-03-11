namespace src;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var result = string.Empty;
        var shortestWord = strs.First(x=>x.Length == strs.Min(x=>x.Length));
        
        for (int i = 1; i <= shortestWord.Length; i++)
        {
            var substring = shortestWord.Substring(0,i);
            if (strs.All(x=>x.Substring(0,i)==substring))
            {
                result = substring;
            }
        }

        return result;
    }
}