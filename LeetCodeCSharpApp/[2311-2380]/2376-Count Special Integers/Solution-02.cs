namespace LeetCodeCSharpApp.CountSpecialIntegers02;

public class Solution
{
    public int CountSpecialNumbers(int n)
    {
        var s = n.ToString();
        int digits = s.Length, result = 0;

        for (var i = 1; i < digits; i++)
        {
            int x = 1, k = 9;

            for (var j = 0; j < i - 1; j++)
            {
                x *= k;
                k--;
            }

            result += 9 * x; // ways to get special integers with digits less than that in n
        }

        var done = Enumerable.Repeat(0, 10).ToList();
        
        for (var i = 0; i < digits; i++)
        {
            // ways for equal digits
            var smaller = 0;
            
            for (var j = 0; j < s[i] - '0'; j++)
                if (done[j] == 0)
                    smaller++; // counting digits less than s[i]
            
            if (i == 0 && s[i] > '0')
                smaller--; // we cannot keep 0 at the first index
            
            int aage = 1, rem = 10 - i - 1;
            
            for (var j = i + 1; j < digits; j++)
            {
                aage *= rem;
                rem--;
            }

            result += smaller * aage;
            
            if (done[s[i] - '0'] == 0)
                done[s[i] - '0'] = 1;
            else
                return result;
        }

        return result + 1;
    }
}
