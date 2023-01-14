public static string hackerrankInString(string s)
{
    var mainWord = "hackerrank";

    var index = 0;
    var matchChar = mainWord[index];

    foreach (var item in s)
    {
        if (item == matchChar)
        {
            index++;
            matchChar = mainWord[index];
        }

        if (index == mainWord.Length - 1)
        {
            break;
        }
    }

    if (index == mainWord.Length - 1)
    {
        return "YES";
    }
    else
    {
        return "NO";
    }
}