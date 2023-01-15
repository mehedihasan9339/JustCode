public static int simpleArraySum(List<int> ar)
{
    var sum = 0;

    foreach (var item in ar)
    {
        sum += item;
    }

    return sum;
}