/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsBalanced(TreeNode root) {
        if(root == null) return true;
        
        int lDepth = height(root.left) + 1;
        int rDepth = height(root.right) + 1;
        
        if (Math.Abs(lDepth - rDepth) <= 1 && IsBalanced(root.left) && IsBalanced(root.right))
            return true;
        else
            return false;
    }
    
    public int height(TreeNode root) {
        // Base cases
        if (root == null)
            return 0;
        
        int l = height(root.left);
        int r = height(root.right);
        
        return 1 + (l >= r ? l : r);
    }
}