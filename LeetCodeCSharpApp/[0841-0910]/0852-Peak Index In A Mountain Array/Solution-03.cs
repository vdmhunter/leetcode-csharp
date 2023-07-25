namespace LeetCodeCSharpApp.PeakIndexInAMountainArray03;

public class Solution
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        int l = 0, r = arr.Length - 1;

        while (l < r)
        {
            var mid = (l + r) / 2;

            if (arr[mid] < arr[mid + 1])
                l = mid + 1;
            else
                r = mid;
        }

        return l;
    }
}
