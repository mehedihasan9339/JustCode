public static List<int> compareTriplets(List<int> a, List<int> b)
{
	var bobEarn = 0;
	var aliceEarn = 0;

	for (int i = 0; i < a.Count; i++)
	{
		if (a[i] < b[i])
		{
			bobEarn++;
		}
		if (a[i] > b[i])
		{
			aliceEarn++;
		}
	}

	var result = new List<int>()
	{
		aliceEarn, bobEarn
	};

	return result;
}