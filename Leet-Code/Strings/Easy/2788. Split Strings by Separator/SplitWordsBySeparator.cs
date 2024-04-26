public class Solution {
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) {
        var result = new List<string>();

        foreach (var word in words)
        {
            result.AddRange(word.Split(separator).Where(x => x != ""));
        }

        return result;
    }
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
