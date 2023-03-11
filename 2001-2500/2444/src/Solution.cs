namespace src;

public class Solution
{
    public long CountSubarrays(int[] nums, int minK, int maxK)
    {
        long result = 0;
        if (minK == maxK) //если они одинаковые, то просто считаем сумму арифметической прогрессии подмассивов
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == minK)
                {
                    count++;
                }

                if (nums[i] != minK || i == nums.Length - 1)
                {
                    if (count > 0)
                    {
                        for (int j = 1; j <= count; j++)
                        {
                            result += j;
                        }
                        count = 0;
                    }
                }
            }
        }
        else
        {
            int leftIndex = -1;
            int rightIndex = -1;
            int l = 0; // левый счетчик
            int r = 0; // правый счетчик
            int firstMatchIndex = -1;
            int prevFirstMatchIndex = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                // если не подходит массив - ищем дальше
                // забудем индексы мин/макс значений
                if (nums[i] < minK || nums[i] > maxK)
                {
                    leftIndex = -1;
                    rightIndex = -1;
                    continue;
                }

                // если нашли совпадение - запомним индекс
                if (nums[i] == minK || nums[i] == maxK)
                {
                    // если это первая находка - индекс начала подмассива
                    // если начало есть - двигаем если повтор
                    if (leftIndex == -1 || nums[i] == nums[leftIndex])
                    {
                        leftIndex = i;
                        firstMatchIndex = i;
                    }
                    // если начало есть, но это не повтор - значит это конец подмассива
                    else if (nums[i] != nums[leftIndex])
                    {
                        rightIndex = i;
                    }
                }



                // если мы нашли индексы минимального и максимального
                if (leftIndex >= 0 && rightIndex >= 0)
                {
                    // наш подмассив - уже подходит
                    result++;
                    // двигаемся вправо пока не найдем неподходящее число или начало массива
                    while (rightIndex < nums.Length - 1 && (nums[rightIndex + 1] <= maxK && nums[rightIndex + 1] >= minK))
                    {
                        r++;
                        rightIndex++;
                    }

                    // затем двигаемся влево, пока не найдем неподходящее число или начало массива/предыдущий минимальный индекс
                    while (leftIndex > 0 && nums[leftIndex - 1] <= maxK && nums[leftIndex - 1] >= minK && leftIndex > prevFirstMatchIndex)
                    {
                        l++;
                        leftIndex--;
                    }

                    // подсчет
                    result += l + r + (l * r);

                    r = 0;
                    l = 0;
                    // сбросим индексы, чтобы искать следующий подмассив
                    leftIndex = -1;
                    rightIndex = -1;

                    // возобновим поиски с первой найденной цифры
                    i = firstMatchIndex;
                    prevFirstMatchIndex = firstMatchIndex + 1;
                }
            }
        }
        return result;
    }

}
