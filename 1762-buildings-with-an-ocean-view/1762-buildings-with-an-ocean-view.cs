public class Solution {
    //Buildings With an Ocean View
    //TC O(n) SC O(n)
    public int[] FindBuildings(int[] heights) {
        List<int> list =new List<int>(){heights.Length - 1};
        int max = heights[heights.Length - 1];
        for(int i=heights.Length-2;i >=0;i--)
        {
            if(heights[i] > max)
            {
                max = heights[i];
                list.Add(i);
            }
        }
        list.Reverse();
        return list.ToArray();
    }
}