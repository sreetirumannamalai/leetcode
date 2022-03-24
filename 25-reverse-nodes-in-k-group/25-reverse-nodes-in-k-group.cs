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
    //O(n) sc O(1)
    public ListNode ReverseKGroup(ListNode head, int k) {
        if(head == null) return null;
       
       ListNode dummy = new ListNode();
        dummy.next = head;
        ListNode current = dummy;
        ListNode prev = dummy;
        ListNode next = null;
        while(current!=null)
        {
            for(int i=0;i<k&& current!=null; i++)
                current= current.next;
            
            if(current==null) break;
            
            next = current.next;
            current.next = null;
            
            ListNode start = prev.next;
            prev.next = Reverse(start);
            start.next = next;
            
            prev = start;
            current = start;
        }
        return dummy.next;
    }
   
    public ListNode Reverse(ListNode head) {
       if(head == null) return null;
        
        ListNode current = head;
        ListNode prev = null;
        while(current != null)
        {
            ListNode temp = current.next;
            current.next = prev;
            prev = current;
            current = temp;
        }
        return prev;
    }
}