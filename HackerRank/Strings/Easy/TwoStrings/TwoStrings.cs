public static string twoStrings(string s1, string s2)
{
    var longWord = s1.Length >= s2.Length ? s1 : s2;

    var anotherWord = s1 == longWord ? s2 : s1;

    string matched = "NO";
    foreach (var item in longWord)
    {
        if (anotherWord.IndexOf(item) >= 0)
        {
            matched = "YES";
            break;
        }
    }

    return matched;
}