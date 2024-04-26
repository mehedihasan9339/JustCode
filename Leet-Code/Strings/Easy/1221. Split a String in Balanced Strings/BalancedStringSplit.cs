public class Solution {
    public int BalancedStringSplit(string s) {
        int balance = 0;
        int count = 0;
        foreach (char c in s)
        {
            if (c == 'L')
            {
                balance++;
            }
            else
            {
                balance--;
            }
            if (balance == 0)
            {
                count++;
            }
        }
        return count;
    }
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
