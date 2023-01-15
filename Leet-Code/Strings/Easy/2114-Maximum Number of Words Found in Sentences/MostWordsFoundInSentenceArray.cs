static void Main(string[] args)
{
	var list = new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };
	Console.WriteLine(MostWordsFound(list));
}

public static int MostWordsFound(string[] sentences)
{
	int maxIndex = 0;
	int maxWords = 0;
	for (int i = 0; i < sentences.Length; i++)
	{
		var numberOfWords = sentences[i].Trim().Split(" ").Length;

		if (numberOfWords > maxWords)
		{
			maxIndex = i;
			maxWords = sentences[i].Split(" ").Length;
		}
	}

	return maxWords;
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
