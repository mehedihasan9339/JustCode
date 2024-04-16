public int NumIdenticalPairs(int[] nums) {
	int n = nums.Length;
	int ans = 0;

	for (int i = 0; i < n; i++)
	{
		for (int j = i + 1; j < n; j++)
		{
			if (nums[i] == nums[j])
			{
				ans++;
			}
		}
	}

	return ans;
}
/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
