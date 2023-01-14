public static int minimumNumber(int n, string password)
{
// Return the minimum number of characters to make the password strong
    var extraChars = 0;
    var digitOccured = false;
    var lowerCaseOccured = false;
    var upperCaseOccured = false;
    var specialCharsOccured = false;

    var specialChars = "!@#$%^&*()-+";

    for (int i = 0; i < password.Length; i++)
    {
        if (char.IsUpper(password[i]) && upperCaseOccured == false)
        {
            upperCaseOccured = true;
        }
        else if (char.IsLower(password[i]) && lowerCaseOccured == false)
        {
            lowerCaseOccured = true;
        }
        else if (char.IsNumber(password[i]) && digitOccured == false)
        {
            digitOccured = true;
        }
    }

    for (int i = 0; i < specialChars.Length; i++)
    {
        if (password.IndexOf(specialChars[i]) >= 0 && specialCharsOccured == false)
        {
            specialCharsOccured = true;
        }
    }

    if (!digitOccured)
    {
        extraChars++;
    }
    if (!lowerCaseOccured)
    {
        extraChars++;
    }
    if (!upperCaseOccured)
    {
        extraChars++;
    }
    if (!specialCharsOccured)
    {
        extraChars++;
    }

    var result = 0;

    if (password.Length + extraChars < 6)
    {
        result = extraChars + (6 - password.Length - extraChars);
    }
    else
    {
        result = extraChars;
    }
    return result;
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
