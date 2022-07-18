// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local

using System.Diagnostics.CodeAnalysis;
using Xunit;
using Solution01 = LeetCodeCSharpApp.IsomorphicStrings01;

[ExcludeFromCodeCoverage]
public class IsomorphicStringsTests {
    
    private readonly Solution01.Solution _solution01;

    private const string ProblemName = "0205-Isomorphic Strings";
    
    #region Test Case 001

    private readonly string _testcase001_s = "egg";
    private readonly string _testcase001_t = "add";

    #endregion
    
    #region Test Case 002

    private readonly string _testcase002_s = "foo";
    private readonly string _testcase002_t = "bar";

    #endregion
    
    #region Test Case 003

    private readonly string _testcase003_s = "paper";
    private readonly string _testcase003_t = "title";

    #endregion
    
    public IsomorphicStringsTests()
    {
        _solution01 = new Solution01.Solution();
    }
    
    #region Solution-01

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.IsIsomorphic(_testcase001_s, _testcase001_t);
        Assert.True(output);
    }
    
    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.IsIsomorphic(_testcase002_s, _testcase002_t);
        Assert.False(output);
    }
    
    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase003()
    {
        var output = _solution01.IsIsomorphic(_testcase003_s, _testcase003_t);
        Assert.True(output);
    }
    
    #endregion
}
