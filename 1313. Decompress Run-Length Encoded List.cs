public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        if(nums.Length == 0)
        {
            return new int[]{};
        }
        List<int> res = new List<int>(); 
        int i = 0;
        while( (i +1) < nums.Length)
        {
            var freq = nums[i];
            var val = nums[i+1];
            while(freq > 0)
            {
                res.Add(val);
                freq--;
            }
            
            i +=2;
        }
        return res.ToArray(); 
    }
}
