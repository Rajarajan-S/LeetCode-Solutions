public class Solution {
    Dictionary<char, int> Romans = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},                
                {'M', 1000}
            };
    public int RomanToInt(string s) {
        var res = 0;
        var pre = 0;
        
        for (int i = s.Length - 1; i >= 0; i--){
            var a = Romans[s[i]];
            res += pre > a ? -a : a;
            pre = a;       
        }
        return res;
    }
}