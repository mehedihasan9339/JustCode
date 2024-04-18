public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
	int length = candies.Length;
	List<bool> result = new List<bool>();

	for (int i = 0; i < length; i++)
	{

		if (candies[i] + extraCandies >= candies.Max())
		{
			result.Add(true);
		}
		else
		{
			result.Add(false);
		}
	}

	return result;
}


/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
