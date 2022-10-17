class Solution {
    public List<Integer> findAnagrams(String s, String p) {
        List<Integer> result = new ArrayList<>();
        if (s == null || s.length() < p.length()) {
            return result;
        }
        int[] index = new int['z' - 'a' + 1];
        for (int i = 0;i < p.length(); ++i) {
            int dx = p.charAt(i) - 'a';
            index[dx] = index[dx] + 1;
        }
       
        int[] cur = new int['z' - 'a' + 1];
        int start = 0;
        
        for (int i = 0; i< s.length(); ++i) {
            int ii = s.charAt(i) - 'a';
            cur[ii] += 1;
            if (cur[ii] > index[ii]) {
                while(s.charAt(start) != s.charAt(i)) {
                    cur[s.charAt(start) - 'a'] -= 1;
                    start++;
                }
                cur[s.charAt(start) - 'a'] -= 1;
                start++;
            } else if (i - start == p.length() - 1) {
                result.add(start);
                cur[s.charAt(start) - 'a'] -= 1;
                start++;
            }
        }     
        return result;
    }
}