public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
        if (strs.Length == 0){
            return String.Empty;
        }
            
        Array.Sort(strs);

        var first = strs[0];
        var last = strs[strs.Length - 1];
        var strbuilder = new StringBuilder();
        for (int i = 0; i < first.Length; i++){
            if (first[i] != last[i]){
                break;
            }
            strbuilder.Append(first[i]);            
        }
        return strbuilder.ToString();
    }
}