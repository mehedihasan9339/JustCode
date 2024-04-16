public int[] GetConcatenation(int[] nums) {
	int n = nums.Length;
	int[] concatenatedArray = new int[2 * n];

	for (int i = 0; i < n; i++)
	{
		concatenatedArray[i] = nums[i];
		concatenatedArray[i + n] = nums[i];
	}

	return concatenatedArray;
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
