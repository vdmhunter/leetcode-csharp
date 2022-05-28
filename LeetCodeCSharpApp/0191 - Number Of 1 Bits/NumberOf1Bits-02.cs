namespace LeetCodeCSharpApp.NumberOf1Bits02;

public class Solution {
    public int HammingWeight(uint n) {
        return Convert.ToString(n, 2).ToCharArray().Count(c => c == '1');
    }
}