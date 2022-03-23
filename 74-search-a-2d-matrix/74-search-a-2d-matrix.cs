public class Solution {
    //O(log(m*n))
     public bool SearchMatrix(int[][] matrix, int target)
    {
        var m = matrix.Length;
        if (m == 0)
            return false;

        var n = matrix[0].Length;
        var lo = 0;
        var hi = m * n - 1;

        while (lo <= hi)
        {
            var mid = (lo + hi) / 2;
            var i = mid / n;
            var j = mid % n;

            if (matrix[i][j] == target)
                return true;

            if (matrix[i][j] < target)
                lo = mid + 1;
            else
                hi = mid - 1;
        }

        return false;
    }
}
           