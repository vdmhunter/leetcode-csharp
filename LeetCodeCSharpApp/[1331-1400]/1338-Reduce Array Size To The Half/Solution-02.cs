namespace LeetCodeCSharpApp.ReduceArraySizeToTheHalf02;

public class Solution
{
    public int MinSetSize(int[] arr)
    {
        var d = new Dictionary<int, int>();

        foreach (var i in arr)
            if (!d.ContainsKey(i))
                d[i] = 1;
            else
                d[i]++;

        var l = d.Values.ToList();
        l.Sort((x, y) => y.CompareTo(x));

        var minTarget = arr.Length / 2;
        var sum = 0;

        for (var i = 0; i < l.Count; i++)
            if ((sum += l[i]) >= minTarget)
                return i + 1;

        return minTarget;
    }
}
