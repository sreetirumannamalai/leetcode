public class Solution {
    public IList<int> SpiralOrder(int[][] matrix)
   {
        List<int> nums = new List<int>();
            if (matrix == null || matrix.Length == 0)
                return nums;

            int left = 0;
            int right = matrix[0].Length - 1;
            int top = 0;
            int bottom = matrix.Length - 1;
            int size = matrix.Length * matrix[0].Length;
            while (nums.Count < size)
            {
                for (int i = left; i <= right && nums.Count < size; i++)
                {
                    nums.Add(matrix[top][i]);
                }
                top++;
                for (int i = top; i <= bottom && nums.Count < size; i++)
                {
                    nums.Add(matrix[i][right]);
                }
                right--;
                for (int i = right; i >= left && nums.Count < size; i--)
                {
                    nums.Add(matrix[bottom][i]);
                }
                bottom--;
                for (int i = bottom; i >= top && nums.Count < size; i--)
                {
                    nums.Add(matrix[i][left]);
                }
                left++;
            }
        return nums;
    }
}
         