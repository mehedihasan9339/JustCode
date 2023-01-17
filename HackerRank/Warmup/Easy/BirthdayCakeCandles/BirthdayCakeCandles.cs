public static int birthdayCakeCandles(List<int> candles)
{
    var maxNum = candles.Max();

    var maxCount = 0;
    foreach (var candle in candles)
    {
        if (candle == maxNum)
        {
            maxCount++;
        }
    }

    return maxCount;
}