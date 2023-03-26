
namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Test()
    {
        var solution = new Solution();
        var expected = new TreeNode(2, new TreeNode(1), new TreeNode(3));
        var list = new TreeNode(4, expected, new TreeNode(7));
        var result = solution.SearchBST(list, 2);
        Assert.Equal(expected, result);
    }
}
