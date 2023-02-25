namespace src;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int[] result;
        bool hasIncrement = true;
        // добавим 1 начиная с конца массива
        for (int i = digits.Count() - 1; i >= 0; i--)
        {
            if (hasIncrement)
            {
                var plus = digits[i] + 1;

                if (plus == 10)
                {
                    hasIncrement = true;
                    plus = 0;
                }
                else
                {
                    hasIncrement = false;
                }

                digits[i] = plus;
            }
        }

        if (digits[0] == 0 && hasIncrement)
        {
            result = new int[digits.Length+1];
            result[0]=1;
            digits.CopyTo(result, 1);
        }
        else
        {
            result = digits;
        }

        return result;
    }
}