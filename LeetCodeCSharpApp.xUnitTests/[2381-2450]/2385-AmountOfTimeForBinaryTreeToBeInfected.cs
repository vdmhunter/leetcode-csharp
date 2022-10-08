// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local

using System.Diagnostics.CodeAnalysis;
using LeetCodeCSharpApp.Common;
using LeetCodeCSharpApp.xUnitTests.Common.Extensions;
using Xunit;
using Solution01 = LeetCodeCSharpApp.AmountOfTimeForBinaryTreeToBeInfected01;
using Solution02 = LeetCodeCSharpApp.AmountOfTimeForBinaryTreeToBeInfected02;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class AmountOfTimeForBinaryTreeToBeInfectedTests
{
    private readonly Solution01.Solution _solution01;
    private readonly Solution02.Solution _solution02;

    private const string ProblemName = "2385-Amount Of Time For Binary Tree To Be Infected";

    #region Test Case 001

    private readonly TreeNode _testcase001_root = "[1,5,3,null,4,10,6,null,null,9,2]".ToBinaryTree();
    private readonly int _testcase001_start = 3;
    private readonly int _testcase001_output = 4;

    #endregion

    #region Test Case 002

    private readonly TreeNode _testcase002_root = "[1]".ToBinaryTree();
    private readonly int _testcase002_start = 1;
    private readonly int _testcase002_output = 0;

    #endregion

    public AmountOfTimeForBinaryTreeToBeInfectedTests()
    {
        _solution01 = new Solution01.Solution();
        _solution02 = new Solution02.Solution();
    }

    #region Solution-01

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.AmountOfTime(_testcase001_root, _testcase001_start);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.AmountOfTime(_testcase002_root, _testcase002_start);
        Assert.Equal(_testcase002_output, output);
    }

    #endregion

    #region Solution-02

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution02_TestCase001()
    {
        var output = _solution02.AmountOfTime(_testcase001_root, _testcase001_start);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution02_TestCase002()
    {
        var output = _solution02.AmountOfTime(_testcase002_root, _testcase002_start);
        Assert.Equal(_testcase002_output, output);
    }

    #endregion
}
