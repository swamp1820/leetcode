
namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Tests()
    {
        var solution = new Solution();
        var list = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15),new TreeNode(7)));
        var result = solution.LevelOrder(list);
        Assert.Equal(new int[][]{new int[]{3},new int[]{9,20},new int[]{15,7}}, result);
    }
}
