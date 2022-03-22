public class Solution {
    //O(n) sc O(1)
    public int NumOfSubarrays(int[] arr) {
        int n = arr.Length;
        int even = 0;
        int odd = 1;
        int mod = 1000000007;
        int currSum = 0;
        int res = 0;
        for(int i =0;i<n;i++)
        {
            currSum += arr[i];
            if(currSum % 2 == 0)
            {
                res = res + even; // even+even or odd+odd == even
                odd++;
            }
            else
            {
                even++;
                res = res + odd; // odd+even or even+odd == odd
            }
            res = res % mod;
        }
        return res;
    }
}