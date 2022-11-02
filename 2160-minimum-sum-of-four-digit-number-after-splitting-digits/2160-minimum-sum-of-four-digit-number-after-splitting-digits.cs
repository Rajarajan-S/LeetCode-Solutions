public class Solution {
    public int MinimumSum(int num) {
        int[] arr = new int[4]; 
        int cur = 0;
        while(num > 0) {
            arr[cur++] = num % 10;
            num /= 10;
        }
        Array.Sort(arr); 
        return arr[0] * 10 + arr[2] +  arr[1] * 10 + arr[3]; 
    }
}
