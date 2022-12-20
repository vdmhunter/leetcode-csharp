namespace LeetCodeCSharpApp.KeysAndRooms02;

/// <summary>
/// DFS
/// </summary>
public class Solution
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        var visited = new HashSet<int> { 0 };
        Dfs(rooms, visited, 0);

        return visited.Count == rooms.Count;
    }

    private static void Dfs(IList<IList<int>> rooms, HashSet<int> visited, int room)
    {
        foreach (var k in rooms[room])
            if (!visited.Contains(k))
            {
                visited.Add(k);
                Dfs(rooms, visited, k);
            }
    }
}
