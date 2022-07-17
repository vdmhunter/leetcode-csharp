namespace LeetCodeCSharpApp.MaxAreaOfIsland02;

/// <summary>
/// Depth-First Search (Iterative)
/// </summary>
public class Solution
{
    public int MaxAreaOfIsland(int[][] grid)
    {
        var seen = new bool[grid.Length][];
        for (var i = 0; i < grid.Length; i++)
            seen[i] = new bool[grid[0].Length];
        
        var dr = new[] { 1, -1, 0, 0 };
        var dc = new[] { 0, 0, 1, -1 };

        var ans = 0;
        
        for (var r0 = 0; r0 < grid.Length; r0++)
            for (var c0 = 0; c0 < grid[0].Length; c0++)
                if (grid[r0][c0] == 1 && !seen[r0][c0])
                {
                    var shape = 0;
                    var stack = new Stack<int[]>();
                    stack.Push(new[] { r0, c0 });
                    seen[r0][c0] = true;
                    
                    while (stack.Count != 0)
                    {
                        var node = stack.Pop();
                        int r = node[0], c = node[1];
                        shape++;
                        
                        for (var k = 0; k < 4; k++)
                        {
                            var nr = r + dr[k];
                            var nc = c + dc[k];
                            
                            if (0 <= nr && nr < grid.Length &&
                                0 <= nc && nc < grid[0].Length &&
                                grid[nr][nc] == 1 && !seen[nr][nc])
                            {
                                stack.Push(new[] { nr, nc });
                                seen[nr][nc] = true;
                            }
                        }
                    }

                    ans = Math.Max(ans, shape);
                }

        return ans;
    }
}
