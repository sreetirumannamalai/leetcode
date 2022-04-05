public class LogSystem
{
    Dictionary<int, long> logs;
    public LogSystem()
    {
        logs = new Dictionary<int, long>();
    }

    public void Put(int id, string timestamp)
    {
        logs.Add(id, long.Parse(timestamp.Replace(":", string.Empty)));
    }

    public IList<int> Retrieve(string s, string e, string gra)
    {
        var dict = new Dictionary<string, long>() 
        {
            //     YYYYMMDDHHMMSS
            {"Year",  10000000000}, 
            {"Month",   100000000},
            {"Day",       1000000},
            {"Hour",        10000},
            {"Minute",        100},
            {"Second",          1}
        };
        
        long div = dict[gra], start = long.Parse(s.Replace(":", "")) / div, end = long.Parse(e.Replace(":", "")) / div;
        return logs.Where(x => x.Value/div >= start && x.Value/div <= end).Select(x => x.Key).ToList();
    }
}
/**
 * Your LogSystem object will be instantiated and called as such:
 * LogSystem obj = new LogSystem();
 * obj.Put(id,timestamp);
 * IList<int> param_2 = obj.Retrieve(start,end,granularity);
 */