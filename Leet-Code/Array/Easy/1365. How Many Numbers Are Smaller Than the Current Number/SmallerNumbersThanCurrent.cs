public int[] SmallerNumbersThanCurrent(int[] nums)
{
    var result = new int[nums.Length];
    int count = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        foreach (var item in nums)
        {
            if (nums[i] > item)
            {
                count++;
            }
        }
        result[i] = count;
        count = 0;
    }

    return result;
}

/*
    --Md Mehedi Hasan
    --http://linkedin.com/in/mehedi9339
    --http://profileofmehedi.xyz
*/
