public class Solution {
    public string DecodeMessage(string key, string message) {
        string firstOccuranceKey = "";

        foreach (var k in key.Replace(" ", ""))
        {
            if (firstOccuranceKey.IndexOf(k) < 0)
            {
                firstOccuranceKey += k;
            }
        }

        string engLetters = "abcdefghijklmnopqrstuvwxyz";

        string decodedMessage = "";
        
        foreach (var item in message)
        {
            if (item == ' ')
            {
                decodedMessage += ' ';
            }
            else
            {
                int indexInKey = firstOccuranceKey.IndexOf(item);
                decodedMessage += engLetters[indexInKey];
            }
        }

        return decodedMessage;
    }
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
