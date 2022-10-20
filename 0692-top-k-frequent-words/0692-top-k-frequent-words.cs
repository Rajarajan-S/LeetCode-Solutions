public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        return words.GroupBy(x => x)
                .Select(x => new { word = x.Key, count = x.Count() })
                .OrderByDescending(x => x.count)
                .ThenBy(x => x.word)
                .Select(x => x.word)
                .Take(k)
                .ToList();
    }
}