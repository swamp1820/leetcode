namespace src;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var table = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!table.Add(nums[i]))
            {
                return true;
            }
        }

        return false;
    }
}