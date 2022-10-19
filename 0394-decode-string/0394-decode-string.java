class Solution {
    int i = 0;
    public String decodeString(String s) {
        StringBuilder sb = new StringBuilder();
        int num = 0;
        while (i < s.length()) {
            char c= s.charAt(i++);
            if (Character.isDigit(c)) {
                num = num * 10 + c - '0';
            } else if (c == '[') {
                String sub = decodeString(s);
                for (int i = 0; i < num; i++) sb.append(sub);   
                num = 0;
            } else if (c == ']') {
                break;
            } else {
                sb.append(c);
            }
        }
        return sb.toString();
    }
}