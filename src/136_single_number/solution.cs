public class Solution {
    public int SingleNumber(int[] nums) {
        int singleNumber = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            singleNumber ^= nums[i];
        }

        return singleNumber;
    }
}
