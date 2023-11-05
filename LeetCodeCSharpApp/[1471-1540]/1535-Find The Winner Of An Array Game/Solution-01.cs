namespace LeetCodeCSharpApp.FindTheWinnerOfAnArrayGame01;

public class Solution
{
    public int GetWinner(int[] arr, int k)
    {
        int cur = arr[0], win = 0;

        for (var i = 1; i < arr.Length; ++i)
        {
            if (arr[i] > cur)
            {
                cur = arr[i];
                win = 0;
            }

            if (++win == k)
                break;
        }

        return cur;
    }
}
