namespace LeetCodeCSharpApp.PeakIndexInAMountainArray02;

public class Solution
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        for (var i = 1; i + 1 < arr.Length; i++)
            if (arr[i] > arr[i + 1])
                return i;

        return -1;
    }
}
