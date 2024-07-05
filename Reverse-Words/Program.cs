using System;

namespace Reverse_Words
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = "csharp is programming language";
            string output = ReverseWords(input);
            Console.WriteLine($"Output: {output}");

            string input1 = "Reverse the words in this sentence";
            string output2 = ReverseWords(input1);
            Console.WriteLine($"Output2: {output2}");

            string input2 = "challenges and data structures";
            string output3 = ReverseWords(input2);
            Console.WriteLine($"Output3: {output3}");
        }

        public static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
