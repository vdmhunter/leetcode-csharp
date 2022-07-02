namespace LeetCodeCSharpApp.MaximumAreaOfAPieceOfCakeAfterHorizontalAndVerticalCuts01;

public class Solution
{
    public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts)
    {
        var hc = NewCuts(horizontalCuts, h);
        var vc = NewCuts(verticalCuts, w);

        return (int)(MaxDiff(hc) * MaxDiff(vc) % 1000000007);
    }

    private static int[] NewCuts(int[] arr, int count)
    {
        var result = new int[arr.Length + 2];
        result[0] = 0;
        result[arr.Length + 1] = count;
        
        Array.Copy(arr, 0, result, 1, arr.Length);
        Array.Sort(result);

        return result;
    }

    private static long MaxDiff(IReadOnlyList<int> arr)
    {
        var maxDifference = 0;

        for (var i = 0; i < arr.Count - 1; i++)
            maxDifference = Math.Max(maxDifference, arr[i + 1] - arr[i]);

        return maxDifference;
    }
}
