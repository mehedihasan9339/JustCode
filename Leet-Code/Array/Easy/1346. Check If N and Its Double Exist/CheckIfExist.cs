public class Solution {
    public bool CheckIfExist(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (i != j)
                {
                    if (arr[i] == arr[j] * 2)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}