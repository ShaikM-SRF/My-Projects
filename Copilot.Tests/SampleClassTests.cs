using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Copilot;

namespace Copilot.Tests
{
    [TestClass]
    public class SampleClassTests
    {
        #region IsPalindrome_Basic Tests

        [TestMethod]
        public void IsPalindrome_Basic_Simplepalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "racecar";

            // Act
            bool result = SampleClass.IsPalindrome_Basic(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_Basic_NotPalindrome_ReturnsFalse()
        {
            // Arrange
            string input = "hello";

            // Act
            bool result = SampleClass.IsPalindrome_Basic(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPalindrome_Basic_CaseInsensitive_ReturnsTrue()
        {
            // Arrange
            string input = "Madam";

            // Act
            bool result = SampleClass.IsPalindrome_Basic(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_Basic_EmptyString_ReturnsTrue()
        {
            // Arrange
            string input = "";

            // Act
            bool result = SampleClass.IsPalindrome_Basic(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_Basic_NullString_ReturnsTrue()
        {
            // Arrange
            string input = null;

            // Act
            bool result = SampleClass.IsPalindrome_Basic(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_Basic_SingleCharacter_ReturnsTrue()
        {
            // Arrange
            string input = "a";

            // Act
            bool result = SampleClass.IsPalindrome_Basic(input);

            // Assert
            Assert.IsTrue(result);
        }

        #endregion

        #region IsPalindrome_Optimized Tests

        [TestMethod]
        public void IsPalindrome_Optimized_SimplePalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "racecar";

            // Act
            bool result = SampleClass.IsPalindrome_Optimized(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_Optimized_NotPalindrome_ReturnsFalse()
        {
            // Arrange
            string input = "world";

            // Act
            bool result = SampleClass.IsPalindrome_Optimized(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPalindrome_Optimized_CaseInsensitive_ReturnsTrue()
        {
            // Arrange
            string input = "RaceCar";

            // Act
            bool result = SampleClass.IsPalindrome_Optimized(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_Optimized_EvenLengthPalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "noon";

            // Act
            bool result = SampleClass.IsPalindrome_Optimized(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_Optimized_OddLengthPalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "level";

            // Act
            bool result = SampleClass.IsPalindrome_Optimized(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_Optimized_EmptyString_ReturnsTrue()
        {
            // Arrange
            string input = "";

            // Act
            bool result = SampleClass.IsPalindrome_Optimized(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_Optimized_NullString_ReturnsTrue()
        {
            // Arrange
            string input = null;

            // Act
            bool result = SampleClass.IsPalindrome_Optimized(input);

            // Assert
            Assert.IsTrue(result);
        }

        #endregion

        #region IsPalindrome_AlphanumericOnly Tests

        [TestMethod]
        public void IsPalindrome_AlphanumericOnly_PhraseWithSpaces_ReturnsTrue()
        {
            // Arrange
            string input = "A man a plan a canal Panama";

            // Act
            bool result = SampleClass.IsPalindrome_AlphanumericOnly(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_AlphanumericOnly_PhraseWithPunctuation_ReturnsTrue()
        {
            // Arrange
            string input = "A man, a plan, a canal: Panama";

            // Act
            bool result = SampleClass.IsPalindrome_AlphanumericOnly(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_AlphanumericOnly_SentenceWithQuestion_ReturnsTrue()
        {
            // Arrange
            string input = "Was it a car or a cat I saw?";

            // Act
            bool result = SampleClass.IsPalindrome_AlphanumericOnly(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_AlphanumericOnly_NotPalindromeWithSpaces_ReturnsFalse()
        {
            // Arrange
            string input = "hello world";

            // Act
            bool result = SampleClass.IsPalindrome_AlphanumericOnly(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPalindrome_AlphanumericOnly_OnlySpaces_ReturnsTrue()
        {
            // Arrange
            string input = "   ";

            // Act
            bool result = SampleClass.IsPalindrome_AlphanumericOnly(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_AlphanumericOnly_MixedAlphanumeric_ReturnsTrue()
        {
            // Arrange
            string input = "A1B2B1A";

            // Act
            bool result = SampleClass.IsPalindrome_AlphanumericOnly(input);

            // Assert
            Assert.IsTrue(result);
        }

        #endregion

        //#region IsPalindrome_Span Tests

        //[TestMethod]
        //public void IsPalindrome_Span_SimplePalindrome_ReturnsTrue()
        //{
        //    // Arrange
        //    string input = "racecar";

        //    // Act
        //    bool result = SampleClass.IsPalindrome_Span(input.AsSpan());

        //    // Assert
        //    Assert.IsTrue(result);
        //}

        //[TestMethod]
        //public void IsPalindrome_Span_NotPalindrome_ReturnsFalse()
        //{
        //    // Arrange
        //    string input = "test";

        //    // Act
        //    bool result = SampleClass.IsPalindrome_Span(input.AsSpan());

        //    // Assert
        //    Assert.IsFalse(result);
        //}

        //[TestMethod]
        //public void IsPalindrome_Span_CaseInsensitive_ReturnsTrue()
        //{
        //    // Arrange
        //    string input = "ABA";

        //    // Act
        //    bool result = SampleClass.IsPalindrome_Span(input.AsSpan());

        //    // Assert
        //    Assert.IsTrue(result);
        //}

        //[TestMethod]
        //public void IsPalindrome_Span_EmptySpan_ReturnsTrue()
        //{
        //    // Arrange
        //    ReadOnlySpan<char> input = ReadOnlySpan<char>.Empty;

        //    // Act
        //    bool result = SampleClass.IsPalindrome_Span(input);

        //    // Assert
        //    Assert.IsTrue(result);
        //}

        //#endregion

        #region Data-Driven Tests

        [TestMethod]
        [DataRow("racecar", true, DisplayName = "Simple palindrome")]
        [DataRow("hello", false, DisplayName = "Not palindrome")]
        [DataRow("Madam", true, DisplayName = "Case insensitive")]
        [DataRow("noon", true, DisplayName = "Even length palindrome")]
        [DataRow("level", true, DisplayName = "Odd length palindrome")]
        [DataRow("", true, DisplayName = "Empty string")]
        [DataRow("a", true, DisplayName = "Single character")]
        [DataRow("ab", false, DisplayName = "Two different characters")]
        [DataRow("aa", true, DisplayName = "Two same characters")]
        public void IsPalindrome_Optimized_DataDriven_ReturnsExpectedResult(string input, bool expected)
        {
            // Act
            bool result = SampleClass.IsPalindrome_Optimized(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("A man, a plan, a canal: Panama", true)]
        [DataRow("race a car", false)]
        [DataRow("Was it a car or a cat I saw?", true)]
        [DataRow("No 'x' in Nixon", true)]
        [DataRow("Hello World", false)]
        public void IsPalindrome_AlphanumericOnly_DataDriven_ReturnsExpectedResult(string input, bool expected)
        {
            // Act
            bool result = SampleClass.IsPalindrome_AlphanumericOnly(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        #endregion

        #region Edge Cases and Special Characters

        [TestMethod]
        public void IsPalindrome_Optimized_WithNumbers_ReturnsTrue()
        {
            // Arrange
            string input = "12321";

            // Act
            bool result = SampleClass.IsPalindrome_Optimized(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_Optimized_UnicodeCharacters_WorksCorrectly()
        {
            // Arrange
            string input = "héh";

            // Act
            bool result = SampleClass.IsPalindrome_Optimized(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_Optimized_LongString_PerformsWell()
        {
            // Arrange
            string halfString = new string('a', 5000);
            string input = halfString + new string('a', 5000);

            // Act
            bool result = SampleClass.IsPalindrome_Optimized(input);

            // Assert
            Assert.IsTrue(result);
        }

        #endregion
    }
}