public class Solution {
    public int ScoreOfString(string s) {
        var result = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            result += Math.Abs((int)s[i] - (int)s[i + 1]);
        }

        return result;
    }
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
