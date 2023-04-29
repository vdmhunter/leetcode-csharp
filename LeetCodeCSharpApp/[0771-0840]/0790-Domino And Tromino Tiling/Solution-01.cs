namespace LeetCodeCSharpApp.DominoAndTrominoTiling01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int NumTilings(int n)
    {
        switch (n)
        {
            case 0:
                return 0;
            case 1:
                return 1;
            case 2:
                return 2;
            case 3:
                return 5;
        }

        var n1 = 1L;
        var n2 = 2L;
        var n3 = 5L;
        var n4 = 0L;

        for (var i = 0; i <= n - 4; i++)
        {
            n4 = 2 * n3 % Mod + n1 % Mod;
            n1 = n2;
            n2 = n3;
            n3 = n4;
        }

        return (int)n4 % Mod;
    }
}
