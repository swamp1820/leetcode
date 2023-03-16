namespace src;

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        var result = new List<List<int>>();
        for (int i = 0; i < numRows; i++)
        {

            var row = new List<int>();
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    row.Add(1);
                }
                else if (i>=2 && (j>=1 && j<i))
                {
                    row.Add(result[i-1][j-1]+result[i-1][j]);
                }

            }
            result.Add(row);
        }
        return result.ToArray();
    }
}