namespace src;

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var memo = new HashSet<int>();
        if (ransomNote.Length > magazine.Length)
        {
            return false;
        }

        for (int i = 0; i < ransomNote.Length; i++)
        {
            // ищем букву в журнале
            var isFound = false;
            for (int j = 0; j < magazine.Length; j++)
            {
                // если эта буква использовалась - пропускаем
                if (memo.TryGetValue(j, out int val))
                {
                    continue;
                }
                // если нашли - добавим
                if (magazine[j] == ransomNote[i])
                {
                    memo.Add(j);
                    isFound = true;
                    break;
                }
            }

            // если не нашли
            if (!isFound)
            {
                return false;
            }

        }
        return true;
    }
}