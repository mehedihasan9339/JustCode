public int NumJewelsInStones(string jewels, string stones)
{
    int count = 0;
    foreach (var item in stones)
    {
        foreach (var j in jewels)
        {
            if (item == j)
            {
                count++;
            }
        }
    }
    return count;
}