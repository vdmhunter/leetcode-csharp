namespace LeetCodeCSharpApp.KthDistinctStringInAnArray01;

public class Solution
{
    public string KthDistinct(string[] arr, int k)
    {
        var frequencyMap = new Dictionary<string, int>();

        foreach (string str in arr)
            if (!frequencyMap.TryAdd(str, 1))
                frequencyMap[str]++;

        foreach (string str in arr)
        {
            if (frequencyMap[str] == 1)
                k--;

            if (k == 0)
                return str;
        }

        return string.Empty;
    }
}
