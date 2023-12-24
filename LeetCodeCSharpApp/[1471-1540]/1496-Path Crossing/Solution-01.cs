namespace LeetCodeCSharpApp.PathCrossing01;

public class Solution
{
    public bool IsPathCrossing(string path)
    {
        const int baseVal = 10001;
        int i = 0, j = 0;
        var set = new HashSet<int> { 0 };

        var map = new Dictionary<char, int[]>
        {
            { 'N', new[] { -1, 0 } },
            { 'S', new[] { 1, 0 } },
            { 'E', new[] { 0, -1 } },
            { 'W', new[] { 0, 1 } }
        };

        foreach (var p in path)
        {
            i += map[p][0];
            j += map[p][1];

            if (!set.Add(i * baseVal + j))
                return true;
        }

        return false;
    }
}
