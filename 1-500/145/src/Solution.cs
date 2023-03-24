using Common;
namespace src;

public class Solution
{
    List<int> result = new List<int>();
    public IList<int> PreorderTraversal(TreeNode root)
    {
        if (root != null)
        {
            result.Add(root.val);
            PreorderTraversal(root.left);
            PreorderTraversal(root.right);
        }

        return result;
    }
}