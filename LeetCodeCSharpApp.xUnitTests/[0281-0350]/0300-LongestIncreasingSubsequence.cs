// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local

using System.Diagnostics.CodeAnalysis;
using Xunit;
using Solution01 = LeetCodeCSharpApp.LongestIncreasingSubsequence01;
using Solution02 = LeetCodeCSharpApp.LongestIncreasingSubsequence02;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class LongestIncreasingSubsequenceTests
{
    private readonly Solution01.Solution _solution01;
    private readonly Solution02.Solution _solution02;

    private const string ProblemName = "0300-Longest Increasing Subsequence";

    #region Test Case 001

    private readonly int[] _testcase001_nums = { 10, 9, 2, 5, 3, 7, 101, 18 };

    private readonly int _testcase001_output = 4;

    #endregion

    #region Test Case 002

    private readonly int[] _testcase002_nums = { 0, 1, 0, 3, 2, 3 };

    private readonly int _testcase002_output = 4;

    #endregion

    #region Test Case 003

    private readonly int[] _testcase003_nums = { 7, 7, 7, 7, 7, 7, 7 };

    private readonly int _testcase003_output = 1;

    #endregion

    public LongestIncreasingSubsequenceTests()
    {
        _solution01 = new Solution01.Solution();
        _solution02 = new Solution02.Solution();
    }

    #region Solution-01

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.LengthOfLIS(_testcase001_nums);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.LengthOfLIS(_testcase002_nums);
        Assert.Equal(_testcase002_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase003()
    {
        var output = _solution01.LengthOfLIS(_testcase003_nums);
        Assert.Equal(_testcase003_output, output);
    }

    #endregion

    #region Solution-02

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-02")]
    public void Solution02_TestCase001()
    {
        var output = _solution02.LengthOfLIS(_testcase001_nums);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-02")]
    public void Solution02_TestCase002()
    {
        var output = _solution02.LengthOfLIS(_testcase002_nums);
        Assert.Equal(_testcase002_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-02")]
    public void Solution02_TestCase003()
    {
        var output = _solution02.LengthOfLIS(_testcase003_nums);
        Assert.Equal(_testcase003_output, output);
    }

    #endregion
}
