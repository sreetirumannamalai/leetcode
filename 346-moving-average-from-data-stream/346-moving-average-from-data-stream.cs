public class MovingAverage {
    double sum;
    Queue<int> queue;
    int maxsize;
    public MovingAverage(int size) {
        maxsize = size;
        sum = 0.0;
        queue = new Queue<int>();
    }
    
    public double Next(int val) {
        if(queue.Count() == maxsize)
           sum -= queue.Dequeue();
        
        queue.Enqueue(val);
        sum += val;
        
        return sum / queue.Count();
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */