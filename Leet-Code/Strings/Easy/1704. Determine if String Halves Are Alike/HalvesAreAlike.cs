public bool HalvesAreAlike(string s)
{
	var vowels = "aeiouAEIOU";

	string firstHalf = s.Substring(0, s.Length / 2);
	string secondHalf = s.Substring(s.Length / 2);

	int count1 = 0;
	int count2 = 0;

	foreach (var item in firstHalf)
	{
		if (vowels.Contains(item))
		{
			count1++;
		}
	}

	foreach (var item in secondHalf)
	{
		if (vowels.Contains(item))
		{
			count2++;
		}
	}

	if (count1 == count2)
	{
		return true;
	}
	else
	{
		return false;
	}

}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
