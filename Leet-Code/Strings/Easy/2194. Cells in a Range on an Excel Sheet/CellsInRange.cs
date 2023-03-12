public class Solution {
    public IList<string> CellsInRange(string s) {
        char fcol = Convert.ToChar(s.Substring(0, 1));
        var frow = Convert.ToInt32(s.Substring(1, 1));
        char lcol = Convert.ToChar(s.Substring(3, 1));
        var lrow = Convert.ToInt32(s.Substring(4, 1));

        var cells = new List<string>();

        for (int i = (int)fcol; i <= (int)lcol; i++)
        {
            for (int j = frow; j <= lrow; j++)
            {
                cells.Add((char)i + j.ToString());
            }
        }

        return cells;
    }
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
