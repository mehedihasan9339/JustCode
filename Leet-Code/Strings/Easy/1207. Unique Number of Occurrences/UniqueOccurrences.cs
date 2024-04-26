public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        List<int> occuranceCount = new List<int>();

        bool result = true;

        foreach (int i in arr.Distinct())
        {
            int occurances = arr.Where(x => x == i).Count();
            if (occuranceCount.IndexOf(occurances) >= 0)
            {
                return false;
            }
            else
            {
                occuranceCount.Add(occurances);
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
