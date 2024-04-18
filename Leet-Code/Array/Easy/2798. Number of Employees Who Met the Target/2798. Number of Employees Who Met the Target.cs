public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
	int length = hours.Length;
	int ans = 0;

	for (int i = 0; i < length; i++)
	{
		if (hours[i] >= target)
		{
			ans++;
		}
	}

	return ans;
}


/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
