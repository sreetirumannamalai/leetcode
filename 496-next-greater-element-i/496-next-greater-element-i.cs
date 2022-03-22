public class Solution {
    // O(n + m) sc O(m)
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        Dictionary<int, int> dictionary = new Dictionary<int,int>();
        Stack<int> stack = new Stack<int>();
        foreach(var num in nums2)
        {
            while(stack.Count > 0 && num > stack.Peek())
                dictionary.Add(stack.Pop(), num);
            
            stack.Push(num);
        }
        
        int[] result = new int[nums1.Length];
        for(int i=0;i<nums1.Length;i++)
            result[i] = dictionary.ContainsKey(nums1[i]) ? dictionary[nums1[i]] : -1;
        
        return result;
    }
}