namespace LeetCodeCSharpApp.SortItemsByGroupsRespectingDependencies01;

public class Solution
{
    public int[] SortItems(int n, int m, int[] group, IList<IList<int>> beforeItems)
    {
        var result = new List<int>();
        var stat = new int[n + 2 * m];
        var al = new List<HashSet<int>>(n + 2 * m);

        for (var i = 0; i < n + 2 * m; i++)
            al.Add(new HashSet<int>());

        for (var i = 0; i < n; ++i)
        {
            AddGroupToAdjacencyList(n, m, group, al, i);
            AddBeforeItemsToAdjacencyList(n, m, group, beforeItems, al, i);
        }

        for (var i = al.Count - 1; i >= 0; i--)
            if (!TopSort(al, i, result, stat))
                return Array.Empty<int>();

        result.Reverse();

        return result.Where(i => i < n).ToArray();
    }

    private static void AddGroupToAdjacencyList(int n, int m, int[] group, List<HashSet<int>> al, int i)
    {
        if (group[i] == -1)
            return;

        al[n + group[i]].Add(i);
        al[i].Add(n + m + group[i]);
    }

    private static void AddBeforeItemsToAdjacencyList(int n, int m, int[] group, IList<IList<int>> beforeItems,
        List<HashSet<int>> al, int i)
    {
        foreach (var j in beforeItems[i])
        {
            if (group[i] != -1 && group[i] == group[j])
            {
                al[j].Add(i);
            }
            else
            {
                var ig = group[i] == -1 ? i : n + group[i];
                var jg = group[j] == -1 ? j : n + m + group[j];
                al[jg].Add(ig);
            }
        }
    }

    private static bool TopSort(List<HashSet<int>> al, int i, List<int> res, int[] stat)
    {
        if (stat[i] != 0)
            return stat[i] == 2;

        stat[i] = 1;

        if (al[i].Any(n => !TopSort(al, n, res, stat)))
            return false;

        stat[i] = 2;
        res.Add(i);

        return true;
    }
}
