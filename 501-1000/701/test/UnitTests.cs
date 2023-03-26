
namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Test()
    {
        var solution = new Solution();
        var insert = new TreeNode(5);
        var expected = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, insert));
        var list = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7));
        var result = solution.InsertIntoBST(list, 5);
        Assert.Equal(expected, result);
    }
}
