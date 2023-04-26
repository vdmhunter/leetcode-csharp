namespace LeetCodeCSharpApp.AddDigits02;

public class Solution
{
    public int AddDigits(int num)
    {
        while (num > 9)
        {
            var sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            num = sum;
        }

        return num;
    }
}
