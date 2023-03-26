namespace src;

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        var hashSet = new HashSet<int>();
        for (int i = 0; i < 9; i++)
        {
            // проверим горизонталь
            for (int j = 0; j < 9; j++)
            {
                if (board[i][j]!='.' && !hashSet.Add(board[i][j]))
                {
                    return false;
                }
            }
            hashSet.Clear();

            // проверим вертикаль
            for (int j = 0; j < 9; j++)
            {
                if (board[j][i]!='.' && !hashSet.Add(board[j][i]))
                {
                    return false;
                }
            }
            hashSet.Clear();

            // проверим квадрат
            var row = (int)Math.Floor((decimal)i/3)*3;
            var column =(i%3)*3; 
            for (int n = column; n < column+3; n++)
            {
                for (int m = row; m < row+3; m++)
                {
                    if (board[n][m]!='.' && !hashSet.Add(board[n][m]))
                    {
                        return false;
                    }
                }
            }
            hashSet.Clear();
        }


        return true;
    }
}