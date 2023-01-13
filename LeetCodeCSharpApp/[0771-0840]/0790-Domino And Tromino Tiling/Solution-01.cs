namespace LeetCodeCSharpApp.DominoAndTrominoTiling01;

public class Solution
{
    private const int M = 1000000007;

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

        long n1 = 1;
        long n2 = 2;
        long n3 = 5;
        long n4 = 0;

        for (var i = 0; i <= n - 4; i++)
        {
            n4 = 2 * n3 % M + n1 % M;
            n1 = n2;
            n2 = n3;
            n3 = n4;
        }

        return (int)n4 % M;
    }
}
