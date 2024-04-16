public int[] BuildArray(int[] nums) {
	int n = nums.Length;
	int[] ans = new int[n];

	for (int i = 0; i < n; i++)
	{
		ans[i] = nums[nums[i]];
	}

	return ans;
}
/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
