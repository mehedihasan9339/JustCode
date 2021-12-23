public string MergeAlternately(string word1, string word2)
{
	string result = "";
	var larger = "equal";
	if (word1.Length > word2.Length)
	{
		larger = word1;
	}
	if (word2.Length > word1.Length)
	{
		larger = word2;
	}
	var length = word1.Length > word2.Length ? word2.Length : word1.Length;
	for (int i = 0; i < length; i++)
	{
		result += word1[i];
		result += word2[i];
	}
	if (larger != "equal")
	{
		if (larger == word1)
		{
			result += word1.Substring(word2.Length);
		}
		else
		{
			result += word2.Substring(word1.Length);
		}
	}

	return result;
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
