namespace LeetCodeCSharpApp.NumberOf1Bits01;

public class Solution {
    public int HammingWeight(uint n) {
        var cnt = 0;
        
        while(n != 0)
        {
            cnt = cnt + ((n & 1) == 1 ? 1 : 0);
            n = n >> 1;
        }
        
        return cnt;
    }
}