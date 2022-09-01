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
    //Remove Nth Node From End of List
    //TC O(n) SC O(1)
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head == null) return null;
        
        ListNode currentNode = head;
        for(int i=0;i<n;i++)
        {
            currentNode = currentNode.next;
        }
        
        if(currentNode ==null)
        {
            return head.next;
        }
        
        ListNode nodeBeforeRemoved = head;
        
        while(currentNode.next != null)
        {
            currentNode = currentNode.next;
            nodeBeforeRemoved = nodeBeforeRemoved.next;
        }
        
        nodeBeforeRemoved.next = nodeBeforeRemoved.next.next;
        return head;
    }
}