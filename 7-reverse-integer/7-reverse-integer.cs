public class Solution {
    public int Reverse(int x) {
        long rev = 0;
        while (x != 0){
            rev = (x % 10) + (rev * 10);
            x = x/10;
            if (rev > Int32.MaxValue || rev < Int32.MinValue){
                return 0;
            }    
        }
        return (int) rev;
    }
}