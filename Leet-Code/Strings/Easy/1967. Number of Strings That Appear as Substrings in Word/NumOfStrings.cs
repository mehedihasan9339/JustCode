public int NumOfStrings(string[] patterns, string word)
{
	int count = 0;

	foreach (var item in patterns)
	{
		bool isExist = true;
		foreach (var c in item)
		{
			if (!word.Contains(c))
			{
				isExist = false;
			}
		}
		if (isExist)
		{
			count++;
		}
	}

	return count;
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
