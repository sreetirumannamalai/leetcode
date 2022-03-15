public class Solution {
    //O(n) sc O(1)
    public int MinSwaps(int[] data) {
        
        int numOfOne = 0;
        foreach(int d in data)
        {
            if(d == 1) numOfOne++;
        }
        
        int min = int.MaxValue;
        int left = 0;
        int right = 0;
        int numOfZero = 0;
        while(right < data.Length)
        {
            if(data[right] == 0)
                numOfZero++;
            
            right++;
            
            if(right - left == numOfOne)
            {
                min = Math.Min(min, numOfZero);
                if(data[left] == 0)
                    numOfZero--;
                
                left++;
            }
        }
          
        return min == int.MaxValue ? 0 : min;
    }
}