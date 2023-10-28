namespace LeetCodeCSharpApp.CountVowelsPermutation01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int CountVowelPermutation(int n)
    {
        ulong a = 1, e = 1, i = 1, o = 1, u = 1;

        for (var iter = 1; iter < n; iter++)
        {
            ulong nextA = e + i + u, nextE = a + i, nextI = e + o, nextO = i, nextU = i + o;
            a = nextA % Mod;
            e = nextE % Mod;
            i = nextI % Mod;
            o = nextO % Mod;
            u = nextU % Mod;
        }

        return (int)((a + e + i + o + u) % Mod);
    }
}
