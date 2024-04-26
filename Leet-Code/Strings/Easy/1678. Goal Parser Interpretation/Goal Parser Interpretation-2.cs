public class Solution {
    public string Interpret(string command) {
        var result = "";

        for (int i = 0; i < command.Length; i++)
        {
            if (command[i] == '(' || command[i] == ')')
            {
                if (command[i] == '(' && command[i + 1] == ')')
                {
                    result += 'o';
                }
            }
            else
            {
                result += command[i];
            }
        }

        return result;
    }
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
