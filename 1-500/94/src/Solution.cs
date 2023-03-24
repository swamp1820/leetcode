using Common;
namespace src;

public class Solution
{
    List<int> result = new List<int>();
    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root != null)
        {
            InorderTraversal(root.left);
            result.Add(root.val);
            InorderTraversal(root.right);
        }

        return result;
    }
}