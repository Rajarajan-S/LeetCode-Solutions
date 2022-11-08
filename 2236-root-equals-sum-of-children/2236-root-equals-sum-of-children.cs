public class Solution {
    public bool CheckTree(TreeNode root) {       
        if(root.left.val + root.right.val == root.val) return true;
        else return false;
    }
}