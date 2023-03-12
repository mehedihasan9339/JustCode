public class Solution {
    public int CountAsterisks(string s) {
        var barCount = 0;
        var asteriskCount = 0;

        for (int i = 0; i < s.Length; i++)
        {
            barCount += s[i] == '|' ? 1 : 0;

            if (barCount % 2 == 0 && s[i] == '*')
            {
                asteriskCount++;
            }
        }
        return asteriskCount;
    }
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
