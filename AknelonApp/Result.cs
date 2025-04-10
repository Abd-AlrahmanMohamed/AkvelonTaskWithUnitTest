using System.Text;
using System.Text.RegularExpressions;

namespace AkvelonApp
{
  
        public class Result
        {
            public string FinalOutput { get; }
            public int Count { get; }

            public Result(string finalOutput, int count)
            {
                FinalOutput = finalOutput;
                Count = count;
            }

        public static Result GetOutput(string input)
        {
            if (input is null)
                throw new ArgumentNullException(nameof(input));

            if (Regex.IsMatch(input, @"[^a-zA-Z\s]"))
            {
                Console.WriteLine("Only alphabetic words are allowed.");
                return new Result(string.Empty, 0);
            }

            var matches = Regex.Matches(input, @"\b[a-zA-Z]+\b", RegexOptions.Compiled);
            var finalOutput = new StringBuilder();
            int wordCount = 0;

            foreach (Match match in matches)
            {
                wordCount++;
                bool isThird = IsMultiple(wordCount, 3);
                bool isFifth = IsMultiple(wordCount, 5);

                if (isThird && isFifth)
                    finalOutput.Append("FizzBuzz ");
                else if (isThird)
                    finalOutput.Append("Fizz ");
                else if (isFifth)
                    finalOutput.Append("Buzz ");
                else
                    finalOutput.Append(match.Value + " ");
            }

            return new Result(finalOutput.ToString().Trim(), wordCount);
        }

        private static bool IsMultiple(int number, int divisor)
            {
                return number != 0 && number % divisor == 0;
            }
        }
}


