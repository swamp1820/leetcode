namespace src;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var result = new int[] { };
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                };
            };
        };

        return result;
    }
}