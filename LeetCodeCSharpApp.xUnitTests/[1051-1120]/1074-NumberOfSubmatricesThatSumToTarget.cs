// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local

using System.Diagnostics.CodeAnalysis;
using Xunit;
using Solution01 = LeetCodeCSharpApp.NumberOfSubmatricesThatSumToTarget01;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class NumberOfSubmatricesThatSumToTargetTests
{
    private readonly Solution01.Solution _solution01;

    private const string ProblemName = "0205-Number Of Submatrices That Sum To Target";

    #region Test Case 001

    private readonly int[][] _testcase001_matrix = { new[] { 0, 1, 0 }, new[] { 1, 1, 1 }, new[] { 0, 1, 0 } };
    private readonly int _testcase001_target = 0;
    private readonly int _testcase001_output = 4;

    #endregion

    #region Test Case 002

    private readonly int[][] _testcase002_matrix = { new[] { 1, -1 }, new[] { -1, 1 } };
    private readonly int _testcase002_target = 0;
    private readonly int _testcase002_output = 5;

    #endregion

    #region Test Case 003

    private readonly int[][] _testcase003_matrix = { new[] { 904 } };
    private readonly int _testcase003_target = 0;
    private readonly int _testcase003_output = 0;

    #endregion

    public NumberOfSubmatricesThatSumToTargetTests()
    {
        _solution01 = new Solution01.Solution();
    }

    #region Solution-01

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.NumSubmatrixSumTarget(_testcase001_matrix, _testcase001_target);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.NumSubmatrixSumTarget(_testcase002_matrix, _testcase002_target);
        Assert.Equal(_testcase002_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase003()
    {
        var output = _solution01.NumSubmatrixSumTarget(_testcase003_matrix, _testcase003_target);
        Assert.Equal(_testcase003_output, output);
    }

    #endregion
}
