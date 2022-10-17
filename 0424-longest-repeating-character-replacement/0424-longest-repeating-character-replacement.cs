public class Solution {
    public int CharacterReplacement(string s, int k) {
        if(s.Length == 0)
        {
            return 0; 
        }
        int l = 0 , res = 0; 
        Dictionary<char,int> sMap = new Dictionary<char,int>();
        for(int r = 0 ; r < s.Length ; r++)
        {

            if(sMap.ContainsKey(s[r]))
            {
                sMap[s[r]]++;
            }
            else
                sMap.TryAdd(s[r], 1); 
  
            if((r-l+1) - sMap.Max(x=>x.Value) > k)
            {
                sMap[s[l]]--; 
                l++;
            }
            res = Math.Max(res, (r-l+1));
            
        }
        return res; 
    }
}