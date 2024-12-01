public class Solution
{
    public int LengthOfLastWord(string s)
    {
        if (s == "" || s == null)
        {
            return 0;
        }
        string[] words = s.Trim().Split(' ');

        string lastWord = words[words.Length - 1].Trim();

        return lastWord.Length;
    }
}