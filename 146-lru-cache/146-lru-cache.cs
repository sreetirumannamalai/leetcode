public class LRUCache {
    public class Cache
    {
        public int cacheKey;
        public int cacheValue;
        public Cache(int key, int value)
        {
            cacheKey = key;
            cacheValue = value;
        }
    }
    
    int capacity =  0;
    Dictionary<int, LinkedListNode<Cache>> dict = new Dictionary<int, LinkedListNode<Cache>>();
    LinkedList<Cache> lruCache;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        lruCache = new LinkedList<Cache>();
    }
    
    public int Get(int key) {
        if(!dict.ContainsKey(key))
            return -1;
        
        LinkedListNode<Cache> cache = dict[key];
        lruCache.Remove(cache);
        lruCache.AddFirst(cache);
        return cache.Value.cacheValue;
    }
    
    public void Put(int key, int value) {
        if(dict.ContainsKey(key))
        {
            dict[key].Value.cacheValue = value;
            LinkedListNode<Cache> cache = dict[key];
            lruCache.Remove(cache);
            lruCache.AddFirst(cache);
        }
        else
        {
            Cache cache = new Cache(key, value);
            dict.Add(key, new LinkedListNode<Cache>(cache));
            lruCache.AddFirst(dict[key]);
            if(dict.Count > capacity)
            {
                LinkedListNode<Cache> lastNode = lruCache.Last;
                dict.Remove(lastNode.Value.cacheKey);
                lruCache.Remove(lastNode);
            }
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */