namespace LeetCodeCSharpApp.HappyNumber01;

/// <summary>
/// Floyd's Cycle-Finding Algorithm
/// </summary>
public class Solution
{
    public bool IsHappy(int n)
    {
        int fast;
        var slow = fast = n;

        do
        {
            slow = DigitSquareSum(slow);
            fast = DigitSquareSum(fast);
            fast = DigitSquareSum(fast);

            if (fast == 1)
                return true;
            
        } while (slow != fast);

        return false;
    }

    private int DigitSquareSum(int n)
    {
        var sum = 0;

        while (n > 0)
        {
            var tmp = n % 10;
            sum += tmp * tmp;
            n /= 10;
        }

        return sum;
    }
}
