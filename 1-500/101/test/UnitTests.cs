
namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Tests()
    {
        var solution = new Solution();
        var list = new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(2, new TreeNode(4), new TreeNode(3)));
        var result = solution.IsSymmetricRecursive(list);
        Assert.Equal(true, result);
    }

    [Fact]
    public void Initial_Tests2()
    {
        var solution = new Solution();
        var list = new TreeNode(1, new TreeNode(2, null, new TreeNode(3)), new TreeNode(2, null, new TreeNode(3)));
        var result = solution.IsSymmetricRecursive(list);
        Assert.Equal(false, result);
    }

   
}
