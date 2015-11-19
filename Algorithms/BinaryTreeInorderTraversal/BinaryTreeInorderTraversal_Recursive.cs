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
    public IList<int> InorderTraversal(TreeNode root) {
        if (root == null) return new List<int>();
        
        List<int> path = new List<int>();
        
        path.AddRange(InorderTraversal(root.left));
        path.Add(root.val);
        path.AddRange(InorderTraversal(root.right));
        
        return path;
    }
}