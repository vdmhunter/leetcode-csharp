// ReSharper disable InconsistentNaming

using System.Diagnostics.CodeAnalysis;
using LeetCodeCSharpApp.Common;
using LeetCodeCSharpApp.xUnitTests.Common.Extensions;
using Xunit;
using Solution01 = LeetCodeCSharpApp.TwoSumIVInputIsABst01;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class TwoSumIVInputIsABstTests
{
    private readonly Solution01.Solution _solution01;

    private const string ProblemName = "0653-Two Sum IV - Input is a BST";

    #region Test Case 001

    private readonly TreeNode _testcase001_root = "[5,3,6,2,4,null,7]".ToBinaryTree();
    private readonly int _testcase001_k = 9;
    private readonly bool _testcase001_output = true;

    #endregion

    public TwoSumIVInputIsABstTests()
    {
        _solution01 = new Solution01.Solution();
    }

    #region Solution-01

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.FindTarget(_testcase001_root, _testcase001_k);
        Assert.Equal(_testcase001_output, output);
    }

    #endregion
}
