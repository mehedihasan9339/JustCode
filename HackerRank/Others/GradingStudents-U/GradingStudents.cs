var newGrade = new List<int>();

foreach (var grade in grades)
{
	int nextNum = grade;

	while (nextNum % 5 != 0)
	{
		nextNum++;
	}

	int diff = nextNum - grade;

	if (grade <= 33)
	{
		newGrade.Add(grade);
	}
	else if (diff < 3)
	{
		newGrade.Add(nextNum);
	}
	else
	{
		newGrade.Add(grade);
	}
}

return newGrade;