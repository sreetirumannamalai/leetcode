public class Solution {
    public double AngleClock(int hour, int minutes) {
        int oneMinAngle = 6;
        int oneHourAngle = 30;
        
        double minutesAngle = oneMinAngle * minutes;
        double hourAngle = (hour % 12 + minutes / 60.0) * oneHourAngle;
        double diff = Math.Abs(hourAngle - minutesAngle);
        return Math.Min(diff, 360 - diff);
    }  
}