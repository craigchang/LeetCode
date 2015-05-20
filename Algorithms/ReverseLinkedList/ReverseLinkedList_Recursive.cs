/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        // Base case
        if (head == null)
            return null;
        else if (head.next == null)
            return head;

        // Recursive case
        ListNode next = head.next;
        head.next = null;
        ListNode rest = ReverseList(next);
        next.next = head;
        return rest;
    }
}