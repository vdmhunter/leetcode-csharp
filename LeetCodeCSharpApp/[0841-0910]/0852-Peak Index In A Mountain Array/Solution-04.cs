namespace LeetCodeCSharpApp.PeakIndexInAMountainArray04;

public class Solution
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        int Gold1(int l, int r)
        {
            return l + (int)Math.Round((r - l) * 0.382);
        }

        int Gold2(int l, int r)
        {
            return l + (int)Math.Round((r - l) * 0.618);
        }

        int l = 0, r = arr.Length - 1;
        int x1 = Gold1(l, r), x2 = Gold2(l, r);

        while (x1 < x2)
        {
            if (arr[x1] < arr[x2])
            {
                l = x1;
                x1 = x2;
                x2 = Gold1(x1, r);
            }
            else
            {
                r = x2;
                x2 = x1;
                x1 = Gold2(l, x2);
            }
        }

        var maxIndex = l;

        for (var i = l; i <= r; i++)
            if (arr[i] > arr[maxIndex])
                maxIndex = i;

        return maxIndex;
    }
}
