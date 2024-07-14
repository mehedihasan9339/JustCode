public class Solution {
    public string CapitalizeTitle(string title) {
        string[] arr = title.ToLower().Split(" ");

        string[] resultArr = new string[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            string word = arr[i];
            if (word.Length > 2)
            {
                resultArr[i] = word[0].ToString().ToUpper() + word.Substring(1, word.Length - 1);
            }
            else
            {
                resultArr[i] = word;
            }
        }

        return string.Join(" ", resultArr);
    }
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
