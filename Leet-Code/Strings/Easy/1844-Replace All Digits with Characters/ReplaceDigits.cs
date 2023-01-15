public string ReplaceDigits(string s)
{
    var letters = "abcdefghijklmnopqrstuvwxyz";
    var nums = "0123456789";

    string result = "";
    var prev = "";
    int count = 0;
    foreach (var item in s)
    {
        if (nums.Contains(item))
        {
            var idx = letters.IndexOf(Convert.ToChar(prev));
            var n = Convert.ToInt32(item.ToString());
            result += letters[idx + n];
        }
        else
        {
            result += item;
            prev = item.ToString();
        }
        count++;
    }
    return result;
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
