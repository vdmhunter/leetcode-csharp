namespace LeetCodeCSharpApp.UTF8Validation01;

public class Solution
{
    public bool ValidUtf8(int[] data)
    {
        var remainingBytes = 0;

        foreach (var b in data)
        {
            var ones = 0;
            
            for (var j = 7; j >= 0; j--)
            {
                if ((b & (1 << j)) == 0)
                    break;
                
                ones++;
            }

            if (remainingBytes > 0)
            {
                if (ones != 1)
                    return false;
            }
            else if (ones != 0)
            {
                if (ones is 1 or > 4)
                    return false;
                
                remainingBytes = ones;
            }

            if (remainingBytes > 0)
                remainingBytes--;
        }

        return remainingBytes == 0;
    }
}
