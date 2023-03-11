namespace src;

public class Solution
{
    public int MySqrt(int x)
    {
        // сначала пытался решить перебором, но бинарный поиск быстрее
        var result = 0;
        long mid = x/2;
        long low = 1;
        long high = x;
        long square = mid*mid;
        while (low <= high)
        {
            mid = low + (high-low)/2;
            square = mid*mid;
            if (square> x)
            {
                high=mid-1;
            }
            else if (square < x)
            {
                result = (int)mid; 
                low = mid + 1;
            }
            else if (square==x)
            {
                return (int)mid;
            }
        }

        return result;
    }

}