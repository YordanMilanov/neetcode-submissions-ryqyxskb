public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();

        foreach (var word in strs) {
            // Step 1: sort letters in word
            var sortedWord = String.Concat(word.OrderBy(c => c));

            // Step 2: add to dictionary
            if (!map.ContainsKey(sortedWord)) {
                map[sortedWord] = new List<string>();
            }
            map[sortedWord].Add(word);
        }

        // Step 3: return grouped anagrams
        return map.Values.ToList();
    }
}

