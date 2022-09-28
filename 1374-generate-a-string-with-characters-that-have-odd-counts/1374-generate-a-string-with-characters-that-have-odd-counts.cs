public class Solution {
    public string GenerateTheString(int n) {
        
        if(n%2 == 1){
            return new string('s', n);
        }
        else{
            return new string('s', n-1) + 'r';
        }
    }
}