public string SortSentence(string s)
{
    var realSentence = new List<string>();
    var words = s.Split(' ');
    for (int i = 1; i <= words.Length; i++)
    {
        foreach (var item in words)
        {
            if (item.Contains(i.ToString()))
            {
                var index = item.IndexOf(i.ToString());
                realSentence.Add(item.Remove(index, 1));
            }
        }
    }
    return String.Join(' ', realSentence);
}