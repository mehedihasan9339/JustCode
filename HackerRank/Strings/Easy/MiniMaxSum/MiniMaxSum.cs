public static void miniMaxSum(List<int> arr)
{
    var sumOfAllNumbers = 0L;
    var minimum = long.MaxValue;
    var maximum = 0L;
    for (int i = 0; i < 5; i++)
    {
        sumOfAllNumbers += arr[i];
        if (arr[i] < minimum)
            minimum = arr[i];

        if (arr[i] > maximum)
            maximum = arr[i];

    }
    Console.WriteLine(string.Format("{0} {1}", sumOfAllNumbers - maximum, sumOfAllNumbers - minimum));
}