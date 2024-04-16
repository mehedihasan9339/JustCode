public int MaximumWealth(int[][] accounts) {
	int length = accounts.Length;
	int[] ans = new int[length];

	for (int i = 0; i < length; i++)
	{
		int sum = 0;
		foreach (var item in accounts[i])
		{
			sum += item;
		}
		ans[i] = sum;
	}

	return ans.Max();
}


/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
