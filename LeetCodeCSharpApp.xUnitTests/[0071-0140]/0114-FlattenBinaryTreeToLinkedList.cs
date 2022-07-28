// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local

using System.Diagnostics.CodeAnalysis;
using LeetCodeCSharpApp.Common;
using LeetCodeCSharpApp.xUnitTests.Common.Extensions;
using Xunit;
using Solution01 = LeetCodeCSharpApp.FlattenBinaryTreeToLinkedList01;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class FlattenBinaryTreeToLinkedListTests
{
    private readonly Solution01.Solution _solution01;

    private const string ProblemName = "0114-Flatten Binary Tree to Linked List";

    #region Test Case 001

    private readonly TreeNode _testcase001_root = "[1,2,5,3,4,null,6]".ToBinaryTree();
    private readonly string _testcase001_output = "[1,null,2,null,3,null,4,null,5,null,6]";

    #endregion

    #region Test Case 002

    private readonly TreeNode _testcase002_root = "[]".ToBinaryTree();
    private readonly string _testcase002_output = "[]";

    #endregion

    #region Test Case 003

    private readonly TreeNode _testcase003_root = "[0]".ToBinaryTree();
    private readonly string _testcase003_output = "[0]";

    #endregion

    public FlattenBinaryTreeToLinkedListTests()
    {
        _solution01 = new Solution01.Solution();
    }

    #region Solution-01

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        _solution01.Flatten(_testcase001_root);
        Assert.Equal(_testcase001_output, $"[{string.Join(",null,", _testcase001_root.ToNlrArray())}]");
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        _solution01.Flatten(_testcase002_root);
        Assert.Equal(_testcase002_output, $"[{string.Join(",null,", _testcase002_root.ToNlrArray())}]");
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase003()
    {
        _solution01.Flatten(_testcase003_root);
        Assert.Equal(_testcase003_output, $"[{string.Join(",null,", _testcase003_root.ToNlrArray())}]");
    }

    #endregion
}
