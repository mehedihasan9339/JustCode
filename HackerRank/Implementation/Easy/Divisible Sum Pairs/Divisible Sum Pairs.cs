public static int divisibleSumPairs(int n, int k, List<int> ar)
{
    var divArr = new List<int>();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j > i)
            {
                int sum = ar[i] + ar[j];

                if (sum % k == 0)
                {
                    divArr.Add(sum);
                }
            }
        }
    }

    return divArr.Count;
}