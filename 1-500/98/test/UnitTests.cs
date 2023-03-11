
namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Tests()
    {
        var solution = new Solution();
        var list = new TreeNode(5, new TreeNode(4), new TreeNode(6, new TreeNode(3), new TreeNode(7)));
        var result = solution.IsValidBST(list);
        Assert.Equal(false, result);
    }

        [Fact]
    public void Initial_Tests2()
    {
        var solution = new Solution();
        var list = new TreeNode(5, new TreeNode(1), new TreeNode(4, new TreeNode(3), new TreeNode(6)));
        var result = solution.IsValidBST(list);
        Assert.Equal(false, result);
    }

        [Fact]
    public void Initial_Tests3()
    {
        var solution = new Solution();
        var list = new TreeNode(2, new TreeNode(1), new TreeNode(3));
        var result = solution.IsValidBST(list);
        Assert.Equal(true, result);
    }
}
