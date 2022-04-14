public class Solution {
    //O(N) sc O(n)
    public int Trap(int[] height) {
        if(height.Length == 0) return 0;
        int res = 0;
        int l =0;
        int r =height.Length - 1;
        int leftMax = height[l];
        int rightMax = height[r];
        while(l<r)
        {
            if(leftMax < rightMax)
            {
                l += 1;
                leftMax = Math.Max(leftMax, height[l]);
                res += leftMax - height[l];
            }
            else
            {
                r -= 1;
                rightMax = Math.Max(rightMax, height[r]);
                res += rightMax - height[r];
            }
        }
        return res;
    }
}
 