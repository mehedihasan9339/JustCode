public bool ArrayStringsAreEqual(string[] word1, string[] word2)
{
    var sentence1 = String.Join(String.Empty, word1);
    var sentence2 = String.Join(String.Empty, word2);
    if (sentence1 == sentence2)
        return true;
    else
        return false;
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
