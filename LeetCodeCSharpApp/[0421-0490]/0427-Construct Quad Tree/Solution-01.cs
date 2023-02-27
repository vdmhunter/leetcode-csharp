using LeetCodeCSharpApp.Common.QuadTree;

namespace LeetCodeCSharpApp.ConstructQuadTree01;

public class Solution
{
    public Node Construct(int[][] grid) => GetNode(grid, grid.Length, 0, 0);

    private Node GetNode(int[][] grid, int size, int i, int k)
    {
        if (size == 1 || AreSame(grid, size, i, k))
            return new Node(grid[i][k] == 1, true);

        return new Node(true, false,
            GetNode(grid, size / 2, i, k),
            GetNode(grid, size / 2, i, k + size / 2),
            GetNode(grid, size / 2, i + size / 2, k),
            GetNode(grid, size / 2, i + size / 2, k + size / 2));
    }

    private static bool AreSame(int[][] grid, int size, int i, int k)
    {
        for (var ii = i; ii < i + size; ii++)
            for (var kk = k; kk < k + size; kk++)
                if (grid[ii][kk] != grid[i][k])
                    return false;

        return true;
    }
}
