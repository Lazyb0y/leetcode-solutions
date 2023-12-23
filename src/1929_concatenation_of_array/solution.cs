public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] result = new int[nums.Length + nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = result[i + nums.Length] = nums[i];
        }

        return result;
    }
}
