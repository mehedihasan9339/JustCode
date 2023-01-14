public static string funnyString(string s)
{
    var sArray = s.ToCharArray();
    Array.Reverse(sArray);

    var s1 = new string(sArray);

    var firstIntArr = new List<int>();
    var lastIntArr = new List<int>();

    foreach (var item in s)
    {
        var ascii = (int)item;
        firstIntArr.Add(ascii);
    }

    foreach (var item in s1)
    {
        lastIntArr.Add((int)item);
    }

    var firstDiff = new List<int>();
    var lastDiff = new List<int>();

    for (int i = 0; i < firstIntArr.Count - 1; i++)
    {
        firstDiff.Add(Math.Abs(firstIntArr[i + 1] - firstIntArr[i]));
    }
    for (int i = 0; i < lastIntArr.Count - 1; i++)
    {
        lastDiff.Add(Math.Abs(lastIntArr[i + 1] - lastIntArr[i]));
    }

    if (firstDiff.SequenceEqual(lastDiff))
    {
        return "Funny";
    }
    else
    {
        return "Not Funny";
    }
}