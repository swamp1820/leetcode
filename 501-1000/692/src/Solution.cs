namespace src;

public class Solution
{
    public IList<string> TopKFrequent(string[] words, int k)
    {
        var counts = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            // проверим есть ли слово в словаре
            if (!counts.TryGetValue(words[i], out int val))
            {
                counts.Add(words[i], 1);
            }
            else
            {
                counts[words[i]]++;
            }
        }
        // вместо этого "читерства" можно было оставить k слов и сравнить самому, но мне лень
        return counts.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(k).Select(x=>x.Key).ToArray();
    }
}