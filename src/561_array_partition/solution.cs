public class Solution {
    public int ArrayPairSum(int[] nums) {
        Array.Sort(nums);

        int maximizedSum = 0;
        for (int i = 0; i < nums.Length - 1; i = i + 2)
        {
            maximizedSum += Math.Min(nums[i], nums[i + 1]);
        }

        return maximizedSum;
    }
}
