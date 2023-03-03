
namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Tests()
    {
        var solution = new Solution();
        var list = new NaryTreeNode(1, new List<NaryTreeNode>(){
            new NaryTreeNode(3, new List<NaryTreeNode>(){
                new NaryTreeNode(5),
             new NaryTreeNode(6)
            }),
             new NaryTreeNode(2),
             new NaryTreeNode(4)
        });
        var result = solution.Preorder(list);
        Assert.Equal(new List<int> { 1,3,5,6,2,4 }, result);
    }
}
