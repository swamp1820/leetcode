namespace src;

public class Solution
{
     public int SearchInsert(int[] nums, int target)
    {       
        var low = 0;
        var high = nums.Length-1;
        var mid = high / 2;
        
        if (nums.Length==1 && nums[0]==target)
        {
            return 0;
        }

        while(low<high)
        {
            if (target == nums[mid])
            {
                return mid;
            }
            else if (target == nums[low])
            {
                return low;
            }
            else if (target == nums[high])
            {
                return high;
            }
            else if (target > nums[mid])
            {
                low = mid+1;
                mid = low+(high-low)/2;
            }
            else if (target < nums[mid])
            {
                high = mid-1;
                mid = low+(high-low)/2;
            }
        }

        return target<nums[low]? low:low+1;
    }
}