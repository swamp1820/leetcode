
namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Tests()
    {
        var solution = new Solution();
        var list = new TreeNode(1, null, new TreeNode(2));
        var result = solution.MaxDepth(list);
        Assert.Equal(2, result);
    }
     [Fact]
    public void Initial_Test()
    {
        var solution = new Solution();
        var list = new TreeNode(3, new TreeNode(9, null,null), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        var result = solution.MaxDepth(list);
        Assert.Equal(3, result);
    }
}
