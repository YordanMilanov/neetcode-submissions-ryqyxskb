public class Solution {
    public string MinWindow(string s, string t) {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            return "";

        var need = new Dictionary<char, int>();

        // броим символите от t
        foreach (char c in t)
        {
            need[c] = need.GetValueOrDefault(c, 0) + 1;
        }

        int left = 0;
        int remaining = t.Length;

        int minLen = int.MaxValue;
        int start = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];

            // expand
            if (need.ContainsKey(c))
            {
                need[c]--;

                if (need[c] >= 0)
                    remaining--;
            }

            // shrink
            while (remaining == 0)
            {
                // update result
                if (right - left + 1 < minLen)
                {
                    minLen = right - left + 1;
                    start = left;
                }

                char leftChar = s[left];

                if (need.ContainsKey(leftChar))
                {
                    need[leftChar]++;

                    if (need[leftChar] > 0)
                        remaining++;
                }

                left++;
            }
        }

        return minLen == int.MaxValue 
            ? "" 
            : s.Substring(start, minLen);
    }
}