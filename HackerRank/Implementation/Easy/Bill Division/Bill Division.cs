public static int sockMerchant(int n, List<int> ar)
{
    int count = 0;
    var group = ar.GroupBy(x => x);
    foreach (var element in group)
    {
        count += (element.Count() / 2);
    }
    return count;
}