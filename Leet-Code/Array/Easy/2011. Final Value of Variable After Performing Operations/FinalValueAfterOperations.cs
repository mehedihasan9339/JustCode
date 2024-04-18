public int FinalValueAfterOperations(string[] operations)
{
    int initial = 0;
    foreach (var item in operations)
    {
        if (item.Contains("++"))
        {
            initial++;
        }
        else
        {
            initial--;
        }
    }
    return initial;
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
