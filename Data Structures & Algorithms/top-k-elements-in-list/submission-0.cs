public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
    var dictionary = new Dictionary<int, int>();

    foreach (var num in nums)
    {
        if (!dictionary.ContainsKey(num))
        {
            dictionary[num] = 1;
        }
        else
        {
            dictionary[num]++;
        }
    }

    var topK = dictionary
        .OrderByDescending(pair => pair.Value)
        .Take(k)
        .Select(pair => pair.Key)
        .ToArray();

    return topK;
    }
}
