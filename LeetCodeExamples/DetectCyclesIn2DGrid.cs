
public class WorkNode
{
    public int colIndex;
    public int rowIndex;

    public int prevColIndex;
    public int prevRowIndex;

    public WorkNode(int rowIndex, int colIndex, int prevColIndex, int prevRowIndex)
    {
        this.colIndex = colIndex;
        this.rowIndex = rowIndex;
        this.prevColIndex = prevColIndex;
        this.prevRowIndex = prevRowIndex;
    }
}

public class DetectCyclesIn2DGridSolution
{
    private static readonly (int, int)[] dimensions = [(-1, 0), (+1, 0), (0, -1), (0, +1)];
    public bool ContainsCycle(char[][] grid)
    {
        if (grid == null || grid[0] == null)
        {
            return false;
        }

        int gridColCount = grid[0].Length;
        int gridRowCount = grid.Length;
        bool[] visited = new bool[gridColCount * gridRowCount];

        for (int i = 0; i < gridRowCount; ++i)
        {
            for (int j = 0; j < gridColCount; ++j)
            {
                if (visited[i * gridColCount + j])
                {
                    continue;
                }

                if (ContainsCycle(grid, i, j, grid[i][j], visited, gridColCount, gridRowCount))
                {
                    return true;
                }
            }
        }

        return false;
    }

    private bool ContainsCycle(char[][] grid, int i, int j, int val, bool[] visited, int gridColCount, int gridRowCount)
    {
        Queue<WorkNode> queue = new Queue<WorkNode>();

        queue.Enqueue(new WorkNode(i, j, -1, -1));

        while (queue.Count > 0)
        {
            WorkNode wn = queue.Dequeue();

            foreach (var dimension in dimensions)
            {
                int newrowIndex = wn.rowIndex + dimension.Item1;
                int newColIndex = wn.colIndex + dimension.Item2;

                if (newrowIndex >= 0 && newrowIndex < gridRowCount &&
                   newColIndex >= 0 && newColIndex < gridColCount &&
                   grid[newrowIndex][newColIndex] == val &&
                   (newrowIndex == wn.prevRowIndex && newColIndex == wn.prevColIndex) == false)
                {
                    if (visited[newrowIndex * gridColCount + newColIndex])
                    {
                        return true;
                    }

                    queue.Enqueue(new WorkNode(newrowIndex, newColIndex, wn.colIndex, wn.rowIndex));
                }
            }

            visited[wn.rowIndex * gridColCount + wn.colIndex] = true;
        }

        return false;
    }
}