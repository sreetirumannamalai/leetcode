public class Solution {
    //Two Sum II - Input Array Is Sorted
    //TC O(n) sc O(1)
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length-1;
        for(int i=0;i<numbers.Length;i++)
        {
            if(numbers[left] + numbers[right] == target)
                return new int[2]{left+1, right+1};
            
            if(numbers[left] + numbers[right] > target)
                right--;
            else
                left++;
        }
        return new int[2]{-1,-1};
    }
}