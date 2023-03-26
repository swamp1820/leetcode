using Common;
namespace src;

public class Solution
{
    int Sum = 0;
    bool result = false;
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root != null)
        {
            Sum = Sum + root.val;
            if (Sum == targetSum && root.left == null && root.right == null)
            {
                result = true;
            }
            HasPathSum(root.left, targetSum);
            Sum = Sum - (root.left?.val ?? 0);
            HasPathSum(root.right, targetSum);
            Sum = Sum - (root.right?.val ?? 0);
        }
        return result;
    }
}