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
        
        for(int i = 2;i<lists.Length;i++)
        {
            head = Merge2Lists(head, lists[i]);
        }
        
        return head;
    }
    
    public ListNode Merge2Lists(ListNode list1, ListNode list2)
    {
        ListNode head = new ListNode();
        ListNode tail = head;
        
        while(list1 != null && list2 != null)
        {
            if(list1.val < list2.val)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }
            tail = tail.next;
        }
        
        tail.next = (list1 == null) ? list2 : list1;
        return head.next;
    }
}