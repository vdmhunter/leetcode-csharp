namespace LeetCodeCSharpApp.IncreasingTripletSubsequence01;

public class Solution
{
    public bool IncreasingTriplet(int[] nums)
    {
        int small = int.MaxValue, big = int.MaxValue;

        foreach (var n in nums)
            if (n <= small)
                small = n;
            else if (n <= big)
                big = n;
            else return true;

        return false;
    }
}
