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
    public TreeNode InvertTree(TreeNode root) {
        if (root == null)
            return root;
        
        TreeNode left = root.left;
        TreeNode right = root.right;
        
        root.left = right;
        root.right = left;
        
        InvertTree(root.left);
        InvertTree(root.right);
        
        return root;
    }
}