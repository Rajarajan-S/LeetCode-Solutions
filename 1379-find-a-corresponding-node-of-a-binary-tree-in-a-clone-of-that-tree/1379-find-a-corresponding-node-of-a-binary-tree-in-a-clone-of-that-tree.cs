public class Solution {
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        
        if(original == null) return null;
        
        if(original == target) return cloned;
        
        TreeNode left = GetTargetCopy(original.left, cloned.left, target);
        TreeNode right = GetTargetCopy(original.right, cloned.right, target);
        
        if(left == null) return right;
        else return left;
    }
}