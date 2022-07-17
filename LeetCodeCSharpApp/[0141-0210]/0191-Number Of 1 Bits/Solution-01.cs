namespace LeetCodeCSharpApp.NumberOf1Bits01;

public class Solution {
    public int HammingWeight(uint n)
    {
        var cnt = 0;
        
        while(n != 0)
        {
            cnt += ((n & 1) == 1 ? 1 : 0);
            n >>= 1;
        }
        
        return cnt;
    }
}