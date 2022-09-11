/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // Constructor initializes an empty nested list.
 *     public NestedInteger();
 *
 *     // Constructor initializes a single integer.
 *     public NestedInteger(int value);
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // Set this NestedInteger to hold a single integer.
 *     public void SetInteger(int value);
 *
 *     // Set this NestedInteger to hold a nested list and adds a nested integer to it.
 *     public void Add(NestedInteger ni);
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class Solution {
    //Nested List Weight Sum 
    //TC O(n) SC O(n)
    public int DepthSum(IList<NestedInteger> nestedList) {
        
        return NestedSum(nestedList, 1);
    }
    
    // depth * (x1 + x2, + x3) == depth * x1 + depth * x2 + depth * x3
    private int NestedSum(IList<NestedInteger> nestedList, int depth)
    {
        var sum = 0;
        for (int i = 0; i < nestedList.Count; i++)
        {
            if (nestedList[i].IsInteger())
            {
                sum += depth * nestedList[i].GetInteger();
            }
            else
            {
                sum += NestedSum(nestedList[i].GetList(), depth + 1);
            }
        }
        return sum;
    }
}