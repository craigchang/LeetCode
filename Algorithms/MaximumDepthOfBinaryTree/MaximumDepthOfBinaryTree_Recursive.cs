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
    public int MaxDepth(TreeNode root) {
        if (root == null)
            return 0;
        else if (root.left == null && root.right == null)
            return 1;
        
        int leftLength = MaxDepth(root.left) + 1;
        int rightLength = MaxDepth(root.right) + 1;
            
        return leftLength > rightLength ? leftLength : rightLength;
    }
}