public class Solution {

    public int NumIdenticalPairs(int[] nums) {

        if (nums == null || nums.Length == 0)

            return 0;

        int res = 0;

        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        foreach (var num in nums)

        {
            if (!dict.ContainsKey(num))

                dict.Add(num, 0);
            
            dict[num] += 1;

        }

        foreach (var item in dict.Values)

            if (item != 1)

                res += item * (item - 1) / 2;
        return res;
    }

}


