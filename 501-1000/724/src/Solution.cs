namespace src;

public class Solution
{
    // перебором
    public int PivotIndex(int[] nums)
    {
        var result = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            int sumLeft = 0;
            int sumRight = 0;
            // сумма слева
            for (int n = 0; n < i; n++)
            {
                sumLeft = sumLeft + nums[n];
            }
            // сумма справа
            for (int m = i + 1; m < nums.Length; m++)
            {
                sumRight = sumRight + nums[m];
            }

            if (sumLeft == sumRight)
            {
                result = i;
                break;
            }
        }
        return result;
    }

    // через сумму
    public int PivotIndexSum(int[] nums)
    {
        var result = -1;
        var sum = nums.Sum();
        int sumLeft = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            // если сумма элементов слева равна сумме справа (сумма всех - сумма слева - nums[i])
            if (sumLeft == sum - sumLeft - nums[i])
            {
                return i;
            }
            sumLeft = sumLeft + nums[i];
        }
        return result;
    }
}