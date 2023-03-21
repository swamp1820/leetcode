namespace src;

public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var result = new List<int>();
        var visited = new HashSet<int>(); // тут индексы короткого индекса, которые уже нашли
        int[] shortestArray; // короткий массив
        int[] longestArray; // длинный массив

        if (nums1.Length <= nums2.Length)
        {
            shortestArray = nums1;
            longestArray = nums2;
        }
        else
        {
            shortestArray = nums2;
            longestArray = nums1;
        }

        // начинаем идти по длинному массиву
        for (int i = 0; i < longestArray.Length; i++)
        {
            // ищем число в коротком массиве
            for (int j = 0; j < shortestArray.Length; j++)
            {
                // если совпало
                if (longestArray[i] == shortestArray[j])
                {
                    // если просматривали - пропускаем
                    if (!visited.Add(j))
                    {
                        continue;
                    }
                    result.Add(shortestArray[j]);
                    // ищем следующее
                    break;
                } 
            }
        }
        return result.ToArray();
    }
}