namespace LeetCodeCSharpApp.UglyNumberII03;

public class Solution
{
    public int NthUglyNumber(int n)
    {
        var state = new int[n];
        state[0] = 1;
        var p2 = 0;
        var p3 = 0;
        var p5 = 0;

        for (var i = 1; i < n; i++)
        {
            state[i] = Math.Min(
                state[p2] * 2,
                Math.Min(
                    state[p3] * 3,
                    state[p5] * 5));

            p2 += state[i] == state[p2] * 2 ? 1 : 0;
            p3 += state[i] == state[p3] * 3 ? 1 : 0;
            p5 += state[i] == state[p5] * 5 ? 1 : 0;
        }

        return state[^1];
    }
}
