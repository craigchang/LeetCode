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
    public IList<int> PreorderTraversal(TreeNode root) {
        if (root == null) return new List<int>();
        
        List<int> path = new List<int>();
        
        path.Add(root.val);
        path.AddRange(PreorderTraversal(root.left));
        path.AddRange(PreorderTraversal(root.right));
        
        return path;
    }
}