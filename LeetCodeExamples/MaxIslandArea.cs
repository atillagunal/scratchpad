
public class MaxIslandAreaSolution {
    public int MaxAreaOfIsland(int[][] grid)
    {
        if (grid == null || grid[0] == null)
        {
            return 0;
        }

        int maxArea = 0;
        HashSet<int> visited = new HashSet<int>();
        int gridColCount = grid[0].Length;
        int gridRowCount = grid.Length;

        for (int i = 0; i < gridRowCount; ++i)
        {
            for (int j = 0; j < gridColCount; ++j)
            {
                if (grid[i][j] == 1 && visited.Contains(i * gridColCount + j) == false)
                {
                    int area = CalculateArea(grid, i, j, visited, gridColCount, gridRowCount);

                    if (area > maxArea)
                    {
                        maxArea = area;
                    }
                }
            }
        }

        return maxArea;
    }

    private int CalculateArea(int[][] grid, int i, int j, HashSet<int> visited, int gridColCount, int gridRowCount)
    {
        int area = 0;
        Queue<(int, int)> queue = new Queue<(int, int)>();

        queue.Enqueue((i, j));

        while (queue.Count > 0)
        {
            var t = queue.Dequeue();

            int arrayIndex = t.Item1 * gridColCount + t.Item2;
            if (visited.Contains(arrayIndex) == false)
            {
                visited.Add(arrayIndex);

                if (grid[t.Item1][t.Item2] == 1)
                {
                    ++area;
                    if (t.Item1 - 1 >= 0)
                    {
                        queue.Enqueue((t.Item1 - 1, t.Item2));
                    }

                    if (t.Item1 + 1 < gridRowCount)
                    {
                        queue.Enqueue((t.Item1 + 1, t.Item2));
                    }

                    if (t.Item2 - 1 >= 0)
                    {
                        queue.Enqueue((t.Item1, t.Item2 - 1));
                    }

                    if (t.Item2 + 1 < gridColCount)
                    {
                        queue.Enqueue((t.Item1, t.Item2 + 1));
                    }
                }
            }
        }

        return area;
    }
}