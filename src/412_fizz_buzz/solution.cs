public class Solution {
    public IList<string> FizzBuzz(int n) {
        string[] answers = new string[n];

        for (int i = 1; i <= n; i++)
        {
            var divisibleBy3 = i % 3 == 0;
            var divisibleBy5 = i % 5 == 0;
            if (divisibleBy3 && divisibleBy5)
            {
                answers[i - 1] = "FizzBuzz";
            }
            else if (divisibleBy3)
            {
                answers[i - 1] = "Fizz";
            }
            else if (divisibleBy5)
            {
                answers[i - 1] = "Buzz";
            }
            else
            {
                answers[i - 1] = i.ToString();
            }
        }

        return answers;
    }
}
