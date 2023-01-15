public static void plusMinus(List<int> arr)
{
    decimal totalPlus = 0;
    decimal totalMinus = 0;
    decimal totalZeros = 0;

    foreach (var item in arr)
    {
        if (item > 0)
        {
            totalPlus++;
        }
        else if (item < 0)
        {
            totalMinus++;
        }
        else
        {
            totalZeros++;
        }
    }

    Console.WriteLine(totalPlus / arr.Count);
    Console.WriteLine(totalMinus / arr.Count);
    Console.WriteLine(totalZeros / arr.Count);
}