using Common;
namespace src;

public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        var s = new Queue<int[]>(); //внешний стек
        s.Enqueue(new int[] { sr, sc });
        while (s.Count != 0)
        {
            var point = s.Dequeue();
            sr = point[0];
            sc = point[1];
            if(image[sr][sc]==color)
            {
                continue;
            }

            // сверху
            if (sr > 0 && image[sr - 1][sc] == image[sr][sc])
            {
                // добавим в очередь
                s.Enqueue(new int[] { sr - 1, sc });
            }

            //справа
            if (sc < image[sr].Length-1 && image[sr][sc + 1] == image[sr][sc])
            {
                // добавим в очередь
                s.Enqueue(new int[] { sr, sc + 1 });
            }
            //снизу 
            if (sr < image.Count() - 1 && image[sr + 1][sc] == image[sr][sc])
            {
                // добавим в очередь
                s.Enqueue(new int[] { sr + 1, sc });
            }

            //слева
            if (sc > 0 && image[sr][sc - 1] == image[sr][sc])
            {
                // добавим в очередь
                s.Enqueue(new int[] { sr, sc - 1 });
            }

            //изменим саму клетку
            image[sr][sc] = color;
        }

        return image;
    }
}