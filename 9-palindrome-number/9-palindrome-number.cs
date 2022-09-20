public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0){
            return false;
        }
        int n = x;
        int r = 0;
        while(n > 0){
            r = (r*10)+(n%10);
            n = n/10;
        }
        return x == r;
    }
}