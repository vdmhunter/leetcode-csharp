// ReSharper disable InconsistentNaming

namespace LeetCodeCSharpApp.HighAccessEmployees01;

public class Solution
{
    public IList<string> FindHighAccessEmployees(IList<IList<string>> access_times)
    {
        var eDict = new Dictionary<string, List<int>>();

        foreach (var access in access_times)
        {
            var e = access[0];
            var t = int.Parse(access[1]);

            if (!eDict.ContainsKey(e))
                eDict[e] = new List<int>();

            eDict[e].Add(t);
        }

        var result = new List<string>();

        foreach (var (e, t) in eDict)
        {
            t.Sort();

            for (var i = 0; i < t.Count - 2; i++)
            {
                if (t[i + 2] - t[i] >= 100)
                    continue;

                result.Add(e);

                break;
            }
        }

        return result;
    }
}
