namespace src;

public class Solution
{
    // TODO: вернуться к решению DnQ, кроме Sliding Window
    // https://leetcode.com/problems/maximum-subarray/solutions/405559/easy-understand-java-solutions-with-explanations-b-f-divide-and-conquer-dp/
    public int MaxSubArray(int[] nums)
    {
        int sum = 0;
        if (nums.Length == 1)
        {
            return nums[0];
        }
        var current = 0;
        var max = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            current = Math.Max(0, current + nums[i]);
            if (nums[i] > max)
            {
                max = nums[i];
            }
            sum = Math.Max(sum, current);
        }

        return max > 0 ? sum : max;
    }

    // Kadane's algo
    // def max_subarray(numbers):
    // """Find the largest sum of any contiguous subarray."""
    // best_sum = 0
    // current_sum = 0
    // for x in numbers:
    //     current_sum = max(0, current_sum + x)
    //     best_sum = max(best_sum, current_sum)
    // return best_sum
}