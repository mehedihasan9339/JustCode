for (int i = 1; i <= n; i++)
{
	int spaces = n - i;
	int hashes = i;

	Console.Write(new string(' ', spaces));
	Console.WriteLine(new string('#', hashes));
}