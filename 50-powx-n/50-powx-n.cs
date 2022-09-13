public class Solution {
    //Pow(x, n)
    //TC O(log n) SC O(log n)
     private double FastPow(double x, long n) {
        if (n == 0) {
            return 1.0;
        }
        double half = FastPow(x, n / 2);
        if (n % 2 == 0) {
            return half * half;
        } else {
            return half * half * x;
        }
    }
    public double MyPow(double x, int n) {
        long N = n;
        if (N < 0) {
            x = 1 / x;
            N = -N;
        }

        return FastPow(x, N);
    }
}