using Common;
namespace src;

public class Solution
{


    // Через FloodFill - работает,но получал TLE на тестах для BFS
    // Для DFS - тесты проходятся
    public int NumIslandsBFSFloodFill(char[][] grid)
    {
        int count = 0;
        var s = new Stack<int[]>();
        // обходим массивы
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                // если "земля"
                if (grid[i][j] == '1')
                {
                    // остров начался
                    count++;
                    s.Push(new int[] { i, j });
                    while (s.Count != 0)
                    {
                        var point = s.Pop();
                        grid[point[0]][point[1]] = '0';

                        // смотрим соседние земли
                        // сверху
                        if (point[0] > 0 && grid[point[0] - 1][point[1]] == '1')
                        {
                            // добавим в очередь
                            s.Push(new int[] { point[0] - 1, point[1] });
                        }

                        // справа
                        if (point[1] < grid[point[0]].Length - 1 && grid[point[0]][point[1] + 1] == '1')
                        {
                            // добавим в очередь
                            s.Push(new int[] { point[0], point[1] + 1 });
                        }
                        //снизу 
                        if (point[0] < grid.Count() - 1 && grid[point[0] + 1][point[1]] == '1')
                        {
                            // добавим в очередь
                            s.Push(new int[] { point[0] + 1, point[1] });
                        }

                        //слева
                        if (point[1] > 0 && grid[point[0]][point[1] - 1] == '1')
                        {
                            // добавим в очередь
                            s.Push(new int[] { point[0], point[1] - 1 });
                        }
                    }
                }
            }
        }

        return count;
    }

    // через BFS и visited hashTable
    public int NumIslands(char[][] grid)
    {
        int count = 0;
        var s = new Queue<int[]>();
        var visited = new HashSet<int>();
        // обходим массивы
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                // если "земля"
                if (grid[i][j] == '1')
                {
                    // если эту клетку уже просматривали - пропускаем
                    if (visited.Contains(i * 1000 + j))
                    {
                        continue;
                    }
                    // если новая смотрим все соседние земли
                    else
                    {
                        s.Enqueue(new int[] { i, j });
                        while (s.Count != 0)
                        {
                            var point = s.Dequeue();
                            // если посетили - пропускаем
                            // добавим посещенную
                            if (!visited.Add(point[0] * 1000 + point[1]))
                            {
                                continue;
                            }

                            // смотрим соседние земли
                            // сверху
                            if (point[0] > 0 && grid[point[0] - 1][point[1]] == '1')
                            {
                                // добавим в очередь
                                s.Enqueue(new int[] { point[0] - 1, point[1] });
                            }

                            // справа
                            if (point[1] < grid[point[0]].Length - 1 && grid[point[0]][point[1] + 1] == '1')
                            {
                                // добавим в очередь
                                s.Enqueue(new int[] { point[0], point[1] + 1 });
                            }
                            //снизу 
                            if (point[0] < grid.Count() - 1 && grid[point[0] + 1][point[1]] == '1')
                            {
                                // добавим в очередь
                                s.Enqueue(new int[] { point[0] + 1, point[1] });
                            }

                            //слева
                            if (point[1] > 0 && grid[point[0]][point[1] - 1] == '1')
                            {
                                // добавим в очередь
                                s.Enqueue(new int[] { point[0], point[1] - 1 });
                            }
                        }
                        // когда очередь = 0 и были новые клетки - записываем +1 остров
                        count++;
                    }
                }
            }
        }

        return count;
    }
}