
namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Tests()
    {
        var solution = new Solution();
        var list = new TreeNode(2, new TreeNode(1), new TreeNode(3));
        var result = solution.InvertTree(list);
        Assert.Equal(new TreeNode(2, new TreeNode(3), new TreeNode(1)), result);
    }
     [Fact]
    public void Initial_Test()
    {
        var solution = new Solution();
        var list = new TreeNode(4, new TreeNode(2, new TreeNode(1),new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));
        var result = solution.InvertTree(list);
        Assert.Equal(new TreeNode(4, new TreeNode(7, new TreeNode(9),new TreeNode(6)), new TreeNode(2, new TreeNode(3), new TreeNode(1))), result);
    }
}
