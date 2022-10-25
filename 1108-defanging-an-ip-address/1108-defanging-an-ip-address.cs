public class Solution {
    public string DefangIPaddr(string address) {
        return new StringBuilder(address).Replace(".", "[.]").ToString();
    }
}