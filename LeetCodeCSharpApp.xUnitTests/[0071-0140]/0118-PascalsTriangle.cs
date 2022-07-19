// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Xunit;
using Solution01 = LeetCodeCSharpApp.PascalsTriangle01;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class PascalsTriangleTests
{
    private readonly Solution01.Solution _solution01;

    private const string ProblemName = "0118-Pascal's Triangle";

    #region Test Case 001

    private readonly int _testcase001_numRows = 5;
    private readonly IList<IList<int>> _testcase001_output = new List<IList<int>>
    {
        new List<int> { 1 },
        new List<int> { 1, 1 },
        new List<int> { 1, 2, 1 },
        new List<int> { 1, 3, 3, 1 },
        new List<int> { 1, 4, 6, 4, 1 }
    };

    #endregion

    #region Test Case 001

    private readonly int _testcase002_numRows = 1;
    private readonly IList<IList<int>> _testcase002_output = new List<IList<int>>
    {
        new List<int> { 1 }
    };

    #endregion

    public PascalsTriangleTests()
    {
        _solution01 = new Solution01.Solution();
    }

    #region Solution-01

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.Generate(_testcase001_numRows);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.Generate(_testcase002_numRows);
        Assert.Equal(_testcase002_output, output);
    }

    #endregion
}
