
namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Tests()
    {
        var solution = new Solution();
        var list = new TreeNode(6, new TreeNode(2, new TreeNode(0), new TreeNode(4, new TreeNode(3), new TreeNode(5))), new TreeNode(8, new TreeNode(7), new TreeNode(9)));
        var p = new TreeNode(2);
        var q = new TreeNode(8);
        var result = solution.LowestCommonAncestor(list, p, q);
        Assert.Equal(list, result);
    }
    [Fact]
    public void Initial_Tests2()
    {
        var solution = new Solution();
        var list = new TreeNode(3, new TreeNode(1, null, new TreeNode(2)), new TreeNode(4));
        var p = new TreeNode(2);
        var q = new TreeNode(4);
        var result = solution.LowestCommonAncestor(list, p, q);
        Assert.Equal(list, result);
    }
}
