namespace src;

public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        var midR = matrix.Length - 1 / 2;
        var lowR = 0;
        var highR = matrix.Length - 1;
        // найдем нужный массив бинарным поиском
        while (lowR <= highR)
        {
            midR = lowR + (highR - lowR) / 2;
            if (target >= matrix[midR][0] && target <= matrix[midR][matrix[midR].Length - 1])
            {
                // найдем число бинарным поиском
                var mid = matrix[midR].Length - 1 / 2;
                var low = 0;
                var high = matrix[midR].Length - 1;
                while (low <= high)
                {
                    mid = low + (high - low) / 2;
                    if (matrix[midR][mid] > target)
                    {
                        high = mid - 1;
                    }
                    else if (matrix[midR][mid] < target)
                    {
                        low = mid + 1;
                    }
                    else if (matrix[midR][mid] == target)
                    {
                        return true;
                    }
                }

                return false;
            }
            else if (target < matrix[midR][0])
            {
                highR = midR - 1;
            }
            else if (target > matrix[midR][0])
            {
                lowR = midR + 1;
            }
        }
        return false;
    }
}