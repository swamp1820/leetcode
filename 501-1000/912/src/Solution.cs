namespace src;

public class Solution
{
    public int[] SortArray(int[] nums)
    {

        var mid = nums.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[nums.Length - mid];
        int[] result = new int[nums.Length];

        if (nums.Length <= 1)
        {
            return nums;
        }

        left = SortArray(nums[..mid]);
        right = SortArray(nums[mid..]);
        var i = 0;
        var n = 0;
        var m = 0;

        for (n = 0, m = 0; n < left.Length && m < right.Length;)
        {
            if (left[n] < right[m])
            {
                result[i] = left[n];
                n++;
            }
            else if (left[n] == right[m])
            {
                result[i] = left[n];
                n++;
                i++;
                result[i] = right[m];
                m++;
            }
            else
            {
                result[i] = right[m];
                m++;
            }

            i++;
        }

        for (int j = n; j < left.Length; j++)
        {
            result[i] = left[j];
            i++;
        }
        for (int j = m; j < right.Length; j++)
        {
            result[i] = right[j];
            i++;
        }

        return result;
    }
}

// Это решение на псевдокоде тоже работает, но не подходит по скорости

// function mergesort(m)
//     var list left, right, result
//     if length(m) ≤ 1
//         return m
//     else
//         middle = length(m) / 2
//         for each x in m up to middle
//             add x to left
//         for each x in m after middle
//             add x to right
//         left = mergesort(left)
//         right = mergesort(right)
//         result = merge(left, right)
//         return result
//     end if

// function merge(left,right)
//     var list result
//     while length(left) > 0 and length(right) > 0
//         if first(left) ≤ first(right)
//             append first(left) to result
//             left = rest(left)
//         else
//             append first(right) to result
//             right = rest(right)
//         end if
//     while length(left) > 0 
//         append first(left) to result
//         left = rest(left)
//     while length(right) > 0 
//         append first(right) to result
//         right = rest(right)
//     return result