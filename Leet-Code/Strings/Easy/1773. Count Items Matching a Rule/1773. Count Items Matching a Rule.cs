public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int result = 0;
        int index = -1;

        switch (ruleKey)
        {
            case "type":
                index = 0;
                break;
            case "color":
                index = 1;
                break;
            case "name":
                index = 2;
                break;
            default:
                throw new ArgumentException("Invalid ruleKey");
        }

        foreach (var item in items)
        {
            if (item.Count > index && item[index] == ruleValue)
            {
                result++;
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
