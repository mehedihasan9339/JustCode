public string DestCity(IList<IList<string>> paths)
{
    var result = "";
    foreach (var item in paths)
    {
        bool isMatched = false;
        foreach (var d in paths)
        {
            if (d[0] == item[1])
            {
                isMatched = true;
                break;
            }
        }
        if (!isMatched)
        {
            result = item[1];
        }
    }
    return result;
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
