namespace src;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int result = 0;
        int buyIndex = 0;
        int sellIndex = 1;
        while (sellIndex <= prices.Count() - 1)
        {
            if (prices[buyIndex] < prices[sellIndex])
            {
                var profit = prices[sellIndex] - prices[buyIndex];
                if (profit > result)
                {
                    result = profit;
                }
            }
            else
            {
                buyIndex = sellIndex;
            }
            sellIndex++;
        }



        return result;
    }
}