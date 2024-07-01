namespace LeetCodeCSharpApp.ThreeConsecutiveOdds01;

public class Solution
{
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        var counter = 0;

        foreach (int num in arr)
        {
            if (num % 2 == 1)
                counter++;
            else
                counter = 0;

            if (counter == 3)
                return true;
        }

        return false;
    }
}
