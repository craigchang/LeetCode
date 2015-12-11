/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        List<int> list = new List<int>();
        ListNode ptr = head;

        while(ptr != null){
            list.Add(ptr.val);
            ptr = ptr.next;
        }
        
        List<int> reverseList = new List<int>(list);
        reverseList.Reverse();
        
        return String.Join("", list.ToArray()) == String.Join("", reverseList.ToArray());
    }
}