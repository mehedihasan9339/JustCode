public IList<int> FindWordsContaining(string[] words, char x) {
	int length = words.Length;
	List<int> result = new List<int>();

	for (int i = 0; i < length; i++)
	{
		if (words[i].Contains(x))
		{
			result.Add(i);
		}
	}

	return result;
}


/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
