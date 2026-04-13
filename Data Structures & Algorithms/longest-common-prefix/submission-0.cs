public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var sb = new StringBuilder();

        for(int i = 0; i < strs[0].Length; i++) {
            var checkChar = strs[0][i];
            for(int j = 0; j < strs.Length; j++) {
                if (i >= strs[j].Length || strs[j][i] != checkChar) {
                    return sb.ToString();
                }
            }
                    sb.Append(checkChar);

        }
        return sb.ToString();
    }
}