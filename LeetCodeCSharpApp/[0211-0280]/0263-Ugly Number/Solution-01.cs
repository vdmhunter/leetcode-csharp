namespace LeetCodeCSharpApp.UglyNumber01;

public class Solution
{
    public bool IsUgly(int n)
    {
        switch (n)
        {
            case 1:
                return true;
            case 0:
                return false;
        }

        while (n % 2 == 0)
            n >>= 1;

        while (n % 3 == 0)
            n /= 3;

        while (n % 5 == 0)
            n /= 5;

        return n == 1;
    }
}
