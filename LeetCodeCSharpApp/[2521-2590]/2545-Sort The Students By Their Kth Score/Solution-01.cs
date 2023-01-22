namespace LeetCodeCSharpApp.SortTheStudentsByTheirKthScore01;

public class Solution
{
    public int[][] SortTheStudents(int[][] score, int k)
    {
        Array.Sort(score, (x, y) => y[k] - x[k]);

        return score;
    }
}
