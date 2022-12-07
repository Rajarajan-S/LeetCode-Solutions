public class Solution {
    private int sum;
    
    public int RangeSumBST(TreeNode root, int low, int high) {
        if (root == null)
        {
            return 0;
        }
        
        if (root.val > high)
        {
            RangeSumBST(root.left, low, high);
        }
        else if (root.val < low)
        {
            RangeSumBST(root.right, low, high);
        }
        else
        {
            sum += root.val;
            
            RangeSumBST(root.left, low, high);
            RangeSumBST(root.right, low, high);
        }
        
        return sum;
    }
}
