public string TruncateSentence(string s, int k)
{
	var splitedWords = s.Split(' ');
	string result = "";
	for (int i = 0; i < k; i++)
	{
		result += splitedWords[i] + " ";
	}
	return result.Trim();
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
