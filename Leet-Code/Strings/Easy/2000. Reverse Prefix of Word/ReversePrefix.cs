public string ReversePrefix(string word, char ch)
{
    var subStr = word.Substring(0, word.IndexOf(ch) + 1);
    var appendStr = word.Substring(word.IndexOf(ch) + 1);

    var result = "";
    for (int i = word.IndexOf(ch); i >= 0; i--)
    {
        result += subStr[i];
    }

    return result + appendStr;
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
