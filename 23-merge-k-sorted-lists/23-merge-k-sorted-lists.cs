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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length == 0) return null;
        
        if(lists.Length == 1) return lists[0];
        
        ListNode head = Merge2Lists(lists[0],lists[1]);
        
        for(int i=2; i < lists.Length ; i++)
        {
            head = Merge2Lists(head, lists[i]);
        }
        return head;
    }
    
    public ListNode Merge2Lists(ListNode l1, ListNode l2)
    {
        ListNode head = new ListNode();
        ListNode tail = head;
        while(l1!=null && l2!= null)
        {
            if(l1.val < l2.val)
            {
                tail.next = l1;
                l1 = l1.next;
            }
            else
            {
                tail.next = l2;
                l2 = l2.next;
            }
            tail = tail.next;
        }
        tail.next = (l1 == null) ? l2 : l1;
        return head.next;
    }
}