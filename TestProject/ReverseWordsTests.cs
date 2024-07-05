using Xunit;
using Reverse_Words;
using Microsoft.VisualStudio.TestPlatform.TestHost; // Ensure this is correct

namespace Reverse_Words.Tests
{
    public class ReverseWordsTests
    {
        [Fact]
        public void Test_ReverseWords_Case011()
        {
            string input = "csharp is programming language";
            string expected = "language programming is csharp";
            string result = Program.ReverseWords(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_ReverseWords_Case02()
        {
            string input = "Reverse the words in this sentence";
            string expected = "sentence this in words the Reverse";
            string result = Program.ReverseWords(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_ReverseWords_Case03()
        {
            string input = "challenges and data structures";
            string expected = "structures data and challenges";
            string result = Program.ReverseWords(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_ReverseWords_EmptyString()
        {
            string input = "";
            string expected = "";
            string result = Program.ReverseWords(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_ReverseWords_SingleWord()
        {
            string input = "csharp";
            string expected = "csharp";
            string result = Program.ReverseWords(input);
            Assert.Equal(expected, result);
        }
    }
}
