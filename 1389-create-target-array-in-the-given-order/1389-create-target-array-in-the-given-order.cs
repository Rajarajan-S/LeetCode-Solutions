public class Solution
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> op = new List<int>();
            for (int i = 0; i < index.Length; i++)
            {
                op.Insert(index[i], nums[i]);
            }
            return op.ToArray();
        }
    }