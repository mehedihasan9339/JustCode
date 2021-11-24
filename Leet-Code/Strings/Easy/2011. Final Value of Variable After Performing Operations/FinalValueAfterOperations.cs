public int FinalValueAfterOperations(string[] operations) {
	int initial = 0;
		foreach (var item in operations)
		{
			if (item.Contains("++"))
			{
				initial++;
			}
			else
			{
				initial--;
			}
		}
		return initial;
}