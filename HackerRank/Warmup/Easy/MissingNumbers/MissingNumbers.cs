    public static List<int> missingNumbers(List<int> arr, List<int> brr)
    {
        
        brr.Sort();

        for (int i = 0; i < arr.Count; i++)
        {
            brr.Remove(arr[i]);
        }

        return brr;
    }
