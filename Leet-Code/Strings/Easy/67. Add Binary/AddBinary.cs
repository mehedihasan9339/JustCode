public class Solution {
    public string AddBinary(string a, string b) {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;
        StringBuilder result = new StringBuilder();

        // Traverse both strings from right to left
        while (i >= 0 || j >= 0 || carry > 0) {
            int sum = carry;

            if (i >= 0) {
                sum += a[i] - '0';  // Convert char to int (0 or 1)
                i--;
            }

            if (j >= 0) {
                sum += b[j] - '0';  // Convert char to int (0 or 1)
                j--;
            }

            carry = sum / 2;  // Carry is either 0 or 1
            result.Append(sum % 2);  // The current bit is sum % 2 (either 0 or 1)
        }

        // Reverse the result string as we built it backwards
        char[] resultArray = result.ToString().ToCharArray();
        Array.Reverse(resultArray);

        return new string(resultArray);
    }
}