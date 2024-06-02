namespace LeetCodeCSharpApp.StudentAttendanceRecordII01;

public class Solution
{
    private readonly int[,] _transitionMatrix =
    {
        { 1, 1, 0, 1, 0, 0 },
        { 1, 0, 1, 1, 0, 0 },
        { 1, 0, 0, 1, 0, 0 },
        { 0, 0, 0, 1, 1, 0 },
        { 0, 0, 0, 1, 0, 1 },
        { 0, 0, 0, 1, 0, 0 }
    };

    private const int Mod = 1_000_000_007;

    public int CheckRecord(int n)
    {
        var resultSum = 0L;
        int[,] poweredMatrix = MatrixPow(_transitionMatrix, n);

        for (var i = 0; i < 6; i++)
            resultSum = (resultSum + poweredMatrix[0, i]) % Mod;

        return (int)resultSum;

        #region MatrixMultiply

        int[,] MatrixMultiply(int[,] a, int[,] b, int mod)
        {
            int size = a.GetLength(0);
            var result = new int[size, size];

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    var sum = 0L;

                    for (var k = 0; k < size; k++)
                    {
                        sum += (long)a[i, k] * b[k, j];
                        sum %= mod;
                    }

                    result[i, j] = (int)sum;
                }
            }

            return result;
        }

        #endregion

        #region MatrixPow

        int[,] MatrixPow(int[,] m, int p)
        {
            if (p == 1)
                return m;

            if (p % 2 != 0)
                return MatrixMultiply(m, MatrixPow(m, p - 1), Mod);

            int[,] b = MatrixPow(m, p / 2);

            return MatrixMultiply(b, b, Mod);
        }

        #endregion
    }
}
