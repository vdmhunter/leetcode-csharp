namespace LeetCodeCSharpApp.MostPopularVideoCreator01;

public class Solution
{
    public IList<IList<string>> MostPopularCreator(string[] creators, string[] ids, int[] views)
    {
        var tot = new Dictionary<string, long>();
        var vid = new Dictionary<string, List<(long, string)>>();

        var max = 0L;

        for (var i = 0; i < creators.Length; ++i)
        {
            if (tot.ContainsKey(creators[i]))
                tot[creators[i]] += views[i];
            else
                tot.Add(creators[i], views[i]);

            max = Math.Max(max, tot[creators[i]]);

            if (vid.ContainsKey(creators[i]))
                vid[creators[i]].Add((-views[i], ids[i]));
            else
                vid[creators[i]] = new List<(long, string)> { (-views[i], ids[i]) };
        }

        var result = new List<IList<string>>();

        foreach (var (c, vv) in vid)
        {
            if (tot[c] != max)
                continue;

            result.Add(new List<string> { c, vv.OrderBy(i => i.Item1).ThenBy(i => i.Item2).First().Item2 });
        }

        return result;
    }
}
