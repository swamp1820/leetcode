namespace src;

public class Solution
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        if (mat.Length * mat[0].Length != r * c)
        {
            return mat;
        }

        var result = new List<int[]>();
        var row = new List<int>();
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                row.Add(mat[i][j]);
                if (row.Count==c)
                {   
                    result.Add(row.ToArray());
                    row.Clear();
                }
            }
        }
        return result.ToArray();
    }
}