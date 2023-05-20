namespace LeetCodeCSharpApp.EvaluateDivision01;

public class Solution
{
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
    {
        var map = CreateMap(equations, values);
        var visited = new HashSet<string>();

        return queries.Select(s => FindResult(s[1], s[0], map, visited)).ToArray();
    }

    private static Dictionary<string, Dictionary<string, double>> CreateMap(IList<IList<string>> equations,
        double[] values)
    {
        var map = new Dictionary<string, Dictionary<string, double>>();

        foreach (var (numerator, denominator, value) in equations.Zip(values, (e, v) => (e[0], e[1], v)))
        {
            if (!map.ContainsKey(numerator))
                map[numerator] = new Dictionary<string, double>();

            if (!map.ContainsKey(denominator))
                map[denominator] = new Dictionary<string, double>();

            map[numerator][denominator] = 1 / value;
            map[denominator][numerator] = value;
        }

        return map;
    }

    private static double FindResult(string start, string target, Dictionary<string, Dictionary<string, double>> map,
        HashSet<string> visited)
    {
        if (!map.ContainsKey(start))
            return -1;

        if (start == target)
            return 1;

        var current = -1D;
        visited.Add(start);

        foreach (var key in map[start].Keys.Where(k => !visited.Contains(k)))
        {
            current = FindResult(key, target, map, visited);

            if (current == -1D)
                continue;

            current *= map[start][key];

            break;
        }

        visited.Remove(start);

        return current;
    }
}
