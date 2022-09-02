public class Solution {
    //Buildings With an Ocean View
    //TC O(n) SC O(n)
    public int[] FindBuildings(int[] heights) {
        if(heights.Length == 0) return null;
        
        List<int> result = new List<int>(){heights.Length - 1};
        int max = heights[heights.Length - 1];
        for(int i= heights.Length -2 ;i>-1;i--)
        {
             if(heights[i] > max)
             { 
                 max = heights[i];
                 result.Add(i);
             }
        }
        result.Reverse();
        return result.ToArray();
    }
}