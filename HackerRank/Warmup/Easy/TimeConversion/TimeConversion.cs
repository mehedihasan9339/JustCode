public static string timeConversion(string s)
{
    var output = Convert.ToDateTime(s);
    var result = output.ToString("HH:mm:ss");
    return result;
}