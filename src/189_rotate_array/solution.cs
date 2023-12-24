public class Solution {
    public void Rotate(int[] nums, int k) {
        int z = k % nums.Length;
        if (z == 0)
        {
            return;
        }

        int[] temp = new int[z];

        for (int i = 0, j = nums.Length - z; i < z; i++, j++)
        {
            temp[i] = nums[j];
        }

        for (int i = nums.Length - 1; i - z >= 0; i--)
        {
            nums[i] = nums[i - z];
        }

        for (int i = 0; i < z; i++)
        {
            nums[i] = temp[i];
        }
    }
}
