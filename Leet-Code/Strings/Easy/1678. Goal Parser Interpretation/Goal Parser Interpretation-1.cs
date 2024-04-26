public class Solution {
    public string Interpret(string command) {
        return command.Replace("()", "o").Replace("(al)", "al").Replace("G", "G");
    }
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
