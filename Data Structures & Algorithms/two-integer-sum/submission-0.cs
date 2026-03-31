public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++) {
            int needed = target - nums[i];
             if (seen.ContainsKey(needed)) {
            // found the pair
                return new int[] { seen[needed], i };
            }
        // store the current number with its index
        seen[nums[i]] = i;
        }
    return new int[0];
    }
}
