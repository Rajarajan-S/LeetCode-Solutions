public class Solution {
    public bool IsCircularSentence(string sentence) {
        
        string[] s = sentence.Split(' ');
        
        if(s.Last().Last() != s.First().First()) return false;
        
        for(int i = 0; i < s.Length-1; i++){
            if(s[i].Last() != s[i+1].First()) return false;
        }         
        return true;
    }
}