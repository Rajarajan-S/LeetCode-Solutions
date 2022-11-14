public class Solution {
    public string RestoreString(string s, int[] indices) {
        
        if(s.Length != indices.Length) return string.Empty ;
        
        char[] result = new char[s.Length];
        
        for (int i = 0; i < indices.Length; i++){
            
            result[indices[i]] = s[i];
            
        }
        return new string (result);
    }
}