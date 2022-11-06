public class Solution {
    public int MinPartitions(string n) {
        int max = 0;
        foreach(var c in n)
        {
            int num = c - '0';
            max = Math.Max(num, max);
        }
        return max;
    }
}