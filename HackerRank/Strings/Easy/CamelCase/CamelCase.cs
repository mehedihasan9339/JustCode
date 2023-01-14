public static int camelcase(string s)
    {
        var n = 1;

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsUpper(s[i]))
            {
                n++;
            }
        }
        
        return n;
    }

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
