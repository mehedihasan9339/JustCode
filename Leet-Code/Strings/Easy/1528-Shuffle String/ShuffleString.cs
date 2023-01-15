public string RestoreString(string s, int[] indices)
{
	var result = s.ToCharArray();

	for (int i = 0; i < indices.Length; ++i)
	{
		result[indices[i]] = s[i];
	}

	return String.Join("", result);
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
