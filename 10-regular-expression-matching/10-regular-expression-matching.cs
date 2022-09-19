public class Solution {
    public bool IsMatch(string s, string p) {
        if (p == null && s == null)
            {
                return true;
            }
            if (p == null || s == null)
            {
                return false;
            }
            return this.IsMatchRecursion(s, 0, p, 0);
    }
    public bool IsMatchRecursion(String s, int indexOfs, String p, int indexofp){
        if (indexOfs >= s.Length)
            {
                while (indexofp + 1 < p.Length && p[indexofp + 1].Equals('*'))                 
                {                     
                    indexofp += 2;                 
                }             
            }             
            if (indexOfs >= s.Length && indexofp >= p.Length)
            {
                return true;
            }
            if (indexOfs >= s.Length || indexofp >= p.Length)
            {
                return false;
            }
            var next = indexofp + 1 >= p.Length ? ' ' : p[indexofp + 1];

            if (next.Equals('*'))
            {
                if (s[indexOfs].Equals(p[indexofp]) || p[indexofp].Equals('.'))
                {
                    return this.IsMatchRecursion(s, indexOfs + 1, p, indexofp) 
                        || this.IsMatchRecursion(s, indexOfs, p, indexofp + 2);
                }
                
                return this.IsMatchRecursion(s, indexOfs, p, indexofp + 2);
            }

            if (s[indexOfs].Equals(p[indexofp]) || p[indexofp].Equals('.'))
            {
                return this.IsMatchRecursion(s, indexOfs + 1, p, indexofp + 1);
            }
            return false;
    }
}