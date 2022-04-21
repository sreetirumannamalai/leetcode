/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        if(head == null) return null;
        
        Node current = head;
        while(current!= null)
        {
            Node copyNode = new Node(current.val);
            copyNode.next = current.next;
            current.next = copyNode;
            current = current.next.next;
        }
        
        current = head;
        while(current != null)
        {
            current.next.random = current.random == null ? null : current.random.next;
            current = current.next.next;
        }
        
        Node dummyHead = new Node(-1);
        Node dummy = dummyHead;
        current = head;
        while(current != null)
        {
            dummy.next = current.next;
            dummy = dummy.next;
            current.next = current.next.next;
            current = current.next;
        }
        return dummyHead.next;
    }
}