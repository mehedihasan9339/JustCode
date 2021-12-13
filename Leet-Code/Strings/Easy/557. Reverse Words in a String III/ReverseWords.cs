public string ReverseWords(string s)
{
	var result = "";
	var words = s.Split(' ');
	foreach (var item in words)
	{
		for (int i = item.Length - 1; i >= 0; i--)
		{
			result += item[i];
		}
		result += " ";
	}
	return result.Trim();
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
