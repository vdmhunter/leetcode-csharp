namespace LeetCodeCSharpApp.CanMakeArithmeticProgressionFromSequence01;

public class Solution
{
    public bool CanMakeArithmeticProgression(int[] arr)
    {
        Array.Sort(arr);

        for (var i = 2; i < arr.Length; i++)
            if (arr[i - 1] - arr[i] != arr[i - 2] - arr[i - 1])
                return false;

        return true;
    }
}
