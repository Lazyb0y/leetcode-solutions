public class Solution {
    public int MinOperations(string s) {
        int count0 = 0;
        int count1 = 0;
        bool evenIndex = true;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != (evenIndex ? '0' : '1'))
            {
                count0++;
            }

            if (s[i] != (evenIndex ? '1' : '0'))
            {
                count1++;
            }

            evenIndex = !evenIndex;
        }

        return count0 < count1 ? count0 : count1;
    }
}
