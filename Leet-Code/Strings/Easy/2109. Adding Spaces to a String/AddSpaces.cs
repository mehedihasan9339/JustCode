public class Solution {
    public string AddSpaces(string s, int[] spaces) {
         List<char> result = new List<char>();
        int spaceIndex = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (spaceIndex < spaces.Length && i == spaces[spaceIndex])
            {
                result.Add(' ');
                spaceIndex++;
            }
            result.Add(s[i]);
        }

        return new string(result.ToArray());
    }
}