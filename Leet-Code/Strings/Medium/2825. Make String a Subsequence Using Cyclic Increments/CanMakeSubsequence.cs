public class Solution {
    public bool CanMakeSubsequence(string str1, string str2) {
        int i = 0, j = 0;
        
        while (i < str1.Length && j < str2.Length) {
            if (str1[i] == str2[j] || IsCyclicIncrement(str1[i], str2[j])) {
                j++;
            }
            i++;
        }
        
        return j == str2.Length;
    }
    
    private bool IsCyclicIncrement(char c1, char c2) {
        return (c2 - c1 + 26) % 26 == 1;
    }
}
