public class Solution {
    public int LastStoneWeight(int[] stones) {
        
        PriorityQueue<int, int> maxHeap = new ();
        
        foreach(int s in stones){
            maxHeap.Enqueue(s,-s);
        }
        
        while(maxHeap.Count > 1){
            int s1 = -maxHeap.Dequeue();
            int s2 = -maxHeap.Dequeue();
            
            if(s1 != s2) {
                int res = s1 - s2;
                res = res > 0 ? res : res * -1;
                maxHeap.Enqueue((res),-(res));
            }            
        }
        if (maxHeap.Count == 0) return 0;
        return maxHeap.Dequeue();
    }
}