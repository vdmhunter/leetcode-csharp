namespace LeetCodeCSharpApp.ValidateBinaryTreeNodes01;

public class Solution
{
    public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
    {
        var ind = new int[n];

        if (!ValidateAndCountInDegrees(n, leftChild, rightChild, ind))
            return false;

        if (ind.Count(i => i == 0) != 1)
            return false;

        var root = Array.IndexOf(ind, 0);
        var cnt = DfsCount(root, leftChild, rightChild);

        return cnt == n;
    }

    private static bool ValidateAndCountInDegrees(int n, int[] leftChild, int[] rightChild, int[] ind)
    {
        for (var i = 0; i < n; i++)
        {
            if (!ValidateChildAndCountInDegree(leftChild[i], ind) || !ValidateChildAndCountInDegree(rightChild[i], ind))
            {
                return false;
            }
        }

        return true;
    }

    private static bool ValidateChildAndCountInDegree(int child, int[] ind)
    {
        if (child > -1)
            ind[child]++;

        return child <= -1 || ind[child] <= 1;
    }

    private static int DfsCount(int i, int[] leftChild, int[] rightChild)
    {
        if (i == -1)
            return 0;

        return 1 + DfsCount(leftChild[i], leftChild, rightChild) + DfsCount(rightChild[i], leftChild, rightChild);
    }
}
