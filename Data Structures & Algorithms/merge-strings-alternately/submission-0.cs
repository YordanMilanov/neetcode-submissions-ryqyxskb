public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int i = 0, j = 0;
        var result = new System.Text.StringBuilder();

        while (i < word1.Length && j < word2.Length)
        {
            result.Append(word1[i]);
            result.Append(word2[j]);
            i++;
            j++;
        }
        while (i < word1.Length)
        {
            result.Append(word1[i]);
            i++;
        }
        while (j < word2.Length)
        {
            result.Append(word2[j]);
            j++;
        }

        return result.ToString();
    }
}