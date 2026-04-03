public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        var maxArea = 0;

        while(left < right) {
            var height = Math.Min(heights[left], heights[right]);
            var width = right - left;

            var area = width * height;
            maxArea = Math.Max(area, maxArea);

            if (heights[left] < heights[right]) {
                left++;
            } else {
                right--;
            }
        }

        return maxArea;
    }
}
