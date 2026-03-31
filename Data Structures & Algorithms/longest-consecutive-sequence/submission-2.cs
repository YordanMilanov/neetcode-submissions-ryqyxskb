public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numbers = nums.ToHashSet();

        int longest = 0;

        foreach(int num in numbers) {

            if(!numbers.Contains(num - 1)){
                int currentNum = num;
                int currentStreak = 1;

                while(numbers.Contains(currentNum + 1)) {
                    currentNum++;
                    currentStreak++;
                }

                longest = Math.Max(longest, currentStreak);
            }
        }

        return longest;
    }
}
