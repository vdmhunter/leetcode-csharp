namespace LeetCodeCSharpApp.SignOfTheProductOfAnArray01;

public class Solution
{
    public int ArraySign(int[] nums) 
    {
        var count = 0;
        
        foreach(var n in nums)
            switch (n)
            {
                case 0:
                    return 0;
                case < 0:
                    count++;
                    break;
            }

        return count % 2 == 0 ? 1 : -1;
    }
}
