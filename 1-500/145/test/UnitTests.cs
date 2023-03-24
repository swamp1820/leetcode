
namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Tests()
    {
        var solution = new Solution();
        var list = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));
        var result = solution.PreorderTraversal(list);
        Assert.Equal(new[]{1,2,3}, result);
    }
}
