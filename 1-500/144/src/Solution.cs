using Common;
namespace src;

public class Solution
{
    List<int> result = new List<int>();
    public IList<int> PostorderTraversal(TreeNode root)
    {
        if (root != null)
        {
            PostorderTraversal(root.left);
            PostorderTraversal(root.right);
            result.Add(root.val);
        }

        return result;
    }
}