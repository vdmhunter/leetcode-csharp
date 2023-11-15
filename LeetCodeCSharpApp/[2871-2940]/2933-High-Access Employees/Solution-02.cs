// ReSharper disable InconsistentNaming

namespace LeetCodeCSharpApp.HighAccessEmployees02;

public class Solution
{
    public IList<string> FindHighAccessEmployees(IList<IList<string>> access_times)
    {
        return access_times
            .GroupBy(a => a[0])
            .Select(g => new { Employee = g.Key, Times = g.Select(x => int.Parse(x[1])).OrderBy(x => x).ToList() })
            .Where(e => e.Times.Where((_, i) => i < e.Times.Count - 2 && e.Times[i + 2] - e.Times[i] < 100).Any())
            .Select(e => e.Employee)
            .ToList();
    }
}
