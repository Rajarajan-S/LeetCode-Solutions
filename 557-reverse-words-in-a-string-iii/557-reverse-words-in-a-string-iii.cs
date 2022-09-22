public class Solution {
    public string ReverseWords(string s) {
        int l = s.Length;
        if(l == 1){
            return s;
        } 
        
        int firstIndex, lastIndex;
        char[] str = s.ToCharArray(); 
        char temp;
        
        for(int index = 0 ; index < l ; index++){
            firstIndex = index;
            while(++index < l && str[index] != ' '); 
            lastIndex = index - 1; 
            
            while(firstIndex < lastIndex){
                temp = str[firstIndex];
                str[firstIndex++] = str[lastIndex];
                str[lastIndex--] = temp;
            }
        }
        return new string (str);
    }
}