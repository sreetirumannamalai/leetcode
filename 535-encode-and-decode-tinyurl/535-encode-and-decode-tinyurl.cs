public class Codec {
    Hashtable hashtable1 = new Hashtable();
    Hashtable hashtable2 = new Hashtable();
    string shortStringSource = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        StringBuilder shortString = new StringBuilder();
        if(longUrl == null || longUrl == string.Empty)
            return string.Empty;
        else if(hashtable1.ContainsKey(longUrl))
            return (string) hashtable1[longUrl];
        for(int i =0;i<=5;i++)
        {
            shortString.Append(shortStringSource[new Random().Next(0, 61)]);
        }
       
        hashtable1.Add(longUrl, "http://tinyurl.com/" + shortString.ToString());
        hashtable2.Add("http://tinyurl.com/" + shortString.ToString(), longUrl);
        
        return "http://tinyurl.com/" + shortString.ToString();
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        return (string) hashtable2[shortUrl];
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));
 