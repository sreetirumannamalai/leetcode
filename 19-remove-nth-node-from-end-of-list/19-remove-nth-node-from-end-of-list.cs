/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head == null) return null;
        int length =0;
        ListNode current = head;
        while(current != null)
        {
            current = current.next;
            length++;
        }
        
        if(length == n)
            return head.next;
        
        //find node to remove - index = length - n - 1
        int nodeBeforeRemovedIndex = length - n - 1;
        current = head;
        for(int i=0;i<nodeBeforeRemovedIndex; i++)
        {
            current = current.next;
        }
        current.next = current.next.next;
        return head;
    }
}