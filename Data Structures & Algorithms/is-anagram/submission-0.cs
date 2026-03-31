public class Solution {
    public bool IsAnagram(string s, string t) {
        
    if (s.Length != t.Length)
        return false;

    var map = new Dictionary<char, int>();

    foreach (char c in s)
    {
        if (!map.ContainsKey(c))
            map[c] = 0;
        map[c]++;
    }

    foreach (char c in t)
    {
        if (!map.ContainsKey(c))
            return false;

        map[c]--;

        if (map[c] == 0)
            map.Remove(c);
    }

    return map.Count == 0;
    }
}
