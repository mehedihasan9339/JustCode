public int[] Shuffle(int[] nums, int n) {
	int length = nums.Length;
	int[] ans = new int[length];

	for (int i = 0; i < n; i++)
	{
		ans[2 * i] = nums[i];
		ans[(2 * i) + 1] = nums[n + i];
	}

	return ans;
}


/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
