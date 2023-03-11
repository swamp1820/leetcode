namespace src;

public class Solution
{
    public int FindKthPositive(int[] arr, int k)
    {
        // отдельный случай когда k не входит в массив
        if (k > arr[arr.Length - 1] - arr.Length)
        {
            return arr[arr.Length - 1] + (k - (arr[arr.Length - 1] - arr.Length));
        }
        else
        {
            // начинаем искать бинарным поиском
            var low = 0;
            var high = arr.Length - 1;

            while (low <= high)
            {
                var mid = low + (high - low) / 2;
                if (k < arr[mid] - mid)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return arr[low] + (k - (arr[low] - low));
        }
    }

    public int FindKthPositiveON(int[] arr, int k)
    {
        // кол-во пропущенных символов
        int number = 0;
        // индекс массива
        int i = 0;
        // искомое число
        int j = 0;

        // пока пропущенное число не Kth
        while (number < k)
        {
            j++;
            // если число совпало
            if (arr[i] == j)
            {
                // если массив закончился - вернем сумму последнего числа массива и оставшихся чисел
                if (i == arr.Length - 1)
                {
                    return arr[i] + k - number;
                }
                // ищем следующее
                i++;
            }
            // если число отсутствует
            else
            {
                number++;
            }
        }

        return j;
    }
}
