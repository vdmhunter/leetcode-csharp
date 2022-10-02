// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local

using System.Diagnostics.CodeAnalysis;
using Xunit;
using Solution01 = LeetCodeCSharpApp.MaximumSumOfAnHourglass01;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class MaximumSumOfAnHourglass
{
    private readonly Solution01.Solution _solution01;

    private const string ProblemName = "2428-Maximum Sum of an Hourglass";

    #region Test Case 001

    private readonly int[][] _testcase001_grid =
        { new[] { 6, 2, 1, 3 }, new[] { 4, 2, 1, 5 }, new[] { 9, 2, 8, 7 }, new[] { 4, 1, 2, 9 } };
    private readonly int _testcase001_output = 30;

    #endregion

    #region Test Case 002

    private readonly int[][] _testcase002_grid = { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } };
    private readonly int _testcase002_output = 35;

    #endregion

    public MaximumSumOfAnHourglass()
    {
        _solution01 = new Solution01.Solution();
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.MaxSum(_testcase001_grid);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.MaxSum(_testcase002_grid);
        Assert.Equal(_testcase002_output, output);
    }
}
